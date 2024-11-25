#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers')

## AuthenticationHandler Class

Handles authentication for a specific endpoint in the chain of responsibility pattern.

```csharp
internal sealed class AuthenticationHandler : ExpressNet.Flow.Abstractions.ChainHandler<ExpressNet.Ctx.Context>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ExpressNet.Flow.Abstractions.ChainHandler&lt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>')[Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')[&gt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>') &#129106; AuthenticationHandler

| Constructors | |
| :--- | :--- |
| [AuthenticationHandler(Type, ServiceScope)](ExpressNet.Flow.Handlers.AuthenticationHandler.AuthenticationHandler(System.Type,ExpressNet.Di.ServiceScope).md 'ExpressNet.Flow.Handlers.AuthenticationHandler.AuthenticationHandler(System.Type, ExpressNet.Di.ServiceScope)') | Initializes a new instance of the [AuthenticationHandler](ExpressNet.Flow.Handlers.AuthenticationHandler.md 'ExpressNet.Flow.Handlers.AuthenticationHandler') class. |

| Methods | |
| :--- | :--- |
| [HandleAsync(Context)](ExpressNet.Flow.Handlers.AuthenticationHandler.HandleAsync(ExpressNet.Ctx.Context).md 'ExpressNet.Flow.Handlers.AuthenticationHandler.HandleAsync(ExpressNet.Ctx.Context)') | Handles the context asynchronously, checking for authentication requirements. |
