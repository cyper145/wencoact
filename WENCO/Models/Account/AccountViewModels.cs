using System.ComponentModel.DataAnnotations;

namespace WENCO.Model
{
    public class SignInViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool? RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Nombre de Usuario")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Apellido Paterno")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Apellido Materno")]
        public string LastName { get; set; }


        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefono 1")]
        public string phone1 { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefono 2")]
        public string phone2 { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "fecha de nacimento")]
        public string date_of_birth { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Foto")]
        public string photo { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}