#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Security](ExpressNet.Security.md 'ExpressNet.Security')

## DefaultPrincipal Class

Represents the default implementation of the [System.Security.Principal.IPrincipal](https://docs.microsoft.com/en-us/dotnet/api/System.Security.Principal.IPrincipal 'System.Security.Principal.IPrincipal') interface.

```csharp
public sealed class DefaultPrincipal :
System.Security.Principal.IPrincipal
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DefaultPrincipal

Implements [System.Security.Principal.IPrincipal](https://docs.microsoft.com/en-us/dotnet/api/System.Security.Principal.IPrincipal 'System.Security.Principal.IPrincipal')

| Constructors | |
| :--- | :--- |
| [DefaultPrincipal(IIdentity, string[])](ExpressNet.Security.DefaultPrincipal.DefaultPrincipal(System.Security.Principal.IIdentity,string[]).md 'ExpressNet.Security.DefaultPrincipal.DefaultPrincipal(System.Security.Principal.IIdentity, string[])') | Initializes a new instance of the [DefaultPrincipal](ExpressNet.Security.DefaultPrincipal.md 'ExpressNet.Security.DefaultPrincipal') class with the specified identity and optional roles. |

| Properties | |
| :--- | :--- |
| [Identity](ExpressNet.Security.DefaultPrincipal.Identity.md 'ExpressNet.Security.DefaultPrincipal.Identity') | Gets the identity of the current principal. |
| [Roles](ExpressNet.Security.DefaultPrincipal.Roles.md 'ExpressNet.Security.DefaultPrincipal.Roles') | Gets the roles associated with the current principal. |

| Methods | |
| :--- | :--- |
| [IsInRole(string)](ExpressNet.Security.DefaultPrincipal.IsInRole(string).md 'ExpressNet.Security.DefaultPrincipal.IsInRole(string)') | Determines whether the current principal belongs to the specified role. |
