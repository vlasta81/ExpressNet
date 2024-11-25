#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Http](ExpressNet.Http.md 'ExpressNet.Http').[Server](ExpressNet.Http.Server.md 'ExpressNet.Http.Server')

## Server.GetContextAsync() Method

Asynchronously gets the context for an incoming request.

```csharp
internal System.Threading.Tasks.Task<System.Net.HttpListenerContext> GetContextAsync();
```

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Net.HttpListenerContext](https://docs.microsoft.com/en-us/dotnet/api/System.Net.HttpListenerContext 'System.Net.HttpListenerContext')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the context for the incoming request.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Thrown when the server is not started.