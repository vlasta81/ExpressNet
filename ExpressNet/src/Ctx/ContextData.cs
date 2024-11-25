using System.Collections.Concurrent;

namespace ExpressNet.Ctx
{
    /// <summary>
    /// Represents a thread-safe context data storage.
    /// </summary>
    public sealed class ContextData
    {
        private readonly ConcurrentDictionary<string, object> _data;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextData"/> class.
        /// </summary>
        public ContextData()
        {
            _data = new ConcurrentDictionary<string, object>();
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="key">The key of the value to get.</param>
        /// <returns>The value associated with the specified key.</returns>
        /// <exception cref="KeyNotFoundException">Thrown when the key is not found in the context data.</exception>
        public T? Get<T>(string key)
        {
            if (_data.TryGetValue(key, out object? value))
            {
                return (T)value;
            }
            throw new KeyNotFoundException($"Key '{key}' not found in the context data.");
        }

        /// <summary>
        /// Sets the value associated with the specified key.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="key">The key of the value to set.</param>
        /// <param name="value">The value to set.</param>
        /// <returns><c>true</c> if the value was added successfully; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the value is null.</exception>
        public bool Set<T>(string key, T value)
        {
            ArgumentNullException.ThrowIfNull(value, nameof(value));
            return _data.TryAdd(key, value);
        }

        /// <summary>
        /// Deletes the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key of the value to delete.</param>
        /// <returns><c>true</c> if the value was removed successfully; otherwise, <c>false</c>.</returns>
        public bool Delete(string key)
        {
            return _data.TryRemove(key, out _);
        }

        /// <summary>
        /// Determines whether the context data contains the specified key.
        /// </summary>
        /// <param name="key">The key to locate in the context data.</param>
        /// <returns><c>true</c> if the context data contains an element with the specified key; otherwise, <c>false</c>.</returns>
        public bool Exists(string key)
        {
            return _data.ContainsKey(key);
        }

        /// <summary>
        /// Gets the number of key/value pairs contained in the context data.
        /// </summary>
        /// <returns>The number of key/value pairs contained in the context data.</returns>
        public int Count()
        {
            return _data.Count;
        }

        /// <summary>
        /// Removes all keys and values from the context data.
        /// </summary>
        public void Clear()
        {
            _data.Clear();
        }
    }
}
