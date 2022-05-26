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
    class Entidades
    {
        SqlConnection cnx = new SqlConnection(conexion.CN());

        public void ObtenerTipo(ComboBox Tipo)
        {
            string Obtener = "ObtenerTipo";

            cnx.Open();
            SqlCommand cmd = new SqlCommand(Obtener, cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            Tipo.ValueMember = "Codigo";
            Tipo.DisplayMember = "Nombre";

            Tipo.DataSource = dt;
            cnx.Close();
        }

        public string CountEntity()
        {
            string Conteo = "ContarEntidades";
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

        public DataSet SelectEntity()
        {

            SqlDataAdapter Entidad = new SqlDataAdapter("ObtenerEntidades", cnx);
            DataSet ds = new DataSet();
            Entidad.Fill(ds);

            return ds;
        }

        public String InsertEntity(int id, string name, string tel, string email, int person_type)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GuardarEntidad";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nombre", SqlDbType.NChar).Value = name;
                cmd.Parameters.Add("@tel", SqlDbType.NChar).Value = tel;
                cmd.Parameters.Add("@email", SqlDbType.NChar).Value = email;
                cmd.Parameters.Add("@person_type_id", SqlDbType.Int).Value = person_type;
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

        public String UpdateEntity(int id, string name, string tel, string email, int person_type)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizarEntidad";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nombre", SqlDbType.NChar).Value = name;
                cmd.Parameters.Add("@tel", SqlDbType.NChar).Value = tel;
                cmd.Parameters.Add("@email", SqlDbType.NChar).Value = email;
                cmd.Parameters.Add("@person_type_id", SqlDbType.Int).Value = person_type;
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

        public string deleteEntity(int id)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarEntidad";
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
