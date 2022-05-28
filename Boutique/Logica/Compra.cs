using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.Logica
{
    class Compra
    {
        SqlConnection cnx = new SqlConnection(conexion.CN());
        public string CountPurchase()
        {
            string Conteo = "ContarCompras";
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand(Conteo, cnx);
                SqlDataReader registro = cmd.ExecuteReader();
                registro.Read();

                return registro["codigo"].ToString();
            }
            catch (Exception ex)
            {
                return "Error al extraer numero de registro: " + ex;
            }
            finally
            {
                cnx.Close();
            }
        }

        public string CountDetailsPurchase()
        {
            string Conteo = "ContarDetallesCompra";
            try
            {
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

        public String InsertPurchase(int id, int provider_id, string date, int document_type, int status)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GuardarCompra";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
                cmd.Parameters.Add("@provider_id", SqlDbType.Int).Value = provider_id;
                cmd.Parameters.Add("@document_type_id", SqlDbType.Int).Value = document_type;
                cmd.Parameters.Add("@status_id", SqlDbType.Int).Value = status;
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

        public String InsertDetailsP(int id, string description, int quantity, double price, double unitPrice, int purchase_id, int product_id)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DetallesCompra";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                cmd.Parameters.Add("@unitCost", SqlDbType.Float).Value = unitPrice;
                cmd.Parameters.Add("@cost", SqlDbType.Float).Value = price;
                cmd.Parameters.Add("@purchase_id", SqlDbType.Int).Value = purchase_id;
                cmd.Parameters.Add("@product_id", SqlDbType.Int).Value = product_id;
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
           double price,
           double costo,
           int stock)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizarStock";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = price;
                cmd.Parameters.Add("@cost", SqlDbType.Float).Value = costo;
                cmd.Parameters.Add("@quantityAvailable", SqlDbType.Int).Value = stock;
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
    }
}
