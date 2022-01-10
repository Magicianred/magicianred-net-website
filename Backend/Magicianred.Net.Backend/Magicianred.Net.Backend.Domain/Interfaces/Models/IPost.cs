using Magicianred.Net.Backend.Domain.Interfaces.Models.Base;
using System.Collections.Generic;

namespace Magicianred.Net.Backend.Domain.Interfaces.Models
{
    /// <summary>
    /// Represent a Post
    /// </summary>
    public interface IPost : IEntityWithTenant, IEntityChanges, IEntitySoftDelete
    {
        /// <summary>
        /// Identifier
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Title of the post
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Text of the post
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// List of the tags for the post
        /// </summary>
        List<ITag> Tags { get; set; }

        /// <summary>
        /// Indicate if it's published or it's a draft
        /// </summary>
        bool IsPublished { get; set; }
    }
}
