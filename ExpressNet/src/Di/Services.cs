using System.Collections.Concurrent;

namespace ExpressNet.Di
{
    /// <summary>
    /// Represents a collection of services for dependency injection.
    /// </summary>
    public sealed class Services
    {
        /// <summary>
        /// A dictionary that holds the registered services and their descriptors.
        /// </summary>
        internal readonly ConcurrentDictionary<Type, ServiceDescriptor> _services;

        /// <summary>
        /// A dictionary that holds the scoped instances of services.
        /// </summary>
        internal readonly ConcurrentDictionary<Type, object> _scopedInstances;

        /// <summary>
        /// Initializes a new instance of the <see cref="Services"/> class.
        /// </summary>
        internal Services()
        {
            _services = new ConcurrentDictionary<Type, ServiceDescriptor>();
            _scopedInstances = new ConcurrentDictionary<Type, object>();
        }

        /// <summary>
        /// Registers a service with the specified factory method and lifetime.
        /// </summary>
        /// <typeparam name="TService">The type of the service to register.</typeparam>
        /// <param name="factory">The factory method used to create the service instance.</param>
        /// <param name="lifetime">The lifetime of the service.</param>
        public void Register<TService>(Func<Services, TService> factory, ServiceLifetime lifetime)
        {
            ServiceDescriptor descriptor = new ServiceDescriptor(typeof(TService), s => factory(s)!, lifetime);
            _services[typeof(TService)] = descriptor;
        }

        /// <summary>
        /// Resolves an instance of the specified service type.
        /// </summary>
        /// <typeparam name="TService">The type of the service to resolve.</typeparam>
        /// <returns>An instance of the specified service type.</returns>
        public TService Resolve<TService>()
        {
            return (TService)Resolve(typeof(TService));
        }

        /// <summary>
        /// Resolves an instance of the specified service type.
        /// </summary>
        /// <param name="serviceType">The type of the service to resolve.</param>
        /// <returns>An instance of the specified service type.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the service type is not registered.</exception>
        public object Resolve(Type serviceType)
        {
            if (_services.TryGetValue(serviceType, out var descriptor))
            {
                if (descriptor.Lifetime == ServiceLifetime.Singleton)
                {
                    if (descriptor.Instance == null)
                    {
                        descriptor.Instance = descriptor.Factory(this);
                    }
                    return descriptor.Instance;
                }

                if (descriptor.Lifetime == ServiceLifetime.Scoped)
                {
                    if (!_scopedInstances.TryGetValue(serviceType, out var instance))
                    {
                        instance = descriptor.Factory(this);
                        _scopedInstances[serviceType] = instance;
                    }
                    return instance;
                }

                return descriptor.Factory(this);
            }

            throw new InvalidOperationException($"Service of type {serviceType} is not registered.");
        }

        /// <summary>
        /// Creates a new scope for resolving scoped services.
        /// </summary>
        /// <returns>A new instance of <see cref="ServiceScope"/>.</returns>
        internal ServiceScope CreateScope()
        {
            return new ServiceScope(this);
        }
    }
}
