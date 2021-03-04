using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OficinaWeb2.Models;

namespace OficinaWeb2.Data
{
    public class OficinaWeb2Context : DbContext
    {
        public OficinaWeb2Context (DbContextOptions<OficinaWeb2Context> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Carro> Carro { get; set; }
    }
}
