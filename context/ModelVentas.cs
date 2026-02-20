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
        public virtual DbSet<Cierre> Cierres { get; set; }
        public virtual DbSet<Separado> Separados { get; set; }
        public virtual DbSet<Abono> Abonos { get; set; }
        public virtual DbSet<Linea> Lineas { get; set; }
        public virtual DbSet<Proveedor> Proveedores { get; set; }
        public virtual DbSet<Articulo> Articulos { get; set; }

    }
}
