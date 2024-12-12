namespace EFApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button_add = new Button();
            txtTitle = new TextBox();
            button_update = new Button();
            checkBoxCompleted = new CheckBox();
            button_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(448, 569);
            dataGridView1.TabIndex = 0;
            // 
            // button_add
            // 
            button_add.Location = new Point(796, 36);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 1;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(495, 38);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(295, 27);
            txtTitle.TabIndex = 2;
            // 
            // button_update
            // 
            button_update.Location = new Point(796, 71);
            button_update.Name = "button_update";
            button_update.Size = new Size(94, 29);
            button_update.TabIndex = 3;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // checkBoxCompleted
            // 
            checkBoxCompleted.AutoSize = true;
            checkBoxCompleted.Location = new Point(503, 74);
            checkBoxCompleted.Name = "checkBoxCompleted";
            checkBoxCompleted.Size = new Size(167, 24);
            checkBoxCompleted.TabIndex = 4;
            checkBoxCompleted.Text = "checkBoxCompleted";
            checkBoxCompleted.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(796, 106);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(94, 29);
            button_delete.TabIndex = 5;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 607);
            Controls.Add(button_delete);
            Controls.Add(checkBoxCompleted);
            Controls.Add(button_update);
            Controls.Add(txtTitle);
            Controls.Add(button_add);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_add;
        private TextBox txtTitle;
        private Button button_update;
        private CheckBox checkBoxCompleted;
        private Button button_delete;
    }
}
