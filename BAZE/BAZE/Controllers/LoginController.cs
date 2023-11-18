using Microsoft.AspNetCore.Mvc;

namespace BAZE.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
