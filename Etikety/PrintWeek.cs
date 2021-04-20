using Spire.Pdf.Exporting.XPS.Schema;
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
using System.Diagnostics;
using System.Drawing.Printing;
namespace Etikety
{

    public partial class PrintWeek : Form
    {
        private List<LoadDataFromCSV> loadWeek; //vytvoreni pole z load data
        private string cesta;
        string printername;

       
            
        
        public PrintWeek(string cestatyden1, string pprintername) //nacteme promennou cestatyden1 a musime ji vytvorit tady v tom formu
        {
            printername = pprintername;
            cesta = cestatyden1;
            InitializeComponent();
        }

        private void Wweek2_Load(object sender, EventArgs e)
        {
         
            loadWeek = File.ReadAllLines(cesta).Skip(1).Select(x => LoadDataFromCSV.GetPrintData(x)).ToList();
         
            setDay.DataSource = loadWeek.Select(x => x.Day).Distinct().ToArray();           
            setDay.SelectedIndex = -1;
            progressBar1.Hide();
            
        }

        private void setDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void printbutW1_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            printbutW1.Enabled = false;
            PrintEtiket print = new PrintEtiket();
            List<LoadDataFromCSV> paths;
            var mycheckboxes = Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<CheckBox>());
            var myGroupBoxes = Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<NumericUpDown>());
            
            if (setDay.SelectedIndex == -1)
            {
                MessageBox.Show("Zapomněli jste zvolit den","Zadejte den",MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                
            }
            else
            { 
            string day = setDay.SelectedItem.ToString();          
            

                foreach (NumericUpDown txt in myGroupBoxes)
                {


                    int copies = (int)txt.Value;
                    if (txt is null)
                    {
                        txt.Value = 0;

                    }
                    if (txt.Value > 0)
                    {
                        
                        var a = mycheckboxes.Where(l => l.Tag == txt.Tag).First();
                        if (a.Text == "")
                            a.Text = txt.Value.ToString();
                        else
                            a.Text = (int.Parse(a.Text) + txt.Value).ToString();  //pricte to k checkbox textu kdyz se zmeni znova, musi se int + int prevest na string a udelat if pokud je prazdny retezec
                        
                        a.Visible = true;
                        a.Checked = true;
                        txt.Value = 0;
                        
                    }
                    progressBar1.Value += progressBar1.Maximum / myGroupBoxes.Count();
                    string type = txt.Tag.ToString();
                    paths = loadWeek.Where(x => (x.Day == day) & (x.Type == type)).ToList();
                    await Task.Run(() => // spusti se asynchronne metoda printing, zkusit casem pouzit thread nebo backg.worker
                    {
                        if (copies > 0) print.Printing(paths, copies, printername);
                       

                    });
                    

                }
                
               

            }
            printbutW1.Enabled = true;
            
            progressBar1.Hide();
            progressBar1.Value = 0;






        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinterWeeksForm wwf = new WinterWeeksForm(printername);
            this.Hide();
            wwf.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resetCheckBoxes = Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<CheckBox>()).ToList();
            var resertGroupBoxes = Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<NumericUpDown>()).ToList();
            for (int i=0; i <= resetCheckBoxes.Count -1 ;i++  )
            {
                resetCheckBoxes[i].Text = "";
                resetCheckBoxes[i].Visible = false;
                resertGroupBoxes[i].Value = 0;
            }
        }

        private void helpbut_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            helper.ShowDialog();
        }
    }
}
