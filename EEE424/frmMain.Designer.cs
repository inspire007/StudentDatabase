namespace EEE424
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMi = new System.Windows.Forms.TextBox();
            this.txtBoxMa = new System.Windows.Forms.TextBox();
            this.txtBoxNa = new System.Windows.Forms.TextBox();
            this.txtBoxSt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPDFReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReport11 = new EEE424.CrystalReport1();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(299, 36);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(110, 18);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Level X Term X";
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.cmdPrint);
            this.grpBox1.Controls.Add(this.dataGridView1);
            this.grpBox1.Controls.Add(this.cmdDelete);
            this.grpBox1.Controls.Add(this.cmdInsert);
            this.grpBox1.Controls.Add(this.cmdUpdate);
            this.grpBox1.Controls.Add(this.cmdBrowse);
            this.grpBox1.Controls.Add(this.label5);
            this.grpBox1.Controls.Add(this.label4);
            this.grpBox1.Controls.Add(this.label3);
            this.grpBox1.Controls.Add(this.label2);
            this.grpBox1.Controls.Add(this.txtBoxMi);
            this.grpBox1.Controls.Add(this.txtBoxMa);
            this.grpBox1.Controls.Add(this.txtBoxNa);
            this.grpBox1.Controls.Add(this.txtBoxSt);
            this.grpBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.Location = new System.Drawing.Point(33, 62);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(619, 440);
            this.grpBox1.TabIndex = 1;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Student Record";
            this.grpBox1.Visible = false;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrint.Location = new System.Drawing.Point(486, 222);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(75, 23);
            this.cmdPrint.TabIndex = 3;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id,
            this.sname,
            this.major,
            this.minor});
            this.dataGridView1.Location = new System.Drawing.Point(25, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(544, 169);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // student_id
            // 
            this.student_id.HeaderText = "Student No.";
            this.student_id.Name = "student_id";
            // 
            // sname
            // 
            this.sname.HeaderText = "Name";
            this.sname.Name = "sname";
            this.sname.Width = 200;
            // 
            // major
            // 
            this.major.HeaderText = "Major Group";
            this.major.Name = "major";
            // 
            // minor
            // 
            this.minor.HeaderText = "Minor Group";
            this.minor.Name = "minor";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Location = new System.Drawing.Point(371, 222);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdInsert
            // 
            this.cmdInsert.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInsert.Location = new System.Drawing.Point(261, 222);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(75, 23);
            this.cmdInsert.TabIndex = 2;
            this.cmdInsert.Text = "Insert";
            this.cmdInsert.UseVisualStyleBackColor = true;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate.Location = new System.Drawing.Point(158, 222);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 2;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowse.Location = new System.Drawing.Point(46, 222);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowse.TabIndex = 2;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Minor Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Major Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student No";
            // 
            // txtBoxMi
            // 
            this.txtBoxMi.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMi.Location = new System.Drawing.Point(261, 167);
            this.txtBoxMi.Name = "txtBoxMi";
            this.txtBoxMi.Size = new System.Drawing.Size(300, 20);
            this.txtBoxMi.TabIndex = 0;
            // 
            // txtBoxMa
            // 
            this.txtBoxMa.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMa.Location = new System.Drawing.Point(261, 117);
            this.txtBoxMa.Name = "txtBoxMa";
            this.txtBoxMa.Size = new System.Drawing.Size(300, 20);
            this.txtBoxMa.TabIndex = 0;
            // 
            // txtBoxNa
            // 
            this.txtBoxNa.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNa.Location = new System.Drawing.Point(261, 71);
            this.txtBoxNa.Name = "txtBoxNa";
            this.txtBoxNa.Size = new System.Drawing.Size(300, 20);
            this.txtBoxNa.TabIndex = 0;
            // 
            // txtBoxSt
            // 
            this.txtBoxSt.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSt.Location = new System.Drawing.Point(261, 30);
            this.txtBoxSt.Name = "txtBoxSt";
            this.txtBoxSt.Size = new System.Drawing.Size(300, 20);
            this.txtBoxSt.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeClassToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeClassToolStripMenuItem
            // 
            this.changeClassToolStripMenuItem.Name = "changeClassToolStripMenuItem";
            this.changeClassToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.changeClassToolStripMenuItem.Text = "Change Class";
            this.changeClassToolStripMenuItem.Click += new System.EventHandler(this.changeClassToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crystalReportToolStripMenuItem,
            this.createPDFReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // crystalReportToolStripMenuItem
            // 
            this.crystalReportToolStripMenuItem.Name = "crystalReportToolStripMenuItem";
            this.crystalReportToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.crystalReportToolStripMenuItem.Text = "Crystal Report";
            this.crystalReportToolStripMenuItem.Click += new System.EventHandler(this.crystalReportToolStripMenuItem_Click);
            // 
            // createPDFReportToolStripMenuItem
            // 
            this.createPDFReportToolStripMenuItem.Name = "createPDFReportToolStripMenuItem";
            this.createPDFReportToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.createPDFReportToolStripMenuItem.Text = "Create PDF Report";
            this.createPDFReportToolStripMenuItem.Click += new System.EventHandler(this.createPDFReportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseDatabaseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseDatabaseToolStripMenuItem
            // 
            this.howToUseDatabaseToolStripMenuItem.Name = "howToUseDatabaseToolStripMenuItem";
            this.howToUseDatabaseToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.howToUseDatabaseToolStripMenuItem.Text = "How to use database";
            this.howToUseDatabaseToolStripMenuItem.Click += new System.EventHandler(this.howToUseDatabaseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 504);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Menu. File and Database management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label lblClass;
        protected internal System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.TextBox txtBoxMi;
        private System.Windows.Forms.TextBox txtBoxMa;
        private System.Windows.Forms.TextBox txtBoxNa;
        private System.Windows.Forms.TextBox txtBoxSt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseDatabaseToolStripMenuItem;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn major;
        private System.Windows.Forms.DataGridViewTextBoxColumn minor;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crystalReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPDFReportToolStripMenuItem;
        private CrystalReport1 crystalReport11;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

