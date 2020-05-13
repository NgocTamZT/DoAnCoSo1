using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using testcsdl.Table;

namespace testcsdl
{
    public partial class LopControl : DevExpress.XtraEditors.XtraForm
    {
        database db = new database();
        public LopControl()
        {
            InitializeComponent();
        }
        void LoadDataLop()
        {
            //LopData.DataSource = db.Lops.Select(us => new
            //{
            //    LopID = us.LopID,
            //    TenLop = us.TenLop,
            //    DonViID = us.DonViID,
                
            //}).ToList();
        }

        private void LopControl_Load(object sender, EventArgs e)
        {
            DanhSachLop();
            LoadDataLop();
        }
        void ThemLop()
        {
            //Lop lop = new Lop() { LopID = Int32.Parse(txtLopID.Text), TenLop = txtTenLop.Text,DonViID = Int32.Parse(txtDonViID.Text), };
            //db.Lops.Add(lop);
            //db.SaveChanges();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            ThemLop();
            LoadDataLop();
            DanhSachLop();

        }
        void DeleteLop()
        {
            //int id = Convert.ToInt32(txtLopID.Text);
            //Lop lop = db.Lops.FirstOrDefault(p => p.LopID == id);//&& p.UserName == txtUserName.Text);

            //db.Lops.Remove(lop);
            //db.SaveChanges();
        }
        private void DanhSachLop()
        {
            //List<Lop> lstlop = db.Lops.ToList();//truyxuatdata.Intance.DonVis.ToList();

            //lstlop.Insert(0, new Lop() { TenLop = "--- Chọn Lớp---" });
            //comboBoxLop.DisplayMember = "TenLop";
            //comboBoxLop.ValueMember = "LopID";
            //comboBoxLop.DataSource = lstlop;
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {

            DeleteLop();
            DanhSachLop();
            LoadDataLop();
        }

        private void XoaLop_Click(object sender, EventArgs e)
        {
            DeleteLop();
            DanhSachLop();
            LoadDataLop();
        }
        void EditLop()
        {
            //int id = Convert.ToInt32(LopData.SelectedCells[0].OwningRow.Cells["LopID"].Value.ToString());
            //Lop lop = db.Lops.Find(id);
            //lop.TenLop = txtTenLop.Text;
            //lop.LopID = Convert.ToInt32(txtLopID.Text);
            //lop.DonViID = Convert.ToInt32(txtDonViID.Text);
            //db.SaveChanges();
        }

        private void LopData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.LopData.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtLopID.Text = row.Cells[0].Value.ToString();
                txtTenLop.Text = row.Cells[1].Value.ToString();
                txtDonViID.Text = row.Cells[2].Value.ToString();

            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            LoadDataLop();
            DanhSachLop();
            EditLop();
        }
    }
}