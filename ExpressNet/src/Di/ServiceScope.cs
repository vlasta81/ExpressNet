using System.Collections.Concurrent;

namespace ExpressNet.Di
{
    /// <summary>
    /// Represents a scope for resolving scoped services in a dependency injection container.
    /// </summary>
    public sealed class ServiceScope : IDisposable
    {
        private readonly Services _rootServices;
        private readonly ConcurrentDictionary<Type, object> _scopedInstances;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceScope"/> class.
        /// </summary>
        /// <param name="rootServices">The root services collection.</param>
        public ServiceScope(Services rootServices)
        {
            _rootServices = rootServices;
            _scopedInstances = new ConcurrentDictionary<Type, object>();
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
            if (_rootServices._services.TryGetValue(serviceType, out var descriptor))
            {
                if (descriptor.Lifetime == ServiceLifetime.Scoped)
                {
                    if (!_scopedInstances.TryGetValue(serviceType, out var instance))
                    {
                        instance = descriptor.Factory(_rootServices);
                        _scopedInstances[serviceType] = instance;
                    }
                    return instance;
                }

                return _rootServices.Resolve(serviceType);
            }
            throw new InvalidOperationException($"Service of type {serviceType} is not registered.");
        }

        /// <summary>
        /// Disposes the scope and clears all scoped instances.
        /// </summary>
        public void Dispose()
        {
            _scopedInstances.Clear();
        }
    }
}
