#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Configs.Configurations](ExpressNet.Configs.Configurations.md 'ExpressNet.Configs.Configurations')

## ServerConfiguration Class

Represents the configuration settings for the server.

```csharp
public sealed class ServerConfiguration
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ServerConfiguration

| Properties | |
| :--- | :--- |
| [AuthenticationScheme](ExpressNet.Configs.Configurations.ServerConfiguration.AuthenticationScheme.md 'ExpressNet.Configs.Configurations.ServerConfiguration.AuthenticationScheme') | Gets or sets the authentication scheme used by the server.<br/>Default is [System.Net.AuthenticationSchemes.Anonymous](https://docs.microsoft.com/en-us/dotnet/api/System.Net.AuthenticationSchemes.Anonymous 'System.Net.AuthenticationSchemes.Anonymous'). |
| [IdleConnectionTimeout](ExpressNet.Configs.Configurations.ServerConfiguration.IdleConnectionTimeout.md 'ExpressNet.Configs.Configurations.ServerConfiguration.IdleConnectionTimeout') | Gets or sets the timeout for idle connections.<br/>Default is 2 minutes. |
| [RequestQueueTimeout](ExpressNet.Configs.Configurations.ServerConfiguration.RequestQueueTimeout.md 'ExpressNet.Configs.Configurations.ServerConfiguration.RequestQueueTimeout') | Gets or sets the timeout for the request queue.<br/>Default is 1 minute. |
