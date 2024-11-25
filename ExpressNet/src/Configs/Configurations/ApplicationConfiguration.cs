
namespace ExpressNet.Configs.Configurations
{
    /// <summary>
    /// Represents the configuration settings for the application.
    /// </summary>
    public class ApplicationConfiguration
    {
        /// <summary>
        /// Gets or sets the name of the application.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the version of the application.
        /// </summary>
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the author of the application.
        /// </summary>
        public string Author { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL of the application.
        /// </summary>
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the application.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
