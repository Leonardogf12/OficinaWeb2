using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OficinaWeb2.Models
{
    public class Servico
    {
        public int ID { get; set; }

        [DisplayName("MODELO")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string VEICULO { get; set; }


        [DisplayName("SERVIÇO")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string SERVICO { get; set; }


        [DisplayName("OBSERVAÇÃO")]       
        public string OBSERVACAO { get; set; }


        [DisplayName("DATA INICIO")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DATA_DE { get; set; }


        [DisplayName("DATA FIM")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DATA_ATE { get; set; }


        //PROPS RELACIONADAS
        [NotMapped]
        public Departamento SER_DEPARTAMENTO { get; set; }

        [NotMapped]
        public Carro SER_CARRO { get; set; }

    }
}
