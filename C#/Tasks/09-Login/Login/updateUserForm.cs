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
    public partial class updateUserForm : Office2007Form
    {
        int myid = 0;
        public updateUserForm(int id,int code,string firstname,string lastname,string post,string username,string password)
        {
            InitializeComponent();
            myid = id;
            txtcode.MyTextString = code.ToString();
            txtname.MyTextString = firstname;
            txtfamily.MyTextString = lastname;
            txtpost.MyTextString = post;
            txtuser.MyTextString = username;
            txtpass.MyTextString = password;
        }
        
        private void updateUserForm_Load(object sender, EventArgs e)
        {
            StyleManager st = new StyleManager();
            RegisterySetting.theme th = new RegisterySetting.theme();
            st.ManagerStyle = th.loadeStyle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase.myDataBase db = new DataBase.myDataBase();
            string str = "update tblusers set code={0},firstname='{1}',lastname='{2}',post='{3}',username='{4}',password='{5}' where id="+myid;
            str = string.Format(str, txtcode.MyDigit, txtname.MyTextString, txtfamily.MyTextString, txtpost.MyTextString, txtuser.MyTextString, txtpass.MyTextString);
            MessageBox.Show(db.workWithData(str));
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
