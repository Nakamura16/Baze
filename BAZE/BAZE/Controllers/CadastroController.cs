using BAZE.Models;
using Microsoft.AspNetCore.Mvc;

namespace BAZE.Controllers
{
    public class CadastroController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["msg"] = "Cadastro de Cliente";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {
            ViewData["msg"] = "Usuário " + usuario.Nome + " cadastrado com Sucesso!";
            return View(usuario);
        }
    }
}
