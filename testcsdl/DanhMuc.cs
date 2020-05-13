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
    public partial class DanhMuc : DevExpress.XtraEditors.XtraForm
    {
        database db = new database();
        public DanhMuc()
        {
            InitializeComponent();
        }
        void LoadDataDanhMuc()
        {

            //gridCtrl.datasource = db.danhmucs.select(us => new
            //{
            //    danhmucid = us.danhmucid,
            //    tendanhmuc = us.tendanhmuc,

            //    donviid = us.donviid,

            //}).tolist();
        }
        private void DanhMuc_Load(object sender, EventArgs e)
        {
            DanhSachDanhMuc();            
        }
        private void DanhSachDanhMuc()
        {
            //List<DanhMuc> lstdanhmuc = db.DanhMucs.ToList();//truyxuatdata.Intance.DonVis.ToList();
            
            //comboBox1.DisplayMember = "TenDanhMuc";
            //comboBox1.ValueMember = "DanhMucID";
            //comboBox1.DataSource = lstdanhmuc;
        }
        

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DanhMuc danhmuc = new DanhMuc() { DanhMucID = Int32.Parse(txtDanhMucID.Text), TenDanhMuc = txtTenDanhMuc.Text, DonViID = Int32.Parse(txtDonViID.Text), };
            //db.DanhMucs.Add(danhmuc);
            //db.SaveChanges();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}