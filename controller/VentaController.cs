using PosDesktop.context;
using PosDesktop.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesktop.controller
{
    internal class VentaController
    {
        ModelVentas db = new ModelVentas();
        public List<Venta> GetVentas()
        {
            return db.Ventas.ToList();
        }

        public List<Venta> Search(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio == null && fechaFin == null)
            {
                return db
                    .Ventas
                    .Where(x => x.fechaMovimiento == DateTime.UtcNow).ToList();
            } else
            {
                return db
                    .Ventas
                    .Where(x => x.fechaMovimiento >= fechaInicio && x.fechaMovimiento <= fechaFin).ToList();
            }
        }

        public bool Create(Venta venta)
        {
            Venta ventaGuardar = db.Ventas.Add(venta);
            return db.SaveChanges() > 0;
        }

        public bool Update(Venta venta)
        {
            db.Ventas.Attach(venta);
            db.Entry(venta).State = EntityState.Modified;
            return db.SaveChanges() > 0;

        }

        public bool Delete(Venta venta)
        {
            db.Ventas.Remove(venta);
            return db.SaveChanges() > 0;
        }
    }
}
