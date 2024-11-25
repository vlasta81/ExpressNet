
namespace ExpressNet.Configs.Contracts
{
    /// <summary>
    /// Interface for custom configuration management.
    /// </summary>
    public interface ICustomConfiguration
    {
        /// <summary>
        /// Retrieves the value associated with the specified key and converts it to the specified type.
        /// </summary>
        /// <typeparam name="TType">The type to which the value should be converted.</typeparam>
        /// <param name="key">The key of the value to retrieve.</param>
        /// <returns>The value associated with the specified key, converted to the specified type.</returns>
        TType Get<TType>(string key);

        /// <summary>
        /// Checks if a value associated with the specified key exists.
        /// </summary>
        /// <param name="key">The key of the value to check for existence.</param>
        /// <returns>True if the value exists, otherwise false.</returns>
        bool Exists(string key);
    }
}
