#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Security](ExpressNet.Security.md 'ExpressNet.Security').[DefaultPrincipal](ExpressNet.Security.DefaultPrincipal.md 'ExpressNet.Security.DefaultPrincipal')

## DefaultPrincipal.IsInRole(string) Method

Determines whether the current principal belongs to the specified role.

```csharp
public bool IsInRole(string role);
```
#### Parameters

<a name='ExpressNet.Security.DefaultPrincipal.IsInRole(string).role'></a>

`role` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the role to check.

Implements [IsInRole(string)](https://docs.microsoft.com/en-us/dotnet/api/System.Security.Principal.IPrincipal.IsInRole#System_Security_Principal_IPrincipal_IsInRole_System_String_ 'System.Security.Principal.IPrincipal.IsInRole(System.String)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the current principal is a member of the specified role; otherwise, `false`.