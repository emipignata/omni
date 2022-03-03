using Omnicanal.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Omnicanal.Models
{
    public abstract class Usuario
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "{0} admite un máximo de {1} caracteres")]
        [MinLength(2, ErrorMessage = "{0} debe tener un mínimo de {1} caracteres")]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = "El campo {0} sólo admite caracteres alfabéticos")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "{0} admite un máximo de {1} caracteres")]
        [MinLength(2, ErrorMessage = "{0} debe tener un mínimo de {1} caracteres")]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = "El campo {0} sólo admite caracteres alfabéticos")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "{0} admite un máximo de {1} caracteres")]
        [EmailAddress(ErrorMessage = "El campo {0} debe ser un email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(8, ErrorMessage = "El campo {0} admite un máximo de {1} caracteres")]
        [RegularExpression(@"[0-9]*", ErrorMessage = "El campo {0} sólo admite números")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(30, ErrorMessage = "El campo {0} admite un máximo de {1} caracteres")]
        [RegularExpression(@"[0-9/-]*", ErrorMessage = "El campo {0} sólo admite números y guiones")]
        public string Telefono { get; set; }

        public abstract Rol Rol { get; }

    }
}