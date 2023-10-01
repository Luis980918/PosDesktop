using PosDesktop.model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PosDesktop.context
{
    public partial class ModelVentas : DbContext
    {
        public ModelVentas()
            : base("name=ModelVentas")
        {
        }

        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Despacho> Despachos { get; set; }
    }
}
