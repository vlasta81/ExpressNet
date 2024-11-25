#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers')

## MiddlewareHandler Class

Handles the execution of middleware in a pipeline.

```csharp
internal sealed class MiddlewareHandler : ExpressNet.Flow.Abstractions.ChainHandler<ExpressNet.Ctx.Context>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ExpressNet.Flow.Abstractions.ChainHandler&lt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>')[Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')[&gt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>') &#129106; MiddlewareHandler

| Constructors | |
| :--- | :--- |
| [MiddlewareHandler(Pipeline, ServiceScope)](ExpressNet.Flow.Handlers.MiddlewareHandler.MiddlewareHandler(ExpressNet.Middlewares.Pipeline,ExpressNet.Di.ServiceScope).md 'ExpressNet.Flow.Handlers.MiddlewareHandler.MiddlewareHandler(ExpressNet.Middlewares.Pipeline, ExpressNet.Di.ServiceScope)') | Initializes a new instance of the [MiddlewareHandler](ExpressNet.Flow.Handlers.MiddlewareHandler.md 'ExpressNet.Flow.Handlers.MiddlewareHandler') class with the specified pipeline and service scope. |

| Methods | |
| :--- | :--- |
| [HandleAsync(Context)](ExpressNet.Flow.Handlers.MiddlewareHandler.HandleAsync(ExpressNet.Ctx.Context).md 'ExpressNet.Flow.Handlers.MiddlewareHandler.HandleAsync(ExpressNet.Ctx.Context)') | Handles the context by invoking the middleware pipeline asynchronously. |
