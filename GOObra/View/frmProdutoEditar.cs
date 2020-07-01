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
    public partial class frmProdutoEditar : Form
    {
        public frmProdutoEditar()
        {
            InitializeComponent();
        }

        private void frmProdutoEditar_Load(object sender, EventArgs e)
        {
            DataTable dt = ProdutosController.GetProdutos();
            ExibirDados(dt);
            txtPesquisar.Focus();
        }
        public void ExibirDados(DataTable dt)
        {
            try
            {
                dgvEntrada.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string fornecedor = FornecedorController.GetStringfornecedor(Convert.ToInt32(dr["fornecedor"].ToString()));
                    dgvEntrada.Rows.Add(dr["id"].ToString(), dr["descricao"].ToString(),dr["fabricante"].ToString(),dr["categoria"].ToString(), dr["preco"].ToString(), fornecedor);
                }

            }
            catch (Exception ex)
            {
                frmErro.Mensagem("Erro : " + ex.Message);
            }
        }

        private void dgvEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          

            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvEntrada.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value);

                cl_Variaveis.frmentrada = null;
                cl_Variaveis.frmprodutoeditar = this;

                using (frmProdutos form = new frmProdutos())
                {
                    cl_Variaveis.frmentrada = null;
                    cl_Variaveis.frmprodutoeditar = this;
                    form.modo = 1;
                    form.IdProduto = id;
                    form.ShowDialog();
                }

            }
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvEntrada.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value);

                if (MessageBox.Show("Deseja excluir o selecionado?", "Informação", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ProdutosController.Delete(id);                
                }


            }
        }

           
        private string Pesquisa()
        {
            string resultado = "";

        
            switch (cmbPesquisa.Text)
            {
                case "Código de Barras":
                    resultado = "codbarra";
                    break;
                case "Produto":
                    resultado = "descricao";
                    break;
                case "Categoria":
                    resultado = "categoria";
                    break;
            }

            return resultado;

        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = ProdutosController.GetProduto(Pesquisa(), txtPesquisar.Text);
                ExibirDados(dt);
            }
            catch 
            {
            }
            
        }

        private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
        }
    }
}
