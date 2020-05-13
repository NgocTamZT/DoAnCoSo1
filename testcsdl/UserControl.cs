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
    public partial class UserControl : DevExpress.XtraEditors.XtraForm
    {
        database db = new database();
        public UserControl()
        {
            InitializeComponent();
        }

        void LoadDataUser()
        {
            //UserData.DataSource = db.Users.Select(us => new
            //{
            //    UserID = us.UserID,
            //    UserName = us.UserName,
            //    Email = us.Email,
            //    DonViID = us.DonViID,
            //    LopID = us.LopID
            //}).ToList();
        }
        

        private void UserControl_Load(object sender, EventArgs e)
        {
            //UserData.DataSource = db.Users.ToList();
            LoadDataUser();
        }

        private void UserData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.UserData.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtUserID.Text = row.Cells[0].Value.ToString();
                txtUserName.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtDonViID.Text = row.Cells[3].Value.ToString();
                txtLopID.Text = row.Cells[4].Value.ToString();
            }
        }

        private void XoaUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
            //UserData.DataSource = db.Users.ToList();
            LoadDataUser();
        }

        void DeleteUser()
        {
        //    int id = Convert.ToInt32(txtUserID.Text);
        //    User sv = db.Users.FirstOrDefault(p => p.UserID == id);//&& p.UserName == txtUserName.Text);

        //    db.Users.Remove(sv);
        //    db.SaveChanges();
        }

        private void btnXoaUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
            //UserData.DataSource = db.Users.ToList();
            LoadDataUser();
        }

        private void btnThemUser_Click(object sender, EventArgs e)
        {
            ThemUser();
            //UserData.DataSource = db.Users.ToList();
            LoadDataUser();
        }
        void ThemUser()
        {
            //User sv = new User() { UserID = Convert.ToInt32(txtUserID.Text), UserName = txtUserName.Text, Email = txtEmail.Text, LopID = Convert.ToInt32(txtLopID.Text), DonViID = Convert.ToInt32(txtDonViID.Text) };
            //db.Users.Add(sv);
            //db.SaveChanges();
        }
        void EditUser()
        {
            //int id = Convert.ToInt32(UserData.SelectedCells[0].OwningRow.Cells["UserID"].Value.ToString());
            //User user = db.Users.Find(id);
            //user.UserName = txtUserName.Text;
            //user.UserID = Convert.ToInt32(txtUserID.Text);
            //user.Email = txtEmail.Text;
            //user.DonViID = Convert.ToInt32(txtDonViID.Text);
            //user.LopID = Convert.ToInt32(txtLopID.Text);
            //db.SaveChanges();
        }

        private void btnSuaUser_Click(object sender, EventArgs e)
        {
            //EditUser();
            //LoadDataUser();
        }
    }
}