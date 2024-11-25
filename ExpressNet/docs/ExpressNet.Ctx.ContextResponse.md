#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx')

## ContextResponse Class

Represents a wrapper for the HttpListenerResponse to provide various response functionalities.

```csharp
public sealed class ContextResponse
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ContextResponse

| Constructors | |
| :--- | :--- |
| [ContextResponse(HttpListenerResponse)](ExpressNet.Ctx.ContextResponse.ContextResponse(System.Net.HttpListenerResponse).md 'ExpressNet.Ctx.ContextResponse.ContextResponse(System.Net.HttpListenerResponse)') | Initializes a new instance of the [ContextResponse](ExpressNet.Ctx.ContextResponse.md 'ExpressNet.Ctx.ContextResponse') class. |

| Properties | |
| :--- | :--- |
| [ContentLength](ExpressNet.Ctx.ContextResponse.ContentLength.md 'ExpressNet.Ctx.ContextResponse.ContentLength') | Gets the content length of the response. |
| [OutputStream](ExpressNet.Ctx.ContextResponse.OutputStream.md 'ExpressNet.Ctx.ContextResponse.OutputStream') | Gets the output stream to write the response. |

| Methods | |
| :--- | :--- |
| [Abort()](ExpressNet.Ctx.ContextResponse.Abort().md 'ExpressNet.Ctx.ContextResponse.Abort()') | Aborts the response. |
| [AddHeader(string, string)](ExpressNet.Ctx.ContextResponse.AddHeader(string,string).md 'ExpressNet.Ctx.ContextResponse.AddHeader(string, string)') | Adds a header to the response. |
| [AppendCookie(Cookie)](ExpressNet.Ctx.ContextResponse.AppendCookie(System.Net.Cookie).md 'ExpressNet.Ctx.ContextResponse.AppendCookie(System.Net.Cookie)') | Appends a cookie to the response. |
| [AppendHeader(string, string)](ExpressNet.Ctx.ContextResponse.AppendHeader(string,string).md 'ExpressNet.Ctx.ContextResponse.AppendHeader(string, string)') | Appends a header to the response. |
| [Close()](ExpressNet.Ctx.ContextResponse.Close().md 'ExpressNet.Ctx.ContextResponse.Close()') | Closes the response. |
| [DownloadFileAsync(string)](ExpressNet.Ctx.ContextResponse.DownloadFileAsync(string).md 'ExpressNet.Ctx.ContextResponse.DownloadFileAsync(string)') | Sends a file to the client as a download asynchronously. |
| [KeepAlive(bool)](ExpressNet.Ctx.ContextResponse.KeepAlive(bool).md 'ExpressNet.Ctx.ContextResponse.KeepAlive(bool)') | Sets a value indicating whether the connection should be kept alive. |
| [SendChunked(bool)](ExpressNet.Ctx.ContextResponse.SendChunked(bool).md 'ExpressNet.Ctx.ContextResponse.SendChunked(bool)') | Sets a value indicating whether the response uses chunked transfer encoding. |
| [SetContentEncoding(Encoding)](ExpressNet.Ctx.ContextResponse.SetContentEncoding(System.Text.Encoding).md 'ExpressNet.Ctx.ContextResponse.SetContentEncoding(System.Text.Encoding)') | Sets the content encoding for the response. |
| [SetContentLength64(long)](ExpressNet.Ctx.ContextResponse.SetContentLength64(long).md 'ExpressNet.Ctx.ContextResponse.SetContentLength64(long)') | Sets the content length of the response. |
| [SetContentType(string)](ExpressNet.Ctx.ContextResponse.SetContentType(string).md 'ExpressNet.Ctx.ContextResponse.SetContentType(string)') | Sets the content type of the response. |
| [SetCookie(Cookie)](ExpressNet.Ctx.ContextResponse.SetCookie(System.Net.Cookie).md 'ExpressNet.Ctx.ContextResponse.SetCookie(System.Net.Cookie)') | Sets a cookie in the response. |
| [SetRedirect(string)](ExpressNet.Ctx.ContextResponse.SetRedirect(string).md 'ExpressNet.Ctx.ContextResponse.SetRedirect(string)') | Redirects the client to the specified URL. |
| [SetStatusCode(int)](ExpressNet.Ctx.ContextResponse.SetStatusCode(int).md 'ExpressNet.Ctx.ContextResponse.SetStatusCode(int)') | Sets the status code of the response. |
| [WriteAsBinaryAsync(byte[])](ExpressNet.Ctx.ContextResponse.WriteAsBinaryAsync(byte[]).md 'ExpressNet.Ctx.ContextResponse.WriteAsBinaryAsync(byte[])') | Writes the specified binary content to the response asynchronously. |
| [WriteAsHtmlAsync(string)](ExpressNet.Ctx.ContextResponse.WriteAsHtmlAsync(string).md 'ExpressNet.Ctx.ContextResponse.WriteAsHtmlAsync(string)') | Writes the specified content as HTML to the response asynchronously. |
| [WriteAsJsonAsync&lt;T&gt;(T)](ExpressNet.Ctx.ContextResponse.WriteAsJsonAsync_T_(T).md 'ExpressNet.Ctx.ContextResponse.WriteAsJsonAsync<T>(T)') | Writes the specified content as JSON to the response asynchronously. |
| [WriteAsTextAsync(string)](ExpressNet.Ctx.ContextResponse.WriteAsTextAsync(string).md 'ExpressNet.Ctx.ContextResponse.WriteAsTextAsync(string)') | Writes the specified content as plain text to the response asynchronously. |
| [WriteAsXmlAsync&lt;T&gt;(T)](ExpressNet.Ctx.ContextResponse.WriteAsXmlAsync_T_(T).md 'ExpressNet.Ctx.ContextResponse.WriteAsXmlAsync<T>(T)') | Writes the specified content as XML to the response asynchronously. |
