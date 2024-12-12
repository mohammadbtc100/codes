namespace textbox
{
    partial class myMaskedtxtbox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.editPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.editPic)).BeginInit();
            this.SuspendLayout();
            // 
            // editPic
            // 
            this.editPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editPic.Image = global::MaskedTextbox.Properties.Resources.edit;
            this.editPic.Location = new System.Drawing.Point(162, 4);
            this.editPic.Name = "editPic";
            this.editPic.Size = new System.Drawing.Size(21, 16);
            this.editPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editPic.TabIndex = 4;
            this.editPic.TabStop = false;
            this.editPic.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 6);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "عنوان شی :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Mask = "####/##/##";
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 5;
            // 
            // myMaskedtxtbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editPic);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "myMaskedtxtbox";
            this.Size = new System.Drawing.Size(295, 29);
            ((System.ComponentModel.ISupportInitialize)(this.editPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox editPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBox1;
    }
}
