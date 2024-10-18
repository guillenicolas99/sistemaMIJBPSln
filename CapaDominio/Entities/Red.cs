using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entities
{
    public class Red
    {
        [Key]
        public int RedID { get; set; }

        [Required(ErrorMessage = "El nombre de la red es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }

        // Relación con Personas
        public virtual ICollection<Persona> Personas { get; set; }
    }

}
