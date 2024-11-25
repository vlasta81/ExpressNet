#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx').[ContextData](ExpressNet.Ctx.ContextData.md 'ExpressNet.Ctx.ContextData')

## ContextData.Get<T>(string) Method

Gets the value associated with the specified key.

```csharp
public T? Get<T>(string key);
```
#### Type parameters

<a name='ExpressNet.Ctx.ContextData.Get_T_(string).T'></a>

`T`

The type of the value.
#### Parameters

<a name='ExpressNet.Ctx.ContextData.Get_T_(string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key of the value to get.

#### Returns
[T](ExpressNet.Ctx.ContextData.Get_T_(string).md#ExpressNet.Ctx.ContextData.Get_T_(string).T 'ExpressNet.Ctx.ContextData.Get<T>(string).T')  
The value associated with the specified key.

#### Exceptions

[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
Thrown when the key is not found in the context data.