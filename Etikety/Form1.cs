using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Net;

namespace Etikety
{

    public partial class Form1 : Form
    {

       

        public Form1()
        {
            
            InitializeComponent();
            FillPrinters();
            NactiNazevTiskarny();
            
            
        }

        void FillPrinters()
        {
            foreach (var p in PrinterSettings.InstalledPrinters)
            {
                toolStripComboBox1.Items.Add(p);
            }
        }

        
        public string NactiNazevTiskarny()
        {
            string NacistNazev = File.ReadAllText(@"printername.txt");
            toolStripComboBox1.SelectedItem = NacistNazev;
            return NacistNazev;
        }

        void ZapisNazevTiskarny()
        {
            string NewNameOfPrinter = toolStripComboBox1.SelectedItem.ToString();
            File.WriteAllText(@"printername.txt", NewNameOfPrinter);
          
        }
        private void WinterBut_Click(object sender, EventArgs e)
        {
            WinterWeeksForm wwf = new WinterWeeksForm(NactiNazevTiskarny());  //posleme do dalsiho formu parametr, musi byt return a vratit jakoby promennou, na druhe strane musime string a promenna
            this.Hide();
            wwf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            helper.ShowDialog();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZapisNazevTiskarny();
        }

        private void SummerBut_Click(object sender, EventArgs e)
        {
            SummerWeeksForm swf = new SummerWeeksForm(NactiNazevTiskarny());  //posleme do dalsiho formu parametr, musi byt return a vratit jakoby promennou, na druhe strane musime string a promenna
            this.Hide();
            swf.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
