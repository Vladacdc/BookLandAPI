using System.Collections.Generic;
using Core.Common;

namespace Core.Entities
{
    public class Book : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int PublishedYear { get; set; }

        public decimal Price { get; set; }

        public decimal? DiscountPrice { get; set; }

        public int LeftInStock { get; set; }

        public int ViewsCount { get; set; }

        public IEnumerable<Genre> Genres { get; set; } = new List<Genre>();

        public IEnumerable<Author> Authors { get; set; } = new List<Author>();

        public IEnumerable<BookComment> Comments { get; set; } = new List<BookComment>();
    }
}