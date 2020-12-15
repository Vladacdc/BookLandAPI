using Core.Common;

namespace Core.Entities
{
    public class BookComment : AuditableEntity
    {
        public int Id { get; set; }
        
        public string Body { get; set; }

        public decimal? Rating { get; set; }

        public Book Book { get; set; }
    }
}