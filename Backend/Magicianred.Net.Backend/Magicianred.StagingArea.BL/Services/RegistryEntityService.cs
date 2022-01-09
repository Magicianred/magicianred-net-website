using Magicianred.StagingArea.Domain.Interfaces.Models;
using Magicianred.StagingArea.Domain.ModelsHelpers;
using System.Collections.Generic;
using System.Threading;

namespace Magicianred.StagingArea.BL.Services
{
    /// <summary>
    /// Repository for Registry Entities CRUD
    /// </summary>
    public class RegistryEntityService
    {
        /// <summary>
        /// Count all items
        /// </summary>
        /// <param name="itemParamsHelper">Sorting and filters</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>Count of elements</returns>
        public long GetCountAll(RegistryEntityParamsHelper itemParamsHelper, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Retrieve all items
        /// </summary>
        /// <param name="itemParamsHelper">Sorting and filters</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>List of items</returns>
        public IEnumerable<IRegistryEntity> GetAll(RegistryEntityParamsHelper itemParamsHelper, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Retrieve an item from identifier
        /// </summary>
        /// <param name="id">identifier of the item</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>the item with id</returns>
        public IRegistryEntity GetById(int id, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Insert a new item
        /// </summary>
        /// <param name="item">data of the new item</param>
        /// <param name="cancelToken">cancel token</param>
        public void Insert(IRegistryEntity item, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Update an item by id
        /// </summary>
        /// <param name="item">data of the new item</param>
        /// <param name="cancelToken">cancel token</param>
        public void UpdateById(long id, IRegistryEntity item, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Delete an item
        /// </summary>
        /// <param name="item">the item to delete</param>
        /// <param name="cancelToken">cancel token</param>
        public void Delete(IRegistryEntity item, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Delete an item by id
        /// </summary>
        /// <param name="id">id of the item</param>
        /// <param name="cancelToken">cancel token</param>
        public void DeleteById(long id, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
