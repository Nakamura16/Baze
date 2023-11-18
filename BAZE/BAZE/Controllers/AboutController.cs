using Microsoft.AspNetCore.Mvc;

namespace BAZE.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
