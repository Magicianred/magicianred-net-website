using System;

namespace Magicianred.Net.Backend.Domain.Interfaces.Models.Base
{
    /// <summary>
    /// Entity properties for registry changes (create, edit)
    /// </summary>
    public interface IEntityChanges
    {
        /// <summary>
        /// Internal identifier
        /// </summary>
        long CreatedId { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// Internal identifier
        /// </summary>
        long? EditedId { get; set; }

        /// <summary>
        /// Edited date
        /// </summary>
        DateTime? EditedDate { get; set; }
    }
}
