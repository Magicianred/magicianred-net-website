using Magicianred.RegistryArea.Domain.Interfaces.Models.Base;

namespace Magicianred.RegistryArea.Domain.Interfaces.Models
{
    /// <summary>
    /// Represent the entity in Staging Area
    /// 
    /// Contains system data and payload of entity
    /// </summary>
    public interface IRegistryEntity : IRegistryEntityWithApplication, IRegistryChangesEntity, IRegistryDataSoftDelete
    {
        /// <summary>
        /// internal identifier of Entity type
        /// </summary>
        int RegistryEntityTypeId { get; set; }

        /// <summary>
        /// Entity type
        /// </summary>
        IRegistryEntityType RegistryEntityType { get; set; }

        /// <summary>
        /// Data of the entity
        /// </summary>
        string PayloadJsonData { get; set; }
    }
}
