using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique.Logica
{
    class Roles
    {
        SqlConnection cnx = new SqlConnection(conexion.CN());
       
        public void ObtenerRoles(ComboBox Rol) {
            string Obtener = "ObtenerRol";

            cnx.Open();
            SqlCommand cmd = new SqlCommand(Obtener, cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            Rol.ValueMember = "codigo";
            Rol.DisplayMember = "Rol";

            Rol.DataSource = dt;
            cnx.Close();
        }    
    }
}
