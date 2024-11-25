#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Middlewares](ExpressNet.Middlewares.md 'ExpressNet.Middlewares').[Pipeline](ExpressNet.Middlewares.Pipeline.md 'ExpressNet.Middlewares.Pipeline')

## Pipeline.InvokeMiddlewareAsync(int, Context, ServiceScope) Method

Invokes the middleware at the specified index asynchronously.

```csharp
internal System.Threading.Tasks.Task InvokeMiddlewareAsync(int index, ExpressNet.Ctx.Context context, ExpressNet.Di.ServiceScope services);
```
#### Parameters

<a name='ExpressNet.Middlewares.Pipeline.InvokeMiddlewareAsync(int,ExpressNet.Ctx.Context,ExpressNet.Di.ServiceScope).index'></a>

`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index of the middleware to invoke.

<a name='ExpressNet.Middlewares.Pipeline.InvokeMiddlewareAsync(int,ExpressNet.Ctx.Context,ExpressNet.Di.ServiceScope).context'></a>

`context` [Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context')

The context for the current request and response.

<a name='ExpressNet.Middlewares.Pipeline.InvokeMiddlewareAsync(int,ExpressNet.Ctx.Context,ExpressNet.Di.ServiceScope).services'></a>

`services` [ServiceScope](ExpressNet.Di.ServiceScope.md 'ExpressNet.Di.ServiceScope')

The service scope for resolving dependencies.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.