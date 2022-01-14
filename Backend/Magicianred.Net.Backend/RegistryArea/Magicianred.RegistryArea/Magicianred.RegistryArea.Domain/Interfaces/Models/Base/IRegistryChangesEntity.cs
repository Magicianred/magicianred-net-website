using System;

namespace Magicianred.RegistryArea.Domain.Interfaces.Models.Base
{
    /// <summary>
    /// Changes data of entity (Edit / Update)
    /// </summary>
    public interface IRegistryChangesEntity : IRegistryEntityWithApplication
    {
        /// <summary>
        /// Internal identifier
        /// </summary>
        long CreatedId { get; set; }

        /// <summary>
        /// Unique external identifier
        /// </summary>
        Guid CreatedGuidId { get; set; }

        /// <summary>
        /// Entity Type Id of Entity
        /// </summary>
        int CreatedEntityTypeId { get; set; }

        /// <summary>
        /// Entity Type of Entity
        /// </summary>
        IRegistryEntityType CreatedEntityType { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// Internal identifier
        /// </summary>
        long? EditedId { get; set; }

        /// <summary>
        /// Unique external identifier
        /// </summary>
        Guid? EditedGuidId { get; set; }

        /// <summary>
        /// Entity Type of Entity
        /// </summary>
        int? EditedEntityTypeId { get; set; }

        /// <summary>
        /// Entity Type of Entity
        /// </summary>
        IRegistryEntityType EditedEntityType { get; set; }

        /// <summary>
        /// Edited date
        /// </summary>
        DateTime? EditedDate { get; set; }
    }
}
