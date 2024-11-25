#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx')

## ContextParams Class

Represents a thread-safe collection of context parameters.

```csharp
public sealed class ContextParams
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ContextParams

| Constructors | |
| :--- | :--- |
| [ContextParams(ConcurrentDictionary&lt;string,object&gt;)](ExpressNet.Ctx.ContextParams.ContextParams(System.Collections.Concurrent.ConcurrentDictionary_string,object_).md 'ExpressNet.Ctx.ContextParams.ContextParams(System.Collections.Concurrent.ConcurrentDictionary<string,object>)') | Initializes a new instance of the [ContextParams](ExpressNet.Ctx.ContextParams.md 'ExpressNet.Ctx.ContextParams') class with the specified parameters. |

| Methods | |
| :--- | :--- |
| [Count()](ExpressNet.Ctx.ContextParams.Count().md 'ExpressNet.Ctx.ContextParams.Count()') | Gets the number of key-value pairs contained in the context parameters. |
| [Exists(string)](ExpressNet.Ctx.ContextParams.Exists(string).md 'ExpressNet.Ctx.ContextParams.Exists(string)') | Determines whether the context parameters contain the specified key. |
| [Get&lt;T&gt;(string)](ExpressNet.Ctx.ContextParams.Get_T_(string).md 'ExpressNet.Ctx.ContextParams.Get<T>(string)') | Gets the value associated with the specified key. |
