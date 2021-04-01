using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Spire.Pdf;
using Spire.Pdf.Print;
using System.Drawing.Printing;

namespace Etikety
{
    class PrintEtiket
    {
        public void Printing(string pFileName, short pCopies)
        {
            
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(pFileName);
            doc.PrintSettings.PrintController = new StandardPrintController();
            doc.PrintSettings.Copies = pCopies;
            doc.Print();
        }
        


    }
}
