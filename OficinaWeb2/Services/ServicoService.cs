using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OficinaWeb2.Data;
using OficinaWeb2.Models;

namespace OficinaWeb2.Services
{
    public class ServicoService
    {
        public readonly OficinaWeb2Context _context;

        public ServicoService(OficinaWeb2Context context)
        {
            _context = context;
        }

        public List<Servico> FindAll()
        {
            return _context.Servico.ToList();
        }

        public Servico FindById(int id)
        {
          return _context.Servico.FirstOrDefault(m => m.ID == id);  
        }           
        
        public void Inserir(Servico obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
