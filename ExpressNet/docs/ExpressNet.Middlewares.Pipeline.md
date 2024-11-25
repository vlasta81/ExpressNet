#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Middlewares](ExpressNet.Middlewares.md 'ExpressNet.Middlewares')

## Pipeline Class

Represents a pipeline for managing and invoking middleware components.

```csharp
public sealed class Pipeline
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Pipeline

| Constructors | |
| :--- | :--- |
| [Pipeline()](ExpressNet.Middlewares.Pipeline.Pipeline().md 'ExpressNet.Middlewares.Pipeline.Pipeline()') | Initializes a new instance of the [Pipeline](ExpressNet.Middlewares.Pipeline.md 'ExpressNet.Middlewares.Pipeline') class. |

| Methods | |
| :--- | :--- |
| [InvokeMiddlewareAsync(int, Context, ServiceScope)](ExpressNet.Middlewares.Pipeline.InvokeMiddlewareAsync(int,ExpressNet.Ctx.Context,ExpressNet.Di.ServiceScope).md 'ExpressNet.Middlewares.Pipeline.InvokeMiddlewareAsync(int, ExpressNet.Ctx.Context, ExpressNet.Di.ServiceScope)') | Invokes the middleware at the specified index asynchronously. |
| [Use(Type)](ExpressNet.Middlewares.Pipeline.Use(System.Type).md 'ExpressNet.Middlewares.Pipeline.Use(System.Type)') | Adds a middleware type to the pipeline. |
| [Use&lt;TMiddleware&gt;()](ExpressNet.Middlewares.Pipeline.Use_TMiddleware_().md 'ExpressNet.Middlewares.Pipeline.Use<TMiddleware>()') | Adds a middleware type to the pipeline. |
