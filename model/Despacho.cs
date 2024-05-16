using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesktop.model
{
    public class Despacho
    {
        [Key]
        [Required]
        public int id {  get; set; }
        [Required]
        public decimal pagoTotal { get; set; }
        [Required]
        public decimal totalRecibido { get; set; }
        [Required]
        public decimal totalDevuelto { get; set; }
        [Required]
        public DateTime fechaMovimiento { get; set; }
        [Required]
        public List<Venta> ventas {  get; set; }
        public Separado separados { get; set; }

    }
}
