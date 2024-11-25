#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Abstractions](ExpressNet.Flow.Abstractions.md 'ExpressNet.Flow.Abstractions').[ChainHandler&lt;Context&gt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>')

## ChainHandler<Context>.HandleAsync(Context) Method

Handles the context asynchronously. If there is a next handler, it delegates the handling to the next handler.

```csharp
public virtual System.Threading.Tasks.Task HandleAsync(Context context);
```
#### Parameters

<a name='ExpressNet.Flow.Abstractions.ChainHandler_Context_.HandleAsync(Context).context'></a>

`context` [Context](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md#ExpressNet.Flow.Abstractions.ChainHandler_Context_.Context 'ExpressNet.Flow.Abstractions.ChainHandler<Context>.Context')

The context to handle.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.