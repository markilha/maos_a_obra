using GOObra.Controller;
using GOObra.Model;
using GOObra.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOObra.View
{
    public partial class frmOrdem : Form
    {
        public frmOrdem()
        {
            InitializeComponent();
        }

        private void frmOrdem_Load(object sender, EventArgs e)
        {
            try
            {
                txtOrdem.Focus();
                this.dgvOrdem.Columns["Preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dgvOrdem.Columns["Desconto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dgvOrdem.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Util.CarregaCombo("Fornecedores", "NomeFantasia", cmbFornecedor);
                Util.CarregaCombo("Entradas", "Comprador", cmbComprador);
                Util.CarregaCombo("Entradas", "Categoria", cmbCategoria);

            }
            catch (Exception ex)
            {
                frmErro frm = new frmErro("Ocorreu um erro: " + ex.Message);
            }


        }

        private void txtOrdem_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                CarregaOrdem();
            }
            catch
            {
            }
        }

        public void CarregaOrdem()
        {
            try
            {

                DataTable dt = EntradaController.Consulta(new List<string> { "ORDEM" }, new List<string> { txtOrdem.Text });
                ExibirEntradas(dt);
                SomaSaida();
            }
            catch 
            {
               
            }

        }
        //public void CarregaOrdem()
        //{
        //    try
        //    {
        //        string sql = "";
        //        if (txtOrdem.Text == "#")
        //        {
        //            sql = $"SELECT * FROM Entradas ORDER BY Ordem;";
        //        }
        //        else
        //        {
        //            sql = $"SELECT * FROM Entradas where Ordem ='{txtOrdem.Text}'";
        //        }

        //        DataTable dt = EntradaController.GetEntradas(sql);
        //        ExibirEntradas(dt);

        //        SomaSaida();
        //    }
        //    catch (Exception ex)
        //    {
        //        frmErro.Mensagem(ex.Message);
        //    }

        //}

        public void ExibirEntradas(DataTable dt)
        {
            try
            {
                dgvOrdem.Rows.Clear();

                foreach (DataRow dr in dt.Rows)
                {                                
                    txtDescontoSobreTotal.Text = dr["DescontoTotal"].ToString();
                    string data = DateTime.Parse(dr["DataEntrada"].ToString()).ToString("yyy/MM/dd");

                    dgvOrdem.Rows.Add(dr["EntradaId"].ToString(), dr["Ordem"].ToString(), dr["NomeFantasia"].ToString(), dr["Quantidade"].ToString(), dr["Descricao"].ToString(), dr["Categoria"].ToString(), data, dr["Preco"].ToString(), dr["Desconto"].ToString(), dr["Total"].ToString());
                }

            }
            catch (Exception ex)
            {
                frmErro.Mensagem("Erro : " + ex.Message);
            }
        }

        //public void ExibirEntradas(DataTable dt)
        //{
        //    try
        //    {
        //        dgvOrdem.Rows.Clear();
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            try
        //            {
        //                DataTable tf = FornecedorController.Getfornecedor(Convert.ToInt32(dr["FornecedorId"].ToString()));

        //                if (tf.Rows.Count > 0)
        //                {
        //                    txtFornecedor.Text = tf.Rows[0]["NomeFantasia"].ToString();

        //                }
        //            }
        //            catch { }

        //            int id = Convert.ToInt32(dr["ProdutoId"].ToString());
        //            txtDescontoSobreTotal.Text = dr["DescontoTotal"].ToString();

        //            string descricao = "";
        //            try { descricao = ProdutosController.GetStringProduto(id); } catch { }

        //            dgvOrdem.Rows.Add(dr["EntradaId"].ToString(), dr["Ordem"].ToString(), dr["Quantidade"].ToString(), descricao, dr["Categoria"].ToString(), dr["DataEntrada"].ToString(), dr["Preco"].ToString(), dr["Desconto"].ToString(), dr["Total"].ToString());
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        frmErro.Mensagem("Erro : " + ex.Message);
        //    }
        //}
        private void SomaSaida()
        {
            //TODO:paradoaqui
            if (dgvOrdem.Rows.Count > 0)
            {
                double subTotal = 0;                
                double desconto = 0;
                double totalQuantidade = 0;

                foreach (DataGridViewRow dt in dgvOrdem.Rows)
                {
                    double preco = 0;
                    double desc = 0;
                    double quant = 0;

                    if (dt.Cells["Total"].Value.ToString().Length > 0)
                    {
                        preco = Convert.ToDouble(dt.Cells["Preco"].Value.ToString());
                        quant = Convert.ToDouble(dt.Cells["quantidade"].Value.ToString());
                        preco = quant * preco;
                    }
                    if (dt.Cells["Desconto"].Value.ToString().Length > 0)
                    {
                        desc = Convert.ToDouble(dt.Cells["Desconto"].Value.ToString());
                    }

                    subTotal += preco;
                    desconto += desc;
                    totalQuantidade += quant;
                   
                }

                txtSubTotal.Text = "R$ " + subTotal.ToString("N2");
                txtTotalDesc.Text = "R$ " + desconto.ToString("N2");
                txtTotal.Text = "R$ " + (subTotal - desconto).ToString("N2");
                txtQuantidade.Text = totalQuantidade.ToString("N2") + " Unidades";
            }
            else
            {
                txtTotalDesc.Text = "0,00";
                txtTotal.Text = "0,00";

            }
        }

        private void dgvOrdem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 10 && e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvOrdem.Rows[e.RowIndex];

                    using (frmOrdemEdita form = new frmOrdemEdita(this))
                    {
                        form.IdEntrada = Convert.ToInt32(row.Cells["EntradaId"].Value);
                        form.ShowDialog();
                    }

                    CarregaOrdem();

                }

                if (e.ColumnIndex == 11 && e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvOrdem.Rows[e.RowIndex];
                    if (MessageBox.Show("Deseja excluir o item selecionada?", "Informação,", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        int id = Convert.ToInt32(row.Cells["EntradaId"].Value);
                        dgvOrdem.Rows.RemoveAt(e.RowIndex);
                        dgvOrdem.Update();
                        SomaSaida();
                        EntradaController.Delete(id);
                    }


                }

            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }

        private void txtDescontoTotal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SomaSaida();

            }
            catch
            {

            }
        }
         
       

        private void txtData_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = EntradaController.GetEntradas("DataEntrada", txtData.Text);
                ExibirEntradas(dt);
                SomaSaida();
            }
            catch
            {


            }

        }

        private void cmbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = FornecedorController.GetIdfornecedor(cmbFornecedor.Text);
                DataTable dt = EntradaController.GetEntradas($"SELECT * FROM Entradas WHERE FornecedorId ={id} ORDER BY DataEntrada;");
                ExibirEntradas(dt);
                SomaSaida();

            }
            catch (Exception ex)
            {
                frmErro frm = new frmErro("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnatualiza_Click(object sender, EventArgs e)
        {
            try
            {
                //dgvOrdem.Rows.Add(dr["EntradaId"].ToString(), dr["Ordem"].ToString(), descricao, dr["Categoria"].ToString(), dr["Quantidade"].ToString(), dr["DataEntrada"].ToString(), dr["Preco"].ToString(), dr["Desconto"].ToString(), dr["Total"].ToString());
                if (dgvOrdem.Rows.Count > 0)
                {
                    foreach (DataGridViewRow dt in dgvOrdem.Rows)
                    {
                        int entradaid = Convert.ToInt32(dt.Cells["EntradaId"].Value.ToString());
                        double quantidade = Convert.ToDouble(dt.Cells["quantidade"].Value.ToString());
                        double desc = Convert.ToDouble(txtDescontoSobreTotal.Text);
                        double preco = Convert.ToDouble(dt.Cells["Preco"].Value.ToString());
                        string desconto = "";
                        double total = 0;
                        desconto = ((preco * desc) / 100).ToString("N2");
                        total = quantidade * (preco - Convert.ToDouble(desconto));

                        DalHelper.ExecutaQuery($"UPDATE Entradas SET Desconto = '{desconto.ToString()}', Total = '{total.ToString()}', DescontoTotal = '{txtDescontoSobreTotal.Text.ToString()}' WHERE EntradaId = {entradaid};");
                    }
                }

                CarregaOrdem();
            }
            catch (Exception ex)
            {
                frmErro frm = new frmErro("Ocorreu um erro ao atualizar: " + ex.Message);
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<string> Campos = new List<string>();
            List<string> Valores = new List<string>();

            if (txtOrdem.Text.Length > 0)
            {
                Campos.Add("Ordem");
                Valores.Add(txtOrdem.Text);
            }
            if (cmbCategoria.Text.Length > 0)
            {
                Campos.Add("T.Categoria");
                Valores.Add(cmbCategoria.Text);
            }

            if (cmbComprador.Text.Length > 0)
            {
                Campos.Add("Comprador");
                Valores.Add(cmbComprador.Text);
            }

            if (cmbFornecedor.Text.Length > 0)
            {
                Campos.Add("NomeFantasia");
                Valores.Add(cmbFornecedor.Text);
            }

            ExibirEntradas(EntradaController.Consulta(Campos, Valores));
            SomaSaida();

        }

        private void btnOrdem_Click(object sender, EventArgs e)
        {
            try
            {
                //string sql = $"UPDATE Entradas SET Comprador = '{cmbComprador.Text}' WHERE Ordem = '{txtOrdem.Text}' ";
                string sql = txtSql.Text;

                using (var cmb = new SQLiteCommand(DalHelper.DbConnection()))
                {
                    cmb.CommandText = sql;
                    cmb.ExecuteNonQuery();

                }
                MessageBox.Show("Atualizado com sucesso!!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
        }

        private void btnAtualizarComprador_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"UPDATE Entradas SET Comprador = '{cmbComprador.Text}' WHERE Ordem = '{txtOrdem.Text}' ";                

                using (var cmb = new SQLiteCommand(DalHelper.DbConnection()))
                {
                    cmb.CommandText = sql;
                    cmb.ExecuteNonQuery();

                }
                MessageBox.Show("Atualizado com sucesso!!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtProduto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = EntradaController.GetEntradas("R.DESCRICAO", txtProduto.Text);
                ExibirEntradas(dt);
                SomaSaida();
            }
            catch
            {


            }
        }
    }
}
