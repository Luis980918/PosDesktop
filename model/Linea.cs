using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesktop.model
{
    public class Linea
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public List<Articulo> articulos { get; set; }
    }
}
