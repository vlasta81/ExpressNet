
namespace ExpressNet.Flow.Contracts
{
    /// <summary>
    /// Defines a handler in a chain of responsibility pattern.
    /// </summary>
    /// <typeparam name="Context">The type of the context.</typeparam>
    internal interface IChainHandler<Context>
    {
        /// <summary>
        /// Sets the next handler in the chain.
        /// </summary>
        /// <param name="nextHandler">The next handler.</param>
        internal void SetNext(IChainHandler<Context> nextHandler);

        /// <summary>
        /// Handles the context asynchronously.
        /// </summary>
        /// <param name="context">The context to handle.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        internal Task HandleAsync(Context context);
    }
}
