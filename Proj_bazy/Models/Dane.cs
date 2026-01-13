using System.ComponentModel.DataAnnotations;

namespace Proj_bazy.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2)]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [EmailAddress(ErrorMessage = "Błędny format email")]
        public string Email { get; set; }
    }
}