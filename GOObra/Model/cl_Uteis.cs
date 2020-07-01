using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOObra.Model
{
    public class cl_Uteis
    {     

        public static void copiaDiretorio(string CaminhoEntrada, string CaminhoSaida)
        {

            if (!Directory.Exists(CaminhoSaida))
            {
                Directory.CreateDirectory(CaminhoSaida);
            }

            if (!string.IsNullOrEmpty(CaminhoEntrada))
            {
                //Copia de arquivos
                string[] arquivos = Directory.GetFiles(CaminhoEntrada);
                foreach (string arquivo in arquivos)
                {
                    File.Copy(CaminhoEntrada + @"\" + Path.GetFileName(arquivo), CaminhoSaida + @"\" + Path.GetFileName(arquivo), true);
                }
                string[] diretorios = Directory.GetDirectories(CaminhoEntrada);

                //Copia das pastas
                foreach (string diretorio in diretorios)
                {
                    copiaDiretorio(diretorio, CaminhoSaida + @"\" + diretorio.Split(Convert.ToChar(@"\"))[diretorio.Split(Convert.ToChar(@"\")).Length - 1]);
                }
            }

        }    

    
    }
}
