using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OficinaWeb2.Services;
using OficinaWeb2.Models;

namespace OficinaWeb2.Controllers
{
    public class ServicosController : Controller
    {
        public ServicoService _servicoService;

        public ServicosController(ServicoService servicoService)
        {
            _servicoService = servicoService;
        }
            
        //GET
        public IActionResult Index()
        {
            var lista = _servicoService.FindAll();
            return View(lista);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }





        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Servico obj)
        {
            _servicoService.Inserir(obj);
            return RedirectToAction(nameof(Index));
        }
    }
}
