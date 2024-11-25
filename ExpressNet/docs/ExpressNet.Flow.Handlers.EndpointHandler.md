#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers')

## EndpointHandler Class

Represents a handler for an endpoint in a chain of responsibility pattern.

```csharp
internal sealed class EndpointHandler : ExpressNet.Flow.Abstractions.ChainHandler<ExpressNet.Ctx.Context>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ExpressNet.Flow.Abstractions.ChainHandler&lt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>')[Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')[&gt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>') &#129106; EndpointHandler

| Constructors | |
| :--- | :--- |
| [EndpointHandler(Type, ServiceScope)](ExpressNet.Flow.Handlers.EndpointHandler.EndpointHandler(System.Type,ExpressNet.Di.ServiceScope).md 'ExpressNet.Flow.Handlers.EndpointHandler.EndpointHandler(System.Type, ExpressNet.Di.ServiceScope)') | Initializes a new instance of the [EndpointHandler](ExpressNet.Flow.Handlers.EndpointHandler.md 'ExpressNet.Flow.Handlers.EndpointHandler') class with the specified endpoint type and service scope. |

| Methods | |
| :--- | :--- |
| [HandleAsync(Context)](ExpressNet.Flow.Handlers.EndpointHandler.HandleAsync(ExpressNet.Ctx.Context).md 'ExpressNet.Flow.Handlers.EndpointHandler.HandleAsync(ExpressNet.Ctx.Context)') | Handles the context asynchronously by creating an instance of the endpoint and invoking its handle method. |
