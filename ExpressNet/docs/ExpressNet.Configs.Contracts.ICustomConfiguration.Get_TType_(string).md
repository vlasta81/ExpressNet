#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Configs.Contracts](ExpressNet.Configs.Contracts.md 'ExpressNet.Configs.Contracts').[ICustomConfiguration](ExpressNet.Configs.Contracts.ICustomConfiguration.md 'ExpressNet.Configs.Contracts.ICustomConfiguration')

## ICustomConfiguration.Get<TType>(string) Method

Retrieves the value associated with the specified key and converts it to the specified type.

```csharp
TType Get<TType>(string key);
```
#### Type parameters

<a name='ExpressNet.Configs.Contracts.ICustomConfiguration.Get_TType_(string).TType'></a>

`TType`

The type to which the value should be converted.
#### Parameters

<a name='ExpressNet.Configs.Contracts.ICustomConfiguration.Get_TType_(string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key of the value to retrieve.

#### Returns
[TType](ExpressNet.Configs.Contracts.ICustomConfiguration.Get_TType_(string).md#ExpressNet.Configs.Contracts.ICustomConfiguration.Get_TType_(string).TType 'ExpressNet.Configs.Contracts.ICustomConfiguration.Get<TType>(string).TType')  
The value associated with the specified key, converted to the specified type.