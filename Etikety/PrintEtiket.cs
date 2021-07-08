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
using System.Threading;
using System.ComponentModel;

namespace Etikety
{
    class PrintEtiket
    {
       
      

       



        

        public void Printing(List<LoadDataFromCSV> paths, int copies, string printername)
        {
            
          
            
            foreach (LoadDataFromCSV item in paths)
            {
                
                PdfDocument pdf = new PdfDocument(); // proc path? 
                pdf.PrintSettings.PrintController = new StandardPrintController();
                pdf.PrintSettings.PrinterName = printername;
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
                       
                        
                       

                        pdf.LoadFromFile(item.Path);
                        pdf.PrintSettings.Copies = (short)(mod / 2 + mod % 2);
                        pdf.Print();
                    }
                }
                if (item.SpecialPage == "2")
                {
                    if (copies < 11)
                    {
                        pdf.LoadFromFile(item.Path);
                        pdf.PrintSettings.Copies = 1;
                        pdf.Print();
                    }
                    else
                    {
                        pdf.LoadFromFile(item.Path);
                        pdf.PrintSettings.Copies = (short)Math.Floor((double)copies / 10 +1);
                        pdf.Print();
                    }


                }



            }
        }

       


    }
}
