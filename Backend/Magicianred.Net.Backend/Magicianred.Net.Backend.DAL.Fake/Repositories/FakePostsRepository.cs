using Magicianred.Net.Backend.DAL.Fake.Models;
using Magicianred.Net.Backend.Domain.Interfaces.Models;
using Magicianred.Net.Backend.Domain.Interfaces.Repositories;
using Magicianred.Net.Backend.Domain.Models;
using Magicianred.Net.Backend.Domain.ModelsHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Magicianred.Net.Backend.DAL.Fake.Repositories
{
    /// <summary>
    /// Repository of posts
    /// </summary>
    public class FakePostsRepository : IPostsRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FakePostsRepository()
        {
            FakePostsRepository.LoadData();
        }

        public long GetCountAll(PostParamsHelper itemParamsHelper, CancellationToken cancelToken = default)
        {
            // TODO use params
            return MemoryCache<Post>.Items.Count();
        }

        public IEnumerable<IPost> GetAll(PostParamsHelper itemParamsHelper, CancellationToken cancelToken = default)
        {
            // TODO use params
            IEnumerable<IPost> posts = MemoryCache<Post>.Items;
            return posts;
        }

        public IPost GetById(int id, CancellationToken cancelToken = default)
        {
            IPost post = MemoryCache<Post>.Items.Find(item => item.Id == id);

            return post;
        }

        public IPost Insert(IPost item, CancellationToken cancelToken = default)
        {
            Post newEntry = (Post)item;
            newEntry.Id = MemoryCache<Post>.Items.Max(element => element.Id) + 1;

            MemoryCache<Post>.Items.Add(newEntry);

            return newEntry;
        }

        public IPost UpdateById(long id, IPost itemToUpdate, CancellationToken cancelToken = default)
        {
            IPost post = MemoryCache<Post>.Items.Find(item => item.Id == id);
            post.EditedDate = DateTime.Now;
            post.Title = itemToUpdate.Title;
            post.Text = itemToUpdate.Text;

            return post;
        }

        public void Delete(IPost item, CancellationToken cancelToken = default)
        {
            MemoryCache<Post>.Items.Remove((Post)item);
        }

        public void DeleteById(long id, CancellationToken cancelToken = default)
        {
            IPost post = MemoryCache<Post>.Items.Find(item => item.Id == id);
            this.Delete(post);
        }

        #region private methods

        private static void LoadData()
        {
            List<Post> posts = MemoryCache<Post>.Items;

            // charge fake data
            if (posts == null || posts.Count == 0)
            {
                posts.Add(
                    new Post()
                    {
                        Id = 1,
                        Title = "Forth post of the blog",
                        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut quis enim eu augue tincidunt tincidunt. Nam luctus pharetra tortor, sit amet sodales odio bibendum non. Nulla imperdiet tempor metus, sit amet posuere justo laoreet nec. Nullam vehicula commodo posuere. Ut elementum, purus id posuere porttitor, massa purus tristique sapien, nec sollicitudin massa lectus ac erat. Nunc id tortor quis leo placerat accumsan nec scelerisque ligula. Vivamus in efficitur felis. Cras tincidunt eleifend leo ut volutpat. Sed ut ligula eu risus pretium volutpat sit amet vel lorem. Aliquam gravida blandit risus non laoreet.\n\nPraesent felis velit, interdum ac laoreet luctus, finibus vel lorem. In vitae dolor ipsum. Quisque pretium eu ex in egestas. Nam imperdiet in diam eu maximus. Nulla tristique magna velit, vitae scelerisque augue facilisis id. Nulla in ultricies ex, nec lobortis felis. Nam nec vestibulum libero, ut laoreet tellus. Pellentesque ut metus sed nulla fermentum consequat at nec ligula. Donec pretium nisi rhoncus elit tincidunt, eu euismod ligula semper.\n\nIn at enim sit amet magna luctus sagittis et quis lacus. In blandit enim risus, eu pharetra nibh pharetra id. Nullam diam augue, fermentum eget aliquam sed, ornare sit amet dolor. Fusce fringilla vestibulum aliquam. Curabitur id laoreet lectus. Proin pretium nunc vel sem bibendum fringilla. Aliquam rhoncus neque enim, pellentesque consequat turpis gravida in. Ut at massa non augue fringilla pellentesque. Mauris consectetur pellentesque mauris molestie ullamcorper. Vivamus at nisi sed turpis cursus porttitor a sed enim. Quisque nec lorem ultrices, vestibulum sapien et, sollicitudin arcu. Donec augue risus, eleifend a tempus eu, hendrerit a quam.\n\nSed ex arcu, fringilla at molestie sit amet, accumsan id odio. Sed ut est orci. Suspendisse convallis mauris in fringilla facilisis. Nulla sit amet orci sed elit sollicitudin placerat. Pellentesque blandit, eros ut blandit volutpat, elit diam pulvinar tellus, vel vulputate urna augue at nisi. Suspendisse id odio quis risus dignissim elementum. Suspendisse vitae interdum dui, id euismod lacus. Mauris sit amet nisi nec diam fringilla lacinia. Nulla mauris nulla, vestibulum a convallis a, imperdiet nec neque. Phasellus aliquet sollicitudin mauris, id congue est varius sit amet. Etiam imperdiet mauris id dui iaculis commodo. Vivamus at nisl ligula. Cras iaculis varius orci, non congue nunc commodo ut.\n\nDonec a justo porttitor, placerat ante sed, ullamcorper quam. Aliquam dapibus velit leo, at fermentum libero iaculis eget. Nullam eu mattis lorem, ac vulputate libero. Duis quis dui eget leo condimentum eleifend a et nisi. Suspendisse lorem tortor, pharetra vitae ornare vel, ullamcorper eu odio. Sed suscipit iaculis massa eu varius. Proin augue quam, ullamcorper quis velit sed, ultrices condimentum orci. Vivamus nisi leo, convallis fermentum dolor quis, suscipit iaculis nisi."
                    }
                );
                posts.Add(
                    new Post()
                    {
                        Id = 2,
                        Title = "Fifth post of the blog",
                        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut quis enim eu augue tincidunt tincidunt. Nam luctus pharetra tortor, sit amet sodales odio bibendum non. Nulla imperdiet tempor metus, sit amet posuere justo laoreet nec. Nullam vehicula commodo posuere. Ut elementum, purus id posuere porttitor, massa purus tristique sapien, nec sollicitudin massa lectus ac erat. Nunc id tortor quis leo placerat accumsan nec scelerisque ligula. Vivamus in efficitur felis. Cras tincidunt eleifend leo ut volutpat. Sed ut ligula eu risus pretium volutpat sit amet vel lorem. Aliquam gravida blandit risus non laoreet.\n\nPraesent felis velit, interdum ac laoreet luctus, finibus vel lorem. In vitae dolor ipsum. Quisque pretium eu ex in egestas. Nam imperdiet in diam eu maximus. Nulla tristique magna velit, vitae scelerisque augue facilisis id. Nulla in ultricies ex, nec lobortis felis. Nam nec vestibulum libero, ut laoreet tellus. Pellentesque ut metus sed nulla fermentum consequat at nec ligula. Donec pretium nisi rhoncus elit tincidunt, eu euismod ligula semper.\n\nIn at enim sit amet magna luctus sagittis et quis lacus. In blandit enim risus, eu pharetra nibh pharetra id. Nullam diam augue, fermentum eget aliquam sed, ornare sit amet dolor. Fusce fringilla vestibulum aliquam. Curabitur id laoreet lectus. Proin pretium nunc vel sem bibendum fringilla. Aliquam rhoncus neque enim, pellentesque consequat turpis gravida in. Ut at massa non augue fringilla pellentesque. Mauris consectetur pellentesque mauris molestie ullamcorper. Vivamus at nisi sed turpis cursus porttitor a sed enim. Quisque nec lorem ultrices, vestibulum sapien et, sollicitudin arcu. Donec augue risus, eleifend a tempus eu, hendrerit a quam.\n\nSed ex arcu, fringilla at molestie sit amet, accumsan id odio. Sed ut est orci. Suspendisse convallis mauris in fringilla facilisis. Nulla sit amet orci sed elit sollicitudin placerat. Pellentesque blandit, eros ut blandit volutpat, elit diam pulvinar tellus, vel vulputate urna augue at nisi. Suspendisse id odio quis risus dignissim elementum. Suspendisse vitae interdum dui, id euismod lacus. Mauris sit amet nisi nec diam fringilla lacinia. Nulla mauris nulla, vestibulum a convallis a, imperdiet nec neque. Phasellus aliquet sollicitudin mauris, id congue est varius sit amet. Etiam imperdiet mauris id dui iaculis commodo. Vivamus at nisl ligula. Cras iaculis varius orci, non congue nunc commodo ut.\n\nDonec a justo porttitor, placerat ante sed, ullamcorper quam. Aliquam dapibus velit leo, at fermentum libero iaculis eget. Nullam eu mattis lorem, ac vulputate libero. Duis quis dui eget leo condimentum eleifend a et nisi. Suspendisse lorem tortor, pharetra vitae ornare vel, ullamcorper eu odio. Sed suscipit iaculis massa eu varius. Proin augue quam, ullamcorper quis velit sed, ultrices condimentum orci. Vivamus nisi leo, convallis fermentum dolor quis, suscipit iaculis nisi."
                    }
                );
                posts.Add(
                    new Post()
                    {
                        Id = 3,
                        Title = "Sixth post of the blog",
                        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut quis enim eu augue tincidunt tincidunt. Nam luctus pharetra tortor, sit amet sodales odio bibendum non. Nulla imperdiet tempor metus, sit amet posuere justo laoreet nec. Nullam vehicula commodo posuere. Ut elementum, purus id posuere porttitor, massa purus tristique sapien, nec sollicitudin massa lectus ac erat. Nunc id tortor quis leo placerat accumsan nec scelerisque ligula. Vivamus in efficitur felis. Cras tincidunt eleifend leo ut volutpat. Sed ut ligula eu risus pretium volutpat sit amet vel lorem. Aliquam gravida blandit risus non laoreet.\n\nPraesent felis velit, interdum ac laoreet luctus, finibus vel lorem. In vitae dolor ipsum. Quisque pretium eu ex in egestas. Nam imperdiet in diam eu maximus. Nulla tristique magna velit, vitae scelerisque augue facilisis id. Nulla in ultricies ex, nec lobortis felis. Nam nec vestibulum libero, ut laoreet tellus. Pellentesque ut metus sed nulla fermentum consequat at nec ligula. Donec pretium nisi rhoncus elit tincidunt, eu euismod ligula semper.\n\nIn at enim sit amet magna luctus sagittis et quis lacus. In blandit enim risus, eu pharetra nibh pharetra id. Nullam diam augue, fermentum eget aliquam sed, ornare sit amet dolor. Fusce fringilla vestibulum aliquam. Curabitur id laoreet lectus. Proin pretium nunc vel sem bibendum fringilla. Aliquam rhoncus neque enim, pellentesque consequat turpis gravida in. Ut at massa non augue fringilla pellentesque. Mauris consectetur pellentesque mauris molestie ullamcorper. Vivamus at nisi sed turpis cursus porttitor a sed enim. Quisque nec lorem ultrices, vestibulum sapien et, sollicitudin arcu. Donec augue risus, eleifend a tempus eu, hendrerit a quam.\n\nSed ex arcu, fringilla at molestie sit amet, accumsan id odio. Sed ut est orci. Suspendisse convallis mauris in fringilla facilisis. Nulla sit amet orci sed elit sollicitudin placerat. Pellentesque blandit, eros ut blandit volutpat, elit diam pulvinar tellus, vel vulputate urna augue at nisi. Suspendisse id odio quis risus dignissim elementum. Suspendisse vitae interdum dui, id euismod lacus. Mauris sit amet nisi nec diam fringilla lacinia. Nulla mauris nulla, vestibulum a convallis a, imperdiet nec neque. Phasellus aliquet sollicitudin mauris, id congue est varius sit amet. Etiam imperdiet mauris id dui iaculis commodo. Vivamus at nisl ligula. Cras iaculis varius orci, non congue nunc commodo ut.\n\nDonec a justo porttitor, placerat ante sed, ullamcorper quam. Aliquam dapibus velit leo, at fermentum libero iaculis eget. Nullam eu mattis lorem, ac vulputate libero. Duis quis dui eget leo condimentum eleifend a et nisi. Suspendisse lorem tortor, pharetra vitae ornare vel, ullamcorper eu odio. Sed suscipit iaculis massa eu varius. Proin augue quam, ullamcorper quis velit sed, ultrices condimentum orci. Vivamus nisi leo, convallis fermentum dolor quis, suscipit iaculis nisi."

                    }
                );
            }
        }

        #endregion
    }
}
