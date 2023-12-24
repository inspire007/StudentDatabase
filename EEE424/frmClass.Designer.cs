namespace EEE424
{
    partial class frmClass
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
            this.txtBoxClass = new System.Windows.Forms.TextBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxClass
            // 
            this.txtBoxClass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxClass.Location = new System.Drawing.Point(89, 25);
            this.txtBoxClass.Name = "txtBoxClass";
            this.txtBoxClass.Size = new System.Drawing.Size(188, 21);
            this.txtBoxClass.TabIndex = 0;
            // 
            // cmdOk
            // 
            this.cmdOk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOk.Location = new System.Drawing.Point(220, 64);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(57, 23);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(89, 64);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(58, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 128);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.txtBoxClass);
            this.Name = "frmClass";
            this.Text = "Level Term";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxClass;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
    }
}