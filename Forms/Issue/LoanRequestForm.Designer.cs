namespace Device_Managament_App.Forms.Issue
{
    partial class LoanRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanRequestForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newMDIChildView = new System.Windows.Forms.ToolStripMenuItem();
            this.newMDIViewHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReviewRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMDIChildView,
            this.newMDIViewHistory,
            this.tsmReviewRequest});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newMDIChildView
            // 
            this.newMDIChildView.Name = "newMDIChildView";
            this.newMDIChildView.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMDIChildView.Size = new System.Drawing.Size(43, 20);
            this.newMDIChildView.Text = "&New";
            this.newMDIChildView.Click += new System.EventHandler(this.newMDIChildView_Click);
            // 
            // newMDIViewHistory
            // 
            this.newMDIViewHistory.Name = "newMDIViewHistory";
            this.newMDIViewHistory.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.newMDIViewHistory.Size = new System.Drawing.Size(85, 20);
            this.newMDIViewHistory.Text = "View &History";
            this.newMDIViewHistory.Click += new System.EventHandler(this.newMDIViewHistory_Click);
            // 
            // tsmReviewRequest
            // 
            this.tsmReviewRequest.Enabled = false;
            this.tsmReviewRequest.Name = "tsmReviewRequest";
            this.tsmReviewRequest.Size = new System.Drawing.Size(106, 20);
            this.tsmReviewRequest.Text = "Review Requests";
            this.tsmReviewRequest.Visible = false;
            this.tsmReviewRequest.Click += new System.EventHandler(this.tsmReviewRequest_Click);
            // 
            // LoanRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoanRequestForm";
            this.Text = "LoanRequestForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoanRequestForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newMDIChildView;
        private System.Windows.Forms.ToolStripMenuItem newMDIViewHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmReviewRequest;
    }
}