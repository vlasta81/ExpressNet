
namespace ExpressNet.Di
{
    /// <summary>
    /// Specifies the lifetime of a service in the dependency injection container.
    /// </summary>
    public enum ServiceLifetime
    {
        /// <summary>
        /// A single instance is created and shared throughout the application's lifetime.
        /// </summary>
        Singleton,

        /// <summary>
        /// A new instance is created each time the service is requested.
        /// </summary>
        Transient,

        /// <summary>
        /// A new instance is created for each scope. Typically, a scope is created per request.
        /// </summary>
        Scoped
    }
}
