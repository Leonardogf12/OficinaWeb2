using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OficinaWeb2.Services;
using Microsoft.EntityFrameworkCore;
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
            try
            {
                if (id == null)
                {
                    return NotFound();
                }
                var obj = _carroService.FindById(id.Value);
                if (obj == null)
                {
                    return NotFound();
                }
                return View(obj);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }


        //GET
        public IActionResult Details(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }
                var obj = _carroService.FindById(id.Value);
                if (obj == null)
                {
                    return NotFound();
                }
                return View(obj);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message );
            }
            
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



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, Carro carro)
        {
            if(id != carro.ID)
            {
                return BadRequest();
            }
            try
            {
                _carroService.Update(carro);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            } 
           
           
        }
    }
}
