using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iTextSharp.text.TabStop;

namespace GOObra.Controller
{
    public class Pdf
    {
        public static Paragraph addParagrafoCentro(string texto,int alinhamento, Font fonte)
        {
            Paragraph paragrafo = new Paragraph("");
            paragrafo.Alignment = alinhamento;
            paragrafo.Font = fonte;
            paragrafo.Add(texto);
            return paragrafo;
        }
        public static void AddCelula(int aliamento,int borda, Font Fonte, PdfPTable tabe, string texto)
        {
            Font CelFont = Fonte;
            PdfPCell celula = new PdfPCell();
            celula.Border = borda;
            celula.HorizontalAlignment = aliamento;
            celula.Phrase = new Phrase(texto, CelFont);
            tabe.AddCell(celula);
        }
    }
}
