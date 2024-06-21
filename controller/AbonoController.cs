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
    internal class AbonoController
    {
        ModelVentas db = new ModelVentas();
        public List<Abono> GetAbonos()
        {
            return db.Abonos.ToList();
        }

        public List<Abono> Search(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio == null && fechaFin == null)
            {
                return db
                    .Abonos
                    .Where(x => x.fechaPago == DateTime.UtcNow).ToList();
            } else
            {
                return db
                    .Abonos
                    .Where(x => x.fechaPago >= fechaInicio && x.fechaPago <= fechaFin).ToList();
            }
            return db.Abonos.ToList();
        }

        public List<Abono> SearchByToday()
        {
            DateTime today = DateTime.Now.Date;
            DateTime tomorrow = today.AddDays(1);

            return db
                .Abonos
                .Where(x => x.fechaPago >= today && x.fechaPago < tomorrow)
                .ToList();
        }

        public Abono SearchById(int id)
        {
            return db
                    .Abonos
                    .Where(x => x.id == id).First();
        }

        public List<Abono> SearchBySeparadoId(int separadoId)
        {
            return db.Abonos
                     .Where(x => x.separado.id == separadoId)
                     .ToList();
        }

        public bool Create(Abono abonos)
        {
            Abono ventaGuardar = db.Abonos.Add(abonos);
            return db.SaveChanges() > 0;
        }
        public bool CreateList(List<Abono> listaAbonos)
        {
            try
            {
                // Añade la lista completa de abonos al contexto
                db.Abonos.AddRange(listaAbonos);

                // Guarda todos los cambios en la base de datos y verifica si se guardaron al menos un cambio
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante el proceso de guardado
                Console.WriteLine("Error al crear los abonos: " + ex.Message);
                return false;
            }
        }
        public bool Delete(Abono abono)
        {
            db.Abonos.Remove(abono);
            return db.SaveChanges() > 0;
        }
    }
}
