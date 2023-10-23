using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MIS
{
    public partial class Tat_V6_CG : Form
    {
        public Tat_V6_CG()
        {
            InitializeComponent();
            customizedesing();
        }



        public void customizedesing()
        {

            panelCodingtatsubmenu.Visible = false;
            panelV6submenu.Visible = false;
            panelCGsubmenu.Visible = false;
            
        }
        public void hidesubmenu()
        {


            if (panelCodingtatsubmenu.Visible == true)
                panelCodingtatsubmenu.Visible = false;
            if (panelV6submenu.Visible == true)
                panelV6submenu.Visible = false;
            if (panelCGsubmenu.Visible == true)
                panelCGsubmenu.Visible = false;
            
        }


        public void showsubmenu(Panel submenu)
        {

            if (submenu.Visible == false)
            {

                hidesubmenu();
                submenu.Visible = true;

            }
            else
            {

                submenu.Visible = true;

            }


        }












        Excel ex = Excel.Getobj();
        WebLoging web = WebLoging.Getobj();
        private void iconButton10_Click(object sender, EventArgs e)
        {
            if (File.Exists(ex.Readcell(111, 2) + "//" + ex.Readcell(111, 3) + ".xlsx") == true) { ex.CodingTat(); }
            else { File.Copy(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Master Data Base\MS6 Inflow & Pending-Coding Team Resp Template.xlsx"), ex.Readcell(111, 2) + "//" + ex.Readcell(111, 3) + ".xlsx");
                ex.CodingTat();
                                
            }
            MessageBox.Show("Coding Tat created sucessfuly!!!");

            ex.Close();
        }


        private void iconButton7_Click(object sender, EventArgs e)

        {
            hidesubmenu();
            Excel ex = Excel.Getobj();
            string fname = DateTime.Now.AddDays(1).ToString("d").Replace("/", "");

            ex.Openexcelfile(ex.Readcell(111, 2) + "//", "MS6 Inflow & Pending-Coding Team Resp - " + fname + ".xlsx");
            ex.Excelvisuable();
            
            
        }

        private void iconButton1_Click(object sender, EventArgs e)

        {

            hidesubmenu();
            Excel ex = Excel.Getobj();
            string fname = DateTime.Now.AddDays(1).ToString("d").Replace("/", "");
            web.UploadingFIle(ex.Readcell(111, 2) + "//" + "MS6 Inflow & Pending-Coding Team Resp - " + fname + ".xlsx", "https://drchrono.app.box.com/folder/107979779102?s=xjg4haxol5fqi28zfrc7jqrkfpnolzu4");
            MessageBox.Show("Coding Tat file upload to box sucessfuly!!!");
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            ex.v6filemacro();
            MessageBox.Show("V6 file created sucessfuly!!!");
            
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        Method meth = Method.Getobj();
        private void iconButton4_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            meth.FolderCreation(ex.Readcell(22,2) + "//" +ex.Readcell(22,3)+"//" ,DateTime.Now.AddDays(1).ToString("d").Replace("/",""));
            //Process proce = Process.Start(@"C:\Program Files\FileZilla FTP Client\filezilla.exe");
            //proce.WaitForInputIdle();
            //while (proce.MainWindowHandle == IntPtr.Zero) {
            //    Thread.Sleep(100);
            
            //}
            //SetParent(proce.MainWindowHandle,this.panel1.Handle);
            MessageBox.Show("Cleargage Reports source folder created sucessfuly!!!");
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            ex.CGConsolidation();
            MessageBox.Show("Cleargage Reports consolidation done sucessfuly!!!");
            ex.Close();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

            hidesubmenu(); 
            web.UploadingFIle(ex.Readcell(23,2) + ex.Readcell(23,3)+"//"+ "Cleargage Exit Report-"+ DateTime.Now.AddDays(1).ToString("d").Replace("/", "")+".xlsx", "https://drchrono.app.box.com/folder/140326771934");
            MessageBox.Show("Cleargage Reports Upload in box sucessfuly!!!");
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Excel ex = Excel.Getobj();
            string today = DateTime.Today.AddDays(1).ToString("d").Replace("/", "");
            web.LogintoHRMS(ex.Readcell(17,2)+ex.Readcell(17,3)+"\\"+today, "Analyst - "+today+".xlsx", "Billing New - " + today + ".xlsx");
            MessageBox.Show("V6 file uploading in hrms sucessfully!!!");
        }

        private void panelV6submenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tat_V6_CG_Load(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            showsubmenu(panelCodingtatsubmenu);
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            showsubmenu(panelV6submenu);
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            showsubmenu(panelCGsubmenu);
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Excel ex = Excel.Getobj();
            ex.Openexcelfile(ex.Readcell(23, 2) + ex.Readcell(23, 3)  , "Cleargage Exit Report-" + DateTime.Now.AddDays(1).ToString("d").Replace("/", "") + ".xlsx");
           
        }
    }



}
