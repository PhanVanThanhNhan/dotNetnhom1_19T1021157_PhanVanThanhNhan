namespace AppQuanLyDanhBa
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemNhom = new System.Windows.Forms.ToolStripButton();
            this.btnXoaNhom = new System.Windows.Forms.ToolStripButton();
            this.btnThemLienLac = new System.Windows.Forms.ToolStripButton();
            this.btnXoaLienLac = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gridNhom = new System.Windows.Forms.DataGridView();
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLienLac = new System.Windows.Forms.DataGridView();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lienLacViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLienLac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lienLacViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemNhom,
            this.btnXoaNhom,
            this.btnThemLienLac,
            this.btnXoaLienLac,
            this.txtSearch,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhom.Image")));
            this.btnThemNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(116, 28);
            this.btnThemNhom.Text = "Thêm nhóm";
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhom.Image")));
            this.btnXoaNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(105, 28);
            this.btnXoaNhom.Text = "Xoá nhóm";
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // btnThemLienLac
            // 
            this.btnThemLienLac.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLienLac.Image")));
            this.btnThemLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLienLac.Name = "btnThemLienLac";
            this.btnThemLienLac.Size = new System.Drawing.Size(125, 28);
            this.btnThemLienLac.Text = "Thêm liên lạc";
            this.btnThemLienLac.Click += new System.EventHandler(this.btnThemLienLac_Click);
            // 
            // btnXoaLienLac
            // 
            this.btnXoaLienLac.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLienLac.Image")));
            this.btnXoaLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLienLac.Name = "btnXoaLienLac";
            this.btnXoaLienLac.Size = new System.Drawing.Size(114, 28);
            this.btnXoaLienLac.Text = "Xoá liên lạc";
            this.btnXoaLienLac.Click += new System.EventHandler(this.btnXoaLienLac_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 31);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_TextChange);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(116, 28);
            this.toolStripLabel1.Text = "Nhập từ cần tìm";
            // 
            // gridNhom
            // 
            this.gridNhom.AllowUserToAddRows = false;
            this.gridNhom.AllowUserToDeleteRows = false;
            this.gridNhom.AutoGenerateColumns = false;
            this.gridNhom.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhomDataGridViewTextBoxColumn});
            this.gridNhom.DataSource = this.nhomViewModelBindingSource;
            this.gridNhom.Location = new System.Drawing.Point(0, 39);
            this.gridNhom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridNhom.Name = "gridNhom";
            this.gridNhom.ReadOnly = true;
            this.gridNhom.RowHeadersWidth = 62;
            this.gridNhom.RowTemplate.Height = 28;
            this.gridNhom.Size = new System.Drawing.Size(322, 443);
            this.gridNhom.TabIndex = 1;
            this.gridNhom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNhom_CellContentClick);
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "Tên nhóm";
            this.tenNhomDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            this.tenNhomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhomViewModelBindingSource
            // 
            this.nhomViewModelBindingSource.DataSource = typeof(AppQuanLyDanhBa.ViewModel.NhomViewModel);
            // 
            // gridLienLac
            // 
            this.gridLienLac.AllowUserToAddRows = false;
            this.gridLienLac.AllowUserToDeleteRows = false;
            this.gridLienLac.AutoGenerateColumns = false;
            this.gridLienLac.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridLienLac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLienLac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn});
            this.gridLienLac.DataSource = this.lienLacViewModelBindingSource;
            this.gridLienLac.Location = new System.Drawing.Point(327, 39);
            this.gridLienLac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridLienLac.Name = "gridLienLac";
            this.gridLienLac.ReadOnly = true;
            this.gridLienLac.RowHeadersWidth = 62;
            this.gridLienLac.RowTemplate.Height = 28;
            this.gridLienLac.Size = new System.Drawing.Size(665, 288);
            this.gridLienLac.TabIndex = 2;
            this.gridLienLac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.FillWeight = 272.7273F;
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên gọi";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 13.63637F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "Sdt";
            this.sdtDataGridViewTextBoxColumn.FillWeight = 13.63637F;
            this.sdtDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sdtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            this.sdtDataGridViewTextBoxColumn.ReadOnly = true;
            this.sdtDataGridViewTextBoxColumn.Width = 180;
            // 
            // lienLacViewModelBindingSource
            // 
            this.lienLacViewModelBindingSource.DataSource = typeof(AppQuanLyDanhBa.ViewModel.LienLacViewModel);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(356, 338);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(74, 18);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "[Tên gọi]";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(490, 380);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(0, 16);
            this.txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(490, 406);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(0, 16);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(490, 435);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(0, 16);
            this.txtPhone.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(663, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(992, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gridLienLac);
            this.Controls.Add(this.gridNhom);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLienLac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lienLacViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemNhom;
        private System.Windows.Forms.ToolStripButton btnXoaNhom;
        private System.Windows.Forms.ToolStripButton btnThemLienLac;
        private System.Windows.Forms.ToolStripButton btnXoaLienLac;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView gridNhom;
        private System.Windows.Forms.DataGridView gridLienLac;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.BindingSource nhomViewModelBindingSource;
        private System.Windows.Forms.BindingSource lienLacViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

