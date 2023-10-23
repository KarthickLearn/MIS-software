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
    public partial class App_Vs_Not_App : Form i
    {

       

        public App_Vs_Not_App()
        {
            InitializeComponent();
            textUserName.Text = ex.Readcell(3, 27);
            textPassworkd.Text = ex.Readcell(3, 28);
            Value_adding();
        }

        WebLoging web = WebLoging.Getobj();
        Excel ex = Excel.Getobj();
        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            web.AppVsNoApp();
            /////////
            //////////

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ex.Writecell(1, 69, dateTimePicker1.Text);
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            ex.app_clear();
            Value_adding();
        }

        private void butLoginDrchror_Click(object sender, EventArgs e)
        {
            web.DrchronoLogin(ex.Readcell(3, 27), ex.Readcell(3, 28));
        }
    
       public void Value_adding()
        {

            


            for(int i = 2; ex.Readcell(i,67) != null;i++)
            {
                if(ex.Readcelldouble(i,64) == -255 || ex.Readcelldouble(i, 65) == -255 || ex.Readcelldouble(i, 66) == -255)
                {
                    comboBox1.Items.Add(ex.Readcell(i, 39));
                                        
                }

            }

            textCompletedAlllstatus.Text = ex.Readcelldouble(1, 70).ToString();
            textCompletedNotSub.Text = ex.Readcelldouble(1, 71).ToString();
            textCompletedLockedNotSub.Text = ex.Readcelldouble(1, 72).ToString();
            textMissingAllStatus.Text = ex.Readcelldouble(2, 70).ToString();
            textMissingNotSub.Text = ex.Readcelldouble(2, 71).ToString();
            textMissingLockedNotSub.Text = ex.Readcelldouble(2, 72).ToString();
               


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 2; ex.Readcell(i, 67) != null; i++)
            {
                if (comboBox1.Text == ex.Readcell(i, 39))
                {
                    
                    
                    textProviderName.Text =  ex.Readcell(i, 67);
                    double lastfridatedate = double.Parse(ex.Readcelldouble(i, 68).ToString());
                    var datetimelastfridatedate = DateTime.FromOADate(lastfridatedate).ToString("d");
                    textClaimStartdate.Text = datetimelastfridatedate;
                    textAllStatusNumbaer.Text = ex.Readcelldouble(i, 64).ToString().Replace("-255","");
                    textBoxNotSubNumber.Text  = ex.Readcelldouble(i, 65).ToString().Replace("-255", "");
                    textLockedNotSubNumber.Text = ex.Readcelldouble(i, 66).ToString().Replace("-255", "");

                    
                }
            }


         }

            private void textAllStatusNumbaer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxNotSubNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textLockedNotSubNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {

            for (int i = 2; ex.Readcell(i, 67) != null; i++)
            {
                if(comboBox1.Text == ex.Readcell(i, 39))
                {
                    ex.Writecell(i, 64, textAllStatusNumbaer.Text.ToString());
                    ex.Writecell(i, 65, textBoxNotSubNumber.Text.ToString());
                    ex.Writecell(i, 66, textLockedNotSubNumber.Text.ToString());
                }
                

            }
            
            
            comboBox1.Items.Clear();
            comboBox1.Text = " ";
            textAllStatusNumbaer.Clear();
            textBoxNotSubNumber.Clear();
            textLockedNotSubNumber.Clear();
            textProviderName.Clear();
            textClaimStartdate.Clear();
            Value_adding();
            ex.Save();
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {
            ex.Writecell(3, 27, textUserName.Text);
        }

        private void textPassworkd_TextChanged(object sender, EventArgs e)
        {
            ex.Writecell(3, 28, textPassworkd.Text);
        }


        private void iconButton2_MouseClick(object sender, MouseEventArgs e)
        {
            textPassworkd.UseSystemPasswordChar = false;
            
        }

        private void iconButton2_MouseCaptureChanged(object sender, EventArgs e)
        {
            textPassworkd.UseSystemPasswordChar = false;
        }

        private void iconButton2_MouseMove(object sender, MouseEventArgs e)
        {
            textPassworkd.UseSystemPasswordChar = false;
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            textPassworkd.UseSystemPasswordChar = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }






}
