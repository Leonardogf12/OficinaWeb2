﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OficinaWeb2.Data;
using OficinaWeb2.Models;

namespace OficinaWeb2.Services
{
    public class CarroService
    {
        public readonly OficinaWeb2Context _context;

        public CarroService(OficinaWeb2Context context)
        {
            _context = context;
        }
        
        //retorna a lista de todos carros no banco.
        public List<Carro> FindAll()
        {
            return _context.Carro.ToList();
        }


        //retorna se o id for igual ao id que foi selecionado para deletar um carro pela controller.
        public Carro FindById(int id)
        {
            return _context.Carro.FirstOrDefault(obj => obj.ID == id);
        }


        //usado na View de Create - vai inserir no banco um novo carro.
        public void Inserir(Carro obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }


        //procura o id no banco, apaga e salva
        public void Remover(int id)
        {
           var obj =  _context.Carro.Find(id);
            _context.Remove(obj);
            _context.SaveChanges();
        }
        
       

    }
}
