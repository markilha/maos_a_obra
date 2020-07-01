using GOObra.Model;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmFornecedor form = new frmFornecedor(null,true))
            {
                form.ShowDialog();
            }
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmOrdem form = new frmOrdem())
            {
                form.ShowDialog();
            }
        }

        private void btnNovaEntrada_Click(object sender, EventArgs e)
        {
            using (frmEntrada form = new frmEntrada())
            {
                form.ShowDialog();
            }
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            using (frmEntrada form = new frmEntrada())
            {
                form.ShowDialog();
            }
        }

        private void frmPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                using (frmEntrada form = new frmEntrada())
                {
                    form.ShowDialog();
                }

            };
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmProdutoEditar form = new frmProdutoEditar())
            {
                form.ShowDialog();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmProdutos form = new frmProdutos())
            {
                cl_Variaveis.frmentrada = null;
                cl_Variaveis.frmprodutoeditar = null;
                form.modo = 0;
                form.ShowDialog();
            }


        }
    }
}
