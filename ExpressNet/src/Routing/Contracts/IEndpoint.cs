using ExpressNet.Ctx;

namespace ExpressNet.Routing.Contracts
{
    /// <summary>
    /// Represents an endpoint that handles HTTP requests asynchronously.
    /// </summary>
    public interface IEndpoint
    {
        /// <summary>
        /// Handles the HTTP request asynchronously.
        /// </summary>
        /// <param name="context">The context for the HTTP request and response.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task HandleAsync(Context context);
    }
}
