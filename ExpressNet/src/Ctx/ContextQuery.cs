using System.Collections.Concurrent;
using System.Collections.Specialized;

namespace ExpressNet.Ctx
{
    /// <summary>
    /// Represents a query context that stores key-value pairs parsed from a query string.
    /// </summary>
    public sealed class ContextQuery
    {
        private readonly ConcurrentDictionary<string, object> _query;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextQuery"/> class with the specified query string.
        /// </summary>
        /// <param name="queryString">The query string to parse and store in the context.</param>
        public ContextQuery(NameValueCollection queryString)
        {
            _query = new ConcurrentDictionary<string, object>();
            foreach (string? key in queryString.AllKeys)
            {
                if (key != null)
                {
                    if (int.TryParse(queryString[key]!, out int intValue))
                    {
                        _query[key] = intValue;
                        continue;
                    }
                    if (bool.TryParse(queryString[key]!, out bool boolValue))
                    {
                        _query[key] = boolValue;
                        continue;
                    }
                    if (double.TryParse(queryString[key]!, out double doubleValue))
                    {
                        _query[key] = doubleValue;
                        continue;
                    }
                    _query[key] = queryString[key]!;
                }
            }
        }

        /// <summary>
        /// Gets the value associated with the specified key and converts it to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to convert the value to.</typeparam>
        /// <param name="key">The key of the value to get.</param>
        /// <returns>The value associated with the specified key, converted to the specified type.</returns>
        /// <exception cref="KeyNotFoundException">Thrown when the specified key is not found in the context query.</exception>
        public T? Get<T>(string key)
        {
            if (_query.TryGetValue(key, out object? value))
            {
                return (T)value;
            }
            throw new KeyNotFoundException($"Key '{key}' not found in the context query.");
        }

        /// <summary>
        /// Determines whether the context query contains the specified key.
        /// </summary>
        /// <param name="key">The key to locate in the context query.</param>
        /// <returns><c>true</c> if the context query contains an element with the specified key; otherwise, <c>false</c>.</returns>
        public bool Exists(string key)
        {
            return _query.ContainsKey(key);
        }

        /// <summary>
        /// Gets the number of key-value pairs contained in the context query.
        /// </summary>
        /// <returns>The number of key-value pairs contained in the context query.</returns>
        public int Count()
        {
            return _query.Count;
        }
    }
}
