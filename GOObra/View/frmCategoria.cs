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
    public partial class frmCategoria : Form
    {
        public bool modoNovo = false;
        //frmListaFornecedores formFornecedor = new frmListaFornecedores();
        public int Id = 0;

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriaModel fm = new CategoriaModel();
                fm.nome = txtCategoria.Text.ToUpper();
                CategoriaController.Add(fm);
                frmSuccess.Mensagem("Categoria Inserida com Sucesso!!!");
                this.Close();


                if (modoNovo == true)
                {
                    
                }
                else
                {
                    //CategoriaModel fm = new CategoriaModel();
                    //fm.Id = Id;
                    //fm.nome = txtCategoria.Text;
                    //FornecedorController.Update(fm);
                    //frmSuccess.Mensagem("Fonecedor Atualizado com Sucesso!!!");
                    //DataTable dt = FornecedorController.GetFornecedores();
                    //formFornecedor.ExibirDados(dt);
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                frmErro.Mensagem("Ops! Ocorreu um erro: " + ex);
            }
        }
    }
}
