using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOObra.Model
{
    public class EntradaModel
    {
        public int EntradaId { get; set; }
        public int FornecedorId { get; set; }
        public string Ordem { get; set; }
        public int ProdutoId { get; set; }
        public string  Quantidade { get; set; }
        public string DataEntrada { get; set; }
        public string Preco { get; set; }
        public string Desconto { get; set; }
        public string Total { get; set; }
        public string DescontoTotal { get; set; }
        public string Categoria { get; set; }
        public string Comprador { get; set; }
    }
}
