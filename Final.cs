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
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
            dateTimeCurrentMonth.Value = DateTime.Today.AddDays(1);
        }

        Excel ex = Excel.Getobj();

        public static DateTime Monthendpreparedate;

        static DateTime dt;
        public void Nofdayinmonthend()
        {
            DateTime dt = dateTimeCurrentMonth.Value;
            Monthendpreparedate = dt;
            dateLasteBeforeMonth.Value = dt.AddMonths(-2);
            int days = Int16.Parse(dt.ToString("dd"));
            dateTimeLastMonth.Value = dt.AddMonths(-1);
            dateTimeCurrentMonth.Value = dt.AddDays(-days + 1);


            DateTime Lbm = dateLasteBeforeMonth.Value;
            DateTime lm = dateTimeLastMonth.Value;
            
            textBoxNoofTotaldays.Text = DateTime.DaysInMonth(Int16.Parse(lm.ToString("yyyy")), Int16.Parse(lm.ToString("MM"))).ToString();

            ex.Writecell(3, 37, Lbm.ToString("MMM") + "'" + Lbm.ToString("yyyy"));
            ex.Writecell(4, 37, Lbm.ToString("MMM") + "'" + Lbm.ToString("yy"));

            ex.Writecell(5, 37, lm.ToString("MMM") + "'" + lm.ToString("yyyy"));
            ex.Writecell(6, 37, lm.ToString("MMM") + "'" + lm.ToString("yy"));

            ex.Writecell(7, 37, dateTimeCurrentMonth.Text);
            textBoxNoofWorkingDays.Text =  ex.Readcelldouble(8, 37).ToString();
            ex.Writecell(9, 37, textBoxNoofTotaldays.Text);


            
        }

        


        private void Final_Load(object sender, EventArgs e)
        {
            Nofdayinmonthend();

            AddingPracticeName();
        }

        private void dateTimeCurrentMonth_ValueChanged(object sender, EventArgs e)
        {
            Nofdayinmonthend();
        }

        private void textBoxNoofWorkingDays_TextChanged(object sender, EventArgs e)
        {
            ex.Writecell(8, 37, textBoxNoofWorkingDays.Text);
        }

        private void butMonthEndReport_Click(object sender, EventArgs e)
        {
            ex.MonthEndReport();
            butMonthEndReport.BackColor = Color.LightGreen;
            MessageBox.Show("Month End Report is ready plz check!!!");
            AddingPracticeName();
            objectclose();


        }

        public void AddingPracticeName()
        {
            
            comboPraticeFileName.Items.Clear(); 
            string bmname;
            string fpath;
            for (int i = 2; ex.Readcell(i,38) != null; i++)
            {
                if (ex.Readcell(i,45) == "Yes")
                {
                    bmname = ex.Readcell(i, 38);
                    fpath = ex.Readcell(26, 2) + ex.Readcell(26, 3) + "\\" + bmname + "\\";
                    string[] filepath = Directory.GetFiles(fpath, "*.xlsx");

                    foreach (string file in filepath)
                        try { 
                        comboPraticeFileName.Items.Add(Path.GetFileName(Path.GetFileNameWithoutExtension(file)));
                        }
                        catch { }

                    break;

                }
            }

            
        }

        public void objectclose()
        {
            ex.Close();
        }


        private void comboPraticeFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Excel ex = Excel.Getobj();
            string bmname;
            string fpath;
            for (int i = 2; ex.Readcell(i, 38) != null; i++)
            {
                if (ex.Readcell(i, 45) == "Yes")
                {
                    bmname = ex.Readcell(i, 38);
                    fpath = ex.Readcell(26, 2) + ex.Readcell(26, 3) + "\\" + bmname + "\\";
                    ex.Openexcelfile(fpath, comboPraticeFileName.Text);
                    break;
                }
            }

            AddingPracticeName();


        }
    }
}
