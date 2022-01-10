using Magicianred.StagingArea.Domain.Interfaces.Models;
using System;

namespace Magicianred.StagingArea.Domain.Models
{
    /// <summary>
    /// An event into the staging area
    /// </summary>
    public class RegistryEvent : IRegistryEvent
    {
        /// <summary>
        /// Date of registry event
        /// </summary>
        public DateTime RegistryEventDate { get; set; }

        /// <summary>
        /// internal identifier of registry event type
        /// </summary>
        public long RegistryEventTypeId { get; set; }

        /// <summary>
        /// Registry Event type
        /// </summary>
        public IRegistryEventType RegistryEventType { get; set; }

        /// <summary>
        /// Data of the event
        /// </summary>
        public string PayloadJsonData { get; set; }
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
