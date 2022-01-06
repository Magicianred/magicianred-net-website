using Magicianred.Net.Backend.Domain.Interfaces.Models;
using System.Collections.Generic;

namespace Magicianred.Net.Backend.Domain.Interfaces.Repositories
{
    public interface IPostsRepository
    {
        IEnumerable<IPost> GetAll();
        IPost GetById(int id);
        void AddPost(IPost item);
    }
}
