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
    public partial class User1 : DevExpress.XtraEditors.XtraForm
    {
        public User1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            

            XtraMessageBox.Show("Lưu thành công");
            this.Close();
        }
    }
}