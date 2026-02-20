using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesktop.model
{ 
    public class Proveedor
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string razonSocial { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string telefono { get; set; }
        [Required]
        public string correo { get; set; }
        public string contacto { get; set; }
        public string observaciones { get; set; }
        public List<Articulo> articulos { get; set; }
    }
}
