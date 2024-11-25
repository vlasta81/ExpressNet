#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers')

## NullEndpointHandler Class

Represents a handler that processes requests with a null endpoint.

```csharp
internal sealed class NullEndpointHandler : ExpressNet.Flow.Abstractions.ChainHandler<ExpressNet.Ctx.Context>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ExpressNet.Flow.Abstractions.ChainHandler&lt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>')[Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')[&gt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>') &#129106; NullEndpointHandler

| Constructors | |
| :--- | :--- |
| [NullEndpointHandler(Type)](ExpressNet.Flow.Handlers.NullEndpointHandler.NullEndpointHandler(System.Type).md 'ExpressNet.Flow.Handlers.NullEndpointHandler.NullEndpointHandler(System.Type)') | Initializes a new instance of the [NullEndpointHandler](ExpressNet.Flow.Handlers.NullEndpointHandler.md 'ExpressNet.Flow.Handlers.NullEndpointHandler') class with the specified endpoint type. |

| Methods | |
| :--- | :--- |
| [HandleAsync(Context)](ExpressNet.Flow.Handlers.NullEndpointHandler.HandleAsync(ExpressNet.Ctx.Context).md 'ExpressNet.Flow.Handlers.NullEndpointHandler.HandleAsync(ExpressNet.Ctx.Context)') | Handles the context asynchronously. If the endpoint is null, sets the response status code to 404 and writes "Not Found" to the response.<br/>Otherwise, delegates the handling to the next handler in the chain. |
