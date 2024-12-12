using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace Login
{
    public partial class login :Office2007Form
    {
        int loginType = 0;
        public login(int type)
        {
            InitializeComponent();
            loginType = type;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            StyleManager st = new StyleManager();
            RegisterySetting.theme th = new RegisterySetting.theme();
            st.ManagerStyle = th.loadeStyle();
            if (loginType == 0)
            {
                radAdmin.Checked = true;
                //radTeacher.Enabled = false;
                //radUnit.Enabled = false;
            }
            else if (loginType == 1)
            {
              //  radAdmin.Enabled = false;
                radTeacher.Checked = true;
               // radUnit.Enabled = false;
            }
            else if (loginType == 2)
            {
                //radAdmin.Enabled = false;
               // radTeacher.Enabled = false;
                radUnit.Checked = true;
            }
            button1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            DataBase.myDataBase db = new DataBase.myDataBase();
            string str="";
            DataTable dt = new DataTable();
            if (radAdmin.Checked == true)
               str = "select count(*) from tblusers where username='{0}' and password='{1}'";
            else if (radTeacher.Checked == true)
            {
                str = "select count(*) from tblprofessor where username='{0}' and password='{1}'";
                
            }
            str = string.Format(str, txtuserName.MyTextString, txtpassword.MyTextString);
            dt = db.selectDataFromDB(str);
            if (int.Parse(dt.Rows[0][0].ToString()) >= 1)
                this.Hide();
            else
                MessageBox.Show("نام کاربری وکلمه عبوررابطورصحصح واردنمایید");

            
        }
        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
