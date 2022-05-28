using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique.Logica
{
    class Facturacion
    {

        SqlConnection cnx = new SqlConnection(conexion.CN());

        public string CountInvoces()
        {
            string Conteo = "ContarFacturas";
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

        public string CountDetails()
        {
            string Conteo = "ContarDetallesFactura";
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


        public String InsertInvoice(int id, int customer_id, string date, int document_type, int status)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GuardarFactura";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
                cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer_id;
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
        public String InsertDetails(int id, string description, int quantity, double price, double unitPrice, int invoice_id, int product_id)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DetallesFactura";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = price;
                cmd.Parameters.Add("@unitPrice", SqlDbType.Float).Value = unitPrice;
                cmd.Parameters.Add("@invoice_id", SqlDbType.Int).Value = invoice_id;
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

        public void ObtenerDocumentos(ComboBox Documento)
        {
            string Obtener = "TipoDocumento";

            cnx.Open();
            SqlCommand cmd = new SqlCommand(Obtener, cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            Documento.ValueMember = "Codigo";
            Documento.DisplayMember = "Documento";

            Documento.DataSource = dt;
            cnx.Close();
        }

        public void ObtenerEntidad(ComboBox Entidad)
        {
            string Obtener = "Entidad";

            cnx.Open();
            SqlCommand cmd = new SqlCommand(Obtener, cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            Entidad.ValueMember = "Codigo";
            Entidad.DisplayMember = "Nombre";

            Entidad.DataSource = dt;
            cnx.Close();
        }

        public void ObtenerStatus(ComboBox Status)
        {
            string Obtener = "Estatus";

            cnx.Open();
            SqlCommand cmd = new SqlCommand(Obtener, cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            Status.ValueMember = "Codigo";
            Status.DisplayMember = "Nombre";

            Status.DataSource = dt;
            cnx.Close();
        }

        public void ObtenerProduct(ComboBox Prod)
        {
            string Obtener = "ObtenerProductos";

            cnx.Open();
            SqlCommand cmd = new SqlCommand(Obtener, cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            Prod.ValueMember = "Codigo";
            Prod.DisplayMember = "Nombre";

            Prod.DataSource = dt;
            cnx.Close();
        }

        public String UpdateQuantity(int id,
        
           int cantidad
           )
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "actualizarCantidad";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@canitdad", SqlDbType.Int).Value = cantidad;
         
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
