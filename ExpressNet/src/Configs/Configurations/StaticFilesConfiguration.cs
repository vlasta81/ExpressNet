
namespace ExpressNet.Configs.Configurations
{
    /// <summary>
    /// Provides configuration for static files including the directory path and cache lifetime.
    /// </summary>
    public sealed class StaticFilesConfiguration
    {
        /// <summary>
        /// Gets or sets the directory path where static files are located.
        /// </summary>
        /// <value>
        /// The directory path as a string.
        /// </value>
        public string Directory { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the cache lifetime for static files in seconds.
        /// </summary>
        /// <value>
        /// The cache lifetime in seconds. Default is 3600 seconds (1 hour).
        /// </value>
        public int Lifetime { get; set; } = 3600;
    }
}
