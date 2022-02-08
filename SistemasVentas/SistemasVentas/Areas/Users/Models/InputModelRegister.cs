using System.ComponentModel.DataAnnotations;

namespace SistemasVentas.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "Campo nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Apellido es obligatorio")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Campo de cedula es obligatorio")]
        public string CI { get; set; }

        [Required(ErrorMessage = "Campo de telefono es obligatorio")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{5})$", ErrorMessage = "El formato de telefono no es valido")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Campo email es obligatorio")]
        [EmailAddress(ErrorMessage = "no es una direccion de correo electronico validad")]
        public string Email { get; set; }

        [Display(Name = "Contrasena")]
        [Required(ErrorMessage = "Campo Password es obligatorio")]
        [StringLength(100, ErrorMessage = "El numerod e caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Seleccione un rol")]
        public string Role { get; set; }
    }
}
