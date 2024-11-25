
namespace ExpressNet.Di
{
    /// <summary>
    /// Represents a descriptor for a service, containing information about the service type, factory method, lifetime, and instance.
    /// </summary>
    internal sealed class ServiceDescriptor
    {
        /// <summary>
        /// Gets the type of the service.
        /// </summary>
        public Type ServiceType { get; }

        /// <summary>
        /// Gets the factory method used to create the service instance.
        /// </summary>
        public Func<Services, object> Factory { get; }

        /// <summary>
        /// Gets the lifetime of the service.
        /// </summary>
        public ServiceLifetime Lifetime { get; }

        /// <summary>
        /// Gets or sets the instance of the service.
        /// </summary>
        public object? Instance { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDescriptor"/> class.
        /// </summary>
        /// <param name="serviceType">The type of the service.</param>
        /// <param name="factory">The factory method used to create the service instance.</param>
        /// <param name="lifetime">The lifetime of the service.</param>
        internal ServiceDescriptor(Type serviceType, Func<Services, object> factory, ServiceLifetime lifetime)
        {
            ServiceType = serviceType;
            Factory = factory;
            Lifetime = lifetime;
        }
    }
}
