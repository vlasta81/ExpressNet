#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Di](ExpressNet.Di.md 'ExpressNet.Di')

## ServiceDescriptor Class

Represents a descriptor for a service, containing information about the service type, factory method, lifetime, and instance.

```csharp
internal sealed class ServiceDescriptor
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ServiceDescriptor

| Constructors | |
| :--- | :--- |
| [ServiceDescriptor(Type, Func&lt;Services,object&gt;, ServiceLifetime)](ExpressNet.Di.ServiceDescriptor.ServiceDescriptor(System.Type,System.Func_ExpressNet.Di.Services,object_,ExpressNet.Di.ServiceLifetime).md 'ExpressNet.Di.ServiceDescriptor.ServiceDescriptor(System.Type, System.Func<ExpressNet.Di.Services,object>, ExpressNet.Di.ServiceLifetime)') | Initializes a new instance of the [ServiceDescriptor](ExpressNet.Di.ServiceDescriptor.md 'ExpressNet.Di.ServiceDescriptor') class. |

| Properties | |
| :--- | :--- |
| [Factory](ExpressNet.Di.ServiceDescriptor.Factory.md 'ExpressNet.Di.ServiceDescriptor.Factory') | Gets the factory method used to create the service instance. |
| [Instance](ExpressNet.Di.ServiceDescriptor.Instance.md 'ExpressNet.Di.ServiceDescriptor.Instance') | Gets or sets the instance of the service. |
| [Lifetime](ExpressNet.Di.ServiceDescriptor.Lifetime.md 'ExpressNet.Di.ServiceDescriptor.Lifetime') | Gets the lifetime of the service. |
| [ServiceType](ExpressNet.Di.ServiceDescriptor.ServiceType.md 'ExpressNet.Di.ServiceDescriptor.ServiceType') | Gets the type of the service. |
