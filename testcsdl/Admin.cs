using System;
using System.Linq;
using System.Windows.Forms;
using testcsdl.Table;

namespace testcsdl
{
    public partial class Admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void ControlUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(UserControl));
            if (frm == null)
            {
                UserControl userControl = new UserControl();
                userControl.MdiParent = this;
                userControl.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //this.ControlUser_ItemClick();
        }

        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void ControlDonVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form FormDonVi = kiemtraform(typeof(DonViControl));
            //if (FormDonVi == null)
            //{
            //    DonViControl donviControl = new DonViControl();
            //    donviControl.MdiParent = this;
            //    donviControl.Show();
            //}
            //else
            //{
            //    FormDonVi.Activate();
            //}
        }

        private void XemDSDanhMuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form FromDanhMuc = kiemtraform(typeof(DanhMucControl));
            //if (FromDanhMuc == null)
            //{
            //    DanhMucControl DanhMucControl = new DanhMucControl();
            //    DanhMucControl.MdiParent = this;
            //    DanhMucControl.Show();
            //}
            //else
            //{
            //    FromDanhMuc.Activate();
            //}
        }

        private void XemDSLop_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form FormLop = kiemtraform(typeof(LopControl));
            if (FormLop == null)
            {
                LopControl LopControl = new LopControl();
                LopControl.MdiParent = this;
                LopControl.Show();
            }
            else
            {
                FormLop.Activate();
            }
        }

        private void ControlHocVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form FormHocVu = kiemtraform(typeof(HocVuControl));
            //if (FormHocVu == null)
            //{
            //    HocVuControl HocVuControl = new HocVuControl();
            //    HocVuControl.MdiParent = this;
            //    HocVuControl.Show();
            //}
            //else
            //{
            //    FormHocVu.Activate();
            //}

        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //HocVu hv = new HocVu();
            //hv.Show();
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form FormHocVu = kiemtraform(typeof(HocVu));
            if (FormHocVu == null)
            {
                GCtrl frm = new GCtrl();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                FormHocVu.Activate();
            }
        }
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc1 dm = new DanhMuc1();
            dm.Show();
        }
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form FromDanhMuc = kiemtraform(typeof(DanhMuc1));
            if (FromDanhMuc == null)
            {
                GCtrl dmuc = new GCtrl();
                dmuc.MdiParent = this;
                dmuc.Show();
            }
            else
            {
                FromDanhMuc.Activate();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DonVics dv = new DonVics();
            dv.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form FormDonVi = kiemtraform(typeof(DonVics));
            if (FormDonVi == null)
            {
                GCtrl donviCtrl = new GCtrl();
                donviCtrl.MdiParent = this;
                donviCtrl.Show();
            }
            else
            {
                FormDonVi.Activate();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}