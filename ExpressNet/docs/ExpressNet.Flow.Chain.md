#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow](ExpressNet.Flow.md 'ExpressNet.Flow')

## Chain Class

Represents a chain of responsibility pattern for handling HTTP request and response contexts.

```csharp
internal sealed class Chain
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Chain

| Methods | |
| :--- | :--- |
| [ExecuteAsync(Context)](ExpressNet.Flow.Chain.ExecuteAsync(ExpressNet.Ctx.Context).md 'ExpressNet.Flow.Chain.ExecuteAsync(ExpressNet.Ctx.Context)') | Executes the chain of handlers asynchronously. |
| [SetNext&lt;TChain&gt;()](ExpressNet.Flow.Chain.SetNext_TChain_().md 'ExpressNet.Flow.Chain.SetNext<TChain>()') | Sets the next handler in the chain by creating a new instance of the specified handler type. |
| [SetNext&lt;TChain&gt;(TChain)](ExpressNet.Flow.Chain.SetNext_TChain_(TChain).md 'ExpressNet.Flow.Chain.SetNext<TChain>(TChain)') | Sets the next handler in the chain. |
