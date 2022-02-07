using Microsoft.AspNetCore.Mvc;

namespace SistemasVentas.Areas.Users.Controllers
{
    [Area("Users")]
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}
