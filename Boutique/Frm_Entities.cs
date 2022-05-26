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
    public partial class Frm_Entities : Form
    {
        Entidades Entidad = new Entidades();
        public void MostrarDatos()
        {
            DataSet ds = Entidad.SelectEntity();
            dgv_Entidades.DataSource = ds.Tables[0];

            txt_code.Text = Entidad.CountEntity();
            Entidad.ObtenerTipo(cb_tipo);
        }

        public void LimpiarCampos()
        {
            txt_nombre.Text = "";
            txt_mail.Text = "";
            txt_telefono.Text = "";
        }
        public Frm_Entities()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Entities_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txt_code.Text.Trim());
            var name = txt_nombre.Text.Trim();
            var tel = txt_telefono.Text.Trim();
            var email = txt_mail.Text.Trim();
            var person_type = Convert.ToInt32(cb_tipo.SelectedValue);


            if (Entidad.InsertEntity(code, name, tel, email, person_type) == "Correcto")
            {
                MessageBox.Show("Entidad Registrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(Entidad.InsertEntity(code, name, tel, email, person_type), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txt_code.Text.Trim());
            var name = txt_nombre.Text.Trim();
            var tel = txt_telefono.Text.Trim();
            var email = txt_mail.Text.Trim();
            var person_type = Convert.ToInt32(cb_tipo.SelectedValue);


            if (Entidad.UpdateEntity(code, name, tel, email, person_type) == "Actualizado")
            {
                MessageBox.Show("Entidad Actualizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(Entidad.UpdateEntity(code, name, tel, email, person_type), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txt_code.Text.Trim());

            if (Entidad.deleteEntity(code) == "Borrado")
            {
                MessageBox.Show("Entidad Borrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(Entidad.deleteEntity(code), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Entidades_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txt_code.Text = row.Cells[0].Value.ToString();
            txt_nombre.Text = row.Cells[1].Value.ToString();
            txt_telefono.Text = row.Cells[2].Value.ToString();
            txt_mail.Text = row.Cells[3].Value.ToString();
            cb_tipo.Text = row.Cells[4].Value.ToString();
        }
    }
}
