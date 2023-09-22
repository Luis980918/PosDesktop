using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesktop.model
{
    public class Venta
    {
        // Atributos
        public int numeroItem { get; set; }
        public decimal precioUnitario { get; set; }
        public int cantidad { get; set; }

        // Calcula el precio total automáticamente
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
