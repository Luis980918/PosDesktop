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
    internal class DespachoController
    {
        ModelVentas db = new ModelVentas();
        public List<Despacho> GetDespachos()
        {
            return db.Despachos.ToList();
        }

        public List<Despacho> Search(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio == null && fechaFin == null)
            {
                return db
                    .Despachos
                    .Where(x => x.fechaMovimiento == DateTime.UtcNow).ToList();
            } else
            {
                return db
                    .Despachos
                    .Where(x => x.fechaMovimiento >= fechaInicio && x.fechaMovimiento <= fechaFin).ToList();
            }
        }

        public bool Create(Despacho despacho)
        {
            Despacho ventaGuardar = db.Despachos.Add(despacho);
            return db.SaveChanges() > 0;
        }

        public bool Update(Despacho despacho)
        {
            db.Despachos.Attach(despacho);
            db.Entry(despacho).State = EntityState.Modified;
            return db.SaveChanges() > 0;

        }

        public bool Delete(Despacho despacho)
        {
            db.Despachos.Remove(despacho);
            return db.SaveChanges() > 0;
        }
    }
}
