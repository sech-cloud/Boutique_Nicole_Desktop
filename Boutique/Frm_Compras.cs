using Boutique.Logica;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique
{
    public partial class Frm_Compras : Form
    {

        SqlConnection cnn = new SqlConnection(conexion.CN());
        Facturacion ftc = new Facturacion();
        Compra Cmp = new Compra();
        int dtc;
        public Frm_Compras()
        {
            InitializeComponent();
        }

        public void limpiarCampos()
        {
            txtPCmp.Text = "";
        }

        public void ClearData()
        {
            dgvStockUpdate.Columns.Clear();
            dgvStockUpdate.Columns.Add("ID", "Id");
            dgvStockUpdate.Columns.Add("Codigo", "Codigo");
            dgvStockUpdate.Columns.Add("Descripcion", "Descripcion");
            dgvStockUpdate.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvStockUpdate.Columns.Add("Costo", "Costo de Compra");
            dgvStockUpdate.Columns.Add("Cantidad", "Cantidad");
        }
        public void dats()
        {
            ClearData();
            dtc = Convert.ToInt32(Cmp.CountDetailsPurchase()) + 1;

            txtNumFact.Text = Cmp.CountPurchase();
            ftc.ObtenerEntidad(CbEntities);
            ftc.ObtenerDocumentos(CbDocument);
            ftc.ObtenerStatus(CbStatus);
            ftc.ObtenerProduct(CbProds);

            dgvStockUpdate.ClearSelection();
            dgvStockUpdate.CurrentCell = null;

            BtnImprimir.Enabled = false;
            btnagregar.Enabled = false;

            txtprecio.Enabled = false;
            txtPCmp.Enabled = false;
            txtcantidad.Enabled = false;

        }
        private void Frm_Compras_Load(object sender, EventArgs e)
        {
            dats();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CbProds_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from products where id = '" + CbProds.SelectedValue + "'";
            SqlCommand cn = new SqlCommand(query, cnn);
            cnn.Open();
            SqlDataReader stock = cn.ExecuteReader();

            if (stock.Read() == true)
            {
                txtprecio.Text = stock["price"].ToString();
                txtPCmp.Text = stock["cost"].ToString();
                txtcantidad.Text = stock["quantityAvailable"].ToString();
                txtUnitario.Text = txtprecio.Text;
                txtPcompra.Text = txtPCmp.Text;
            }
            else
            {
                txtprecio.Text = "";
            }
            cnn.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int indice_fila = dgvStockUpdate.Rows.Add();
            DataGridViewRow row = dgvStockUpdate.Rows[indice_fila];

            row.Cells["ID"].Value = dtc + indice_fila;
            row.Cells["Codigo"].Value = CbProds.SelectedValue;
            row.Cells["Cantidad"].Value = int.Parse(txtcantidad.Text) + int.Parse(txtNCantidad.Text);
            row.Cells["Descripcion"].Value = CbProds.Text;
            row.Cells["PrecioUnitario"].Value = txtUnitario.Text;
            row.Cells["Costo"].Value = txtPcompra.Text;

            limpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txtNumFact.Text.Trim());
            var customer = Convert.ToInt32(CbEntities.SelectedValue);
            var fecha = Convert.ToString(DateTime.Now);
            var document = Convert.ToInt32(CbDocument.SelectedValue);
            var status = Convert.ToInt32(CbStatus.SelectedValue);


            if (Cmp.InsertPurchase(code, customer, fecha, document, status) == "Correcto")
            {
                MessageBox.Show("Factura Registrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BtnImprimir.Enabled = true;
                btnagregar.Enabled = true;
            }
            else
            {
                MessageBox.Show(ftc.InsertInvoice(code, customer, fecha, document, status), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                GenerarReport(CbEntities.Text, txtNumFact.Text);
                foreach (DataGridViewRow GVRow in dgvStockUpdate.Rows)
                {
                    var code = Convert.ToInt32(txtNumFact.Text.Trim());
                    int ID = Convert.ToInt32(GVRow.Cells[0].Value);
                    int Cod_Prod = Convert.ToInt32(GVRow.Cells[1].Value);
                    string Descripcion = Convert.ToString(GVRow.Cells[2].Value);
                    double Precio = Convert.ToDouble(GVRow.Cells[3].Value);
                    double Costo = Convert.ToDouble(GVRow.Cells[4].Value);
                    int Cantidad = Convert.ToInt32(GVRow.Cells[5].Value);

                    Cmp.InsertDetailsP(ID, Descripcion, Cantidad, Costo, Precio, code, Cod_Prod);
                    Cmp.UpdateProducts(Cod_Prod, Precio, Costo, Cantidad);

                }

                MessageBox.Show("Stock Actualizado",
                    "Informacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                ClearData();
                dats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar: " + ex.Message.ToString(), 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Stop);
            }
           
        }

        public void GenerarReport(string Nombre, string NumDoc)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyy"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", Nombre);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", NumDoc);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvStockUpdate.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Costo"].Value.ToString() + "</td>";
                filas += "</tr>";
                //total += decimal.Parse(row.Cells["Costo"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    //limpiarCampos();
                    //ClearData();
                }

            }
        }
    }
}
