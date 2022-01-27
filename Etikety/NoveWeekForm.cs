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
    public partial class NoveWeekForm : Form
    {

        string printername;
        public NoveWeekForm(string pprintername)
        {
            printername = pprintername;
            InitializeComponent();

        }

        private void nweek1but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/nweek1.txt", printername, "Týden 1 - Nový cyklus");  //do formu printw vlozime parametr cesty, ten zavolame jako cestatyden1 ve formu printweek
            this.Hide();

            Printw.ShowDialog();
        }

        private void NoveWeekForm_Load(object sender, EventArgs e)
        {

        }

        private void nweek2but_Click(object sender, EventArgs e)
        {
            PrintWeek Printw = new PrintWeek(@"db/nweek2.txt", printername, "Týden 2 - Nový cyklus");  //do formu printw vlozime parametr cesty, ten zavolame jako cestatyden1 ve formu printweek
            this.Hide();

            Printw.ShowDialog();
        }
    }
}
