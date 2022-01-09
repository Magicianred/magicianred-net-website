using System;

namespace Magicianred.StagingArea.Domain.Interfaces.Models.Base
{
    /// <summary>
    /// Entity data existing in staging area (without application reference)
    /// </summary>
    public interface IRegistryEntityBase
    {
        /// <summary>
        /// Internal identifier
        /// </summary>
        long Id { get; set; }

        /// <summary>
        /// Unique external guid
        /// </summary>
        Guid GuidId { get; set; }

        /// <summary>
        /// Identifier of external (any type)
        /// </summary>
        string EntityIdentifier { get; set; }
    }
}
