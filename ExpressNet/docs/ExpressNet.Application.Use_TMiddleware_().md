#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet](ExpressNet.md 'ExpressNet').[Application](ExpressNet.Application.md 'ExpressNet.Application')

## Application.Use<TMiddleware>() Method

Adds a middleware to the pipeline.

```csharp
public void Use<TMiddleware>()
    where TMiddleware : ExpressNet.Middlewares.Contracts.IMiddleware;
```
#### Type parameters

<a name='ExpressNet.Application.Use_TMiddleware_().TMiddleware'></a>

`TMiddleware`

The type of the middleware to add.