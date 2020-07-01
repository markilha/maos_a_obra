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
    public partial class frmOrdemEdita : Form
    {        
        public int IdEntrada;
        public frmOrdem frmordem = new frmOrdem();
        public frmOrdemEdita(frmOrdem Formulario)
        {
            InitializeComponent();
            frmordem = Formulario;
        }

        private void frmSaida_Load(object sender, EventArgs e)
        {
            try
            {
                ProdutosController.CarregaCombo(cmbProduto);
                FornecedorController.CarregaCombo(cmbFornecedor);
                Util.CarregaCombo("Entradas", "Comprador", cmbComprador);
                CarregaForme();

            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }

        private void CarregaForme()
        {
            try
            {
                EntradaModel en = EntradaController.GetEntradaModel(IdEntrada);
                ProdutosModel pm = ProdutosController.GetProdutoModel(en.ProdutoId);
                

                cmbFornecedor.Text = FornecedorController.GetStringfornecedor(en.FornecedorId);
                cmbComprador.Text = en.Comprador;
                cmbProduto.Text = pm.descricao;
                txtOrdem.Text = en.Ordem;
                txtData.Text = en.DataEntrada;
                txtPreco.Text = en.Preco;
                txtDesconto.Text =pm.desconto.ToString();
                txtComDesconto.Text = en.Desconto;
                txtQuantidade.Text = en.Quantidade.ToString();
                txtDescontoFinal.Text = en.DescontoTotal;
                lblTotal.Text = en.Total;

                DataTable produtos = ProdutosController.GetProdutos("SELECT DISTINCT categoria FROM Produtos;");

                cmbCategoria.Items.Clear();
                if (produtos.Rows.Count > 0)
                {
                    foreach (DataRow dr in produtos.Rows)
                    {
                        cmbCategoria.Items.Add(dr["categoria"].ToString());
                    }
                }

                cmbCategoria.Text = en.Categoria;

            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPreco_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                Somatorio();
            }
            catch
            {


            }
        }

        private void Somatorio()
        {
            double preco = Convert.ToDouble(txtPreco.Text);
            double quant = Convert.ToDouble(txtQuantidade.Text);
            double desconto = Calculo.Desconto(preco, Convert.ToDouble(txtDesconto.Text));
            txtComDesconto.Text = (quant * desconto).ToString("N2");
            lblTotal.Text = ((preco - desconto ) * quant).ToString("N2");
        }

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Somatorio();
            }
            catch
            {


            }
        }

        private void txtDesconto_KeyUp(object sender, KeyEventArgs e)
        {
            Somatorio();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int fornecedorid = FornecedorController.GetIdfornecedor(cmbFornecedor.Text);
                int produtoid = ProdutosController.GetIdProduto(cmbProduto.Text);

                EntradaModel em = new EntradaModel
                {
                    EntradaId = IdEntrada,
                    ProdutoId = produtoid,
                    FornecedorId = fornecedorid,
                    Ordem = txtOrdem.Text,
                    Quantidade = txtQuantidade.Text,
                    DataEntrada = DateTime.Parse(txtData.Text).ToString("yyyy/MM/dd"),
                    Preco = txtPreco.Text,
                    Desconto = txtComDesconto.Text,
                    Total = lblTotal.Text,
                    DescontoTotal = txtDescontoFinal.Text,
                    Categoria = cmbCategoria.Text,
                    Comprador = cmbComprador.Text                  
                };

                EntradaController.Update(em);
                frmordem.CarregaOrdem();

                frmSuccess.Mensagem("Atualizado com Sucesso!!!");
                this.Close();

            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }
    }
}
