using ExpressNet.Attributes;
using ExpressNet.Ctx;
using ExpressNet.Di;
using ExpressNet.Routing.Contracts;

namespace WebApplication1.Endpoints
{
    [Endpoint("GET", "/")]
    public class IndexEndpoint : IEndpoint
    {
        private readonly SingletonService _singletonService;

        public IndexEndpoint(ServiceScope services)
        {
            _singletonService = services.Resolve<SingletonService>();
            services.Resolve<TransientService>();
            services.Resolve<ScopedService>();
        }

        public async Task HandleAsync(Context context)
        {
            await context.Response.WriteAsTextAsync("Hello, World!");
        }
    }
}
