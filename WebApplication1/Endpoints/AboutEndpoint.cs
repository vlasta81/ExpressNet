using ExpressNet.Attributes;
using ExpressNet.Ctx;
using ExpressNet.Di;
using ExpressNet.Routing.Contracts;

namespace WebApplication1.Endpoints
{
    [Endpoint("GET", "/About")]
    [RequireAuthentication]
    public class AboutEndpoint : IEndpoint
    {
        public AboutEndpoint(ServiceScope services)
        {
            
        }

        public async Task HandleAsync(Context context)
        {
            await context.Response.WriteAsTextAsync("Hello, World!");
        }
    }
}
