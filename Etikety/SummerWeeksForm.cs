using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etikety
{
    public partial class SummerWeeksForm : Form
    {
        string printername;
        public SummerWeeksForm(string pprintername)
        {
            printername = pprintername;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void sweek1but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/sweek1.txt", printername, "Týden 1");  //do formu printw vlozime parametr cesty, ten zavolame jako cestatyden1 ve formu printweek
            this.Hide();

            Printw.ShowDialog();
        }

        private void sweek2but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/sweek2.txt", printername, "Týden 2");  //do formu printw vlozime parametr cesty, ten zavolame jako cestatyden1 ve formu printweek
            this.Hide();

            Printw.ShowDialog();
        }

        private void sweek3but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/sweek3.txt", printername, "Týden 3");  //do formu printw vlozime parametr cesty, ten zavolame jako cestatyden1 ve formu printweek
            this.Hide();

            Printw.ShowDialog();
        }

        private void sweek4but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/sweek4.txt", printername, "Týden 4");  //do formu printw vlozime parametr cesty, ten zavolame jako cestatyden1 ve formu printweek
            this.Hide();

            Printw.ShowDialog();
        }

        private void sweek5but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/sweek5.txt", printername, "Týden 5");  //do formu printw vlozime parametr cesty, ten zavolame jako cestatyden1 ve formu printweek
            this.Hide();

            Printw.ShowDialog();
        }
    }
}
