using System.ComponentModel.DataAnnotations;

namespace PetshopApp.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        [Display(Name = "Descrição")]
        public string Descricao {get; set;}
        public int QuantidadeEstoque {get; set;}
        [Display(Name = "Preço de Compra")]
        // [DataType(DataType.Currency)]
        public float PrecoCompra {get; set;}
        [Display(Name = "Preço de Venda")]
        // [DataType(DataType.Currency)]
        public float PrecoVenda {get; set;}
    }
}