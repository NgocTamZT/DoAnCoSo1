namespace testcsdl
{
    partial class LopControl
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
            this.LopData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.XoaLop = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemLop = new MaterialSkin.Controls.MaterialFlatButton();
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaLop = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSuaLop = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnThemLop = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDonViID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTenLop = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLopID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LopData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LopData
            // 
            this.LopData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LopData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LopData.ContextMenuStrip = this.contextMenuStrip1;
            this.LopData.Location = new System.Drawing.Point(12, 12);
            this.LopData.Name = "LopData";
            this.LopData.Size = new System.Drawing.Size(660, 600);
            this.LopData.TabIndex = 0;
            this.LopData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LopData_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XoaLop});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // XoaLop
            // 
            this.XoaLop.Name = "XoaLop";
            this.XoaLop.Size = new System.Drawing.Size(94, 22);
            this.XoaLop.Text = "Xóa";
            this.XoaLop.Click += new System.EventHandler(this.XoaLop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemLop);
            this.groupBox1.Controls.Add(this.comboBoxLop);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(678, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Lớp:";
            // 
            // btnTimKiemLop
            // 
            this.btnTimKiemLop.AutoSize = true;
            this.btnTimKiemLop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiemLop.Depth = 0;
            this.btnTimKiemLop.Location = new System.Drawing.Point(118, 136);
            this.btnTimKiemLop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiemLop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiemLop.Name = "btnTimKiemLop";
            this.btnTimKiemLop.Primary = false;
            this.btnTimKiemLop.Size = new System.Drawing.Size(72, 36);
            this.btnTimKiemLop.TabIndex = 2;
            this.btnTimKiemLop.Text = "Tìm Kiếm ";
            this.btnTimKiemLop.UseVisualStyleBackColor = true;
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Location = new System.Drawing.Point(22, 87);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(242, 25);
            this.comboBoxLop.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 53);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tên Lớp:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaLop);
            this.groupBox2.Controls.Add(this.btnSuaLop);
            this.groupBox2.Controls.Add(this.btnThemLop);
            this.groupBox2.Controls.Add(this.txtDonViID);
            this.groupBox2.Controls.Add(this.txtTenLop);
            this.groupBox2.Controls.Add(this.txtLopID);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(678, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 342);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Lớp:";
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.AutoSize = true;
            this.btnXoaLop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaLop.Depth = 0;
            this.btnXoaLop.Location = new System.Drawing.Point(244, 250);
            this.btnXoaLop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaLop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Primary = false;
            this.btnXoaLop.Size = new System.Drawing.Size(39, 36);
            this.btnXoaLop.TabIndex = 2;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.AutoSize = true;
            this.btnSuaLop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuaLop.Depth = 0;
            this.btnSuaLop.Location = new System.Drawing.Point(149, 250);
            this.btnSuaLop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuaLop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Primary = false;
            this.btnSuaLop.Size = new System.Drawing.Size(39, 36);
            this.btnSuaLop.TabIndex = 2;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.AutoSize = true;
            this.btnThemLop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemLop.Depth = 0;
            this.btnThemLop.Location = new System.Drawing.Point(44, 250);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemLop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Primary = false;
            this.btnThemLop.Size = new System.Drawing.Size(50, 36);
            this.btnThemLop.TabIndex = 2;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // txtDonViID
            // 
            this.txtDonViID.Depth = 0;
            this.txtDonViID.Hint = "";
            this.txtDonViID.Location = new System.Drawing.Point(129, 125);
            this.txtDonViID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDonViID.Name = "txtDonViID";
            this.txtDonViID.PasswordChar = '\0';
            this.txtDonViID.SelectedText = "";
            this.txtDonViID.SelectionLength = 0;
            this.txtDonViID.SelectionStart = 0;
            this.txtDonViID.Size = new System.Drawing.Size(180, 23);
            this.txtDonViID.TabIndex = 1;
            this.txtDonViID.UseSystemPasswordChar = false;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Depth = 0;
            this.txtTenLop.Hint = "";
            this.txtTenLop.Location = new System.Drawing.Point(129, 85);
            this.txtTenLop.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.PasswordChar = '\0';
            this.txtTenLop.SelectedText = "";
            this.txtTenLop.SelectionLength = 0;
            this.txtTenLop.SelectionStart = 0;
            this.txtTenLop.Size = new System.Drawing.Size(180, 23);
            this.txtTenLop.TabIndex = 1;
            this.txtTenLop.UseSystemPasswordChar = false;
            // 
            // txtLopID
            // 
            this.txtLopID.Depth = 0;
            this.txtLopID.Hint = "";
            this.txtLopID.Location = new System.Drawing.Point(129, 40);
            this.txtLopID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLopID.Name = "txtLopID";
            this.txtLopID.PasswordChar = '\0';
            this.txtLopID.SelectedText = "";
            this.txtLopID.SelectionLength = 0;
            this.txtLopID.SelectionStart = 0;
            this.txtLopID.Size = new System.Drawing.Size(180, 23);
            this.txtLopID.TabIndex = 1;
            this.txtLopID.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(18, 129);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(76, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Đơn Vị ID:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 89);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(67, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Tên Lớp:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(18, 45);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Lớp ID:";
            // 
            // LopControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LopData);
            this.Name = "LopControl";
            this.Text = "Danh Sách Lớp";
            this.Load += new System.EventHandler(this.LopControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LopData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LopData;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnTimKiemLop;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenLop;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLopID;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btnXoaLop;
        private MaterialSkin.Controls.MaterialFlatButton btnSuaLop;
        private MaterialSkin.Controls.MaterialFlatButton btnThemLop;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDonViID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem XoaLop;
    }
}