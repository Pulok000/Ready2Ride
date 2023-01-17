using Microsoft.AspNetCore.Identity;
using Ready2Ride.Shared;

namespace Ready2Ride.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<SuperHero> SuperHeroes { get; set; } = new List<SuperHero>();
    }
}