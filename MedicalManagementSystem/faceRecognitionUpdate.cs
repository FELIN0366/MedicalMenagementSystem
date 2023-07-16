using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalMenagementSystem
{
    public partial class faceRecognitionUpdate : Form
    {
        string userId;
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoDevice;
        int currentIndex = 0;

        /// <summary>
        /// 将图片从 bitmap 转换成 byte[] 格式，再转化成base64string
        /// </summary>
        private string BitmapToByteToBase64String(Bitmap img)
        {
            Bitmap face = img;
            // 1.先将BitMap转成内存流
            MemoryStream ms = new MemoryStream();
            face.Save(ms, ImageFormat.Bmp);
            ms.Seek(0, SeekOrigin.Begin);
            // 2.再将内存流转成byte[]
            byte[] bytes = new byte[ms.Length];
            ms.Read(bytes, 0, bytes.Length);
            ms.Dispose();
            // 3.最后将 byte[] 转换成base64string并返回
            return Convert.ToBase64String(bytes);
        }

        public faceRecognitionUpdate()
        {
            InitializeComponent();
        }
        public faceRecognitionUpdate(string userId)
        {
            InitializeComponent();

            this.userId = userId;
        }

        /// <summary>
        /// initialize the camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void faceRecognitionUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                //获取摄像头
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count > 0)
                {
                    //告知即将要使用的摄像头名称
                    deviceNameLabel.Text = videoDevices[currentIndex].Name;
                }
                else
                {
                    //没有摄像头，不支持人脸识别登录
                    MessageBox.Show("No Camera Detected");

                    //关闭窗口
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// change camera if there are more than one camera on device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeCamera_button_Click(object sender, EventArgs e)
        {
            try
            {
                videoSourcePlayer1.Stop();

                currentIndex = (currentIndex + 1) % videoDevices.Count;

                Console.WriteLine(currentIndex);

                deviceNameLabel.Text = videoDevices[currentIndex].Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// start the camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cameraStart_button_Click(object sender, EventArgs e)
        {
            try
            {
                //实例化摄像头
                videoDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
                //将摄像头视频播放在控件中
                videoSourcePlayer1.VideoSource = videoDevice;
                //开启摄像头
                videoSourcePlayer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can Not Connnect To The Camera！", ex.Message);
            }
        }

        /// <summary>
        /// stop the camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cameraStop_button_Click(object sender, EventArgs e)
        {
            try
            {
                videoSourcePlayer1.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can Not Stop The Camera! ", ex.Message);
            }
        }

        private void xbutton_Click(object sender, EventArgs e)
        {
            try
            {
                videoSourcePlayer1.Stop();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can Not Stop The Camera! ", ex.Message);
            }
        }

        /// <summary>
        /// update the face
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void faceRecognitionUpdate_button_Click(object sender, EventArgs e)
        {
            if (videoSourcePlayer1.IsRunning == true)
            {
                //创建一个实例
                // 设置APPID/AK/SK
                var API_KEY = "Ou8uuvsLl1fUg7GVSRvDB7oa";
                var SECRET_KEY = "wSRRBwOR3Zar2ahiGWNta9ANIrdG9D1F";
                var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
                client.Timeout = 60000;  // 修改超时时间

                //获取人脸
                Bitmap img = videoSourcePlayer1.GetCurrentVideoFrame();
                string image = BitmapToByteToBase64String(img);

                var imageType = "BASE64";

                var groupId = "patient";

                try
                {
                    var result = client.UserUpdate(image, imageType, groupId, userId);
                    Console.WriteLine(result);

                    if (result["error_code"].ToString() == "0")
                    {
                        MessageBox.Show("Update SUCCESS! ");
                    }
                    else
                    {
                        MessageBox.Show("Sorry,Update FAIL! ");
                    }
                    xbutton_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Turn On The Cemara! ");
            }
        }


        /// <summary>
        /// make form movable
        /// </summary>
        bool formMove = false;
        Point formPoint;

        private void faceRecognitionUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void faceRecognitionUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void faceRecognitionUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }
    }
}
