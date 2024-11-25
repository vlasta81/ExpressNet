
namespace ExpressNet.Attributes
{
    /// <summary>
    /// Specifies that a class is an endpoint with a specific HTTP method and route.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class EndpointAttribute : Attribute
    {
        /// <summary>
        /// Gets the HTTP method for the endpoint.
        /// </summary>
        public string Method { get; }

        /// <summary>
        /// Gets the route for the endpoint.
        /// </summary>
        public string Route { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointAttribute"/> class with the specified HTTP method and route.
        /// </summary>
        /// <param name="httpMethod">The HTTP method for the endpoint (e.g., GET, POST).</param>
        /// <param name="route">The route for the endpoint.</param>
        public EndpointAttribute(string httpMethod, string route)
        {
            Method = httpMethod.ToUpper();
            Route = route;
        }
    }
}
