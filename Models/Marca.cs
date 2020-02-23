using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Produto_Marca.Models {
    public class Marca {

        public int Id{ get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Esse campo é de preenchimento obrigatório.")]
        public string Nome { get; set; }

    }
}
