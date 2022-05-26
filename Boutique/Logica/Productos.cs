using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.Logica
{
    class Productos
    {
        SqlConnection cnx = new SqlConnection(conexion.CN());

        public string CountProducts()
        {
            try
            {
                string Conteo = "ContarProductos";
                cnx.Open();
                SqlCommand cmd = new SqlCommand(Conteo, cnx);
                SqlDataReader registro = cmd.ExecuteReader();
                registro.Read();

                return registro["codigo"].ToString();
            }
            catch (Exception ex)
            {
                return "Error al Extraer numero de registro: " + ex;
            }
            finally
            {
                cnx.Close();
            }

        }
        public DataSet SelectProducts()
        {

            SqlDataAdapter Productos = new SqlDataAdapter("ObtenerProductos", cnx);
            DataSet ds = new DataSet();
            Productos.Fill(ds);

            return ds;
        }

        public String InsertProducts(int id, 
            string name, 
            double price, 
            double costo, 
            int cantidad, 
            int stock, 
            int categoria, 
            int marca)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GuardarProductos";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = price;
                cmd.Parameters.Add("@cost", SqlDbType.Float).Value = costo;
                cmd.Parameters.Add("@initialQuantity", SqlDbType.Int).Value = cantidad;
                cmd.Parameters.Add("@quantityAvailable", SqlDbType.Int).Value = stock;
                cmd.Parameters.Add("@category_id", SqlDbType.Int).Value = categoria;
                cmd.Parameters.Add("@brand_id", SqlDbType.Int).Value = marca;
                cnx.Open();
                cmd.Connection = cnx;
                cmd.ExecuteNonQuery();

                ds = "Correcto";
                return ds;

            }
            catch (Exception ex)
            {
                ds = "Error al ingresar: " + ex.Message.ToString();
                return ds;
            }
            finally
            {
                cnx.Close();
            }

        }

        public String UpdateProducts(int id, 
            string name, 
            double price,
            double costo,
            int cantidad,
            int stock,
            int categoria,
            int marca)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizarProductos";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = price;
                cmd.Parameters.Add("@cost", SqlDbType.Float).Value = costo;
                cmd.Parameters.Add("@initialQuantity", SqlDbType.Int).Value = cantidad;
                cmd.Parameters.Add("@quantityAvailable", SqlDbType.Int).Value = stock;
                cmd.Parameters.Add("@category_id", SqlDbType.Int).Value = categoria;
                cmd.Parameters.Add("@brand_id", SqlDbType.Int).Value = marca;
                cnx.Open();
                cmd.Connection = cnx;
                cmd.ExecuteNonQuery();

                ds = "Actualizado";
                return ds;

            }
            catch (Exception ex)
            {
                ds = "Error al Actualizar: " + ex.Message.ToString();
                return ds;
            }
            finally
            {
                cnx.Close();
            }
        }

        public string deleteProducts(int id)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarProductos";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cnx.Open();
                cmd.Connection = cnx;
                cmd.ExecuteNonQuery();

                ds = "Borrado";
                return ds;


            }
            catch (Exception ex)
            {
                ds = "Error al Borrar: " + ex.Message.ToString();
                return ds;
            }
            finally
            {
                cnx.Close();
            }
        }

    }
}
