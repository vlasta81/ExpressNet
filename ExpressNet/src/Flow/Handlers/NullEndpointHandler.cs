using ExpressNet.Ctx;
using ExpressNet.Flow.Abstractions;

namespace ExpressNet.Flow.Handlers
{
    /// <summary>
    /// Represents a handler that processes requests with a null endpoint.
    /// </summary>
    internal sealed class NullEndpointHandler : ChainHandler<Context>
    {
        private readonly Type? _endpoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="NullEndpointHandler"/> class with the specified endpoint type.
        /// </summary>
        /// <param name="endpoint">The endpoint type.</param>
        internal NullEndpointHandler(Type? endpoint)
        {
            _endpoint = endpoint;
        }

        /// <summary>
        /// Handles the context asynchronously. If the endpoint is null, sets the response status code to 404 and writes "Not Found" to the response.
        /// Otherwise, delegates the handling to the next handler in the chain.
        /// </summary>
        /// <param name="context">The context to handle.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async Task HandleAsync(Context context)
        {
            if (_endpoint is null)
            {
                context.Response.SetStatusCode(404);
                await context.Response.WriteAsTextAsync("Not Found");
            }
            else
            {
                await base.HandleAsync(context);
            }
        }
    }
}
