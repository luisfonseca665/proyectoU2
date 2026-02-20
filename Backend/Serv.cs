using MySql.Data.MySqlClient;
using ProyectoFinal.Backend;
using System;
using System.Data;

namespace proyectoU2.Backend
{
    public class ServiciosController
    {

        /// <summary>
        /// Recibe la clave del servicio y devuelve un objeto Servicios con toda la información de ese servicio. Si no se encuentra, devuelve null.
        /// </summary>
        /// <param name="clave"></param>
        /// <returns></returns>
        public static Servicios ObtenerPorClave(int clave)
        {
            Servicios s = null;
            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM Servicios WHERE clave_servicio = @clave";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@clave", clave);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                s = new Servicios();
                                s.clave_servicio = Convert.ToInt32(reader["clave_servicio"]);
                                s.nombre_servicio = reader["nombre_servicio"].ToString();
                                s.descripcion = reader["descripcion"].ToString();
                                s.costo_base = Convert.ToDecimal(reader["costo_base"]);
                                s.tiempo_estimado = Convert.ToInt32(reader["tiempo_estimado"]);
                            }
                        }
                    }
                }
            }
            catch (Exception) { return null; }
            return s;
        }

        /// <summary>
        /// Nos ayuda a obtener una lista de todos los servicios activos en la base de datos. Solo devuelve los servicios que tienen el campo "activo" en 1, lo que indica que están disponibles para su uso. Esto es útil para mostrar solo los servicios que se pueden ofrecer a los clientes, evitando mostrar aquellos que han sido eliminados o desactivados.
        /// </summary>
        /// <returns></returns>
        public static DataTable ObtenerServicios()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    // Agregamos WHERE activo = 1
                    string query = "SELECT clave_servicio, nombre_servicio, descripcion, costo_base, tiempo_estimado FROM Servicios WHERE activo = 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
            return dt;
        }

        /// <summary>
        /// Metodo para eliminar un servicio. En lugar de eliminar físicamente el registro de la base de datos, este método actualiza el campo "activo" a 0, lo que indica que el servicio ya no está disponible para su uso. Esto permite mantener un historial de los servicios eliminados y evita problemas de integridad referencial si otros registros dependen de este servicio.
        /// </summary>
        /// <param name="clave"></param>
        /// <returns></returns>
        public static bool EliminarServicio(int clave)
        {
            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    // Cambiamos DELETE por UPDATE
                    string query = "UPDATE Servicios SET activo = 0 WHERE clave_servicio = @clave";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@clave", clave);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception) { return false; }
        }

        /// <summary>
        /// Metodo que nos proporciona la funcionalidad de agregar un nuevo servicio a la base de datos. Recibe como parámetros el nombre del servicio, su descripción, el costo base y el tiempo estimado para realizarlo. Luego, inserta un nuevo registro en la tabla "Servicios" con esta información, estableciendo el campo "activo" en 1 para indicar que el servicio está disponible. Si la operación se realiza correctamente, devuelve true; de lo contrario, devuelve false.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="costo"></param>
        /// <param name="tiempo"></param>
        /// <returns></returns>
        public static bool AgregarServicio(string nombre, string descripcion, decimal costo, int tiempo)
        {
            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Servicios (nombre_servicio, descripcion, costo_base, tiempo_estimado) " +
                                   "VALUES (@nom, @desc, @costo, @tiempo)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nombre);
                        cmd.Parameters.AddWithValue("@desc", descripcion);
                        cmd.Parameters.AddWithValue("@costo", costo);
                        cmd.Parameters.AddWithValue("@tiempo", tiempo);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception) { return false; }
        }

        /// <summary>
        /// Metodo para editar un servicio existente en la base de datos. Recibe como parámetros la clave del servicio que se desea modificar, junto con el nuevo nombre, descripción, costo base y tiempo estimado. Luego, actualiza el registro correspondiente en la tabla "Servicios" con esta nueva información. Si la operación se realiza correctamente, devuelve true; de lo contrario, devuelve false.
        /// </summary>
        /// <param name="clave"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="costo"></param>
        /// <param name="tiempo"></param>
        /// <returns></returns>
        public static bool EditarServicio(int clave, string nombre, string descripcion, decimal costo, int tiempo)
        {
            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "UPDATE Servicios SET nombre_servicio=@nom, descripcion=@desc, costo_base=@costo, tiempo_estimado=@tiempo " +
                                   "WHERE clave_servicio=@clave";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nombre);
                        cmd.Parameters.AddWithValue("@desc", descripcion);
                        cmd.Parameters.AddWithValue("@costo", costo);
                        cmd.Parameters.AddWithValue("@tiempo", tiempo);
                        cmd.Parameters.AddWithValue("@clave", clave);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception) { return false; }
        }

        
    }
}