using ExpressNet.Ctx;
using ExpressNet.Di;
using ExpressNet.Flow.Abstractions;
using ExpressNet.Routing.Contracts;

namespace ExpressNet.Flow.Handlers
{
    /// <summary>
    /// Represents a handler for an endpoint in a chain of responsibility pattern.
    /// </summary>
    internal sealed class EndpointHandler : ChainHandler<Context>
    {
        private readonly Type _endpoint;
        private readonly ServiceScope _services;

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointHandler"/> class with the specified endpoint type and service scope.
        /// </summary>
        /// <param name="endpoint">The type of the endpoint to handle.</param>
        /// <param name="services">The service scope for resolving dependencies.</param>
        internal EndpointHandler(Type endpoint, ServiceScope services)
        {
            _endpoint = endpoint;
            _services = services;
        }

        /// <summary>
        /// Handles the context asynchronously by creating an instance of the endpoint and invoking its handle method.
        /// </summary>
        /// <param name="context">The context to handle.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the endpoint instance cannot be created.</exception>
        public override async Task HandleAsync(Context context)
        {
            IEndpoint? endpointInstance = Activator.CreateInstance(_endpoint, _services) as IEndpoint;
            ArgumentNullException.ThrowIfNull(endpointInstance, nameof(endpointInstance));
            await endpointInstance.HandleAsync(context);
        }
    }
}
