using Magicianred.RegistryArea.Domain.Interfaces.Handlers;
using Magicianred.RegistryArea.Domain.Interfaces.Models;

namespace Magicianred.RegistryArea.BL.Handlers
{
    /// <summary>
    /// Repository for Registry Application CRUD
    /// </summary>
    public class RegistryHandler : IRegistryHandler
    {
        public IRegistryEntityType GetEntityTypeBySystemName(string systemName)
        {
            throw new System.NotImplementedException();
        }

        public IRegistryEventType GetEventTypeBySystemName(string systemName)
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(IRegistryEventType eventType, string eventPayload, string entityPayload, IRegistryEntityType entityType, IRegistryApplication application = null)
        {
            throw new System.NotImplementedException();
        }
    }
}
