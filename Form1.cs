namespace MIS
{


    public partial class Path_cre : Form
    {

        
        public Path_cre()
        {
            InitializeComponent();
             

        }
        

        Method method = Method.Getobj();
        MIS_Report mis = new MIS_Report();
        Excel ex = Excel.Getobj();



        public void btnBrowse_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fopen = new FolderBrowserDialog();
            fopen.ShowDialog();
            txtPath.Text = fopen.SelectedPath;
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

       private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (this.txtPath.Text == "")
            {

                 MessageBox.Show("Kindly select the path location...!!");

             }
            else
             {

                 method.FolderCreation(txtPath.Text, "MIS Folder");
                 if (radiobtnDefultpath.Checked)
                 {
                                        
                    ex.Writecell(1, 3, txtPath.Text);
                    ex.Save();
                    
                 }

                ActiveForm.Hide();

                mis.Show();
                


            }
            
    }

        private void Path_cre_Load(object sender, EventArgs e)
        {
            

           
        }
        

    }
    }
