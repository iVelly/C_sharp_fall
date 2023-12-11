namespace Final_Project
{
    partial class SearchEvent
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
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnSearchEvent = new System.Windows.Forms.Button();
            this.txtNameOfEventBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 166);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(776, 272);
            this.dgvResults.TabIndex = 11;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            // 
            // btnSearchEvent
            // 
            this.btnSearchEvent.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSearchEvent.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEvent.ForeColor = System.Drawing.Color.Black;
            this.btnSearchEvent.Location = new System.Drawing.Point(319, 115);
            this.btnSearchEvent.Name = "btnSearchEvent";
            this.btnSearchEvent.Size = new System.Drawing.Size(169, 45);
            this.btnSearchEvent.TabIndex = 52;
            this.btnSearchEvent.Text = "Search Event";
            this.btnSearchEvent.UseVisualStyleBackColor = false;
            this.btnSearchEvent.Click += new System.EventHandler(this.btnSearchEvent_Click);
            // 
            // txtNameOfEventBox
            // 
            this.txtNameOfEventBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOfEventBox.Location = new System.Drawing.Point(388, 54);
            this.txtNameOfEventBox.Name = "txtNameOfEventBox";
            this.txtNameOfEventBox.Size = new System.Drawing.Size(259, 29);
            this.txtNameOfEventBox.TabIndex = 54;
            this.txtNameOfEventBox.TextChanged += new System.EventHandler(this.txtNameOfEventBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(217, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 33);
            this.label10.TabIndex = 53;
            this.label10.Text = "Name of Event:";
            // 
            // SearchEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.pink_blue_gradient;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNameOfEventBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSearchEvent);
            this.Controls.Add(this.dgvResults);
            this.Name = "SearchEvent";
            this.Text = "Search Events";
            this.Load += new System.EventHandler(this.SearchEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnSearchEvent;
        private System.Windows.Forms.TextBox txtNameOfEventBox;
        private System.Windows.Forms.Label label10;
    }
}