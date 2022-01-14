using Magicianred.Net.Backend.Domain.Interfaces.Models;
using Magicianred.Net.Backend.Domain.Interfaces.Services;
using Magicianred.RegistryArea.Domain.Interfaces.Handlers;
using Magicianred.RegistryArea.Domain.Interfaces.Models;
using Newtonsoft.Json;

namespace Magicianred.Net.Backend.BL.Services
{
    public class StagingAreaService : IStagingAreaService
    {
        private readonly IRegistryHandler _registryHandler;

        // Constructor
        public StagingAreaService(IRegistryHandler registryHandler)
        {
            _registryHandler = registryHandler;
        }

        /// <summary>
        /// Insert an event of Insert in Staging Area
        /// </summary>
        /// <param name="postData"></param>
        /// <returns></returns>
        public bool RegistryPostInsert(IPost postData)
        {
            return this.InsertPostEntry("Insert", postData);
        }

        /// <summary>
        /// Insert an event of Update in Staging Area
        /// </summary>
        /// <param name="postData"></param>
        /// <returns></returns>
        public bool RegistryPostUpdate(IPost postData)
        {
            return this.InsertPostEntry("Update", postData);
        }

        /// <summary>
        /// Insert an event of Delete in Staging Area
        /// </summary>
        /// <param name="postData"></param>
        /// <returns></returns>
        public bool RegistryPostDelete(IPost postData)
        {
            return this.InsertPostEntry("Delete", postData);
        }

        #region private methods

        /// <summary>
        /// Centralized method for insert entry in Registry Event
        /// </summary>
        /// <param name="eventType">name of event</param>
        /// <param name="postEntity">post data</param>
        /// <returns></returns>
        private bool InsertPostEntry(string eventType, IPost postEntity)
        {
            IRegistryEventType evType = _registryHandler.GetEventTypeBySystemName(eventType);
            string eventPayload = "{ }";
            string entityPayload =  JsonConvert.SerializeObject(postEntity);
            IRegistryEntityType enType = _registryHandler.GetEntityTypeBySystemName("Post");
            return _registryHandler.Insert(evType, eventPayload, entityPayload, enType);
        }
        #endregion
    }
}
