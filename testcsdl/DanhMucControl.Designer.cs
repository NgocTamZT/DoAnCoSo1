namespace testcsdl
{
    partial class DanhMucControl
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
            this.DanhMucData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.XoaDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemDanhMuc = new MaterialSkin.Controls.MaterialFlatButton();
            this.comboBoxDanhMuc = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaDanhMuc = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSuaDanhMuc = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnThemDanhMuc = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDonViID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTenDanhMuc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDanhMucID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DanhMucData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DanhMucData
            // 
            this.DanhMucData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DanhMucData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhMucData.ContextMenuStrip = this.contextMenuStrip1;
            this.DanhMucData.Location = new System.Drawing.Point(12, 12);
            this.DanhMucData.Name = "DanhMucData";
            this.DanhMucData.Size = new System.Drawing.Size(447, 518);
            this.DanhMucData.TabIndex = 0;
            this.DanhMucData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhMucData_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XoaDanhMuc});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // XoaDanhMuc
            // 
            this.XoaDanhMuc.Name = "XoaDanhMuc";
            this.XoaDanhMuc.Size = new System.Drawing.Size(94, 22);
            this.XoaDanhMuc.Text = "Xóa";
            this.XoaDanhMuc.Click += new System.EventHandler(this.XoaDanhMuc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemDanhMuc);
            this.groupBox1.Controls.Add(this.comboBoxDanhMuc);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(465, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Danh Mục";
            // 
            // btnTimKiemDanhMuc
            // 
            this.btnTimKiemDanhMuc.AutoSize = true;
            this.btnTimKiemDanhMuc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiemDanhMuc.Depth = 0;
            this.btnTimKiemDanhMuc.Location = new System.Drawing.Point(129, 92);
            this.btnTimKiemDanhMuc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiemDanhMuc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiemDanhMuc.Name = "btnTimKiemDanhMuc";
            this.btnTimKiemDanhMuc.Primary = false;
            this.btnTimKiemDanhMuc.Size = new System.Drawing.Size(72, 36);
            this.btnTimKiemDanhMuc.TabIndex = 2;
            this.btnTimKiemDanhMuc.Text = "Tìm Kiếm";
            this.btnTimKiemDanhMuc.UseVisualStyleBackColor = true;
            // 
            // comboBoxDanhMuc
            // 
            this.comboBoxDanhMuc.FormattingEnabled = true;
            this.comboBoxDanhMuc.Location = new System.Drawing.Point(122, 36);
            this.comboBoxDanhMuc.Name = "comboBoxDanhMuc";
            this.comboBoxDanhMuc.Size = new System.Drawing.Size(207, 25);
            this.comboBoxDanhMuc.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(7, 39);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(109, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Tên Danh Mục:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaDanhMuc);
            this.groupBox2.Controls.Add(this.btnSuaDanhMuc);
            this.groupBox2.Controls.Add(this.btnThemDanhMuc);
            this.groupBox2.Controls.Add(this.txtDonViID);
            this.groupBox2.Controls.Add(this.txtTenDanhMuc);
            this.groupBox2.Controls.Add(this.txtDanhMucID);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(465, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 344);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Danh Mục";
            // 
            // btnXoaDanhMuc
            // 
            this.btnXoaDanhMuc.AutoSize = true;
            this.btnXoaDanhMuc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaDanhMuc.Depth = 0;
            this.btnXoaDanhMuc.Location = new System.Drawing.Point(241, 209);
            this.btnXoaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaDanhMuc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaDanhMuc.Name = "btnXoaDanhMuc";
            this.btnXoaDanhMuc.Primary = false;
            this.btnXoaDanhMuc.Size = new System.Drawing.Size(39, 36);
            this.btnXoaDanhMuc.TabIndex = 2;
            this.btnXoaDanhMuc.Text = "Xóa";
            this.btnXoaDanhMuc.UseVisualStyleBackColor = true;
            // 
            // btnSuaDanhMuc
            // 
            this.btnSuaDanhMuc.AutoSize = true;
            this.btnSuaDanhMuc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuaDanhMuc.Depth = 0;
            this.btnSuaDanhMuc.Location = new System.Drawing.Point(162, 209);
            this.btnSuaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuaDanhMuc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuaDanhMuc.Name = "btnSuaDanhMuc";
            this.btnSuaDanhMuc.Primary = false;
            this.btnSuaDanhMuc.Size = new System.Drawing.Size(39, 36);
            this.btnSuaDanhMuc.TabIndex = 2;
            this.btnSuaDanhMuc.Text = "Sửa";
            this.btnSuaDanhMuc.UseVisualStyleBackColor = true;
            this.btnSuaDanhMuc.Click += new System.EventHandler(this.btnSuaDanhMuc_Click);
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.AutoSize = true;
            this.btnThemDanhMuc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemDanhMuc.Depth = 0;
            this.btnThemDanhMuc.Location = new System.Drawing.Point(74, 209);
            this.btnThemDanhMuc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemDanhMuc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Primary = false;
            this.btnThemDanhMuc.Size = new System.Drawing.Size(50, 36);
            this.btnThemDanhMuc.TabIndex = 2;
            this.btnThemDanhMuc.Text = "Thêm";
            this.btnThemDanhMuc.UseVisualStyleBackColor = true;
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // txtDonViID
            // 
            this.txtDonViID.Depth = 0;
            this.txtDonViID.Hint = "";
            this.txtDonViID.Location = new System.Drawing.Point(162, 118);
            this.txtDonViID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDonViID.Name = "txtDonViID";
            this.txtDonViID.PasswordChar = '\0';
            this.txtDonViID.SelectedText = "";
            this.txtDonViID.SelectionLength = 0;
            this.txtDonViID.SelectionStart = 0;
            this.txtDonViID.Size = new System.Drawing.Size(167, 23);
            this.txtDonViID.TabIndex = 1;
            this.txtDonViID.UseSystemPasswordChar = false;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Depth = 0;
            this.txtTenDanhMuc.Hint = "";
            this.txtTenDanhMuc.Location = new System.Drawing.Point(162, 77);
            this.txtTenDanhMuc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.PasswordChar = '\0';
            this.txtTenDanhMuc.SelectedText = "";
            this.txtTenDanhMuc.SelectionLength = 0;
            this.txtTenDanhMuc.SelectionStart = 0;
            this.txtTenDanhMuc.Size = new System.Drawing.Size(167, 23);
            this.txtTenDanhMuc.TabIndex = 1;
            this.txtTenDanhMuc.UseSystemPasswordChar = false;
            // 
            // txtDanhMucID
            // 
            this.txtDanhMucID.Depth = 0;
            this.txtDanhMucID.Hint = "";
            this.txtDanhMucID.Location = new System.Drawing.Point(162, 36);
            this.txtDanhMucID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDanhMucID.Name = "txtDanhMucID";
            this.txtDanhMucID.PasswordChar = '\0';
            this.txtDanhMucID.SelectedText = "";
            this.txtDanhMucID.SelectionLength = 0;
            this.txtDanhMucID.SelectionStart = 0;
            this.txtDanhMucID.Size = new System.Drawing.Size(167, 23);
            this.txtDanhMucID.TabIndex = 1;
            this.txtDanhMucID.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(26, 122);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Đơn Vị ID:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(26, 81);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Tên Danh Mục:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 41);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(98, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Danh Mục ID:";
            // 
            // DanhMucControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DanhMucData);
            this.Name = "DanhMucControl";
            this.Text = "Danh Sách Danh Mục";
            this.Load += new System.EventHandler(this.DanhMucControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhMucData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DanhMucData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnXoaDanhMuc;
        private MaterialSkin.Controls.MaterialFlatButton btnSuaDanhMuc;
        private MaterialSkin.Controls.MaterialFlatButton btnThemDanhMuc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDonViID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenDanhMuc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDanhMucID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem XoaDanhMuc;
        private MaterialSkin.Controls.MaterialFlatButton btnTimKiemDanhMuc;
        private System.Windows.Forms.ComboBox comboBoxDanhMuc;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}