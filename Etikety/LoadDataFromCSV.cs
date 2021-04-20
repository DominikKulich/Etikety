using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etikety
{
    class LoadDataFromCSV
    {
        public string Day { get; set; } 
        public string Type { get; set; } 
        public string SpecialPage { get; set; } 
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
