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
    internal class CierreController
    {
        ModelVentas db = new ModelVentas();
        public List<Cierre> GetCierres()
        {
            return db.Cierres.ToList();
        }

        public List<Cierre> Search(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio == null && fechaFin == null)
            {
                return db
                    .Cierres
                    .Where(x => x.fecha == DateTime.UtcNow).ToList();
            } else
            {
                return db
                    .Cierres
                    .Where(x => x.fecha >= fechaInicio && x.fecha <= fechaFin).ToList();
            }
            return db.Cierres.ToList();
        }

        public List<Cierre> SearchByToday()
        {
            DateTime today = DateTime.Now.Date;
            DateTime tomorrow = today.AddDays(1);

            return db
                .Cierres
                .Where(x => x.fecha >= today && x.fecha < tomorrow)
                .ToList();
        }

        public Cierre SearchById(int id)
        {
            return db
                    .Cierres
                    .Where(x => x.id == id).First();
        }

        public bool Create(Cierre cierre)
        {
            Cierre ventaGuardar = db.Cierres.Add(cierre);
            return db.SaveChanges() > 0;
        }

        public bool Update(Cierre cierre)
        {
            Cierre cierreAct = SearchById(cierre.id);
            cierreAct.pagoTrabajadoras = cierre.pagoTrabajadoras;
            cierreAct.totalEnCaja = cierre.totalEnCaja;
            cierreAct.totalCierre = cierre.totalCierre;
            cierreAct.ahorro = cierre.ahorro;
            cierreAct.totalBase = cierre.totalBase;
            db.Cierres.Attach(cierreAct);
            db.Entry(cierreAct).State = EntityState.Modified;
            return db.SaveChanges() > 0;

        }

        public bool Delete(Cierre cierre)
        {
            db.Cierres.Remove(cierre);
            return db.SaveChanges() > 0;
        }
    }
}
