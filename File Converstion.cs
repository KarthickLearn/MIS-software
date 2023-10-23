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
    public partial class File_Converstion : Form
    {
        public File_Converstion()
        {
            InitializeComponent();
        }
        Excel ex = Excel.Getobj();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ex.ExtentionConvert();
            MessageBox.Show("File sucessfully converted to sepcify path!!!");
        }

        
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ex.LCF_File_Check();
            for (int i= 2; ex.Readcell(i,38) != null; i++)
            {
                if(ex.Readcell(i,45) == "Yes")
                {
                    PracticeNameList.Items.Add(ex.Readcell(i, 39));
                    LCFColumList.Items.Add(ex.Readcell(i, 49));
                }



            } 



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
