namespace Magicianred.RegistryArea.Domain.Interfaces.Models.Base
{
    /// <summary>
    /// Entity data existing in staging area (with reference of applications)
    /// </summary>
    public interface IRegistryEntityWithApplication : IRegistryEntityBase
    {
        /// <summary>
        /// Reference to internal Application id
        /// </summary>
        long ApplicationId { get; set; }

        /// <summary>
        /// Registry Application
        /// </summary>
        IRegistryApplication Application { get; set; }
    }
}
