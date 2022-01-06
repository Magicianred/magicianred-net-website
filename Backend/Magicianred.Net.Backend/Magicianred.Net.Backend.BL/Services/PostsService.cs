using Magicianred.Net.Backend.Domain.Interfaces.Models;
using Magicianred.Net.Backend.Domain.Interfaces.Repositories;
using Magicianred.Net.Backend.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Magicianred.Net.Backend.BL.Services
{
    /// <summary>
    /// Service of posts
    /// </summary>
    public class PostsService : IPostsService
    {
        private readonly IPostsRepository _postsRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        public PostsService(IPostsRepository postsRepository)
        {
            _postsRepository = postsRepository;
        }

        public void Add(IPost entry)
        {
            _postsRepository.AddPost(entry);
        }

        /// <summary>
        /// Retrieve all posts
        /// </summary>
        /// <returns>list of posts</returns>
        public List<IPost> GetAll()
        {
            return _postsRepository.GetAll().ToList();
        }

        /// <summary>
        /// Retrieve the post by own id
        /// </summary>
        /// <param name="id">id of post to retrieve</param>
        /// <returns>the post, null if id not found</returns>
        public IPost GetById(int id)
        {
            return _postsRepository.GetById(id);
        }

    }
}