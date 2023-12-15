namespace Final_Project
{
    partial class AverageScreen
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
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCalTotHrs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.BackColor = System.Drawing.Color.MediumPurple;
            this.lstPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 24;
            this.lstPlayers.Location = new System.Drawing.Point(12, 150);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(776, 124);
            this.lstPlayers.TabIndex = 65;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.BackColor = System.Drawing.Color.Transparent;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F);
            this.lblFeedback.Location = new System.Drawing.Point(261, 337);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 29);
            this.lblFeedback.TabIndex = 64;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 32.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(231, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(534, 71);
            this.lblTitle.TabIndex = 63;
            this.lblTitle.Text = "Average Hours Played";
            // 
            // btnCalTotHrs
            // 
            this.btnCalTotHrs.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnCalTotHrs.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalTotHrs.ForeColor = System.Drawing.Color.Black;
            this.btnCalTotHrs.Location = new System.Drawing.Point(301, 380);
            this.btnCalTotHrs.Name = "btnCalTotHrs";
            this.btnCalTotHrs.Size = new System.Drawing.Size(213, 58);
            this.btnCalTotHrs.TabIndex = 62;
            this.btnCalTotHrs.Text = "Calculate Hours";
            this.btnCalTotHrs.UseVisualStyleBackColor = false;
            this.btnCalTotHrs.Click += new System.EventHandler(this.btnCalTotHrs_Click);
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
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // AverageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.pink_blue_gradient;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCalTotHrs);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AverageScreen";
            this.Text = "AverageScreen";
            this.Load += new System.EventHandler(this.AverageScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCalTotHrs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}