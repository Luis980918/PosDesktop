using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesktop.model
{
    // Implementar atributos y métodos basicos para artículo, adicional, asociar con Linea y Proveedor
    public class Articulo
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string codigo { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string descripcion { get; set; }
        [Required]
        public decimal precio { get; set; }
        [Required]
        public decimal porcentaje { get; set; }
        [Required]
        public decimal costo { get; set; }
        [Required]
        public int stock { get; set; }
        public Linea linea { get; set; }
        public Proveedor proveedor { get; set; }
    }
}
