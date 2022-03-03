using Omnicanal.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Omnicanal.Models
{
    public class Asesor : Usuario
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "{0} admite un máximo de {1} caracteres")]
        [MinLength(2, ErrorMessage = "{0} debe tener un mínimo de {1} caracteres")]
        [RegularExpression(@"[a-zA-Z0-9]*", ErrorMessage = "El campo {0} sólo admite caracteres alfanuméricos")]
        [Display(Name = "Nombre de usuario")]
        public string NombreUsuario;

        [ScaffoldColumn(false)]
        public byte[] Password { get; set; }

        public override Rol Rol => Rol.Asesor;
    }
}