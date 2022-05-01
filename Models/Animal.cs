using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetshopApp.Models
{
    public class Animal
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DtNascimento {get; set;}
        [Display(Name = "Raça")]
        public string Raca {get; set;}
        public string Porte {get; set;}
        public string Sexo {get; set;}
        [Display(Name = "Espécie")]
        public string Especie {get; set;}
        [Display(Name = "Proprietario")]
        public int ProprietarioId {get; set;}

        public virtual Proprietario Proprietario {get; set;}
    }
}