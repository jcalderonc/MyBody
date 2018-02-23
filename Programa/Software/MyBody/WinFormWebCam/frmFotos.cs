using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;



namespace WinFormWebCam
{
    //Design by Pongsakorn Poosankam
    public partial class Principal : Form
    {
        public Principal(int _ID)
        {
            ID = _ID;
            InitializeComponent();
        }

        WebCam webcam;
        private void mainWinForm_Load(object sender, EventArgs e)
        {
           webcam = new WebCam();
           webcam.InitializeWebCam(ref imgVideo);
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void bntContinue_Click(object sender, EventArgs e)
        {
            webcam.Continue();
        }

        private void bntCapture_Click(object sender, EventArgs e)
        {
            imgCapture.Image = imgVideo.Image;
        }
        public int ID { get; set; }
        private void bntSave_Click(object sender, EventArgs e)
        {
            SaveImageCapture(imgCapture.Image, ID);
            Application.Exit();
        }
        public void SaveImageCapture(System.Drawing.Image _Image, int _IDSocio)
        {
            try
            {
                string filename = Application.StartupPath + "/Fotos/" + _IDSocio.ToString().PadLeft(6, '0') + ".jpeg";
                _Image.Save(filename);
                MessageBox.Show("Foto grabada.");        
            }
            catch
            {
                MessageBox.Show("Error al grabar la foto.");
            }
        }

        private void bntVideoFormat_Click(object sender, EventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void bntVideoSource_Click(object sender, EventArgs e)
        {
            webcam.AdvanceSetting();
        }

         
    }
}
