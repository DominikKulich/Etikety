using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etikety
{
    
    public partial class Wweek2 : Form
    {
        private List<LoadDataFromCSV> loadW2; //vytvoreni pole z load data
        public Wweek2()
        {
            InitializeComponent();
        }

        private void Wweek2_Load(object sender, EventArgs e)
        {
            loadW2 = File.ReadAllLines(@"db/week2.txt").Skip(1).Select(x => LoadDataFromCSV.GetPrintData(x)).ToList();
            setDay.DataSource = loadW2.Select(x => x.Day).Distinct().ToArray();
        }

        private void setDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printbutW1_Click(object sender, EventArgs e)
        {
            PrintEtiket print = new PrintEtiket();
            List<LoadDataFromCSV> paths;
            string day = setDay.SelectedItem.ToString();
            
                var myTextBoxes = groupBox1.Controls.OfType<TextBox>();

                foreach (TextBox txt in myTextBoxes)
                {
                    int copies = Convert.ToInt32(txt.Text);
                    string type = txt.Tag.ToString();
                paths = loadW2.Where(x => (x.Day == day) & (x.Type == type)).ToList();
                if (copies > 0) print.Printing(paths, copies);
                }
            

        }
    }
}
