using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesktop.model
{
    public class Cierre
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public decimal pagoTrabajadoras { get; set; }
        [Required]
        public decimal ahorro { get; set; }
        [Required]
        public decimal totalBase { get; set; }
        [Required]
        public decimal totalEnCaja { get; set; }
        [Required]
        public decimal totalCierre { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Required]
        public List<Despacho> movimientos { get; set; }
    }
}
