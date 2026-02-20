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
    internal class LineaController
    {
        public static void CrearLinea()
        {
            Linea linea = new Linea();
            Console.WriteLine("Ingrese el nombre de la linea");
            linea.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la descripcion de la linea");
            linea.descripcion = Console.ReadLine();
            using (var db = new ModelVentas())
            {
                db.Lineas.Add(linea);
                db.SaveChanges();
            }
        }

        public static void ListarLineas()
        {
            using (var db = new ModelVentas())
            {
                var lineas = db.Lineas.ToList();
                foreach (var linea in lineas)
                {
                    Console.WriteLine(linea.nombre);
                }
            }
        }

        public static void EditarLinea()
        {
            Console.WriteLine("Ingrese el id de la linea a editar");
            int id = int.Parse(Console.ReadLine());
            using (var db = new ModelVentas())
            {
                var linea = db.Lineas.Find(id);
                if (linea != null)
                {
                    Console.WriteLine("Ingrese el nombre de la linea");
                    linea.nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la descripcion de la linea");
                    linea.descripcion = Console.ReadLine();
                    db.Entry(linea).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Linea no encontrada");
                }
            }
        }

        public static void EliminarLinea()
        {
            Console.WriteLine("Ingrese el id de la linea a eliminar");
            int id = int.Parse(Console.ReadLine());
            using (var db = new ModelVentas())
            {
                var linea = db.Lineas.Find(id);
                if (linea != null)
                {
                    db.Lineas.Remove(linea);
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Linea no encontrada");
                }
            }
        }

        public static void AsociarArticulo()
        {
            Console.WriteLine("Ingrese el id de la linea");
            int id = int.Parse(Console.ReadLine());
            using (var db = new ModelVentas())
            {
                var linea = db.Lineas.Find(id);
                if (linea != null)
                {
                    Console.WriteLine("Ingrese el id del articulo");
                    int idArticulo = int.Parse(Console.ReadLine());
                    var articulo = db.Articulos.Find(idArticulo);
                    if (articulo != null)
                    { }
                }
            }
        }
    }   
}
