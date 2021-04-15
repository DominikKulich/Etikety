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
       

        public WinterWeeksForm()
        {
            InitializeComponent();
            
        }

        private void wweek2but_Click(object sender, EventArgs e)
        {

            PrintWeek Printw = new PrintWeek(@"db/wweek2.txt");  //do formu printw vlozime parametr cesty, ten zavolame jako cestatyden1 ve formu printweek
            this.Hide();

            Printw.ShowDialog();
        }

        private void wweek1but_Click(object sender, EventArgs e)
        {
            
            
            PrintWeek Printw = new PrintWeek(@"db/wweek1.txt");
            this.Hide();
            
            Printw.ShowDialog();
            
        }

        private void wweek4but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/wweek4.txt");
            this.Hide();

            Printw.ShowDialog();
        }

        private void wweek3but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/wweek3.txt");
            this.Hide();

            Printw.ShowDialog();
        }

        private void wweek5but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/wweek5.txt");
            this.Hide();

            Printw.ShowDialog();
        }
    }
}
