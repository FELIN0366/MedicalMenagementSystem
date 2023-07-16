using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json.Linq;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection.Emit;

namespace MedicalMenagementSystem
{
    public partial class frmLoginPatient : Form
    {
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoDevice;
        int currentIndex = 0;
        
        /// <summary>
        /// import DLL
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [DllImport("cppDLL.dll")]

        static extern IntPtr returnPasswordPatient(IntPtr s);


        public frmLoginPatient()
        {
            InitializeComponent();
        }

        frmStart fs;
        public frmLoginPatient(frmStart f)
        {
            InitializeComponent();

            fs = f;
        }

        /// <summary>
        /// initialize the camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //获取摄像头
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    //没有摄像头，不支持人脸识别登录
                    MessageBox.Show("No Camera Detected");
                    //禁用相关按钮
                    videoSourcePlayer1.Enabled = false;
                    cameraStart_button.Enabled = false;
                    cameraStop_button.Enabled = false;
                    faceRecognitionLogin_button.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AccountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// login judge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInButton_Click(object sender, EventArgs e)
        {
            IntPtr ptrIn = Marshal.StringToHGlobalAnsi(AccountBox.Text);
            try
            {
                IntPtr ptrRet = returnPasswordPatient(ptrIn);
                string retlust = Marshal.PtrToStringAnsi(ptrRet);

                //判断是否存在此账号
                if(retlust == "-1")
                {
                    MessageBox.Show("Sorry,the account does not exist");
                    return;
                }

                if (retlust != PasswordBox.Text)
                {
                    MessageBox.Show("Passwords wrong, Please Re_enter", "Log in Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PasswordBox.Text = "";
                    PasswordBox.Focus();
                }
                else
                {
                    //成功登录
                    MessageBox.Show("Welcome to medical system!", "Log in sucssfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new navigatorPatient(ptrIn,this).Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// clear the text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            AccountBox.Text = "";
            PasswordBox.Text = "";
        }
        public  void clearClick()
        {
            AccountBox.Text = "";
            PasswordBox.Text = "";
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            new createAccountPatient(this).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fs != null)
            {
                fs.Show();
                this.Hide();
            }
            else
            {
                new frmStart().Show();
                this.Hide();
            }
        }

        /// <summary>
        /// code that make form movable
        /// </summary>
        bool formMove = false;
        Point formPoint;
        private void frmLoginPatient_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void frmLoginPatient_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void frmLoginPatient_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
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
                videoDevice = new VideoCaptureDevice(videoDevices[currentIndex].MonikerString);
                //将摄像头视频播放在控件中
                videoSourcePlayer1.VideoSource = videoDevice;
                //开启摄像头
                videoSourcePlayer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can Not Start The Camera！", ex.Message);
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
                MessageBox.Show("Can Not Stop The Camera！", ex.Message);
            }
        }

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

        /// <summary>
        /// login judgement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void faceRecognitionLogin_button_Click(object sender, EventArgs e)
        {
            if (videoSourcePlayer1.IsRunning == true)
            {
                bool samePerson = false;

                //拍照
                Bitmap face_just_taken = videoSourcePlayer1.GetCurrentVideoFrame();
                //将刚拍下的人脸照片转Base64
                string face_just_taken_base64string = BitmapToByteToBase64String(face_just_taken);

                //创建一个实例
                // 设置APPID/AK/SK
                var API_KEY = "Ou8uuvsLl1fUg7GVSRvDB7oa";
                var SECRET_KEY = "wSRRBwOR3Zar2ahiGWNta9ANIrdG9D1F";
                var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
                client.Timeout = 60000;  // 修改超时时间

                //查询系统中用户的人脸的face_token
                var userId = AccountBox.Text;
                var groupId = "patient";
                JObject result;
                JArray res;
                JObject obj;
                string face_stored_in_system_token;
                try
                {
                    result = client.FaceGetlist(userId, groupId);
                    res = result["result"].Value<JArray>("face_list");
                    obj = JObject.Parse(res[0].ToString());
                    face_stored_in_system_token = obj.Value<string>("face_token");

                    //对比两张照片的相似度
                    var faces = new JArray
                    {
                        new JObject
                        {
                            {"image", face_stored_in_system_token},
                            {"image_type", "FACE_TOKEN"},
                        },
                        new JObject
                        {
                            {"image", face_just_taken_base64string},
                            {"image_type", "BASE64"},
                        }
                    };

                    var match_result = client.Match(faces);

                    if (match_result["error_code"].ToString() == "0")
                    //比对操作成功，返回比对结果
                    {
                        double match_score = match_result["result"].Value<double>("score");
                        if(match_score > 60)
                        {
                            samePerson = true;
                        }
                    }
                    else
                    //比对操作失败
                    {
                        MessageBox.Show("Comparison Faild！");
                        Console.WriteLine(match_result);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Account Not Registered Or Face Not Registered!");
                }

                //关闭摄像头
                videoSourcePlayer1.Stop();

                if (samePerson)
                {
                    //成功登录
                    IntPtr ptrIn = Marshal.StringToHGlobalAnsi(AccountBox.Text);
                    MessageBox.Show("Welcome to medical system!", "Log in sucssfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new navigatorPatient(ptrIn, this).Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please turn on the camera!");
            }
        }

        /// <summary>
        /// if there are more than 1 cemera on your computer, you can click the button to change another one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeCamera_button_Click(object sender, EventArgs e)
        {
            try
            {
                videoSourcePlayer1.Stop();

                if(videoDevices.Count == 1)
                {
                    MessageBox.Show("Sorry,You Have Only One Camera!");
                    Console.WriteLine(currentIndex);
                }
                else
                {
                    currentIndex = (currentIndex + 1) % videoDevices.Count;
                    Console.WriteLine(currentIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
