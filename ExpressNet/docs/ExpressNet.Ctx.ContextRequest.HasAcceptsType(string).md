#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx').[ContextRequest](ExpressNet.Ctx.ContextRequest.md 'ExpressNet.Ctx.ContextRequest')

## ContextRequest.HasAcceptsType(string) Method

Determines whether the request accepts the specified MIME type.

```csharp
public bool HasAcceptsType(string type);
```
#### Parameters

<a name='ExpressNet.Ctx.ContextRequest.HasAcceptsType(string).type'></a>

`type` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The MIME type to check.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the request accepts the specified MIME type; otherwise, `false`.