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
    public partial class frmEntrada : Form
    {
        public ProdutosModel _produtoModel = new ProdutosModel();
        public frmEntrada()
        {
            InitializeComponent();
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime data = DateTime.Now.Date;
                txtData.Text = data.ToString("dd/MM/yyyy");
                CarregaFornecedores();
                txtOrdem.Text = EntradaController.GetUltimaOrdem();
                CarregaCampos();
                txtCodigoBarra.Focus();
                Util.CarregaCombo("Entradas", "Comprador", cmbComprador);
            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }

        }

        private void CarregaFornecedores()
        {
            try
            {
                cmbFornecedor.Items.Clear();
                DataTable fornecedores = FornecedorController.GetFornecedores();
                if (fornecedores.Rows.Count > 0)
                {

                    foreach (DataRow dr in fornecedores.Rows)
                    {
                        DataTable dt = FornecedorController.Getfornecedor(Convert.ToInt32(dr["Id"].ToString()));
                        string fornecedor = dt.Rows[0]["NomeFantasia"].ToString();
                        cmbFornecedor.Text = "";
                        cmbFornecedor.Items.Add(fornecedor);
                    }
                }

            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }

        public void CarregaCampos()
        {
            DataTable dts = FornecedorController.GetSqlfornecedores("select distinct NomeFantasia from Fornecedores order by NomeFantasia;");
            Util.AutoCompleta(dts, cmbFornecedor);

            DataTable dtd = ProdutosController.GetProdutos("select distinct descricao from Produtos order by descricao;");
            Util.AutoCompleta(dtd, txtDescricao);

            DataTable dtc = EntradaController.GetSqlEntradas("select distinct Categoria from Entradas order by Categoria;");
            Util.AutoCompleta(dtc, txtCategoria);

            DataTable dtco = EntradaController.GetSqlEntradas("select distinct Comprador from Entradas order by Comprador;");
            Util.AutoCompleta(dtco, cmbComprador);
        }


        private void txtDescricao_KeyUp(object sender, KeyEventArgs e)
        {
            //PesquisaProduto(txtDescricao,"descricao");
            if (e.KeyCode == Keys.Enter)
            {
                using (frmListaProduto frm = new frmListaProduto(this))
                {
                    frm.ShowDialog();
                }

                txtId.Text = _produtoModel.Id.ToString();
                txtCategoria.Text = _produtoModel.categoria;
                txtDescricao.Text = _produtoModel.descricao;
                txtPreco.Text = _produtoModel.preco;
                txtDesconto.Text = _produtoModel.desconto;
                txtFabricante.Text = _produtoModel.fabricante;


                txtQuantidade.Text = "";
                txtQuantidade.Focus();

            }
        }

        private void PesquisaProduto(TextBox textbox, string campo)
        {
            try
            {

                DataTable dt = ProdutosController.GetProduto(campo, textbox.Text);

                txtCategoria.Text = "";
                txtPreco.Text = "";
                txtDesconto.Text = "";
                txtId.Text = "";
                txtQuantidade.Text = "";
                txtFabricante.Text = "";

                if (dt.Rows.Count == 1)
                {

                    foreach (DataRow row in dt.Rows)
                    {
                        txtCategoria.Text = row["categoria"].ToString();
                        txtPreco.Text = row["preco"].ToString();
                        txtDesconto.Text = row["desconto"].ToString();
                        txtId.Text = row["id"].ToString();
                        txtFabricante.Text = row["fabricante"].ToString();
                        txtQuantidade.Text = "";
                    }

                }
                else
                {

                }

            }
            catch
            {
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSaida.Rows.Add(txtId.Text, txtQuantidade.Text, txtDescricao.Text, txtPreco.Text);
            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }

        private void txtQuantidade_MouseEnter(object sender, EventArgs e)
        {


        }

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    double quant = Convert.ToDouble(txtQuantidade.Text);
                    double preco = Convert.ToDouble(txtPreco.Text);
                    double desc = Convert.ToDouble(txtDesconto.Text);
                    string desconto = "0,00";
                    string subtotal = "0,00";

                    if (desc > 0)
                    {
                        desconto = (preco * (desc / 100)).ToString("N2");
                        desconto = (quant * Convert.ToDouble(desconto)).ToString("N2");
                    }

                    subtotal = ((preco * quant) - Convert.ToDouble(desconto)).ToString("N2");

                    dgvSaida.Rows.Add(txtId.Text, txtQuantidade.Text, txtDescricao.Text, txtFabricante.Text, txtCategoria.Text, txtPreco.Text, desconto, subtotal);

                    SomaSaida();
                    txtDescricao.Text = "";
                    txtDescricao.Select();
                }
                catch (Exception ex)
                {

                    frmErro.Mensagem(ex.Message);
                }


            }

        }

        private string SomaSaida()
        {
            string saida = "0,00";

            if (dgvSaida.Rows.Count > 0)
            {
                double TotalSemDesconto = 0;
                double SubTotal = 0;
                double Desconto = 0;

                //TotalaPagar = 0;

                foreach (DataGridViewRow dt in dgvSaida.Rows)
                {
                    double preco = Convert.ToDouble(dt.Cells["preco2"].Value.ToString());
                    double quant = Convert.ToDouble(dt.Cells["quantidade"].Value);

                    Desconto += Convert.ToDouble(dt.Cells["desconto"].Value);
                    SubTotal += Convert.ToDouble(dt.Cells["subtotal"].Value);
                    TotalSemDesconto += (preco * quant);

                    txtSubTotal.Text = TotalSemDesconto.ToString("N2");
                    txtDesc.Text = Desconto.ToString("N2");
                    txtTotal.Text = (TotalSemDesconto - Desconto).ToString("N2");
                    saida = txtTotal.Text;
                }
            }
            else
            {
                txtSubTotal.Text = "0,00";
                txtDesc.Text = "0,00";
                txtTotal.Text = "0,00";
                saida = "0,00";
            }

            return saida;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = DialogResult;

                using (frmErro form = new frmErro("Deseja Realmente fechar a compra?"))
                {
                    resultado = form.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        if (cmbFornecedor.Text.Length < 3)
                        {
                            frmSuccess.Mensagem("Favor Cadastrar um Fornecedor!!!!");
                            return;
                        }

                        if (txtData.Text.Length < 3)
                        {
                            frmSuccess.Mensagem("Favor Cadastrar uma Data!!!");
                            return;
                        }
                        if (dgvSaida.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow dt in dgvSaida.Rows)
                            {
                                int fornecedor = FornecedorController.GetIdfornecedor(cmbFornecedor.Text);

                                EntradaModel em = new EntradaModel();
                                em.ProdutoId = Convert.ToInt32(dt.Cells["id2"].Value);
                                em.FornecedorId = fornecedor;
                                em.Ordem = txtOrdem.Text;
                                em.Quantidade = dt.Cells["quantidade"].Value.ToString();
                                em.DataEntrada = DateTime.Parse(txtData.Text).ToString("yyyy/MM/dd");
                                em.Preco = dt.Cells["preco2"].Value.ToString();
                                em.Desconto = dt.Cells["Desconto"].Value.ToString();
                                em.Total = dt.Cells["subtotal"].Value.ToString();
                                em.DescontoTotal = txtDescontoTotal.Text;
                                em.Categoria = dt.Cells["Categoria"].Value.ToString();
                                em.Comprador = cmbComprador.Text.ToUpper();

                                EntradaController.Add(em);
                            }
                            dgvSaida.Rows.Clear();

                        }

                        txtOrdem.Text = EntradaController.GetUltimaOrdem();

                    }

                }

            }
            catch (Exception ex)
            {
                frmSuccess.Mensagem("Ocorreu erro ao executar a finalização da compra: " + ex);
            }
        }

        private void txtOrdem_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnOrdem_Click(object sender, EventArgs e)
        {
            using (frmOrdem form = new frmOrdem())
            {
                form.ShowDialog();
            }
        }

        private void cmbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvSaida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8 && e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvSaida.Rows[e.RowIndex];
                    cl_Variaveis.Quantidade = row.Cells["quantidade"].Value.ToString();
                    cl_Variaveis.Produto = row.Cells["descricao2"].Value.ToString();
                    cl_Variaveis.Preco = row.Cells["preco2"].Value.ToString();

                    using (frmEditaEntrada form = new frmEditaEntrada())
                    {
                        form.ShowDialog();
                    }

                    row.Cells["quantidade"].Value = cl_Variaveis.Quantidade.ToString();
                    row.Cells["descricao2"].Value = cl_Variaveis.Produto;
                    row.Cells["preco2"].Value = cl_Variaveis.Preco;
                    dgvSaida.Update();
                    SomaSaida();
                }

                if (e.ColumnIndex == 9 && e.RowIndex >= 0)
                {
                    DialogResult resultado = new DialogResult();
                    frmErro form = new frmErro("Esta certo de excluir esta entrada?");
                    resultado = form.ShowDialog();

                    DataGridViewRow row = this.dgvSaida.Rows[e.RowIndex];

                    if (resultado == DialogResult.OK)
                    {
                        dgvSaida.Rows.RemoveAt(e.RowIndex);
                        dgvSaida.Update();
                        SomaSaida();
                    }


                }

            }
            catch (Exception ex)
            {
                frmErro.Mensagem("Ocorreu um erro ao Excluir: " + ex);
            }
        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            using (frmProdutos form = new frmProdutos())
            {
                cl_Variaveis.frmentrada = this;
                cl_Variaveis.frmprodutoeditar = null;
                form.modo = 0;
                form.ShowDialog();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtData.Text = dateTimePicker1.Value.ToShortDateString();

        }

        private void frmEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void frmEntrada_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void panelentrada_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ExibirGrupos(GroupBox grupo)
        {
            grupoEntrada.Location = new Point(17, 2300);
            grupo.Location = new Point(17, 230);
            grupo.Size = new Size(694, 415);
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUtil_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            using (frmFornecedor frm = new frmFornecedor(null, true))
            {
                frm.ShowDialog();
            }

            CarregaFornecedores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ProdutosController.GetIdProduto(txtDescricao.Text);
                cl_Variaveis.frmentrada = this;
                cl_Variaveis.frmprodutoeditar = null;
                using (frmProdutos form = new frmProdutos())
                {
                    form.IdProduto = id;
                    form.modo = 1;
                    form.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                frmErro form = new frmErro("Ocorreu um erro ao tentar editar o produto: " + ex.Message);
            }

        }



        private void txtDescontoTotal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                if (dgvSaida.Rows.Count > 0)
                {
                    foreach (DataGridViewRow dt in dgvSaida.Rows)
                    {
                        double quantidade = Convert.ToDouble(dt.Cells["quantidade"].Value.ToString());
                        double desc = Convert.ToDouble(txtDescontoTotal.Text);
                        double preco = Convert.ToDouble(dt.Cells["preco2"].Value.ToString());

                        string desconto = "";
                        double total = 0;

                        desconto = ((preco * desc) / 100).ToString("N2");
                        desconto = (quantidade * Convert.ToDouble(desconto)).ToString("N2");

                        total = (quantidade * preco) - Convert.ToDouble(desconto);

                        dt.Cells["Desconto"].Value = desconto;
                        dt.Cells["subtotal"].Value = total.ToString("N2");
                        SomaSaida();
                    }
                }

            }
            catch
            {

            }
        }

        private void txtCodigoBarra_KeyUp(object sender, KeyEventArgs e)
        {
            PesquisaProduto(txtCodigoBarra, "codbarra");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }      
    }
}
