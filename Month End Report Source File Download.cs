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
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Excel ex = Excel.Getobj();

        private void comboBoxBMName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ex.monthendclear();
            textBox1.Text = ex.Readcell(29, 2) + ex.Readcell(29, 3) + "\\"+ comboBoxBMName.Text ;

            for (int i = 2; ex.Readcell(i, 19) != null; i++)
            {
                if (comboBoxBMName.Text == ex.Readcell(i, 19))
                {
                    comboBoxTLName.Text = ex.Readcell(i, 20);

                }
            }

            comboPracticeName.Items.Clear();
            comboPracticeName.Text = "";
            comboPracticeName.Items.Add("All");
            for (int i = 2; ex.Readcell(i, 38) != null; i++)
            {
                ex.Writecell(i, 45, "");
                if (comboBoxBMName.Text == ex.Readcell(i, 38) && ex.Readcell(i, 40) == "Yes")
                {
                    comboPracticeName.Items.Add(ex.Readcell(i, 39));

                }
            }















        }

        private void Source_Load(object sender, EventArgs e)


        {
            textBox1.Text = ex.Readcell(29, 2) + ex.Readcell(29, 3);
            
            for (int i = 2; ex.Readcell(i, 19) != null; i++) { 
                
                comboBoxBMName.Items.Add(ex.Readcell(i, 19));

                comboBoxTLName.Items.Add(ex.Readcell(i, 20));
            }


            comboPracticeName.Items.Add("All");
            for (int i = 2; ex.Readcell(i, 38) != null; i++)
            {
                ex.Writecell(i, 45, "");
                if(ex.Readcell(i,40) == "Yes") { 
                comboPracticeName.Items.Add(ex.Readcell(i, 39));
                }
            }





        }

        private void comboBoxTLName_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 2; ex.Readcell(i, 19) != null; i++)
            {


                if (comboBoxTLName.Text == ex.Readcell(i, 20))
                {
                    comboBoxBMName.Text = ex.Readcell(i, 19);
                }
            }
        }

        private void PracticeListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboPracticeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int  i = 2; ex.Readcell(i,38) != null; i++)
            {
                ex.Writecell(i, 45, "");
                if (comboPracticeName.Text == "All" )
                {
                    if (ex.Readcell(i, 38) == comboBoxBMName.Text && ex.Readcell(i, 40) == "Yes")
                    {
                        ex.Writecell(i, 45, "Yes");
                    }
                }
                else { 
                    if(ex.Readcell(i, 39) == comboPracticeName.Text && ex.Readcell(i, 40) == "Yes")
                    {
                        ex.Writecell(i, 45, "Yes");

                    }




                }

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach(string file in droppedFiles)
            {

               
               
                string filename = getfilename(file);
                FileListBox.Items.Add(filename);
                try { 
                File.Copy(file, textBox1.Text+ "\\"+ filename +Path.GetExtension(file));
                }
                catch
                {
                    
                    MessageBox.Show ("Unable copy this file plz copy and place to folder your self!!!");
                }
            }


        }


        public string getfilename( string path)
        {

            return Path.GetFileNameWithoutExtension(path);
        }






        private void panel2_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
