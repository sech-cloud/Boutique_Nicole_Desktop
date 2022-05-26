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
    public partial class Frm_Dashboard : Form
    {
        Frm_Marcas marcas = new Frm_Marcas();
        Frm_Categories Categoria = new Frm_Categories();
        Frm_Productos Productos = new Frm_Productos();
        Frm_Entities Entidad = new Frm_Entities();
        Frm_Usuarios Usuarios = new Frm_Usuarios();
        Frm_Pedidos Ventas = new Frm_Pedidos();
        Frm_Compras Compras = new Frm_Compras();
        Acerca_de About = new Acerca_de();
        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Pnl_GMarcas_MouseClick(object sender, MouseEventArgs e)
        {
            marcas.Show();
        }

        private void Pnl_Categorias_MouseClick(object sender, MouseEventArgs e)
        {
            Categoria.Show();
        }

        private void Pnl_Products_MouseClick(object sender, MouseEventArgs e)
        {
            Productos.Show();
        }

        private void Pnl_Entidades_MouseClick(object sender, MouseEventArgs e)
        {
            Entidad.Show();
        }

        private void Pnl_Users_MouseClick(object sender, MouseEventArgs e)
        {
            Usuarios.Show();
        }

        private void Pnl_Compra_MouseClick(object sender, MouseEventArgs e)
        {
            Compras.Show();
        }
        private void Pnl_Ventas_MouseClick(object sender, MouseEventArgs e)
        {
            Ventas.Show();
        }

        private void Pnl_AcercaDe_MouseClick(object sender, MouseEventArgs e)
        {
            About.Show();
        }
        private void Pnl_Salir_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

       
    }
}
