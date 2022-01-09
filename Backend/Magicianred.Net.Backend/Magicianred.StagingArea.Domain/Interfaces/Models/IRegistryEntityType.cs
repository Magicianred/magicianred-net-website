using Magicianred.StagingArea.Domain.Interfaces.Models.Base;

namespace Magicianred.StagingArea.Domain.Interfaces.Models
{
    /// <summary>
    /// Entity Type of Registry
    /// </summary>
    public interface IRegistryEntityType : IRegistryEntityWithApplication, IRegistryChangesEntity, IRegistryDataSoftDelete
    {
        /// <summary>
        /// System Name of Entity Type
        /// </summary>
        string SystemName { get; set; }

        /// <summary>
        /// Description of Entity Type
        /// </summary>
        string Description { get; set; }
    }
}
