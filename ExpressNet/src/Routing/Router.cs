using ExpressNet.Attributes;
using ExpressNet.Ctx;
using ExpressNet.Routing.Contracts;
using System.Collections.Concurrent;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ExpressNet.Routing
{
    /// <summary>
    /// Represents a router that handles the registration and matching of routes to endpoints.
    /// </summary>
    public sealed class Router
    {
        private readonly RouteNode _root = new RouteNode();

        /// <summary>
        /// Adds a route to the router with the specified route template and handler type.
        /// </summary>
        /// <param name="routeTemplate">The route template to add.</param>
        /// <param name="handler">The handler type for the route.</param>
        internal void AddRoute(string routeTemplate, Type handler)
        {
            string[] segments = routeTemplate.Split('/').Where(s => !string.IsNullOrEmpty(s)).ToArray();
            RouteNode currentNode = _root;
            foreach (string segment in segments)
            {
                (string Segment, RouteParameter? Parameter) parsedSegment = ParseSegment(segment);

                if (!currentNode.Children.ContainsKey(parsedSegment.Segment))
                {
                    currentNode.Children[parsedSegment.Segment] = new RouteNode
                    {
                        Segment = parsedSegment.Segment,
                        Parameter = parsedSegment.Parameter,
                    };
                }
                currentNode = currentNode.Children[parsedSegment.Segment];
            }
            currentNode.Endpoint = handler;
        }

        /// <summary>
        /// Adds an endpoint to the router.
        /// </summary>
        /// <typeparam name="TEndpoint">The type of the endpoint to add.</typeparam>
        public void Add<TEndpoint>() where TEndpoint : IEndpoint
        {
            Type endpointType = typeof(TEndpoint);
            EndpointAttribute? endpointAttribute = endpointType.GetCustomAttribute<EndpointAttribute>();
            ArgumentNullException.ThrowIfNull(endpointAttribute, nameof(endpointAttribute));
            AddRoute(endpointAttribute.Route, endpointType);
        }

        /// <summary>
        /// Parses a route segment and returns the segment and its parameter, if any.
        /// </summary>
        /// <param name="segment">The route segment to parse.</param>
        /// <returns>A tuple containing the segment and its parameter, if any.</returns>
        private (string Segment, RouteParameter? Parameter) ParseSegment(string segment)
        {
            Match match = Regex.Match(segment, @"^\<(?<name>\w+):(?<type>\w+)\>$");
            if (match.Success)
            {
                string name = match.Groups["name"].Value;
                string type = match.Groups["type"].Value.ToLower();
                return (name, new RouteParameter
                {
                    Name = name,
                    Type = type
                });
            }
            return (segment, null);
        }

        /// <summary>
        /// Splits a URL path into segments.
        /// </summary>
        /// <param name="urlPath">The URL path to split.</param>
        /// <returns>An array of segments.</returns>
        private string[] GetSegments(string urlPath)
        {
            return urlPath.Split('/').Where(s => !string.IsNullOrEmpty(s)).ToArray();
        }

        /// <summary>
        /// Matches an endpoint based on the context.
        /// </summary>
        /// <param name="context">The context containing the request information.</param>
        /// <returns>The matched endpoint type, or null if no match is found.</returns>
        internal Type? MatchEndpoint(Context context)
        {
            string[] segments = GetSegments(context.Request.Url!.AbsolutePath);
            ConcurrentDictionary<string, object> parameters = new ConcurrentDictionary<string, object>();
            RouteNode currentNode = _root;
            foreach (string segment in segments)
            {
                RouteNode matchedChild = FindMatchingChild(currentNode, segment);
                if (matchedChild == null) return null;
                if (matchedChild.Parameter != null)
                {
                    object? convertedValue = matchedChild.Parameter.Convert(segment);
                    if (convertedValue == null) return null;
                    parameters[matchedChild.Parameter.Name] = convertedValue;
                }
                currentNode = matchedChild;
            }
            if (currentNode.Endpoint == null) return null;
            EndpointAttribute? endpointAttribute = currentNode.Endpoint.GetCustomAttribute<EndpointAttribute>();
            ArgumentNullException.ThrowIfNull(endpointAttribute, nameof(endpointAttribute));
            if (endpointAttribute.Method.ToUpper() != context.Request.HttpMethod.ToUpper()) return null;
            context.Request.Params = new ContextParams(parameters);
            return currentNode.Endpoint;
        }

        /// <summary>
        /// Finds a matching child node for a given segment.
        /// </summary>
        /// <param name="parent">The parent node to search within.</param>
        /// <param name="segment">The segment to match.</param>
        /// <returns>The matching child node, or null if no match is found.</returns>
        private RouteNode FindMatchingChild(RouteNode parent, string segment)
        {
            if (parent.Children.ContainsKey(segment))
                return parent.Children[segment];

            return parent.Children
                .FirstOrDefault(child => child.Value.Parameter != null)
                .Value;
        }

        /// <summary>
        /// Represents a node in the route tree.
        /// </summary>
        private class RouteNode
        {
            /// <summary>
            /// Gets or sets the segment of the route.
            /// </summary>
            public string Segment { get; set; }
            /// <summary>
            /// Gets or sets the parameter associated with the segment, if any.
            /// </summary>
            public RouteParameter? Parameter { get; set; }
            /// <summary>
            /// Gets the children of the node.
            /// </summary>
            public ConcurrentDictionary<string, RouteNode> Children { get; } = new ConcurrentDictionary<string, RouteNode>();
            /// <summary>
            /// Gets or sets the endpoint associated with the node.
            /// </summary>
            public Type? Endpoint { get; set; }
        }

        /// <summary>
        /// Represents a parameter in a route segment.
        /// </summary>
        private class RouteParameter
        {
            /// <summary>
            /// Gets or sets the name of the parameter.
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// Gets or sets the type of the parameter.
            /// </summary>
            public string Type { get; set; }

            /// <summary>
            /// Converts a string value to the parameter's type.
            /// </summary>
            /// <param name="value">The value to convert.</param>
            /// <returns>The converted value, or null if the conversion fails.</returns>
            public object? Convert(string value)
            {
                return this.Type switch
                {
                    "int" => int.Parse(value),
                    "string" => value,
                    "bool" => bool.Parse(value),
                    "double" => double.Parse(value),
                    _ => throw new NotSupportedException($"Unsupported parameter type: {value}"),
                };
            }
        }
    }

}
