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
using AForge.Video;
using AForge.Video.DirectShow;
namespace WebcamApp
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices; // Collection of available video devices
        private VideoCaptureDevice videoSource; // The selected video source
        public Form1()
        {
            InitializeComponent();
            LoadWebcams();
        }
        private void LoadWebcams()
        {
            // Get available video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                cboCamera.Items.Add(device.Name); // Add device names to ComboBox
            }
            if (cboCamera.Items.Count > 0)
                cboCamera.SelectedIndex = 0; // Select the first device by default
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Display the current frame in the PictureBox
            pic.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Stop capturing when closing the form
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            base.OnFormClosing(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Start capturing from the selected webcam
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[cboCamera.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start(); // Start capturing
            }
        }
    }
}
