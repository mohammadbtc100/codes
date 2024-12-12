namespace Login
{
    partial class login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpassword = new textbox.mytxtbox();
            this.txtuserName = new textbox.mytxtbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radUnit = new System.Windows.Forms.RadioButton();
            this.radTeacher = new System.Windows.Forms.RadioButton();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtuserName);
            this.groupBox1.Location = new System.Drawing.Point(5, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(7, 42);
            this.txtpassword.myIsNumerical = false;
            this.txtpassword.myLeftToRightText = true;
            this.txtpassword.myMessaging = false;
            this.txtpassword.MyMessagingTitle = "کلمه عبور";
            this.txtpassword.myTextPssword = '*';
            this.txtpassword.MyTextString = "123";
            this.txtpassword.MyTitleString = "کلمه عبور:";
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpassword.Size = new System.Drawing.Size(269, 30);
            this.txtpassword.TabIndex = 1;
            // 
            // txtuserName
            // 
            this.txtuserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserName.Location = new System.Drawing.Point(7, 15);
            this.txtuserName.myIsNumerical = false;
            this.txtuserName.myLeftToRightText = true;
            this.txtuserName.myMessaging = true;
            this.txtuserName.MyMessagingTitle = "نام کاربری";
            this.txtuserName.myTextPssword = '\0';
            this.txtuserName.MyTextString = "admin";
            this.txtuserName.MyTitleString = "نام کاربری :";
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtuserName.Size = new System.Drawing.Size(269, 30);
            this.txtuserName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radUnit);
            this.groupBox2.Controls.Add(this.radTeacher);
            this.groupBox2.Controls.Add(this.radAdmin);
            this.groupBox2.Location = new System.Drawing.Point(5, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "ورودبه عنوان :";
            // 
            // radUnit
            // 
            this.radUnit.AutoSize = true;
            this.radUnit.Location = new System.Drawing.Point(31, 19);
            this.radUnit.Name = "radUnit";
            this.radUnit.Size = new System.Drawing.Size(46, 17);
            this.radUnit.TabIndex = 2;
            this.radUnit.Text = "واحد";
            this.radUnit.UseVisualStyleBackColor = true;
            // 
            // radTeacher
            // 
            this.radTeacher.AutoSize = true;
            this.radTeacher.Location = new System.Drawing.Point(89, 19);
            this.radTeacher.Name = "radTeacher";
            this.radTeacher.Size = new System.Drawing.Size(50, 17);
            this.radTeacher.TabIndex = 1;
            this.radTeacher.Text = "استاد";
            this.radTeacher.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Checked = true;
            this.radAdmin.Location = new System.Drawing.Point(150, 18);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(44, 17);
            this.radAdmin.TabIndex = 0;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "مدیر";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Login.Properties.Resources.exit;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(65, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "خروج";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Login.Properties.Resources.Nano_Login;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(152, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "ورود";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 175);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private textbox.mytxtbox txtpassword;
        private textbox.mytxtbox txtuserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radUnit;
        private System.Windows.Forms.RadioButton radTeacher;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}