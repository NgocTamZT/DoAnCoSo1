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
    public partial class DanhMucControl : DevExpress.XtraEditors.XtraForm
    {
        database db = new database();
        public DanhMucControl()
        {
            InitializeComponent();
        }
        void LoadDataDanhMuc()
        {

            //DanhMucData.DataSource = db.DanhMucs.Select(us => new
            //{
            //    DanhMucID = us.DanhMucID,
            //    TenDanhMuc = us.TenDanhMuc,

            //    DonViID = us.DonViID,

            //}).ToList();
        }

        private void DanhMucControl_Load(object sender, EventArgs e)
        {
            DanhSachDanhMuc();
            LoadDataDanhMuc();
        }

        private void DanhMucData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.DanhMucData.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtDanhMucID.Text = row.Cells[0].Value.ToString();
                txtTenDanhMuc.Text = row.Cells[1].Value.ToString();
                txtDonViID.Text = row.Cells[2].Value.ToString();
                
            }
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            ThemDanhMuc();
            DanhSachDanhMuc();
            LoadDataDanhMuc();

        }
        void ThemDanhMuc()
        {
            //DanhMuc danhmuc = new DanhMuc() { DanhMucID = Int32.Parse(txtDanhMucID.Text), TenDanhMuc = txtTenDanhMuc.Text, DonViID = Int32.Parse(txtDonViID.Text), };
            //db.DanhMucs.Add(danhmuc);
            //db.SaveChanges();
        }

        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            EditDanhMuc();
            DanhSachDanhMuc();
            LoadDataDanhMuc();

        }
        void EditDanhMuc()
        {
            //int id = Convert.ToInt32(DanhMucData.SelectedCells[0].OwningRow.Cells["DanhMucID"].Value.ToString());
            //DanhMuc danhMuc = db.DanhMucs.Find(id);
            //danhMuc.DanhMucID = Convert.ToInt32(txtDanhMucID.Text);
            //danhMuc.TenDanhMuc = txtTenDanhMuc.Text;
            //danhMuc.DonViID = Convert.ToInt32(txtDonViID.Text);
            //db.SaveChanges();
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            DeleteDanhMuc();
            DanhSachDanhMuc();
            LoadDataDanhMuc();

        }
        void DeleteDanhMuc()
        {
            //int id = Convert.ToInt32(txtDanhMucID.Text);
            //DanhMuc danhmuc = db.DanhMucs.FirstOrDefault(p => p.DanhMucID == id);//&& p.UserName == txtUserName.Text);

            //db.DanhMucs.Remove(danhmuc);
            //db.SaveChanges();
        }
        private void DanhSachDanhMuc()
        {
            //List<DanhMuc> lstdanhmuc = db.DanhMucs.ToList();//truyxuatdata.Intance.DonVis.ToList();

            //lstdanhmuc.Insert(0, new DanhMuc() { TenDanhMuc = "--- Chọn Danh Mục---" });
            //comboBoxDanhMuc.DisplayMember = "TenDanhMuc";
            //comboBoxDanhMuc.ValueMember = "DanhMucID";
            //comboBoxDanhMuc.DataSource = lstdanhmuc;
        }

        private void XoaDanhMuc_Click(object sender, EventArgs e)
        {
            DeleteDanhMuc();
            DanhSachDanhMuc();
            LoadDataDanhMuc();
        }
    }
}