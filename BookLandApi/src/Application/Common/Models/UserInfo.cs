using System.Collections.Generic;
using System.Security.Claims;

namespace Application.Common.Models
{
    public class UserInfo
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public IEnumerable<string> Roles { get; set; } = new List<string>();
    }
}