using Magicianred.Net.Backend.BL.Services;
using Magicianred.Net.Backend.DAL.Fake.Repositories;
using Magicianred.Net.Backend.Domain.Interfaces.Models;
using Magicianred.Net.Backend.Domain.Interfaces.Repositories;
using Magicianred.Net.Backend.Domain.Interfaces.Services;
using Magicianred.Net.Backend.Domain.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Magicianred.Net.Backend.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            // Domains
            container.RegisterType<IPost, Post>();

            // BL
            container.RegisterType<IPostsService, PostsService>();

            // DAL.Fake
            container.RegisterType<IPostsRepository, FakePostsRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}