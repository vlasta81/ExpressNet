#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers').[EndpointHandler](ExpressNet.Flow.Handlers.EndpointHandler.md 'ExpressNet.Flow.Handlers.EndpointHandler')

## EndpointHandler.HandleAsync(Context) Method

Handles the context asynchronously by creating an instance of the endpoint and invoking its handle method.

```csharp
public override System.Threading.Tasks.Task HandleAsync(ExpressNet.Ctx.Context context);
```
#### Parameters

<a name='ExpressNet.Flow.Handlers.EndpointHandler.HandleAsync(ExpressNet.Ctx.Context).context'></a>

`context` [Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')

The context to handle.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown when the endpoint instance cannot be created.