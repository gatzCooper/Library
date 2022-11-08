namespace LibraryProject.Borrow
{
    partial class BooksDetail
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
            this.txt_IDbook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IDbook
            // 
            this.txt_IDbook.Location = new System.Drawing.Point(75, 154);
            this.txt_IDbook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IDbook.Name = "txt_IDbook";
            this.txt_IDbook.Size = new System.Drawing.Size(148, 26);
            this.txt_IDbook.TabIndex = 0;
            this.txt_IDbook.TextChanged += new System.EventHandler(this.txt_IDbook_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(234, 149);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 35);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_borrow
            // 
            this.btn_borrow.Location = new System.Drawing.Point(78, 371);
            this.btn_borrow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(112, 35);
            this.btn_borrow.TabIndex = 6;
            this.btn_borrow.Text = "Borrow";
            this.btn_borrow.UseVisualStyleBackColor = true;
            this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mColID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(75, 194);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1066, 168);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(225, 378);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 20);
            this.lbl_status.TabIndex = 16;
            this.lbl_status.Click += new System.EventHandler(this.lbl_status_Click);
            // 
            // txt_userID
            // 
            this.txt_userID.Location = new System.Drawing.Point(75, 23);
            this.txt_userID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.ReadOnly = true;
            this.txt_userID.Size = new System.Drawing.Size(148, 26);
            this.txt_userID.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "User ID";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(75, 63);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(148, 26);
            this.txt_name.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Name";
            // 
            // mColID
            // 
            this.mColID.DataPropertyName = "ID";
            this.mColID.HeaderText = "ID";
            this.mColID.MinimumWidth = 8;
            this.mColID.Name = "mColID";
            this.mColID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "author";
            this.dataGridViewTextBoxColumn2.HeaderText = "Author";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "publisher";
            this.dataGridViewTextBoxColumn3.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "translator";
            this.dataGridViewTextBoxColumn4.HeaderText = "Translator";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "available";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Available";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // BooksDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 488);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_borrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_IDbook);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BooksDetail";
            this.Text = "BooksDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IDbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}