
namespace ExpressNet.Routing.Contracts
{
    /// <summary>
    /// Defines a contract for a group of endpoints that can be added to a router.
    /// </summary>
    public interface IGroupEndpoints
    {
        /// <summary>
        /// Adds the endpoints defined by the implementing class to the specified router.
        /// </summary>
        /// <param name="router">The router to which the endpoints will be added.</param>
        void AddEndpoints(Router router);
    }
}
