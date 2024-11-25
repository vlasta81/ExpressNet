using System.Security.Principal;

namespace ExpressNet.Security
{
    /// <summary>
    /// Represents the default implementation of the <see cref="IPrincipal"/> interface.
    /// </summary>
    public sealed class DefaultPrincipal : IPrincipal
    {
        /// <summary>
        /// Gets the identity of the current principal.
        /// </summary>
        public IIdentity Identity { get; init; }

        /// <summary>
        /// Gets the roles associated with the current principal.
        /// </summary>
        public string[]? Roles { get; init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultPrincipal"/> class with the specified identity and optional roles.
        /// </summary>
        /// <param name="identity">The identity of the principal.</param>
        /// <param name="roles">The roles associated with the principal. Default is null.</param>
        public DefaultPrincipal(IIdentity identity, string[]? roles = null)
        {
            Identity = identity;
            Roles = roles;
        }

        /// <summary>
        /// Determines whether the current principal belongs to the specified role.
        /// </summary>
        /// <param name="role">The name of the role to check.</param>
        /// <returns><c>true</c> if the current principal is a member of the specified role; otherwise, <c>false</c>.</returns>
        public bool IsInRole(string role)
        {
            return Roles?.Contains(role) ?? false;
        }
    }
}
