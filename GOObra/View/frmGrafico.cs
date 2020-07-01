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
    public partial class frmGrafico : Form
    {
        public int modoConsulta = 0;
        public frmGrafico(int consulta)
        {
            InitializeComponent();
            modoConsulta = consulta;
        }

        private void frmGrafico_Load(object sender, EventArgs e)
        {
            check3d.Checked = false;

            switch (modoConsulta)
            {
                case 0:
                    Consulta("FornecedorId", true);
                    break;
                case 1:
                    Consulta("Ordem", false);
                    break;
                case 2:
                    Consulta("ProdutoId", true);
                    break;
                case 3:
                    Consulta("Categoria", false);
                    break;
                case 4:
                    MaoObraMaterial();
                    break;
                case 5:
                    Variacao();
                    break;
                case 6:
                    Consulta("Comprador", false);
                    break;

            }

        }

        private void MaoObraMaterial()
        {
            List<string> lista = new List<string>();

            lista = EntradaController.GetLista("Categoria");
            double TotalMo = 0;
            double TotalMa = 0;
            double Total = TotalGastro();

            if (lista.Count > 0)
            {
                foreach (string item in lista)
                {
                    DataTable valores = EntradaController.GetSqlEntradas($"SELECT Total FROM Entradas WHERE Categoria = '{item}' ORDER BY Categoria");

                    if (valores.Rows.Count > 0)
                    {
                        foreach (DataRow dr in valores.Rows)
                        {                            

                            if (item == "Mão de Obra")
                            {
                                if (dr["Total"].ToString().Length > 0)
                                {
                                    TotalMo += Convert.ToDouble(dr["Total"].ToString());
                                }

                            }
                            else
                            {
                                if (dr["Total"].ToString().Length > 0)
                                {
                                    TotalMa += Convert.ToDouble(dr["Total"].ToString());
                                }

                            }
                        }
                    }

                }


                Grafico.Series["ChartValores"].Label = "#PERCENT";
                Grafico.Series["ChartValores"].Points.AddXY("Mão de Obra", Util.Porcentagem(TotalMo,Total));
                Grafico.Series["ChartValores"].Points.AddXY("Materiais", Util.Porcentagem(TotalMa, Total));

            }

            Grafico.Titles["Titulo"].Text = $"Total gasto: R$ {Total.ToString("N2")}";
        }


        private void Consulta(string Campo, bool busca)
        {
            List<string> lista = new List<string>();
            lista = EntradaController.GetLista(Campo);
           double Total = TotalGastro();
         


            if (lista.Count > 0)
            {
                foreach (string item in lista)
                {
                    double valor = 0;
                    DataTable valores = EntradaController.GetSqlEntradas($"SELECT Total FROM Entradas WHERE {Campo} = '{item}' ORDER BY {Campo}");
                    string eixoY = item;

                    #region Busca
                    if (busca == true)
                    {
                        switch (Campo)
                        {
                            case "FornecedorId":
                                eixoY = EntradaController.GetString($"SELECT NomeFantasia FROM Fornecedores where Id ='{item}'", "NomeFantasia");
                                break;
                            case "ProdutoId":
                                eixoY = EntradaController.GetString($"SELECT descricao FROM Produtos where id ='{item}'", "descricao");
                                break;
                        }
                    }
                    #endregion


                    if (valores.Rows.Count > 0)
                    {
                        valor = 0;
                        foreach (DataRow dr in valores.Rows)
                        {
                            if (dr["Total"].ToString().Length > 0)
                            {
                                valor += Convert.ToDouble(dr["Total"].ToString());
                            }

                        }
                    }

                    double porcentagem = Util.Porcentagem(valor, Total);
                    Grafico.Series["ChartValores"].Label = "#PERCENT";
                    Grafico.Series["ChartValores"].Points.AddXY(eixoY, porcentagem);

                }
            }

            Grafico.Titles["Titulo"].Text = $"Total gasto: R$ {Total.ToString("N2")}";

        }

        private double TotalGastro()
        {
            double Total = 0;
            DataTable totais = EntradaController.GetSqlEntradas($"SELECT Total FROM Entradas;");

            if (totais.Rows.Count > 0)
            {
                foreach (DataRow dr in totais.Rows)
                {
                    double valor = Convert.ToDouble(dr["Total"].ToString());
                    Total += valor;
                }
            }
            return Total;
        }

        private void Variacao()
        {
            try
            {
                DataTable dt = EntradaController.GetSqlEntradas("SELECT ProdutoId, preco FROM Entradas ORDER by ProdutoId");


                if (dt.Rows.Count > 0)
                {
                    string descricaoAnt = "";
                    double precoAnt = 0;
                    double Varicao = 0;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string descricao = ProdutosController.GetStringProduto((int)dt.Rows[i]["ProdutoId"]);
                        double Preco = Convert.ToDouble(dt.Rows[i]["Preco"].ToString());

                        if (i > 0)
                        {
                            if (descricao == descricaoAnt)
                            {
                                Varicao = ((Preco - precoAnt) / precoAnt) * 100;

                                if (Varicao > 0)
                                {
                                    Grafico.Series["ChartValores"].Label = "#PERCENT";
                                    Grafico.Series["ChartValores"].Points.AddXY(descricao, Varicao);
                                }

                            }

                            descricaoAnt = descricao;
                            precoAnt = Preco;
                        }
                        else
                        {
                            descricaoAnt = descricao;
                            precoAnt = Preco;
                        }
                    }

                    Grafico.Titles["Titulo"].Text = "Variação do Preço";
                }

            }
            catch (Exception ex)
            {
                frmErro frm = new frmErro("Ocorreu um erro no calculo da variação: " + ex.Message);
                frm.ShowDialog();
            }
        }


        private void check3d_OnChange(object sender, EventArgs e)
        {
            if (check3d.Checked)
            {
                Grafico.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                Grafico.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }

        private void Grafico01_Click(object sender, EventArgs e)
        {

        }

        private void Grafico_Click(object sender, EventArgs e)
        {

        }

        private void ckPizza_OnChange(object sender, EventArgs e)
        {
            if (ckPizza.Checked)
            {
                Grafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
            else
            {
                Grafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
