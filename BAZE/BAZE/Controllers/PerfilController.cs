﻿using BAZE.Models;
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
            return View();
        }

        [HttpPost]
        public IActionResult Bikes(Bike bike)
        {

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
