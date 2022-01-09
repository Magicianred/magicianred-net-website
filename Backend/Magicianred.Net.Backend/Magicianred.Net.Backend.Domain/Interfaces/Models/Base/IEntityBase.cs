namespace Magicianred.Net.Backend.Domain.Interfaces.Models.Base
{
    /// <summary>
    /// Base data for entities
    /// </summary>
    public interface IEntityBase
    {
        /// <summary>
        /// Internal identifier
        /// </summary>
        long Id { get; set; }
    }
}
