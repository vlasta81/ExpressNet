#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers').[NullEndpointHandler](ExpressNet.Flow.Handlers.NullEndpointHandler.md 'ExpressNet.Flow.Handlers.NullEndpointHandler')

## NullEndpointHandler.HandleAsync(Context) Method

Handles the context asynchronously. If the endpoint is null, sets the response status code to 404 and writes "Not Found" to the response.  
Otherwise, delegates the handling to the next handler in the chain.

```csharp
public override System.Threading.Tasks.Task HandleAsync(ExpressNet.Ctx.Context context);
```
#### Parameters

<a name='ExpressNet.Flow.Handlers.NullEndpointHandler.HandleAsync(ExpressNet.Ctx.Context).context'></a>

`context` [Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')

The context to handle.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.