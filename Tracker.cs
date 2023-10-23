using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace MIS
{
    public partial class Tracker : Form 
    {
      
        public Tracker()
        {
            InitializeComponent();
            
        }

        Excel ex = Excel.Getobj();
        Method meth = Method.Getobj();
        WebLoging web = WebLoging.Getobj();
        private void iconButton1_Click(object sender, EventArgs e)
        {
            texDownloadTime.Visible = false;
            butDownloadTime.Visible = true;
            string cliamstart = ex.Readcell(50, 5).Replace("'","");
            //var datetimecliamstart = DateTime.FromOADate(cliamstart).ToString();
            var rcmfname = MIS_Report.today + " "+ cliamstart;
            web.Filedownload(rcmfname);
            web.RCMFiledownload(MIS_Report.today);
            MessageBox.Show("Srouce File Download from RCM Folder to downloads!!!!!!");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            ex.Filetransfer();
            
            MessageBox.Show("Source File transfer to source folder. Kindly rename the file name!!!!");  
        }

        private void Tracker_Load(object sender, EventArgs e)
        {

            texDownloadTime.Visible = false;
            texDownloadTime.Text = ex.Readcell(50, 5);
            butDownloadTime.Visible = true;
            textBox1.Visible = false;
            textBox1.Text = DateTime.Today.ToString("d");
            var today = DateTime.Today.AddDays(1);
            string today1 = today.ToString();
            var yesterday = DateTime.Today;
            string yesterday1 = yesterday.ToString("d").Replace("/", "");
            var yesterdaybefore = DateTime.Today.AddDays(-1);
            string yesterdaybefore1 = yesterdaybefore.ToString("d").Replace("/", "");

            var yesterdaybefore2 = DateTime.Today.AddDays(-2);
            string yesterdaybefore22 = yesterdaybefore2.ToString("d").Replace("/", "");

            var yesterdaybefore3 = DateTime.Today.AddDays(-3);
            string yesterdaybefore33 = yesterdaybefore3.ToString("d").Replace("/", "");

            ex.Writecell(50, 4, today1);
            ex.Writecell(51, 3, "Tracker-" + yesterday1);
            ex.Writecell(52, 3, "Tracker-" + yesterdaybefore1);
            ex.Writecell(54, 3, "Completion Mail " + DateTime.Now.ToString("dd") + "-" + DateTime.Now.ToString("MMM"));
            ex.Writecell(56, 3, "Tracer Consolidation-" + DateTime.Now.AddDays(1).ToString("MMM") + "'"+DateTime.Now.ToString("yyyy"));
            string na = DateTime.Today.ToString("dddd");
            

            if (na== "Sunday")
            {

                textBox1.Visible = true;
                textBox1.Text = DateTime.Today.AddDays(-2).ToString("d");
                ex.Writecell(51, 3, "Tracker-" + yesterdaybefore22);
                ex.Writecell(52, 3, "Tracker-" + yesterdaybefore33);
                ex.Writecell(54, 3, "Completion Mail " + DateTime.Today.AddDays(-2).ToString("dd") + "-" + DateTime.Now.ToString("MMM"));
                

            }
            if (na == "Monday")
            {
                
                ex.Writecell(51, 3, "Tracker-" + yesterday1);
                ex.Writecell(52, 3, "Tracker-" + yesterdaybefore33);
             }
           
            
            ex.Writecell(51, 4, textBox1.Text);

            for (int i = 51; ex.Readcell(i, 2) != null; i++)
            {
                meth.Choosefile(ex.Readcell(i, 2), ex.Readcell(i, 3) + ".xlsx");
            }

            ex.Save();

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ex.SourceFileRename();
            MessageBox.Show("Source FIle Renamed successfully and now you can make a tracker");
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ex.Consolidation();
           MessageBox.Show("Source files consolidation done!!!!");
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ex.Completion();
            MessageBox.Show("Completion process completed sucessfully");
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ex.Formating();
            MessageBox.Show("Fromating process completed sucessfully!!!!");
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ex.Exlcusion();
            
            MessageBox.Show("Exclusion Marking process completed sucessfully!!!.. Kindly cross verfy before upload");
            ex.Close();
        }

        private void iconButton9_Click(object sender, EventArgs e)

        {
            
            
            Excel ex = Excel.Getobj();
            
           var today = DateTime.Today.AddDays(1);
            string today1 = today.ToString("d").Replace("/", "");

            ex.Openexcelfile(ex.Readcell(20, 2), "Tracker-" + today1 + ".xlsx");
            
            ex.Excelvisuable();

                      
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Excel ex = Excel.Getobj();
            iconButton8.IconColor = Color.Yellow;
            var today = DateTime.Today.AddDays(1);
            string today1 = today.ToString().Replace("/", "").Replace(" 12:00:00 AM", "");

            string filename = ex.Readcell(20, 2) + "\\" + "Tracker-" + today1 + ".xlsx";
            try
            {
                web.UploadingFIle(filename, "https://drchrono.app.box.com/folder/107661894114?s=glwr1uhegwwrhfyvuamq8ut7pioawu3s");
            }
            catch
            {
                web.Logintobox(ex.Readcell(2, 27), ex.Readcell(2, 28));
                web.UploadingFIle(filename, "https://drchrono.app.box.com/folder/107661894114?s=glwr1uhegwwrhfyvuamq8ut7pioawu3s");

            }

            iconButton8.IconColor = Color.White;

            

         }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            
            var today = DateTime.Today.AddDays(1);
            string today1 = today.ToString("d").Replace("/", "");

            
            
            
          ex.ExcelConsoliditon(ex.Readcell(20, 2) + "\\" + "Tracker-" + today1 + ".xlsx", ex.Readcell(56,2) + "//" + ex.Readcell(56, 3) + ".xlsx", 2,49, Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Master Data Base\Tracker Consolidation Sample.xlsx"));

            ex.ExcelvisuableHide();
            MessageBox.Show("Daily Tracker has been uploded with monthly Consolidation!!!");
        }

        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            ex.Writecell(51, 4, textBox1.Text);


            ex.Writecell(54, 3, "Completion Mail " + DateTime.Today.AddDays(-1).ToString("dd") + "-" + DateTime.Now.ToString("MMM"));


            ex.Save();
        }

        private void butDownloadTime_Click(object sender, EventArgs e)
        {
            texDownloadTime.Visible = true;
            butDownloadTime.Visible = false;
        }

        private void texDownloadTime_TextChanged(object sender, EventArgs e)
        {
            ex.Writecell(50,5, "'"+texDownloadTime.Text);   
        }
    }
}
