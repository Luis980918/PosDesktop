using PosDesktop.context;
using PosDesktop.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PosDesktop.controller
{
    internal class SeparadoController
    {
        ModelVentas db = new ModelVentas();
        public List<Separado> GetSeparados()
        {
            return db.Separados.ToList();
        }

        public List<Separado> Search(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio == null && fechaFin == null)
            {
                return db
                    .Separados
                    .Where(x => x.fecha == DateTime.UtcNow).ToList();
            } else
            {
                return db
                    .Separados
                    .Where(x => x.fecha >= fechaInicio && x.fecha <= fechaFin).ToList();
            }
            return db.Separados.ToList();
        }

        public List<Separado> SearchByAllFilters(DateTime fechaInicio, DateTime fechaFin, String nombreCliente)
        {
            DateTime inicio = fechaInicio != null ? fechaInicio : DateTime.UtcNow;
            DateTime fin = fechaFin != null ? fechaFin : DateTime.UtcNow.AddDays(1);

            return db.Separados
                     .Where(x => x.fecha >= inicio && x.fecha < fin &&
                                 (nombreCliente == null || x.cliente.Contains(nombreCliente)))
                     .ToList();
        }

        public List<Separado> SearchByToday()
        {
            DateTime today = DateTime.Now.Date;
            DateTime tomorrow = today.AddDays(1);

            return db
                .Separados
                .Where(x => x.fecha >= today && x.fecha < tomorrow)
                .ToList();
        }

        public Separado SearchById(int id)
        {
            return db
                    .Separados
                    .Where(x => x.id == id).First();
        }

        public bool Create(Separado separado)
        {
            Separado ventaGuardar = db.Separados.Add(separado);
            return db.SaveChanges() > 0;
        }

        public bool Update(Separado separado)
        {
            Separado separadoAct = SearchById(separado.id);
            separadoAct.despachos = separado.despachos;
            separadoAct.restante = separado.restante;
            db.Separados.Attach(separadoAct);
            db.Entry(separadoAct).State = EntityState.Modified;
            return db.SaveChanges() > 0;

        }

        public bool Delete(Separado separado)
        {
            db.Separados.Remove(separado);
            return db.SaveChanges() > 0;
        }
    }
}
