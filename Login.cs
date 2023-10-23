using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MIS
{
    public partial class Login : Form
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


        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            this.Close();
            Excel excel = Excel.Getobj();
            string cell = excel.Readcell(1, 3);
            DirectoryInfo dcf = new DirectoryInfo(@cell + "\\MIS Folder");
            if (dcf.Exists)
            {
                   
                Application.Run(new MIS_Report());
                //Application.Run(new Login());

            }

            else
            {
                MessageBox.Show("Plz select your worksspace to perfrome!!!!");
                Application.Run(new Path_cre());
            }

            this.Hide();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
