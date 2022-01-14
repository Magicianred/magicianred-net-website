using Magicianred.RegistryArea.Domain.Interfaces.Models;
using Magicianred.RegistryArea.Domain.ModelsHelpers;
using System.Collections.Generic;
using System.Threading;

namespace Magicianred.RegistryArea.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Repository for Registry Application CRUD
    /// </summary>
    public interface IRegistryApplicationRepository
    {
        /// <summary>
        /// Count all items
        /// </summary>
        /// <param name="itemParamsHelper">Sorting and filters</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>Count of elements</returns>
        long GetCountAll(RegistryApplicationParamsHelper itemParamsHelper, CancellationToken cancelToken = default);

        /// <summary>
        /// Retrieve items
        /// </summary>
        /// <param name="itemParamsHelper">Sorting and filters</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>List of items</returns>
        IEnumerable<IRegistryApplication> GetAll(RegistryApplicationParamsHelper itemParamsHelper, CancellationToken cancelToken = default);

        /// <summary>
        /// Retrieve an item from identifier
        /// </summary>
        /// <param name="id">identifier of the item</param>
        /// <param name="cancelToken">cancel token</param>
        /// <returns>the item with id</returns>
        IRegistryApplication GetById(int id, CancellationToken cancelToken = default);

        /// <summary>
        /// Insert a new item
        /// </summary>
        /// <param name="item">data of the new item</param>
        /// <param name="cancelToken">cancel token</param>
        IRegistryApplication Insert(IRegistryApplication item, CancellationToken cancelToken = default);

        /// <summary>
        /// Update an item by id
        /// </summary>
        /// <param name="item">data of the new post</param>
        /// <param name="cancelToken">cancel token</param>
        IRegistryApplication UpdateById(long id, IRegistryApplication item, CancellationToken cancelToken = default);

        /// <summary>
        /// Delete an item
        /// </summary>
        /// <param name="item">the item to delete</param>
        /// <param name="cancelToken">cancel token</param>
        void Delete(IRegistryApplication item, CancellationToken cancelToken = default);

        /// <summary>
        /// Delete an item by id
        /// </summary>
        /// <param name="id">id of the item</param>
        /// <param name="cancelToken">cancel token</param>
        void DeleteById(long id, CancellationToken cancelToken = default);
    }
}