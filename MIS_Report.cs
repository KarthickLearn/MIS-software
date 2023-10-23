using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    public partial class MIS_Report : Form
    {
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse


        );




        public MIS_Report()
        {
            InitializeComponent();
            customizedesing();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        Excel ex = Excel.Getobj();



        public void customizedesing()
        {

            panelsubKPIReports.Visible = false;
            panelSubmenuDailyReports.Visible = false;
            panelsubMonthEndReports.Visible = false;
            panelsubMonthlyInvoice.Visible = false;
            panelsubWeeklyInvoice.Visible = false;
            panelsubmenuWeeklyReports.Visible = false;

        }

        public void hidesubmenu()
        {


            if (panelsubKPIReports.Visible == true)
                panelsubKPIReports.Visible = false;
            if (panelSubmenuDailyReports.Visible == true)
                panelSubmenuDailyReports.Visible = false;
            if (panelsubMonthEndReports.Visible == true)
                panelsubMonthEndReports.Visible = false;
            if (panelsubMonthlyInvoice.Visible == true)
                panelsubMonthlyInvoice.Visible = false;
            if (panelsubWeeklyInvoice.Visible == true)
                panelsubWeeklyInvoice.Visible = false;
            if (panelsubmenuWeeklyReports.Visible == true)
                panelsubmenuWeeklyReports.Visible = false;

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


        public static string today;

        Method meth = Method.Getobj();
        private void MIS_Report_Load(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;

            labdate.Text = DateTime.Now.AddDays(1).ToString("dd");
            labMonth.Text = DateTime.Today.AddDays(1).ToString("MM");
            labYear.Text = DateTime.Today.AddDays(1).ToString("yyyy");
            today = dt.ToString("yyyy") + "-" + dt.ToString("MM") + "-" + dt.ToString("dd");


            for (int i = 3; ex.Readcell(i, 2) != null; i++)
            {
                meth.FolderCreation(ex.Readcell(i, 2), ex.Readcell(i, 3));
            }
            ex.Save();


        }

        private void butDailyReports_Click(object sender, EventArgs e)
        {
            showsubmenu(panelSubmenuDailyReports);
        }

        private void butTracker_Click(object sender, EventArgs e)
        {

            hidesubmenu();

        }

        private void butCompletion_Click(object sender, EventArgs e)
        {
            Openchildform(new Completion());

            hidesubmenu();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            label1.Text = butTracker.Text;

            Openchildform(new Tracker());
            hidesubmenu();
        }

        private void butTat_V6_CG_Click(object sender, EventArgs e)
        {
            Openchildform(new Tat_V6_CG());

            hidesubmenu();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Openchildform(new AR_Backlog());
            hidesubmenu();
        }

        private void butWeeklyREports_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubmenuWeeklyReports);
        }



        private void butSpecialistReview_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void butPatientstatment_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void butWeeklyInvoice_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubWeeklyInvoice);
        }

        private void butBackup_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void butMonthlyINvoice_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubMonthlyInvoice);
        }

        private void butMonthlyBackup_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void butMOnthendreport_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubMonthEndReports);
        }

        private void iconButton39_Click(object sender, EventArgs e)
        {

            Openchildform(new Source());
            hidesubmenu();
        }

        private void iconButton38_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Openchildform(new Rename_Source_File());
        }

        private void iconButton37_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Openchildform(new File_Converstion());
        }

        private void iconButton36_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Openchildform(new Primay_Status());
        }

        private void butFinalStep_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Openchildform(new Final());
        }

        private void butPaidin30days_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Openchildform(new Paid_In_30_Days());
        }

        private void butKPIReport_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubKPIReports);
        }

        private void butDataBase_Click(object sender, EventArgs e)
        {
            Openchildform(new Database());
            hidesubmenu();
        }

        private void butAPPvsNot_Click_1(object sender, EventArgs e)
        {
            hidesubmenu();


            Openchildform(new App_Vs_Not_App());
        }

        private void butChareinflow_Click_1(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WebLoging.obj != null)
            {
                WebLoging web = WebLoging.Getobj();
                web.Chromebrowserclose();
            }

            Application.Exit();
            ex.Save();
            ex.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            activeform.Close();
            label1.Text = "HOME";
            button2.Visible = false;

        }

        private Form activeform = null;

        public void Openchildform(Form childForm)
        {

            if (activeform != null)

                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormcontioner.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            button2.Visible = true;
            label1.Text = childForm.Name;

        }


     


        public  void run(Form childForm)
        {

            if (activeform != null)

                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormcontioner.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            button2.Visible = true;
            label1.Text = childForm.Name;

        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildFormcontioner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labdate_Click(object sender, EventArgs e)
        {

        }

        private void labMonth_Click(object sender, EventArgs e)
        {

        }

        private void labYear_Click(object sender, EventArgs e)
        {

        }

        private void MIS_Report_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelChildFormcontioner_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLog_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelSideMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WebLoging web = WebLoging.Getobj();
            web.Logintobox(ex.Readcell(2, 27), ex.Readcell(2, 28));
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}