using System.ComponentModel.DataAnnotations;

namespace calculoDeCombustivel.Models
{
    public class CombustivelModel
    {
        [Required(ErrorMessage = "O valor da gasolina é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor da gasolina deve ser maior que zero")]
        [Display(Name = "Preço da Gasolina (R$)")]
        public decimal Gasolina { get; set; }

        [Required(ErrorMessage = "O valor do etanol é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do etanol deve ser maior que zero")]
        [Display(Name = "Preço do Etanol (R$)")]
        public decimal Etanol { get; set; }

        public string? Resultado { get; set; }
        public decimal? Indice { get; set; }
    }
}
