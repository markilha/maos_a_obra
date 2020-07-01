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
    public partial class frmAlterarBanco : Form
    {
        public frmAlterarBanco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"UPDATE {cmbTabelas.Text} SET {cmbCampos.Text} = REPLACE({cmbCampos.Text},'{cmbTextoAtual.Text}','{txtTextoReplace.Text}');";
                if (Util.replaceCampo(sql) == 11)
                {
                    MessageBox.Show("Atualizado com sucesso!!!!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro!!!!");
                }
            }
            catch (Exception ex)
            {
                frmErro form = new frmErro("Ocorreu um erro: " + ex.Message);
            }
        }

        private void frmAlterarBanco_Load(object sender, EventArgs e)
        {

        }

        private void cmbTabelas_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                cmbCampos.Items.Clear();

                switch (cmbTabelas.Text)
                {
                    case "Entradas":
                        cmbCampos.Items.Add("ProdutoId");
                        cmbCampos.Items.Add("Quantidade");
                        cmbCampos.Items.Add("DataEntrada");
                        cmbCampos.Items.Add("Preco");
                        cmbCampos.Items.Add("Total");
                        cmbCampos.Items.Add("Ordem");
                        cmbCampos.Items.Add("FornecedorId");
                        cmbCampos.Items.Add("Desconto");
                        cmbCampos.Items.Add("DescontoTotal");
                        cmbCampos.Items.Add("Categoria");
                        break;
                    case "Produtos":
                        cmbCampos.Items.Add("codbarra");
                        cmbCampos.Items.Add("descricao");
                        cmbCampos.Items.Add("quantidade");
                        cmbCampos.Items.Add("preco");
                        cmbCampos.Items.Add("fornecedor");
                        cmbCampos.Items.Add("desconto");
                        cmbCampos.Items.Add("imagem");
                        cmbCampos.Items.Add("categoria");
                        break;
                    case "Fornecedores":
                        cmbCampos.Items.Add("NomeFantasia");
                        break;
                }


            }
            catch (Exception Ex)
            {

                frmErro frm = new frmErro("Ocorreu um erro: " + Ex.Message);
            }

        }

        private void cmbCampos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbTextoAtual.Items.Clear();
                DataTable dt = Util.GetDados($"SELECT {cmbCampos.Text} FROM {cmbTabelas.Text} ORDER BY {cmbCampos.Text};");

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbTextoAtual.Items.Add(dr[cmbCampos.Text].ToString());
                    }
                }

            }
            catch (Exception Ex)
            {

                frmErro frm = new frmErro("Ocorreu um erro: " + Ex.Message);
            }
        }
    }
}
