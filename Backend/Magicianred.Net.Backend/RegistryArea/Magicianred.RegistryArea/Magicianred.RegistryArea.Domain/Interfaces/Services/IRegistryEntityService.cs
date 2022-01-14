using Magicianred.RegistryArea.Domain.Interfaces.Models;
using Magicianred.RegistryArea.Domain.ModelsHelpers;
using System.Collections.Generic;
using System.Threading;

namespace Magicianred.RegistryArea.Domain.Interfaces.Services
{
    /// <summary>
    /// Repository for Registry Entities CRUD
    /// </summary>
    public interface IRegistryEntityService
    {
        /// <summary>
        /// Count all items
        /// </summary>
        /// <param name="itemParamsHelper">Sorting and filters</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>Count of elements</returns>
        long GetCountAll(RegistryEntityParamsHelper itemParamsHelper, CancellationToken cancelToken = default);

        /// <summary>
        /// Retrieve all items
        /// </summary>
        /// <param name="itemParamsHelper">Sorting and filters</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>List of items</returns>
        IEnumerable<IRegistryEntity> GetAll(RegistryEntityParamsHelper itemParamsHelper, CancellationToken cancelToken = default);

        /// <summary>
        /// Retrieve an item from identifier
        /// </summary>
        /// <param name="id">identifier of the item</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>the item with id</returns>
        IRegistryEntity GetById(int id, CancellationToken cancelToken = default);

        /// <summary>
        /// Insert a new item
        /// </summary>
        /// <param name="item">data of the new item</param>
        /// <param name="cancelToken">cancel token</param>
        void Insert(IRegistryEntity item, CancellationToken cancelToken = default);

        /// <summary>
        /// Update an item by id
        /// </summary>
        /// <param name="item">data of the new post</param>
        /// <param name="cancelToken">cancel token</param>
        void UpdateById(long id, IRegistryEntity item, CancellationToken cancelToken = default);

        /// <summary>
        /// Delete an item
        /// </summary>
        /// <param name="item">the item to delete</param>
        /// <param name="cancelToken">cancel token</param>
        void Delete(IRegistryEntity item, CancellationToken cancelToken = default);

        /// <summary>
        /// Delete an item by id
        /// </summary>
        /// <param name="id">id of the item</param>
        /// <param name="cancelToken">cancel token</param>
        void DeleteById(long id, CancellationToken cancelToken = default);
    }
}
