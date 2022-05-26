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
    public partial class Frm_Productos : Form
    {
        Productos products = new Productos();
        Categories categorias = new Categories();
        Brands Marcas = new Brands();
        ReporteProductos Rp = new ReporteProductos();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public Frm_Productos()
        {
            InitializeComponent();
        }
        public void MostrarDatos()
        {
            DataSet ds = products.SelectProducts();
            dgv_products.DataSource = ds.Tables[0];

            txt_code.Text = products.CountProducts();

            categorias.ObtenerCategorias(cb_Category);
            Marcas.ObtenerMarcas(cb_Brands);
        }
        public void LimpiarCampos() {
            txt_price.Text = "";
            txt_costo.Text = "";
            txt_Inicial.Text = "";
            txt_stock.Text = "";
        }
        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txt_code.Text.Trim());
            var name = txt_name.Text.Trim();
            var price = Convert.ToDouble(txt_price.Text.Trim());
            var cost = Convert.ToDouble(txt_costo.Text.Trim());
            var cantidad = Convert.ToInt32(txt_Inicial.Text.Trim());
            var stock = Convert.ToInt32(txt_stock.Text.Trim());
            var categoria = Convert.ToInt32(cb_Category.SelectedValue);
            var marca = Convert.ToInt32(cb_Brands.SelectedValue);
            
            if (products.InsertProducts(code, name, price, cost, cantidad, stock, categoria, marca) == "Correcto")
            {
                MessageBox.Show("Producto Registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(products.InsertProducts(code, name, price, cost, cantidad, stock, categoria, marca), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txt_code.Text.Trim());
            var name = txt_name.Text.Trim();
            var price = Convert.ToDouble(txt_price.Text.Trim());
            var cost = Convert.ToDouble(txt_costo.Text.Trim());
            var cantidad = Convert.ToInt32(txt_Inicial.Text.Trim());
            var stock = Convert.ToInt32(txt_stock.Text.Trim());
            var categoria = Convert.ToInt32(cb_Category.SelectedValue);
            var marca = Convert.ToInt32(cb_Brands.SelectedValue);


            if (products.UpdateProducts(code, name, price, cost, cantidad, stock, categoria, marca) == "Actualizado")
            {
                MessageBox.Show("Producto Actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(products.InsertProducts(code, name, price, cost, cantidad, stock, categoria, marca), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txt_code.Text.Trim());

            if (products.deleteProducts(code) == "Borrado")
            {
                MessageBox.Show("Producto Borrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MostrarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(products.deleteProducts(code), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_products_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txt_code.Text = row.Cells[0].Value.ToString();
            txt_name.Text = row.Cells[1].Value.ToString();
            txt_price.Text = row.Cells[2].Value.ToString();
            txt_costo.Text = row.Cells[3].Value.ToString();
            txt_Inicial.Text = row.Cells[4].Value.ToString();
            txt_stock.Text = row.Cells[5].Value.ToString();
            cb_Category.Text = row.Cells[6].Value.ToString();
            cb_Brands.Text = row.Cells[7].Value.ToString();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Rp.Show();
        }
    }
}
