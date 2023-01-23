using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ready2Ride.Server.Data;
using Ready2Ride.Server.Models;
using Ready2Ride.Shared;

namespace Ready2Ride.Server.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        public readonly ApplicationDbContext _applicationDbContext;
        public readonly UserManager<ApplicationUser> _usermanager;

        public UserManagementController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> usermanager)
        {
            _applicationDbContext= applicationDbContext;
            _usermanager= usermanager;
        }

        [HttpGet]
        public async Task<ActionResult> GetUser()
        {
            var user = await _usermanager.Users.ToListAsync();
            List<UserDto> u = new List<UserDto>();
            foreach (var n in user) {
                u.Add(new UserDto
                {
                    Email=n.Email,
                    EmailConfirmation=n.EmailConfirmed,
                    UserId=n.Id,
                    UserName=n.UserName,
                    FirstName=n.FirstName, 
                    LastName=n.LastName,
                });
            
            }
            return Ok(u);
        }
    }
}
