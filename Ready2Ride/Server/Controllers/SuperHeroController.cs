using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ready2Ride.Server.Data;
using Ready2Ride.Server.Models;
using Ready2Ride.Shared;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;

namespace Ready2Ride.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public SuperHeroController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
           

        }
        [HttpGet]

        public async Task<ActionResult<List<SuperHero>>> GetSuperHero()
        {
            var user = await _userManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            //var user = await _context.Users.
            //    Include(u => u.SuperHeroes)
            //    .FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (user == null)
                return NotFound();
            return Ok(user.SuperHeroes);
        }


    }
}
