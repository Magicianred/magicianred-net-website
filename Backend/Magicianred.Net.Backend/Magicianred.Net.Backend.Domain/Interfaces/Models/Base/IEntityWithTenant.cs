namespace Magicianred.Net.Backend.Domain.Interfaces.Models.Base
{
    /// <summary>
    /// Tenant for entities
    /// </summary>
    public interface IEntityWithTenant
    {
        /// <summary>
        /// Reference to tenant
        /// </summary>
        long TenantId { get; set; }

        /// <summary>
        /// Data tenant
        /// </summary>
        ITenant Tenant { get; set; }
    }
}
