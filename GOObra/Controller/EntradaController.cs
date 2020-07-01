using GOObra.Model;
using GOObra.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOObra.Controller
{
    public class EntradaController
    {
        public static DataTable GetEntradas()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Entradas";
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetEntradas(string Campo, string Texto)
        {
            if(Campo == "DataEntrada")
            {
                if(Texto.Length == 10)
                {
                    Texto = DateTime.Parse(Texto).ToString("yyyy/MM/dd");
                }
            }

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT T.ENTRADAID,T.ORDEM,R.DESCRICAO, P.NOMEFANTASIA, T.CATEGORIA, T.QUANTIDADE, " +
                        "T.DATAENTRADA,T.PRECO,T.DESCONTO,T.TOTAL,T.DESCONTOTOTAL, T.COMPRADOR, T.PARCELAS " +
                        "FROM ENTRADAS AS T INNER JOIN FORNECEDORES AS P ON T.FORNECEDORID = P.ID " +
                        $"INNER JOIN PRODUTOS AS R ON T.PRODUTOID = R.ID where {Campo} like '%{Texto}%'";
                  
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetEntradas(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable Consulta(List<string> ListaCampos, List<string> Valores)
        {
            string filtro = "";

            if (ListaCampos.Count > 0)
            {
                int cont = 0;
                foreach (string Campo in ListaCampos)
                {
                    if (cont == 0)
                    {
                        filtro = $"WHERE {Campo} = '{Valores[cont].ToString()}' ";

                    }
                    else
                    {
                        filtro += $" AND { Campo} = '{Valores[cont].ToString()}' ";
                    }
                    cont++;

                }

            }

            string sql = "SELECT T.ENTRADAID,T.ORDEM,R.DESCRICAO, P.NOMEFANTASIA, T.CATEGORIA, T.QUANTIDADE, " +
                         "T.DATAENTRADA,T.PRECO,T.DESCONTO,T.TOTAL,T.DESCONTOTOTAL, T.COMPRADOR, T.PARCELAS " +
                         "FROM ENTRADAS AS T INNER JOIN FORNECEDORES AS P ON T.FORNECEDORID = P.ID " +
                         $"INNER JOIN PRODUTOS AS R ON T.PRODUTOID = R.ID {filtro};";

            return EntradaController.GetEntradas(sql);

        }

        public static DataTable GetSqlEntradas(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                frmErro form = new frmErro("Ocorreu erro ao consultar no banco de dados: " + ex.Message);
                form.ShowDialog();
            }
            return dt;
        }
        public static string GetUltimaOrdem()
        {
            string ordem = "";
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT MAX(Ordem)as UltimaOrdem FROM Entradas";
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (dt.Rows.Count > 0)
            {
                double Ord = Convert.ToDouble(dt.Rows[0]["UltimaOrdem"]);
                ordem = (Ord + 1).ToString();
            }
            return ordem;
        }
        public static string GetString(string sql, string CampoDeRetorno)
        {
            string resultado = "";
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                frmErro form = new frmErro($"Ocorreu um erro ao buscar {CampoDeRetorno}: {ex.Message}");
            }

            if (dt.Rows.Count > 0)
            {
                resultado = dt.Rows[0][CampoDeRetorno].ToString();
            }

            return resultado;

        }


        public static EntradaModel GetEntradaModel(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Entradas Where EntradaId=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                }

                return new EntradaModel
                {
                    EntradaId = Convert.ToInt32(dt.Rows[0]["EntradaId"].ToString()),
                    ProdutoId = Convert.ToInt32(dt.Rows[0]["ProdutoId"].ToString()),
                    FornecedorId = Convert.ToInt32(dt.Rows[0]["FornecedorId"].ToString()),
                    Ordem = dt.Rows[0]["Ordem"].ToString(),
                    DataEntrada = dt.Rows[0]["DataEntrada"].ToString(),
                    Preco = dt.Rows[0]["Preco"].ToString(),
                    Total = dt.Rows[0]["Total"].ToString(),
                    Desconto = dt.Rows[0]["Desconto"].ToString(),
                    Quantidade = dt.Rows[0]["Quantidade"].ToString(),
                    DescontoTotal = dt.Rows[0]["DescontoTotal"].ToString(),
                    Categoria = dt.Rows[0]["Categoria"].ToString(),
                    Comprador = dt.Rows[0]["Comprador"].ToString()
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Add(EntradaModel entrada)
        {
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Entradas(ProdutoId,FornecedorId,Ordem, Quantidade,DataEntrada,Preco,Desconto,Total,DescontoTotal,Categoria,Comprador) values (@ProdutoId, @FornecedorId,@Ordem,@Quantidade,@DataEntrada,@Preco,@Desconto,@Total,@DescontoTotal,@Categoria,@Comprador)";
                    cmd.Parameters.AddWithValue("@ProdutoId", entrada.ProdutoId);
                    cmd.Parameters.AddWithValue("@FornecedorId", entrada.FornecedorId);
                    cmd.Parameters.AddWithValue("@Ordem", entrada.Ordem);
                    cmd.Parameters.AddWithValue("@Quantidade", entrada.Quantidade);
                    cmd.Parameters.AddWithValue("@DataEntrada", entrada.DataEntrada);
                    cmd.Parameters.AddWithValue("@Preco", entrada.Preco);
                    cmd.Parameters.AddWithValue("@Desconto", entrada.Desconto);
                    cmd.Parameters.AddWithValue("@Total", entrada.Total);
                    cmd.Parameters.AddWithValue("@DescontoTotal", entrada.DescontoTotal);
                    cmd.Parameters.AddWithValue("@Categoria", entrada.Categoria);
                    cmd.Parameters.AddWithValue("@Comprador", entrada.Comprador);


                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                frmErro.Mensagem(ex.Message);
            }
        }


        public static void Update(EntradaModel entrada)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DalHelper.DbConnection()))
                {

                    cmd.CommandText = "UPDATE Entradas SET Ordem=@Ordem,ProdutoId=@ProdutoId,FornecedorId=@FornecedorId, Quantidade=@Quantidade, DataEntrada=@DataEntrada, Preco=@Preco, Desconto=@Desconto, Total=@Total, DescontoTotal=@DescontoTotal,Categoria=@Categoria,Comprador=@Comprador  WHERE EntradaId=@EntradaId";
                    cmd.Parameters.AddWithValue("@EntradaId", entrada.EntradaId);
                    cmd.Parameters.AddWithValue("@Ordem", entrada.Ordem);
                    cmd.Parameters.AddWithValue("@ProdutoId", entrada.ProdutoId);
                    cmd.Parameters.AddWithValue("@FornecedorId", entrada.FornecedorId);
                    cmd.Parameters.AddWithValue("@Quantidade", entrada.Quantidade);
                    cmd.Parameters.AddWithValue("@DataEntrada", entrada.DataEntrada);
                    cmd.Parameters.AddWithValue("@Preco", entrada.Preco);
                    cmd.Parameters.AddWithValue("@Desconto", entrada.Desconto);
                    cmd.Parameters.AddWithValue("@Total", entrada.Total);
                    cmd.Parameters.AddWithValue("@DescontoTotal", entrada.DescontoTotal);
                    cmd.Parameters.AddWithValue("@Categoria", entrada.Categoria);
                    cmd.Parameters.AddWithValue("@Comprador", entrada.Comprador);
                    cmd.ExecuteNonQuery();

                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int Id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DalHelper.DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Entradas Where EntradaId=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<string> GetLista(string campo)
        {
            string sql = $"SELECT DISTINCT {campo} FROM Entradas ORDER BY {campo};";
            DataTable dt = EntradaController.GetSqlEntradas(sql);
            List<string> lista = new List<string>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lista.Add(dr[campo].ToString());
                }

            }
            return lista;
        }
        public static List<string> GetLista(string campo, string where, string valor)
        {
            string sql = $"SELECT DISTINCT {campo} FROM Entradas where  {where}= '{valor}' ORDER BY {campo};";
            DataTable dt = EntradaController.GetSqlEntradas(sql);
            List<string> lista = new List<string>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lista.Add(dr[campo].ToString());
                }

            }
            return lista;
        }


    }
}
