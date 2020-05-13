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
    public partial class Students : DevExpress.XtraEditors.XtraForm
    {
        database db = new database();
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }
    }
}