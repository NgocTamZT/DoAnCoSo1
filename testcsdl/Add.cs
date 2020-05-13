using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testcsdl.Table;

namespace testcsdl
{
    public partial class Add : Form
    {
        database db = new database();
        public Add()
        {
            InitializeComponent();
        }

        private void btnADDSV_Click(object sender, EventArgs e)
        {
            AddSinhVien();
            
        }
        
        void AddSinhVien()
        {
            //User sv = new User() { UserID = Convert.ToInt32(txtUserID.Text), UserName = txtUserName.Text,Email = txtEmail.Text, LopID= Convert.ToInt32(txtLopID.Text), DonViID = Convert.ToInt32(txtDonViID.Text) };
            //db.Users.Add(sv);
            //db.SaveChanges();
            
        }
        void DeleteSinhVien()
        {
            //int id = Convert.ToInt32(txtUserID.Text);
            //User sv = db.Users.FirstOrDefault(p => p.UserID == id);
            //db.Users.Remove(sv);
            //db.SaveChanges();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DeleteSinhVien();

        }
    }
}
