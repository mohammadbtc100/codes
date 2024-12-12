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
    public partial class ListUsers : Office2007Form
    {
        string opt;
        public ListUsers(string operate)
        {
            InitializeComponent();
            opt = operate;
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            StyleManager st = new StyleManager();
            RegisterySetting.theme th = new RegisterySetting.theme();
            st.ManagerStyle = th.loadeStyle();
            DataBase.myDataBase db = new DataBase.myDataBase();
            dataGridView1.DataSource = db.selectWithStoreProcedure("selectusers");
            if (opt == "list")
            {
                dataGridView1.Columns["select"].Visible = false;
                this.Width = this.Width - 52;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            if (opt == "delete")
            {
                if (MessageBox.Show("آیا شما می خواهیداین سطررا حذف کنید", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataBase.myDataBase frmMydb = new DataBase.myDataBase();
                    frmMydb.workWithData(@"delete from tblusers where id=" + myid);

                }
            }
            else if(opt=="update")
            {
                int code1 =int.Parse(dataGridView1.Rows[e.RowIndex].Cells["code"].Value.ToString());
                string firstname1 = dataGridView1.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
                string lastname1 = dataGridView1.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
                string post1 = dataGridView1.Rows[e.RowIndex].Cells["post"].Value.ToString();
                string username1 = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
                string password1 = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();
                updateUserForm frmu = new updateUserForm(myid, code1, firstname1, lastname1, post1, username1, password1);
                frmu.ShowDialog();
            }
            
            UsersList_Load(sender,e);
        }
    }
}
