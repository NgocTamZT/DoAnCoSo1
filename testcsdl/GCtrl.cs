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
    public partial class GCtrl : DevExpress.XtraEditors.XtraForm
    {
        database db = new database();
        public GCtrl()
        {
            InitializeComponent();
        }

        private void gridCtrl_Click(object sender, EventArgs e)
        {

        }
        void LoadDataDonVi()
        {
            //GCtrl.DataSource = db.DonVis.Select(us => new
            //{
            //    DonViID = us.DonViID,
            //    TenDonVi = us.TenDonVi,

            //}).ToList();
        }
    }
}