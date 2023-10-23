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
    public partial class Paid_In_30_Days : Form
    {
        public Paid_In_30_Days()
        {
            InitializeComponent();
            practicenamechoosing();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(listBox1.SelectedItem.ToString());
        }

        private void panelRenameCheck_Paint(object sender, PaintEventArgs e)
        {

        }
        Excel ex = Excel.Getobj();

        private void comboBoxBMName_SelectedIndexChanged(object sender, EventArgs e)
        {
            practicenamechoosing();
                    }

        public void practicenamechoosing()
        {
            comboPracticeName.Items.Clear();
            
            comboPracticeName.Text = "";
            ex.KPI_Clear();
            
            if (comboBoxBMName.Text == "")
            {
                comboPracticeName.Items.Add("All");
                for (int i = 2; ex.Readcell(i, 38) != null; i++)
                {


                    if (ex.Readcell(i, 19) != null)
                    {
                        comboBoxBMName.Items.Add(ex.Readcell(i, 19));
                        comboBoxTLName.Items.Add(ex.Readcell(i, 20));
                    }
                    comboPracticeName.Items.Add(ex.Readcell(i, 39));
                }
            }
            if(comboBoxBMName.Text != "")
            {
                textBox1.Text = ex.Readcell(31, 2) + ex.Readcell(31, 3) + "\\" + comboBoxBMName.Text + "\\";
                comboPracticeName.Items.Add("All");

                for (int i = 2; ex.Readcell(i,38) != null; i++)
                {
                    if(ex.Readcell(i,38) == comboBoxBMName.Text && ex.Readcell(i, 41) == "Yes")
                    {
                        comboPracticeName.Items.Add(ex.Readcell(i, 39));

                    }

                    if (ex.Readcell(i, 19) == comboBoxBMName.Text)
                    {
                        comboBoxTLName.Text = ex.Readcell(i, 20);
                    }

                }

                

            }



        }

        private void comboPracticeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ex.KPI_Clear();
            for (int i = 2; ex.Readcell(i,38) != null;i++)
            {
                if(comboPracticeName.Text == "All" && ex.Readcell(i, 41) == "Yes")
                {
                    if(ex.Readcell(i,38) == comboBoxBMName.Text)
                    {
                        ex.Writecell(i, 56, "Yes");
                    }
                   
                }

                if (comboPracticeName.Text == ex.Readcell(i,39))
                {
                     ex.Writecell(i, 56, "Yes");
                   
                }

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            ex.KPIDaysheet_name_Finding();
            ex.KPICharge_name_Finding();

            listBox1.Items.Clear();            
            listBox3.Items.Clear();
            

            for (int i =2; ex.Readcell(i,38) != null; i++)
            {
               if(ex.Readcell(i,54) == "File Name is incorrect") { 
                listBox1.Items.Add(ex.Readcell(i, 52));
                
                }
                if (ex.Readcell(i, 55) == "File Name is incorrect")
                {
                    listBox3.Items.Add(ex.Readcell(i, 53));
                    
                }

            }
            
        }

        private void iconBilledTime_Click(object sender, EventArgs e)
        {
            ex.KPIBilledtime();
            MessageBox.Show("Billed Time corrected sucessfully!!");
        }

        private void iconPaidIN30days_Click(object sender, EventArgs e)
        {
            ex.KPI_Paidin30days_Final();
            MessageBox.Show("Paid in 30 days completed for selelecd Practice");
            ex.Save();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ex.KPI_ExtentionConvert();
            MessageBox.Show("File Coverstion Sucessflly completed!!");
        }

        private void iconChargeFileVerification_Click(object sender, EventArgs e)
        {
            
            ex.KPIchargefilecheck();
            MessageBox.Show("Charge file verification Completed sucessfully!!!");
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(listBox3.SelectedItem.ToString());
        }
    }
}
