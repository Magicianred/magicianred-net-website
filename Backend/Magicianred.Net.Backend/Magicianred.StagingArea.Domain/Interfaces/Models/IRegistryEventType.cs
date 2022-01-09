using Magicianred.StagingArea.Domain.Interfaces.Models.Base;

namespace Magicianred.StagingArea.Domain.Interfaces.Models
{
    /// <summary>
    /// Represent a registry event type
    /// </summary>
    public interface IRegistryEventType : IRegistryEntityWithApplication, IRegistryChangesEntity, IRegistryDataSoftDelete
    {
        /// <summary>
        /// System name of Registry event type
        /// </summary>
        string SystemName { get; set; }

        /// <summary>
        /// Description of Event
        /// </summary>
        string Description { get; set; }
    }
}
