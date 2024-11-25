#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx')

## Context Class

Represents the context for an HTTP request and response.

```csharp
public sealed class Context
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Context

| Constructors | |
| :--- | :--- |
| [Context(HttpListenerContext, Configuration)](ExpressNet.Ctx.Context.Context(System.Net.HttpListenerContext,ExpressNet.Configs.Configuration).md 'ExpressNet.Ctx.Context.Context(System.Net.HttpListenerContext, ExpressNet.Configs.Configuration)') | Initializes a new instance of the [Context](ExpressNet.Ctx.Context.md 'ExpressNet.Ctx.Context') class with the specified HTTP listener context and configuration. |

| Fields | |
| :--- | :--- |
| [Configuration](ExpressNet.Ctx.Context.Configuration.md 'ExpressNet.Ctx.Context.Configuration') | Gets the configuration settings for the application, server, static files, and custom configurations. |
| [Data](ExpressNet.Ctx.Context.Data.md 'ExpressNet.Ctx.Context.Data') | Gets the data context for storing and retrieving data associated with the current context. |
| [Request](ExpressNet.Ctx.Context.Request.md 'ExpressNet.Ctx.Context.Request') | Gets the request context containing details about the HTTP request. |
| [Response](ExpressNet.Ctx.Context.Response.md 'ExpressNet.Ctx.Context.Response') | Gets the response context containing details about the HTTP response. |
| [User](ExpressNet.Ctx.Context.User.md 'ExpressNet.Ctx.Context.User') | Gets or sets the user principal associated with the current context. |

| Methods | |
| :--- | :--- |
| [GetHttpContext()](ExpressNet.Ctx.Context.GetHttpContext().md 'ExpressNet.Ctx.Context.GetHttpContext()') | Gets the raw HTTP listener context. |
