#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Middlewares.Contracts](ExpressNet.Middlewares.Contracts.md 'ExpressNet.Middlewares.Contracts')

## IMiddleware Interface

Defines a middleware component that can be used to handle HTTP requests and responses.

```csharp
public interface IMiddleware
```

| Methods | |
| :--- | :--- |
| [InvokeAsync(Context, Func&lt;Context,Task&gt;)](ExpressNet.Middlewares.Contracts.IMiddleware.InvokeAsync(ExpressNet.Ctx.Context,System.Func_ExpressNet.Ctx.Context,System.Threading.Tasks.Task_).md 'ExpressNet.Middlewares.Contracts.IMiddleware.InvokeAsync(ExpressNet.Ctx.Context, System.Func<ExpressNet.Ctx.Context,System.Threading.Tasks.Task>)') | Invokes the middleware with the given context and the next middleware in the pipeline. |
