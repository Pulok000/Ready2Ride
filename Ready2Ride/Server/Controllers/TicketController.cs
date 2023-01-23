using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ready2Ride.Server.Data;
using Ready2Ride.Shared;



namespace Ready2Ride.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TicketController(ApplicationDbContext context)
        {
            _context = context;
        }
  


        [HttpGet]
        public async Task<ActionResult> TicketDetails()
        {
            var ticket = await _context.Tickets.ToListAsync();
            List<TicketDto> u = new List<TicketDto>();
            foreach (var n in ticket)
            {
                u.Add(new TicketDto
                {
                    Id = n.Id,
                    UserName = n.UserName,
                    Email = n.Email,
                    BusName = n.BusName,
                    ScheduleDate = n.ScheduleDate,

                });

            }
            return Ok(u);
        }




    }
}