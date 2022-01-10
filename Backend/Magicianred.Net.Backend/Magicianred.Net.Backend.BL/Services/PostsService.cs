using Magicianred.Net.Backend.Domain.Interfaces.Models;
using Magicianred.Net.Backend.Domain.Interfaces.Repositories;
using Magicianred.Net.Backend.Domain.Interfaces.Services;
using Magicianred.Net.Backend.Domain.ModelsHelpers;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;

namespace Magicianred.Net.Backend.BL.Services
{
    /// <summary>
    /// Service of posts
    /// </summary>
    public class PostsService : IPostsService
    {
        private readonly bool UseRegistryEvents = ConfigurationManager.AppSettings["UseRegistryEvents"] == "true";

        private readonly IPostsRepository _postsRepository;
        private readonly IStagingAreaService _stagingAreaService;

        /// <summary>
        /// Constructor
        /// </summary>
        public PostsService(IPostsRepository postsRepository, IStagingAreaService stagingAreaService = null)
        {
            _postsRepository = postsRepository;
            _stagingAreaService = stagingAreaService;
        }

        public long GetCountAll(PostParamsHelper itemParamsHelper, CancellationToken cancelToken = default)
        {
            var itemsCount = _postsRepository.GetCountAll(itemParamsHelper, cancelToken);

            return itemsCount;
        }

        public IEnumerable<IPost> GetAll(PostParamsHelper itemParamsHelper, CancellationToken cancelToken = default)
        {
            var items = _postsRepository.GetAll(itemParamsHelper, cancelToken);

            return items;
        }

        public IPost GetById(int id, CancellationToken cancelToken = default)
        {
            var item = _postsRepository.GetById(id, cancelToken);

            return item;
        }

        public void Insert(IPost item, CancellationToken cancelToken = default)
        {
            IPost newItem = _postsRepository.Insert(item, cancelToken);

            // registry event
            if (UseRegistryEvents)
            {
                _stagingAreaService.RegistryPostInsert(newItem);
            }
        }

        public void UpdateById(long id, IPost item, CancellationToken cancelToken = default)
        {
            var itemToUpdate = _postsRepository.GetById(id, cancelToken);

            itemToUpdate.Title = item.Title;
            itemToUpdate.Text = item.Text;

            IPost newItem = _postsRepository.UpdateById(id, itemToUpdate, cancelToken);

            // registry event
            if (UseRegistryEvents)
            {
                _stagingAreaService.RegistryPostUpdate(newItem);
            }
        }

        public void Delete(IPost item, CancellationToken cancelToken = default)
        {
            _postsRepository.Delete(item, cancelToken);

            // registry event
            if (UseRegistryEvents)
            {
                _stagingAreaService.RegistryPostDelete(item);
            }
        }

        public void DeleteById(long id, CancellationToken cancelToken = default)
        {
            var item = _postsRepository.GetById(id, cancelToken);
            _postsRepository.DeleteById(id, cancelToken);

            // registry event
            if (UseRegistryEvents)
            {
                _stagingAreaService.RegistryPostDelete(item);
            }
        }
    }
}