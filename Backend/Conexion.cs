using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Backend
{

    /// <summary>
    /// Nos da la conexion a la base de datos
    /// </summary>
    public class Conexion
    {
        private static string cadena = "server=4.242.22.77;database=Mecanica;user=luiyi;password=abcde; Allow User Variables=True;";
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}