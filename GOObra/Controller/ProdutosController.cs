using GOObra.Model;
using GOObra.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOObra.Controller
{
    public class ProdutosController
    {

        public static DataTable GetProdutos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Produtos";
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
        public static DataTable GetProdutos(string sql)
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
        public static void CarregaCombo(MetroFramework.Controls.MetroComboBox combo)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Produtos";
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    combo.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        combo.Items.Add(dr["descricao"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetProduto(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Produtos Where Id=" + id;
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
        public static ProdutosModel GetProdutoModel(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            using (var cmd = DalHelper.DbConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Produtos Where Id=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                da.Fill(dt);
            }
            ProdutosModel pm = new ProdutosModel
            {
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                fornecedor = Convert.ToInt32(dt.Rows[0]["fornecedor"]),
                codbarra = dt.Rows[0]["codbarra"].ToString(),
                descricao = dt.Rows[0]["descricao"].ToString(),
                preco = dt.Rows[0]["preco"].ToString(),
                desconto = dt.Rows[0]["desconto"].ToString(),
                quantidade = dt.Rows[0]["quantidade"].ToString(),
                imagem = dt.Rows[0]["imagem"].ToString(),
                categoria = dt.Rows[0]["categoria"].ToString(),
                fabricante = dt.Rows[0]["fabricante"].ToString()
            };
            return pm;

        }
        public static string GetStringProduto(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            string produto = "";
            using (var cmd = DalHelper.DbConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT descricao FROM Produtos Where Id=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    produto = dt.Rows[0]["descricao"].ToString();
                }

            }
            return produto;

        }
        public static string GetStringCategoria(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT categoria FROM Produtos Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                    return dt.Rows[0]["categoria"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetProduto(string Campo, string Valor)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM Produtos Where {Campo} LIKE '%{Valor}%'";
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
        public static int GetIdProduto(string Descricao)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = $"SELECT Id FROM Produtos Where descricao='{Descricao}'";
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                    return Convert.ToInt32(dt.Rows[0]["Id"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetDescricao()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT descricao FROM Produtos;";
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
        public static void Add(ProdutosModel produto)
        {
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Produtos(codbarra,fornecedor,descricao,preco,desconto,quantidade,imagem,categoria,fabricante) values (@codbarra,@fornecedor,@descricao,@preco, @desconto,@quantidade,@imagem,@categoria,@fabricante)";
                    cmd.Parameters.AddWithValue("@codbarra", produto.codbarra);
                    cmd.Parameters.AddWithValue("@fornecedor", produto.fornecedor);
                    cmd.Parameters.AddWithValue("@descricao", produto.descricao);
                    cmd.Parameters.AddWithValue("@preco", produto.preco);
                    cmd.Parameters.AddWithValue("@desconto", produto.desconto);
                    cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
                    cmd.Parameters.AddWithValue("@imagem", produto.imagem);
                    cmd.Parameters.AddWithValue("@categoria", produto.categoria);
                    cmd.Parameters.AddWithValue("@fabricante", produto.fabricante);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Update(ProdutosModel produto)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DalHelper.DbConnection()))
                {
                    cmd.CommandText = "UPDATE Produtos SET codbarra=@codbarra,fornecedor=@fornecedor, descricao=@descricao,preco =@preco,desconto=@desconto,quantidade=@quantidade,imagem=@imagem, categoria=@categoria, fabricante=@fabricante WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", produto.Id);
                    cmd.Parameters.AddWithValue("@fornecedor", produto.fornecedor);
                    cmd.Parameters.AddWithValue("@codbarra", produto.codbarra);
                    cmd.Parameters.AddWithValue("@descricao", produto.descricao);
                    cmd.Parameters.AddWithValue("@preco", produto.preco);
                    cmd.Parameters.AddWithValue("@desconto", produto.desconto);
                    cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
                    cmd.Parameters.AddWithValue("@imagem", produto.imagem);
                    cmd.Parameters.AddWithValue("@categoria", produto.categoria);
                    cmd.Parameters.AddWithValue("@fabricante", produto.fabricante);
                    cmd.ExecuteNonQuery();

                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateCampo(string Tabela, string Campo, string Texto, int id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DalHelper.DbConnection()))
                {

                    cmd.CommandText = $"UPDATE {Tabela} SET {Campo}=@{Campo} WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue($"@{Campo}", Texto);
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
                    cmd.CommandText = "DELETE FROM Produtos Where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
