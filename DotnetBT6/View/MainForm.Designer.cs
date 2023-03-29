namespace DotnetBT6.View
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
            this.cbbNameLop = new System.Windows.Forms.ComboBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuradiobut = new System.Windows.Forms.RadioButton();
            this.Namradiobut = new System.Windows.Forms.RadioButton();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNameSV = new System.Windows.Forms.TextBox();
            this.DTBlab = new System.Windows.Forms.Label();
            this.LopSHlab = new System.Windows.Forms.Label();
            this.NameSVlab = new System.Windows.Forms.Label();
            this.labMSSV = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ShowcbbNameLop = new System.Windows.Forms.ComboBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbNameLop
            // 
            this.cbbNameLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbNameLop.Enabled = false;
            this.cbbNameLop.FormattingEnabled = true;
            this.cbbNameLop.Location = new System.Drawing.Point(141, 54);
            this.cbbNameLop.Name = "cbbNameLop";
            this.cbbNameLop.Size = new System.Drawing.Size(209, 24);
            this.cbbNameLop.TabIndex = 41;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMSSV.Enabled = false;
            this.txtMSSV.Location = new System.Drawing.Point(141, 16);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(209, 22);
            this.txtMSSV.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Nuradiobut);
            this.groupBox1.Controls.Add(this.Namradiobut);
            this.groupBox1.Location = new System.Drawing.Point(376, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 141);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới Tính";
            // 
            // Nuradiobut
            // 
            this.Nuradiobut.AutoSize = true;
            this.Nuradiobut.Location = new System.Drawing.Point(24, 80);
            this.Nuradiobut.Name = "Nuradiobut";
            this.Nuradiobut.Size = new System.Drawing.Size(45, 20);
            this.Nuradiobut.TabIndex = 1;
            this.Nuradiobut.TabStop = true;
            this.Nuradiobut.Text = "Nữ";
            this.Nuradiobut.UseVisualStyleBackColor = true;
            // 
            // Namradiobut
            // 
            this.Namradiobut.AutoSize = true;
            this.Namradiobut.Location = new System.Drawing.Point(24, 40);
            this.Namradiobut.Name = "Namradiobut";
            this.Namradiobut.Size = new System.Drawing.Size(57, 20);
            this.Namradiobut.TabIndex = 0;
            this.Namradiobut.TabStop = true;
            this.Namradiobut.Text = "Nam";
            this.Namradiobut.UseVisualStyleBackColor = true;
            // 
            // txtDTB
            // 
            this.txtDTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDTB.Location = new System.Drawing.Point(141, 135);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(209, 22);
            this.txtDTB.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.Name_Lop,
            this.NameSV,
            this.GioiTinh,
            this.DTB});
            this.dataGridView1.Location = new System.Drawing.Point(25, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(841, 288);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            this.MSSV.Width = 125;
            // 
            // Name_Lop
            // 
            this.Name_Lop.DataPropertyName = "Name_Lop";
            this.Name_Lop.HeaderText = "Lớp SH";
            this.Name_Lop.MinimumWidth = 6;
            this.Name_Lop.Name = "Name_Lop";
            this.Name_Lop.ReadOnly = true;
            this.Name_Lop.Width = 125;
            // 
            // NameSV
            // 
            this.NameSV.DataPropertyName = "NameSV";
            this.NameSV.HeaderText = "Họ Tên";
            this.NameSV.MinimumWidth = 6;
            this.NameSV.Name = "NameSV";
            this.NameSV.ReadOnly = true;
            this.NameSV.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // DTB
            // 
            this.DTB.DataPropertyName = "DTB";
            this.DTB.HeaderText = "Điểm TB";
            this.DTB.MinimumWidth = 6;
            this.DTB.Name = "DTB";
            this.DTB.ReadOnly = true;
            this.DTB.Width = 125;
            // 
            // txtNameSV
            // 
            this.txtNameSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameSV.Location = new System.Drawing.Point(141, 94);
            this.txtNameSV.Name = "txtNameSV";
            this.txtNameSV.Size = new System.Drawing.Size(209, 22);
            this.txtNameSV.TabIndex = 37;
            // 
            // DTBlab
            // 
            this.DTBlab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTBlab.AutoSize = true;
            this.DTBlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DTBlab.Location = new System.Drawing.Point(31, 137);
            this.DTBlab.Name = "DTBlab";
            this.DTBlab.Size = new System.Drawing.Size(82, 20);
            this.DTBlab.TabIndex = 36;
            this.DTBlab.Text = "Điểm TB";
            // 
            // LopSHlab
            // 
            this.LopSHlab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LopSHlab.AutoSize = true;
            this.LopSHlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LopSHlab.Location = new System.Drawing.Point(31, 58);
            this.LopSHlab.Name = "LopSHlab";
            this.LopSHlab.Size = new System.Drawing.Size(72, 20);
            this.LopSHlab.TabIndex = 35;
            this.LopSHlab.Text = "Lớp SH";
            // 
            // NameSVlab
            // 
            this.NameSVlab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameSVlab.AutoSize = true;
            this.NameSVlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameSVlab.Location = new System.Drawing.Point(31, 96);
            this.NameSVlab.Name = "NameSVlab";
            this.NameSVlab.Size = new System.Drawing.Size(81, 20);
            this.NameSVlab.TabIndex = 34;
            this.NameSVlab.Text = "NameSV";
            // 
            // labMSSV
            // 
            this.labMSSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labMSSV.AutoSize = true;
            this.labMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labMSSV.Location = new System.Drawing.Point(31, 18);
            this.labMSSV.Name = "labMSSV";
            this.labMSSV.Size = new System.Drawing.Size(60, 20);
            this.labMSSV.TabIndex = 33;
            this.labMSSV.Text = "MSSV";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(574, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 22);
            this.txtSearch.TabIndex = 32;
            // 
            // ShowcbbNameLop
            // 
            this.ShowcbbNameLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowcbbNameLop.FormattingEnabled = true;
            this.ShowcbbNameLop.Location = new System.Drawing.Point(574, 79);
            this.ShowcbbNameLop.Name = "ShowcbbNameLop";
            this.ShowcbbNameLop.Size = new System.Drawing.Size(209, 24);
            this.ShowcbbNameLop.TabIndex = 31;
            // 
            // butSearch
            // 
            this.butSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butSearch.Location = new System.Drawing.Point(789, 12);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(77, 41);
            this.butSearch.TabIndex = 30;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butDel
            // 
            this.butDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butDel.Location = new System.Drawing.Point(674, 494);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(77, 41);
            this.butDel.TabIndex = 29;
            this.butDel.Text = "Delete";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butEdit
            // 
            this.butEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butEdit.Location = new System.Drawing.Point(376, 494);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(77, 41);
            this.butEdit.TabIndex = 28;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butAdd
            // 
            this.butAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butAdd.Location = new System.Drawing.Point(61, 494);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(77, 41);
            this.butAdd.TabIndex = 27;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butShow
            // 
            this.butShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butShow.Location = new System.Drawing.Point(789, 70);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(77, 41);
            this.butShow.TabIndex = 26;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 546);
            this.Controls.Add(this.cbbNameLop);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNameSV);
            this.Controls.Add(this.DTBlab);
            this.Controls.Add(this.LopSHlab);
            this.Controls.Add(this.NameSVlab);
            this.Controls.Add(this.labMSSV);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ShowcbbNameLop);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butShow);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbNameLop;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Nuradiobut;
        private System.Windows.Forms.RadioButton Namradiobut;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
        private System.Windows.Forms.TextBox txtNameSV;
        private System.Windows.Forms.Label DTBlab;
        private System.Windows.Forms.Label LopSHlab;
        private System.Windows.Forms.Label NameSVlab;
        private System.Windows.Forms.Label labMSSV;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox ShowcbbNameLop;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butShow;
    }
}