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
    public partial class frmFornecedor : Form
    {
        public bool modoNovo = false;
        frmListaFornecedores formFornecedor = new frmListaFornecedores();
        public int Id = 0;
        public frmFornecedor(frmListaFornecedores formulario, bool modo)
        {
            InitializeComponent();
            modoNovo = modo;
            formFornecedor = formulario;
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            if(modoNovo == true)
            {
                limpaCampos();
            }else
            {
                DataTable dt = FornecedorController.Getfornecedor(Id);
                if(dt.Rows.Count > 0)
                {
                    txtNome.Text = dt.Rows[0]["NomeFantasia"].ToString();
                    
                }

            }
        }

        private void limpaCampos()
        {
            txtNome.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (modoNovo == true)
                {
                    FornecedorModel fm = new FornecedorModel();
                    fm.NomeFantasia = txtNome.Text.ToUpper();
                    FornecedorController.Add(fm);
                    frmSuccess.Mensagem("Fonecedor Inserido com Sucesso!!!");
                    this.Close();
                }
                else
                {
                    FornecedorModel fm = new FornecedorModel();
                    fm.Id = Id;
                    fm.NomeFantasia = txtNome.Text;
                    FornecedorController.Update(fm);                
                    frmSuccess.Mensagem("Fonecedor Atualizado com Sucesso!!!");
                    DataTable dt = FornecedorController.GetFornecedores();                    
                    formFornecedor.ExibirDados(dt);
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
