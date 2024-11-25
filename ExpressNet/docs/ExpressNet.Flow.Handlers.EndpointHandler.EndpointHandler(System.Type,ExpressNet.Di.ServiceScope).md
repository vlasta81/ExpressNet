#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers').[EndpointHandler](ExpressNet.Flow.Handlers.EndpointHandler.md 'ExpressNet.Flow.Handlers.EndpointHandler')

## EndpointHandler(Type, ServiceScope) Constructor

Initializes a new instance of the [EndpointHandler](ExpressNet.Flow.Handlers.EndpointHandler.md 'ExpressNet.Flow.Handlers.EndpointHandler') class with the specified endpoint type and service scope.

```csharp
internal EndpointHandler(System.Type endpoint, ExpressNet.Di.ServiceScope services);
```
#### Parameters

<a name='ExpressNet.Flow.Handlers.EndpointHandler.EndpointHandler(System.Type,ExpressNet.Di.ServiceScope).endpoint'></a>

`endpoint` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of the endpoint to handle.

<a name='ExpressNet.Flow.Handlers.EndpointHandler.EndpointHandler(System.Type,ExpressNet.Di.ServiceScope).services'></a>

`services` [ServiceScope](ExpressNet.Di.ServiceScope.md 'ExpressNet.Di.ServiceScope')

The service scope for resolving dependencies.