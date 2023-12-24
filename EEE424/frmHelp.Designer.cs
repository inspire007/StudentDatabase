namespace EEE424
{
    partial class frmHelp
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
            this.txtBox_help = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_help
            // 
            this.txtBox_help.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_help.Location = new System.Drawing.Point(0, -1);
            this.txtBox_help.Multiline = true;
            this.txtBox_help.Name = "txtBox_help";
            this.txtBox_help.ReadOnly = true;
            this.txtBox_help.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_help.Size = new System.Drawing.Size(603, 431);
            this.txtBox_help.TabIndex = 0;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 434);
            this.Controls.Add(this.txtBox_help);
            this.Name = "frmHelp";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_help;
    }
}