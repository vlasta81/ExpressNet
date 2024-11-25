#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Abstractions](ExpressNet.Flow.Abstractions.md 'ExpressNet.Flow.Abstractions')

## ChainHandler<Context> Class

Represents an abstract base class for a handler in a chain of responsibility pattern.

```csharp
internal abstract class ChainHandler<Context>
```
#### Type parameters

<a name='ExpressNet.Flow.Abstractions.ChainHandler_Context_.Context'></a>

`Context`

The type of the context.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ChainHandler<Context>

Derived  
&#8627; [AuthenticationHandler](ExpressNet.Flow.Handlers.AuthenticationHandler.md 'ExpressNet.Flow.Handlers.AuthenticationHandler')  
&#8627; [EndpointHandler](ExpressNet.Flow.Handlers.EndpointHandler.md 'ExpressNet.Flow.Handlers.EndpointHandler')  
&#8627; [MiddlewareHandler](ExpressNet.Flow.Handlers.MiddlewareHandler.md 'ExpressNet.Flow.Handlers.MiddlewareHandler')  
&#8627; [NullEndpointHandler](ExpressNet.Flow.Handlers.NullEndpointHandler.md 'ExpressNet.Flow.Handlers.NullEndpointHandler')  
&#8627; [StaticFilesHandler](ExpressNet.Flow.Handlers.StaticFilesHandler.md 'ExpressNet.Flow.Handlers.StaticFilesHandler')

| Methods | |
| :--- | :--- |
| [HandleAsync(Context)](ExpressNet.Flow.Abstractions.ChainHandler_Context_.HandleAsync(Context).md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>.HandleAsync(Context)') | Handles the context asynchronously. If there is a next handler, it delegates the handling to the next handler. |
| [SetNext(IChainHandler&lt;Context&gt;)](ExpressNet.Flow.Abstractions.ChainHandler_Context_.SetNext(ExpressNet.Flow.Contracts.IChainHandler_Context_).md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>.SetNext(ExpressNet.Flow.Contracts.IChainHandler<Context>)') | Sets the next handler in the chain. |
