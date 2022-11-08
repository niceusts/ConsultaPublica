using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string? Genero { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime ReleaseDate { get; set; }
        public string? Residencia { get; set; }

        [Display(Name = "Interferencia da Criminalidade na Cidade")]
        public string? InterferenciaCidade { get; set; }

        [Display(Name = "Interferencia da Criminalidade na Camunidade")]
        public string? InterferenciaComunidade { get; set; }

        [Display(Name = "Prioridade do poder público")]
        public string? PrioridadePoderPublico { get; set; }
        public string? Confianca { get; set; }
        public string? AcoesRelevancia { get; set; }
        public string? Descreva { get; set; }

        public bool testeVorF { get; set; }



        //public decimal Price { get; set; }
    }
}