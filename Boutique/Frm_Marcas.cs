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
    public partial class Frm_Marcas : Form
    {
        Brands brands = new Brands();

        public void MostrarDatos()
        {
            DataSet ds = brands.SelectBrands();
            dgv_marcas.DataSource = ds.Tables[0];

            txt_code.Text = brands.CountBrnds();
        }
        public Frm_Marcas()
        {
            InitializeComponent();
        }

        private void Frm_Marcas_Load(object sender, EventArgs e)
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


            if (brands.InsertBrands(code, name, fecha) == "Correcto")
            {
                MessageBox.Show("Marca Registrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                txt_name.Text = "";
            }
            else
            {
                MessageBox.Show(brands.InsertBrands(code, name, fecha), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            var code = Convert.ToInt32(txt_code.Text.Trim());
            var name = txt_name.Text.Trim();
            var fecha = dtp_fecha.Text;


            if (brands.UpdateBrands(code, name, fecha) == "Actualizado")
            {
                MessageBox.Show("Marca Actualizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                txt_name.Text = "";
            }
            else
            {
                MessageBox.Show(brands.UpdateBrands(code, name, fecha), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_marcas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txt_code.Text = row.Cells[0].Value.ToString();
            txt_name.Text = row.Cells[1].Value.ToString();
            dtp_fecha.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txt_code.Text.Trim());
            var name = txt_name.Text.Trim();
            var fecha = dtp_fecha.Text;


            if (brands.deleteMarcas(code) == "Borrado")
            {
                MessageBox.Show("Marca Borrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                txt_name.Text = "";
            }
            else
            {
                MessageBox.Show(brands.deleteMarcas(code), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
