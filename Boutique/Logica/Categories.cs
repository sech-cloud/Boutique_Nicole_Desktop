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
    class Categories
    {
        SqlConnection cnx = new SqlConnection(conexion.CN());

        public string CountCategories()
        {
            try
            {
                string Conteo = "ContarCategorias";
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
        public DataSet SelectCategories()
        {

            SqlDataAdapter Categories = new SqlDataAdapter("ObtenerCategorias", cnx);
            DataSet ds = new DataSet();
            Categories.Fill(ds);

            return ds;
        }

        public String InsertCategories(int id, string name, string created_at)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GuardarCategoria";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@fecha_creacion", SqlDbType.Date).Value = created_at;
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

        public String UpdateCategories(int id, string name, string created_at)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizarCategoria";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@fecha_creacion", SqlDbType.Date).Value = created_at;
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

        public string deleteCategories(int id)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarCategoria";
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

        public void ObtenerCategorias(ComboBox Category)
        {
            string Obtener = "ObtenerCategorias";

            cnx.Open();
            SqlCommand cmd = new SqlCommand(Obtener, cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            Category.ValueMember = "Codigo";
            Category.DisplayMember = "Nombre";

            Category.DataSource = dt;
            cnx.Close();
        }
    }
}
