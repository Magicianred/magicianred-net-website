using Magicianred.Net.Backend.Domain.Interfaces.Models;
using System.Collections.Generic;

namespace Magicianred.Net.Backend.Domain.Interfaces.Services
{
    public interface IPostsService
    {
        List<IPost> GetAll();
        IPost GetById(int id);
        void Add(IPost entry);
    }
}
