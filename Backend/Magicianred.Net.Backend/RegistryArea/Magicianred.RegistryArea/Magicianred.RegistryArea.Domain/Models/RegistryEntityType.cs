using Magicianred.RegistryArea.Domain.Interfaces.Models;
using System;

namespace Magicianred.RegistryArea.Domain.Models
{
    /// <summary>
    /// Entity Type of Registry
    /// </summary>
    public class RegistryEntityType : IRegistryEntityType
    {
        /// <summary>
        /// System Name of Entity Type
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Description of Entity Type
        /// </summary>
        public string Description { get; set; }

        public long CreatedId { get; set; }
        public Guid CreatedGuidId { get; set; }
        public int CreatedEntityTypeId { get; set; }
        public IRegistryEntityType CreatedEntityType { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? EditedId { get; set; }
        public Guid? EditedGuidId { get; set; }
        public int? EditedEntityTypeId { get; set; }
        public IRegistryEntityType EditedEntityType { get; set; }
        public DateTime? EditedDate { get; set; }
        public long ApplicationId { get; set; }
        public IRegistryApplication Application { get; set; }
        public long Id { get; set; }
        public Guid GuidId { get; set; }
        public string EntityIdentifier { get; set; }
        public long? DeletedId { get; set; }
        public Guid? DeletedGuidId { get; set; }
        public int? DeletedEntityTypeId { get; set; }
        public IRegistryEntityType DeletedEntityType { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
