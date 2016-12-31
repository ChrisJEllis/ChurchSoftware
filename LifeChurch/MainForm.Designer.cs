namespace LifeChurch
{
    partial class MainForm
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
            this.ChurchMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.evangelismToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveInterestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChurchMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChurchMainMenuStrip
            // 
            this.ChurchMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evangelismToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.ChurchMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ChurchMainMenuStrip.Name = "ChurchMainMenuStrip";
            this.ChurchMainMenuStrip.Size = new System.Drawing.Size(434, 24);
            this.ChurchMainMenuStrip.TabIndex = 0;
            this.ChurchMainMenuStrip.Text = "menuStrip1";
            // 
            // evangelismToolStripMenuItem
            // 
            this.evangelismToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.evangelismToolStripMenuItem.Name = "evangelismToolStripMenuItem";
            this.evangelismToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.evangelismToolStripMenuItem.Text = "Evangelism";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestCardsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // guestCardsToolStripMenuItem
            // 
            this.guestCardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRemoveInterestsToolStripMenuItem});
            this.guestCardsToolStripMenuItem.Name = "guestCardsToolStripMenuItem";
            this.guestCardsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guestCardsToolStripMenuItem.Text = "Guest Cards";
            // 
            // addRemoveInterestsToolStripMenuItem
            // 
            this.addRemoveInterestsToolStripMenuItem.Name = "addRemoveInterestsToolStripMenuItem";
            this.addRemoveInterestsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addRemoveInterestsToolStripMenuItem.Text = "Add / Remove Interests";
            this.addRemoveInterestsToolStripMenuItem.Click += new System.EventHandler(this.addRemoveInterestsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 193);
            this.Controls.Add(this.ChurchMainMenuStrip);
            this.Name = "MainForm";
            this.Text = "Life Church";
            this.ChurchMainMenuStrip.ResumeLayout(false);
            this.ChurchMainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ChurchMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem evangelismToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveInterestsToolStripMenuItem;
    }
}

