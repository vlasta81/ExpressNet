
# ExpressNet (beta)

ExpressNet is a simple web framework for .NET 9 that enables easy creation of web applications and APIs.

## Features

- Support for static files
- Middleware architecture
- Easy service and endpoint registration

## Download

The current library can be downloaded here: **[DOWNLOAD](https://github.com/vlasta81/ExpressNet/blob/master/ExpressNet/README-EN.md)**

## Installation

In Visual Studio, add a reference to the dll library **ExpressNet.dll** or compile your own.
   
## Usage

### Program.cs

```
using ExpressNet;
```

```
public static async Task Main(string[] args)
{
	Application app = new Application(configurator =>
	{
		configurator.Application.Name = "WebApplication1";
		configurator.Application.Description = "A simple web application.";
		configurator.Application.Version = "1.0.0";
		configurator.Application.Author = "John Doe";
		configurator.Application.Url = "https://example.com";

		configurator.Server.AuthenticationScheme = System.Net.AuthenticationSchemes.Anonymous;
		configurator.Server.RequestQueueTimeout = TimeSpan.FromMinutes(1);
		configurator.Server.IdleConnectionTimeout = TimeSpan.FromMinutes(2);

		configurator.StaticFiles.Directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
		configurator.StaticFiles.Lifetime = 3600;

		configurator.Custom = null;
	});

	app.Register((services) => new SingletonService(), ExpressNet.Di.ServiceLifetime.Singleton);
	app.Register((services) => new TransientService(), ExpressNet.Di.ServiceLifetime.Transient);
	app.Register((services) => new ScopedService(), ExpressNet.Di.ServiceLifetime.Scoped);

	app.Add<IndexEndpoint>();
	app.AddRange<MainEndpoints>();

	app.Use<FirstMiddleware>();
	app.Use<SecondMiddleware>();

	await app.RunAsync("https://localhost:9001/");
}
```

### Own configuration

```
using ExpressNet.Configs.Contracts;
```

```
public class CustomConfiguration : ICustomConfiguration
{
    public bool Exists(string key)
    {
            
    }

    public TType Get<TType>(string key)
    {
            
    }
}
```

```
configurator.Custom = new CustomConfiguration();
```

### Endpoint

```
using ExpressNet.Attributes;
using ExpressNet.Ctx;
using ExpressNet.Di;
using ExpressNet.Routing.Contracts;
```

```
[Endpoint("GET", "/")]
public class IndexEndpoint : IEndpoint
{
    private readonly SingletonService _singletonService;

    public IndexEndpoint(ServiceScope services)
    {
        _singletonService = services.Resolve<SingletonService>();
        services.Resolve<TransientService>();
        services.Resolve<ScopedService>();
    }

    public async Task HandleAsync(Context context)
    {
        await context.Response.WriteAsTextAsync("Hello, World!");
    }
}
```

### Authentication

```
using ExpressNet.Attributes;
using ExpressNet.Ctx;
using ExpressNet.Di;
using ExpressNet.Routing.Contracts;
```

```
[Endpoint("GET", "/About")]
[RequireAuthentication]
public class AboutEndpoint : IEndpoint
{
}
```

Authentication supports only:
- System.Net.AuthenticationSchemes.Anonymous
- System.Net.AuthenticationSchemes.Basic
- System.Net.AuthenticationSchemes.Digest

It is possible to create middleware and manage your own authentication system.

```
using ExpressNet.Security;
using ExpressNet.Ctx;
using ExpressNet.Di;
using IMiddleware = ExpressNet.Middlewares.Contracts.IMiddleware;
```

```
public class AuthenticationMiddleware : IMiddleware
{
    public AuthenticationMiddleware(ServiceScope services)
    {
    }

    public async Task InvokeAsync(Context context, Func<Context, Task> next)
    {
		context.User = new DefaultPrincipal(new DefaultIdentity("Bearer", "John Doe", true), new string[] { "User" });
        await next(context);
    }
}
```

### Group endpoint

```
using ExpressNet.Routing;
using ExpressNet.Routing.Contracts;
```

```
public class MainEndpoints : IGroupEndpoints
{
    public void AddEndpoints(Router router)
    {
        router.Add<HomeEndpoint>();
        router.Add<AboutEndpoint>();
    }
}
```

### Middleware

```
using ExpressNet.Ctx;
using ExpressNet.Di;
using IMiddleware = ExpressNet.Middlewares.Contracts.IMiddleware;
```

```
public class FirstMiddleware : IMiddleware
{
	private readonly ScopedService _scopedService;
		
    public FirstMiddleware(ServiceScope services)
    {
        _scopedService = services.Resolve<ScopedService>();
    }

    public async Task InvokeAsync(Context context, Func<Context, Task> next)
    {
		await context.Response.WriteAsTextAsync("Hello, World!");
		    
		OR
		    
        await next(context);
    }
}
```

## Author

(c) 2024 vlasta81

## License

MIT
