using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace BckupRestore
{
    public partial class Restore : Office2007Form
    {
        public Restore()
        {
            InitializeComponent();
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                textBox1.Text = path;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase.SettingForm s = new DataBase.SettingForm();
            string dbName = s.myOnlyDatabaseNameWithoutFileType();
            timer1.Enabled = true;
            DataBase.myDataBase db = new DataBase.myDataBase();
           //  string str = "RESTORE DATABASE " + dbName + " FROM DISK='" + path + "'";
            string str = "ALTER DATABASE " + dbName + " SET SINGLE_USER with ROLLBACK IMMEDIATE " + "use master " + " RESTORE DATABASE " + dbName + " FROM DISK='" + path + "'";
            
            progressBar1.Value = 100;
            MessageBox.Show(db.workWithData(str));
            timer1.Enabled = false;
        }

        private void Restore_Load(object sender, EventArgs e)
        {
            StyleManager st = new StyleManager();
            RegisterySetting.theme th = new RegisterySetting.theme();
            st.ManagerStyle = th.loadeStyle();
        }
    }
}
