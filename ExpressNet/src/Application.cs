using ExpressNet.Http;
using ExpressNet.Di;
using ExpressNet.Attributes;
using System.Reflection;
using ExpressNet.Configs;
using ExpressNet.Middlewares;
using ExpressNet.Middlewares.Contracts;
using System.Net;
using ExpressNet.Routing;
using ExpressNet.Routing.Contracts;
using ExpressNet.Flow;
using ExpressNet.Flow.Handlers;
using ExpressNet.Ctx;

namespace ExpressNet
{
    /// <summary>
    /// Represents the main application class responsible for configuring and running the server.
    /// </summary>
    public sealed class Application
    {
        private readonly Configuration _configuration;
        private readonly Server _server;
        private readonly Services _services;
        private readonly Pipeline _pipeline;
        private readonly Router _router;

        /// <summary>
        /// Initializes a new instance of the <see cref="Application"/> class with the specified configuration action.
        /// </summary>
        /// <param name="configure">The action to configure the application.</param>
        public Application(Action<Configurator> configure)
        {
            Configurator configurator = new Configurator();
            configure.Invoke(configurator);
            _configuration = new Configuration(configurator);
            _server = new Server();
            _services = new Services();
            _pipeline = new Pipeline();
            _router = new Router();
        }

        /// <summary>
        /// Registers a service with the specified factory method and lifetime.
        /// </summary>
        /// <typeparam name="TService">The type of the service to register.</typeparam>
        /// <param name="factory">The factory method used to create the service instance.</param>
        /// <param name="lifetime">The lifetime of the service.</param>
        public void Register<TService>(Func<Services, TService> factory, ServiceLifetime lifetime)
        {
            _services.Register(factory, lifetime);
        }

        /// <summary>
        /// Adds a middleware to the pipeline.
        /// </summary>
        /// <typeparam name="TMiddleware">The type of the middleware to add.</typeparam>
        public void Use<TMiddleware>() where TMiddleware : IMiddleware
        {
            Type middlewareType = typeof(TMiddleware);
            _pipeline.Use(middlewareType);
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
            _router.AddRoute(endpointAttribute.Route, endpointType);
        }

        /// <summary>
        /// Adds a group of endpoints to the router.
        /// </summary>
        /// <typeparam name="TGroupEndpoints">The type of the group of endpoints to add.</typeparam>
        public void AddRange<TGroupEndpoints>() where TGroupEndpoints : IGroupEndpoints, new()
        {
            TGroupEndpoints endpoints = new TGroupEndpoints();
            endpoints.AddEndpoints(_router);
        }

        /// <summary>
        /// Runs the application asynchronously with the specified URL.
        /// </summary>
        /// <param name="url">The URL to listen on.</param>
        public async Task RunAsync(string url)
        {
            _server.Configure(_configuration.Server);
            _server.AddPrefix(url);
            _server.Start();
            while (true)
            {
                HttpListenerContext context = await _server.GetContextAsync();
                ServiceScope services = _services.CreateScope();
                Context ctx = new Context(context, _configuration);
                _ = ProcessHttpRequest(_configuration, ctx, services);
            }
        }

        /// <summary>
        /// Processes an HTTP request asynchronously.
        /// </summary>
        /// <param name="configuration">The configuration settings.</param>
        /// <param name="context">The context for the current request and response.</param>
        /// <param name="services">The service scope for resolving dependencies.</param>
        private async Task ProcessHttpRequest(Configuration configuration, Context context, ServiceScope services)
        {
            try
            {
                Chain chain = new Chain();
                chain.SetNext(new StaticFilesHandler(configuration));
                Type? endpoint = _router.MatchEndpoint(context);
                chain.SetNext(new NullEndpointHandler(endpoint));
                chain.SetNext(new MiddlewareHandler(_pipeline, services));
                chain.SetNext(new AuthenticationHandler(endpoint!, services));
                chain.SetNext(new EndpointHandler(endpoint!, services));
                await chain.ExecuteAsync(context);
            }
            catch (Exception ex)
            {
                context.Response.SetStatusCode(500);
                await context.Response.WriteAsTextAsync($"Internal Server Error: {ex.Message}");
            }
            finally
            {
                context.Response.Close();
            }
        }
    }
}
