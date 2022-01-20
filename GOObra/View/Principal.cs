using GOObra.Controller;
using GOObra.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOObra.View
{

    public partial class Principal : Form
    {
        private Form activeForm = null;

        Font FontTitulo = FontFactory.GetFont(FontFactory.COURIER_BOLD, 16, BaseColor.GREEN);
        Font FontSubTitulo = FontFactory.GetFont(FontFactory.COURIER, 14, BaseColor.ORANGE);
        Font FontLinhas = FontFactory.GetFont(FontFactory.COURIER, 12, BaseColor.BLACK);
        Font FontTotais = FontFactory.GetFont(FontFactory.COURIER, 12, BaseColor.BLUE);

        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            hideSubMenu(null);
            txtCaminho.Text = Properties.Settings.Default.PathBanco;
        }
        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            //if(Sidebar.Width == 270)
            //{
            //    Sidebar.Visible = false;
            //    Sidebar.Width = 68;
            //    SidebarWrapper.Width = 90;
            //    LineSidebar.Width = 52;
            //    animacaoSidebar.Show(Sidebar);
            //}else
            //{
            //    Sidebar.Visible = false;
            //    Sidebar.Width = 270;
            //    SidebarWrapper.Width = 300;
            //    LineSidebar.Width = 252;
            //    animacaoSidebarBack.Show(Sidebar);

            //}
        }

        private void bntEntrada_Click(object sender, EventArgs e)
        {

            openChildremFormInPanel(new frmEntrada());

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            hideSubMenu(subMenuCadastro);
        }


        private void btnOrdens_Click(object sender, EventArgs e)
        {
            using (frmOrdem form = new frmOrdem())
            {
                form.ShowDialog();
            }
        }

        private void btnListaProdutos_Click(object sender, EventArgs e)
        {
            using (frmProdutoEditar form = new frmProdutoEditar())
            {
                form.ShowDialog();
            }
        }
        private void openChildremFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            // childForm.Location = new Point((this.Size.Width / 2) - (this.panelChildForm.Size.Width / 2), (this.Size.Height / 2) - (this.panelChildForm.Size.Height / 2));
            childForm.Left = ((panelChildForm.Width - childForm.Width) / 2);
            childForm.Top = ((panelChildForm.Height - childForm.Height) / 2);

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            cl_Variaveis.frmentrada = null;
            cl_Variaveis.frmprodutoeditar = null;
            openChildremFormInPanel(new frmProdutos());
            hideSubMenu(null);
        }

        private void SidebarWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadFornecedores_Click(object sender, EventArgs e)
        {
            openChildremFormInPanel(new frmFornecedor(null, true));
            hideSubMenu(null);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            hideSubMenu(subMenuConsulta);
        }

        private void hideSubMenu(Panel painel)
        {
            subMenuCadastro.Visible = false;
            subMenuCadastro.Size = new System.Drawing.Size(270, 1);
            subMenuConsulta.Visible = false;
            subMenuConsulta.Size = new System.Drawing.Size(270, 1);
            subMenuGrafico.Visible = false;
            subMenuGrafico.Size = new System.Drawing.Size(270, 1);
            subMenuRelatorio.Visible = false;
            subMenuRelatorio.Size = new System.Drawing.Size(270, 1);

            if (painel != null)
            {
                painel.Visible = true;
                painel.Size = new System.Drawing.Size(270, 155);
            }


        }

        private void btnConProdutos_Click(object sender, EventArgs e)
        {
            openChildremFormInPanel(new frmProdutoEditar());
            hideSubMenu(null);
        }

        private void btnConOrdem_Click(object sender, EventArgs e)
        {
            openChildremFormInPanel(new frmOrdem());
            hideSubMenu(null);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            hideSubMenu(subMenuGrafico);

        }

        private void btnConfornecedores_Click(object sender, EventArgs e)
        {
            openChildremFormInPanel(new frmListaFornecedores());
            hideSubMenu(null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildremFormInPanel(new frmGrafico(0));
            hideSubMenu(null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildremFormInPanel(new frmGrafico(1));
            hideSubMenu(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildremFormInPanel(new frmGrafico(3));
            hideSubMenu(null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildremFormInPanel(new frmGrafico(4));
            hideSubMenu(null);
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            openChildremFormInPanel(new frmAlterarBanco());
            hideSubMenu(null);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            hideSubMenu(subMenuRelatorio);
        }

        private void GeraReltatorio()
        {
            string pasta = Diretorio.CaminhoSalva("Aquivos pdf|*.pdf", "", "");

            using (var doc = new Document(iTextSharp.text.PageSize.A4, 40, 40, 50, 50))
            {
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(pasta, FileMode.CreateNew));
                doc.Open();

                PdfPTable pdfTable = new PdfPTable(new float[] { 100f });
                pdfTable.WidthPercentage = 100f;
                Pdf.AddCelula(1, 0, FontTitulo, pdfTable, $"Relatorio Gastros por Fornecedores\n\n");
                doc.Add(pdfTable);

                PdfPTable pdfTable2 = new PdfPTable(new float[] { 70f, 30f });
                pdfTable2.WidthPercentage = 100f;
                Pdf.AddCelula(Element.ALIGN_CENTER, Rectangle.NO_BORDER, FontSubTitulo, pdfTable2, "FORNECEDOR");
                Pdf.AddCelula(Element.ALIGN_CENTER, Rectangle.NO_BORDER, FontSubTitulo, pdfTable2, "SUBTOTAL");
                doc.Add(pdfTable2);

                List<string> lista = new List<string>();
                lista = EntradaController.GetLista("FornecedorId");

                double total = 0;
                DataTable dt = new DataTable();
                dt.Columns.Add("Fornecedor");
                dt.Columns.Add("Valor");

                if (lista.Count > 0)
                {
                    foreach (string item in lista)
                    {
                        double valor = 0;
                        DataTable valores = EntradaController.GetSqlEntradas($"SELECT Total FROM Entradas WHERE FornecedorId = '{item}' ORDER BY FornecedorId ");
                        string fornecedor = EntradaController.GetString($"SELECT NomeFantasia FROM Fornecedores where Id ='{item}'", "NomeFantasia");


                        if (valores.Rows.Count > 0)
                        {
                            foreach (DataRow dr in valores.Rows)
                            {
                                if (dr["Total"].ToString().Length > 0)
                                {
                                    valor += Convert.ToDouble(dr["Total"].ToString());
                                }

                            }
                        }



                        dt.Rows.Add(fornecedor, valor.ToString("N2"));

                        total += valor;

                    }
                }

                dt.DefaultView.Sort = "Fornecedor ASC";
                dt = dt.DefaultView.ToTable();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        PdfPTable pdfTable3 = new PdfPTable(new float[] { 70f, 30f });
                        pdfTable3.WidthPercentage = 100f;
                        Pdf.AddCelula(Element.ALIGN_LEFT, Rectangle.LEFT_BORDER, FontLinhas, pdfTable3, dr["Fornecedor"].ToString());
                        Pdf.AddCelula(Element.ALIGN_RIGHT, Rectangle.LEFT_BORDER, FontLinhas, pdfTable3, dr["Valor"].ToString());
                        doc.Add(pdfTable3);

                    }

                }

                PdfPTable pdfTable4 = new PdfPTable(new float[] { 70f, 30f });
                pdfTable4.WidthPercentage = 100f;
                pdfTable4.DefaultCell.Border = Rectangle.BOTTOM_BORDER;
                Pdf.AddCelula(Element.ALIGN_RIGHT, 0, FontLinhas, pdfTable4, "");
                Pdf.AddCelula(Element.ALIGN_RIGHT, 0, FontTotais, pdfTable4, $"Total: {total.ToString("N2")}");
                doc.Add(pdfTable4);


                //doc.Add(Pdf.addParagrafoCentro("Relatório\n\n", Element.ALIGN_CENTER, FontTitulo));


                doc.Close();
                System.Diagnostics.Process.Start(pasta);
            }
        }
        private void GeraReltatorioComprador()
        {
            string pasta = Diretorio.CaminhoSalva("Aquivos pdf|*.pdf", "", "RolComprador");

            using (var doc = new Document(iTextSharp.text.PageSize.A4, 40, 40, 50, 50))
            {
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(pasta, FileMode.CreateNew));
                doc.Open();

                PdfPTable pdfTable = new PdfPTable(new float[] { 100f });
                pdfTable.WidthPercentage = 100f;
                Pdf.AddCelula(1, 0, FontTitulo, pdfTable, $"Relatorio Gastros por Compradores\n\n");
                doc.Add(pdfTable);



                List<string> lista = new List<string>();
                lista = EntradaController.GetLista("Comprador");
                lista.Sort();

                double total = 0;
                List<string> listaTotal = new List<string>();



                if (lista.Count > 0)
                {
                    foreach (string item in lista)
                    {
                        PdfPTable pdfTable3 = new PdfPTable(new float[] { 100f });
                        pdfTable3.WidthPercentage = 100f;
                        Pdf.AddCelula(Element.ALIGN_CENTER, Rectangle.LEFT_BORDER, FontSubTitulo, pdfTable3, item);
                        doc.Add(pdfTable3);

                        PdfPTable pdfTable2 = new PdfPTable(new float[] { 20f, 60f, 20f });
                        pdfTable2.WidthPercentage = 100f;
                        Pdf.AddCelula(Element.ALIGN_CENTER, Rectangle.NO_BORDER, FontSubTitulo, pdfTable2, "DATA");
                        Pdf.AddCelula(Element.ALIGN_CENTER, Rectangle.NO_BORDER, FontSubTitulo, pdfTable2, "PRODUTO");
                        Pdf.AddCelula(Element.ALIGN_CENTER, Rectangle.NO_BORDER, FontSubTitulo, pdfTable2, "SUBTOTAL");
                        doc.Add(pdfTable2);

                        double valor = 0;
                        DataTable valores = EntradaController.GetSqlEntradas($"SELECT DATAENTRADA, PRODUTOID,Total FROM Entradas WHERE Comprador = '{item}' ORDER BY DATAENTRADA DESC ");


                        if (valores.Rows.Count > 0)
                        {
                            foreach (DataRow dr in valores.Rows)
                            {
                                string produto = ProdutosController.GetStringProduto(int.Parse(dr["ProdutoId"].ToString()));
                                string data = DateTime.Parse(dr["DataEntrada"].ToString()).ToString("dd/MM/yyyy");

                                if (dr["Total"].ToString().Length > 0)
                                {
                                    valor += Convert.ToDouble(dr["Total"].ToString());
                                }

                                PdfPTable tab = new PdfPTable(new float[] { 15f, 65f, 20f });
                                tab.WidthPercentage = 100f;
                                Pdf.AddCelula(Element.ALIGN_LEFT, Rectangle.LEFT_BORDER, FontLinhas, tab, data);
                                Pdf.AddCelula(Element.ALIGN_LEFT, Rectangle.LEFT_BORDER, FontLinhas, tab, produto);
                                Pdf.AddCelula(Element.ALIGN_RIGHT, Rectangle.LEFT_BORDER, FontLinhas, tab, dr["Total"].ToString());
                                doc.Add(tab);

                            }
                        }

                        listaTotal.Add($"{item};{valor.ToString("N2")}");

                        doc.Add(Pdf.addParagrafoCentro("\n\n", Element.ALIGN_CENTER, FontTitulo));

                    }
                }


                if (listaTotal.Count > 0)
                {
                    foreach (string item in listaTotal)
                    {
                        string[] vetor = item.Split(';');

                        PdfPTable tab3 = new PdfPTable(new float[] { 80f, 20f });
                        tab3.WidthPercentage = 100f;
                        tab3.DefaultCell.Border = Rectangle.BOTTOM_BORDER;
                        Pdf.AddCelula(Element.ALIGN_RIGHT, 0, FontLinhas, tab3, vetor[0] + ": ");
                        Pdf.AddCelula(Element.ALIGN_RIGHT, 0, FontTotais, tab3, $"R$ {vetor[1]}");
                        doc.Add(tab3);

                        total += double.Parse(vetor[1]);
                    }
                }

                PdfPTable pdfTable4 = new PdfPTable(new float[] { 70f, 30f });
                pdfTable4.WidthPercentage = 100f;
                pdfTable4.DefaultCell.Border = Rectangle.BOTTOM_BORDER;
                Pdf.AddCelula(Element.ALIGN_RIGHT, 0, FontLinhas, pdfTable4, "");
                Pdf.AddCelula(Element.ALIGN_RIGHT, 0, FontTotais, pdfTable4, $"Total: {total.ToString("N2")}");
                doc.Add(pdfTable4);


                //doc.Add(Pdf.addParagrafoCentro("Relatório\n\n", Element.ALIGN_CENTER, FontTitulo));


                doc.Close();
                System.Diagnostics.Process.Start(pasta);
            }
        }
        private void GeraReltatorioProduto()
        {

            string pasta = Diretorio.CaminhoSalva("Aquivos pdf|*.pdf", "", "");

            using (var doc = new Document(iTextSharp.text.PageSize.A4, 40, 40, 50, 50))
            {
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(pasta, FileMode.CreateNew));
                doc.Open();

                //Titulo do documento
                doc.Add(Pdf.addParagrafoCentro("Relatório dos Materiais utilizados\n\n", Element.ALIGN_CENTER, FontTitulo));
                InserirLinha(doc, new float[] { 10f, 70f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_CENTER, Element.ALIGN_CENTER, Element.ALIGN_CENTER }, FontSubTitulo, new List<string> { "QT", "Produto", "SubTotal" });

                List<string> lista = new List<string>();
                List<string> ListaProdutos = new List<string>();
                lista = EntradaController.GetLista("Categoria");
                double Total = 0;

                if (lista.Count > 0)
                {
                    foreach (string item in lista)
                    {
                        double TotalCategoria = 0;
                        doc.Add(Pdf.addParagrafoCentro("\n", Element.ALIGN_CENTER, FontTitulo));

                        InserirLinha(doc, new float[] { 100f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_CENTER }, FontTitulo, new List<string> { item.ToUpper() });



                        DataTable valores = EntradaController.GetSqlEntradas($"SELECT * FROM Entradas WHERE Categoria = '{item}' ORDER BY Categoria ");

                        //DataRow[] result = valores.Select("Date > #6/1/2001#");
                        List<string> produtos = new List<string>();

                        if (valores.Rows.Count > 0)
                        {
                            foreach (DataRow dr in valores.Rows)
                            {
                                string produto = ProdutosController.GetStringProduto(Convert.ToInt32(dr["ProdutoId"].ToString()));
                                produtos.Add(produto);
                            }

                        }
                        produtos.Sort();
                        string anterior = "";


                        if (produtos.Count > 0)
                        {
                            foreach (string prod in produtos)
                            {
                                if (prod != anterior)
                                {
                                    int id = ProdutosController.GetIdProduto(prod);
                                    double contar = 0;
                                    double subtotal = 0;

                                    DataTable dt = EntradaController.GetSqlEntradas($"SELECT * FROM Entradas WHERE ProdutoId = {id} ");
                                    if (dt.Rows.Count > 0)
                                    {
                                        foreach (DataRow dr in dt.Rows)
                                        {
                                            contar += Convert.ToDouble(dr["Quantidade"]);
                                            subtotal += Convert.ToDouble(dr["Total"]);
                                        }
                                    }

                                    InserirLinha(doc, new float[] { 10f, 70f, 20f }, Rectangle.LEFT_BORDER, new List<int> { Element.ALIGN_LEFT, Element.ALIGN_LEFT, Element.ALIGN_RIGHT }, FontLinhas, new List<string> { contar.ToString(), prod, "R$ " + subtotal.ToString("N2") });
                                    Total += subtotal;
                                    TotalCategoria += subtotal;

                                }

                                anterior = prod;
                            }

                        }
                        InserirLinha(doc, new float[] { 10f, 20f, 70f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_RIGHT, Element.ALIGN_RIGHT, Element.ALIGN_RIGHT }, FontTotais, new List<string> { "", "", " SUBTOTAL = R$ " + TotalCategoria.ToString("N2") });
                    }
                }

                InserirLinha(doc, new float[] { 10f, 20f, 70f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_RIGHT, Element.ALIGN_RIGHT, Element.ALIGN_RIGHT }, FontTotais, new List<string> { "", "", " TOTAL = R$ " + Total.ToString("N2") });
                doc.Close();
                System.Diagnostics.Process.Start(pasta);
            }
        }

        private void GeraReltatorioOrdem()
        {
            try
            {
                string pasta = Diretorio.CaminhoSalva("Aquivos pdf|*.pdf", "", "RelatorioPorOrdem");

                using (var doc = new Document(iTextSharp.text.PageSize.A4, 40, 40, 50, 50))
                {
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(pasta, FileMode.CreateNew));
                    doc.Open();

                    //Titulo do documento
                    doc.Add(Pdf.addParagrafoCentro("Relatório das Ordens\n\n", Element.ALIGN_CENTER, FontTitulo));

                    double Total = 0;


                    doc.Add(Pdf.addParagrafoCentro("\n", Element.ALIGN_CENTER, FontTitulo));

                    //Todos as entrada de um determinada data
                    DataTable valores = EntradaController.GetSqlEntradas("SELECT A.Ordem, B.NomeFantasia, A.DataEntrada, A.quantidade, C.descricao, A.total FROM Entradas as A INNER JOIN Fornecedores as B ON B.Id = A.FornecedorId INNER JOIN Produtos as C on C.Id = A.ProdutoId ORDER by A.DataEntrada DESC;");
                    string stringOrdem = "";
                    bool inicio = true;
                    double TotalOrdem = 0;

                    if (valores.Rows.Count > 0)
                    {
                        foreach (DataRow dr in valores.Rows)
                        {
                            DateTime dt = DateTime.Parse(dr["DATAENTRADA"].ToString());
                            string data = dt.ToString("dd/MM/yyyy");
                           
                            //var filteredDataTable = valores.Select($"Ordem = '{ordem}'");                           

                            if (dr["ORDEM"].ToString() != stringOrdem)
                            {                              

                                if (inicio == true)
                                {
                                    InserirLinha(doc, new float[] { 100f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_LEFT }, FontLinhas, new List<string> { $"ORDEM: {dr["ORDEM"].ToString()}\nFORNECEDOR: {dr["NOMEFANTASIA"].ToString()}\nDATA: {data}" });
                                    InserirLinha(doc, new float[] { 10f, 75f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_CENTER, Element.ALIGN_CENTER, Element.ALIGN_CENTER }, FontSubTitulo, new List<string> { "QT", "PRODUTO", "SUBTOTAL" });
                                    InserirLinha(doc, new float[] { 10f, 75f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_LEFT, Element.ALIGN_LEFT, Element.ALIGN_RIGHT }, FontLinhas, new List<string> { dr["QUANTIDADE"].ToString(), dr["DESCRICAO"].ToString(), dr["TOTAL"].ToString() });                                    
                                    inicio = false;
                                }
                                else
                                {                                   
                                    InserirLinha(doc, new float[] { 80f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_RIGHT, Element.ALIGN_RIGHT }, FontTotais, new List<string> { "", " R$ " + TotalOrdem.ToString("N2") });                                   

                                    InserirLinha(doc, new float[] { 100f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_LEFT }, FontLinhas, new List<string> { $"ORDEM: {dr["ORDEM"].ToString()}\nFORNECEDOR: {dr["NOMEFANTASIA"].ToString()}\nDATA: {data}" });
                                    InserirLinha(doc, new float[] { 10f, 75f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_CENTER, Element.ALIGN_CENTER, Element.ALIGN_CENTER }, FontSubTitulo, new List<string> { "QT", "PRODUTO", "SUBTOTAL" });
                                    InserirLinha(doc, new float[] { 10f, 75f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_LEFT, Element.ALIGN_LEFT, Element.ALIGN_RIGHT }, FontLinhas, new List<string> { dr["QUANTIDADE"].ToString(), dr["DESCRICAO"].ToString(), dr["TOTAL"].ToString() });
                                }

                                TotalOrdem = Convert.ToDouble(dr["Total"].ToString());

                            }
                            else
                            {
                                InserirLinha(doc, new float[] { 10f, 75f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_LEFT, Element.ALIGN_LEFT, Element.ALIGN_RIGHT }, FontLinhas, new List<string> { dr["QUANTIDADE"].ToString(), dr["DESCRICAO"].ToString(), dr["TOTAL"].ToString() });
                                TotalOrdem += Convert.ToDouble(dr["TOTAL"].ToString());
                            }

                            stringOrdem = dr["ORDEM"].ToString();
                            Total += double.Parse(dr["TOTAL"].ToString());
                        }                     

                    }


                    InserirLinha(doc, new float[] { 80f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_RIGHT, Element.ALIGN_RIGHT }, FontTotais, new List<string> { "TOTAL =", "R$ " + Total.ToString("N2") });
                    doc.Close();
                    System.Diagnostics.Process.Start(pasta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void GeraReltatorioOrdem_()
        {
            try
            {
                string pasta = Diretorio.CaminhoSalva("Aquivos pdf|*.pdf", "", "RelatorioPorOrdem");

                using (var doc = new Document(iTextSharp.text.PageSize.A4, 40, 40, 50, 50))
                {
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(pasta, FileMode.CreateNew));
                    doc.Open();

                    //Titulo do documento
                    doc.Add(Pdf.addParagrafoCentro("Relatório das Ordens\n\n", Element.ALIGN_CENTER, FontTitulo));

                    List<string> listaDatas = new List<string>();
                    List<string> listaOrdens = new List<string>();

                    listaDatas = EntradaController.GetLista("DataEntrada");
                    listaDatas.Sort();

                    double Total = 0;


                    if (listaDatas.Count > 0)
                    {
                        InserirLinha(doc, new float[] { 10f, 75f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_CENTER, Element.ALIGN_CENTER, Element.ALIGN_CENTER }, FontSubTitulo, new List<string> { "QT", "PRODUTO", "SUBTOTAL" });


                        foreach (string data in listaDatas)
                        {
                            doc.Add(Pdf.addParagrafoCentro("\n", Element.ALIGN_CENTER, FontTitulo));

                            //Todos as entrada de um determinada data
                            DataTable valores = EntradaController.GetSqlEntradas($"SELECT * FROM Entradas WHERE DataEntrada = '{data}' ORDER BY DataEntrada");

                            //lista de ordens de uma determinada ordem
                            listaOrdens = EntradaController.GetLista("Ordem", "DataEntrada", data);
                            listaOrdens.Sort();
                            string stringOrdem = "";

                            foreach (string ordem in listaOrdens)
                            {
                                double TotalOrdem = 0;
                                var filteredDataTable = valores.Select($"Ordem = '{ordem}'");

                                foreach (DataRow dr in filteredDataTable)
                                {
                                    string descricao = ProdutosController.GetStringProduto(Convert.ToInt32(dr["ProdutoId"].ToString()));

                                    if (ordem != stringOrdem)
                                    {
                                        string fornecedor = FornecedorController.GetStringfornecedor(Convert.ToInt32(dr["FornecedorId"].ToString()));
                                        InserirLinha(doc, new float[] { 100f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_LEFT }, FontLinhas, new List<string> { $"ORDEM: {ordem}\nFORNECEDOR: {fornecedor}\nDATACOMPRA: {data}" });
                                        InserirLinha(doc, new float[] { 10f, 75f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_LEFT, Element.ALIGN_LEFT, Element.ALIGN_RIGHT }, FontLinhas, new List<string> { dr["Quantidade"].ToString(), descricao, dr["Total"].ToString() });
                                        TotalOrdem = Convert.ToDouble(dr["Total"].ToString());

                                    }
                                    else
                                    {
                                        InserirLinha(doc, new float[] { 10f, 75f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_LEFT, Element.ALIGN_LEFT, Element.ALIGN_RIGHT }, FontLinhas, new List<string> { dr["Quantidade"].ToString(), descricao, dr["Total"].ToString() });
                                        TotalOrdem += Convert.ToDouble(dr["Total"].ToString());
                                    }

                                    stringOrdem = ordem;

                                }

                                Total += TotalOrdem;
                                InserirLinha(doc, new float[] { 80f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_RIGHT, Element.ALIGN_RIGHT }, FontTotais, new List<string> { "SUBTOTAL =", " R$ " + TotalOrdem.ToString("N2") });

                            }



                        }
                    }

                    InserirLinha(doc, new float[] { 80f, 20f }, Rectangle.NO_BORDER, new List<int> { Element.ALIGN_RIGHT, Element.ALIGN_RIGHT }, FontTotais, new List<string> { "TOTAL =", "R$ " + Total.ToString("N2") });
                    doc.Close();
                    System.Diagnostics.Process.Start(pasta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void InserirLinha(Document doc, float[] TamanhoColunas, int Borda, List<int> AlinhamentoCelula, Font Fonte, List<string> Textos)
        {
            PdfPTable pdfTable = new PdfPTable(TamanhoColunas);
            pdfTable.WidthPercentage = 100f;
            pdfTable.DefaultCell.Border = Borda;
            int cont = 0;
            foreach (string item in Textos)
            {
                Pdf.AddCelula(AlinhamentoCelula[cont], Borda, Fonte, pdfTable, item);
                cont++;
            }

            doc.Add(pdfTable);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GeraReltatorio();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GeraReltatorioProduto();
        }

        private void btnGrafVariacao_Click(object sender, EventArgs e)
        {
            openChildremFormInPanel(new frmGrafico(5));
            hideSubMenu(null);
        }

        private void btnOrdem_Click(object sender, EventArgs e)
        {
            GeraReltatorioOrdem();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildremFormInPanel(new frmGrafico(6));
            hideSubMenu(null);
        }

        private void btnRolComprador_Click(object sender, EventArgs e)
        {
            GeraReltatorioComprador();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //string[] vetor = Directory.GetCurrentDirectory().ToString().Split('\\');

                //string caminhoProjeto = $"{Directory.GetCurrentDirectory().ToString()}\\Dados\\goobra.sqlite";
                //string caminhoSalva = $"{vetor[0]}\\{vetor[1]}\\{vetor[2]}\\";
                //File.Copy(caminhoProjeto, caminhoSalva, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            //string[] vetor = Directory.GetCurrentDirectory().ToString().Split('\\');

            //string caminho = $"{vetor[0]}\\{vetor[1]}\\{vetor[2]}\\";
            //MessageBox.Show( $"{Directory.GetCurrentDirectory().ToString()}\\Dados\\goobra.sqlite");
           
            
        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCarModelo_Click(object sender, EventArgs e)
        {
            try
            {
                
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "SQL|*sqlite";               
                fileDialog.Title = "Selecione o caminho";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCaminho.Text = fileDialog.FileName;
                    Properties.Settings.Default.PathBanco = fileDialog.FileName;
                    Properties.Settings.Default.Save();
                        
                }

               

            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }
    }
}
