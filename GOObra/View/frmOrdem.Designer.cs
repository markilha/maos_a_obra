namespace GOObra.View
{
    partial class frmOrdem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdem));
            this.txtOrdem = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOrdem = new MetroFramework.Controls.MetroGrid();
            this.EntradaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edita = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescontoSobreTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtData = new MetroFramework.Controls.MetroTextBox();
            this.btnatualiza = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnFiltrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cmbComprador = new System.Windows.Forms.ComboBox();
            this.btnOrdem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.btnAtualizarComprador = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProduto = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdem)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrdem
            // 
            this.txtOrdem.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtOrdem.CustomButton.Image = null;
            this.txtOrdem.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtOrdem.CustomButton.Name = "";
            this.txtOrdem.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtOrdem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrdem.CustomButton.TabIndex = 1;
            this.txtOrdem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrdem.CustomButton.UseSelectable = true;
            this.txtOrdem.CustomButton.Visible = false;
            this.txtOrdem.Lines = new string[0];
            this.txtOrdem.Location = new System.Drawing.Point(6, 14);
            this.txtOrdem.MaxLength = 32767;
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.PasswordChar = '\0';
            this.txtOrdem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrdem.SelectedText = "";
            this.txtOrdem.SelectionLength = 0;
            this.txtOrdem.SelectionStart = 0;
            this.txtOrdem.ShortcutsEnabled = true;
            this.txtOrdem.Size = new System.Drawing.Size(121, 25);
            this.txtOrdem.TabIndex = 25;
            this.txtOrdem.UseSelectable = true;
            this.txtOrdem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrdem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOrdem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOrdem_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dgvOrdem);
            this.groupBox3.Location = new System.Drawing.Point(50, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1024, 283);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entradas";
            // 
            // dgvOrdem
            // 
            this.dgvOrdem.AllowUserToAddRows = false;
            this.dgvOrdem.AllowUserToResizeRows = false;
            this.dgvOrdem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dgvOrdem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrdem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrdem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntradaId,
            this.ordem,
            this.fornecedor,
            this.quantidade,
            this.ProdutoId,
            this.Categoria,
            this.DataEntrada,
            this.Preco,
            this.Desconto,
            this.Total,
            this.edita,
            this.delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrdem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdem.EnableHeadersVisualStyles = false;
            this.dgvOrdem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOrdem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrdem.Location = new System.Drawing.Point(3, 16);
            this.dgvOrdem.Name = "dgvOrdem";
            this.dgvOrdem.ReadOnly = true;
            this.dgvOrdem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrdem.RowHeadersVisible = false;
            this.dgvOrdem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrdem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdem.Size = new System.Drawing.Size(1018, 264);
            this.dgvOrdem.TabIndex = 0;
            this.dgvOrdem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdem_CellContentClick);
            // 
            // EntradaId
            // 
            this.EntradaId.HeaderText = "EntradaId";
            this.EntradaId.Name = "EntradaId";
            this.EntradaId.ReadOnly = true;
            this.EntradaId.Visible = false;
            // 
            // ordem
            // 
            this.ordem.HeaderText = "Ordem";
            this.ordem.Name = "ordem";
            this.ordem.ReadOnly = true;
            this.ordem.Width = 50;
            // 
            // fornecedor
            // 
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Width = 150;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quant";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 50;
            // 
            // ProdutoId
            // 
            this.ProdutoId.HeaderText = "Descrição";
            this.ProdutoId.Name = "ProdutoId";
            this.ProdutoId.ReadOnly = true;
            this.ProdutoId.Width = 300;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // DataEntrada
            // 
            this.DataEntrada.HeaderText = "Data";
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 80;
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desc";
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            this.Desconto.Width = 50;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // edita
            // 
            this.edita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edita.HeaderText = "";
            this.edita.Image = ((System.Drawing.Image)(resources.GetObject("edita.Image")));
            this.edita.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.edita.Name = "edita";
            this.edita.ReadOnly = true;
            this.edita.Width = 25;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 25;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.groupBox5.Controls.Add(this.txtSubTotal);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.txtTotalDesc);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(819, 418);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 87);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.ForeColor = System.Drawing.Color.White;
            this.txtSubTotal.Location = new System.Drawing.Point(133, 15);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 13);
            this.txtSubTotal.TabIndex = 5;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SubTotal:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(133, 61);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 13);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalDesc
            // 
            this.txtTotalDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtTotalDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalDesc.ForeColor = System.Drawing.Color.White;
            this.txtTotalDesc.Location = new System.Drawing.Point(133, 37);
            this.txtTotalDesc.Name = "txtTotalDesc";
            this.txtTotalDesc.Size = new System.Drawing.Size(100, 13);
            this.txtTotalDesc.TabIndex = 2;
            this.txtTotalDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total a Pagar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Desconto:";
            // 
            // txtDescontoSobreTotal
            // 
            this.txtDescontoSobreTotal.BackColor = System.Drawing.Color.White;
            this.txtDescontoSobreTotal.Location = new System.Drawing.Point(54, 433);
            this.txtDescontoSobreTotal.Name = "txtDescontoSobreTotal";
            this.txtDescontoSobreTotal.Size = new System.Drawing.Size(99, 20);
            this.txtDescontoSobreTotal.TabIndex = 30;
            this.txtDescontoSobreTotal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescontoTotal_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "DESCONTO SOB TOTAL";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.groupBox2.Controls.Add(this.txtOrdem);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(50, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 47);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordem (# tudo)";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.groupBox4.Controls.Add(this.cmbCategoria);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(187, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 47);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(6, 17);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(309, 21);
            this.cmbCategoria.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.groupBox6.Controls.Add(this.cmbFornecedor);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(696, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(242, 47);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Por Fornecedor";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(14, 15);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(205, 21);
            this.cmbFornecedor.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.groupBox7.Controls.Add(this.txtData);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(521, 21);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(164, 47);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtData.CustomButton.Image = null;
            this.txtData.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtData.CustomButton.Name = "";
            this.txtData.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtData.CustomButton.TabIndex = 1;
            this.txtData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtData.CustomButton.UseSelectable = true;
            this.txtData.CustomButton.Visible = false;
            this.txtData.Lines = new string[0];
            this.txtData.Location = new System.Drawing.Point(6, 12);
            this.txtData.MaxLength = 32767;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.ShortcutsEnabled = true;
            this.txtData.Size = new System.Drawing.Size(143, 25);
            this.txtData.TabIndex = 34;
            this.txtData.UseSelectable = true;
            this.txtData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtData_KeyUp);
            // 
            // btnatualiza
            // 
            this.btnatualiza.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnatualiza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnatualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnatualiza.BorderRadius = 7;
            this.btnatualiza.ButtonText = "Atualiza";
            this.btnatualiza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnatualiza.DisabledColor = System.Drawing.Color.Gray;
            this.btnatualiza.Iconcolor = System.Drawing.Color.Transparent;
            this.btnatualiza.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnatualiza.Iconimage")));
            this.btnatualiza.Iconimage_right = null;
            this.btnatualiza.Iconimage_right_Selected = null;
            this.btnatualiza.Iconimage_Selected = null;
            this.btnatualiza.IconMarginLeft = 0;
            this.btnatualiza.IconMarginRight = 0;
            this.btnatualiza.IconRightVisible = true;
            this.btnatualiza.IconRightZoom = 0D;
            this.btnatualiza.IconVisible = true;
            this.btnatualiza.IconZoom = 90D;
            this.btnatualiza.IsTab = false;
            this.btnatualiza.Location = new System.Drawing.Point(177, 429);
            this.btnatualiza.Name = "btnatualiza";
            this.btnatualiza.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnatualiza.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnatualiza.OnHoverTextColor = System.Drawing.Color.White;
            this.btnatualiza.selected = false;
            this.btnatualiza.Size = new System.Drawing.Size(101, 29);
            this.btnatualiza.TabIndex = 41;
            this.btnatualiza.Text = "Atualiza";
            this.btnatualiza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnatualiza.Textcolor = System.Drawing.Color.White;
            this.btnatualiza.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualiza.Click += new System.EventHandler(this.btnatualiza_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrar.BorderRadius = 7;
            this.btnFiltrar.ButtonText = "Filtrar";
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnFiltrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFiltrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Iconimage")));
            this.btnFiltrar.Iconimage_right = null;
            this.btnFiltrar.Iconimage_right_Selected = null;
            this.btnFiltrar.Iconimage_Selected = null;
            this.btnFiltrar.IconMarginLeft = 0;
            this.btnFiltrar.IconMarginRight = 0;
            this.btnFiltrar.IconRightVisible = true;
            this.btnFiltrar.IconRightZoom = 0D;
            this.btnFiltrar.IconVisible = true;
            this.btnFiltrar.IconZoom = 90D;
            this.btnFiltrar.IsTab = false;
            this.btnFiltrar.Location = new System.Drawing.Point(947, 33);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFiltrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFiltrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFiltrar.selected = false;
            this.btnFiltrar.Size = new System.Drawing.Size(127, 74);
            this.btnFiltrar.TabIndex = 42;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Textcolor = System.Drawing.Color.White;
            this.btnFiltrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.groupBox8.Controls.Add(this.cmbComprador);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(521, 71);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(275, 47);
            this.groupBox8.TabIndex = 43;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Comprador";
            // 
            // cmbComprador
            // 
            this.cmbComprador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbComprador.FormattingEnabled = true;
            this.cmbComprador.Location = new System.Drawing.Point(20, 17);
            this.cmbComprador.Name = "cmbComprador";
            this.cmbComprador.Size = new System.Drawing.Size(241, 21);
            this.cmbComprador.TabIndex = 1;
            // 
            // btnOrdem
            // 
            this.btnOrdem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOrdem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOrdem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrdem.BorderRadius = 7;
            this.btnOrdem.ButtonText = "Atualizar Campo";
            this.btnOrdem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdem.DisabledColor = System.Drawing.Color.Gray;
            this.btnOrdem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOrdem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOrdem.Iconimage")));
            this.btnOrdem.Iconimage_right = null;
            this.btnOrdem.Iconimage_right_Selected = null;
            this.btnOrdem.Iconimage_Selected = null;
            this.btnOrdem.IconMarginLeft = 0;
            this.btnOrdem.IconMarginRight = 0;
            this.btnOrdem.IconRightVisible = true;
            this.btnOrdem.IconRightZoom = 0D;
            this.btnOrdem.IconVisible = true;
            this.btnOrdem.IconZoom = 90D;
            this.btnOrdem.IsTab = false;
            this.btnOrdem.Location = new System.Drawing.Point(524, 465);
            this.btnOrdem.Name = "btnOrdem";
            this.btnOrdem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOrdem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOrdem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOrdem.selected = false;
            this.btnOrdem.Size = new System.Drawing.Size(163, 37);
            this.btnOrdem.TabIndex = 45;
            this.btnOrdem.Text = "Atualizar Campo";
            this.btnOrdem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdem.Textcolor = System.Drawing.Color.White;
            this.btnOrdem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdem.Click += new System.EventHandler(this.btnOrdem_Click);
            // 
            // txtSql
            // 
            this.txtSql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSql.Location = new System.Drawing.Point(54, 464);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(464, 38);
            this.txtSql.TabIndex = 46;
            this.txtSql.Text = "UPDATE Entradas SET DataEntrada= \'15/01/2020\' WHERE Ordem = \'41\'";
            // 
            // btnAtualizarComprador
            // 
            this.btnAtualizarComprador.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAtualizarComprador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAtualizarComprador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizarComprador.BorderRadius = 7;
            this.btnAtualizarComprador.ButtonText = "Atualizar Comprador";
            this.btnAtualizarComprador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarComprador.DisabledColor = System.Drawing.Color.Gray;
            this.btnAtualizarComprador.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAtualizarComprador.Iconimage = null;
            this.btnAtualizarComprador.Iconimage_right = null;
            this.btnAtualizarComprador.Iconimage_right_Selected = null;
            this.btnAtualizarComprador.Iconimage_Selected = null;
            this.btnAtualizarComprador.IconMarginLeft = 0;
            this.btnAtualizarComprador.IconMarginRight = 0;
            this.btnAtualizarComprador.IconRightVisible = true;
            this.btnAtualizarComprador.IconRightZoom = 0D;
            this.btnAtualizarComprador.IconVisible = true;
            this.btnAtualizarComprador.IconZoom = 90D;
            this.btnAtualizarComprador.IsTab = false;
            this.btnAtualizarComprador.Location = new System.Drawing.Point(803, 77);
            this.btnAtualizarComprador.Name = "btnAtualizarComprador";
            this.btnAtualizarComprador.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAtualizarComprador.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAtualizarComprador.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAtualizarComprador.selected = false;
            this.btnAtualizarComprador.Size = new System.Drawing.Size(134, 38);
            this.btnAtualizarComprador.TabIndex = 47;
            this.btnAtualizarComprador.Text = "Atualizar Comprador";
            this.btnAtualizarComprador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtualizarComprador.Textcolor = System.Drawing.Color.White;
            this.btnAtualizarComprador.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarComprador.Click += new System.EventHandler(this.btnAtualizarComprador_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(50, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 47);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtProduto.CustomButton.Image = null;
            this.txtProduto.CustomButton.Location = new System.Drawing.Point(429, 1);
            this.txtProduto.CustomButton.Name = "";
            this.txtProduto.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtProduto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProduto.CustomButton.TabIndex = 1;
            this.txtProduto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProduto.CustomButton.UseSelectable = true;
            this.txtProduto.CustomButton.Visible = false;
            this.txtProduto.Lines = new string[0];
            this.txtProduto.Location = new System.Drawing.Point(6, 15);
            this.txtProduto.MaxLength = 32767;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.PasswordChar = '\0';
            this.txtProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProduto.SelectedText = "";
            this.txtProduto.SelectionLength = 0;
            this.txtProduto.SelectionStart = 0;
            this.txtProduto.ShortcutsEnabled = true;
            this.txtProduto.Size = new System.Drawing.Size(453, 25);
            this.txtProduto.TabIndex = 34;
            this.txtProduto.UseSelectable = true;
            this.txtProduto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProduto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProduto_KeyUp);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.ForeColor = System.Drawing.Color.White;
            this.txtQuantidade.Location = new System.Drawing.Point(381, 432);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 13);
            this.txtQuantidade.TabIndex = 50;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(322, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Quantidade";
            // 
            // frmOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1104, 517);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtualizarComprador);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.btnOrdem);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnatualiza);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescontoSobreTotal);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmOrdem";
            this.Load += new System.EventHandler(this.frmOrdem_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdem)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtOrdem;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroGrid dgvOrdem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotalDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescontoSobreTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private MetroFramework.Controls.MetroTextBox txtData;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnatualiza;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuFlatButton btnFiltrar;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cmbComprador;
        private Bunifu.Framework.UI.BunifuFlatButton btnOrdem;
        private System.Windows.Forms.TextBox txtSql;
        private Bunifu.Framework.UI.BunifuFlatButton btnAtualizarComprador;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntradaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn edita;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label4;
    }
}