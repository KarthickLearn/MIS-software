using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    public partial class Primay_Status : Form
    {
        public Primay_Status()
        {
            InitializeComponent();
        }


        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            DateTime dt = DateTime.Today.AddDays(1);
            int days = Int16.Parse(dt.ToString("dd"));
            dateTimePicker1.Value = dt.AddDays(-days);
            ex.Writecell(2, 37, dateTimePicker1.Text);

        }
        Excel ex = Excel.Getobj();
        private void iconButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            
            
            ex.Primarystatuslistbox();
            
            
            try { 
             Array Claimid =  ex.findingprimarystatus(2);

            foreach(var claim in Claimid)
            {

                listBox1.Items.Add(claim);

            }

            Array ProviderNmae = ex.findingprimarystatus(5);

            foreach (string provider in ProviderNmae)
            {

                listBox2.Items.Add(provider);

            }

            Array BillingStatus = ex.findingprimarystatus(7);

            foreach (string billing in BillingStatus)
            {

                listBox3.Items.Add(billing);

            }

            }
            catch { MessageBox.Show("There is no new billing status found!!!"); }



            MessageBox.Show("Unkown primary listed below!!!!");


        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ex.Daysheet_Alignment_Change();
            MessageBox.Show("Dayseet is ready to make monthend report!!!");
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ex.Agingfind();
            MessageBox.Show("Aging file sucessfully renamed!!!");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ex.Primarystatusfind();
            MessageBox.Show("LCF consolidated sucessfully!!!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ex.Writecell(2, 37, dateTimePicker1.Text);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(listBox1.SelectedItem.ToString());
        }
    }
}
