#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx').[ContextRequest](ExpressNet.Ctx.ContextRequest.md 'ExpressNet.Ctx.ContextRequest')

## ContextRequest.ReadOnceUploadedFilesAsync(Func<string,Task>) Method

Reads the uploaded files from the request and processes each file using the specified function asynchronously.

```csharp
public System.Threading.Tasks.Task ReadOnceUploadedFilesAsync(System.Func<string,System.Threading.Tasks.Task> processFile);
```
#### Parameters

<a name='ExpressNet.Ctx.ContextRequest.ReadOnceUploadedFilesAsync(System.Func_string,System.Threading.Tasks.Task_).processFile'></a>

`processFile` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The function to process each uploaded file.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')