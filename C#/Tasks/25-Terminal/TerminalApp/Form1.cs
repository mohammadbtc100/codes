using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace TerminalApp
{
    public partial class Form1 : Form
    {
        private TextBox outputTextBox;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Command Prompt Simulation";
            this.Width = 900;
            this.Height = 500;

            // تنظیمات TextBox برای خروجی
            outputTextBox = new TextBox
            {
                Dock = DockStyle.Fill,
                Multiline = true,
                ReadOnly = false,
                ScrollBars = ScrollBars.Vertical,
                BackColor = Color.Black,
                ForeColor = Color.WhiteSmoke,
                Font=new Font("Tahoma",14),
            };
            outputTextBox.KeyUp += new KeyEventHandler(outputTextBox_KeyUp);
            this.Controls.Add(outputTextBox);

        }
        private void outputTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int lineIndex = outputTextBox.GetLineFromCharIndex(outputTextBox.SelectionStart);
                string activeLine = outputTextBox.Lines[lineIndex-1];
                Console.WriteLine();
                //MessageBox.Show(lineIndex.ToString());
                ExecuteCommand(activeLine);
                
            }
        }
        private void ExecuteCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
                return;

            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/C " + command)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    outputTextBox.Text += $"{command}\n{output}\n"; // نمایش خروجی دستور
                }
            }
            catch (Exception ex)
            {
                outputTextBox.Text += $"Error: {ex.Message}\n";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}