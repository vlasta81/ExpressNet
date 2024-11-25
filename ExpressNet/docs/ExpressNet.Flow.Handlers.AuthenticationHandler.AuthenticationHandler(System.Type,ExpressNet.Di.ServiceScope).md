#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers').[AuthenticationHandler](ExpressNet.Flow.Handlers.AuthenticationHandler.md 'ExpressNet.Flow.Handlers.AuthenticationHandler')

## AuthenticationHandler(Type, ServiceScope) Constructor

Initializes a new instance of the [AuthenticationHandler](ExpressNet.Flow.Handlers.AuthenticationHandler.md 'ExpressNet.Flow.Handlers.AuthenticationHandler') class.

```csharp
public AuthenticationHandler(System.Type endpoint, ExpressNet.Di.ServiceScope services);
```
#### Parameters

<a name='ExpressNet.Flow.Handlers.AuthenticationHandler.AuthenticationHandler(System.Type,ExpressNet.Di.ServiceScope).endpoint'></a>

`endpoint` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The endpoint type to check for authentication requirements.

<a name='ExpressNet.Flow.Handlers.AuthenticationHandler.AuthenticationHandler(System.Type,ExpressNet.Di.ServiceScope).services'></a>

`services` [ServiceScope](ExpressNet.Di.ServiceScope.md 'ExpressNet.Di.ServiceScope')

The service scope for resolving dependencies.