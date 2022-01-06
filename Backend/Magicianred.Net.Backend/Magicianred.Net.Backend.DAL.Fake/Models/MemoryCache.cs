using System.Collections.Generic;

namespace Magicianred.Net.Backend.DAL.Fake.Models
{
    public static class MemoryCache<T>
    {
        private static readonly List<T> ts = new List<T>();
        private static List<T> items = ts;

        public static List<T> Items { get => items; set => items = value; }
    }
}
