using ExpressNet.Routing;
using ExpressNet.Routing.Contracts;

namespace WebApplication1.Endpoints
{
    public class MainEndpoints : IGroupEndpoints
    {
        public void AddEndpoints(Router router)
        {
            router.Add<HomeEndpoint>();
            router.Add<AboutEndpoint>();
        }
    }
}
