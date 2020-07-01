using GOObra.Controller;
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
    public partial class frmEditaEntrada : Form
    {
        public int id;
        
        public frmEditaEntrada()
        {
            InitializeComponent();                
        }

        private void frmEditaEntrada_Load(object sender, EventArgs e)
        {
            try
            {
                ProdutosController.CarregaCombo(cmbProduto);
                cmbProduto.Text = cl_Variaveis.Produto;
                txtQuantidade.Text = cl_Variaveis.Quantidade.ToString();
                txtPreco.Text = cl_Variaveis.Preco;
            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
          
             

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cl_Variaveis.Produto = cmbProduto.Text;
            cl_Variaveis.Quantidade = txtQuantidade.Text;
            cl_Variaveis.Preco = txtPreco.Text;
            this.Close();
        }
    }
}
