using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOObra.Controller
{
    public class Diretorio
    {
        public static string CaminhoSalva(string filtro, string diretorio, string nome)
        {
            string caminho = "";
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = filtro;
            fileDialog.InitialDirectory = diretorio;
            fileDialog.Title = "Selecione o caminho para salvar";
            fileDialog.FileName = nome;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminho = fileDialog.FileName;

                FileInfo fileInfo = new FileInfo(fileDialog.FileName); 
                //Mostra a extensão do arquivo
                string fileExtension = fileInfo.Extension;
                //Mostra o caminho completo do arquivo junto com o nome
                string fileFullName = fileInfo.FullName;

            }

            return caminho;
        }
    }
}
