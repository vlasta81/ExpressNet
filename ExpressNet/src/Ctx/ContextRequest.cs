using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using Microsoft.AspNetCore.WebUtilities;

namespace ExpressNet.Ctx
{
    /// <summary>
    /// Represents an HTTP request context, providing access to various request properties and methods for reading the request body.
    /// </summary>
    public sealed class ContextRequest
    {
        private string? _body;
        private readonly HttpListenerRequest _request;

        /// <summary>
        /// Gets or sets the context parameters.
        /// </summary>
        public ContextParams? Params;

        /// <summary>
        /// Gets the query context.
        /// </summary>
        public readonly ContextQuery Query;

        /// <summary>
        /// Gets the HTTP method specified by the client.
        /// </summary>
        public string HttpMethod => _request.HttpMethod;

        /// <summary>
        /// Gets the user agent presented by the client.
        /// </summary>
        public string? UserAgent => _request.UserAgent;

        /// <summary>
        /// Gets the collection of query string variables.
        /// </summary>
        public NameValueCollection QueryString => _request.QueryString;

        /// <summary>
        /// Gets the MIME type of the body data included in the request.
        /// </summary>
        public string? ContentType => _request.ContentType;

        /// <summary>
        /// Gets the length of the body data included in the request.
        /// </summary>
        public long ContentLength64 => _request.ContentLength64;

        /// <summary>
        /// Gets a value indicating whether the TCP connection used to send the request is using SSL.
        /// </summary>
        public bool IsSecureConnection => _request.IsSecureConnection;

        /// <summary>
        /// Gets a value indicating whether the request is a WebSocket request.
        /// </summary>
        public bool IsWebSocketRequest => _request.IsWebSocketRequest;

        /// <summary>
        /// Gets a value indicating whether the client requests a persistent connection.
        /// </summary>
        public bool KeepAlive => _request.KeepAlive;

        /// <summary>
        /// Gets a value indicating whether the request is sent from the local computer.
        /// </summary>
        public bool IsLocal => _request.IsLocal;

        /// <summary>
        /// Gets a value indicating whether the client is authenticated.
        /// </summary>
        public bool IsAuthenticated => _request.IsAuthenticated;

        /// <summary>
        /// Gets a value indicating whether the request has associated body data.
        /// </summary>
        public bool HasEntityBody => _request.HasEntityBody;

        /// <summary>
        /// Gets the HTTP version used by the client.
        /// </summary>
        public Version ProtocolVersion => _request.ProtocolVersion;

        /// <summary>
        /// Gets the URL requested by the client.
        /// </summary>
        public Uri? Url => _request.Url;

        /// <summary>
        /// Gets the raw URL requested by the client.
        /// </summary>
        public string? RawUrl => _request.RawUrl;

        /// <summary>
        /// Gets the URL of the resource that referred the client to the server.
        /// </summary>
        public Uri? Referrer => _request.UrlReferrer;

        /// <summary>
        /// Gets the DNS name and, if provided, the port number specified by the client.
        /// </summary>
        public string UserHostname => _request.UserHostName;

        /// <summary>
        /// Gets the IP address and port number from which the request originated.
        /// </summary>
        public string UserHostAddress => _request.UserHostAddress;

        /// <summary>
        /// Gets the natural languages that are preferred for the response.
        /// </summary>
        public string[]? UserLanguages => _request.UserLanguages;

        /// <summary>
        /// Gets the client's X.509 v.3 certificate.
        /// </summary>
        public X509Certificate2? ClientCertificate => _request.GetClientCertificate();

        /// <summary>
        /// Gets the collection of header name/value pairs.
        /// </summary>
        public NameValueCollection Headers => _request.Headers;

        /// <summary>
        /// Gets the collection of cookies sent with the request.
        /// </summary>
        public CookieCollection Cookies => _request.Cookies;

        /// <summary>
        /// Gets the MIME types accepted by the client.
        /// </summary>
        public string[]? AcceptTypes => _request.AcceptTypes;

        /// <summary>
        /// Gets the error code returned when a client certificate is invalid.
        /// </summary>
        public int ClientCertificateError => _request.ClientCertificateError;

        /// <summary>
        /// Gets the encoding that the client uses for the body data.
        /// </summary>
        public Encoding ContentEncoding => _request.ContentEncoding;

        /// <summary>
        /// Gets the local endpoint to which the request is directed.
        /// </summary>
        public IPEndPoint LocalEndPoint => _request.LocalEndPoint;

        /// <summary>
        /// Gets the remote endpoint from which the request originated.
        /// </summary>
        public IPEndPoint RemoteEndPoint => _request.RemoteEndPoint;

        /// <summary>
        /// Gets the service name requested by the client.
        /// </summary>
        public string? ServiceName => _request.ServiceName;

        /// <summary>
        /// Gets the transport context for the request.
        /// </summary>
        public TransportContext TransportContext => _request.TransportContext;

        /// <summary>
        /// Gets the unique identifier for the request.
        /// </summary>
        public Guid RequestTraceIdentifier => _request.RequestTraceIdentifier;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextRequest"/> class with the specified HTTP listener request.
        /// </summary>
        /// <param name="request">The HTTP listener request.</param>
        public ContextRequest(HttpListenerRequest request)
        {
            _request = request;
            Params = null;
            Query = new ContextQuery(_request.QueryString);
        }

