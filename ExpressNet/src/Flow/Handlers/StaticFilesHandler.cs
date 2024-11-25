using ExpressNet.Configs;
using ExpressNet.Ctx;
using ExpressNet.Flow.Abstractions;

namespace ExpressNet.Flow.Handlers
{

    /// <summary>
    /// Handles the serving of static files in the application.
    /// </summary>
    internal sealed class StaticFilesHandler : ChainHandler<Context>
    {
        private readonly string? _staticFilesDirectory;

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticFilesHandler"/> class with the specified configuration.
        /// </summary>
        /// <param name="configuration">The configuration settings.</param>
        public StaticFilesHandler(Configuration configuration)
        {
            if (configuration.StaticFiles.Directory is not null && Directory.Exists(configuration.StaticFiles.Directory))
            {
                _staticFilesDirectory = configuration.StaticFiles.Directory;
            }
        }

        /// <summary>
        /// Gets the content type based on the file extension.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The content type as a string.</returns>
        private string GetContentType(string path)
        {
            string ext = Path.GetExtension(path).ToLowerInvariant();
            return ext switch
            {
                ".html" => "text/html",
                ".css" => "text/css",
                ".js" => "application/javascript",
                ".png" => "image/png",
                ".jpg" => "image/jpeg",
                ".jpeg" => "image/jpeg",
                ".svg" => "image/svg+xml",
                ".txt" => "text/plain",
                ".json" => "application/json",
                ".bmp" => "image/bmp",
                ".gif" => "image/gif",
                _ => "application/octet-stream",
            };
        }

        /// <summary>
        /// Gets the full file path based on the URL path.
        /// </summary>
        /// <param name="urlPath">The URL path.</param>
        /// <returns>The full file path as a string.</returns>
        /// <exception cref="UnauthorizedAccessException">Thrown when the file path is outside the static files directory.</exception>
        private string GetFilePath(string urlPath)
        {
            string normalizedPath = urlPath.Replace('/', Path.DirectorySeparatorChar).TrimStart(Path.DirectorySeparatorChar);
            string filePath = Path.Combine(_staticFilesDirectory!, normalizedPath);
            string normalizedFilePath = Path.GetFullPath(filePath);
            if (!normalizedFilePath.StartsWith(_staticFilesDirectory!, StringComparison.OrdinalIgnoreCase))
            {
                throw new UnauthorizedAccessException();
            }
            return normalizedFilePath;
        }

        /// <summary>
        /// Handles the context asynchronously by serving static files if available, otherwise delegates to the next handler.
        /// </summary>
        /// <param name="context">The context to handle.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async Task HandleAsync(Context context)
        {
            if (_staticFilesDirectory is null)
            {
                await base.HandleAsync(context);
            }
            else
            {
                if (context.Request.Url is not null)
                {
                    string filePath = GetFilePath(context.Request.Url.LocalPath);
                    if (!File.Exists(filePath))
                    {
                        await base.HandleAsync(context);
                    }
                    else
                    {
                        string mimeType = GetContentType(filePath);
                        context.Response.SetContentType(mimeType);
                        context.Response.AddHeader("Cache-Control", $"public, max-age={context.Configuration.StaticFiles.Lifetime.ToString()}");
                        using (FileStream fileStream = File.OpenRead(filePath))
                        {
                            context.Response.SetContentLength64(fileStream.Length);
                            await fileStream.CopyToAsync(context.Response.OutputStream);
                        }
                    }
                }
                else
                {
                    await base.HandleAsync(context);
                }
            }
        }
    }

}
