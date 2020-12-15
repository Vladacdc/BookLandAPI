using System.Collections.Generic;
using Core.Common;

namespace Core.Entities
{
    public class Author : AuditableEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<Book> Books { get; set; } = new List<Book>();
    }
}