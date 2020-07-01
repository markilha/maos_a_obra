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
    public class Util
    {
        public static int replaceCampo(string sql)
        {
            using (var cmd = new SQLiteCommand(DalHelper.DbConnection()))
            {
                cmd.CommandText = sql;
                return cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetDados(string sql)
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
        public static void CarregaCombo(string Tabela, string Campo, ComboBox combo)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            using (var cmd = DalHelper.DbConnection().CreateCommand())
            {
                cmd.CommandText = $"SELECT DISTINCT {Campo} FROM {Tabela} ORDER BY {Campo};";
                da = new SQLiteDataAdapter(cmd.CommandText, DalHelper.DbConnection());
                da.Fill(dt);
            }
            if (dt.Rows.Count > 0)
            {
                combo.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    combo.Items.Add(dr[Campo].ToString());
                }

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
        public static void AutoCompleta(DataTable Tabela, ComboBox Combo)
        {
            var source = new AutoCompleteStringCollection();

            for (int i = 0; i < Tabela.Rows.Count; i++)
            {
                source.Add(Tabela.Rows[i][0].ToString());
            }

            Combo.AutoCompleteCustomSource = source;
            Combo.AutoCompleteMode = AutoCompleteMode.Append;
            Combo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public static double Porcentagem(double valor, double total)
        {
            string valor1 = valor.ToString("N2");
            string total1 = total.ToString("N2");

            double resultato = 0;
            resultato = (Convert.ToDouble(valor1) * 100) / Convert.ToDouble(total);
            return resultato;
        }


        public static DataTable Consulta(List<string> ListaCampos, List<string> Valores)
        {
            string sql = "";

            if (ListaCampos.Count > 0)
            {
                int cont = 0;
                foreach (string Campo in ListaCampos)
                {
                    if (cont == 0)
                    {
                        sql = $"SELECT * FROM Entradas WHERE {Campo} = '{Valores[cont].ToString()}' ";

                    }
                    else
                    {
                        sql += $"AND { Campo} = '{Valores[cont].ToString()}' ";
                    }
                    cont++;

                }

            }

            return EntradaController.GetEntradas(sql);

        }

    }
}
