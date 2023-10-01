using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesktop.model
{
    public class Venta
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public int numeroItem { get; set; }
        [Required]
        public decimal precioUnitario { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        public Despacho despacho { get; set; }

        // Calcula el precio total automáticamente
        [Required]
        public decimal precioTotal => precioUnitario * cantidad;
        // Constructor
        public Venta(int numeroItem, decimal precioUnitario)
        {
            this.numeroItem = numeroItem;
            this.precioUnitario = precioUnitario;
        }
        public Venta()
        {
        }
    }
}
