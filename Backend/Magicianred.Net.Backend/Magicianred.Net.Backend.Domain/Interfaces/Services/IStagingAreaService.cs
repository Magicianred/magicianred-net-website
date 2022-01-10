using Magicianred.Net.Backend.Domain.Interfaces.Models;

namespace Magicianred.Net.Backend.Domain.Interfaces.Services
{
    /// <summary>
    /// Connecting StagingArea to App
    /// </summary>
    public interface IStagingAreaService
    {
        /// <summary>
        /// Registry an insert post event
        /// </summary>
        /// <param name="post">Post data</param>
        /// <returns>boolean of the success of insert event</returns>
        bool RegistryPostInsert(IPost postData);

        /// <summary>
        /// Registry a update post event
        /// </summary>
        /// <param name="post">Post data</param>
        /// <returns>boolean of the success of insert event</returns>
        bool RegistryPostUpdate(IPost postData);

        /// <summary>
        /// Registry a delete post event
        /// </summary>
        /// <param name="post">Post data</param>
        /// <returns>boolean of the success of insert event</returns>
        bool RegistryPostDelete(IPost postData);
    }
}