        /// <summary>
        /// Determines whether the request accepts the specified MIME type.
        /// </summary>
        /// <param name="type">The MIME type to check.</param>
        /// <returns><c>true</c> if the request accepts the specified MIME type; otherwise, <c>false</c>.</returns>
        public bool HasAcceptsType(string type)
        {
            if (AcceptTypes is null || AcceptTypes.Length == 0)
            {
                return false;
            }
            return AcceptTypes.Contains(type, StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Determines whether the request accepts the specified user language.
        /// </summary>
        /// <param name="language">The user language to check.</param>
        /// <returns><c>true</c> if the request accepts the specified user language; otherwise, <c>false</c>.</returns>
        public bool HasUserLanguage(string language)
        {
            if (UserLanguages is null || UserLanguages.Length == 0)
            {
                return false;
            }
            return UserLanguages.Any(l => l.StartsWith(language, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Gets the value of the specified header.
        /// </summary>
        /// <param name="headerName">The name of the header.</param>
        /// <returns>The value of the specified header.</returns>
        public string? GetHeader(string headerName)
        {
            return Headers[headerName];
        }

        /// <summary>
        /// Gets the cookie with the specified name.
        /// </summary>
        /// <param name="cookieName">The name of the cookie.</param>
        /// <returns>The cookie with the specified name.</returns>
        public Cookie? GetCookie(string cookieName)
        {
            return Cookies[cookieName];
        }

        /// <summary>
        /// Reads the request body as a text string asynchronously.
        /// </summary>
        /// <returns>The request body as a text string.</returns>
        public async Task<string?> ReadBodyAsTextAsync()
        {
            if (_body is null)
            {
                using (StreamReader reader = new StreamReader(_request.InputStream, _request.ContentEncoding))
                {
                    _body = await reader.ReadToEndAsync();
                }
            }
            return _body;
        }

        /// <summary>
        /// Reads the request body as an HTML string asynchronously.
        /// </summary>
        /// <returns>The request body as an HTML string.</returns>
        public async Task<string?> ReadBodyAsHtmlAsync()
        {
            if (_body is null)
            {
                using (StreamReader reader = new StreamReader(_request.InputStream, _request.ContentEncoding))
                {
                    _body = await reader.ReadToEndAsync();
                }
            }
            return _body;
        }

        /// <summary>
        /// Reads the request body as a JSON object asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of the JSON object.</typeparam>
        /// <returns>The request body as a JSON object.</returns>
        public async Task<T?> ReadBodyAsJsonAsync<T>()
        {
            if (_body is null)
            {
                using (StreamReader reader = new StreamReader(_request.InputStream, _request.ContentEncoding))
                {
                    _body = await reader.ReadToEndAsync();
                }
            }
            return JsonSerializer.Deserialize<T>(_body);
        }

        /// <summary>
        /// Reads the request body as an XML object asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of the XML object.</typeparam>
        /// <returns>The request body as an XML object.</returns>
        public async Task<T?> ReadBodyAsXmlAsync<T>()
        {
            if (_body is null)
            {
                using (StreamReader reader = new StreamReader(_request.InputStream, _request.ContentEncoding))
                {
                    _body = await reader.ReadToEndAsync();
                }
            }
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringReader stringReader = new StringReader(_body))
            {
                return (T?)serializer.Deserialize(stringReader);
            }
        }

        /// <summary>
        /// Reads the request body as a binary array asynchronously.
        /// </summary>
        /// <returns>The request body as a binary array.</returns>
        public async Task<byte[]> ReadBodyOnceAsBinaryAsync()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                await _request.InputStream.CopyToAsync(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Reads the uploaded file from the request and saves it to the specified file path asynchronously.
        /// </summary>
        /// <param name="filePath">The file path to save the uploaded file.</param>
        public async Task ReadOnceUploadedFileAsync(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await _request.InputStream.CopyToAsync(fs);
            }
        }

        /// <summary>
        /// Reads the uploaded files from the request and processes each file using the specified function asynchronously.
        /// </summary>
        /// <param name="processFile">The function to process each uploaded file.</param>
        public async Task ReadOnceUploadedFilesAsync(Func<string, Task> processFile)
        {
            if (_request.ContentType?.StartsWith("multipart/form-data") == true)
            {
                string boundary = GetBoundary(_request.ContentType);
                MultipartReader reader = new MultipartReader(boundary, _request.InputStream);
                MultipartSection? section = await reader.ReadNextSectionAsync();
                while (section is not null)
                {
                    bool hasContentDispositionHeader = ContentDispositionHeaderValue.TryParse(section.ContentDisposition, out ContentDispositionHeaderValue? contentDisposition);
                    if (hasContentDispositionHeader && contentDisposition!.DispositionType.Equals("form-data") && !string.IsNullOrEmpty(contentDisposition.FileName))
                    {
                        string tempUploadFilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                        using (FileStream targetStream = new FileStream(tempUploadFilePath, FileMode.Create, FileAccess.Write))
                        {
                            await section.Body.CopyToAsync(targetStream);
                        }
                        await processFile(tempUploadFilePath);
                        File.Delete(tempUploadFilePath);
                    }
                    section = await reader.ReadNextSectionAsync();
                }
            }
        }

        /// <summary>
        /// Gets the boundary from the content type.
        /// </summary>
        /// <param name="contentType">The content type.</param>
        /// <returns>The boundary string.</returns>
        private string GetBoundary(string contentType)
        {
            string[] elements = contentType.Split(' ');
            string? element = elements.FirstOrDefault(entry => entry.StartsWith("boundary="));
            string? boundary = element?.Substring("boundary=".Length);
            return boundary ?? string.Empty;
        }
    }
}
