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

namespace Etikety
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

       

        private void WinterBut_Click(object sender, EventArgs e)
        {
            WinterWeeksForm wwf = new WinterWeeksForm();
            this.Hide();
            wwf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"help.txt");
        }
    }
}
