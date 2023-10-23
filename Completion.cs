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
    public partial class Completion : Form
    {
        public Completion()
        {
            InitializeComponent();
        }

        private void Completion_Load(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now.AddDays(1);

            string comdate = dt.ToString("dd");
            string commonth = dt.ToString("MMM");
            string comyear = dt.ToString("yyyy");
            ex.Writecell(101, 3, "Completion Mail " + comdate + "-" + commonth);
            ex.Writecell(102, 3, "Completion Mail " + comdate + "-" + commonth);
            ex.Writecell(103, 3, "Completion Consolidation-" + commonth + "'" + comyear);
                
            ex.Save();


        }
        WebLoging web = WebLoging.Getobj();
        Excel ex = Excel.Getobj();
        Method meth = Method.Getobj();
        private void iconButton1_Click(object sender, EventArgs e)
        {

            ex.CompletionPivot();
            MessageBox.Show("Completion Pivot work done!!!!");

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ex.CompletionDates();
            MessageBox.Show("Completion Adding has been sucessfully added!!!");
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ex.CompletionVlookup();
            MessageBox.Show("Vlookup work done!!!!");
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ex.CompletionAdding();
            MessageBox.Show("Today inflow has been added sucessfully!!!");
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ex.CompletionFilesaving();
            MessageBox.Show("Completion file saving!!!");
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            web.UploadingFIle(ex.Readcell(101, 2) + "\\" + ex.Readcell(101, 3) + ".xlsx", "https://drchrono.app.box.com/folder/141509303889");
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            web.UploadingFIle(ex.Readcell(102, 2) + "\\" + ex.Readcell(102, 3) + ".xlsx", "https://drchrono.app.box.com/folder/107661922995");
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
         
            ex.ExcelConsoliditon(ex.Readcell(101, 2) + "\\" + ex.Readcell(101, 3) + ".xlsx", ex.Readcell(103, 2) + "\\" + ex.Readcell(103, 3) + ".xlsx", 3, 43, Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Master Data Base\Completion Consolidiation Sample.xlsx"));
            ex.Pendingremoving(ex.Readcell(103, 2) + "\\" + ex.Readcell(103, 3) + ".xlsx");
        }

    }
}
