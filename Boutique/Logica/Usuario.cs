using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.Logica
{
    class Usuario
    {
        SqlConnection cnx = new SqlConnection(conexion.CN());

        public string CountUsers()
        {
            string Conteo = "ContarUsuarios";
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
                return "Error: " + ex;
            }
            finally
            {
                cnx.Close();
            }
        }

        public DataSet SelectUsers() {
        
        SqlDataAdapter Usuario = new SqlDataAdapter("ObtenerUsuarios", cnx);
        DataSet ds = new DataSet();
        Usuario.Fill(ds);

            return ds;
        }

        public String InsertUsers(int id, string name, string lastname, string dui, string nit, string userName, string password, string email, int rol_id)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RegistrarUsuario";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@names", SqlDbType.NChar).Value = name;
                cmd.Parameters.Add("@lastnames", SqlDbType.NChar).Value = lastname;
                cmd.Parameters.Add("@dui", SqlDbType.VarChar).Value = dui;
                cmd.Parameters.Add("@nit", SqlDbType.VarChar).Value = nit;
                cmd.Parameters.Add("@userName", SqlDbType.NChar).Value = userName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@rol_id", SqlDbType.Int).Value = rol_id;

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

        public string Accesar(string username, string password)
        {
            string Iniciar = "IniciarSesion";

            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand(Iniciar, cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return "Bienvenido";
                }
                else
                {
                    return "Usuario no existe";
                }

            }
            catch (Exception ex)
            {
                return "Error al entrar: " + ex;
            }
            finally { cnx.Close(); }
        }
        public String UpdateUsers(int id, string name, string lastname, string dui, string nit, string userName, string password, string email, int rol_id)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizarUsuarios";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@names", SqlDbType.NChar).Value = name;
                cmd.Parameters.Add("@lastnames", SqlDbType.NChar).Value = lastname;
                cmd.Parameters.Add("@dui", SqlDbType.VarChar).Value = dui;
                cmd.Parameters.Add("@nit", SqlDbType.VarChar).Value = nit;
                cmd.Parameters.Add("@userName", SqlDbType.NChar).Value = userName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@Permiso", SqlDbType.Int).Value = rol_id;

                cnx.Open();
                cmd.Connection = cnx;
                cmd.ExecuteNonQuery();

                ds = "Actualizado";
                return ds;


            }
            catch (Exception ex)
            {
                ds = "Error al actualizar: " + ex.Message.ToString();
                return ds;
            }
            finally
            {
                cnx.Close();
            }
        }

        public string deleteUsers(int id)
        {
            string ds;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarUsuarios";
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
