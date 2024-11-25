#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet](ExpressNet.md 'ExpressNet')

## Application Class

Represents the main application class responsible for configuring and running the server.

```csharp
public sealed class Application
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Application

| Constructors | |
| :--- | :--- |
| [Application(Action&lt;Configurator&gt;)](ExpressNet.Application.Application(System.Action_ExpressNet.Configs.Configurator_).md 'ExpressNet.Application.Application(System.Action<ExpressNet.Configs.Configurator>)') | Initializes a new instance of the [Application](ExpressNet.Application.md 'ExpressNet.Application') class with the specified configuration action. |

| Methods | |
| :--- | :--- |
| [Add&lt;TEndpoint&gt;()](ExpressNet.Application.Add_TEndpoint_().md 'ExpressNet.Application.Add<TEndpoint>()') | Adds an endpoint to the router. |
| [AddRange&lt;TGroupEndpoints&gt;()](ExpressNet.Application.AddRange_TGroupEndpoints_().md 'ExpressNet.Application.AddRange<TGroupEndpoints>()') | Adds a group of endpoints to the router. |
| [Register&lt;TService&gt;(Func&lt;Services,TService&gt;, ServiceLifetime)](ExpressNet.Application.Register_TService_(System.Func_ExpressNet.Di.Services,TService_,ExpressNet.Di.ServiceLifetime).md 'ExpressNet.Application.Register<TService>(System.Func<ExpressNet.Di.Services,TService>, ExpressNet.Di.ServiceLifetime)') | Registers a service with the specified factory method and lifetime. |
| [RunAsync(string)](ExpressNet.Application.RunAsync(string).md 'ExpressNet.Application.RunAsync(string)') | Runs the application asynchronously with the specified URL. |
| [Use&lt;TMiddleware&gt;()](ExpressNet.Application.Use_TMiddleware_().md 'ExpressNet.Application.Use<TMiddleware>()') | Adds a middleware to the pipeline. |
