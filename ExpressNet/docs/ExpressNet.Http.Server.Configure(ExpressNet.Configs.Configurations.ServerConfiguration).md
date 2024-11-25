#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Http](ExpressNet.Http.md 'ExpressNet.Http').[Server](ExpressNet.Http.Server.md 'ExpressNet.Http.Server')

## Server.Configure(ServerConfiguration) Method

Configures the server with the specified settings.

```csharp
internal void Configure(ExpressNet.Configs.Configurations.ServerConfiguration configuration);
```
#### Parameters

<a name='ExpressNet.Http.Server.Configure(ExpressNet.Configs.Configurations.ServerConfiguration).configuration'></a>

`configuration` [ServerConfiguration](ExpressNet.Configs.Configurations.ServerConfiguration.md 'ExpressNet.Configs.Configurations.ServerConfiguration')

The configuration settings to apply.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Thrown when the server is running.