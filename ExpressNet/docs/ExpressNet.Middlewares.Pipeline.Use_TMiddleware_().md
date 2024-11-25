#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Middlewares](ExpressNet.Middlewares.md 'ExpressNet.Middlewares').[Pipeline](ExpressNet.Middlewares.Pipeline.md 'ExpressNet.Middlewares.Pipeline')

## Pipeline.Use<TMiddleware>() Method

Adds a middleware type to the pipeline.

```csharp
public void Use<TMiddleware>()
    where TMiddleware : ExpressNet.Middlewares.Contracts.IMiddleware;
```
#### Type parameters

<a name='ExpressNet.Middlewares.Pipeline.Use_TMiddleware_().TMiddleware'></a>

`TMiddleware`

The type of the middleware to add.