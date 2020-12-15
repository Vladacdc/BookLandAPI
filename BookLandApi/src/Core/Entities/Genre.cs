using System.Collections.Generic;
using Core.Common;

namespace Core.Entities
{
    public class Genre : AuditableEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public IEnumerable<Book> Books { get; set; } = new List<Book>();
    }
}