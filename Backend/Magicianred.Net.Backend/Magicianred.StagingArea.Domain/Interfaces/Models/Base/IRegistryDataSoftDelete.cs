using System;

namespace Magicianred.StagingArea.Domain.Interfaces.Models.Base
{
    /// <summary>
    /// Entity data of soft delete
    /// </summary>
    public interface IRegistryDataSoftDelete
    {
        /// <summary>
        /// Internal identifier
        /// </summary>
        long? DeletedId { get; set; }

        /// <summary>
        /// Unique external identifier
        /// </summary>
        Guid? DeletedGuidId { get; set; }

        /// <summary>
        /// Entity Type of Entity
        /// </summary>
        int? DeletedEntityTypeId { get; set; }

        /// <summary>
        /// Entity Type of Entity
        /// </summary>
        IRegistryEntityType DeletedEntityType { get; set; }

        /// <summary>
        /// Deleted date
        /// </summary>
        DateTime? DeletedDate { get; set; }
    }
}
