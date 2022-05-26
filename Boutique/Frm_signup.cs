using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boutique.Logica;

namespace Boutique
{
    public partial class Frm_signup : Form
    {
        Roles Rol = new Roles();
        Usuario usuario = new Usuario();
        public void MostrarDatos()
        {
           txt_code.Text = usuario.CountUsers();
            Rol.ObtenerRoles(Cb_Rol);
        }
        private void signup_Load(object sender, EventArgs e)
        {
            MostrarDatos();
    }
        public Frm_signup()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txt_code.Text.Trim());
            var name = txt_name.Text.Trim();
            var lastname = txt_lastname.Text.Trim();
            var dui = txt_dui.Text.Trim();
            var nit = txt_nit.Text.Trim();
            var userName = txt_user.Text.Trim();
            var password = txt_pass.Text.Trim();
            var email = txt_mail.Text.Trim();
            var rol_id = Cb_Rol.SelectedValue;

            if (usuario.InsertUsers(code, name, lastname, dui, nit, userName, password, email, Convert.ToInt32(rol_id)) == "Correcto")
             {
                 MessageBox.Show("Ingresado Correctamente", "Informacion", MessageBoxButtons.OK);
                 MostrarDatos();
                 txt_name.Text = "";
             }
             else
             {
                 MessageBox.Show(usuario.InsertUsers(code, name, lastname, dui, nit, userName, password, email, Convert.ToInt32(rol_id)), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
