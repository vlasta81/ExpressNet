using ExpressNet.Configs;
using System.Net;
using System.Security.Principal;

namespace ExpressNet.Ctx
{
    /// <summary>
    /// Represents the context for an HTTP request and response.
    /// </summary>
    public sealed class Context
    {
        private readonly HttpListenerContext _rawContext;

        /// <summary>
        /// Gets the configuration settings for the application, server, static files, and custom configurations.
        /// </summary>
        public readonly Configuration Configuration;

        /// <summary>
        /// Gets the request context containing details about the HTTP request.
        /// </summary>
        public readonly ContextRequest Request;

        /// <summary>
        /// Gets the response context containing details about the HTTP response.
        /// </summary>
        public readonly ContextResponse Response;

        /// <summary>
        /// Gets the data context for storing and retrieving data associated with the current context.
        /// </summary>
        public readonly ContextData Data;

        /// <summary>
        /// Gets or sets the user principal associated with the current context.
        /// </summary>
        public IPrincipal? User;

        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class with the specified HTTP listener context and configuration.
        /// </summary>
        /// <param name="context">The HTTP listener context.</param>
        /// <param name="configuration">The configuration settings.</param>
        public Context(HttpListenerContext context, Configuration configuration)
        {
            _rawContext = context;
            Configuration = configuration;
            Request = new ContextRequest(context.Request);
            Response = new ContextResponse(context.Response);
            Data = new ContextData();
            User = context.User;
        }

        /// <summary>
        /// Gets the raw HTTP listener context.
        /// </summary>
        /// <returns>The raw HTTP listener context.</returns>
        internal HttpListenerContext GetHttpContext()
        {
            return _rawContext;
        }
    }

}
