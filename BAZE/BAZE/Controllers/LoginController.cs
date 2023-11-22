using BAZE.Models;
using BAZE.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace BAZE.Controllers
{
    public class LoginController : Controller
    {
        private UsuarioContext _context;
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            var username = _context.Usuarios.Where(
                u => u.NomeUsuario == usuario.NomeUsuario
                && u.Senha == usuario.Senha).FirstOrDefault();
            if (username != null)
            {
                HttpContext.Session.SetString("LoggedUser", usuario.Nome);
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
