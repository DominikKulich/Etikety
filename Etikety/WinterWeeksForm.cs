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
    public partial class WinterWeeksForm : Form
    {

        string printername;
        public WinterWeeksForm(string pprintername)
        {
            printername = pprintername;
            InitializeComponent();
            
        }

        private void wweek2but_Click(object sender, EventArgs e)
        {

            PrintWeek Printw = new PrintWeek(@"db/wweek2.txt", printername,"Týden 2");  //do formu printw vlozime parametr cesty, ten zavolame jako cestatyden1 ve formu printweek
            this.Hide();

            Printw.ShowDialog();
        }

        private void wweek1but_Click(object sender, EventArgs e)
        {
            
            
            PrintWeek Printw = new PrintWeek(@"db/wweek1.txt", printername, "Týden 1 - Zimní cyklus");
            this.Hide();
            
            Printw.ShowDialog();
            
        }

        private void wweek4but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/wweek4.txt", printername, "Týden 4 - Zimní cyklus");
            this.Hide();

            Printw.ShowDialog();
        }

        private void wweek3but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/wweek3.txt", printername, "Týden 3 - Zimní cyklus");
            this.Hide();

            Printw.ShowDialog();
        }

        private void wweek5but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/wweek5.txt", printername, "Týden 4 - Zimní cyklus");
            this.Hide();

            Printw.ShowDialog();
        }

        private void WinterWeeksForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }
    }
}
