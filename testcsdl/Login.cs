using System;
using System.Linq;

namespace testcsdl
{
    public partial class Login : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin fma = new Admin();
            fma.Show();
        }
    }
}
