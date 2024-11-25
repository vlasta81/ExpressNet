#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Middlewares.Contracts](ExpressNet.Middlewares.Contracts.md 'ExpressNet.Middlewares.Contracts').[IMiddleware](ExpressNet.Middlewares.Contracts.IMiddleware.md 'ExpressNet.Middlewares.Contracts.IMiddleware')

## IMiddleware.InvokeAsync(Context, Func<Context,Task>) Method

Invokes the middleware with the given context and the next middleware in the pipeline.

```csharp
System.Threading.Tasks.Task InvokeAsync(ExpressNet.Ctx.Context context, System.Func<ExpressNet.Ctx.Context,System.Threading.Tasks.Task> next);
```
#### Parameters

<a name='ExpressNet.Middlewares.Contracts.IMiddleware.InvokeAsync(ExpressNet.Ctx.Context,System.Func_ExpressNet.Ctx.Context,System.Threading.Tasks.Task_).context'></a>

`context` [Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')

The context for the current HTTP request and response.

<a name='ExpressNet.Middlewares.Contracts.IMiddleware.InvokeAsync(ExpressNet.Ctx.Context,System.Func_ExpressNet.Ctx.Context,System.Threading.Tasks.Task_).next'></a>

`next` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

A function that invokes the next middleware in the pipeline.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the completion of the middleware execution.