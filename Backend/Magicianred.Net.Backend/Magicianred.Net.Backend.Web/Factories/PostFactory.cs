using Magicianred.Net.Backend.Domain.Interfaces.Models;
using Magicianred.Net.Backend.Web.Models;
using System.Collections.Generic;
using System.Linq;

using ModelPost = Magicianred.Net.Backend.Domain.Models.Post;

namespace Magicianred.Net.Backend.Web.Factories
{
    /// <summary>
    /// Convert Post model domain into a Post Ef entity
    /// </summary>
    public static class PostFactory
    {

        /// <summary>
        /// Covert 
        /// </summary>
        /// <param name="itemDTO"></param>
        /// <returns></returns>
        public static ModelPost ToModelDomain(this PostDTO itemDTO)
        {
            ModelPost model = null;
            if (itemDTO != null)
            {
                model = new ModelPost
                {
                    Id = itemDTO.Id,
                    Title = itemDTO.Title,
                    Text = itemDTO.Text,
                    CreateDate = itemDTO.CreatedDate
                };
            }
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemDTOs"></param>
        /// <returns></returns>
        public static List<ModelPost> ToModelsDomain(this List<PostDTO> itemDTOs)
        {
            List<ModelPost> models = null;
            if (itemDTOs != null && itemDTOs.Any())
            {
                models = new List<ModelPost>();
                itemDTOs.ForEach(item =>
                {
                    models.Add(item.ToModelDomain());
                });
            }
            return models;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static PostDTO ToItemDTO(this IPost model)
        {
            PostDTO itemDTO = null;
            if (model != null)
            {
                itemDTO = new PostDTO
                {
                    Id = model.Id,
                    Title = model.Title,
                    Text = model.Text,
                    CreatedDate = model.CreatedDate
                };
            }
            return itemDTO;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public static List<PostDTO> ToItemDTOs(this List<IPost> models)
        {
            List<PostDTO> itemDTOs = null;
            if (models != null && models.Any())
            {
                itemDTOs = new List<PostDTO>();
                models.ForEach(item =>
                {
                    itemDTOs.Add(item.ToItemDTO());
                });
            }
            return itemDTOs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static PostDTO ToItemDTO(this ModelPost model)
        {
            PostDTO itemDTO = null;
            if (model != null)
            {
                itemDTO = new PostDTO
                {
                    Id = model.Id,
                    Title = model.Title,
                    Text = model.Text,
                    CreatedDate = model.CreateDate
                };
            }
            return itemDTO;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public static List<PostDTO> ToItemDTOs(this List<ModelPost> models)
        {
            List<PostDTO> itemDTOs = null;
            if (models != null && models.Any())
            {
                itemDTOs = new List<PostDTO>();
                models.ForEach(item =>
                {
                    itemDTOs.Add(item.ToItemDTO());
                });
            }
            return itemDTOs;
        }
    }
}