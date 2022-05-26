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
    public partial class Frm_Categories : Form
    {
        Categories categoria = new Categories();

        public void MostrarDatos()
        {
            DataSet ds = categoria.SelectCategories();
            dgv_categorias.DataSource = ds.Tables[0];

            txt_code.Text = categoria.CountCategories();
        }
        public Frm_Categories()
        {
            InitializeComponent();
        }

        private void Frm_Categories_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txt_code.Text.Trim());
            var name = txt_name.Text.Trim();
            var fecha = dtp_fecha.Text;


            if (categoria.InsertCategories(code, name, fecha) == "Correcto")
            {
                MessageBox.Show("Categoria Ingresada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                txt_name.Text = "";
            }
            else
            {
                MessageBox.Show(categoria.InsertCategories(code, name, fecha), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            var code = Convert.ToInt32(txt_code.Text.Trim());
            var name = txt_name.Text.Trim();
            var fecha = dtp_fecha.Text;


            if (categoria.UpdateCategories(code, name, fecha) == "Actualizado")
            {
                MessageBox.Show("Categoria Actualizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                txt_name.Text = "";
            }
            else
            {
                MessageBox.Show(categoria.UpdateCategories(code, name, fecha), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgv_categorias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txt_code.Text = row.Cells[0].Value.ToString();
            txt_name.Text = row.Cells[1].Value.ToString();
            dtp_fecha.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txt_code.Text.Trim());
         
            if (categoria.deleteCategories(code) == "Borrado")
            {
                MessageBox.Show("Categoria Borrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                txt_name.Text = "";
            }
            else
            {
                MessageBox.Show(categoria.deleteCategories(code), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
