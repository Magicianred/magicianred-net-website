using System;

namespace Magicianred.Net.Backend.Domain.Interfaces.Models
{
    public interface IPost
    {
        int Id { get; set; }
        string Title { get; set; }
        string Text { get; set; }
        DateTime CreateDate { get; set; }
    }
}
