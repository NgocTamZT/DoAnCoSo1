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
    public partial class Welcome : DevExpress.XtraEditors.XtraForm
    {
        public Welcome()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1500;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}