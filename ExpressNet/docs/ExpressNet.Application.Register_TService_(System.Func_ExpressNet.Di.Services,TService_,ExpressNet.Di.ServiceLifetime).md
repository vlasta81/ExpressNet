#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet](ExpressNet.md 'ExpressNet').[Application](ExpressNet.Application.md 'ExpressNet.Application')

## Application.Register<TService>(Func<Services,TService>, ServiceLifetime) Method

Registers a service with the specified factory method and lifetime.

```csharp
public void Register<TService>(System.Func<ExpressNet.Di.Services,TService> factory, ExpressNet.Di.ServiceLifetime lifetime);
```
#### Type parameters

<a name='ExpressNet.Application.Register_TService_(System.Func_ExpressNet.Di.Services,TService_,ExpressNet.Di.ServiceLifetime).TService'></a>

`TService`

The type of the service to register.
#### Parameters

<a name='ExpressNet.Application.Register_TService_(System.Func_ExpressNet.Di.Services,TService_,ExpressNet.Di.ServiceLifetime).factory'></a>

`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Services](ExpressNet.Di.Services.md 'ExpressNet.Di.Services')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TService](ExpressNet.Application.Register_TService_(System.Func_ExpressNet.Di.Services,TService_,ExpressNet.Di.ServiceLifetime).md#ExpressNet.Application.Register_TService_(System.Func_ExpressNet.Di.Services,TService_,ExpressNet.Di.ServiceLifetime).TService 'ExpressNet.Application.Register<TService>(System.Func<ExpressNet.Di.Services,TService>, ExpressNet.Di.ServiceLifetime).TService')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The factory method used to create the service instance.

<a name='ExpressNet.Application.Register_TService_(System.Func_ExpressNet.Di.Services,TService_,ExpressNet.Di.ServiceLifetime).lifetime'></a>

`lifetime` [ServiceLifetime](ExpressNet.Di.ServiceLifetime.md 'ExpressNet.Di.ServiceLifetime')

The lifetime of the service.