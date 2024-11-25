#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx').[ContextRequest](ExpressNet.Ctx.ContextRequest.md 'ExpressNet.Ctx.ContextRequest')

## ContextRequest.HasUserLanguage(string) Method

Determines whether the request accepts the specified user language.

```csharp
public bool HasUserLanguage(string language);
```
#### Parameters

<a name='ExpressNet.Ctx.ContextRequest.HasUserLanguage(string).language'></a>

`language` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The user language to check.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the request accepts the specified user language; otherwise, `false`.