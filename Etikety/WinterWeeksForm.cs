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
            Wweek2 ww2 = new Wweek2();
            this.Hide();
            ww2.ShowDialog();
        }
    }
}
