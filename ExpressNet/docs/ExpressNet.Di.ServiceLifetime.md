#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Di](ExpressNet.Di.md 'ExpressNet.Di')

## ServiceLifetime Enum

Specifies the lifetime of a service in the dependency injection container.

```csharp
public enum ServiceLifetime
```
### Fields

<a name='ExpressNet.Di.ServiceLifetime.Scoped'></a>

`Scoped` 2

A new instance is created for each scope. Typically, a scope is created per request.

<a name='ExpressNet.Di.ServiceLifetime.Singleton'></a>

`Singleton` 0

A single instance is created and shared throughout the application's lifetime.

<a name='ExpressNet.Di.ServiceLifetime.Transient'></a>

`Transient` 1

A new instance is created each time the service is requested.