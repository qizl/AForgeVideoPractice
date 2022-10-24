using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AForgeVideoPractice
{
    public partial class FormMain : Form
    {
        private FilterInfoCollection _videoDevices;  //设备对象  可以是多个
        private VideoCaptureDevice _videoSource;     //网络摄像头对象
        private SpeechSynthesizer _speech = new SpeechSynthesizer();

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //实例化设备对象
            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (_videoDevices.Count == 0)
            {
                throw new ApplicationException();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Task.Run(() => this._speech.Speak("正在打开摄像头..."));

            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            try
            {
                // 连接摄像头
                _videoSource = new VideoCaptureDevice(_videoDevices[0].MonikerString);
                _videoSource.VideoResolution = _videoSource.VideoCapabilities[0];

                this.videoSourcePlayer1.VideoSource = _videoSource;
                this.videoSourcePlayer1.Start();
            }
            catch
            {
                Task.Run(() => this._speech.Speak("摄像头打开失败，请检查系统是否有访问权限！"));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Task.Run(() => this._speech.Speak("正在关闭摄像头..."));

            this.closeCamera();
        }
        private void closeCamera()
        {
            if (this.videoSourcePlayer1.IsRunning)
            {
                this.videoSourcePlayer1.SignalToStop();
                this.videoSourcePlayer1.WaitForStop();
            }
        }

        private void btnTakeAPhoto_Click(object sender, EventArgs e)
        {
            if (!this.videoSourcePlayer1.IsRunning)
            {
                Task.Run(() => this._speech.Speak("请先开启摄像头！"));
                return;
            }

            Task.Run(() => this._speech.Speak("正在拍照..."));

            Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
            var imageFolder = Path.Combine(Environment.CurrentDirectory, "CameraPhoto");
            if (!Directory.Exists(imageFolder))
                Directory.CreateDirectory(imageFolder);
            var filePath = Path.Combine(imageFolder, $"{DateTime.Now:yyyyMMddHHmmss}.jpg");

            try
            {
                bitmap.Save(filePath, ImageFormat.Jpeg);
                bitmap.Dispose();

                Task.Run(() => this._speech.Speak("拍照完成，照片已保存！"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.closeCamera();
        }
    }
}
