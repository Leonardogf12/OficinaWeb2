using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OficinaWeb2.Services;
using OficinaWeb2.Models;

namespace OficinaWeb2.Controllers
{
    public class CarrosController : Controller
    {
        public readonly CarroService _carroService; //obj

        public CarrosController(CarroService carroService) //construtor
        {
            _carroService = carroService;
        }

        //GET
        public IActionResult Index()
        {
            var lista = _carroService.FindAll();
            return View(lista);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }
            
        //GET
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _carroService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Carro carro)
        {
            _carroService.Inserir(carro);
            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _carroService.Remover(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
