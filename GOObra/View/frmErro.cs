using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOObra.View
{
    public partial class frmErro : Form
    {
        public frmErro(string mensagem)
        {
            InitializeComponent();
            lblMensagem.Text = mensagem;
        }

        public static void Mensagem(string mensagem)
        {
            frmErro frm = new frmErro(mensagem);
            frm.ShowDialog();
        }
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            btnAceitar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            btnCancelar.Enabled = false;
        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }

        private void frmErro_Load(object sender, EventArgs e)
        {
        }
    }
}
