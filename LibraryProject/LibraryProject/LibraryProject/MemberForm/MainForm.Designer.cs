namespace LibraryProject
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AddB = new System.Windows.Forms.Button();
            this.btn_SearchB = new System.Windows.Forms.Button();
            this.btn_DeleteB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_borrowedB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mColFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mColAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mColPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mColTranslator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mColJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mColExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mColID,
            this.mColFullName,
            this.mColAuthor,
            this.mColPublisher,
            this.mColTranslator,
            this.mColJoinDate,
            this.mColExpiryDate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1710, 491);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_AddB
            // 
            this.btn_AddB.Location = new System.Drawing.Point(18, 18);
            this.btn_AddB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddB.Name = "btn_AddB";
            this.btn_AddB.Size = new System.Drawing.Size(75, 38);
            this.btn_AddB.TabIndex = 15;
            this.btn_AddB.Text = "Add";
            this.btn_AddB.UseVisualStyleBackColor = true;
            this.btn_AddB.Click += new System.EventHandler(this.btn_AddB_Click);
            // 
            // btn_SearchB
            // 
            this.btn_SearchB.Location = new System.Drawing.Point(102, 18);
            this.btn_SearchB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SearchB.Name = "btn_SearchB";
            this.btn_SearchB.Size = new System.Drawing.Size(75, 38);
            this.btn_SearchB.TabIndex = 14;
            this.btn_SearchB.Text = "Search";
            this.btn_SearchB.UseVisualStyleBackColor = true;
            this.btn_SearchB.Click += new System.EventHandler(this.btn_SearchB_Click);
            // 
            // btn_DeleteB
            // 
            this.btn_DeleteB.Location = new System.Drawing.Point(186, 18);
            this.btn_DeleteB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DeleteB.Name = "btn_DeleteB";
            this.btn_DeleteB.Size = new System.Drawing.Size(75, 38);
            this.btn_DeleteB.TabIndex = 16;
            this.btn_DeleteB.Text = "Delete";
            this.btn_DeleteB.UseVisualStyleBackColor = true;
            this.btn_DeleteB.Click += new System.EventHandler(this.btn_DeleteB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_borrowedB);
            this.groupBox1.Controls.Add(this.btn_AddB);
            this.groupBox1.Controls.Add(this.btn_SearchB);
            this.groupBox1.Controls.Add(this.btn_DeleteB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1718, 72);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // btn_borrowedB
            // 
            this.btn_borrowedB.Location = new System.Drawing.Point(270, 18);
            this.btn_borrowedB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_borrowedB.Name = "btn_borrowedB";
            this.btn_borrowedB.Size = new System.Drawing.Size(158, 38);
            this.btn_borrowedB.TabIndex = 17;
            this.btn_borrowedB.Text = "Borrowed Books";
            this.btn_borrowedB.UseVisualStyleBackColor = true;
            this.btn_borrowedB.Click += new System.EventHandler(this.btn_borrowedB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1718, 520);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // mColID
            // 
            this.mColID.DataPropertyName = "ID";
            this.mColID.HeaderText = "ID";
            this.mColID.MinimumWidth = 8;
            this.mColID.Name = "mColID";
            this.mColID.ReadOnly = true;
            // 
            // mColFullName
            // 
            this.mColFullName.DataPropertyName = "FullName";
            this.mColFullName.HeaderText = "FullName";
            this.mColFullName.MinimumWidth = 8;
            this.mColFullName.Name = "mColFullName";
            this.mColFullName.ReadOnly = true;
            // 
            // mColAuthor
            // 
            this.mColAuthor.DataPropertyName = "City";
            this.mColAuthor.HeaderText = "City";
            this.mColAuthor.MinimumWidth = 8;
            this.mColAuthor.Name = "mColAuthor";
            this.mColAuthor.ReadOnly = true;
            // 
            // mColPublisher
            // 
            this.mColPublisher.DataPropertyName = "Address";
            this.mColPublisher.HeaderText = "Address";
            this.mColPublisher.MinimumWidth = 8;
            this.mColPublisher.Name = "mColPublisher";
            this.mColPublisher.ReadOnly = true;
            // 
            // mColTranslator
            // 
            this.mColTranslator.DataPropertyName = "PhoneNumber";
            this.mColTranslator.HeaderText = "PhoneNumber";
            this.mColTranslator.MinimumWidth = 8;
            this.mColTranslator.Name = "mColTranslator";
            this.mColTranslator.ReadOnly = true;
            // 
            // mColJoinDate
            // 
            this.mColJoinDate.DataPropertyName = "JoinDate";
            this.mColJoinDate.HeaderText = "JoinDate";
            this.mColJoinDate.MinimumWidth = 8;
            this.mColJoinDate.Name = "mColJoinDate";
            // 
            // mColExpiryDate
            // 
            this.mColExpiryDate.DataPropertyName = "ExpiryDate";
            this.mColExpiryDate.HeaderText = "ExpiryDate";
            this.mColExpiryDate.MinimumWidth = 8;
            this.mColExpiryDate.Name = "mColExpiryDate";
            this.mColExpiryDate.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 592);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AddB;
        private System.Windows.Forms.Button btn_DeleteB;
        private System.Windows.Forms.Button btn_SearchB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_borrowedB;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColTranslator;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn mColExpiryDate;
    }
}