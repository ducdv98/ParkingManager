using ParkingManager.Data.Repositories;
using System;
using System.Windows.Forms;

namespace ParkingManager.GUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                LoginDao loginDao = new LoginDao();
                if (loginDao.Login(tbUsername.Text.Trim(), tbPassword.Text.Trim()) != null)
                {
                    FrmMain main = new FrmMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                    tbUsername.Focus();
                }
            }
        }

        private bool validateInput()
        {
            if (tbUsername.Text.Trim().Equals("") || tbPassword.Text.Trim().Equals(""))
                return false;

            return true;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !tbPassword.Text.Equals(""))
                btnLogin_Click(null, null);
        }
    }
}
