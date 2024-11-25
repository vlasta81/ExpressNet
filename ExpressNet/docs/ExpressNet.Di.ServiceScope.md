#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Di](ExpressNet.Di.md 'ExpressNet.Di')

## ServiceScope Class

Represents a scope for resolving scoped services in a dependency injection container.

```csharp
public sealed class ServiceScope :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ServiceScope

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Constructors | |
| :--- | :--- |
| [ServiceScope(Services)](ExpressNet.Di.ServiceScope.ServiceScope(ExpressNet.Di.Services).md 'ExpressNet.Di.ServiceScope.ServiceScope(ExpressNet.Di.Services)') | Initializes a new instance of the [ServiceScope](ExpressNet.Di.ServiceScope.md 'ExpressNet.Di.ServiceScope') class. |

| Methods | |
| :--- | :--- |
| [Dispose()](ExpressNet.Di.ServiceScope.Dispose().md 'ExpressNet.Di.ServiceScope.Dispose()') | Disposes the scope and clears all scoped instances. |
| [Resolve(Type)](ExpressNet.Di.ServiceScope.Resolve(System.Type).md 'ExpressNet.Di.ServiceScope.Resolve(System.Type)') | Resolves an instance of the specified service type. |
| [Resolve&lt;TService&gt;()](ExpressNet.Di.ServiceScope.Resolve_TService_().md 'ExpressNet.Di.ServiceScope.Resolve<TService>()') | Resolves an instance of the specified service type. |
