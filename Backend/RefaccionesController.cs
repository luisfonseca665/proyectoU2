using MySql.Data.MySqlClient;
using ProyectoFinal.Backend;
using System;
using System.Data;

namespace proyectoU2.Backend
{
    public class RefaccionesController
    {
        /// <summary>
        /// Metodo para obtener una refacción por su código, utilizado para cargar los datos en el formulario de edición.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static Refacciones ObtenerPorCodigo(string codigo)
        {
            Refacciones r = null;
            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM Refacciones WHERE codigo_refaccion = @cod";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cod", codigo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                r = new Refacciones();
                                r.codigo_refaccion = reader["codigo_refaccion"].ToString();
                                r.nombre = reader["nombre"].ToString();
                                r.marca = reader["marca"].ToString();
                                r.precio_unitario = Convert.ToDecimal(reader["precio_unitario"]);
                                r.stock_actual = Convert.ToInt32(reader["stock_actual"]);
                                r.stock_minimo = Convert.ToInt32(reader["stock_minimo"]);
                                r.proveedor = reader["proveedor"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception) { return null; }
            return r;
        }

        /// <summary>
        /// Metodo para obtener todas las refacciones activas, utilizado para cargar el DataGridView en el formulario principal.
        /// </summary>
        /// <returns></returns>
        public static DataTable ObtenerRefacciones()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    // Agregamos WHERE activo = 1
                    string query = "SELECT codigo_refaccion, nombre, marca, precio_unitario, stock_actual, stock_minimo, proveedor FROM Refacciones WHERE activo = 1";
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
        /// Metodo para eliminar una refacción, en realidad solo la marca como inactiva (activo = 0) para mantener el historial de datos.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static bool EliminarRefaccion(string codigo)
        {
            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "UPDATE Refacciones SET activo = 0 WHERE codigo_refaccion = @cod";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cod", codigo);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception) { return false; }
        }

        /// <summary>
        /// Metodo para agregar una nueva refacción a la base de datos, con el campo activo = 1 por defecto para indicar que está disponible.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="stockMinimo"></param>
        /// <param name="proveedor"></param>
        /// <returns></returns>
        public static bool AgregarRefaccion(string codigo, string nombre, string marca, decimal precio, int stock, int stockMinimo, string proveedor)
        {
            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Refacciones (codigo_refaccion, nombre, marca, precio_unitario, stock_actual, stock_minimo, proveedor) " +
                                   "VALUES (@cod, @nom, @mar, @pre, @stk, @min, @prov)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cod", codigo);
                        cmd.Parameters.AddWithValue("@nom", nombre);
                        cmd.Parameters.AddWithValue("@mar", marca);
                        cmd.Parameters.AddWithValue("@pre", precio);
                        cmd.Parameters.AddWithValue("@stk", stock);
                        cmd.Parameters.AddWithValue("@min", stockMinimo);
                        cmd.Parameters.AddWithValue("@prov", proveedor);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception) { return false; }
        }

        /// <summary>
        /// Metodo para editar una refacción existente, se identifica por el código original (que no se puede cambiar) y se actualizan los demás campos. El campo activo no se modifica para mantener el estado de la refacción.
        /// </summary>
        /// <param name="codigoOriginal"></param>
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="stockMinimo"></param>
        /// <param name="proveedor"></param>
        /// <returns></returns>
        public static bool EditarRefaccion(string codigoOriginal, string nombre, string marca, decimal precio, int stock, int stockMinimo, string proveedor)
        {
            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "UPDATE Refacciones SET nombre=@nom, marca=@mar, precio_unitario=@pre, stock_actual=@stk, stock_minimo=@min, proveedor=@prov " +
                                   "WHERE codigo_refaccion=@cod";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nombre);
                        cmd.Parameters.AddWithValue("@mar", marca);
                        cmd.Parameters.AddWithValue("@pre", precio);
                        cmd.Parameters.AddWithValue("@stk", stock);
                        cmd.Parameters.AddWithValue("@min", stockMinimo);
                        cmd.Parameters.AddWithValue("@prov", proveedor);
                        cmd.Parameters.AddWithValue("@cod", codigoOriginal);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception) { return false; }
        }

       
    }

}