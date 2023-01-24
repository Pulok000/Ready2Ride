using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Ready2Ride.Server.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string? Name { get; set; }
        public string? UserType { get; set; }


    }
}