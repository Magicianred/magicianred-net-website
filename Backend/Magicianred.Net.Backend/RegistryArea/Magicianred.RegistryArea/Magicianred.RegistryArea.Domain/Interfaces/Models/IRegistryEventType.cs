using Magicianred.RegistryArea.Domain.Interfaces.Models.Base;

namespace Magicianred.RegistryArea.Domain.Interfaces.Models
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
