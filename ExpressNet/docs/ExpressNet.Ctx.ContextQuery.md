#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx')

## ContextQuery Class

Represents a query context that stores key-value pairs parsed from a query string.

```csharp
public sealed class ContextQuery
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ContextQuery

| Constructors | |
| :--- | :--- |
| [ContextQuery(NameValueCollection)](ExpressNet.Ctx.ContextQuery.ContextQuery(System.Collections.Specialized.NameValueCollection).md 'ExpressNet.Ctx.ContextQuery.ContextQuery(System.Collections.Specialized.NameValueCollection)') | Initializes a new instance of the [ContextQuery](ExpressNet.Ctx.ContextQuery.md 'ExpressNet.Ctx.ContextQuery') class with the specified query string. |

| Methods | |
| :--- | :--- |
| [Count()](ExpressNet.Ctx.ContextQuery.Count().md 'ExpressNet.Ctx.ContextQuery.Count()') | Gets the number of key-value pairs contained in the context query. |
| [Exists(string)](ExpressNet.Ctx.ContextQuery.Exists(string).md 'ExpressNet.Ctx.ContextQuery.Exists(string)') | Determines whether the context query contains the specified key. |
| [Get&lt;T&gt;(string)](ExpressNet.Ctx.ContextQuery.Get_T_(string).md 'ExpressNet.Ctx.ContextQuery.Get<T>(string)') | Gets the value associated with the specified key and converts it to the specified type. |
