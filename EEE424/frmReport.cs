using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EEE424
{   
    public partial class frmReport : Form
    {
        private OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath
    + "\\data\\student.accdb");

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            CrystalReport1 myReport = new CrystalReport1();
            crystalReportViewer1.ReportSource = myReport;
        }
    }
}
