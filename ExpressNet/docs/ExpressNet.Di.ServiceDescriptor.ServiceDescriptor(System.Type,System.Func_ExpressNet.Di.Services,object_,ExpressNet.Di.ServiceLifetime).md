#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Di](ExpressNet.Di.md 'ExpressNet.Di').[ServiceDescriptor](ExpressNet.Di.ServiceDescriptor.md 'ExpressNet.Di.ServiceDescriptor')

## ServiceDescriptor(Type, Func<Services,object>, ServiceLifetime) Constructor

Initializes a new instance of the [ServiceDescriptor](ExpressNet.Di.ServiceDescriptor.md 'ExpressNet.Di.ServiceDescriptor') class.

```csharp
internal ServiceDescriptor(System.Type serviceType, System.Func<ExpressNet.Di.Services,object> factory, ExpressNet.Di.ServiceLifetime lifetime);
```
#### Parameters

<a name='ExpressNet.Di.ServiceDescriptor.ServiceDescriptor(System.Type,System.Func_ExpressNet.Di.Services,object_,ExpressNet.Di.ServiceLifetime).serviceType'></a>

`serviceType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of the service.

<a name='ExpressNet.Di.ServiceDescriptor.ServiceDescriptor(System.Type,System.Func_ExpressNet.Di.Services,object_,ExpressNet.Di.ServiceLifetime).factory'></a>

`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Services](ExpressNet.Di.Services.md 'ExpressNet.Di.Services')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The factory method used to create the service instance.

<a name='ExpressNet.Di.ServiceDescriptor.ServiceDescriptor(System.Type,System.Func_ExpressNet.Di.Services,object_,ExpressNet.Di.ServiceLifetime).lifetime'></a>

`lifetime` [ServiceLifetime](ExpressNet.Di.ServiceLifetime.md 'ExpressNet.Di.ServiceLifetime')

The lifetime of the service.