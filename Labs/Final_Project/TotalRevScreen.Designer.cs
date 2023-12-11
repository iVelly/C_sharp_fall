namespace Final_Project
{
    partial class TotalRevScreen
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCalculateTotalRevenue = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lstEvents = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 32.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(231, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(357, 71);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Total Revenue";
            // 
            // btnCalculateTotalRevenue
            // 
            this.btnCalculateTotalRevenue.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnCalculateTotalRevenue.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTotalRevenue.ForeColor = System.Drawing.Color.Black;
            this.btnCalculateTotalRevenue.Location = new System.Drawing.Point(301, 380);
            this.btnCalculateTotalRevenue.Name = "btnCalculateTotalRevenue";
            this.btnCalculateTotalRevenue.Size = new System.Drawing.Size(213, 58);
            this.btnCalculateTotalRevenue.TabIndex = 9;
            this.btnCalculateTotalRevenue.Text = "Calculate Revenue";
            this.btnCalculateTotalRevenue.UseVisualStyleBackColor = false;
            this.btnCalculateTotalRevenue.Click += new System.EventHandler(this.btnCalculateTotalRevenue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.Better_dancing;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.BackColor = System.Drawing.Color.Transparent;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F);
            this.lblFeedback.Location = new System.Drawing.Point(261, 337);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 29);
            this.lblFeedback.TabIndex = 54;
            // 
            // lstEvents
            // 
            this.lstEvents.BackColor = System.Drawing.Color.MediumPurple;
            this.lstEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 24;
            this.lstEvents.Location = new System.Drawing.Point(12, 150);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(776, 124);
            this.lstEvents.TabIndex = 55;
            // 
            // TotalRevScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.pink_blue_gradient;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCalculateTotalRevenue);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TotalRevScreen";
            this.Text = "TotalRevScreen";
            this.Load += new System.EventHandler(this.TotalRevScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCalculateTotalRevenue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.ListBox lstEvents;
    }
}