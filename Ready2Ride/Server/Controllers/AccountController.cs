using Microsoft.AspNetCore.Mvc;

namespace Ready2Ride.Server.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
