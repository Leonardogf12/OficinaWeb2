using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using OficinaWeb2.Models;

namespace OficinaWeb2.Models
{
    public class Departamento
    {
        
        public int ID { get; set; }

        [DisplayName("DEPARTAMENTO")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string NOME { get; set; }



        //PROPS RELACIONADAS
        [NotMapped]
        public ICollection<Servico> DEP_SERVICOS { get; set; } = new List<Servico>();

    }
}
