using Magicianred.StagingArea.Domain.Interfaces.Models.Base;

namespace Magicianred.StagingArea.Domain.Interfaces.Models
{
    /// <summary>
    /// Represent application entity (internal or external)
    /// </summary>
    public interface IRegistryApplication : IRegistryEntity, IRegistryChangesEntity, IRegistryDataSoftDelete
    {
        /// <summary>
        /// Name of application
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Description of Application
        /// </summary>
        string Description { get; set; }
    }
}
