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
    public class DalHelper
    {
        private static SQLiteConnection sqliteConnection;

        public DalHelper()
        { }

        public static SQLiteConnection DbConnection()
        {
            //string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            //string caminho = path + @"\Dados\\goobra.sqlite";

            sqliteConnection = new SQLiteConnection($"Data Source={Properties.Settings.Default.PathBanco}; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        public static void CriarBancoSQLite()
        {
            try
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                SQLiteConnection.CreateFile(Properties.Settings.Default.PathBanco);
                frmSuccess.Mensagem("Feito");
            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }
        public static void CriarTabelas()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Entradas(EntradaId INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, ProdutoId int, FornecedorId int, Quantidade int, DataEntrada Varchar)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Produtos(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, codbarra Varchar, descricao VarChar,quantidade int,preco varchar)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Fornecedores(Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, NomeFantasia Varchar)";
                    cmd.ExecuteNonQuery();
                    

                    frmSuccess.Mensagem("Feito");
                }
            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }
        public static void CriarTabelaSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Produtos(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, codbarra Varchar, descricao VarChar,quantidade int,preco Real)";
                    cmd.ExecuteNonQuery();
                    frmSuccess.Mensagem("Feito");
                }
            }
            catch (Exception ex)
            {
                frmErro.Mensagem(ex.Message);
            }
        }

        public static List<string> listaTabelas()
        {
            List<string> lista = new List<string>();

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM sqlite_master WHERE type = 'table'";
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                }

            }
            catch 
            {

               
            }
          
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    lista.Add(dr["name"].ToString());
                }
                
            }

            return lista;
        }
        public static List<string> listaColunas(string Tabela)
        {
            List<string> lista = new List<string>();

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = $"SELECT name FROM pragma_table_info['{Tabela}']";
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                }

            }
            catch
            {


            }

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lista.Add(dr["name"].ToString());
                }

            }

            return lista;
        }
        public static void ExecutaQuery(string sql)
        {
            using (var cmd = DalHelper.DbConnection().CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }


    }
}
