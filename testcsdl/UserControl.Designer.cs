namespace testcsdl
{
    partial class UserControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSuaUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnThemUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtLopID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDonViID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUserID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.UserData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.XoaUser = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaUser);
            this.groupBox1.Controls.Add(this.btnSuaUser);
            this.groupBox1.Controls.Add(this.btnThemUser);
            this.groupBox1.Controls.Add(this.txtLopID);
            this.groupBox1.Controls.Add(this.txtDonViID);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(678, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 336);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin User";
            // 
            // btnXoaUser
            // 
            this.btnXoaUser.AutoSize = true;
            this.btnXoaUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaUser.Depth = 0;
            this.btnXoaUser.Location = new System.Drawing.Point(265, 292);
            this.btnXoaUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoaUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaUser.Name = "btnXoaUser";
            this.btnXoaUser.Primary = false;
            this.btnXoaUser.Size = new System.Drawing.Size(39, 36);
            this.btnXoaUser.TabIndex = 8;
            this.btnXoaUser.Text = "Xóa";
            this.btnXoaUser.UseVisualStyleBackColor = true;
            this.btnXoaUser.Click += new System.EventHandler(this.btnXoaUser_Click);
            // 
            // btnSuaUser
            // 
            this.btnSuaUser.AutoSize = true;
            this.btnSuaUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuaUser.Depth = 0;
            this.btnSuaUser.Location = new System.Drawing.Point(194, 292);
            this.btnSuaUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuaUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuaUser.Name = "btnSuaUser";
            this.btnSuaUser.Primary = false;
            this.btnSuaUser.Size = new System.Drawing.Size(39, 36);
            this.btnSuaUser.TabIndex = 7;
            this.btnSuaUser.Text = "Sửa";
            this.btnSuaUser.UseVisualStyleBackColor = true;
            this.btnSuaUser.Click += new System.EventHandler(this.btnSuaUser_Click);
            // 
            // btnThemUser
            // 
            this.btnThemUser.AutoSize = true;
            this.btnThemUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemUser.Depth = 0;
            this.btnThemUser.Location = new System.Drawing.Point(121, 292);
            this.btnThemUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemUser.Name = "btnThemUser";
            this.btnThemUser.Primary = false;
            this.btnThemUser.Size = new System.Drawing.Size(50, 36);
            this.btnThemUser.TabIndex = 6;
            this.btnThemUser.Text = "Thêm";
            this.btnThemUser.UseVisualStyleBackColor = true;
            this.btnThemUser.Click += new System.EventHandler(this.btnThemUser_Click);
            // 
            // txtLopID
            // 
            this.txtLopID.Depth = 0;
            this.txtLopID.Hint = "";
            this.txtLopID.Location = new System.Drawing.Point(145, 178);
            this.txtLopID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLopID.Name = "txtLopID";
            this.txtLopID.PasswordChar = '\0';
            this.txtLopID.SelectedText = "";
            this.txtLopID.SelectionLength = 0;
            this.txtLopID.SelectionStart = 0;
            this.txtLopID.Size = new System.Drawing.Size(188, 23);
            this.txtLopID.TabIndex = 5;
            this.txtLopID.UseSystemPasswordChar = false;
            // 
            // txtDonViID
            // 
            this.txtDonViID.Depth = 0;
            this.txtDonViID.Hint = "";
            this.txtDonViID.Location = new System.Drawing.Point(145, 137);
            this.txtDonViID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDonViID.Name = "txtDonViID";
            this.txtDonViID.PasswordChar = '\0';
            this.txtDonViID.SelectedText = "";
            this.txtDonViID.SelectionLength = 0;
            this.txtDonViID.SelectionStart = 0;
            this.txtDonViID.Size = new System.Drawing.Size(188, 23);
            this.txtDonViID.TabIndex = 4;
            this.txtDonViID.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(145, 98);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(188, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Depth = 0;
            this.txtUserName.Hint = "";
            this.txtUserName.Location = new System.Drawing.Point(145, 63);
            this.txtUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.Size = new System.Drawing.Size(188, 23);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.UseSystemPasswordChar = false;
            // 
            // txtUserID
            // 
            this.txtUserID.Depth = 0;
            this.txtUserID.Hint = "";
            this.txtUserID.Location = new System.Drawing.Point(145, 26);
            this.txtUserID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.SelectedText = "";
            this.txtUserID.SelectionLength = 0;
            this.txtUserID.SelectionStart = 0;
            this.txtUserID.Size = new System.Drawing.Size(188, 23);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(37, 182);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(52, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "LopID:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(37, 141);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "DonViID:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(37, 102);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Email:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(37, 67);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "UserName:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(37, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "UserID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialFlatButton1);
            this.groupBox2.Controls.Add(this.materialSingleLineTextField6);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(678, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 163);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm User";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(231, 24);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(72, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Tìm kiếm ";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Hint = "";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(96, 29);
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '\0';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(108, 23);
            this.materialSingleLineTextField6.TabIndex = 1;
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 33);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(58, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "UserID:";
            // 
            // UserData
            // 
            this.UserData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserData.ContextMenuStrip = this.contextMenuStrip1;
            this.UserData.Location = new System.Drawing.Point(12, 12);
            this.UserData.Name = "UserData";
            this.UserData.Size = new System.Drawing.Size(660, 498);
            this.UserData.TabIndex = 3;
            this.UserData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserData_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XoaUser});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // XoaUser
            // 
            this.XoaUser.Name = "XoaUser";
            this.XoaUser.Size = new System.Drawing.Size(94, 22);
            this.XoaUser.Text = "Xóa";
            this.XoaUser.Click += new System.EventHandler(this.XoaUser_Click);
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 530);
            this.Controls.Add(this.UserData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl";
            this.Text = "Danh Sác User";
            this.Load += new System.EventHandler(this.UserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLopID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDonViID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUserID;
        private MaterialSkin.Controls.MaterialFlatButton btnXoaUser;
        private MaterialSkin.Controls.MaterialFlatButton btnSuaUser;
        private MaterialSkin.Controls.MaterialFlatButton btnThemUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DataGridView UserData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem XoaUser;
    }
}