using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesktop.model
{
    public class Abono
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        public DateTime fechaPago { get; set; }

        [Required]
        public decimal valorAbono { get; set; }

        public int? separado_id { get; set; } // Clave foránea

        [ForeignKey("separado_id")]
        [Required]
        public virtual Separado separado { get; set; }
    }
}
