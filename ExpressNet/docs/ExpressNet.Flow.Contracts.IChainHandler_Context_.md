#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow.Contracts](ExpressNet.Flow.Contracts.md 'ExpressNet.Flow.Contracts')

## IChainHandler<Context> Interface

Defines a handler in a chain of responsibility pattern.

```csharp
internal interface IChainHandler<Context>
```
#### Type parameters

<a name='ExpressNet.Flow.Contracts.IChainHandler_Context_.Context'></a>

`Context`

The type of the context.

Derived  
&#8627; [ChainHandler&lt;Context&gt;](ExpressNet.Flow.Abstractions.ChainHandler_Context_.md 'ExpressNet.Flow.Abstractions.ChainHandler<Context>')

| Methods | |
| :--- | :--- |
| [HandleAsync(Context)](ExpressNet.Flow.Contracts.IChainHandler_Context_.HandleAsync(Context).md 'ExpressNet.Flow.Contracts.IChainHandler<Context>.HandleAsync(Context)') | Handles the context asynchronously. |
| [SetNext(IChainHandler&lt;Context&gt;)](ExpressNet.Flow.Contracts.IChainHandler_Context_.SetNext(ExpressNet.Flow.Contracts.IChainHandler_Context_).md 'ExpressNet.Flow.Contracts.IChainHandler<Context>.SetNext(ExpressNet.Flow.Contracts.IChainHandler<Context>)') | Sets the next handler in the chain. |
