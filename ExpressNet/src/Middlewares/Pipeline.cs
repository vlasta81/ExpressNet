using ExpressNet.Ctx;
using ExpressNet.Di;
using ExpressNet.Middlewares.Contracts;
using System.Collections.Concurrent;

namespace ExpressNet.Middlewares
{
    /// <summary>
    /// Represents a pipeline for managing and invoking middleware components.
    /// </summary>
    public sealed class Pipeline
    {
        private readonly ConcurrentDictionary<int, Type> _middlewareTypes;
        private int _middlewareCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Pipeline"/> class.
        /// </summary>
        internal Pipeline()
        {
            _middlewareTypes = new ConcurrentDictionary<int, Type>();
            _middlewareCount = 0;
        }

        /// <summary>
        /// Adds a middleware type to the pipeline.
        /// </summary>
        /// <typeparam name="TMiddleware">The type of the middleware to add.</typeparam>
        public void Use<TMiddleware>() where TMiddleware : IMiddleware
        {
            Type middlewareType = typeof(TMiddleware);
            Use(middlewareType);
        }

        /// <summary>
        /// Adds a middleware type to the pipeline.
        /// </summary>
        /// <param name="middlewareType">The type of the middleware to add.</param>
        internal void Use(Type middlewareType)
        {
            _middlewareTypes.TryAdd(_middlewareCount++, middlewareType);
        }

        /// <summary>
        /// Invokes the middleware at the specified index asynchronously.
        /// </summary>
        /// <param name="index">The index of the middleware to invoke.</param>
        /// <param name="context">The context for the current request and response.</param>
        /// <param name="services">The service scope for resolving dependencies.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        internal async Task InvokeMiddlewareAsync(int index, Context context, ServiceScope services)
        {
            if (_middlewareTypes.TryGetValue(index, out var middlewareType))
            {
                IMiddleware middleware = (IMiddleware)Activator.CreateInstance(middlewareType, services)!;
                await middleware.InvokeAsync(context, async (req) => await InvokeMiddlewareAsync(index + 1, req, services));
            }
        }
    }

}
