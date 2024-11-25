
namespace ExpressNet.Attributes
{
    /// <summary>
    /// An attribute to indicate that authentication is required for the decorated class.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class RequireAuthenticationAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequireAuthenticationAttribute"/> class.
        /// </summary>
        public RequireAuthenticationAttribute()
        {
        }
    }
}
