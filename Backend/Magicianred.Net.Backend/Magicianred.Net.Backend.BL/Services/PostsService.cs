using Magicianred.Net.Backend.Domain.Interfaces.Models;
using Magicianred.Net.Backend.Domain.Interfaces.Repositories;
using Magicianred.Net.Backend.Domain.Interfaces.Services;
using Magicianred.Net.Backend.Domain.ModelsHelpers;
using Magicianred.StagingArea.Domain.Interfaces.Handlers;
using Magicianred.StagingArea.Domain.Interfaces.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Magicianred.Net.Backend.BL.Services
{
    /// <summary>
    /// Service of posts
    /// </summary>
    public class PostsService : IPostsService
    {
        private readonly IPostsRepository _postsRepository;
        private readonly IRegistryHandler _registryHandler;

        /// <summary>
        /// Constructor
        /// </summary>
        public PostsService(IPostsRepository postsRepository, IRegistryHandler registryHandler = null)
        {
            _postsRepository = postsRepository;
            _registryHandler = registryHandler;
        }

        public void Delete(IPost item, CancellationToken cancelToken = default)
        {
            _postsRepository.Delete(item, cancelToken);

            // registry event
            _registryHandler.Insert();
        }

        public void DeleteById(long id, CancellationToken cancelToken = default)
        {
            _postsRepository.DeleteById(id, cancelToken);
        }

        public IEnumerable<IPost> GetAll(PostParamsHelper itemParamsHelper, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }

        public IPost GetById(int id, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }

        public long GetCountAll(PostParamsHelper itemParamsHelper, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(IPost item, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateById(long id, IPost item, CancellationToken cancelToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}