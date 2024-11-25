#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet](ExpressNet.md 'ExpressNet').[Application](ExpressNet.Application.md 'ExpressNet.Application')

## Application.AddRange<TGroupEndpoints>() Method

Adds a group of endpoints to the router.

```csharp
public void AddRange<TGroupEndpoints>()
    where TGroupEndpoints : ExpressNet.Routing.Contracts.IGroupEndpoints, new();
```
#### Type parameters

<a name='ExpressNet.Application.AddRange_TGroupEndpoints_().TGroupEndpoints'></a>

`TGroupEndpoints`

The type of the group of endpoints to add.