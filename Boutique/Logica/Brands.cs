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
    class Brands
    {
        SqlConnection cnx = new SqlConnection(conexion.CN());

        public string CountBrnds()
        {
            string Conteo = "ContarMarcas";
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
        public DataSet SelectBrands()
        {

            SqlDataAdapter Brands = new SqlDataAdapter("ObtenerMarcas", cnx);
            DataSet ds = new DataSet();
            Brands.Fill(ds);

            return ds;
        }

        public String InsertBrands(int id, string name, string created_at)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GuardarMarcas";
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

        public String UpdateBrands(int id, string name, string created_at)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizarMarcas";
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

        public string deleteMarcas(int id)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarMarcas";
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

        public void ObtenerMarcas(ComboBox Brand)
        {
            string Obtener = "ObtenerMarcas";

            cnx.Open();
            SqlCommand cmd = new SqlCommand(Obtener, cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            Brand.ValueMember = "Codigo";
            Brand.DisplayMember = "Nombre";

            Brand.DataSource = dt;
            cnx.Close();
        }
    }
}
