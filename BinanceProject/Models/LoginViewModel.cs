using System.ComponentModel.DataAnnotations;

namespace BinanceProject.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El Email es requerido")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es requerida")]
        public string Password { get; set; } = string.Empty;
    }
}
