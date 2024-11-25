#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Security](ExpressNet.Security.md 'ExpressNet.Security').[DefaultPrincipal](ExpressNet.Security.DefaultPrincipal.md 'ExpressNet.Security.DefaultPrincipal')

## DefaultPrincipal(IIdentity, string[]) Constructor

Initializes a new instance of the [DefaultPrincipal](ExpressNet.Security.DefaultPrincipal.md 'ExpressNet.Security.DefaultPrincipal') class with the specified identity and optional roles.

```csharp
public DefaultPrincipal(System.Security.Principal.IIdentity identity, string[]? roles=null);
```
#### Parameters

<a name='ExpressNet.Security.DefaultPrincipal.DefaultPrincipal(System.Security.Principal.IIdentity,string[]).identity'></a>

`identity` [System.Security.Principal.IIdentity](https://docs.microsoft.com/en-us/dotnet/api/System.Security.Principal.IIdentity 'System.Security.Principal.IIdentity')

The identity of the principal.

<a name='ExpressNet.Security.DefaultPrincipal.DefaultPrincipal(System.Security.Principal.IIdentity,string[]).roles'></a>

`roles` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The roles associated with the principal. Default is null.