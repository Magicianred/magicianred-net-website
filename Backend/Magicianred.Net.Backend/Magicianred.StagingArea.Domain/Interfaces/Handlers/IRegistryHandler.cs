using Magicianred.StagingArea.Domain.Interfaces.Models;

namespace Magicianred.StagingArea.Domain.Interfaces.Handlers
{
    /// <summary>
    /// Registry Handler
    /// </summary>
    public interface IRegistryHandler
    {
        /// <summary>
        /// Insert an event in Staging Area
        /// </summary>
        /// <param name="eventType">type of event</param>
        /// <param name="eventPayload">event data</param>
        /// <param name="entityPayload">entity</param>
        /// <param name="entityType">entity type</param>
        /// <param name="application">application, if null default application</param>
        bool Insert(IRegistryEventType eventType, string eventPayload, string entityPayload, IRegistryEntityType entityType, IRegistryApplication application = null);

        /// <summary>
        /// Return entity type by system name
        /// </summary>
        /// <param name="systemName">system name of entity type</param>
        /// <returns>the entity type</returns>
        IRegistryEntityType GetEntityTypeBySystemName(string systemName);

        /// <summary>
        /// Return event type by system name
        /// </summary>
        /// <param name="systemName">system name of event type</param>
        /// <returns>the event type</returns>
        IRegistryEventType GetEventTypeBySystemName(string systemName);
    }
}
