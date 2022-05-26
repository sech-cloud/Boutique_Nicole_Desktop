using Boutique.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique
{
    public partial class Frm_signin : Form
    {
        Frm_signup Registrar = new Frm_signup();
        SqlConnection con = new SqlConnection(conexion.CN());
        Roles Rol = new Roles();
        Usuario usuario = new Usuario();
        Frm_Dashboard Dashboard = new Frm_Dashboard();
        public Frm_signin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            var username = txt_Usuario.Text.Trim();
            var contraseña = txt_Contraseña.Text.Trim();

            if (username == "") {
                MessageBox.Show("Campo Vacio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Focus();
            }
            else if (contraseña == "") {
                MessageBox.Show("Campo Vacio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseña.Focus();
            }
            else{
                string Respuesta = usuario.Accesar(username, contraseña);
                if (Respuesta == "Bienvenido")
                {
                    MessageBox.Show("Bienvenido: " + username, "Informacion", MessageBoxButtons.OK);

                    txt_Usuario.Text = "";
                    txt_Contraseña.Text = "";

                    Dashboard.Show();

                }
                else
                {
                    MessageBox.Show(Respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            var username = txt_Usuario.Text.Trim();
            var contraseña = txt_Contraseña.Text.Trim();

            if (username == "")
            {
                MessageBox.Show("Campo Usuario Vacio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Focus();
            }
            else if (contraseña == "")
            {
                MessageBox.Show("Campo Contraseña Vacio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseña.Focus();
            }
            else
            {
                
                if (username == "admin" && contraseña == "admin")
                {
                    MessageBox.Show("Bienvenido: " + username, "Informacion", MessageBoxButtons.OK);

                    txt_Usuario.Text = "";
                    txt_Contraseña.Text = "";

                    Registrar.Show();

                }
                else
                {
                    MessageBox.Show("Solo un administrador puede resgistrar un usuario", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Usuario.Text = "";
                    txt_Contraseña.Text = "";

                }
            }
        }
    }
}
