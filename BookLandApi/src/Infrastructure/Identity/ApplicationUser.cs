using System.Collections.Generic;
using Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public IEnumerable<Book> FavouriteBooks { get; set; } = new List<Book>();
    }
}