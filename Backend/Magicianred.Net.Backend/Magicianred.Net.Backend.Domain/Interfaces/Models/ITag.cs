using Magicianred.Net.Backend.Domain.Interfaces.Models.Base;
using System.Collections.Generic;

namespace Magicianred.Net.Backend.Domain.Interfaces.Models
{
    /// <summary>
    /// Represent a Tag
    /// </summary>
    public interface ITag : IEntityBase
    {
        /// <summary>
        /// Title of the tag
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Description of the tag
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// List of the post for the tag
        /// </summary>
        List<IPost> Posts { get; set; }
    }
}
