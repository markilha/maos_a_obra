namespace GOObra
{
    partial class frmBD
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
            this.btnCriar = new MetroFramework.Controls.MetroButton();
            this.btnCriarTabelas = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(37, 173);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(135, 48);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar Banco";
            this.btnCriar.UseSelectable = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnCriarTabelas
            // 
            this.btnCriarTabelas.Location = new System.Drawing.Point(188, 173);
            this.btnCriarTabelas.Name = "btnCriarTabelas";
            this.btnCriarTabelas.Size = new System.Drawing.Size(135, 48);
            this.btnCriarTabelas.TabIndex = 1;
            this.btnCriarTabelas.Text = "Criar Tabelas";
            this.btnCriarTabelas.UseSelectable = true;
            this.btnCriarTabelas.Click += new System.EventHandler(this.btnCriarTabelas_Click);
            // 
            // frmBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 271);
            this.Controls.Add(this.btnCriarTabelas);
            this.Controls.Add(this.btnCriar);
            this.Name = "frmBD";
            this.Text = "Banco de Dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCriar;
        private MetroFramework.Controls.MetroButton btnCriarTabelas;
    }
}

