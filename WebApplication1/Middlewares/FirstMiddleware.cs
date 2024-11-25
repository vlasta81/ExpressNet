using ExpressNet.Ctx;
using ExpressNet.Di;
using ExpressNet.Security;
using IMiddleware = ExpressNet.Middlewares.Contracts.IMiddleware;

namespace WebApplication1.Middlewares
{
    public class FirstMiddleware : IMiddleware
    {
        public FirstMiddleware(ServiceScope services)
        {

        }

        public async Task InvokeAsync(Context context, Func<Context, Task> next)
        {
            context.User = new DefaultPrincipal(new DefaultIdentity("Bearer", "John Doe", true), new string[] { "User" });
            await next(context);
        }
    }
}
