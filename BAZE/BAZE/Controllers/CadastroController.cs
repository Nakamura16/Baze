using BAZE.Models;
using BAZE.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace BAZE.Controllers
{
    public class CadastroController : Controller
    {

        private UsuarioContext _context;

        public CadastroController(UsuarioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["msg"] = "Cadastro de Cliente";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            ViewData["msg"] = "Usuário " + usuario.Nome + " cadastrado com Sucesso!";
            return View(usuario);
        }
    }
}
