using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;
namespace DataBase
{
    public partial class SettingForm :Office2007Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }
        //****************Srart My Function*****************
        public string myPhysicalServer() { return txtserver.MyTextString; }
        public string mySQLServer() { return txtSqlserver.MyTextString; }
        public string myFullPath() { return txtserver.MyTextString + "\\" + txtSqlserver.MyTextString; }
        public string myOnlyDatabaseNameWithoutFileType() { return txtDatabase.MyTextString.Remove(txtDatabase.MyTextString.IndexOf(".")); }
        public string myDataBaseOrInitialCatalog() { return txtDatabase.MyTextString; }
        public string myUsername() { return txtUser.MyTextString; }
        public string myPassword() { return txtPass.MyTextString; }
        //****************end my Function*******************
        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            if (radWin.Checked == true)
            {
                sql = @"Data Source={0}\{1};AttachDbFilename=|DataDirectory|\{2};Integrated Security=True;Connect Timeout=30;User Instance=True";
                sql = string.Format(sql, txtserver.MyTextString, txtSqlserver.MyTextString, txtDatabase.MyTextString);
            }
            else
            {
                sql = @"";
                
            }
            textBox.Text = sql;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = txtserver.MyTextString + ";" + txtSqlserver.MyTextString + ";" + txtDatabase.MyTextString + ";" + txtUser.MyTextString + ";" + txtPass.MyTextString + ";";

            File.WriteAllText(Application.StartupPath+ @"\DataBase\fields.add", str);
            button1_Click(sender,e);
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

            StyleManager st = new StyleManager();
            RegisterySetting.theme th = new RegisterySetting.theme();
            st.ManagerStyle = th.loadeStyle();
            string str;
            try
            {
                str = File.ReadAllText(Application.StartupPath+@"\DataBase\fields.add");
                char ch = char.Parse(";"); 
                string[] array = str.Split(ch);
                txtserver.MyTextString = array[0];
                txtSqlserver.MyTextString = array[1];
                txtDatabase.MyTextString = array[2];
                txtUser.MyTextString = array[3];
                txtPass.MyTextString = array[4];
                button1_Click(sender,e);

            }
            catch
            {
                MessageBox.Show("فایل مسیر بانک اطلاعاتی دردسترس نمی باشد");
            }
            txtserver.Focus();
        }

        private void radWin_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            gUser.Enabled = false;
        }

        private void radSQL_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            gUser.Enabled = true;
        }
    }
}
