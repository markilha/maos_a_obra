using GOObra.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOObra.Model
{
    public class cl_Variaveis
    {
        public static int Id { get; set; }
        public static string Produto { get; set; }
        public static string Quantidade { get; set; }
        public static string Preco { get; set; }
        public static frmProdutoEditar frmprodutoeditar { get; set;}
        public static frmEntrada frmentrada { get; set; }
    }
}
