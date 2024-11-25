#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Routing](ExpressNet.Routing.md 'ExpressNet.Routing').[Router](ExpressNet.Routing.Router.md 'ExpressNet.Routing.Router')

## Router.Add<TEndpoint>() Method

Adds an endpoint to the router.

```csharp
public void Add<TEndpoint>()
    where TEndpoint : ExpressNet.Routing.Contracts.IEndpoint;
```
#### Type parameters

<a name='ExpressNet.Routing.Router.Add_TEndpoint_().TEndpoint'></a>

`TEndpoint`

The type of the endpoint to add.