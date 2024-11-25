#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx').[ContextQuery](ExpressNet.Ctx.ContextQuery.md 'ExpressNet.Ctx.ContextQuery')

## ContextQuery.Get<T>(string) Method

Gets the value associated with the specified key and converts it to the specified type.

```csharp
public T? Get<T>(string key);
```
#### Type parameters

<a name='ExpressNet.Ctx.ContextQuery.Get_T_(string).T'></a>

`T`

The type to convert the value to.
#### Parameters

<a name='ExpressNet.Ctx.ContextQuery.Get_T_(string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key of the value to get.

#### Returns
[T](ExpressNet.Ctx.ContextQuery.Get_T_(string).md#ExpressNet.Ctx.ContextQuery.Get_T_(string).T 'ExpressNet.Ctx.ContextQuery.Get<T>(string).T')  
The value associated with the specified key, converted to the specified type.

#### Exceptions

[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
Thrown when the specified key is not found in the context query.