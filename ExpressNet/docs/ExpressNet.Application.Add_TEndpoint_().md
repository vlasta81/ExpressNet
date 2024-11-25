#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet](ExpressNet.md 'ExpressNet').[Application](ExpressNet.Application.md 'ExpressNet.Application')

## Application.Add<TEndpoint>() Method

Adds an endpoint to the router.

```csharp
public void Add<TEndpoint>()
    where TEndpoint : ExpressNet.Routing.Contracts.IEndpoint;
```
#### Type parameters

<a name='ExpressNet.Application.Add_TEndpoint_().TEndpoint'></a>

`TEndpoint`

The type of the endpoint to add.