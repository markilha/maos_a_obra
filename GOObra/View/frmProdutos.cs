using GOObra.Controller;
using GOObra.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOObra.View
{
    public partial class frmProdutos : Form
    {
        public int modo = 0;
        public int IdProduto;       
        private string caminhoImagem = "";

        public frmProdutos()
        {
            InitializeComponent(); 
        }
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            Ativa();
            FornecedorController.CarregaCombo(cmbFornecedor);

            if (modo == 0)
            {
                CarregaCategoria();
            }
            else
            {
                ExibirDados();
            }

            DataTable dt = FornecedorController.GetSqlfornecedores("select distinct NomeFantasia from Fornecedores order by NomeFantasia;");
            Util.AutoCompleta(dt, cmbFornecedor);
            Util.CarregaCombo("Produtos", "fabricante", cmbFabricante);

        }

        private void Ativa()
        {
            txtCodigoBarra.Enabled = true;
            txtDescricao.Enabled = true;
            txtPreco.Enabled = true;
        }
        private void Desativa()
        {
            txtCodigoBarra.Enabled = false;
            txtDescricao.Enabled = false;
            txtPreco.Enabled = false;
        }
        private bool Valida()
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ExibirDados()
        {
            try
            {               
                ProdutosModel pm = ProdutosController.GetProdutoModel(IdProduto);
                string fornecedor = FornecedorController.GetStringfornecedor(pm.fornecedor);
                txtCodigoBarra.Text = pm.codbarra;
                cmbFornecedor.Text = fornecedor;
                txtDescricao.Text = pm.descricao;
                txtDesconto.Text = pm.desconto.ToString();
                txtPreco.Text = pm.preco.ToString();
                cmbFabricante.Text = pm.fabricante.ToString();

                if(pm.imagem.Length > 3)
                {
                    pbImagem.Load(pm.imagem);
                    pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
                    caminhoImagem = pm.imagem;
                }

                CarregaCategoria();
                cmbCategoria.Text = pm.categoria;

            }
            catch (Exception ex)
            {
                frmErro.Mensagem("Erro : " + ex.Message);
            }
        }

        private void CarregaCategoria()
        {
            DataTable produtos = ProdutosController.GetProdutos("SELECT DISTINCT categoria FROM Produtos;");

            cmbCategoria.Items.Clear();
            if (produtos.Rows.Count > 0)
            {
                foreach (DataRow dr in produtos.Rows)
                {
                    cmbCategoria.Items.Add(dr["categoria"].ToString());
                }
            }            
        }

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = FornecedorController.GetIdfornecedor(cmbFornecedor.Text);

                ProdutosModel pm = new ProdutosModel();
                pm.Id = IdProduto;
                pm.codbarra = txtCodigoBarra.Text;
                pm.descricao = txtDescricao.Text;
                pm.preco = txtPreco.Text;
                pm.fornecedor = id;
                pm.desconto = txtDesconto.Text;
                pm.imagem = caminhoImagem;
                pm.categoria = cmbCategoria.Text.ToUpper();
                pm.fabricante = cmbFabricante.Text.ToUpper() ;

                if (modo == 0)
                {
                    ProdutosController.Add(pm);
                    frmSuccess.Mensagem("Cadastro Inserido com Sucesso!!!");
                    Desativa();
                }
                else
                {
                    ProdutosController.Update(pm);
                    frmSuccess.Mensagem("Cadastro Atualizado com sucesso!!!");
                    Desativa();
                    DataTable dt = ProdutosController.GetProdutos();

                    if (cl_Variaveis.frmprodutoeditar != null)
                    {
                        cl_Variaveis.frmprodutoeditar.ExibirDados(dt);

                    }
                    if (cl_Variaveis.frmentrada != null)
                    {
                        cl_Variaveis.frmentrada.CarregaCampos();
                    }

                }
                btnSalvar.Enabled = false;
                this.Close();

            }
            catch (Exception ex)
            {
                frmErro.Mensagem("Erro : " + ex.Message);
            }
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\Imagem\";

                string caminho = "";
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Arquivos imagem|*.jpg|Arquivos PNG|*.png";
                fileDialog.InitialDirectory = path;
                fileDialog.Title = "Escolha uma imagem!!";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminho = fileDialog.FileName;
                }

                caminhoImagem = caminho;
                pbImagem.Load(caminho);
                pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
