using Microsoft.AspNetCore.Identity;

namespace Tut3.Areas.Data
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
