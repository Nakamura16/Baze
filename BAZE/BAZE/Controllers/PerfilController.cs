using BAZE.Models;
using BAZE.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace BAZE.Controllers
{
    public class PerfilController : Controller
    {
        private UsuarioContext _context;

        public PerfilController(UsuarioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bikes()
        {
            var lista = _context.Bikes.ToList();
            return View(lista);
        }

        //cadastra a bike
        [HttpPost]
        public IActionResult Bikes(Bike bike)
        {
            Usuario usuario = new Usuario();
            usuario.Senha = "123";
            bike.Usuario = usuario;
            bike.UsuarioId = 1;
            _context.Bikes.Add(bike);
            _context.SaveChanges();
            ViewData["msg"] = "Bike " + bike.Nome + " cadastrado com Sucesso!";
            return View(bike);
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

        public IActionResult Corridas()
        {
            return View();
        }
    }
}
