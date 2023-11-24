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
        public IActionResult Desafio()
        {
            var lista = _context.Desafios.ToList();
            return View(lista);
        }
        public IActionResult CadastroDesafio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroDesafio(Desafio desafio)
        {
            _context.Desafios.Add(desafio);
            _context.SaveChanges();
            ViewData["msg"] = "Desafio " + desafio.Nome + " cadastrado com Sucesso!";
            return View(desafio);
        }

        public IActionResult DesafioExcluir(int id)
        {
            var desafio = _context.Desafios.Find(id);
            _context.Desafios.Remove(desafio);
            _context.SaveChanges();
            TempData["msg"] = "Desafio removido!";
            return RedirectToAction("Desafio");
        }

        public IActionResult Bikes()
        {
            var lista = _context.Bikes.ToList();
            return View(lista);
        }

        //cadastra a bike
        [HttpPost]
        public IActionResult CadastroBikes(Bike bike)
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

        public IActionResult CadastroBikes()
        {
            return View();
        }

        public IActionResult Corridas()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BikeBusca(Bike bike)
        {
            var find = _context.Bikes.Where(b => b.Nome == bike.Nome).FirstOrDefault();
            ViewData["msg"] = "Bike " + bike.Nome + " encontrada!";
            return View(bike);
        }

        public IActionResult BikeBusca()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BikeEditar(Bike bike)
        {
            Usuario usuario = new Usuario();
            usuario.Senha = "123";
            bike.Usuario = usuario;
            bike.UsuarioId = 1;
            _context.Bikes.Update(bike);
            _context.SaveChanges();
            TempData["msg"] = "Bike atualizada";
            return RedirectToAction("bikes");
        }

        public IActionResult BikeEditar(int id)
        {
            var bike = _context.Bikes.First(b => b.Id == id);
            return View(bike);
        }

        public IActionResult BikeExcluir(int id)
        {
            var bike = _context.Bikes.Find(id);
            _context.Bikes.Remove(bike);
            _context.SaveChanges();
            TempData["msg"] = "Bike removida!";
            return RedirectToAction("Bikes");
        }
    }
}
