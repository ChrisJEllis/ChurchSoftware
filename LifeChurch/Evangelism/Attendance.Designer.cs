namespace LifeChurch
{
    partial class Attendance
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guestCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGuestCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvGuestGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGuestGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestCardsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guestCardsToolStripMenuItem
            // 
            this.guestCardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGuestCardMenuItem});
            this.guestCardsToolStripMenuItem.Name = "guestCardsToolStripMenuItem";
            this.guestCardsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.guestCardsToolStripMenuItem.Text = "Guest Cards";
            // 
            // NewGuestCardMenuItem
            // 
            this.NewGuestCardMenuItem.Name = "NewGuestCardMenuItem";
            this.NewGuestCardMenuItem.Size = new System.Drawing.Size(197, 22);
            this.NewGuestCardMenuItem.Text = "New";
            this.NewGuestCardMenuItem.Click += new System.EventHandler(this.NewGuestCardMenuItem_Click);
            // 
            // gvGuestGrid
            // 
            this.gvGuestGrid.AllowUserToAddRows = false;
            this.gvGuestGrid.AllowUserToDeleteRows = false;
            this.gvGuestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGuestGrid.Location = new System.Drawing.Point(6, 19);
            this.gvGuestGrid.Name = "gvGuestGrid";
            this.gvGuestGrid.ReadOnly = true;
            this.gvGuestGrid.Size = new System.Drawing.Size(743, 150);
            this.gvGuestGrid.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvGuestGrid);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 216);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGuestGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guestCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGuestCardMenuItem;
        private System.Windows.Forms.DataGridView gvGuestGrid;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}