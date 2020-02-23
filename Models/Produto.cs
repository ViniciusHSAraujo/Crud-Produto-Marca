using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Produto_Marca.Models {
    public class Produto {

        public int Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Esse campo é de preenchimento obrigatório.")]

        public string Nome { get; set; }

        [DisplayName("Preço")]
        [Required(ErrorMessage = "Esse campo é de preenchimento obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero.")]
        public double Preco { get; set; }

        [DisplayName("Marca")]
        [Required(ErrorMessage = "Esse campo é de preenchimento obrigatório.")]
        public int MarcaId { get; set; }

        [ForeignKey("MarcaId")]
        public virtual Marca Marca { get; set; }

    }
}
