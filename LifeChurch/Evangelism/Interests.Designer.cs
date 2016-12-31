namespace LifeChurch.Evangelism
{
    partial class Interests
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
            this.gvInterests = new System.Windows.Forms.DataGridView();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvInterests)).BeginInit();
            this.SuspendLayout();
            // 
            // gvInterests
            // 
            this.gvInterests.AllowUserToAddRows = false;
            this.gvInterests.AllowUserToDeleteRows = false;
            this.gvInterests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInterests.Location = new System.Drawing.Point(13, 36);
            this.gvInterests.Name = "gvInterests";
            this.gvInterests.ReadOnly = true;
            this.gvInterests.Size = new System.Drawing.Size(408, 463);
            this.gvInterests.TabIndex = 0;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(13, 11);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(257, 20);
            this.txtInterest.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(277, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(144, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit Interest";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Interests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 511);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.gvInterests);
            this.Name = "Interests";
            this.Text = "Interests";
            this.Load += new System.EventHandler(this.Interests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvInterests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvInterests;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Button btnSubmit;
    }
}