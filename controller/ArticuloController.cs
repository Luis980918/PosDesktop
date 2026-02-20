using PosDesktop.context;
using PosDesktop.model;
using PosDesktop.vistas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PosDesktop.controller
{
    internal class ArticuloController
    {
        ModelVentas db = new ModelVentas();
        public List<Articulo> GetArticulos()
        {
            return db.Articulos.ToList();
        }

        public List<Articulo> Search(string nombre, string codigo, string linea)
        {
            if (nombre == null && codigo == null && linea == null)
            {
                return db
                    .Articulos
                    .Where(x => x.nombre == nombre || x.codigo == codigo || x.linea.nombre == linea).ToList();
            }
            else
            {
                return db
                    .Articulos
                    .Where(x => x.nombre == nombre || x.codigo == codigo || x.linea.nombre == linea).ToList();
            }
            return db.Articulos.ToList();
        }

        public Articulo SearchById(int id)
        {
            return db
                    .Articulos
                    .Where(x => x.id == id).First();
        }

        public bool Create(Articulo articulo)
        {
            Articulo articuloGuardar = db.Articulos.Add(articulo);
            return db.SaveChanges() > 0;
        }

        public bool Update(Articulo articulo)
        {
            db.Entry(articulo).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            Articulo articulo = db.Articulos.Find(id);
            db.Articulos.Remove(articulo);
            return db.SaveChanges() > 0;
        }

        public List<Articulo> SearchByLinea(int idLinea)
        {
            return db
                .Articulos
                .Where(x => x.linea.id == idLinea)
                .ToList();
        }

        public List<Articulo> SearchByProveedor(int idProveedor)
        {
            return db
                .Articulos
                .Where(x => x.proveedor.id == idProveedor)
                .ToList();
        }

        public List<Articulo> SearchByLineaAndProveedor(int idLinea, int idProveedor)
        {
            return db
                .Articulos
                .Where(x => x.linea.id == idLinea && x.proveedor.id == idProveedor)
                .ToList();
        }

    }   
}
