namespace testcsdl
{
    partial class DonViControl
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
            this.DonViData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.XoaDonVi = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttimkiemdonvi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btntimkiemdonvi = new MaterialSkin.Controls.MaterialFlatButton();
            this.tendonvi = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaDonVi = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSuaDonVi = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnThemDonVi = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtTenDonVi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDonViID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DonViData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DonViData
            // 
            this.DonViData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DonViData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonViData.ContextMenuStrip = this.contextMenuStrip1;
            this.DonViData.Location = new System.Drawing.Point(12, 12);
            this.DonViData.Name = "DonViData";
            this.DonViData.Size = new System.Drawing.Size(426, 513);
            this.DonViData.TabIndex = 0;
            this.DonViData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DonViData_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XoaDonVi});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // XoaDonVi
            // 
            this.XoaDonVi.Name = "XoaDonVi";
            this.XoaDonVi.Size = new System.Drawing.Size(94, 22);
            this.XoaDonVi.Text = "Xóa";
            this.XoaDonVi.Click += new System.EventHandler(this.XoaDonVi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttimkiemdonvi);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btntimkiemdonvi);
            this.groupBox1.Controls.Add(this.tendonvi);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(444, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm Đơn Vị";
            // 
            // txttimkiemdonvi
            // 
            this.txttimkiemdonvi.Depth = 0;
            this.txttimkiemdonvi.Hint = "";
            this.txttimkiemdonvi.Location = new System.Drawing.Point(125, 91);
            this.txttimkiemdonvi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txttimkiemdonvi.Name = "txttimkiemdonvi";
            this.txttimkiemdonvi.PasswordChar = '\0';
            this.txttimkiemdonvi.SelectedText = "";
            this.txttimkiemdonvi.SelectionLength = 0;
            this.txttimkiemdonvi.SelectionStart = 0;
            this.txttimkiemdonvi.Size = new System.Drawing.Size(178, 23);
            this.txttimkiemdonvi.TabIndex = 4;
            this.txttimkiemdonvi.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 25);
            this.comboBox1.TabIndex = 3;
            // 
            // btntimkiemdonvi
            // 
            this.btntimkiemdonvi.AutoSize = true;
            this.btntimkiemdonvi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btntimkiemdonvi.Depth = 0;
            this.btntimkiemdonvi.Location = new System.Drawing.Point(133, 125);
            this.btntimkiemdonvi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btntimkiemdonvi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btntimkiemdonvi.Name = "btntimkiemdonvi";
            this.btntimkiemdonvi.Primary = false;
            this.btntimkiemdonvi.Size = new System.Drawing.Size(72, 36);
            this.btntimkiemdonvi.TabIndex = 2;
            this.btntimkiemdonvi.Text = "Tìm Kiếm ";
            this.btntimkiemdonvi.UseVisualStyleBackColor = true;
            this.btntimkiemdonvi.Click += new System.EventHandler(this.btntimkiemdonvi_Click);
            // 
            // tendonvi
            // 
            this.tendonvi.AutoSize = true;
            this.tendonvi.Depth = 0;
            this.tendonvi.Font = new System.Drawing.Font("Roboto", 11F);
            this.tendonvi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tendonvi.Location = new System.Drawing.Point(14, 48);
            this.tendonvi.MouseState = MaterialSkin.MouseState.HOVER;
            this.tendonvi.Name = "tendonvi";
            this.tendonvi.Size = new System.Drawing.Size(87, 19);
            this.tendonvi.TabIndex = 0;
            this.tendonvi.Text = "Tên Đơn Vị:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaDonVi);
            this.groupBox2.Controls.Add(this.btnSuaDonVi);
            this.groupBox2.Controls.Add(this.btnThemDonVi);
            this.groupBox2.Controls.Add(this.txtTenDonVi);
            this.groupBox2.Controls.Add(this.txtDonViID);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(444, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 303);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đơn Vị";
            // 
            // btnXoaDonVi
            // 
            this.btnXoaDonVi.AutoSize = true;
            this.btnXoaDonVi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaDonVi.Depth = 0;
            this.btnXoaDonVi.Location = new System.Drawing.Point(264, 195);
            this.btnXoaDonVi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaDonVi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaDonVi.Name = "btnXoaDonVi";
            this.btnXoaDonVi.Primary = false;
            this.btnXoaDonVi.Size = new System.Drawing.Size(39, 36);
            this.btnXoaDonVi.TabIndex = 3;
            this.btnXoaDonVi.Text = "Xóa";
            this.btnXoaDonVi.UseVisualStyleBackColor = true;
            this.btnXoaDonVi.Click += new System.EventHandler(this.btnXoaDonVi_Click_1);
            // 
            // btnSuaDonVi
            // 
            this.btnSuaDonVi.AutoSize = true;
            this.btnSuaDonVi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuaDonVi.Depth = 0;
            this.btnSuaDonVi.Location = new System.Drawing.Point(166, 195);
            this.btnSuaDonVi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuaDonVi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuaDonVi.Name = "btnSuaDonVi";
            this.btnSuaDonVi.Primary = false;
            this.btnSuaDonVi.Size = new System.Drawing.Size(39, 36);
            this.btnSuaDonVi.TabIndex = 3;
            this.btnSuaDonVi.Text = "Sửa";
            this.btnSuaDonVi.UseVisualStyleBackColor = true;
            this.btnSuaDonVi.Click += new System.EventHandler(this.btnSuaDonVi_Click);
            // 
            // btnThemDonVi
            // 
            this.btnThemDonVi.AutoSize = true;
            this.btnThemDonVi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemDonVi.Depth = 0;
            this.btnThemDonVi.Location = new System.Drawing.Point(63, 195);
            this.btnThemDonVi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemDonVi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemDonVi.Name = "btnThemDonVi";
            this.btnThemDonVi.Primary = false;
            this.btnThemDonVi.Size = new System.Drawing.Size(50, 36);
            this.btnThemDonVi.TabIndex = 3;
            this.btnThemDonVi.Text = "Thêm";
            this.btnThemDonVi.UseVisualStyleBackColor = true;
            this.btnThemDonVi.Click += new System.EventHandler(this.btnThemDonVi_Click);
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.Depth = 0;
            this.txtTenDonVi.Hint = "";
            this.txtTenDonVi.Location = new System.Drawing.Point(143, 108);
            this.txtTenDonVi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.PasswordChar = '\0';
            this.txtTenDonVi.SelectedText = "";
            this.txtTenDonVi.SelectionLength = 0;
            this.txtTenDonVi.SelectionStart = 0;
            this.txtTenDonVi.Size = new System.Drawing.Size(221, 23);
            this.txtTenDonVi.TabIndex = 2;
            this.txtTenDonVi.UseSystemPasswordChar = false;
            // 
            // txtDonViID
            // 
            this.txtDonViID.Depth = 0;
            this.txtDonViID.Hint = "";
            this.txtDonViID.Location = new System.Drawing.Point(143, 48);
            this.txtDonViID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDonViID.Name = "txtDonViID";
            this.txtDonViID.PasswordChar = '\0';
            this.txtDonViID.SelectedText = "";
            this.txtDonViID.SelectionLength = 0;
            this.txtDonViID.SelectionStart = 0;
            this.txtDonViID.Size = new System.Drawing.Size(221, 23);
            this.txtDonViID.TabIndex = 2;
            this.txtDonViID.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 112);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(87, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Tên Đơn Vị:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 53);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Đơn Vị ID:";
            // 
            // DonViControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DonViData);
            this.Name = "DonViControl";
            this.Text = "Danh Sách Đơn Vị";
            this.Load += new System.EventHandler(this.DonViControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonViData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DonViData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialFlatButton btntimkiemdonvi;
        private MaterialSkin.Controls.MaterialFlatButton btnXoaDonVi;
        private MaterialSkin.Controls.MaterialFlatButton btnSuaDonVi;
        private MaterialSkin.Controls.MaterialFlatButton btnThemDonVi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenDonVi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDonViID;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel tendonvi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem XoaDonVi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txttimkiemdonvi;
    }
}