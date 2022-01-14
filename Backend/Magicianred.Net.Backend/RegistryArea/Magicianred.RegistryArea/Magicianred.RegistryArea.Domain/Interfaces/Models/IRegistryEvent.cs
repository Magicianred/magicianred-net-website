using Magicianred.RegistryArea.Domain.Interfaces.Models.Base;
using System;

namespace Magicianred.RegistryArea.Domain.Interfaces.Models
{
    /// <summary>
    /// An event into the staging area
    /// </summary>
    public interface IRegistryEvent : IRegistryEntityWithApplication, IRegistryChangesEntity, IRegistryDataSoftDelete
    {
        /// <summary>
        /// Date of registry event
        /// </summary>
        DateTime RegistryEventDate { get; set; }

        /// <summary>
        /// internal identifier of registry event type
        /// </summary>
        long RegistryEventTypeId { get; set; }

        /// <summary>
        /// Registry Event type
        /// </summary>
        IRegistryEventType RegistryEventType { get; set; }

        /// <summary>
        /// Data of the event
        /// </summary>
        string PayloadJsonData { get; set; }
    }
}
