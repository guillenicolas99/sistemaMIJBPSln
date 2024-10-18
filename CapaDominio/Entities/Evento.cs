using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entities
{
    public class Evento
    {
        [Key]
        public int EventoID { get; set; }

        [Required(ErrorMessage = "El nombre del evento es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }

        public DateTime FechaEvento { get; set; }

        // Relación con Tickets
        public virtual ICollection<Ticket>? Tickets { get; set; }
    }

}
