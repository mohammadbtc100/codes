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
    public partial class Search :Office2007Form
    {
        public Search()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataBase.myDataBase db = new DataBase.myDataBase();
            string str = "SELECT * FROM tblusers where ";
            if (txtType.Text == "نام خانوادگی")
            {
                str += "lastname like '%{0}%'";
                str = string.Format(str, txtSearch.Text);
            }
            else
            {
                str += "code like '%{0}%'";
                str = string.Format(str,Int32.Parse(txtSearch.Text));
            }
            
            dataGridView1.DataSource = db.selectDataFromDB(str);
        }
        private void mytxtbox1_Load(object sender, EventArgs e)
        {

        }
        int myid = 0;
        int myRow = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            myid =int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            myRow = e.RowIndex;
            // MessageBox.Show(code);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا شما می خواهیداین سطررا حذف کنید", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase.myDataBase frmMydb = new DataBase.myDataBase();
                frmMydb.workWithData(@"delete from tblusers where id=" + myid);
                myid = 0;
                myRow = 0;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int code1 =int.Parse(dataGridView1.Rows[myRow].Cells[2].Value.ToString());
            string firstname1 = dataGridView1.Rows[myRow].Cells[3].Value.ToString();
            string lastname1 = dataGridView1.Rows[myRow].Cells[4].Value.ToString();
            string post1 = dataGridView1.Rows[myRow].Cells[5].Value.ToString();
            string username1 = dataGridView1.Rows[myRow].Cells[6].Value.ToString();
            string password1 = dataGridView1.Rows[myRow].Cells[7].Value.ToString();
            updateUserForm frmu = new updateUserForm(myid, code1, firstname1, lastname1, post1, username1, password1);
            frmu.ShowDialog();
            myid = 0; myRow = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             toolStripMenuItem2_Click(sender,e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toolStripMenuItem3_Click(sender,e);
            button1_Click(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchForm_Load(object sender, EventArgs e)
        {
            StyleManager st = new StyleManager();
            RegisterySetting.theme th = new RegisterySetting.theme();
            st.ManagerStyle = th.loadeStyle();
            button1_Click(sender,e); //load data
        }
        bool b = true;
        private void Search_Resize(object sender, EventArgs e)
        {
            if (b == true)
            {
                int a = (this.Width - groupBox1.Width) / 2;
                groupBox1.Left = groupBox1.Left + a;
                groupBox2.Left = groupBox1.Left;
                int a2 = (this.Height - (groupBox1.Height + groupBox2.Height - 8)) / 2;
                groupBox1.Top = groupBox1.Top + a2 - 33;
                groupBox2.Top = groupBox1.Top + groupBox1.Height + 5;
                b = false;
            }
            else
            {
                groupBox1.Left = 8;
                groupBox2.Left = 8;
                groupBox1.Top = 5;
                groupBox2.Top = groupBox1.Top + groupBox1.Height + 5;
                b = true;
            }
        }
    }
}
