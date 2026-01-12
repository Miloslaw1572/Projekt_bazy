using System.ComponentModel.DataAnnotations;

namespace Proj_bazy.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Błędny format email")]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        public string Role { get; set; } 
    }
}
