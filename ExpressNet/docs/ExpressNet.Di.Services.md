#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Di](ExpressNet.Di.md 'ExpressNet.Di')

## Services Class

Represents a collection of services for dependency injection.

```csharp
public sealed class Services
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Services

| Constructors | |
| :--- | :--- |
| [Services()](ExpressNet.Di.Services.Services().md 'ExpressNet.Di.Services.Services()') | Initializes a new instance of the [Services](ExpressNet.Di.Services.md 'ExpressNet.Di.Services') class. |

| Fields | |
| :--- | :--- |
| [_scopedInstances](ExpressNet.Di.Services._scopedInstances.md 'ExpressNet.Di.Services._scopedInstances') | A dictionary that holds the scoped instances of services. |
| [_services](ExpressNet.Di.Services._services.md 'ExpressNet.Di.Services._services') | A dictionary that holds the registered services and their descriptors. |

| Methods | |
| :--- | :--- |
| [CreateScope()](ExpressNet.Di.Services.CreateScope().md 'ExpressNet.Di.Services.CreateScope()') | Creates a new scope for resolving scoped services. |
| [Register&lt;TService&gt;(Func&lt;Services,TService&gt;, ServiceLifetime)](ExpressNet.Di.Services.Register_TService_(System.Func_ExpressNet.Di.Services,TService_,ExpressNet.Di.ServiceLifetime).md 'ExpressNet.Di.Services.Register<TService>(System.Func<ExpressNet.Di.Services,TService>, ExpressNet.Di.ServiceLifetime)') | Registers a service with the specified factory method and lifetime. |
| [Resolve(Type)](ExpressNet.Di.Services.Resolve(System.Type).md 'ExpressNet.Di.Services.Resolve(System.Type)') | Resolves an instance of the specified service type. |
| [Resolve&lt;TService&gt;()](ExpressNet.Di.Services.Resolve_TService_().md 'ExpressNet.Di.Services.Resolve<TService>()') | Resolves an instance of the specified service type. |
