using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etikety
{
    class LoadDataFromCSV
    {
        public string Day { get; set; } // 1 =pondeli, 2=utery, 3=streda, 4=ctvrtek, 5=patek
        public string Type { get; set; } //lc5000,r5000,m6000
        public string SpecialPage { get; set; } // 0 nebo 1
        public string Path { get; set; }

        public static LoadDataFromCSV GetPrintData(string line) //? proc line
        {
            string[] values = line.Split(';');
            LoadDataFromCSV data = new LoadDataFromCSV();
            data.Day = values[0];
            data.Type = values[1];
            data.SpecialPage = values[2];
            data.Path = values[3];
            return data;
        }
    }
}
