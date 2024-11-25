#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Http](ExpressNet.Http.md 'ExpressNet.Http')

## Server Class

Represents an HTTP server that listens for incoming HTTP requests.

```csharp
internal class Server
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Server

| Constructors | |
| :--- | :--- |
| [Server()](ExpressNet.Http.Server.Server().md 'ExpressNet.Http.Server.Server()') | Initializes a new instance of the [Server](ExpressNet.Http.Server.md 'ExpressNet.Http.Server') class. |

| Methods | |
| :--- | :--- |
| [Abort()](ExpressNet.Http.Server.Abort().md 'ExpressNet.Http.Server.Abort()') | Aborts the server, causing it to stop immediately. |
| [AddPrefix(string)](ExpressNet.Http.Server.AddPrefix(string).md 'ExpressNet.Http.Server.AddPrefix(string)') | Adds a URL prefix that the server should respond to. |
| [Close()](ExpressNet.Http.Server.Close().md 'ExpressNet.Http.Server.Close()') | Closes the server, releasing all resources. |
| [Configure(ServerConfiguration)](ExpressNet.Http.Server.Configure(ExpressNet.Configs.Configurations.ServerConfiguration).md 'ExpressNet.Http.Server.Configure(ExpressNet.Configs.Configurations.ServerConfiguration)') | Configures the server with the specified settings. |
| [GetContextAsync()](ExpressNet.Http.Server.GetContextAsync().md 'ExpressNet.Http.Server.GetContextAsync()') | Asynchronously gets the context for an incoming request. |
| [Start()](ExpressNet.Http.Server.Start().md 'ExpressNet.Http.Server.Start()') | Starts the HTTP server. |
| [Stop()](ExpressNet.Http.Server.Stop().md 'ExpressNet.Http.Server.Stop()') | Stops the server. |
