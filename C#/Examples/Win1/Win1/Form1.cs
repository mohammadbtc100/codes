using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout=ImageLayout.Stretch;
            this.BackgroundImage = Image.FromFile("bg1.jpg");

            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterParent;
            login.ShowDialog(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("در دست طراحی می باشد");
        }

        private void cntactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("در دست طراحی می باشد");
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs obj = new AboutUs();
            obj.Text = "درباره ما";
            obj.ControlBox=false;
            obj.RightToLeft = RightToLeft.Yes;  
            obj.StartPosition=FormStartPosition.CenterParent;
            obj.BackColor = Color.Gray;    //background color
            obj.ForeColor = Color.Black;    //text color
            obj.Height = 300;
            obj.Width = 600;
            obj.ShowDialog();
        }

        private void mnuFileUserExit_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.StartPosition = FormStartPosition.CenterParent; 
            obj.ShowDialog(this);
        }
    }
}
