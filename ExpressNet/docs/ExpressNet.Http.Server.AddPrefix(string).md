#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Http](ExpressNet.Http.md 'ExpressNet.Http').[Server](ExpressNet.Http.Server.md 'ExpressNet.Http.Server')

## Server.AddPrefix(string) Method

Adds a URL prefix that the server should respond to.

```csharp
internal void AddPrefix(string url);
```
#### Parameters

<a name='ExpressNet.Http.Server.AddPrefix(string).url'></a>

`url` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The URL prefix to add.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Thrown when the server is running.