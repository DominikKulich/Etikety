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
using System.Windows.Forms;

namespace Etikety
{
    class PrintEtiket
    {
        public void Printing(List<LoadDataFromCSV> paths, int copies)
        {


            foreach (LoadDataFromCSV item in paths)
            {
                
                PdfDocument pdf = new PdfDocument(); // proc path? 
                pdf.PrintSettings.PrintController = new StandardPrintController();
                int mod = copies % 10;
                if (copies - mod > 9)
                {
                    if (item.SpecialPage == "0")
                    {
                        
                        pdf.LoadFromFile(item.Path);
                        pdf.PrintSettings.Copies = (short)(copies / 10);
                        pdf.Print();
                      //  copies = copies * 10 + mod;
                    }



                }
                if (mod > 0)
                {
                    if (item.SpecialPage == "1")
                    {
                        //if (mod % 2 == 0)
                        //    copies = mod / 2;
                        //if (mod == 7)
                        //    copies = 4;
                        //if (mod == 9)
                        //    copies = 5;
                        //if (mod == 3)
                        //    copies = 2;
                        //if (mod == 5)
                        //    copies = 6;
                        //if (mod == 1)
                        //    copies = 1;
                        
                       

                        pdf.LoadFromFile(item.Path);
                        pdf.PrintSettings.Copies = (short)(mod / 2 + mod % 2);
                        pdf.Print();
                    }
                }






            }
        }



    }
}
