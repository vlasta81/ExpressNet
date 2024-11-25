#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Routing](ExpressNet.Routing.md 'ExpressNet.Routing').[Router](ExpressNet.Routing.Router.md 'ExpressNet.Routing.Router')

## Router.MatchEndpoint(Context) Method

Matches an endpoint based on the context.

```csharp
internal System.Type? MatchEndpoint(ExpressNet.Ctx.Context context);
```
#### Parameters

<a name='ExpressNet.Routing.Router.MatchEndpoint(ExpressNet.Ctx.Context).context'></a>

`context` [Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')

The context containing the request information.

#### Returns
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The matched endpoint type, or null if no match is found.