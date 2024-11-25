#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx').[ContextParams](ExpressNet.Ctx.ContextParams.md 'ExpressNet.Ctx.ContextParams')

## ContextParams.Get<T>(string) Method

Gets the value associated with the specified key.

```csharp
public T? Get<T>(string key);
```
#### Type parameters

<a name='ExpressNet.Ctx.ContextParams.Get_T_(string).T'></a>

`T`

The type of the value to get.
#### Parameters

<a name='ExpressNet.Ctx.ContextParams.Get_T_(string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key of the value to get.

#### Returns
[T](ExpressNet.Ctx.ContextParams.Get_T_(string).md#ExpressNet.Ctx.ContextParams.Get_T_(string).T 'ExpressNet.Ctx.ContextParams.Get<T>(string).T')  
The value associated with the specified key.

#### Exceptions

[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
Thrown when the specified key is not found in the context parameters.