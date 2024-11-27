using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword.TabIndex = 0;
            txtPassword.Focus();    //to active a control
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length <= 0) {
                MessageBox.Show("کلمه عبور را وارد نمایید");
                return;   //exit from btnLogin_Click event
            }
            
            User user = new User();
            bool b=user.login(txtUsername.Text,txtPassword.Text);
            if (b) { 
                Close();
            }
            else {
                MessageBox.Show("اطلاعات کاربری را درست وارد نمایید");
            }
        }
    }
}
