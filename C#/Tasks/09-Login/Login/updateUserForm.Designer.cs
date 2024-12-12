namespace Login
{
    partial class updateUserForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtpass = new textbox.mytxtbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtuser = new textbox.mytxtbox();
            this.txtpost = new textbox.mytxtbox();
            this.txtfamily = new textbox.mytxtbox();
            this.txtname = new textbox.mytxtbox();
            this.txtcode = new textbox.mytxtbox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = global::Login.Properties.Resources.Nano_Symbol_Check9;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(288, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "ثبت اطلاعات";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(7, 72);
            this.txtpass.myIsNumerical = false;
            this.txtpass.myLeftToRightText = true;
            this.txtpass.myMessaging = true;
            this.txtpass.MyMessagingTitle = "کلمه عبور ";
            this.txtpass.MyTextString = "";
            this.txtpass.MyTitleString = "کلمه عبور :";
            this.txtpass.Name = "txtpass";
            this.txtpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpass.Size = new System.Drawing.Size(270, 32);
            this.txtpass.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Controls.Add(this.txtpost);
            this.groupBox1.Controls.Add(this.txtfamily);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(7, 44);
            this.txtuser.myIsNumerical = false;
            this.txtuser.myLeftToRightText = true;
            this.txtuser.myMessaging = true;
            this.txtuser.MyMessagingTitle = "نام کاربری ";
            this.txtuser.MyTextString = "";
            this.txtuser.MyTitleString = "نام کاربری :";
            this.txtuser.Name = "txtuser";
            this.txtuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtuser.Size = new System.Drawing.Size(270, 32);
            this.txtuser.TabIndex = 7;
            // 
            // txtpost
            // 
            this.txtpost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpost.Location = new System.Drawing.Point(7, 16);
            this.txtpost.myIsNumerical = false;
            this.txtpost.myLeftToRightText = false;
            this.txtpost.myMessaging = false;
            this.txtpost.MyMessagingTitle = null;
            this.txtpost.MyTextString = "";
            this.txtpost.MyTitleString = "سمت :";
            this.txtpost.Name = "txtpost";
            this.txtpost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpost.Size = new System.Drawing.Size(270, 32);
            this.txtpost.TabIndex = 6;
            // 
            // txtfamily
            // 
            this.txtfamily.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfamily.Location = new System.Drawing.Point(276, 71);
            this.txtfamily.myIsNumerical = false;
            this.txtfamily.myLeftToRightText = false;
            this.txtfamily.myMessaging = false;
            this.txtfamily.MyMessagingTitle = null;
            this.txtfamily.MyTextString = "";
            this.txtfamily.MyTitleString = "نام خانوادگی :";
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfamily.Size = new System.Drawing.Size(288, 32);
            this.txtfamily.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(276, 43);
            this.txtname.myIsNumerical = false;
            this.txtname.myLeftToRightText = false;
            this.txtname.myMessaging = false;
            this.txtname.MyMessagingTitle = "نام ";
            this.txtname.MyTextString = "";
            this.txtname.MyTitleString = "نام :";
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(288, 32);
            this.txtname.TabIndex = 4;
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(276, 15);
            this.txtcode.myIsNumerical = false;
            this.txtcode.myLeftToRightText = true;
            this.txtcode.myMessaging = false;
            this.txtcode.MyMessagingTitle = "کدکارمندی";
            this.txtcode.MyTextString = "";
            this.txtcode.MyTitleString = "کدکارمندی :";
            this.txtcode.Name = "txtcode";
            this.txtcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcode.Size = new System.Drawing.Size(288, 32);
            this.txtcode.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Image = global::Login.Properties.Resources.exit;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(156, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "خروج";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 171);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateUserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش";
            this.Load += new System.EventHandler(this.updateUserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private textbox.mytxtbox txtpass;
        private System.Windows.Forms.GroupBox groupBox1;
        private textbox.mytxtbox txtuser;
        private textbox.mytxtbox txtpost;
        private textbox.mytxtbox txtfamily;
        private textbox.mytxtbox txtname;
        private textbox.mytxtbox txtcode;
        private System.Windows.Forms.Button button3;
    }
}