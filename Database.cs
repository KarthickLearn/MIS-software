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
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        WebLoging web = WebLoging.Getobj();
        Excel ex = Excel.Getobj();

        private void iconButton1_Click(object sender, EventArgs e)
        {
            web.Logintobox(ex.Readcell(2, 27), ex.Readcell(2, 28));
        }

        private void butMasterExceView_Click(object sender, EventArgs e)
        {
            ex.Excelvisuable();
        }
    }
}
