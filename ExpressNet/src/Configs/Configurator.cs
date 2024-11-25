using ExpressNet.Configs.Configurations;
using ExpressNet.Configs.Contracts;

namespace ExpressNet.Configs
{
    /// <summary>
    /// Provides configuration settings for the server, application, and static files.
    /// </summary>
    public sealed class Configurator
    {
        /// <summary>
        /// Gets the server configuration settings.
        /// </summary>
        public readonly ServerConfiguration Server;

        /// <summary>
        /// Gets the application configuration settings.
        /// </summary>
        public readonly ApplicationConfiguration Application;

        /// <summary>
        /// Gets the static files configuration settings.
        /// </summary>
        public readonly StaticFilesConfiguration StaticFiles;

        /// <summary>
        /// Gets or sets the custom configuration settings.
        /// </summary>
        public ICustomConfiguration? Custom;

        /// <summary>
        /// Initializes a new instance of the <see cref="Configurator"/> class.
        /// </summary>
        public Configurator()
        {
            Server = new ServerConfiguration();
            Application = new ApplicationConfiguration();
            StaticFiles = new StaticFilesConfiguration();
        }
    }
}
