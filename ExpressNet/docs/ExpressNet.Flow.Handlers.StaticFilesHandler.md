#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers')

## StaticFilesHandler Class

Handles the serving of static files in the application.

```csharp
internal sealed class StaticFilesHandler : ExpressNet.Flow.Abstractions.ChainHandler<ExpressNet.Ctx.Context>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ExpressNet.Flow.Abstractions.ChainHandler&lt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>')[Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')[&gt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>') &#129106; StaticFilesHandler

| Constructors | |
| :--- | :--- |
| [StaticFilesHandler(Configuration)](ExpressNet.Flow.Handlers.StaticFilesHandler.StaticFilesHandler(ExpressNet.Configs.Configuration).md 'ExpressNet.Flow.Handlers.StaticFilesHandler.StaticFilesHandler(ExpressNet.Configs.Configuration)') | Initializes a new instance of the [StaticFilesHandler](ExpressNet.Flow.Handlers.StaticFilesHandler.md 'ExpressNet.Flow.Handlers.StaticFilesHandler') class with the specified configuration. |

| Methods | |
| :--- | :--- |
| [HandleAsync(Context)](ExpressNet.Flow.Handlers.StaticFilesHandler.HandleAsync(ExpressNet.Ctx.Context).md 'ExpressNet.Flow.Handlers.StaticFilesHandler.HandleAsync(ExpressNet.Ctx.Context)') | Handles the context asynchronously by serving static files if available, otherwise delegates to the next handler. |
