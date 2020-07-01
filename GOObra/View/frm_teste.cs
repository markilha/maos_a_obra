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
    public partial class frm_teste : Form
    {
        public frm_teste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = EntradaController.GetEntradas();

            foreach (DataRow dr in dt.Rows)
            {
                string data = DateTime.Parse(dr["DataEntrada"].ToString()).ToString("yyyy/MM/dd");

                string sql = $"UPDATE ENTRADAS SET DATAENTRADA = '{data}' WHERE ENTRADAID = '{dr["EntradaId"].ToString()}'";
                DalHelper.ExecutaQuery(sql);

            }

            MessageBox.Show("Feito");


        }
    }
}
