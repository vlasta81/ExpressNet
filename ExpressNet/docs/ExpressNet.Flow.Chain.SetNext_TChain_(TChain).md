#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Flow](ExpressNet.Flow.md 'ExpressNet.Flow').[Chain](ExpressNet.Flow.Chain.md 'ExpressNet.Flow.Chain')

## Chain.SetNext<TChain>(TChain) Method

Sets the next handler in the chain.

```csharp
public void SetNext<TChain>(TChain handler)
    where TChain : ExpressNet.Flow.Contracts.IChainHandler<ExpressNet.Ctx.Context>;
```
#### Type parameters

<a name='ExpressNet.Flow.Chain.SetNext_TChain_(TChain).TChain'></a>

`TChain`

The type of the handler.
#### Parameters

<a name='ExpressNet.Flow.Chain.SetNext_TChain_(TChain).handler'></a>

`handler` [TChain](ExpressNet.Flow.Chain.SetNext_TChain_(TChain).md#ExpressNet.Flow.Chain.SetNext_TChain_(TChain).TChain 'ExpressNet.Flow.Chain.SetNext<TChain>(TChain).TChain')

The handler to set as the next in the chain.