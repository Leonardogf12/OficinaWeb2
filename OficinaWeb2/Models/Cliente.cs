using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OficinaWeb2.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        [DisplayName("CLIENTE")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string NOME { get; set; }


        [DisplayName("NASCIMENTO")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime NASCIMENTO { get; set; }


        [DisplayName("CPF")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string CPF { get; set; }


        [DisplayName("ENDEREÇO")]
        public string ENDERECO { get; set; }


        [DisplayName("CELULAR")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string CONTATO { get; set; }

        [DisplayName("E-MAIL")]
        [EmailAddress]
        public string EMAIL { get; set; }


        //PROPS RELACIONADOS
        [NotMapped]
        public Carro CLI_CARRO { get; set; }

    }
}
