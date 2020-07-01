using GOObra.Controller;
using GOObra.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOObra
{
    public partial class frmBD : MetroFramework.Forms.MetroForm
    {
        public frmBD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                DalHelper.CriarBancoSQLite();
                //btnCriarBancoDados.Enabled = false;
            }
            catch (Exception ex)
            {
                frmErro.Mensagem("Erro : " + ex.Message);
            }
        }

        private void btnCriarTabelas_Click(object sender, EventArgs e)
        {
            try
            {
                DalHelper.CriarTabelas();
             
                //btnCriarTabela.Enabled = false;
            }
            catch (Exception ex)
            {
                frmErro.Mensagem("Erro : " + ex.Message);
            }
        }
    }
}
