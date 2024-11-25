#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Configs.Contracts](ExpressNet.Configs.Contracts.md 'ExpressNet.Configs.Contracts').[ICustomConfiguration](ExpressNet.Configs.Contracts.ICustomConfiguration.md 'ExpressNet.Configs.Contracts.ICustomConfiguration')

## ICustomConfiguration.Exists<TType>(string) Method

Checks if a value associated with the specified key exists.

```csharp
bool Exists<TType>(string key);
```
#### Type parameters

<a name='ExpressNet.Configs.Contracts.ICustomConfiguration.Exists_TType_(string).TType'></a>

`TType`

The type of the value to check for existence.
#### Parameters

<a name='ExpressNet.Configs.Contracts.ICustomConfiguration.Exists_TType_(string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The key of the value to check for existence.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the value exists, otherwise false.