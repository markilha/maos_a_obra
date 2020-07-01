using GOObra.Controller;
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
    public partial class frmListaFornecedores : Form
    {
        public frmListaFornecedores()
        {
            InitializeComponent();
        }

        private void frmListaFornecedores_Load(object sender, EventArgs e)
        {
            DataTable dt = FornecedorController.GetFornecedores();
            ExibirDados(dt);
            txtFornecedor.Focus();
        }

        public void ExibirDados(DataTable dt)
        {
            try
            {
                dgvFornecedor.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvFornecedor.Rows.Add(dr["Id"].ToString(), dr["NomeFantasia"].ToString());
                }

            }
            catch (Exception ex)
            {
                frmErro.Mensagem("Erro : " + ex.Message);
            }
        }

        private void txtFornecedor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = FornecedorController.Getfornecedores(txtFornecedor.Text);
                ExibirDados(dt);
            }
            catch
            {

            }

        }

        private void dgvFornecedor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2 && e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvFornecedor.Rows[e.RowIndex];
                    int id = Convert.ToInt32(row.Cells["id"].Value);

                    using (frmFornecedor form = new frmFornecedor(this,false))
                    {
                        form.Id = id;
                        form.ShowDialog();
                    }

                }
                if (e.ColumnIndex == 3 && e.RowIndex >= 0)
                {
                    DialogResult resultado = new DialogResult();
                    DataGridViewRow row = this.dgvFornecedor.Rows[e.RowIndex];
                    int id = Convert.ToInt32(row.Cells["id"].Value);

                    using (frmErro frm = new frmErro("Deseja realmente excluir o fornecedor selecionado?"))
                    {
                        resultado = frm.ShowDialog();
                        if (resultado == DialogResult.OK)
                        {
                            FornecedorController.Delete(id);
                            DataTable dt = FornecedorController.GetFornecedores();
                            ExibirDados(dt);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                frmErro.Mensagem("Ocorreu um erro na edição ou exclusão do fornecedor: " + ex);
            }
          
        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
