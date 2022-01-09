using Magicianred.Net.Backend.BL.Services;
using Magicianred.Net.Backend.DAL.Fake.Repositories;
using Magicianred.Net.Backend.Web.Factories;
using Magicianred.Net.Backend.Domain.Interfaces.Repositories;
using Magicianred.Net.Backend.Domain.Interfaces.Services;
using Magicianred.Net.Backend.Domain.Models;
using Magicianred.Net.Backend.Web.Models;
using System.Collections.Generic;
using System.Web.Http;
using Magicianred.Net.Backend.Domain.ModelsHelpers;
using Magicianred.Net.Backend.Domain.Interfaces.Models;
using System.Linq;
using System.Threading;

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
            _postsService = new PostsService(_postsRepository, null);
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
        public IEnumerable<PostDTO> Get(CancellationToken cancelToken = default)
        {
            PostParamsHelper itemsParam = new PostParamsHelper
            {
                Page = 1,
                ItemsPerPage = 10
            };

            var posts = new List<IPost>();
            var postsEnumerable = _postsService.GetAll(itemsParam, cancelToken);
            if(postsEnumerable != null && postsEnumerable.Any())
            {
                posts = postsEnumerable.ToList();
            }

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
        public PostDTO Get(int id, CancellationToken cancelToken = default)
        {
            var post = _postsService.GetById(id, cancelToken);

            return post.ToItemDTO();
        }

        [HttpPost]
        public void Add(CancellationToken cancelToken = default)
        {
            Post newPost = new Post()
            {
                Title = "New test post",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut quis enim eu augue tincidunt tincidunt. Nam luctus pharetra tortor, sit amet sodales odio bibendum non.",
                CreateDate = System.DateTime.Now
            };
            _postsService.Insert(newPost, cancelToken);
            //_logger.LogInformation("Added fake post!");
        }
    }
}
