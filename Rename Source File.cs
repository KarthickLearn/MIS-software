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
    public partial class Rename_Source_File : Form
    {
        public Rename_Source_File()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        Excel ex = Excel.Getobj();
        private void Rename_Source_File_Load(object sender, EventArgs e)
        {
                    }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DaysheetCorrectList.Items.Clear();
            ex.Daysheet_File_Finding();
            for (int i = 2; ex.Readcell(i, 38) != null; i++)
            {
                if (ex.Readcell(i, 46) == "File Name is incorrect")
                {
                    DaysheetCorrectList.Items.Add(ex.Readcell(i, 42));
                   

                }
            }




        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            LCFcorrectList.Items.Clear();
            ex.LCF_File_Finding();
            for (int i = 2; ex.Readcell(i, 38) != null; i++)
            {
                
                if (ex.Readcell(i, 48) == "File Name is incorrect")
                {
                    LCFcorrectList.Items.Add(ex.Readcell(i, 44));
                    
                }
            }




        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            AgingCorrectList.Items.Clear();
            ex.Aging_File_Finding();
            for (int i = 2; ex.Readcell(i, 38) != null; i++)
            {
                
                if (ex.Readcell(i, 47) == "File Name is incorrect")
                {
                    AgingCorrectList.Items.Add(ex.Readcell(i, 43));
                    

                }
            }
            



        }

        private void DaysheetCorrectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string na = DaysheetCorrectList.SelectedItem.ToString();
            Clipboard.SetText(na);
        }

        private void LCFcorrectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(LCFcorrectList.SelectedItem.ToString());  
        }

        private void AgingCorrectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(AgingCorrectList.SelectedItem.ToString());
        }
    }
}
