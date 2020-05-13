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
using System.Collections;

namespace testcsdl
{
    public partial class DonViControl : DevExpress.XtraEditors.XtraForm
    {
        database db = new database();
        public DonViControl()
        {
            InitializeComponent();
        }
        void LoadDataDonVi()
        {
            DonViData.DataSource = db.DonVis.Select(us => new
            {
                DonViID = us.DonViID,
                TenDonVi = us.TenDonVi,
                
            }).ToList();
        }

        private void DonViControl_Load(object sender, EventArgs e)
        {
            DanhSachDonVi();
            LoadDataDonVi();
        }

        
        void ThemDonVi()
        {
            DonVi donVi = new DonVi() { DonViID = Int32.Parse(txtDonViID.Text), TenDonVi = txtTenDonVi.Text,  };
            db.DonVis.Add(donVi);
            db.SaveChanges();
        }

        private void btnThemDonVi_Click(object sender, EventArgs e)
        {
            ThemDonVi();
            LoadDataDonVi();
        }
        void EditDonVi()
        {
            int id = Convert.ToInt32(DonViData.SelectedCells[0].OwningRow.Cells["DonViID"].Value.ToString());
            DonVi donvi = db.DonVis.Find(id);
            donvi.TenDonVi = txtTenDonVi.Text;
            donvi.DonViID = Convert.ToInt32(txtDonViID.Text);
            db.SaveChanges();
        }

        private void btnSuaDonVi_Click(object sender, EventArgs e)
        {
            EditDonVi();
            DanhSachDonVi();
            LoadDataDonVi();
        }

        private void DonViData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.DonViData.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtDonViID.Text = row.Cells[0].Value.ToString();
                txtTenDonVi.Text = row.Cells[1].Value.ToString();

            }
        }
        //private void timdonvi()
        //{
            
        //    string TenDonvi = "";
            
        //    TenDonvi = "" + comboBox1.SelectedValue;

        //    List<DonVi> lstDonvi = db.DonVis.ToList();
        //    IEnumerable lstDonvi = db.DonVis.ToString();
        //    if (!string.IsNullOrEmpty(TenDonvi))
        //    {
        //        lstDonvi = lstDonvi.ToString(p => p.TenDonVi == TenDonvi);
        //    }
        //}

        private void DanhSachDonVi()
        {
            List<DonVi> lstDonvi = db.DonVis.ToList();//truyxuatdata.Intance.DonVis.ToList();

            lstDonvi.Insert(0, new DonVi() { TenDonVi = "--- Chọn đơn vị---" });
            comboBox1.DisplayMember = "TenDonVi";
            comboBox1.ValueMember = "DonViID";
            comboBox1.DataSource = lstDonvi;
        }
        void DeleteDonVi()
        {
            int id = Convert.ToInt32(txtDonViID.Text);
            DonVi donvi = db.DonVis.FirstOrDefault(p => p.DonViID == id);//&& p.UserName == txtUserName.Text);

            db.DonVis.Remove(donvi);
            db.SaveChanges();
        }

        private void btnXoaDonVi_Click(object sender, EventArgs e)
        {
            DeleteDonVi();
            DanhSachDonVi();
            LoadDataDonVi();
        }

        private void XoaDonVi_Click(object sender, EventArgs e)
        {
            DeleteDonVi();
            DanhSachDonVi();
            LoadDataDonVi();
        }

        private void btntimkiemdonvi_Click(object sender, EventArgs e)
        {
            
                
        }

        private void btnXoaDonVi_Click_1(object sender, EventArgs e)
        {

        }
    }
}