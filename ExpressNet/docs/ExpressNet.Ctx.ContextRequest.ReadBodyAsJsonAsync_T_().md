#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx').[ContextRequest](ExpressNet.Ctx.ContextRequest.md 'ExpressNet.Ctx.ContextRequest')

## ContextRequest.ReadBodyAsJsonAsync<T>() Method

Reads the request body as a JSON object asynchronously.

```csharp
public System.Threading.Tasks.Task<T?> ReadBodyAsJsonAsync<T>();
```
#### Type parameters

<a name='ExpressNet.Ctx.ContextRequest.ReadBodyAsJsonAsync_T_().T'></a>

`T`

The type of the JSON object.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](ExpressNet.Ctx.ContextRequest.ReadBodyAsJsonAsync_T_().md#ExpressNet.Ctx.ContextRequest.ReadBodyAsJsonAsync_T_().T 'ExpressNet.Ctx.ContextRequest.ReadBodyAsJsonAsync<T>().T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The request body as a JSON object.