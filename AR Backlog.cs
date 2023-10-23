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
    public partial class AR_Backlog : Form
    {
        public AR_Backlog()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
            Noofdays();
        }

        Excel ex = Excel.Getobj();

        public void Noofdays()
        {

            DateTime dt = dateTimePicker1.Value;

            string today = dt.ToString("dddd");

            if (today == "Monday" || today == "Tuesday" || today == "Wednesday")
            {
                textBox2.Text = "2";
                           

            }
            else
            {
                textBox2.Text = "0";
            }

            
            int days = Int16.Parse(textBox2.Text);
            dateTimePicker2.Value = dt.AddDays(-days - 3 - 1);

            dateTimePicker3.Value = dt.AddDays(-3 - 1);
            dateTimePicker6.Value = dt.AddDays(31);
            dateTimePicker5.Value = dt.AddDays(-14-1);
            dateTimePicker4.Value = dt.AddDays(-37 - 1);



            ex.Writecell(2, 22, dt.ToString("d"));
            ex.Writecell(4, 22, dateTimePicker2.Text);
            ex.Writecell(5, 22, dateTimePicker3.Text);
            ex.Writecell(6,22, dateTimePicker6.Text);
            ex.Writecell(7, 22, dateTimePicker5.Text);
            ex.Writecell(8, 22, dateTimePicker4.Text);



            if (today == "Monday") { ex.Writecell(3, 22, dt.AddDays(-3).ToString("d")); }
            else { ex.Writecell(3, 22, dt.AddDays(-1).ToString("d")); }

            if (today == "Monday" || today == "Tuesday" )
            {
                dateTimePicker4.Value = dt.AddDays(-39 - 1);
                ex.Writecell(8, 22, dateTimePicker4.Text);

            }

        }
           

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
                     
            textBox2_TextChanged(sender, e);
            Noofdays();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            int days = Int16.Parse(textBox2.Text);
            dateTimePicker2.Value = dt.AddDays(-days -3 -1);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

       
        WebLoging web = WebLoging.Getobj();
        private void iconButton11_Click(object sender, EventArgs e)
        {
            texDownloadTime.Visible = false;
            DateTime dt = dateTimePicker1.Value;
            string time = ex.Readcell(2, 23).Replace("'", "");
            string fname = dt.ToString("yyyy") + "-" + dt.ToString("MM") + "-" + dt.ToString("dd") + " "+time;
            try { web.Filedownload(fname); } catch(OpenQA.Selenium.NoSuchElementException qa) { MessageBox.Show ("RCM 2nd dowload(" +fname + ")file not found"); }
            web.RCMFiledownload(fname); 

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            ex.file_transfer_AR();
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            ex.RenameFile_AR();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ex.Excelvisuable();
            if (radioButton1.Checked) { ex.FirstARBacklog(); radioButton1.Checked = false; } 
            else { 
            ex.AR();
                radioButton1.Checked = false;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ex.GravisReport();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ex.Summary();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ex.Bmamwise();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            ex.primaryStatus();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ex.split_AR();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ex.SpineSumary();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            ex.Angel();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ex.MedBar();
            ex.Close();
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            Excel ex = Excel.Getobj();
            DateTime dt = dateTimePicker1.Value;
            ex.Openexcelfile(ex.Readcell(25, 2) + ex.Readcell(25, 3), "AR Backlog - " + dt.ToString("d").Replace("/", "")+".xlsx");

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            web.UploadingFIle(ex.Readcell(25, 2) + ex.Readcell(25, 3) + "//AR Backlog - " + dt.ToString("d").Replace("/", "") + ".xlsx", "https://drchrono.app.box.com/folder/153112309465?s=zj39y1v16c84cb7tdivhpyh28dq8m8ea");
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            Noofdays();
        }

        private void AR_Backlog_Load(object sender, EventArgs e)
        {
            texDownloadTime.Visible = false;
            texDownloadTime.Text = ex.Readcell(2, 23).Replace("'", "");
            Noofdays();
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            ex.AR_Compleiton();
        }

        private void butDownloadTime_Click(object sender, EventArgs e)
        {
            texDownloadTime.Visible = true;
            butDownloadTime.Visible = false;
        }

        private void texDownloadTime_TextChanged(object sender, EventArgs e)
        {
            ex.Writecell(2, 23, "'"+texDownloadTime.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
