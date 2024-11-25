using ExpressNet.Flow.Contracts;

namespace ExpressNet.Flow.Abstractions
{
    /// <summary>
    /// Represents an abstract base class for a handler in a chain of responsibility pattern.
    /// </summary>
    /// <typeparam name="Context">The type of the context.</typeparam>
    internal abstract class ChainHandler<Context> : IChainHandler<Context>
    {
        private IChainHandler<Context>? _nextHandler;

        /// <summary>
        /// Sets the next handler in the chain.
        /// </summary>
        /// <param name="nextHandler">The next handler.</param>
        public void SetNext(IChainHandler<Context> nextHandler)
        {
            _nextHandler = nextHandler;
        }

        /// <summary>
        /// Handles the context asynchronously. If there is a next handler, it delegates the handling to the next handler.
        /// </summary>
        /// <param name="context">The context to handle.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public virtual async Task HandleAsync(Context context)
        {
            if (_nextHandler is not null)
            {
                await _nextHandler.HandleAsync(context);
            }
        }
    }
}
