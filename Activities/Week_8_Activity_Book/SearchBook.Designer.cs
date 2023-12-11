namespace Lab_5_Book
{
    partial class SearchBook
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookIDBox = new System.Windows.Forms.TextBox();
            this.txtBookTitleBox = new System.Windows.Forms.TextBox();
            this.btnSearchABook = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "BookID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Book Title:";
            // 
            // txtBookIDBox
            // 
            this.txtBookIDBox.Location = new System.Drawing.Point(525, 31);
            this.txtBookIDBox.Name = "txtBookIDBox";
            this.txtBookIDBox.Size = new System.Drawing.Size(199, 20);
            this.txtBookIDBox.TabIndex = 13;
            this.txtBookIDBox.TextChanged += new System.EventHandler(this.txtBookIDBox_TextChanged);
            // 
            // txtBookTitleBox
            // 
            this.txtBookTitleBox.Location = new System.Drawing.Point(84, 31);
            this.txtBookTitleBox.Name = "txtBookTitleBox";
            this.txtBookTitleBox.Size = new System.Drawing.Size(199, 20);
            this.txtBookTitleBox.TabIndex = 12;
            this.txtBookTitleBox.TextChanged += new System.EventHandler(this.txtBookTitleBox_TextChanged);
            // 
            // btnSearchABook
            // 
            this.btnSearchABook.Location = new System.Drawing.Point(299, 98);
            this.btnSearchABook.Name = "btnSearchABook";
            this.btnSearchABook.Size = new System.Drawing.Size(182, 44);
            this.btnSearchABook.TabIndex = 10;
            this.btnSearchABook.Text = "Search a Book";
            this.btnSearchABook.UseVisualStyleBackColor = true;
            this.btnSearchABook.Click += new System.EventHandler(this.btnSearchABook_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 148);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(776, 271);
            this.dgvResults.TabIndex = 16;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellContentClick);
            this.dgvResults.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellDoubleContentClick);
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookIDBox);
            this.Controls.Add(this.txtBookTitleBox);
            this.Controls.Add(this.btnSearchABook);
            this.Name = "SearchBook";
            this.Text = "SearchBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookIDBox;
        private System.Windows.Forms.TextBox txtBookTitleBox;
        private System.Windows.Forms.Button btnSearchABook;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}