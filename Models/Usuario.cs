using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace validacion.Models;

public class Usuario
{
    [Required]
    [EmailAddress]
    [Remote("ValidarEmail", "Usuarios", ErrorMessage = "Este correo ya esta registrado.")]
    public string Email {get; set;} = string.Empty;

    [Required]
    [StringLength(100, MinimumLength = 8, ErrorMessage ="La contraseña debe contener 8 caracteres.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&].*$", 
    ErrorMessage ="La contraseña debe como mínimo 8 caracteres, Al menos una letra mayúscula, Al menos una letra minúscula,  Al menos un número, Al menos un carácter especial (como @, #, $, etc.)."
)]
    public string Password {get; set;} = string.Empty;
}
