using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketID { get; set; }

        [Required(ErrorMessage = "El número de ticket es requerido")]
        public string NumeroTicket { get; set; }  // Campo adicional para la numeración

        public int PersonaID { get; set; }
        public int EventoID { get; set; }
        public int CategoriaID { get; set; }

        public decimal PrecioAbonado { get; set; }
        public decimal DescuentoAplicado { get; set; }
        public DateTime? FechaLimiteDescuento { get; set; }

        // Relación con Persona
        public virtual Persona Persona { get; set; }

        // Relación con Evento
        public virtual Evento Evento { get; set; }

        // Relación con Categoria
        public virtual Categoria Categoria { get; set; }
    }

}
