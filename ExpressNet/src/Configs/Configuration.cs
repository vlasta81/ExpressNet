using ExpressNet.Configs.Configurations;
using ExpressNet.Configs.Contracts;

namespace ExpressNet.Configs
{
    /// <summary>
    /// Represents the configuration settings for the application, server, static files, and custom configurations.
    /// </summary>
    public sealed class Configuration
    {
        /// <summary>
        /// Gets the server configuration settings.
        /// </summary>
        public ServerConfiguration Server { get; init; }

        /// <summary>
        /// Gets the application configuration settings.
        /// </summary>
        public ApplicationConfiguration Application { get; init; }

        /// <summary>
        /// Gets the static files configuration settings.
        /// </summary>
        public StaticFilesConfiguration StaticFiles { get; init; }

        /// <summary>
        /// Gets the custom configuration settings.
        /// </summary>
        public ICustomConfiguration? Custom { get; init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration"/> class with the specified configurator.
        /// </summary>
        /// <param name="configurator">The configurator containing the configuration settings.</param>
        public Configuration(Configurator configurator)
        {
            Server = configurator.Server;
            Application = configurator.Application;
            StaticFiles = configurator.StaticFiles;
            Custom = configurator.Custom;
        }
    }
}
