using System.Security.Principal;

namespace ExpressNet.Security
{
    /// <summary>
    /// Represents the default implementation of the <see cref="IIdentity"/> interface.
    /// </summary>
    public sealed class DefaultIdentity : IIdentity
    {
        /// <summary>
        /// Gets the type of authentication used.
        /// </summary>
        public string AuthenticationType { get; init; }

        /// <summary>
        /// Gets a value indicating whether the user has been authenticated.
        /// </summary>
        public bool IsAuthenticated { get; init; }

        /// <summary>
        /// Gets the name of the user.
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultIdentity"/> class with the specified authentication type, user name, and authentication status.
        /// </summary>
        /// <param name="authenticationType">The type of authentication used.</param>
        /// <param name="name">The name of the user.</param>
        /// <param name="isAuthenticated">A value indicating whether the user has been authenticated.</param>
        public DefaultIdentity(string authenticationType, string name, bool isAuthenticated)
        {
            AuthenticationType = authenticationType;
            Name = name;
            IsAuthenticated = isAuthenticated;
        }
    }
}
