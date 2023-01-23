using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ready2Ride.Shared
{
    public class TicketDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string BusName { get; set; }
        [Required]
        public DateTime ScheduleDate { get; set; }

        public TicketDto()
        {
                
        }
    }

}
