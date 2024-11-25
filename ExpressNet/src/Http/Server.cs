using ExpressNet.Configs.Configurations;
using System.Net;

namespace ExpressNet.Http
{
    /// <summary>
    /// Represents an HTTP server that listens for incoming HTTP requests.
    /// </summary>
    internal class Server
    {
        private readonly HttpListener _listener;
        private bool _isStarted = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        internal Server()
        {
            _listener = new HttpListener();
        }

        /// <summary>
        /// Starts the HTTP server.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when the server is already started.</exception>
        internal void Start()
        {
            if (_isStarted) throw new InvalidOperationException("Listener is already started.");
            _listener.Start();
            _isStarted = true;
            Console.WriteLine($"ExpressNet server");
            Console.WriteLine($"-----------------");
            Console.WriteLine($"Running at '{string.Join("', '", _listener.Prefixes)}'");
            Console.WriteLine($"Press CTRL+C for shutdown server.");
            Console.WriteLine();
        }

        /// <summary>
        /// Adds a URL prefix that the server should respond to.
        /// </summary>
        /// <param name="url">The URL prefix to add.</param>
        /// <exception cref="InvalidOperationException">Thrown when the server is running.</exception>
        internal void AddPrefix(string url)
        {
            if (_isStarted) throw new InvalidOperationException("Cannot configure HttpListener while running.");
            _listener.Prefixes.Add(url);
        }

        /// <summary>
        /// Aborts the server, causing it to stop immediately.
        /// </summary>
        internal void Abort()
        {
            _listener.Abort();
            _isStarted = false;
        }

        /// <summary>
        /// Stops the server.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when the server is not started.</exception>
        internal void Stop()
        {
            if (!_isStarted) throw new InvalidOperationException("Listener is not started.");
            _listener.Stop();
            _isStarted = false;
        }

        /// <summary>
        /// Closes the server, releasing all resources.
        /// </summary>
        internal void Close()
        {
            _listener.Close();
        }

        /// <summary>
        /// Configures the server with the specified settings.
        /// </summary>
        /// <param name="configuration">The configuration settings to apply.</param>
        /// <exception cref="InvalidOperationException">Thrown when the server is running.</exception>
        internal void Configure(ServerConfiguration configuration)
        {
            if (_isStarted) throw new InvalidOperationException("Cannot configure HttpListener while running.");
            _listener.AuthenticationSchemes = configuration.AuthenticationScheme;
            _listener.TimeoutManager.IdleConnection = configuration.IdleConnectionTimeout;
#if WINDOWS
                _listener.TimeoutManager.RequestQueue = configuration.RequestQueueTimeout;        
#endif
        }

        /// <summary>
        /// Asynchronously gets the context for an incoming request.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains the context for the incoming request.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the server is not started.</exception>
        internal async Task<HttpListenerContext> GetContextAsync()
        {
            if (!_isStarted) throw new InvalidOperationException("Listener is not started.");
            return await _listener.GetContextAsync();
        }
    }

}
