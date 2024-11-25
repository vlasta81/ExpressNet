#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Di](ExpressNet.Di.md 'ExpressNet.Di').[Services](ExpressNet.Di.Services.md 'ExpressNet.Di.Services')

## Services._services Field

A dictionary that holds the registered services and their descriptors.

```csharp
internal readonly ConcurrentDictionary<Type,ServiceDescriptor> _services;
```

#### Field Value
[System.Collections.Concurrent.ConcurrentDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Concurrent.ConcurrentDictionary-2 'System.Collections.Concurrent.ConcurrentDictionary`2')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Concurrent.ConcurrentDictionary-2 'System.Collections.Concurrent.ConcurrentDictionary`2')[ServiceDescriptor](ExpressNet.Di.ServiceDescriptor.md 'ExpressNet.Di.ServiceDescriptor')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Concurrent.ConcurrentDictionary-2 'System.Collections.Concurrent.ConcurrentDictionary`2')