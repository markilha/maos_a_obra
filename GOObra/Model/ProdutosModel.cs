using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOObra.Model
{
    public class ProdutosModel
    {
        public int Id { get; set; }
        public int fornecedor { get; set; }
        public string codbarra { get; set; }
        public string descricao { get; set; }
        public string preco { get; set; }
        public string desconto { get; set; }
        public string quantidade { get; set; }
        public string imagem { get; set; }
        public string categoria { get; set; }
        public string fabricante { get; set; }
    }
}
