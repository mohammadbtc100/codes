using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace textbox
{
    public partial class mytxtbox : UserControl
    {
        public mytxtbox()
        {
            InitializeComponent();
        }
        public string strMyMessagingTitle;
        public string MyTitleString
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public string MyMessagingTitle
        {
            get
            {
                return strMyMessagingTitle;
            }
            set
            {
                strMyMessagingTitle = value;
            }
        }
        public string MyTextString
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public double MyDigit
        {
            get
            {
                try
                {
                    double d = 0;
                    d = double.Parse(textBox1.Text);
                    return d;
                }
                catch
                {
                    return 0;
                }
            }
        }
        public bool b;
        public bool myMessaging
        {
            set
            {
                b =value;
            }
            get
            {
                return b;
            }
        }
        
        public char myTextPssword
        {
            set
            {
                textBox1.PasswordChar = value;
            }
            get
            {
                return textBox1.PasswordChar;
            }
        }
        public bool num;
        public bool myIsNumerical
        {
            set
            {
                num = value;
            }
            get
            {
                return num;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
                textBox1.BackColor = Color.Beige;
                editPic.Visible = true;

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;

            if (num == true)
            {
                if (MyDigit == 0)
                    MessageBox.Show("لطفا مقدارعددی را برای فیلد " + strMyMessagingTitle + " واردنمایید");
            }
            else if ((b == true) && (textBox1.Text == ""))
            {
                MessageBox.Show("مقدار فیلد " + strMyMessagingTitle + " را به شکل درست واردنمایید");
            }
            editPic.Visible = false;

        }
        private bool bTxtRF;
        public bool myLeftToRightText
        {
            set
            {
                bTxtRF = value;
                if (bTxtRF == false)
                {
                    textBox1.TextAlign = HorizontalAlignment.Left;
                }
                else
                    textBox1.TextAlign = HorizontalAlignment.Right;
            }
            get
            {
                return bTxtRF;
            }
        }
        public void myTextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
