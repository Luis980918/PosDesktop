using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosDesktop.proyect
{
    internal class Conexion
    {
        NpgsqlConnection conex = new NpgsqlConnection();

        static String servidor = "localhost";
        static String bd = "POS-DESKTOP";
        static String usuario = "postgres";
        static String clave = "5278";
        static String puerto = "5432";

        String conexion = "server=" + servidor + ";" + "port=" + 
            puerto + ";" + "user id=" + usuario + ";" + "password=" + 
            clave + ";" + "database=" + bd + ";";

        public NpgsqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = conexion;
                conex.Open();
            } catch (NpgsqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos de PostgreSQL, error: " + e.ToString());
            }
            return conex;
        }
    }
}
