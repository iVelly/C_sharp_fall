namespace Final_Project
{
    partial class HomeScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.btnSearchPlayer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnCalAvgHealth = new System.Windows.Forms.Button();
            this.btnCalTotHours = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.Better_dancing;
            this.pictureBox1.Location = new System.Drawing.Point(33, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnAddPlayer.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.ForeColor = System.Drawing.Color.Black;
            this.btnAddPlayer.Location = new System.Drawing.Point(434, 146);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(162, 81);
            this.btnAddPlayer.TabIndex = 3;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnUpdatePlayer.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePlayer.ForeColor = System.Drawing.Color.Black;
            this.btnUpdatePlayer.Location = new System.Drawing.Point(613, 146);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(162, 81);
            this.btnUpdatePlayer.TabIndex = 4;
            this.btnUpdatePlayer.Text = "Update Player";
            this.btnUpdatePlayer.UseVisualStyleBackColor = false;
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // btnSearchPlayer
            // 
            this.btnSearchPlayer.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSearchPlayer.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPlayer.ForeColor = System.Drawing.Color.Black;
            this.btnSearchPlayer.Location = new System.Drawing.Point(434, 233);
            this.btnSearchPlayer.Name = "btnSearchPlayer";
            this.btnSearchPlayer.Size = new System.Drawing.Size(162, 81);
            this.btnSearchPlayer.TabIndex = 5;
            this.btnSearchPlayer.Text = "Search for Player";
            this.btnSearchPlayer.UseVisualStyleBackColor = false;
            this.btnSearchPlayer.Click += new System.EventHandler(this.btnSearchPlayer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 32.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(216, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(396, 71);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Player Manager";
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnDeletePlayer.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlayer.ForeColor = System.Drawing.Color.Black;
            this.btnDeletePlayer.Location = new System.Drawing.Point(613, 233);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(162, 81);
            this.btnDeletePlayer.TabIndex = 7;
            this.btnDeletePlayer.Text = "Delete Player";
            this.btnDeletePlayer.UseVisualStyleBackColor = false;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click_1);
            // 
            // btnCalAvgHealth
            // 
            this.btnCalAvgHealth.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnCalAvgHealth.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalAvgHealth.ForeColor = System.Drawing.Color.Black;
            this.btnCalAvgHealth.Location = new System.Drawing.Point(434, 320);
            this.btnCalAvgHealth.Name = "btnCalAvgHealth";
            this.btnCalAvgHealth.Size = new System.Drawing.Size(162, 81);
            this.btnCalAvgHealth.TabIndex = 8;
            this.btnCalAvgHealth.Text = "Calculate Avg Health";
            this.btnCalAvgHealth.UseVisualStyleBackColor = false;
            this.btnCalAvgHealth.Click += new System.EventHandler(this.btnCalTotRev_Click);
            // 
            // btnCalTotHours
            // 
            this.btnCalTotHours.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnCalTotHours.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalTotHours.ForeColor = System.Drawing.Color.Black;
            this.btnCalTotHours.Location = new System.Drawing.Point(613, 320);
            this.btnCalTotHours.Name = "btnCalTotHours";
            this.btnCalTotHours.Size = new System.Drawing.Size(162, 81);
            this.btnCalTotHours.TabIndex = 9;
            this.btnCalTotHours.Text = "Calculate Total Hrs";
            this.btnCalTotHours.UseVisualStyleBackColor = false;
            this.btnCalTotHours.Click += new System.EventHandler(this.btnCalTotHours_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Final_Project.Properties.Resources.pink_blue_gradient;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalTotHours);
            this.Controls.Add(this.btnCalAvgHealth);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearchPlayer);
            this.Controls.Add(this.btnUpdatePlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnUpdatePlayer;
        private System.Windows.Forms.Button btnSearchPlayer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnCalAvgHealth;
        private System.Windows.Forms.Button btnCalTotHours;
    }
}

