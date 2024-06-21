using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public Separado separado { get; set; }
    }
}
