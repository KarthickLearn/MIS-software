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
    public partial class Openfilefolder : Form
    {
        
        
        public Openfilefolder()
        {
            InitializeComponent();
            
            
        }

        public string fun = "";
       
        private void butChoose_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txtfilechossing.Text = ofd.FileName;
        }

        private void butUpload_Click(object sender, EventArgs e)
        {
            File.Copy( txtfilechossing.Text, fun);
            ActiveForm.Close();
            Method.restrict = 0;
        }

        private void butCansel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            Method.restrict = 0;
        }

        public void Filename(string fname)
        {

            labMissingFIleName.Text = "We need this file for further process. Hence kindly select this " + fname + " Now!!!";

        }

    }
}
