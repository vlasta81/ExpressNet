using ExpressNet.Ctx;
using ExpressNet.Flow.Contracts;

namespace ExpressNet.Flow
{
    /// <summary>
    /// Represents a chain of responsibility pattern for handling HTTP request and response contexts.
    /// </summary>
    internal sealed class Chain
    {
        private IChainHandler<Context>? _chain;
        private IChainHandler<Context>? _tempChain;

        /// <summary>
        /// Sets the next handler in the chain.
        /// </summary>
        /// <typeparam name="TChain">The type of the handler.</typeparam>
        /// <param name="handler">The handler to set as the next in the chain.</param>
        public void SetNext<TChain>(TChain handler) where TChain : IChainHandler<Context>
        {
            if (_chain is null)
            {
                _chain = handler;
                _tempChain = handler;
            }
            else
            {
                _tempChain?.SetNext(handler);
                _tempChain = handler;
            }
        }

        /// <summary>
        /// Sets the next handler in the chain by creating a new instance of the specified handler type.
        /// </summary>
        /// <typeparam name="TChain">The type of the handler.</typeparam>
        public void SetNext<TChain>() where TChain : IChainHandler<Context>, new()
        {
            TChain handler = new TChain();
            if (_chain is null)
            {
                _chain = handler;
                _tempChain = handler;
            }
            else
            {
                _tempChain?.SetNext(handler);
                _tempChain = handler;
            }
        }

        /// <summary>
        /// Executes the chain of handlers asynchronously.
        /// </summary>
        /// <param name="context">The context to handle.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task ExecuteAsync(Context context)
        {
            if (_chain is not null)
            {
                await _chain.HandleAsync(context);
            }
            await Task.CompletedTask;
        }
    }
}
