using Boutique.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique
{
    public partial class Frm_Usuarios : Form
    {
        Roles Rol = new Roles();
        Usuario usuario = new Usuario();
        public void MostrarDatos()
        {
            DataSet ds = usuario.SelectUsers();
            dgv_Users.DataSource = ds.Tables[0];

            txt_code.Text = usuario.CountUsers();
            Rol.ObtenerRoles(Cb_Rol);
        }

        public void LimpiarCampos()
        {
            txt_name.Text = "";
            txt_lastname.Text = "";
            txt_mail.Text = "";
            txt_dui.Text = "";
            txt_nit.Text = "";
            txt_user.Text = "";
            txt_pass.Text = "";
        }
        public Frm_Usuarios()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btn_Save_Click(object sender, EventArgs e)
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
                MessageBox.Show("Usuario Registrado", "Informacion", MessageBoxButtons.OK);
                MostrarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(usuario.InsertUsers(code, name, lastname, dui, nit, userName, password, email, Convert.ToInt32(rol_id)), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btn_update_Click(object sender, EventArgs e)
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

            if (usuario.UpdateUsers(code, name, lastname, dui, nit, userName, password, email, Convert.ToInt32(rol_id)) == "Actualizado")
            {
                MessageBox.Show("Usuario Actualizado", "Informacion", MessageBoxButtons.OK);
                MostrarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(usuario.UpdateUsers(code, name, lastname, dui, nit, userName, password, email, Convert.ToInt32(rol_id)), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txt_code.Text.Trim());

            if (usuario.deleteUsers(code) == "Borrado")
            {
                MessageBox.Show("Usuario Borrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                txt_name.Text = "";
            }
            else
            {
                MessageBox.Show(usuario.deleteUsers(code), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Users_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txt_code.Text = row.Cells[0].Value.ToString();
            txt_name.Text = row.Cells[1].Value.ToString();
            txt_lastname.Text = row.Cells[2].Value.ToString();
            txt_dui.Text = row.Cells[3].Value.ToString();
            txt_nit.Text = row.Cells[4].Value.ToString();
            txt_mail.Text = row.Cells[5].Value.ToString();
            txt_user.Text = row.Cells[6].Value.ToString();
            txt_pass.Text = row.Cells[7].Value.ToString();
            Cb_Rol.Text = row.Cells[8].Value.ToString();
        }
    }
}
