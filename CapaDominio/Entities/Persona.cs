using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entities
{
    public class Persona
    {
        [Key]
        public int PersonaID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El rol es requerido")]
        [StringLength(50)]
        public string Rol { get; set; } // Anciano, Diácono, Mentor, Líder, Discípulo

        public int RedID { get; set; }

        // Relación con Red
        public virtual Red Red { get; set; }

        // Relación con Tickets
        public virtual ICollection<Ticket> Tickets { get; set; }
    }

}
