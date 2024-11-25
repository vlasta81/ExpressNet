#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow](ExpressNet.Flow.md 'ExpressNet.Flow').[Chain](ExpressNet.Flow.Chain.md 'ExpressNet.Flow.Chain')

## Chain.SetNext<TChain>() Method

Sets the next handler in the chain by creating a new instance of the specified handler type.

```csharp
public void SetNext<TChain>()
    where TChain : ExpressNet.Flow.Contracts.IChainHandler<ExpressNet.Ctx.Context>, new();
```
#### Type parameters

<a name='ExpressNet.Flow.Chain.SetNext_TChain_().TChain'></a>

`TChain`

The type of the handler.