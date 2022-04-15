using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetshopApp.Models
{
    public class Produto
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        [Display(Name = "Descrição")]
        public string Descricao {get; set;}

        [Display(Name = "Quantidade em Estoque")]
        public int QuantidadeEstoque {get; set;}

        [Display(Name = "Preço de Compra")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public double PrecoCompra {get; set;}

        [Display(Name = "Preço de Venda")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public double PrecoVenda {get; set;}
    }
}