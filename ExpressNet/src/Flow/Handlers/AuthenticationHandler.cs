using ExpressNet.Attributes;
using ExpressNet.Ctx;
using ExpressNet.Di;
using ExpressNet.Flow.Abstractions;
using System.Reflection;
using System.Security.Principal;

namespace ExpressNet.Flow.Handlers
{
    /// <summary>
    /// Handles authentication for a specific endpoint in the chain of responsibility pattern.
    /// </summary>
    internal sealed class AuthenticationHandler : ChainHandler<Context>
    {
        private readonly Type _endpoint;
        private readonly ServiceScope _services;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationHandler"/> class.
        /// </summary>
        /// <param name="endpoint">The endpoint type to check for authentication requirements.</param>
        /// <param name="services">The service scope for resolving dependencies.</param>
        public AuthenticationHandler(Type endpoint, ServiceScope services)
        {
            _endpoint = endpoint;
            _services = services;
        }

        /// <summary>
        /// Handles the context asynchronously, checking for authentication requirements.
        /// </summary>
        /// <param name="context">The context to handle.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async Task HandleAsync(Context context)
        {
            RequireAuthenticationAttribute? requireAuthenticationAttribute = _endpoint.GetCustomAttribute<RequireAuthenticationAttribute>();
            if (requireAuthenticationAttribute is not null)
            {
                IPrincipal? user = context.User;
                if (user is not null && user.Identity?.IsAuthenticated == true)
                {
                    await base.HandleAsync(context);
                }
                else
                {
                    context.Response.SetStatusCode(401);
                    await context.Response.WriteAsTextAsync("Unauthorized");
                }
            }
            else
            {
                await base.HandleAsync(context);
            }
        }
    }
}
