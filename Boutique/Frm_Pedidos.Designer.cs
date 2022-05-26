namespace Boutique
{
    partial class Frm_Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbProds = new Guna.UI.WinForms.GunaComboBox();
            this.txtcantidad = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtprecio = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.CbStatus = new Guna.UI.WinForms.GunaComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbDocument = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbEntities = new Guna.UI.WinForms.GunaComboBox();
            this.txtNumFact = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnagregar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnImprimir = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvproducto = new Guna.UI.WinForms.GunaDataGridView();
            this.btnBorrar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.RoyalBlue;
            this.gunaElipsePanel1.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 1;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(575, 23);
            this.gunaElipsePanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(553, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(3, 2);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(68, 19);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Pedidos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CbProds);
            this.groupBox2.Controls.Add(this.txtcantidad);
            this.groupBox2.Controls.Add(this.txtprecio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 59);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Producto";
            // 
            // CbProds
            // 
            this.CbProds.BackColor = System.Drawing.Color.Transparent;
            this.CbProds.BaseColor = System.Drawing.Color.White;
            this.CbProds.BorderColor = System.Drawing.Color.Silver;
            this.CbProds.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbProds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProds.FocusedColor = System.Drawing.Color.Empty;
            this.CbProds.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbProds.ForeColor = System.Drawing.Color.Black;
            this.CbProds.FormattingEnabled = true;
            this.CbProds.Location = new System.Drawing.Point(96, 24);
            this.CbProds.Name = "CbProds";
            this.CbProds.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CbProds.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CbProds.Size = new System.Drawing.Size(148, 26);
            this.CbProds.TabIndex = 95;
            this.CbProds.SelectedIndexChanged += new System.EventHandler(this.CbProds_SelectedIndexChanged);
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.White;
            this.txtcantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcantidad.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcantidad.LineColor = System.Drawing.Color.Gainsboro;
            this.txtcantidad.Location = new System.Drawing.Point(458, 21);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.PasswordChar = '\0';
            this.txtcantidad.Size = new System.Drawing.Size(60, 26);
            this.txtcantidad.TabIndex = 94;
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.White;
            this.txtprecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprecio.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtprecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtprecio.LineColor = System.Drawing.Color.Gainsboro;
            this.txtprecio.Location = new System.Drawing.Point(304, 24);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.PasswordChar = '\0';
            this.txtprecio.Size = new System.Drawing.Size(79, 26);
            this.txtprecio.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 91;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 91;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripcion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gunaButton1);
            this.groupBox1.Controls.Add(this.CbStatus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CbDocument);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CbEntities);
            this.groupBox1.Controls.Add(this.txtNumFact);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 117);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Cliente";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(471, 64);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(74, 26);
            this.gunaButton1.TabIndex = 96;
            this.gunaButton1.Text = "Registrar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // CbStatus
            // 
            this.CbStatus.BackColor = System.Drawing.Color.Transparent;
            this.CbStatus.BaseColor = System.Drawing.Color.White;
            this.CbStatus.BorderColor = System.Drawing.Color.Silver;
            this.CbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.CbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbStatus.ForeColor = System.Drawing.Color.Black;
            this.CbStatus.FormattingEnabled = true;
            this.CbStatus.Location = new System.Drawing.Point(331, 64);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CbStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CbStatus.Size = new System.Drawing.Size(121, 26);
            this.CbStatus.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 94;
            this.label7.Text = "Estado:";
            // 
            // CbDocument
            // 
            this.CbDocument.BackColor = System.Drawing.Color.Transparent;
            this.CbDocument.BaseColor = System.Drawing.Color.White;
            this.CbDocument.BorderColor = System.Drawing.Color.Silver;
            this.CbDocument.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDocument.FocusedColor = System.Drawing.Color.Empty;
            this.CbDocument.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbDocument.ForeColor = System.Drawing.Color.Black;
            this.CbDocument.FormattingEnabled = true;
            this.CbDocument.Location = new System.Drawing.Point(140, 64);
            this.CbDocument.Name = "CbDocument";
            this.CbDocument.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CbDocument.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CbDocument.Size = new System.Drawing.Size(121, 26);
            this.CbDocument.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 92;
            this.label6.Text = "Tipo de Documento:";
            // 
            // CbEntities
            // 
            this.CbEntities.BackColor = System.Drawing.Color.Transparent;
            this.CbEntities.BaseColor = System.Drawing.Color.White;
            this.CbEntities.BorderColor = System.Drawing.Color.Silver;
            this.CbEntities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbEntities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEntities.FocusedColor = System.Drawing.Color.Empty;
            this.CbEntities.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbEntities.ForeColor = System.Drawing.Color.Black;
            this.CbEntities.FormattingEnabled = true;
            this.CbEntities.Location = new System.Drawing.Point(424, 17);
            this.CbEntities.Name = "CbEntities";
            this.CbEntities.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CbEntities.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CbEntities.Size = new System.Drawing.Size(121, 26);
            this.CbEntities.TabIndex = 91;
            // 
            // txtNumFact
            // 
            this.txtNumFact.BackColor = System.Drawing.Color.White;
            this.txtNumFact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumFact.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNumFact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumFact.LineColor = System.Drawing.Color.Gainsboro;
            this.txtNumFact.Location = new System.Drawing.Point(131, 17);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.PasswordChar = '\0';
            this.txtNumFact.Size = new System.Drawing.Size(148, 26);
            this.txtNumFact.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 89;
            this.label2.Text = "Nro. Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 87;
            this.label1.Text = "Tipo de Cliente:";
            // 
            // btnagregar
            // 
            this.btnagregar.AnimationHoverSpeed = 0.07F;
            this.btnagregar.AnimationSpeed = 0.03F;
            this.btnagregar.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnagregar.BorderColor = System.Drawing.Color.Black;
            this.btnagregar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnagregar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregar.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregar.CheckedImage = null;
            this.btnagregar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnagregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregar.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnagregar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnagregar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregar.Location = new System.Drawing.Point(216, 227);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.OnHoverBaseColor = System.Drawing.Color.Green;
            this.btnagregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregar.OnHoverImage = null;
            this.btnagregar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregar.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregar.Size = new System.Drawing.Size(144, 35);
            this.btnagregar.TabIndex = 97;
            this.btnagregar.Text = "Agregar Producto";
            this.btnagregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.AnimationHoverSpeed = 0.07F;
            this.BtnImprimir.AnimationSpeed = 0.03F;
            this.BtnImprimir.BaseColor = System.Drawing.Color.Blue;
            this.BtnImprimir.BorderColor = System.Drawing.Color.Black;
            this.BtnImprimir.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnImprimir.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnImprimir.CheckedForeColor = System.Drawing.Color.White;
            this.BtnImprimir.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.CheckedImage")));
            this.BtnImprimir.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnImprimir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnImprimir.FocusedColor = System.Drawing.Color.Empty;
            this.BtnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.Image")));
            this.BtnImprimir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnImprimir.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnImprimir.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnImprimir.Location = new System.Drawing.Point(455, 536);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnImprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnImprimir.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnImprimir.OnHoverImage = null;
            this.BtnImprimir.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.BtnImprimir.Size = new System.Drawing.Size(107, 35);
            this.BtnImprimir.TabIndex = 98;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // dgvproducto
            // 
            this.dgvproducto.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvproducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvproducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvproducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvproducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproducto.ColumnHeadersHeight = 20;
            this.dgvproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproducto.EnableHeadersVisualStyles = false;
            this.dgvproducto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvproducto.Location = new System.Drawing.Point(11, 268);
            this.dgvproducto.MultiSelect = false;
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.ReadOnly = true;
            this.dgvproducto.RowHeadersVisible = false;
            this.dgvproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproducto.Size = new System.Drawing.Size(551, 262);
            this.dgvproducto.TabIndex = 99;
            this.dgvproducto.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvproducto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvproducto.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvproducto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvproducto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvproducto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvproducto.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvproducto.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvproducto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvproducto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvproducto.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvproducto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvproducto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvproducto.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvproducto.ThemeStyle.ReadOnly = true;
            this.dgvproducto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvproducto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvproducto.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvproducto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvproducto.ThemeStyle.RowsStyle.Height = 22;
            this.dgvproducto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvproducto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnBorrar
            // 
            this.btnBorrar.AnimationHoverSpeed = 0.07F;
            this.btnBorrar.AnimationSpeed = 0.03F;
            this.btnBorrar.BaseColor = System.Drawing.Color.Blue;
            this.btnBorrar.BorderColor = System.Drawing.Color.Black;
            this.btnBorrar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBorrar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBorrar.CheckedForeColor = System.Drawing.Color.White;
            this.btnBorrar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.CheckedImage")));
            this.btnBorrar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBorrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBorrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBorrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBorrar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBorrar.Location = new System.Drawing.Point(12, 536);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBorrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBorrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBorrar.OnHoverImage = null;
            this.btnBorrar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBorrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBorrar.Size = new System.Drawing.Size(107, 35);
            this.btnBorrar.TabIndex = 100;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 578);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvproducto);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Ventas";
            this.Load += new System.EventHandler(this.Frm_Ventas_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txtcantidad;
        private Guna.UI.WinForms.GunaLineTextBox txtprecio;
        private Guna.UI.WinForms.GunaLineTextBox txtNumFact;
        private Guna.UI.WinForms.GunaAdvenceButton btnagregar;
        private Guna.UI.WinForms.GunaAdvenceButton BtnImprimir;
        private Guna.UI.WinForms.GunaDataGridView dgvproducto;
        private Guna.UI.WinForms.GunaAdvenceButton btnBorrar;
        private Guna.UI.WinForms.GunaComboBox CbEntities;
        private Guna.UI.WinForms.GunaComboBox CbDocument;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox CbStatus;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox CbProds;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}