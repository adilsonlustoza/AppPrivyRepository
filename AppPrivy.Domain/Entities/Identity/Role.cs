using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace AppPrivy.Domain.Entities.Identity
{
    public class Role : IdentityRole<int>
    {
        public List<UserRole> UserRoles { get; set; }
    }
}