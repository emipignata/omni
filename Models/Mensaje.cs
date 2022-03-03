using Omnicanal.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Omnicanal.Models
{
    public class Mensaje
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(250, ErrorMessage = "{0} admite un máximo de {1} caracteres")]
        public string Descripcion { get; set; }

        public Canal Canal { get; set; }
    }
}