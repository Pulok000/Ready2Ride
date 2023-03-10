using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ready2Ride.Shared
{
    public class UserDto
    {

        public string UserName { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmation { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }

        public UserDto() { }
    }
}
