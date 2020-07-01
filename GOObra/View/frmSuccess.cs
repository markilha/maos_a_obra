using System;
using System.Windows.Forms;

namespace GOObra.View
{
    public partial class frmSuccess : Form
    {
        public frmSuccess(string mensagem)
        {
            InitializeComponent();
            lblMensagem.Text = mensagem;
        }

        private void frmSuccess_Load(object sender, EventArgs e)
        {
           
        }
        public static void Mensagem(string mensagem)
        {
            frmSuccess frm = new frmSuccess(mensagem);
            frm.ShowDialog();
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            btnAceitar.Enabled = false;
            this.Close();            
        }
        
    }
}
