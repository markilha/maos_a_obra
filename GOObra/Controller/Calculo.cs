using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOObra.Controller
{
    public class Calculo
    {
        public static double Desconto(double valor, double porc)
        {
            double resultado = 0;
            resultado = ((valor * porc) / 100);
            return resultado;
        }
        public static double Total(double preco, double quant, double desconto)
        {
            double Desc = (Calculo.Desconto(preco, desconto));
            double SubTotal = (preco - Desc);
            return (SubTotal * quant);
        }
    }
}
