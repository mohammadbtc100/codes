namespace DataBase
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSqlserver = new textbox.mytxtbox();
            this.txtDatabase = new textbox.mytxtbox();
            this.txtserver = new textbox.mytxtbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radSQL = new System.Windows.Forms.RadioButton();
            this.radWin = new System.Windows.Forms.RadioButton();
            this.gUser = new System.Windows.Forms.GroupBox();
            this.txtPass = new textbox.mytxtbox();
            this.txtUser = new textbox.mytxtbox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::DataBase.Properties.Resources.exit;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(21, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 46);
            this.button3.TabIndex = 10;
            this.button3.Text = "بستن";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DataBase.Properties.Resources.Nano_Symbol_Check9;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(123, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "ثبت اطلاعات";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DataBase.Properties.Resources._new;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(225, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "نمایش آدرس";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(271, 260);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "رشته اتصال :";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(5, 277);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(336, 86);
            this.textBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSqlserver);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.txtserver);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(336, 105);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات سرویس دهنده";
            // 
            // txtSqlserver
            // 
            this.txtSqlserver.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSqlserver.ForeColor = System.Drawing.Color.Black;
            this.txtSqlserver.Location = new System.Drawing.Point(6, 46);
            this.txtSqlserver.myIsNumerical = false;
            this.txtSqlserver.myLeftToRightText = true;
            this.txtSqlserver.myMessaging = true;
            this.txtSqlserver.MyMessagingTitle = "سرویس دهنده پایگاه ";
            this.txtSqlserver.MyTextString = "SQLEXPRESS";
            this.txtSqlserver.MyTitleString = "سرویس دهنده پایگاه :";
            this.txtSqlserver.Name = "txtSqlserver";
            this.txtSqlserver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSqlserver.Size = new System.Drawing.Size(319, 29);
            this.txtSqlserver.TabIndex = 1;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.ForeColor = System.Drawing.Color.Black;
            this.txtDatabase.Location = new System.Drawing.Point(6, 72);
            this.txtDatabase.myIsNumerical = false;
            this.txtDatabase.myLeftToRightText = true;
            this.txtDatabase.myMessaging = true;
            this.txtDatabase.MyMessagingTitle = "پایگاه داده";
            this.txtDatabase.MyTextString = "myDataBase.mdf";
            this.txtDatabase.MyTitleString = "پایگاه داده :";
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDatabase.Size = new System.Drawing.Size(319, 29);
            this.txtDatabase.TabIndex = 2;
            // 
            // txtserver
            // 
            this.txtserver.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserver.ForeColor = System.Drawing.Color.Black;
            this.txtserver.Location = new System.Drawing.Point(6, 21);
            this.txtserver.myIsNumerical = false;
            this.txtserver.myLeftToRightText = true;
            this.txtserver.myMessaging = true;
            this.txtserver.MyMessagingTitle = "سرویس دهنده ";
            this.txtserver.MyTextString = ".";
            this.txtserver.MyTitleString = "سرویس دهنده :";
            this.txtserver.Name = "txtserver";
            this.txtserver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtserver.Size = new System.Drawing.Size(319, 29);
            this.txtserver.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radSQL);
            this.groupBox2.Controls.Add(this.radWin);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(5, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(336, 74);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب حالت";
            // 
            // radSQL
            // 
            this.radSQL.AutoSize = true;
            this.radSQL.ForeColor = System.Drawing.Color.Black;
            this.radSQL.Location = new System.Drawing.Point(80, 45);
            this.radSQL.Name = "radSQL";
            this.radSQL.Size = new System.Drawing.Size(245, 18);
            this.radSQL.TabIndex = 4;
            this.radSQL.Text = "حالت اهراز هویت سرویس دهنده اس کیو ال";
            this.radSQL.UseVisualStyleBackColor = true;
            this.radSQL.CheckedChanged += new System.EventHandler(this.radSQL_CheckedChanged);
            // 
            // radWin
            // 
            this.radWin.AutoSize = true;
            this.radWin.Checked = true;
            this.radWin.ForeColor = System.Drawing.Color.Black;
            this.radWin.Location = new System.Drawing.Point(184, 21);
            this.radWin.Name = "radWin";
            this.radWin.Size = new System.Drawing.Size(141, 18);
            this.radWin.TabIndex = 3;
            this.radWin.TabStop = true;
            this.radWin.Text = "حالت اهراز هویت ویندوز";
            this.radWin.UseVisualStyleBackColor = true;
            this.radWin.CheckedChanged += new System.EventHandler(this.radWin_CheckedChanged);
            // 
            // gUser
            // 
            this.gUser.Controls.Add(this.txtPass);
            this.gUser.Controls.Add(this.txtUser);
            this.gUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gUser.Location = new System.Drawing.Point(5, 181);
            this.gUser.Name = "gUser";
            this.gUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gUser.Size = new System.Drawing.Size(336, 76);
            this.gUser.TabIndex = 18;
            this.gUser.TabStop = false;
            this.gUser.Text = "اطلاعات کاربری";
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(9, 43);
            this.txtPass.myIsNumerical = false;
            this.txtPass.myLeftToRightText = true;
            this.txtPass.myMessaging = true;
            this.txtPass.MyMessagingTitle = "کلمه عبور ";
            this.txtPass.MyTextString = "";
            this.txtPass.MyTitleString = "کلمه عبور :";
            this.txtPass.Name = "txtPass";
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPass.Size = new System.Drawing.Size(319, 29);
            this.txtPass.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(9, 16);
            this.txtUser.myIsNumerical = false;
            this.txtUser.myLeftToRightText = true;
            this.txtUser.myMessaging = true;
            this.txtUser.MyMessagingTitle = "نام کاربری ";
            this.txtUser.MyTextString = "";
            this.txtUser.MyTitleString = "نام کاربری :";
            this.txtUser.Name = "txtUser";
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUser.Size = new System.Drawing.Size(319, 29);
            this.txtUser.TabIndex = 5;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 420);
            this.Controls.Add(this.gUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private textbox.mytxtbox txtSqlserver;
        private textbox.mytxtbox txtDatabase;
        private textbox.mytxtbox txtserver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radSQL;
        private System.Windows.Forms.RadioButton radWin;
        private System.Windows.Forms.GroupBox gUser;
        private textbox.mytxtbox txtPass;
        private textbox.mytxtbox txtUser;
    }
}