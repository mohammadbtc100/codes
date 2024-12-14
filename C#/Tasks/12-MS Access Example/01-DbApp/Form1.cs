using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbApp
{
    public partial class Form1 : Form
    {
        private string strConn;
        OleDbConnection conn;
        OleDbCommand cmd;
        public Form1()
        {
            InitializeComponent();
            strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\repos\DbApp\bin\Debug\Database.accdb";
            conn = new OleDbConnection(strConn);
            cmd = new OleDbCommand();
            cmd.Connection = conn;
        }
        public void selectAll()
        {
            cmd.CommandText = "select * from users";
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            selectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdString= @"INSERT INTO users([name],username,[password]) values('{0}','{1}','{2}');";
            cmdString=string.Format(cmdString,txtName.Text,txtUsername.Text,txtPassword.Text);
            cmd = new OleDbCommand(cmdString,conn);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            int r= cmd.ExecuteNonQuery();
            if(r >0)
                MessageBox.Show("Your new user is inserted!");

            if (conn.State == ConnectionState.Closed)
                conn.Close();
           
            txtName.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            //بارگذاری مجدد لیست
            selectAll();
        }
        int selected_index;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //دریافت مقدار شناسه سطر
            string str = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            selected_index = Convert.ToInt32(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdString = @"update users set [name]='{0}',username='{1}',[password]='{2}' where id={3}";
            cmdString = string.Format(cmdString, txtName.Text, txtUsername.Text, txtPassword.Text,selected_index);
            selected_index = -1;

            cmd = new OleDbCommand(cmdString, conn);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            int r = cmd.ExecuteNonQuery();
            if (r > 0)
                MessageBox.Show("Your new user is updated!");

            if (conn.State == ConnectionState.Closed)
                conn.Close();

            txtName.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            //بارگذاری مجدد لیست
            selectAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete
            cmd = new OleDbCommand("delete from users where id="+selected_index, conn);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            int r = cmd.ExecuteNonQuery();
            if (r > 0)
                MessageBox.Show("Your new user is deleted!");

            if (conn.State == ConnectionState.Closed)
                conn.Close();

            txtName.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            //بارگذاری مجدد لیست
            selectAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //search based name or username
            string sql= "select * from users where ";
            if(txtName!=null)
                sql +="name='"+ txtName.Text+"'";
            else if (txtUsername != null)
                sql += "username='" + txtUsername.Text + "'";

            cmd.CommandText = sql;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectAll();    
        }
    }
}
