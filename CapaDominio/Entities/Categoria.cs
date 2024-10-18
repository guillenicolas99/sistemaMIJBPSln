using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entities
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        [Required(ErrorMessage = "El nombre de la categoría es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }

        // Relación con Tickets
        public virtual ICollection<Ticket> Tickets { get; set; }
    }

}
