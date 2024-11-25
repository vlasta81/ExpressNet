#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx').[ContextResponse](ExpressNet.Ctx.ContextResponse.md 'ExpressNet.Ctx.ContextResponse')

## ContextResponse.WriteAsJsonAsync<T>(T) Method

Writes the specified content as JSON to the response asynchronously.

```csharp
public System.Threading.Tasks.Task WriteAsJsonAsync<T>(T content);
```
#### Type parameters

<a name='ExpressNet.Ctx.ContextResponse.WriteAsJsonAsync_T_(T).T'></a>

`T`

The type of the content.
#### Parameters

<a name='ExpressNet.Ctx.ContextResponse.WriteAsJsonAsync_T_(T).content'></a>

`content` [T](ExpressNet.Ctx.ContextResponse.WriteAsJsonAsync_T_(T).md#ExpressNet.Ctx.ContextResponse.WriteAsJsonAsync_T_(T).T 'ExpressNet.Ctx.ContextResponse.WriteAsJsonAsync<T>(T).T')

The content to write.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous write operation.