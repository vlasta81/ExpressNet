#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers').[StaticFilesHandler](ExpressNet.Flow.Handlers.StaticFilesHandler.md 'ExpressNet.Flow.Handlers.StaticFilesHandler')

## StaticFilesHandler.HandleAsync(Context) Method

Handles the context asynchronously by serving static files if available, otherwise delegates to the next handler.

```csharp
public override System.Threading.Tasks.Task HandleAsync(ExpressNet.Ctx.Context context);
```
#### Parameters

<a name='ExpressNet.Flow.Handlers.StaticFilesHandler.HandleAsync(ExpressNet.Ctx.Context).context'></a>

`context` [Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')

The context to handle.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.