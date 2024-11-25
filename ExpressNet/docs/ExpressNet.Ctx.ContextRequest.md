#### [ExpressNet](ExpressNet.md 'ExpressNet')
### [ExpressNet.Ctx](ExpressNet.Ctx.md 'ExpressNet.Ctx')

## ContextRequest Class

Represents an HTTP request context, providing access to various request properties and methods for reading the request body.

```csharp
public sealed class ContextRequest
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ContextRequest

| Constructors | |
| :--- | :--- |
| [ContextRequest(HttpListenerRequest)](ExpressNet.Ctx.ContextRequest.ContextRequest(System.Net.HttpListenerRequest).md 'ExpressNet.Ctx.ContextRequest.ContextRequest(System.Net.HttpListenerRequest)') | Initializes a new instance of the [ContextRequest](ExpressNet.Ctx.ContextRequest.md 'ExpressNet.Ctx.ContextRequest') class with the specified HTTP listener request. |

| Fields | |
| :--- | :--- |
| [Params](ExpressNet.Ctx.ContextRequest.Params.md 'ExpressNet.Ctx.ContextRequest.Params') | Gets or sets the context parameters. |
| [Query](ExpressNet.Ctx.ContextRequest.Query.md 'ExpressNet.Ctx.ContextRequest.Query') | Gets the query context. |

| Properties | |
| :--- | :--- |
| [AcceptTypes](ExpressNet.Ctx.ContextRequest.AcceptTypes.md 'ExpressNet.Ctx.ContextRequest.AcceptTypes') | Gets the MIME types accepted by the client. |
| [ClientCertificate](ExpressNet.Ctx.ContextRequest.ClientCertificate.md 'ExpressNet.Ctx.ContextRequest.ClientCertificate') | Gets the client's X.509 v.3 certificate. |
| [ClientCertificateError](ExpressNet.Ctx.ContextRequest.ClientCertificateError.md 'ExpressNet.Ctx.ContextRequest.ClientCertificateError') | Gets the error code returned when a client certificate is invalid. |
| [ContentEncoding](ExpressNet.Ctx.ContextRequest.ContentEncoding.md 'ExpressNet.Ctx.ContextRequest.ContentEncoding') | Gets the encoding that the client uses for the body data. |
| [ContentLength64](ExpressNet.Ctx.ContextRequest.ContentLength64.md 'ExpressNet.Ctx.ContextRequest.ContentLength64') | Gets the length of the body data included in the request. |
| [ContentType](ExpressNet.Ctx.ContextRequest.ContentType.md 'ExpressNet.Ctx.ContextRequest.ContentType') | Gets the MIME type of the body data included in the request. |
| [Cookies](ExpressNet.Ctx.ContextRequest.Cookies.md 'ExpressNet.Ctx.ContextRequest.Cookies') | Gets the collection of cookies sent with the request. |
| [HasEntityBody](ExpressNet.Ctx.ContextRequest.HasEntityBody.md 'ExpressNet.Ctx.ContextRequest.HasEntityBody') | Gets a value indicating whether the request has associated body data. |
| [Headers](ExpressNet.Ctx.ContextRequest.Headers.md 'ExpressNet.Ctx.ContextRequest.Headers') | Gets the collection of header name/value pairs. |
| [HttpMethod](ExpressNet.Ctx.ContextRequest.HttpMethod.md 'ExpressNet.Ctx.ContextRequest.HttpMethod') | Gets the HTTP method specified by the client. |
| [IsAuthenticated](ExpressNet.Ctx.ContextRequest.IsAuthenticated.md 'ExpressNet.Ctx.ContextRequest.IsAuthenticated') | Gets a value indicating whether the client is authenticated. |
| [IsLocal](ExpressNet.Ctx.ContextRequest.IsLocal.md 'ExpressNet.Ctx.ContextRequest.IsLocal') | Gets a value indicating whether the request is sent from the local computer. |
| [IsSecureConnection](ExpressNet.Ctx.ContextRequest.IsSecureConnection.md 'ExpressNet.Ctx.ContextRequest.IsSecureConnection') | Gets a value indicating whether the TCP connection used to send the request is using SSL. |
| [IsWebSocketRequest](ExpressNet.Ctx.ContextRequest.IsWebSocketRequest.md 'ExpressNet.Ctx.ContextRequest.IsWebSocketRequest') | Gets a value indicating whether the request is a WebSocket request. |
| [KeepAlive](ExpressNet.Ctx.ContextRequest.KeepAlive.md 'ExpressNet.Ctx.ContextRequest.KeepAlive') | Gets a value indicating whether the client requests a persistent connection. |
| [LocalEndPoint](ExpressNet.Ctx.ContextRequest.LocalEndPoint.md 'ExpressNet.Ctx.ContextRequest.LocalEndPoint') | Gets the local endpoint to which the request is directed. |
| [ProtocolVersion](ExpressNet.Ctx.ContextRequest.ProtocolVersion.md 'ExpressNet.Ctx.ContextRequest.ProtocolVersion') | Gets the HTTP version used by the client. |
| [QueryString](ExpressNet.Ctx.ContextRequest.QueryString.md 'ExpressNet.Ctx.ContextRequest.QueryString') | Gets the collection of query string variables. |
| [RawUrl](ExpressNet.Ctx.ContextRequest.RawUrl.md 'ExpressNet.Ctx.ContextRequest.RawUrl') | Gets the raw URL requested by the client. |
| [Referrer](ExpressNet.Ctx.ContextRequest.Referrer.md 'ExpressNet.Ctx.ContextRequest.Referrer') | Gets the URL of the resource that referred the client to the server. |
| [RemoteEndPoint](ExpressNet.Ctx.ContextRequest.RemoteEndPoint.md 'ExpressNet.Ctx.ContextRequest.RemoteEndPoint') | Gets the remote endpoint from which the request originated. |
| [RequestTraceIdentifier](ExpressNet.Ctx.ContextRequest.RequestTraceIdentifier.md 'ExpressNet.Ctx.ContextRequest.RequestTraceIdentifier') | Gets the unique identifier for the request. |
| [ServiceName](ExpressNet.Ctx.ContextRequest.ServiceName.md 'ExpressNet.Ctx.ContextRequest.ServiceName') | Gets the service name requested by the client. |
| [TransportContext](ExpressNet.Ctx.ContextRequest.TransportContext.md 'ExpressNet.Ctx.ContextRequest.TransportContext') | Gets the transport context for the request. |
| [Url](ExpressNet.Ctx.ContextRequest.Url.md 'ExpressNet.Ctx.ContextRequest.Url') | Gets the URL requested by the client. |
| [UserAgent](ExpressNet.Ctx.ContextRequest.UserAgent.md 'ExpressNet.Ctx.ContextRequest.UserAgent') | Gets the user agent presented by the client. |
| [UserHostAddress](ExpressNet.Ctx.ContextRequest.UserHostAddress.md 'ExpressNet.Ctx.ContextRequest.UserHostAddress') | Gets the IP address and port number from which the request originated. |
| [UserHostname](ExpressNet.Ctx.ContextRequest.UserHostname.md 'ExpressNet.Ctx.ContextRequest.UserHostname') | Gets the DNS name and, if provided, the port number specified by the client. |
| [UserLanguages](ExpressNet.Ctx.ContextRequest.UserLanguages.md 'ExpressNet.Ctx.ContextRequest.UserLanguages') | Gets the natural languages that are preferred for the response. |

| Methods | |
| :--- | :--- |
| [GetCookie(string)](ExpressNet.Ctx.ContextRequest.GetCookie(string).md 'ExpressNet.Ctx.ContextRequest.GetCookie(string)') | Gets the cookie with the specified name. |
| [GetHeader(string)](ExpressNet.Ctx.ContextRequest.GetHeader(string).md 'ExpressNet.Ctx.ContextRequest.GetHeader(string)') | Gets the value of the specified header. |
| [HasAcceptsType(string)](ExpressNet.Ctx.ContextRequest.HasAcceptsType(string).md 'ExpressNet.Ctx.ContextRequest.HasAcceptsType(string)') | Determines whether the request accepts the specified MIME type. |
| [HasUserLanguage(string)](ExpressNet.Ctx.ContextRequest.HasUserLanguage(string).md 'ExpressNet.Ctx.ContextRequest.HasUserLanguage(string)') | Determines whether the request accepts the specified user language. |
| [ReadBodyAsHtmlAsync()](ExpressNet.Ctx.ContextRequest.ReadBodyAsHtmlAsync().md 'ExpressNet.Ctx.ContextRequest.ReadBodyAsHtmlAsync()') | Reads the request body as an HTML string asynchronously. |
| [ReadBodyAsJsonAsync&lt;T&gt;()](ExpressNet.Ctx.ContextRequest.ReadBodyAsJsonAsync_T_().md 'ExpressNet.Ctx.ContextRequest.ReadBodyAsJsonAsync<T>()') | Reads the request body as a JSON object asynchronously. |
| [ReadBodyAsTextAsync()](ExpressNet.Ctx.ContextRequest.ReadBodyAsTextAsync().md 'ExpressNet.Ctx.ContextRequest.ReadBodyAsTextAsync()') | Reads the request body as a text string asynchronously. |
| [ReadBodyAsXmlAsync&lt;T&gt;()](ExpressNet.Ctx.ContextRequest.ReadBodyAsXmlAsync_T_().md 'ExpressNet.Ctx.ContextRequest.ReadBodyAsXmlAsync<T>()') | Reads the request body as an XML object asynchronously. |
| [ReadBodyOnceAsBinaryAsync()](ExpressNet.Ctx.ContextRequest.ReadBodyOnceAsBinaryAsync().md 'ExpressNet.Ctx.ContextRequest.ReadBodyOnceAsBinaryAsync()') | Reads the request body as a binary array asynchronously. |
| [ReadOnceUploadedFileAsync(string)](ExpressNet.Ctx.ContextRequest.ReadOnceUploadedFileAsync(string).md 'ExpressNet.Ctx.ContextRequest.ReadOnceUploadedFileAsync(string)') | Reads the uploaded file from the request and saves it to the specified file path asynchronously. |
| [ReadOnceUploadedFilesAsync(Func&lt;string,Task&gt;)](ExpressNet.Ctx.ContextRequest.ReadOnceUploadedFilesAsync(System.Func_string,System.Threading.Tasks.Task_).md 'ExpressNet.Ctx.ContextRequest.ReadOnceUploadedFilesAsync(System.Func<string,System.Threading.Tasks.Task>)') | Reads the uploaded files from the request and processes each file using the specified function asynchronously. |
