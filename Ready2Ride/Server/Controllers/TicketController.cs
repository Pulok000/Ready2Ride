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


        [HttpPost]
        [Route("AddTicket")]
        public async Task<IActionResult> AddTicket(TicketDto newTicket)
        {
            var ticket = new Ticket
            {
                BusName = newTicket.BusName,
                ScheduleDate = newTicket.ScheduleDate,
                UserName = newTicket.UserName,
                Email = newTicket.Email
            };

            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTicket", new { id = ticket.Id }, ticket);
        }


    }
}