using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Drawing.Printing;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace EEE424
{
    public partial class frmMain : Form
    {
        private OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath
    + "\\data\\student.accdb");

        public frmMain()
        {
            InitializeComponent();
        }


        private void changeClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass frmClass = new frmClass(this);
            frmClass.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("LevelTerm.txt"))
            {
                TextReader tr = new StreamReader("LevelTerm.txt");
                lblClass.Text = tr.ReadLine();
                tr.Close();
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql ="SELECT * from student order by student_id " + (txtBoxSt.Text == "" ? "" : "= '"+txtBoxSt.Text+"'");
            OleDbCommand dbComm = new OleDbCommand(sql, conn);
            DataSet ds = new DataSet();
            OleDbDataAdapter dbAdap = new OleDbDataAdapter(dbComm);
            dbAdap.Fill(ds);
            conn.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtBoxSt.Text = ds.Tables[0].Rows[0]["student_id"].ToString();
                txtBoxNa.Text = ds.Tables[0].Rows[0]["sname"].ToString();
                txtBoxMa.Text = ds.Tables[0].Rows[0]["major"].ToString();
                txtBoxMi.Text = ds.Tables[0].Rows[0]["minor"].ToString();
            }
            data_GridView();
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "UPDATE student SET sname='" + txtBoxNa.Text +"', major='" +
       txtBoxMa.Text + "', minor='"+txtBoxMi.Text+"' where student_id='"+txtBoxSt.Text+"'";
            OleDbCommand dbComm = new OleDbCommand(sql, conn);
            dbComm.ExecuteScalar();
            conn.Close();
            data_GridView();
            MessageBox.Show("Data updated");
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "insert into student (student_id,sname,major,minor) values ('" +
       txtBoxSt.Text + "','" + txtBoxNa.Text + "','" + txtBoxMa.Text + "','"+ txtBoxMi.Text +
        "')" ;
            OleDbCommand dbComm = new OleDbCommand(sql, conn);
            dbComm.ExecuteScalar();
            conn.Close();
            data_GridView();
            MessageBox.Show("Data inserted");
        }

        private void howToUseDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.Show();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql ="delete from student where student_id='"+ txtBoxSt.Text +"'";
            OleDbCommand dbComm = new OleDbCommand(sql, conn);
            dbComm.ExecuteScalar();
            conn.Close();
            data_GridView();
            MessageBox.Show("Data deleted");
        }
        private void data_GridView()
        {
            conn.Open();
            string sql = "SELECT student_id,sname,major,minor from student order by student_id";
            OleDbCommand dbComm = new OleDbCommand(sql, conn);
            DataSet ds = new DataSet();
            OleDbDataAdapter dbAdap = new OleDbDataAdapter(dbComm);
            dbAdap.Fill(ds);
            conn.Close();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string student_id = Convert.ToString(ds.Tables[0].Rows[i]["student_id"]);
                string sname = Convert.ToString(ds.Tables[0].Rows[i]["sname"]);
                string major = Convert.ToString(ds.Tables[0].Rows[i]["major"]);
                string minor = Convert.ToString(ds.Tables[0].Rows[i]["minor"]);
                dataGridView1.Rows.Add(student_id, sname, major, minor);
            }

            dataGridView1.Visible = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                string std_id = row.Cells[0].Value.ToString();

                conn.Open();
                string sql = "SELECT * from student where student_id = '"+std_id+"'";
                OleDbCommand dbComm = new OleDbCommand(sql, conn);
                DataSet ds = new DataSet();
                OleDbDataAdapter dbAdap = new OleDbDataAdapter(dbComm);
                dbAdap.Fill(ds);
                conn.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {

                    string student_id = Convert.ToString(ds.Tables[0].Rows[0]["student_id"]);
                    string sname = Convert.ToString(ds.Tables[0].Rows[0]["sname"]);
                    string major = Convert.ToString(ds.Tables[0].Rows[0]["major"]);
                    string minor = Convert.ToString(ds.Tables[0].Rows[0]["minor"]);

                    txtBoxSt.Text = student_id;
                    txtBoxNa.Text = sname;
                    txtBoxMa.Text = major;
                    txtBoxMi.Text = minor;

                    dataGridView1.Visible = true;
                }
                else {
                    MessageBox.Show("Student ID " + std_id + " not found in database");
                }

            }
            catch { 
            }
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            cmdPrint.Visible = false;
            PrintPreviewDialog ppd = new PrintPreviewDialog();

            ppd.Document = new PrintDocument();
            ppd.Document.PrintPage += new PrintPageEventHandler(Document_PrintPage);

            ppd.ShowDialog();
            cmdPrint.Visible = true;

        }

        void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bt = new Bitmap(this.Width, this.Height);

            float scale = 1.0f;
            scale = Math.Min(scale, (float)e.MarginBounds.Width / bt.Width);
            scale = Math.Min(scale, (float)e.MarginBounds.Height / bt.Height);

            e.Graphics.TranslateTransform(e.MarginBounds.Left + (e.MarginBounds.Width - bt.Width * scale) / 2, e.MarginBounds.Top);
            e.Graphics.ScaleTransform(scale, scale);

            DrawToBitmap(bt, new Rectangle(0, 0, this.Width, this.Height));
            RectangleF destinationRect = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF sourceRect = new RectangleF(0, 0, this.Width, this.Height);

            e.Graphics.DrawImage(bt, destinationRect, sourceRect, GraphicsUnit.Pixel);
        }

        private void crystalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.Show();            
        }

        private void createPDFReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Application.StartupPath);
            string fname = "Report.pdf";
            path = Path.GetDirectoryName(path);
            ReportDocument crystalReport = new ReportDocument();
            crystalReport.Load(path + @"\crystalReport1.rpt");
            ExportFormatType formatType = ExportFormatType.PortableDocFormat;
            crystalReport.ExportToDisk(formatType, fname);
            MessageBox.Show("Pdf created " + fname);
            System.Diagnostics.Process.Start(fname);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

