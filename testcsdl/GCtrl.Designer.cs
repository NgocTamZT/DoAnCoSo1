namespace testcsdl
{
    partial class GCtrl
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
            this.gridCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrl
            // 
            this.gridCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrl.Location = new System.Drawing.Point(0, 0);
            this.gridCtrl.MainView = this.gridView1;
            this.gridCtrl.Name = "gridCtrl";
            this.gridCtrl.Size = new System.Drawing.Size(766, 528);
            this.gridCtrl.TabIndex = 0;
            this.gridCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridCtrl.Click += new System.EventHandler(this.gridCtrl_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridCtrl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.SearchInPreview = true;
            // 
            // GCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 528);
            this.Controls.Add(this.gridCtrl);
            this.Name = "GCtrl";
            this.Text = "GCtrl";
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}