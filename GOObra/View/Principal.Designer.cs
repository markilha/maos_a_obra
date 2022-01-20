namespace GOObra.View
{
    partial class Principal
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCarModelo = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.animacaoSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animacaoSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.radioPainelForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnTeste = new System.Windows.Forms.Button();
            this.subMenuRelatorio = new System.Windows.Forms.Panel();
            this.btnRolComprador = new System.Windows.Forms.Button();
            this.btnOrdem = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnRelatorio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.subMenuGrafico = new System.Windows.Forms.Panel();
            this.btnCompradores = new System.Windows.Forms.Button();
            this.btnGrafVariacao = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGrafico = new Bunifu.Framework.UI.BunifuFlatButton();
            this.subMenuConsulta = new System.Windows.Forms.Panel();
            this.btnConOrdem = new System.Windows.Forms.Button();
            this.btnConfornecedores = new System.Windows.Forms.Button();
            this.btnConProdutos = new System.Windows.Forms.Button();
            this.btnConsulta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.subMenuCadastro = new System.Windows.Forms.Panel();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnCadFornecedores = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnCadastro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntEntrada = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Sair = new System.Windows.Forms.PictureBox();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.MenuTop.SuspendLayout();
            this.SidebarWrapper.SuspendLayout();
            this.Wrapper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.subMenuRelatorio.SuspendLayout();
            this.subMenuGrafico.SuspendLayout();
            this.subMenuConsulta.SuspendLayout();
            this.subMenuCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Sair);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.animacaoSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Margin = new System.Windows.Forms.Padding(4);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1848, 69);
            this.MenuTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animacaoSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "GERENCIADOR DE OBRA";
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.animacaoSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 69);
            this.SidebarWrapper.Margin = new System.Windows.Forms.Padding(4);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(400, 901);
            this.SidebarWrapper.TabIndex = 1;
            this.SidebarWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.SidebarWrapper_Paint);
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.panel1);
            this.Wrapper.Controls.Add(this.panelChildForm);
            this.animacaoSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(400, 69);
            this.Wrapper.Margin = new System.Windows.Forms.Padding(4);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1448, 901);
            this.Wrapper.TabIndex = 2;
            this.Wrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.Wrapper_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnCarModelo);
            this.panel1.Controls.Add(this.txtCaminho);
            this.animacaoSidebarBack.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(29, 852);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 37);
            this.panel1.TabIndex = 1;
            // 
            // btnCarModelo
            // 
            this.btnCarModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.animacaoSidebar.SetDecoration(this.btnCarModelo, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnCarModelo, BunifuAnimatorNS.DecorationType.None);
            this.btnCarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarModelo.ForeColor = System.Drawing.Color.White;
            this.btnCarModelo.Location = new System.Drawing.Point(2, 5);
            this.btnCarModelo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCarModelo.Name = "btnCarModelo";
            this.btnCarModelo.Size = new System.Drawing.Size(271, 31);
            this.btnCarModelo.TabIndex = 76;
            this.btnCarModelo.Text = "Caminho do Banco";
            this.btnCarModelo.UseVisualStyleBackColor = true;
            this.btnCarModelo.Click += new System.EventHandler(this.btnCarModelo_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCaminho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtCaminho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animacaoSidebar.SetDecoration(this.txtCaminho, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.txtCaminho, BunifuAnimatorNS.DecorationType.None);
            this.txtCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminho.ForeColor = System.Drawing.Color.Chartreuse;
            this.txtCaminho.Location = new System.Drawing.Point(301, 8);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(1055, 19);
            this.txtCaminho.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.AutoSize = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.animacaoSidebarBack.SetDecoration(this.panelChildForm, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.panelChildForm, BunifuAnimatorNS.DecorationType.None);
            this.panelChildForm.Location = new System.Drawing.Point(29, 30);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1388, 808);
            this.panelChildForm.TabIndex = 0;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // animacaoSidebar
            // 
            this.animacaoSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.animacaoSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.animacaoSidebar.DefaultAnimation = animation1;
            // 
            // animacaoSidebarBack
            // 
            this.animacaoSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animacaoSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animacaoSidebarBack.DefaultAnimation = animation2;
            // 
            // radioPainelForm
            // 
            this.radioPainelForm.ElipseRadius = 7;
            this.radioPainelForm.TargetControl = this.panelChildForm;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.btnCategoria);
            this.Sidebar.Controls.Add(this.btnTeste);
            this.Sidebar.Controls.Add(this.subMenuRelatorio);
            this.Sidebar.Controls.Add(this.btnRelatorio);
            this.Sidebar.Controls.Add(this.subMenuGrafico);
            this.Sidebar.Controls.Add(this.btnGrafico);
            this.Sidebar.Controls.Add(this.subMenuConsulta);
            this.Sidebar.Controls.Add(this.btnConsulta);
            this.Sidebar.Controls.Add(this.subMenuCadastro);
            this.Sidebar.Controls.Add(this.btnCadastro);
            this.Sidebar.Controls.Add(this.bntEntrada);
            this.Sidebar.Controls.Add(this.LineSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.animacaoSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(21, 30);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(360, 868);
            this.Sidebar.TabIndex = 0;
            // 
            // btnTeste
            // 
            this.animacaoSidebar.SetDecoration(this.btnTeste, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnTeste, BunifuAnimatorNS.DecorationType.None);
            this.btnTeste.Location = new System.Drawing.Point(41, 774);
            this.btnTeste.Margin = new System.Windows.Forms.Padding(4);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(167, 34);
            this.btnTeste.TabIndex = 0;
            this.btnTeste.Text = "button7";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Visible = false;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // subMenuRelatorio
            // 
            this.subMenuRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuRelatorio.Controls.Add(this.btnRolComprador);
            this.subMenuRelatorio.Controls.Add(this.btnOrdem);
            this.subMenuRelatorio.Controls.Add(this.button5);
            this.subMenuRelatorio.Controls.Add(this.button6);
            this.animacaoSidebarBack.SetDecoration(this.subMenuRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.subMenuRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.subMenuRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuRelatorio.Location = new System.Drawing.Point(0, 433);
            this.subMenuRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.subMenuRelatorio.Name = "subMenuRelatorio";
            this.subMenuRelatorio.Size = new System.Drawing.Size(360, 208);
            this.subMenuRelatorio.TabIndex = 20;
            // 
            // btnRolComprador
            // 
            this.animacaoSidebar.SetDecoration(this.btnRolComprador, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnRolComprador, BunifuAnimatorNS.DecorationType.None);
            this.btnRolComprador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRolComprador.FlatAppearance.BorderSize = 0;
            this.btnRolComprador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRolComprador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRolComprador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolComprador.ForeColor = System.Drawing.Color.Silver;
            this.btnRolComprador.Location = new System.Drawing.Point(0, 147);
            this.btnRolComprador.Margin = new System.Windows.Forms.Padding(4);
            this.btnRolComprador.Name = "btnRolComprador";
            this.btnRolComprador.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnRolComprador.Size = new System.Drawing.Size(360, 49);
            this.btnRolComprador.TabIndex = 21;
            this.btnRolComprador.Text = "Por Comprador";
            this.btnRolComprador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolComprador.UseVisualStyleBackColor = true;
            this.btnRolComprador.Click += new System.EventHandler(this.btnRolComprador_Click);
            // 
            // btnOrdem
            // 
            this.animacaoSidebar.SetDecoration(this.btnOrdem, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnOrdem, BunifuAnimatorNS.DecorationType.None);
            this.btnOrdem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdem.FlatAppearance.BorderSize = 0;
            this.btnOrdem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnOrdem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdem.ForeColor = System.Drawing.Color.Silver;
            this.btnOrdem.Location = new System.Drawing.Point(0, 98);
            this.btnOrdem.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdem.Name = "btnOrdem";
            this.btnOrdem.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnOrdem.Size = new System.Drawing.Size(360, 49);
            this.btnOrdem.TabIndex = 20;
            this.btnOrdem.Text = "Por Ordem";
            this.btnOrdem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdem.UseVisualStyleBackColor = true;
            this.btnOrdem.Click += new System.EventHandler(this.btnOrdem_Click);
            // 
            // button5
            // 
            this.animacaoSidebar.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(0, 49);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(360, 49);
            this.button5.TabIndex = 19;
            this.button5.Text = "Produtos Utilizados";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.animacaoSidebar.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(360, 49);
            this.button6.TabIndex = 2;
            this.button6.Text = "Por Fornecedor";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorio.BorderRadius = 0;
            this.btnRelatorio.ButtonText = "               RELATÓRIOS";
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacaoSidebarBack.SetDecoration(this.btnRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.btnRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.btnRelatorio.DisabledColor = System.Drawing.Color.Gray;
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRelatorio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Iconimage")));
            this.btnRelatorio.Iconimage_right = null;
            this.btnRelatorio.Iconimage_right_Selected = null;
            this.btnRelatorio.Iconimage_Selected = null;
            this.btnRelatorio.IconMarginLeft = 0;
            this.btnRelatorio.IconMarginRight = 0;
            this.btnRelatorio.IconRightVisible = true;
            this.btnRelatorio.IconRightZoom = 0D;
            this.btnRelatorio.IconVisible = true;
            this.btnRelatorio.IconZoom = 50D;
            this.btnRelatorio.IsTab = false;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 374);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(5);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRelatorio.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnRelatorio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRelatorio.selected = false;
            this.btnRelatorio.Size = new System.Drawing.Size(360, 59);
            this.btnRelatorio.TabIndex = 19;
            this.btnRelatorio.Text = "               RELATÓRIOS";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Textcolor = System.Drawing.Color.Black;
            this.btnRelatorio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // subMenuGrafico
            // 
            this.subMenuGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuGrafico.Controls.Add(this.btnCompradores);
            this.subMenuGrafico.Controls.Add(this.btnGrafVariacao);
            this.subMenuGrafico.Controls.Add(this.button4);
            this.subMenuGrafico.Controls.Add(this.button1);
            this.subMenuGrafico.Controls.Add(this.button2);
            this.subMenuGrafico.Controls.Add(this.button3);
            this.animacaoSidebarBack.SetDecoration(this.subMenuGrafico, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.subMenuGrafico, BunifuAnimatorNS.DecorationType.None);
            this.subMenuGrafico.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuGrafico.Location = new System.Drawing.Point(0, 337);
            this.subMenuGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.subMenuGrafico.Name = "subMenuGrafico";
            this.subMenuGrafico.Size = new System.Drawing.Size(360, 37);
            this.subMenuGrafico.TabIndex = 18;
            // 
            // btnCompradores
            // 
            this.animacaoSidebar.SetDecoration(this.btnCompradores, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnCompradores, BunifuAnimatorNS.DecorationType.None);
            this.btnCompradores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompradores.FlatAppearance.BorderSize = 0;
            this.btnCompradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCompradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCompradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompradores.ForeColor = System.Drawing.Color.Silver;
            this.btnCompradores.Location = new System.Drawing.Point(0, 165);
            this.btnCompradores.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompradores.Name = "btnCompradores";
            this.btnCompradores.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnCompradores.Size = new System.Drawing.Size(360, 32);
            this.btnCompradores.TabIndex = 21;
            this.btnCompradores.Text = "Compradores";
            this.btnCompradores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompradores.UseVisualStyleBackColor = true;
            this.btnCompradores.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnGrafVariacao
            // 
            this.animacaoSidebar.SetDecoration(this.btnGrafVariacao, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnGrafVariacao, BunifuAnimatorNS.DecorationType.None);
            this.btnGrafVariacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrafVariacao.FlatAppearance.BorderSize = 0;
            this.btnGrafVariacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnGrafVariacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnGrafVariacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafVariacao.ForeColor = System.Drawing.Color.Silver;
            this.btnGrafVariacao.Location = new System.Drawing.Point(0, 133);
            this.btnGrafVariacao.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrafVariacao.Name = "btnGrafVariacao";
            this.btnGrafVariacao.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnGrafVariacao.Size = new System.Drawing.Size(360, 32);
            this.btnGrafVariacao.TabIndex = 20;
            this.btnGrafVariacao.Text = "Variação Preço";
            this.btnGrafVariacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafVariacao.UseVisualStyleBackColor = true;
            this.btnGrafVariacao.Click += new System.EventHandler(this.btnGrafVariacao_Click);
            // 
            // button4
            // 
            this.animacaoSidebar.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(0, 101);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(360, 32);
            this.button4.TabIndex = 19;
            this.button4.Text = "Mão de Obra X Materiais";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.animacaoSidebar.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(0, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(360, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Por Categoria";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.animacaoSidebar.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(0, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(360, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Por Ordem";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.animacaoSidebar.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(360, 37);
            this.button3.TabIndex = 0;
            this.button3.Text = "Por Fornedor";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGrafico.BackColor = System.Drawing.Color.Transparent;
            this.btnGrafico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrafico.BorderRadius = 0;
            this.btnGrafico.ButtonText = "               GRÁFICO";
            this.btnGrafico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacaoSidebarBack.SetDecoration(this.btnGrafico, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.btnGrafico, BunifuAnimatorNS.DecorationType.None);
            this.btnGrafico.DisabledColor = System.Drawing.Color.Gray;
            this.btnGrafico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrafico.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGrafico.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGrafico.Iconimage")));
            this.btnGrafico.Iconimage_right = null;
            this.btnGrafico.Iconimage_right_Selected = null;
            this.btnGrafico.Iconimage_Selected = null;
            this.btnGrafico.IconMarginLeft = 0;
            this.btnGrafico.IconMarginRight = 0;
            this.btnGrafico.IconRightVisible = true;
            this.btnGrafico.IconRightZoom = 0D;
            this.btnGrafico.IconVisible = true;
            this.btnGrafico.IconZoom = 50D;
            this.btnGrafico.IsTab = false;
            this.btnGrafico.Location = new System.Drawing.Point(0, 278);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(5);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGrafico.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnGrafico.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGrafico.selected = false;
            this.btnGrafico.Size = new System.Drawing.Size(360, 59);
            this.btnGrafico.TabIndex = 17;
            this.btnGrafico.Text = "               GRÁFICO";
            this.btnGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.Textcolor = System.Drawing.Color.Black;
            this.btnGrafico.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // subMenuConsulta
            // 
            this.subMenuConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuConsulta.Controls.Add(this.btnConOrdem);
            this.subMenuConsulta.Controls.Add(this.btnConfornecedores);
            this.subMenuConsulta.Controls.Add(this.btnConProdutos);
            this.animacaoSidebarBack.SetDecoration(this.subMenuConsulta, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.subMenuConsulta, BunifuAnimatorNS.DecorationType.None);
            this.subMenuConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuConsulta.Location = new System.Drawing.Point(0, 226);
            this.subMenuConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.subMenuConsulta.Name = "subMenuConsulta";
            this.subMenuConsulta.Size = new System.Drawing.Size(360, 52);
            this.subMenuConsulta.TabIndex = 16;
            // 
            // btnConOrdem
            // 
            this.animacaoSidebar.SetDecoration(this.btnConOrdem, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnConOrdem, BunifuAnimatorNS.DecorationType.None);
            this.btnConOrdem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConOrdem.FlatAppearance.BorderSize = 0;
            this.btnConOrdem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnConOrdem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnConOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConOrdem.ForeColor = System.Drawing.Color.Silver;
            this.btnConOrdem.Location = new System.Drawing.Point(0, 98);
            this.btnConOrdem.Margin = new System.Windows.Forms.Padding(4);
            this.btnConOrdem.Name = "btnConOrdem";
            this.btnConOrdem.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnConOrdem.Size = new System.Drawing.Size(360, 49);
            this.btnConOrdem.TabIndex = 2;
            this.btnConOrdem.Text = "Ordens";
            this.btnConOrdem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConOrdem.UseVisualStyleBackColor = true;
            this.btnConOrdem.Click += new System.EventHandler(this.btnConOrdem_Click);
            // 
            // btnConfornecedores
            // 
            this.animacaoSidebar.SetDecoration(this.btnConfornecedores, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnConfornecedores, BunifuAnimatorNS.DecorationType.None);
            this.btnConfornecedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfornecedores.FlatAppearance.BorderSize = 0;
            this.btnConfornecedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnConfornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnConfornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfornecedores.ForeColor = System.Drawing.Color.Silver;
            this.btnConfornecedores.Location = new System.Drawing.Point(0, 49);
            this.btnConfornecedores.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfornecedores.Name = "btnConfornecedores";
            this.btnConfornecedores.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnConfornecedores.Size = new System.Drawing.Size(360, 49);
            this.btnConfornecedores.TabIndex = 1;
            this.btnConfornecedores.Text = "Fonecedores";
            this.btnConfornecedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfornecedores.UseVisualStyleBackColor = true;
            this.btnConfornecedores.Click += new System.EventHandler(this.btnConfornecedores_Click);
            // 
            // btnConProdutos
            // 
            this.animacaoSidebar.SetDecoration(this.btnConProdutos, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnConProdutos, BunifuAnimatorNS.DecorationType.None);
            this.btnConProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConProdutos.FlatAppearance.BorderSize = 0;
            this.btnConProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnConProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnConProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConProdutos.ForeColor = System.Drawing.Color.Silver;
            this.btnConProdutos.Location = new System.Drawing.Point(0, 0);
            this.btnConProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.btnConProdutos.Name = "btnConProdutos";
            this.btnConProdutos.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnConProdutos.Size = new System.Drawing.Size(360, 49);
            this.btnConProdutos.TabIndex = 0;
            this.btnConProdutos.Text = "Produtos";
            this.btnConProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConProdutos.UseVisualStyleBackColor = true;
            this.btnConProdutos.Click += new System.EventHandler(this.btnConProdutos_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConsulta.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsulta.BorderRadius = 0;
            this.btnConsulta.ButtonText = "               CONSULTAR";
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacaoSidebarBack.SetDecoration(this.btnConsulta, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.btnConsulta, BunifuAnimatorNS.DecorationType.None);
            this.btnConsulta.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsulta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Iconimage")));
            this.btnConsulta.Iconimage_right = null;
            this.btnConsulta.Iconimage_right_Selected = null;
            this.btnConsulta.Iconimage_Selected = null;
            this.btnConsulta.IconMarginLeft = 0;
            this.btnConsulta.IconMarginRight = 0;
            this.btnConsulta.IconRightVisible = true;
            this.btnConsulta.IconRightZoom = 0D;
            this.btnConsulta.IconVisible = true;
            this.btnConsulta.IconZoom = 50D;
            this.btnConsulta.IsTab = false;
            this.btnConsulta.Location = new System.Drawing.Point(0, 167);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConsulta.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnConsulta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsulta.selected = false;
            this.btnConsulta.Size = new System.Drawing.Size(360, 59);
            this.btnConsulta.TabIndex = 15;
            this.btnConsulta.Text = "               CONSULTAR";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Textcolor = System.Drawing.Color.Black;
            this.btnConsulta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // subMenuCadastro
            // 
            this.subMenuCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuCadastro.Controls.Add(this.btnAltera);
            this.subMenuCadastro.Controls.Add(this.btnCadFornecedores);
            this.subMenuCadastro.Controls.Add(this.btnCadProduto);
            this.animacaoSidebarBack.SetDecoration(this.subMenuCadastro, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.subMenuCadastro, BunifuAnimatorNS.DecorationType.None);
            this.subMenuCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuCadastro.Location = new System.Drawing.Point(0, 118);
            this.subMenuCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.subMenuCadastro.Name = "subMenuCadastro";
            this.subMenuCadastro.Size = new System.Drawing.Size(360, 49);
            this.subMenuCadastro.TabIndex = 14;
            // 
            // btnAltera
            // 
            this.animacaoSidebar.SetDecoration(this.btnAltera, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnAltera, BunifuAnimatorNS.DecorationType.None);
            this.btnAltera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltera.FlatAppearance.BorderSize = 0;
            this.btnAltera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAltera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAltera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltera.ForeColor = System.Drawing.Color.Silver;
            this.btnAltera.Location = new System.Drawing.Point(0, 98);
            this.btnAltera.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAltera.Size = new System.Drawing.Size(360, 49);
            this.btnAltera.TabIndex = 2;
            this.btnAltera.Text = "Alterar Banco de Dados";
            this.btnAltera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnCadFornecedores
            // 
            this.animacaoSidebar.SetDecoration(this.btnCadFornecedores, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnCadFornecedores, BunifuAnimatorNS.DecorationType.None);
            this.btnCadFornecedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadFornecedores.FlatAppearance.BorderSize = 0;
            this.btnCadFornecedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCadFornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCadFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFornecedores.ForeColor = System.Drawing.Color.Silver;
            this.btnCadFornecedores.Location = new System.Drawing.Point(0, 49);
            this.btnCadFornecedores.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadFornecedores.Name = "btnCadFornecedores";
            this.btnCadFornecedores.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnCadFornecedores.Size = new System.Drawing.Size(360, 49);
            this.btnCadFornecedores.TabIndex = 1;
            this.btnCadFornecedores.Text = "Fonecedores";
            this.btnCadFornecedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadFornecedores.UseVisualStyleBackColor = true;
            this.btnCadFornecedores.Click += new System.EventHandler(this.btnCadFornecedores_Click);
            // 
            // btnCadProduto
            // 
            this.animacaoSidebar.SetDecoration(this.btnCadProduto, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnCadProduto, BunifuAnimatorNS.DecorationType.None);
            this.btnCadProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadProduto.FlatAppearance.BorderSize = 0;
            this.btnCadProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCadProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadProduto.ForeColor = System.Drawing.Color.Silver;
            this.btnCadProduto.Location = new System.Drawing.Point(0, 0);
            this.btnCadProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnCadProduto.Size = new System.Drawing.Size(360, 49);
            this.btnCadProduto.TabIndex = 0;
            this.btnCadProduto.Text = "Produtos";
            this.btnCadProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastro.BorderRadius = 0;
            this.btnCadastro.ButtonText = "               CADASTRO";
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacaoSidebarBack.SetDecoration(this.btnCadastro, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.btnCadastro, BunifuAnimatorNS.DecorationType.None);
            this.btnCadastro.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastro.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Iconimage")));
            this.btnCadastro.Iconimage_right = null;
            this.btnCadastro.Iconimage_right_Selected = null;
            this.btnCadastro.Iconimage_Selected = null;
            this.btnCadastro.IconMarginLeft = 0;
            this.btnCadastro.IconMarginRight = 0;
            this.btnCadastro.IconRightVisible = true;
            this.btnCadastro.IconRightZoom = 0D;
            this.btnCadastro.IconVisible = true;
            this.btnCadastro.IconZoom = 50D;
            this.btnCadastro.IsTab = false;
            this.btnCadastro.Location = new System.Drawing.Point(0, 59);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCadastro.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCadastro.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastro.selected = false;
            this.btnCadastro.Size = new System.Drawing.Size(360, 59);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Text = "               CADASTRO";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Textcolor = System.Drawing.Color.Black;
            this.btnCadastro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // bntEntrada
            // 
            this.bntEntrada.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bntEntrada.BackColor = System.Drawing.Color.Transparent;
            this.bntEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntEntrada.BorderRadius = 0;
            this.bntEntrada.ButtonText = "               ENTRADA";
            this.bntEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacaoSidebarBack.SetDecoration(this.bntEntrada, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.bntEntrada, BunifuAnimatorNS.DecorationType.None);
            this.bntEntrada.DisabledColor = System.Drawing.Color.Gray;
            this.bntEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntEntrada.Iconcolor = System.Drawing.Color.Transparent;
            this.bntEntrada.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntEntrada.Iconimage")));
            this.bntEntrada.Iconimage_right = null;
            this.bntEntrada.Iconimage_right_Selected = null;
            this.bntEntrada.Iconimage_Selected = null;
            this.bntEntrada.IconMarginLeft = 0;
            this.bntEntrada.IconMarginRight = 0;
            this.bntEntrada.IconRightVisible = true;
            this.bntEntrada.IconRightZoom = 0D;
            this.bntEntrada.IconVisible = true;
            this.bntEntrada.IconZoom = 50D;
            this.bntEntrada.IsTab = false;
            this.bntEntrada.Location = new System.Drawing.Point(0, 0);
            this.bntEntrada.Margin = new System.Windows.Forms.Padding(0);
            this.bntEntrada.Name = "bntEntrada";
            this.bntEntrada.Normalcolor = System.Drawing.Color.Transparent;
            this.bntEntrada.OnHovercolor = System.Drawing.Color.Transparent;
            this.bntEntrada.OnHoverTextColor = System.Drawing.Color.White;
            this.bntEntrada.Padding = new System.Windows.Forms.Padding(2);
            this.bntEntrada.selected = false;
            this.bntEntrada.Size = new System.Drawing.Size(360, 59);
            this.bntEntrada.TabIndex = 9;
            this.bntEntrada.Text = "               ENTRADA";
            this.bntEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntEntrada.Textcolor = System.Drawing.Color.Black;
            this.bntEntrada.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEntrada.Click += new System.EventHandler(this.bntEntrada_Click);
            // 
            // LineSidebar
            // 
            this.LineSidebar.BackColor = System.Drawing.Color.Transparent;
            this.animacaoSidebarBack.SetDecoration(this.LineSidebar, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebar.SetDecoration(this.LineSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineSidebar.LineThickness = 1;
            this.LineSidebar.Location = new System.Drawing.Point(12, 65);
            this.LineSidebar.Margin = new System.Windows.Forms.Padding(5);
            this.LineSidebar.Name = "LineSidebar";
            this.LineSidebar.Size = new System.Drawing.Size(272, 1);
            this.LineSidebar.TabIndex = 8;
            this.LineSidebar.Transparency = 255;
            this.LineSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.animacaoSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "M4RC0 C0D3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.animacaoSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animacaoSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1745, 17);
            this.Restaurar.Margin = new System.Windows.Forms.Padding(4);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(40, 37);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animacaoSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1699, 17);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(40, 37);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animacaoSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1745, 17);
            this.Maximizar.Margin = new System.Windows.Forms.Padding(4);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(40, 37);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Sair
            // 
            this.Sair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animacaoSidebar.SetDecoration(this.Sair, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.Sair, BunifuAnimatorNS.DecorationType.None);
            this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
            this.Sair.Location = new System.Drawing.Point(1792, 17);
            this.Sair.Margin = new System.Windows.Forms.Padding(4);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(40, 37);
            this.Sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sair.TabIndex = 2;
            this.Sair.TabStop = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // MenuSidebar
            // 
            this.animacaoSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(44, 16);
            this.MenuSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(40, 37);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // btnCategoria
            // 
            this.animacaoSidebar.SetDecoration(this.btnCategoria, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this.btnCategoria, BunifuAnimatorNS.DecorationType.None);
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.ForeColor = System.Drawing.Color.Silver;
            this.btnCategoria.Location = new System.Drawing.Point(0, 641);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnCategoria.Size = new System.Drawing.Size(360, 49);
            this.btnCategoria.TabIndex = 10;
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 970);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.animacaoSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animacaoSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            this.SidebarWrapper.ResumeLayout(false);
            this.Wrapper.ResumeLayout(false);
            this.Wrapper.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.subMenuRelatorio.ResumeLayout(false);
            this.subMenuGrafico.ResumeLayout(false);
            this.subMenuConsulta.ResumeLayout(false);
            this.subMenuCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuSeparator LineSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bntEntrada;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastro;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition animacaoSidebar;
        private BunifuAnimatorNS.BunifuTransition animacaoSidebarBack;
        private System.Windows.Forms.Panel panelChildForm;
        private Bunifu.Framework.UI.BunifuElipse radioPainelForm;
        private System.Windows.Forms.Panel subMenuCadastro;
        private System.Windows.Forms.Button btnCadFornecedores;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Panel subMenuConsulta;
        private System.Windows.Forms.Button btnConfornecedores;
        private System.Windows.Forms.Button btnConProdutos;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsulta;
        private System.Windows.Forms.Button btnConOrdem;
        private Bunifu.Framework.UI.BunifuFlatButton btnGrafico;
        private System.Windows.Forms.Panel subMenuGrafico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAltera;
        private Bunifu.Framework.UI.BunifuFlatButton btnRelatorio;
        private System.Windows.Forms.Panel subMenuRelatorio;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnGrafVariacao;
        private System.Windows.Forms.Button btnOrdem;
        private System.Windows.Forms.Button btnCompradores;
        private System.Windows.Forms.Button btnRolComprador;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnCarModelo;
        private System.Windows.Forms.Button btnCategoria;
    }
}