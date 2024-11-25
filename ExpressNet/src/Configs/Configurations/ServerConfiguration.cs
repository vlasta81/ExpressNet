using System.Net;

namespace ExpressNet.Configs.Configurations
{
    /// <summary>
    /// Represents the configuration settings for the server.
    /// </summary>
    public sealed class ServerConfiguration
    {
        /// <summary>
        /// Gets or sets the authentication scheme used by the server.
        /// Default is <see cref="AuthenticationSchemes.Anonymous"/>.
        /// </summary>
        public AuthenticationSchemes AuthenticationScheme { get; set; } = AuthenticationSchemes.Anonymous;

        /// <summary>
        /// Gets or sets the timeout for the request queue.
        /// Default is 1 minute.
        /// </summary>
        public TimeSpan RequestQueueTimeout { get; set; } = TimeSpan.FromMinutes(1);

        /// <summary>
        /// Gets or sets the timeout for idle connections.
        /// Default is 2 minutes.
        /// </summary>
        public TimeSpan IdleConnectionTimeout { get; set; } = TimeSpan.FromMinutes(2);
    }
}
