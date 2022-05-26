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
    public partial class Frm_Pedidos : Form
    {
        SqlConnection cnn = new SqlConnection(conexion.CN());
        Facturacion ftc = new Facturacion();
        int dtf;

        public Frm_Pedidos()
        {
            InitializeComponent();
        }

        public void limpiarCampos()
        {            
            txtcantidad.Text = "";
        }

        public void ClearData() {
            dgvproducto.Columns.Clear();
            dgvproducto.Columns.Add("ID", "Id");
            dgvproducto.Columns.Add("Codigo", "Codigo");
            dgvproducto.Columns.Add("Cantidad", "Cantidad");
            dgvproducto.Columns.Add("Descripcion", "Descripcion");
            dgvproducto.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvproducto.Columns.Add("Importe", "Importe");            
        }

        public void dats() {
            ClearData();
            dtf = Convert.ToInt32(ftc.CountDetails()) + 1;

            txtNumFact.Text = ftc.CountInvoces();
            ftc.ObtenerEntidad(CbEntities);
            ftc.ObtenerDocumentos(CbDocument);
            ftc.ObtenerStatus(CbStatus);
            ftc.ObtenerProduct(CbProds);

            dgvproducto.ClearSelection();
            dgvproducto.CurrentCell = null;

            BtnImprimir.Enabled = false;
            btnagregar.Enabled = false;

        }

        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            dats();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            int indice_fila = dgvproducto.Rows.Add();
            DataGridViewRow row = dgvproducto.Rows[indice_fila];

            row.Cells["ID"].Value = dtf + indice_fila;
            row.Cells["Codigo"].Value = CbProds.SelectedValue;
            row.Cells["Cantidad"].Value = txtcantidad.Text;
            row.Cells["Descripcion"].Value = CbProds.Text;
            row.Cells["PrecioUnitario"].Value = txtprecio.Text;
            row.Cells["Importe"].Value = decimal.Parse(txtcantidad.Text) * decimal.Parse(txtprecio.Text);

            limpiarCampos();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dgvproducto.Rows.RemoveAt(dgvproducto.CurrentRow.Index);

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            imprimir(CbEntities.Text, txtNumFact.Text);
            foreach (DataGridViewRow GVRow in dgvproducto.Rows)
            {
                var code = Convert.ToInt32(txtNumFact.Text.Trim());
                int ID = Convert.ToInt32(GVRow.Cells[0].Value);
                int Cod_Prod = Convert.ToInt32(GVRow.Cells[1].Value);
                int Cantidad = Convert.ToInt32(GVRow.Cells[2].Value);
                string Descripcion = Convert.ToString(GVRow.Cells[3].Value);
                double Precio = Convert.ToDouble(GVRow.Cells[4].Value);
                double Total = Convert.ToDouble(GVRow.Cells[5].Value);

                ftc.InsertDetails(ID, Descripcion, Cantidad, Total, Precio, code, Cod_Prod);

            }
            
            MessageBox.Show("Pedido Registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ClearData();
            dats();

            
        }

        private void CbProds_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from products where id = '"+CbProds.SelectedValue+"'";
            SqlCommand cn = new SqlCommand(query, cnn);
            cnn.Open();
            SqlDataReader precio = cn.ExecuteReader();

            if(precio.Read() == true)
            {
                txtprecio.Text = precio["price"].ToString();
            }
            else
            {
                txtprecio.Text = "";
            }
            cnn.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(txtNumFact.Text.Trim());
            var customer = Convert.ToInt32(CbEntities.SelectedValue);
            var fecha = Convert.ToString(DateTime.Now);
            var document = Convert.ToInt32(CbDocument.SelectedValue);
            var status = Convert.ToInt32(CbStatus.SelectedValue);


            if (ftc.InsertInvoice(code, customer, fecha, document, status) == "Correcto")
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

        public void imprimir(string Nombre, string NumDoc)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyy"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", Nombre);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", NumDoc);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvproducto.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Importe"].Value.ToString());
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

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
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
