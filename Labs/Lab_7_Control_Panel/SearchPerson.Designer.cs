namespace Midterm
{
    partial class SearchPerson
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
            this.btnSearchAPerson = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastNameBox = new System.Windows.Forms.TextBox();
            this.txtFirstNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchAPerson
            // 
            this.btnSearchAPerson.Location = new System.Drawing.Point(299, 116);
            this.btnSearchAPerson.Name = "btnSearchAPerson";
            this.btnSearchAPerson.Size = new System.Drawing.Size(182, 44);
            this.btnSearchAPerson.TabIndex = 4;
            this.btnSearchAPerson.Text = "Search a person";
            this.btnSearchAPerson.UseVisualStyleBackColor = true;
            this.btnSearchAPerson.Click += new System.EventHandler(this.btnSearchAPerson_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 166);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(776, 272);
            this.dgvResults.TabIndex = 5;
            this.dgvResults.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name:";
            // 
            // txtLastNameBox
            // 
            this.txtLastNameBox.Location = new System.Drawing.Point(525, 49);
            this.txtLastNameBox.Name = "txtLastNameBox";
            this.txtLastNameBox.Size = new System.Drawing.Size(199, 20);
            this.txtLastNameBox.TabIndex = 7;
            // 
            // txtFirstNameBox
            // 
            this.txtFirstNameBox.Location = new System.Drawing.Point(84, 49);
            this.txtFirstNameBox.Name = "txtFirstNameBox";
            this.txtFirstNameBox.Size = new System.Drawing.Size(199, 20);
            this.txtFirstNameBox.TabIndex = 6;
            // 
            // SearchPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastNameBox);
            this.Controls.Add(this.txtFirstNameBox);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnSearchAPerson);
            this.Name = "SearchPerson";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchAPerson;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastNameBox;
        private System.Windows.Forms.TextBox txtFirstNameBox;
    }
}