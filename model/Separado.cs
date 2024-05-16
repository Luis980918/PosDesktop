using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesktop.model
{
    public class Separado
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string cliente { get; set; }
        [Required]
        public string articulos { get; set; }
        [Required]
        public decimal costoTotal { get; set; }
        [Required]
        public decimal restante { get; set; }
        [Required]
        public DateTime fecha { get; set; }

        [Required]
        public List<Despacho> despachos { get; set; }
    }
}
