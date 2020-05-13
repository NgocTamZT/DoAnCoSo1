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

namespace testcsdl
{
    public partial class HocVuControl : DevExpress.XtraEditors.XtraForm
    {
        database db = new database();
        public HocVuControl()
        {
            InitializeComponent();
        }
        void LoadDataHocVu()
        {
            //HocVuData.DataSource = db.HocVus.Select(us => new
            //{
            //    HocvuID = us.HocVuID,
            //    NgayTao = us.NgayTao,
            //    NoiDung = us.NoiDung,
            //    TinhTrang = us.TinhTrang,
            //    ParentID = us.ParentID,
            //    NgayHen = us.ParentID,
            //    DanhMucID = us.DanhMucID,
            //    UserID  = us.UserID,
            //    DonViID = us.DonViID,
            //}).ToList();
        }

        private void HocVuControl_Load(object sender, EventArgs e)
        {
            LoadDataHocVu();
        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }
    }
}