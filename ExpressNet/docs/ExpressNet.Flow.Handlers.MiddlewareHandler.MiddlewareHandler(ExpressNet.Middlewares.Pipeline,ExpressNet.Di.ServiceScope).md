#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Handlers](ExpressNet.Flow.Handlers.md 'ExpressNet.Flow.Handlers').[MiddlewareHandler](ExpressNet.Flow.Handlers.MiddlewareHandler.md 'ExpressNet.Flow.Handlers.MiddlewareHandler')

## MiddlewareHandler(Pipeline, ServiceScope) Constructor

Initializes a new instance of the [MiddlewareHandler](ExpressNet.Flow.Handlers.MiddlewareHandler.md 'ExpressNet.Flow.Handlers.MiddlewareHandler') class with the specified pipeline and service scope.

```csharp
internal MiddlewareHandler(ExpressNet.Middlewares.Pipeline pipeline, ExpressNet.Di.ServiceScope services);
```
#### Parameters

<a name='ExpressNet.Flow.Handlers.MiddlewareHandler.MiddlewareHandler(ExpressNet.Middlewares.Pipeline,ExpressNet.Di.ServiceScope).pipeline'></a>

`pipeline` [Pipeline](ExpressNet.Middlewares.Pipeline.md 'ExpressNet.Middlewares.Pipeline')

The pipeline to execute middleware.

<a name='ExpressNet.Flow.Handlers.MiddlewareHandler.MiddlewareHandler(ExpressNet.Middlewares.Pipeline,ExpressNet.Di.ServiceScope).services'></a>

`services` [ServiceScope](ExpressNet.Di.ServiceScope.md 'ExpressNet.Di.ServiceScope')

The service scope for resolving dependencies.