using System;
using System.Runtime.Serialization;

namespace Magicianred.Net.Backend.Web.Models
{
    [DataContract]
    public class PostDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public DateTime CreateDate { get; set; }
    }
}