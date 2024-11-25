#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Security](ExpressNet.Security.md 'ExpressNet.Security')

## DefaultIdentity Class

Represents the default implementation of the [System.Security.Principal.IIdentity](https://docs.microsoft.com/en-us/dotnet/api/System.Security.Principal.IIdentity 'System.Security.Principal.IIdentity') interface.

```csharp
public sealed class DefaultIdentity :
System.Security.Principal.IIdentity
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DefaultIdentity

Implements [System.Security.Principal.IIdentity](https://docs.microsoft.com/en-us/dotnet/api/System.Security.Principal.IIdentity 'System.Security.Principal.IIdentity')

| Constructors | |
| :--- | :--- |
| [DefaultIdentity(string, string, bool)](ExpressNet.Security.DefaultIdentity.DefaultIdentity(string,string,bool).md 'ExpressNet.Security.DefaultIdentity.DefaultIdentity(string, string, bool)') | Initializes a new instance of the [DefaultIdentity](ExpressNet.Security.DefaultIdentity.md 'ExpressNet.Security.DefaultIdentity') class with the specified authentication type, user name, and authentication status. |

| Properties | |
| :--- | :--- |
| [AuthenticationType](ExpressNet.Security.DefaultIdentity.AuthenticationType.md 'ExpressNet.Security.DefaultIdentity.AuthenticationType') | Gets the type of authentication used. |
| [IsAuthenticated](ExpressNet.Security.DefaultIdentity.IsAuthenticated.md 'ExpressNet.Security.DefaultIdentity.IsAuthenticated') | Gets a value indicating whether the user has been authenticated. |
| [Name](ExpressNet.Security.DefaultIdentity.Name.md 'ExpressNet.Security.DefaultIdentity.Name') | Gets the name of the user. |
