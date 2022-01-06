using Magicianred.Net.Backend.Domain.Interfaces.Models;
using System;

namespace Magicianred.Net.Backend.Domain.Models
{
    public partial class Post : IPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
