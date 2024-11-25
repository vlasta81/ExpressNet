using ExpressNet;

using WebApplication1.Endpoints;
using WebApplication1.Middlewares;

namespace WebApplication1
{


    public class Program
    {
        public static async Task Main(string[] args)
        {
            Application app = new Application(configurator =>
            {
                configurator.Application.Name = "WebApplication1";
                configurator.Application.Description = "A simple web application.";
                configurator.Application.Version = "1.0.0";
                configurator.Application.Author = "John Doe";
                configurator.Application.Url = "https://example.com";

                configurator.Server.AuthenticationScheme = System.Net.AuthenticationSchemes.None;
                configurator.Server.RequestQueueTimeout = TimeSpan.FromMinutes(1);
                configurator.Server.IdleConnectionTimeout = TimeSpan.FromMinutes(2);

                configurator.StaticFiles.Directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                configurator.StaticFiles.Lifetime = 3600;

                configurator.Custom = null;
            });

            app.Register((services) => new SingletonService(), ExpressNet.Di.ServiceLifetime.Singleton);
            app.Register((services) => new TransientService(), ExpressNet.Di.ServiceLifetime.Transient);
            app.Register((services) => new ScopedService(), ExpressNet.Di.ServiceLifetime.Scoped);

            app.Add<IndexEndpoint>();
            app.AddRange<MainEndpoints>();

            app.Use<FirstMiddleware>();
            app.Use<SecondMiddleware>();

            await app.RunAsync("https://localhost:9001/");
        }
    }
}
