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
    public class Carro
    {
        public int ID { get; set; }

        [DisplayName("MODELO")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string MODELO { get; set; }

        [DisplayName("PLACA")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string PLACA { get; set; }



        //PROPS RELACIONADOS
       [NotMapped]
        public Cliente CAR_CLIENTE { get; set; }


        [NotMapped]
        public ICollection<Servico> CAR_SERVICOS { get; set; } = new List<Servico>();

    }
}
