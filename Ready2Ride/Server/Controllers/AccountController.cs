using Microsoft.AspNetCore.Mvc;
using Ready2Ride.Server.Data;

namespace Ready2Ride.Server.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
