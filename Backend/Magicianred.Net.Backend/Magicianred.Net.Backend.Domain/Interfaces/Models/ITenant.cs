using Magicianred.Net.Backend.Domain.Interfaces.Models.Base;

namespace Magicianred.Net.Backend.Domain.Interfaces.Models
{
    /// <summary>
    /// Represent a tenant
    /// </summary>
    public interface ITenant : IEntityBase, IEntityChanges, IEntitySoftDelete
    {
        /// <summary>
        /// Name of the Tenant
        /// </summary>
        string Name { get; set; }
    }
}
