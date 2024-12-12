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
    public partial class Bckup :Office2007Form
    {
        public Bckup()
        {
            InitializeComponent();
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                textBox1.Text = path;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase.SettingForm s = new DataBase.SettingForm();
            timer1.Enabled = true;
            DataBase.myDataBase db = new DataBase.myDataBase();
            string str = "BACKUP DATABASE "+s.myOnlyDatabaseNameWithoutFileType()+" TO DISK='"+ path+"'";
            progressBar1.Value = 100;
            MessageBox.Show(db.workWithData(str));
            timer1.Enabled = false;
        }

        private void Bckup_Load(object sender, EventArgs e)
        {
            StyleManager st = new StyleManager();
            RegisterySetting.theme th = new RegisterySetting.theme();
            st.ManagerStyle = th.loadeStyle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = (counter++).ToString();
        }
    }
}
