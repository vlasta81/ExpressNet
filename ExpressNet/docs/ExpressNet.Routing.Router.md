#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Routing](ExpressNet.Routing.md 'ExpressNet.Routing')

## Router Class

Represents a router that handles the registration and matching of routes to endpoints.

```csharp
public sealed class Router
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Router

| Methods | |
| :--- | :--- |
| [Add&lt;TEndpoint&gt;()](ExpressNet.Routing.Router.Add_TEndpoint_().md 'ExpressNet.Routing.Router.Add<TEndpoint>()') | Adds an endpoint to the router. |
| [AddRoute(string, Type)](ExpressNet.Routing.Router.AddRoute(string,System.Type).md 'ExpressNet.Routing.Router.AddRoute(string, System.Type)') | Adds a route to the router with the specified route template and handler type. |
| [MatchEndpoint(Context)](ExpressNet.Routing.Router.MatchEndpoint(ExpressNet.Ctx.Context).md 'ExpressNet.Routing.Router.MatchEndpoint(ExpressNet.Ctx.Context)') | Matches an endpoint based on the context. |
