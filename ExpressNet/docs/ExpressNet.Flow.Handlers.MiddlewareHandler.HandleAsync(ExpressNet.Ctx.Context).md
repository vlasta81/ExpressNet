#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers').[MiddlewareHandler](ExpressNet.Flow.Handlers.MiddlewareHandler.md 'ExpressNet.Flow.Handlers.MiddlewareHandler')

## MiddlewareHandler.HandleAsync(Context) Method

Handles the context by invoking the middleware pipeline asynchronously.

```csharp
public override System.Threading.Tasks.Task HandleAsync(ExpressNet.Ctx.Context context);
```
#### Parameters

<a name='ExpressNet.Flow.Handlers.MiddlewareHandler.HandleAsync(ExpressNet.Ctx.Context).context'></a>

`context` [Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')

The context to handle.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.