using System.Net;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace ExpressNet.Ctx
{
    /// <summary>
    /// Represents a wrapper for the HttpListenerResponse to provide various response functionalities.
    /// </summary>
    public sealed class ContextResponse
    {
        private readonly HttpListenerResponse _response;

        /// <summary>
        /// Gets the content length of the response.
        /// </summary>
        public long ContentLength => _response.ContentLength64;

        /// <summary>
        /// Gets the output stream to write the response.
        /// </summary>
        public Stream OutputStream => _response.OutputStream;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextResponse"/> class.
        /// </summary>
        /// <param name="response">The HttpListenerResponse to wrap.</param>
        public ContextResponse(HttpListenerResponse response)
        {
            _response = response;
        }

        /// <summary>
        /// Sets a value indicating whether the response uses chunked transfer encoding.
        /// </summary>
        /// <param name="sendChunked">True to use chunked transfer encoding; otherwise, false.</param>
        public void SendChunked(bool sendChunked)
        {
            _response.SendChunked = sendChunked;
        }

        /// <summary>
        /// Sets a value indicating whether the connection should be kept alive.
        /// </summary>
        /// <param name="keepAlive">True to keep the connection alive; otherwise, false.</param>
        public void KeepAlive(bool keepAlive)
        {
            _response.KeepAlive = keepAlive;
        }

        /// <summary>
        /// Sets the content encoding for the response.
        /// </summary>
        /// <param name="encodingType">The encoding type to set.</param>
        public void SetContentEncoding(Encoding encodingType)
        {
            _response.ContentEncoding = encodingType;
        }

        /// <summary>
        /// Sets the content length of the response.
        /// </summary>
        /// <param name="bytes">The content length in bytes.</param>
        public void SetContentLength64(long bytes)
        {
            _response.ContentLength64 = bytes;
        }

        /// <summary>
        /// Sets the content type of the response.
        /// </summary>
        /// <param name="mimeType">The MIME type to set.</param>
        public void SetContentType(string mimeType)
        {
            _response.ContentType = mimeType;
        }

        /// <summary>
        /// Sets the status code of the response.
        /// </summary>
        /// <param name="statusCode">The status code to set.</param>
        public void SetStatusCode(int statusCode)
        {
            _response.StatusCode = statusCode;
        }

        /// <summary>
        /// Redirects the client to the specified URL.
        /// </summary>
        /// <param name="url">The URL to redirect to.</param>
        public void SetRedirect(string url)
        {
            _response.Redirect(url);
        }

        /// <summary>
        /// Aborts the response.
        /// </summary>
        public void Abort()
        {
            _response.Abort();
        }

        /// <summary>
        /// Adds a header to the response.
        /// </summary>
        /// <param name="name">The name of the header.</param>
        /// <param name="value">The value of the header.</param>
        public void AddHeader(string name, string value)
        {
            _response.AddHeader(name, value);
        }

        /// <summary>
        /// Appends a header to the response.
        /// </summary>
        /// <param name="name">The name of the header.</param>
        /// <param name="value">The value of the header.</param>
        public void AppendHeader(string name, string value)
        {
            _response.AppendHeader(name, value);
        }

        /// <summary>
        /// Appends a cookie to the response.
        /// </summary>
        /// <param name="cookie">The cookie to append.</param>
        public void AppendCookie(Cookie cookie)
        {
            _response.AppendCookie(cookie);
        }

        /// <summary>
        /// Sets a cookie in the response.
        /// </summary>
        /// <param name="cookie">The cookie to set.</param>
        public void SetCookie(Cookie cookie)
        {
            _response.SetCookie(cookie);
        }

        /// <summary>
        /// Closes the response.
        /// </summary>
        public void Close()
        {
            _response.Close();
        }

        /// <summary>
        /// Writes the specified content as plain text to the response asynchronously.
        /// </summary>
        /// <param name="content">The content to write.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        public async Task WriteAsTextAsync(string content)
        {
            _response.ContentType = "text/plain";
            using (StreamWriter writer = new StreamWriter(_response.OutputStream, Encoding.UTF8))
            {
                await writer.WriteAsync(content);
            }
        }

        /// <summary>
        /// Writes the specified content as HTML to the response asynchronously.
        /// </summary>
        /// <param name="content">The content to write.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        public async Task WriteAsHtmlAsync(string content)
        {
            _response.ContentType = "text/html";
            using (StreamWriter writer = new StreamWriter(_response.OutputStream, Encoding.UTF8))
            {
                await writer.WriteAsync(content);
            }
        }

        /// <summary>
        /// Writes the specified content as JSON to the response asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of the content.</typeparam>
        /// <param name="content">The content to write.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        public async Task WriteAsJsonAsync<T>(T content)
        {
            _response.ContentType = "application/json";
            string json = JsonSerializer.Serialize(content);
            using (StreamWriter writer = new StreamWriter(_response.OutputStream, Encoding.UTF8))
            {
                await writer.WriteAsync(json);
            }
        }

        /// <summary>
        /// Writes the specified content as XML to the response asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of the content.</typeparam>
        /// <param name="content">The content to write.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        public async Task WriteAsXmlAsync<T>(T content)
        {
            await Task.Run(() =>
            {
                _response.ContentType = "application/xml";
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (StreamWriter writer = new StreamWriter(_response.OutputStream, Encoding.UTF8))
                {
                    serializer.Serialize(writer, content);
                }
            });
        }

        /// <summary>
        /// Writes the specified binary content to the response asynchronously.
        /// </summary>
        /// <param name="content">The binary content to write.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        public async Task WriteAsBinaryAsync(byte[] content)
        {
            _response.ContentType = "application/octet-stream";
            await _response.OutputStream.WriteAsync(content, 0, content.Length);
        }

        /// <summary>
        /// Sends a file to the client as a download asynchronously.
        /// </summary>
        /// <param name="filePath">The path of the file to download.</param>
        /// <returns>A task that represents the asynchronous download operation.</returns>
        public async Task DownloadFileAsync(string filePath)
        {
            _response.ContentType = "application/octet-stream";
            _response.AddHeader("Content-Disposition", $"attachment; filename={Path.GetFileName(filePath)}");
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                await fs.CopyToAsync(_response.OutputStream);
            }
        }
    }

}
