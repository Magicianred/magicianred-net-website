using Magicianred.Net.Backend.Domain.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace Magicianred.Net.Backend.Domain.Models
{
    public partial class Post : IPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
        public List<ITag> Tags { get; set; }
        public long TenantId { get; set; }
        public ITenant Tenant { get; set; }
        public long CreatedId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? EditedId { get; set; }
        public DateTime? EditedDate { get; set; }
        public long? DeletedId { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
