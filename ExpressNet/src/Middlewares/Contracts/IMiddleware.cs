using ExpressNet.Ctx;

namespace ExpressNet.Middlewares.Contracts
{
    /// <summary>
    /// Defines a middleware component that can be used to handle HTTP requests and responses.
    /// </summary>
    public interface IMiddleware
    {
        /// <summary>
        /// Invokes the middleware with the given context and the next middleware in the pipeline.
        /// </summary>
        /// <param name="context">The context for the current HTTP request and response.</param>
        /// <param name="next">A function that invokes the next middleware in the pipeline.</param>
        /// <returns>A task that represents the completion of the middleware execution.</returns>
        Task InvokeAsync(Context context, Func<Context, Task> next);
    }
}
