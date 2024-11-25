#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx').[ContextData](ExpressNet.Ctx.ContextData.md 'ExpressNet.Ctx.ContextData')

## ContextData.Set<T>(string, T) Method

Sets the value associated with the specified key.

```csharp
public bool Set<T>(string key, T value);
```
#### Type parameters

<a name='ExpressNet.Ctx.ContextData.Set_T_(string,T).T'></a>

`T`

The type of the value.
#### Parameters

<a name='ExpressNet.Ctx.ContextData.Set_T_(string,T).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key of the value to set.

<a name='ExpressNet.Ctx.ContextData.Set_T_(string,T).value'></a>

`value` [T](ExpressNet.Ctx.ContextData.Set_T_(string,T).md#ExpressNet.Ctx.ContextData.Set_T_(string,T).T 'ExpressNet.Ctx.ContextData.Set<T>(string, T).T')

The value to set.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the value was added successfully; otherwise, `false`.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown when the value is null.