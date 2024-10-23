using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbLab2
{
    public partial class Form1 : Form
    {
        Persistence.DbContext dbContext;
        public Form1()
        {
            InitializeComponent();
            dbContext = new Persistence.DbContext();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = openFileDialog1.FileName;
            int v = dbContext.add(new Models.Novel(0,textBox1.Text, dbContext.imageToBytes(openFileDialog1.FileName)));
            if (v == 1)
                MessageBox.Show("You image is inserted!");
            else
                MessageBox.Show("Error");
            dataGridView1.DataSource=dbContext.getList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.BackgroundImage=Image.FromFile(openFileDialog1.FileName);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.getList();
        }
        private int rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get image from a row
            byte[] img = (byte[])dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            pictureBox1.BackgroundImage=dbContext.bytesToImage(img);

            //get row id
            rowId = -1;
            string strId = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            rowId = int.Parse(strId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int v=dbContext.delete(rowId);
            if (v == 1)
                MessageBox.Show("You image is Deleted!");
            else
                MessageBox.Show("Error");
            
            //new loading
            dataGridView1.DataSource = dbContext.getList();
        }
    }
}
