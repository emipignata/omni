using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Omnicanal.Models
{
    public class Contacto
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Cliente))]
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [ForeignKey(nameof(Asesor))]
        public Guid AsesorId { get; set; }
        public Asesor Asesor { get; set; }

        public List<Mensaje> Mensajes { get; set; }

        [Display(Name = "Estado abierto")]
        public bool Estado;
    }
}