using GOObra.Model;
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
    public class FornecedorController
    {
        public static DataTable GetFornecedores()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Fornecedores";
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
        public static DataTable Getfornecedores(string nomeFantasia)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM Fornecedores Where NomeFantasia LIKE  '%{nomeFantasia}%'";
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

        public static DataTable GetSqlfornecedores(string sql)
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
        public static DataTable Getfornecedor(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Fornecedores Where Id=" + id;
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
        
        public static String GetStringfornecedor(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT NomeFantasia FROM Fornecedores Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                    return dt.Rows[0]["NomeFantasia"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int GetIdfornecedor(string NomeFantasia)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = $"SELECT Id FROM Fornecedores Where NomeFantasia='{NomeFantasia}'";
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
        public static int GetIdfornecedor(string NomeFantasia, bool like)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            int resultado = 0;

             using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    try
                    {
                    cmd.CommandText = $"SELECT Id FROM Fornecedores Where NomeFantasia LIKE '%{NomeFantasia}%'";
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                        da.Fill(dt);
                        resultado =  Convert.ToInt32(dt.Rows[0]["Id"].ToString());
                    }
                    catch 
                    {
                        
                    }
                  
                }
            return resultado;
          
        }
        public static void CarregaCombo(ComboBox combo)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Fornecedores";
                    da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                    da.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    combo.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        combo.Items.Add(dr["NomeFantasia"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       

        public static void Add(FornecedorModel fornecedor)
        {
            try
            {
                using (var cmd = DalHelper.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Fornecedores(NomeFantasia) values (@NomeFantasia)";
                    cmd.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia); 
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Update(FornecedorModel fornecedor)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DalHelper.DbConnection()))
                {

                    cmd.CommandText = "UPDATE Fornecedores SET NomeFantasia=@NomeFantasia WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", fornecedor.Id);
                    cmd.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia);
                    cmd.ExecuteNonQuery();
                }
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
                    cmd.CommandText = "DELETE FROM Fornecedores Where Id=@Id";
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
