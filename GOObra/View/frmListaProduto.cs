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
    public partial class frmListaProduto : Form
    {
        DataTable dt = new DataTable();
        frmEntrada _entrada = new frmEntrada();
        public frmListaProduto(frmEntrada frm)
        {
            InitializeComponent();
            _entrada = frm;

        }

        private void frmListaProduto_Load(object sender, EventArgs e)
        {
            txtPesquisa.Select();

        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvProduto.Focus();
                }
                else
                {
                    dt = ProdutosController.GetProduto("Descricao", txtPesquisa.Text);

                    ExibirDados(dt);
                }

                if (e.KeyCode == Keys.Down)
                {
                    dgvProduto.Focus();
                }



            }
            catch
            {


            }

        }


        public void ExibirDados(DataTable dt)
        {
            try
            {
                dgvProduto.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string fornecedor = FornecedorController.GetStringfornecedor(Convert.ToInt32(dr["fornecedor"].ToString()));
                    dgvProduto.Rows.Add(dr["id"].ToString(), dr["descricao"].ToString(), dr["fabricante"].ToString(), fornecedor, dr["preco"].ToString());
                }

            }
            catch (Exception ex)
            {
                frmErro.Mensagem("Erro : " + ex.Message);
            }
        }

        private void dgvEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value.ToString());
                _entrada._produtoModel = ProdutosController.GetProdutoModel(id);
                this.Close();

            }


            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                ProdutosModel pm = new ProdutosModel();
                pm = ProdutosController.GetProdutoModel(id);

                using (frmProdutos form = new frmProdutos())
                {
                    cl_Variaveis.frmentrada = null;
                    cl_Variaveis.frmprodutoeditar = null;

                    form.IdProduto = id;
                    form.modo = 1;
                    form.ShowDialog();
                }

            }
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value);

                if (MessageBox.Show("Deseja excluir o selecionado?", "Informação", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ProdutosController.Delete(id);
                    DataTable dt = ProdutosController.GetProdutos();
                    ExibirDados(dt);
                }


            }
        }

        private void dgvEntrada_KeyUp(object sender, KeyEventArgs e)
        {

            //TODO: PRODUTO
            if (e.KeyCode == Keys.Enter)
            {
            
                if (dgvProduto.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow r in dgvProduto.SelectedRows)
                    {                      

                        int id = Convert.ToInt32(r.Cells["id"].Value.ToString());
                        _entrada._produtoModel = ProdutosController.GetProdutoModel(id);
                        
                        this.Close();

                    }
                }

            }
        }

        private void dgvProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl_Variaveis.frmentrada = null;
            cl_Variaveis.frmprodutoeditar = null;

            using (frmProdutos form = new frmProdutos())
            {
                form.modo = 0;
                form.ShowDialog();
            }
        }
    }
}
