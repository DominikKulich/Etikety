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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tyden1_Click(object sender, EventArgs e)
        {
            Tyden1 tyden1 = new Tyden1();
            this.Hide();
            tyden1.ShowDialog();

        }
    }
}
