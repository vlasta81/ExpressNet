#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Di](ExpressNet.Di.md 'ExpressNet.Di').[ServiceScope](ExpressNet.Di.ServiceScope.md 'ExpressNet.Di.ServiceScope')

## ServiceScope.Resolve(Type) Method

Resolves an instance of the specified service type.

```csharp
public object Resolve(System.Type serviceType);
```
#### Parameters

<a name='ExpressNet.Di.ServiceScope.Resolve(System.Type).serviceType'></a>

`serviceType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of the service to resolve.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An instance of the specified service type.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Thrown when the service type is not registered.