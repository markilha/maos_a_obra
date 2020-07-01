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
    public partial class frmNovaEntrada : MetroFramework.Forms.MetroForm
    {
        DataTable TodasDescricao = new DataTable();
        public frmNovaEntrada()
        {
            InitializeComponent();
        }

        private void frmNovaEntrada_Load(object sender, EventArgs e)
        {
            txtDescricao.Focus();
            TodasDescricao = ProdutosController.GetDescricao();
            AutoCompleta(TodasDescricao, txtDescricao);
        }

        private void txtDescricao_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {


            }
            catch 
            {              
            }
        }

       
        public static void AutoCompleta(DataTable Tabela, TextBox textobox)
        {
            var source = new AutoCompleteStringCollection();

            for (int i = 0; i < Tabela.Rows.Count; i++)
            {
                source.Add(Tabela.Rows[i][0].ToString());
            }

            textobox.AutoCompleteCustomSource = source;
            textobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textobox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public static void AutoCompleta(DataTable Tabela, MetroFramework.Controls.MetroTextBox textobox)
        {
            var source = new AutoCompleteStringCollection();

            for (int i = 0; i < Tabela.Rows.Count; i++)
            {
                source.Add(Tabela.Rows[i][0].ToString());
            }

            textobox.AutoCompleteCustomSource = source;
            textobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textobox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //ProdutosModel pm = new ProdutosModel();
                //pm.CodigoBarra = txtCodigoBarra.Text;
                //pm.Descricao = txtDescricao.Text;
                //pm.Preco = txtPreco.Text;
                //pm.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                //ProdutosController.Add(pm);

                //frmErro.Mensagem("Feito");

            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }
    }
}
