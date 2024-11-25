using ExpressNet.Ctx;
using ExpressNet.Di;
using ExpressNet.Flow.Abstractions;
using ExpressNet.Middlewares;

namespace ExpressNet.Flow.Handlers
{
    /// <summary>
    /// Handles the execution of middleware in a pipeline.
    /// </summary>
    internal sealed class MiddlewareHandler : ChainHandler<Context>
    {
        private readonly Pipeline _pipeline;
        private readonly ServiceScope _services;

        /// <summary>
        /// Initializes a new instance of the <see cref="MiddlewareHandler"/> class with the specified pipeline and service scope.
        /// </summary>
        /// <param name="pipeline">The pipeline to execute middleware.</param>
        /// <param name="services">The service scope for resolving dependencies.</param>
        internal MiddlewareHandler(Pipeline pipeline, ServiceScope services)
        {
            _pipeline = pipeline;
            _services = services;
        }

        /// <summary>
        /// Handles the context by invoking the middleware pipeline asynchronously.
        /// </summary>
        /// <param name="context">The context to handle.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async Task HandleAsync(Context context)
        {
            await _pipeline.InvokeMiddlewareAsync(0, context, _services);
            if (context.Response.ContentLength >= 0)
            {
                await base.HandleAsync(context);
            }
        }
    }
}
