namespace Final_Project
{
    partial class FillOutInfo
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
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPlayingSince = new System.Windows.Forms.DateTimePicker();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoursPlayed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudLives = new System.Windows.Forms.NumericUpDown();
            this.nudHealth = new System.Windows.Forms.NumericUpDown();
            this.nudStrength = new System.Windows.Forms.NumericUpDown();
            this.nudArmor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudLives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(206, 105);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(204, 29);
            this.txtPlayerName.TabIndex = 35;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtNameOfEvent_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 33);
            this.label11.TabIndex = 34;
            this.label11.Text = "Playing Since:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 33);
            this.label10.TabIndex = 33;
            this.label10.Text = "Player Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 33);
            this.label9.TabIndex = 32;
            this.label9.Text = "Lives:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 33);
            this.label2.TabIndex = 42;
            this.label2.Text = "Strength:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 33);
            this.label3.TabIndex = 41;
            this.label3.Text = "Armor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 32.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 71);
            this.label4.TabIndex = 47;
            this.label4.Text = "Player Information";
            // 
            // dtpPlayingSince
            // 
            this.dtpPlayingSince.Location = new System.Drawing.Point(206, 322);
            this.dtpPlayingSince.Name = "dtpPlayingSince";
            this.dtpPlayingSince.Size = new System.Drawing.Size(204, 20);
            this.dtpPlayingSince.TabIndex = 49;
            this.dtpPlayingSince.ValueChanged += new System.EventHandler(this.dtpWhen_ValueChanged);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnDeletePlayer.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlayer.ForeColor = System.Drawing.Color.Black;
            this.btnDeletePlayer.Location = new System.Drawing.Point(562, 198);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(169, 45);
            this.btnDeletePlayer.TabIndex = 52;
            this.btnDeletePlayer.Text = "Delete Player";
            this.btnDeletePlayer.UseVisualStyleBackColor = false;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnUpdatePlayer.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePlayer.ForeColor = System.Drawing.Color.Black;
            this.btnUpdatePlayer.Location = new System.Drawing.Point(562, 147);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(169, 45);
            this.btnUpdatePlayer.TabIndex = 51;
            this.btnUpdatePlayer.Text = "Update Player";
            this.btnUpdatePlayer.UseVisualStyleBackColor = false;
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnAddPlayer.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.ForeColor = System.Drawing.Color.Black;
            this.btnAddPlayer.Location = new System.Drawing.Point(562, 101);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(169, 45);
            this.btnAddPlayer.TabIndex = 50;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.BackColor = System.Drawing.Color.Transparent;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F);
            this.lblFeedback.Location = new System.Drawing.Point(21, 361);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 29);
            this.lblFeedback.TabIndex = 53;
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerID.Location = new System.Drawing.Point(3, 9);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(53, 13);
            this.lblPlayerID.TabIndex = 54;
            this.lblPlayerID.Text = "Player ID:";
            this.lblPlayerID.Click += new System.EventHandler(this.lblEventID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 56;
            this.label1.Text = "Health:";
            // 
            // txtHoursPlayed
            // 
            this.txtHoursPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursPlayed.Location = new System.Drawing.Point(206, 175);
            this.txtHoursPlayed.Name = "txtHoursPlayed";
            this.txtHoursPlayed.Size = new System.Drawing.Size(204, 29);
            this.txtHoursPlayed.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 33);
            this.label5.TabIndex = 59;
            this.label5.Text = "Hours Played:";
            // 
            // nudLives
            // 
            this.nudLives.Location = new System.Drawing.Point(206, 146);
            this.nudLives.Name = "nudLives";
            this.nudLives.Size = new System.Drawing.Size(204, 20);
            this.nudLives.TabIndex = 61;
            // 
            // nudHealth
            // 
            this.nudHealth.Location = new System.Drawing.Point(206, 219);
            this.nudHealth.Name = "nudHealth";
            this.nudHealth.Size = new System.Drawing.Size(204, 20);
            this.nudHealth.TabIndex = 62;
            // 
            // nudStrength
            // 
            this.nudStrength.Location = new System.Drawing.Point(206, 254);
            this.nudStrength.Name = "nudStrength";
            this.nudStrength.Size = new System.Drawing.Size(204, 20);
            this.nudStrength.TabIndex = 63;
            // 
            // nudArmor
            // 
            this.nudArmor.Location = new System.Drawing.Point(206, 280);
            this.nudArmor.Name = "nudArmor";
            this.nudArmor.Size = new System.Drawing.Size(204, 20);
            this.nudArmor.TabIndex = 64;
            // 
            // FillOutInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.pink_blue_gradient;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudArmor);
            this.Controls.Add(this.nudStrength);
            this.Controls.Add(this.nudHealth);
            this.Controls.Add(this.nudLives);
            this.Controls.Add(this.txtHoursPlayed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnUpdatePlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.dtpPlayingSince);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "FillOutInfo";
            this.Text = "Party Information";
            this.Load += new System.EventHandler(this.FillOutInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPlayingSince;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnUpdatePlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoursPlayed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudLives;
        private System.Windows.Forms.NumericUpDown nudHealth;
        private System.Windows.Forms.NumericUpDown nudStrength;
        private System.Windows.Forms.NumericUpDown nudArmor;
    }
}