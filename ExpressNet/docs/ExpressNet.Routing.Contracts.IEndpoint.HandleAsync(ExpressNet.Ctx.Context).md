#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Routing.Contracts](ExpressNet.Routing.Contracts.md 'ExpressNet.Routing.Contracts').[IEndpoint](ExpressNet.Routing.Contracts.IEndpoint.md 'ExpressNet.Routing.Contracts.IEndpoint')

## IEndpoint.HandleAsync(Context) Method

Handles the HTTP request asynchronously.

```csharp
System.Threading.Tasks.Task HandleAsync(ExpressNet.Ctx.Context context);
```
#### Parameters

<a name='ExpressNet.Routing.Contracts.IEndpoint.HandleAsync(ExpressNet.Ctx.Context).context'></a>

`context` [Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')

The context for the HTTP request and response.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.