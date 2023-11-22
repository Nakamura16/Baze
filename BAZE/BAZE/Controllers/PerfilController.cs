using BAZE.Models;
using Microsoft.AspNetCore.Mvc;

namespace BAZE.Controllers
{
    public class PerfilController : Controller
    {
        public static Usuario _usuario;
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Bikes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroBikes(Usuario usuario)
        {
            return View();
        }

        public IActionResult CadastroBikes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bike bike)
        {
            return View();
        }

        public IActionResult Corridas()
        {
            return View();
        }
    }
}
