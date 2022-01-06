using Magicianred.Net.Backend.BL.Services;
using Magicianred.Net.Backend.DAL.Fake.Repositories;
using Magicianred.Net.Backend.Web.Factories;
using Magicianred.Net.Backend.Domain.Interfaces.Repositories;
using Magicianred.Net.Backend.Domain.Interfaces.Services;
using Magicianred.Net.Backend.Domain.Models;
using Magicianred.Net.Backend.Web.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Magicianred.Net.Backend.Web.Controllers
{
    public class PostsController : ApiController
    {
        private readonly IPostsRepository _postsRepository;
        private readonly IPostsService _postsService;

        // TODO remove constructor inject - using a Unity system
        /// <summary>
        /// Constructor
        /// </summary>
        public PostsController()
        {
            _postsRepository = new FakePostsRepository();
            _postsService = new PostsService(_postsRepository);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="postsService"></param>
        public PostsController(IPostsService postsService)
        {
            _postsService = postsService;
        }

        /// <summary>
        /// Retrieve all Posts
        /// GET: api/<HomeController>
        /// </summary>
        /// <returns>list of Posts</returns>
        [HttpGet]
        public IEnumerable<PostDTO> Get()
        {
            var posts = _postsService.GetAll();

            return posts.ToItemDTOs();
        }

        /// <summary>
        /// Retrieve the post with the id
        /// GET api/<HomeController>/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns>the post with requested id</returns>
        [HttpGet]
        //[Route("{id}")]
        public PostDTO Get(int id)
        {
            var post = _postsService.GetById(id);

            return post.ToItemDTO();
        }

        [HttpPost]
        public void Add()
        {
            Post newPost = new Post()
            {
                Title = "New test post",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut quis enim eu augue tincidunt tincidunt. Nam luctus pharetra tortor, sit amet sodales odio bibendum non.",
                CreateDate = System.DateTime.Now
            };
            _postsService.Add(newPost);
            //_logger.LogInformation("Added fake post!");
        }
    }
}
