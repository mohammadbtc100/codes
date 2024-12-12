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
    public partial class AddUser : Office2007Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void addUserForm_Load(object sender, EventArgs e)
        {
            StyleManager st = new StyleManager();
            RegisterySetting.theme th = new RegisterySetting.theme();
            st.ManagerStyle = th.loadeStyle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcode.MyTextString = string.Empty;
            txtfamily.MyTextString = string.Empty;
            txtname.MyTextString = string.Empty;
            txtpass.MyTextString = string.Empty;
            txtpost.MyTextString = string.Empty;
            txtuser.MyTextString = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase.myDataBase db = new DataBase.myDataBase();
            string str = "INSERT INTO tblusers(code,firstname,lastname,post,username,password) VALUES({0},'{1}','{2}','{3}','{4}','{5}')";
            str = string.Format(str, txtcode.MyTextString, txtname.MyTextString, txtfamily.MyTextString, txtpost.MyTextString,txtuser.MyTextString, txtpass.MyTextString);

            MessageBox.Show(db.workWithData(str));
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
