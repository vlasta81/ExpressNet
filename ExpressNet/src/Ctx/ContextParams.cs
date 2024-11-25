using System.Collections.Concurrent;

namespace ExpressNet.Ctx
{
    /// <summary>
    /// Represents a thread-safe collection of context parameters.
    /// </summary>
    public sealed class ContextParams
    {
        private readonly ConcurrentDictionary<string, object> _params;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextParams"/> class with the specified parameters.
        /// </summary>
        /// <param name="parameters">A collection of key-value pairs to initialize the context parameters.</param>
        public ContextParams(ConcurrentDictionary<string, object> parameters)
        {
            _params = parameters;
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <typeparam name="T">The type of the value to get.</typeparam>
        /// <param name="key">The key of the value to get.</param>
        /// <returns>The value associated with the specified key.</returns>
        /// <exception cref="KeyNotFoundException">Thrown when the specified key is not found in the context parameters.</exception>
        public T? Get<T>(string key)
        {
            if (_params.TryGetValue(key, out object? value))
            {
                return (T)value;
            }
            throw new KeyNotFoundException($"Key '{key}' not found in the context params.");
        }

        /// <summary>
        /// Gets the number of key-value pairs contained in the context parameters.
        /// </summary>
        /// <returns>The number of key-value pairs contained in the context parameters.</returns>
        public int Count()
        {
            return _params.Count;
        }

        /// <summary>
        /// Determines whether the context parameters contain the specified key.
        /// </summary>
        /// <param name="key">The key to locate in the context parameters.</param>
        /// <returns><c>true</c> if the context parameters contain an element with the specified key; otherwise, <c>false</c>.</returns>
        public bool Exists(string key)
        {
            return _params.ContainsKey(key);
        }
    }

}
