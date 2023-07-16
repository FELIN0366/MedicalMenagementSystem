using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicalMenagementSystem
{
    public partial class chatroom : Form
    {
        bool formMove = false;
        Point formPoint;

        Thread thUpdateNewMessage;    //创建线程用于更新新消息信息
        Thread thLoadMessage;       //创建线程用于加载信息
        string connectionStr;         //连接字符串
        string meString;    //当前界面的使用者是谁
        string visitorString;
        string allMessage;      //用来存放加载的聊天记录
        bool isChatting = false;
        string userType;

        public chatroom()
        {
            InitializeComponent();

            meString = "13922988811";
        }

        public chatroom(string meString)
        {
            InitializeComponent();

            this.meString = meString;
        }
        public chatroom(string meString, string userType)
        {
            InitializeComponent();

            this.meString = meString;
            this.userType = userType;
        }

        /// <summary>
        /// add user to list view and display
        /// </summary>
        void addUserToListView()
        {
            try
            {
                if (userType == "patient")
                {
                    string connectStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=account";
                    string op = string.Format("select * from idpwdoctor");
                    using (MySqlConnection conn = new MySqlConnection(connectStr))
                    {
                        using (MySqlCommand myCommand = new MySqlCommand(op, conn))
                        {
                            conn.Open();
                            MySqlDataReader myReader = myCommand.ExecuteReader();   //遍历表格
                            while (myReader.Read())
                            {
                                listView1.Items.Add(myReader["id"].ToString());
                            }
                            myReader.Close();
                            myReader.Dispose();
                            conn.Close();
                        }
                    }
                }
                else
                {
                    // userType == "doctor"
                    string connectStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=account";
                    string op = string.Format("select * from idpwpatient");
                    using (MySqlConnection conn = new MySqlConnection(connectStr))
                    {
                        using (MySqlCommand myCommand = new MySqlCommand(op, conn))
                        {
                            conn.Open();
                            MySqlDataReader myReader = myCommand.ExecuteReader();   //遍历表格
                            while (myReader.Read())
                            {
                                listView1.Items.Add(myReader["id"].ToString());
                            }
                            myReader.Close();
                            myReader.Dispose();
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// if new messages, perform tips
        /// </summary>
        private void updateNewMessage()
        {
            try
            {
                while (true)  //死循环
                {
                    /* 新消息情况 */
                    string op = string.Format("select * from chat_transcript");
                    using (MySqlConnection conn = new MySqlConnection(connectionStr))
                    {
                        using (MySqlCommand myCommand = new MySqlCommand(op, conn))
                        {
                            conn.Open();
                            MySqlDataReader myReader = myCommand.ExecuteReader();   //遍历表格
                            while (myReader.Read())
                            {
                                //有新消息
                                if (myReader["tag"].ToString() == "1" && myReader["saver"].ToString() == meString && myReader["sender"].ToString() != meString)
                                {
                                    //委托修改item的颜色
                                    if (listView1.IsHandleCreated)
                                    {
                                        this.Invoke(new Action(() =>
                                        {
                                            listView1.FindItemWithText(myReader["sender"].ToString()).BackColor = Color.Gold;
                                        }));
                                    }

                                    Thread.Sleep(500);

                                    //委托修改item的颜色
                                    if (listView1.IsHandleCreated)
                                    {
                                        this.Invoke(new Action(() =>
                                        {
                                            listView1.FindItemWithText(myReader["sender"].ToString()).BackColor = Color.White;
                                            //listView1.FindItemWithText(myReader["sender"].ToString()).ForeColor = Color.Black;
                                        }));
                                    }

                                    Thread.Sleep(100);

                                    //委托修改item的颜色
                                    if (listView1.IsHandleCreated)
                                    {
                                        this.Invoke(new Action(() =>
                                        {
                                            listView1.FindItemWithText(myReader["sender"].ToString()).BackColor = Color.Gold;
                                            //listView1.FindItemWithText(myReader["sender"].ToString()).ForeColor = Color.White;
                                        }));
                                    }
                                }
                                else if (myReader["tag"].ToString() == "0" && myReader["saver"].ToString() == meString && myReader["sender"].ToString() != meString)
                                {
                                    //委托修改item的颜色
                                    if (listView1.IsHandleCreated)
                                    {
                                        this.Invoke(new Action(() =>
                                        {
                                            listView1.FindItemWithText(myReader["sender"].ToString()).BackColor = Color.White;
                                            //listView1.FindItemWithText(myReader["sender"].ToString()).ForeColor = Color.Black;
                                        }));
                                    }
                                }
                            }
                            myReader.Close();
                            myReader.Dispose();
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// load message/ new message to the chat box
        /// </summary>
        private void loadMessage()
        {
            allMessage = "";
            try
            {
                int count = -1;
                while (true)  //死循环
                {
                    /* 加载新消息 */
                    using (MySqlConnection conn = new MySqlConnection(connectionStr))
                    {
                        conn.Open();

                        int temp = 0;
                        string countString = string.Format("select count(1) from chat_transcript where saver = '" + meString + "'");
                        using (MySqlCommand myCommand = new MySqlCommand(countString, conn))
                        {
                            MySqlDataReader myReader = myCommand.ExecuteReader();   //遍历表格
                                                                                    //Thread.Sleep(100);
                            myReader.Read();

                            temp = myReader.GetInt32(0);

                            myReader.Close();
                            myReader.Dispose();
                        }
                        if (count < temp)
                        {
                            allMessage = "";
                            
                            string selectString = string.Format("select * from chat_transcript");
                            using (MySqlCommand myCommand = new MySqlCommand(selectString, conn))
                            {
                                MySqlDataReader myReader = myCommand.ExecuteReader();   //遍历表格
                                                                                        //Thread.Sleep(100);
                                while (myReader.Read())
                                {
                                    //有新消息
                                    if (myReader["saver"].ToString() == meString && (myReader["sender"].ToString() == visitorString || myReader["receiver"].ToString() == visitorString))
                                    {
                                        allMessage += myReader["sender"].ToString() + "  " + myReader["time"].ToString() + "\r\n" + myReader["content"].ToString() + "\r\n" + "\r\n";
                                    }
                                }
                                myReader.Close();
                                myReader.Dispose();
                            }

                            string modifyString1 = string.Format("update chat_transcript set tag = 0 where saver = '" + meString + "' and sender = '" + visitorString + "'");
                            using (MySqlCommand myCommand = new MySqlCommand(modifyString1, conn))
                            {
                                myCommand.ExecuteNonQuery();
                                //Thread.Sleep(100);
                            }

                            string modifyString2 = string.Format("update chat_transcript set tag = 0 where saver = '" + meString + "' and receiver = '" + visitorString + "'");
                            using (MySqlCommand myCommand = new MySqlCommand(modifyString2, conn))
                            {
                                myCommand.ExecuteNonQuery();
                                //Thread.Sleep(100);
                            }

                            //委托修改textBox内容
                            if (chatTranscriptTxtBox.IsHandleCreated)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    chatTranscriptTxtBox.Text = allMessage;
                                    chatTranscriptTxtBox.Refresh();
                                }));

                            }
                            count = temp;
                        }
                        conn.Close();
                    }
                    //Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 从 Microsoft 官网thread调用示例代码
        /// </summary>
        private void tryF()
        {
            var threadParameters = new System.Threading.ThreadStart(delegate { WriteTextSafe(allMessage); });
            var thread2 = new System.Threading.Thread(threadParameters);
            thread2.Start();
        }

        public void WriteTextSafe(string text)
        {
            if (chatTranscriptTxtBox.InvokeRequired)
            {
                Action safeWrite = delegate { WriteTextSafe($"{text}(THREAD2)"); };
                chatTranscriptTxtBox.Invoke(safeWrite);
            }
            else
            {
                chatTranscriptTxtBox.Text = text;
            }
        }

        /// <summary>
        /// when selected item changes, start new thread to load message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                isChatting = true;
                chatTranscriptTxtBox.Text = "";
                visitorString = listView1.SelectedItems[0].Text;

                thLoadMessage = new Thread(loadMessage);
                thLoadMessage.IsBackground = true;
                thLoadMessage.Start();
            }
            else
            {
                isChatting = false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            editTextBox.Text = "";
        }


        /// <summary>
        /// send message and save it to MySQL.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (isChatting && editTextBox.Text != "")
            {
                using (MySqlConnection conn = new MySqlConnection(connectionStr))
                {
                    conn.Open();

                    string timeString = DateTime.Now.ToString();

                    string modifyString1 = string.Format("insert into chat_transcript value('" + meString + "','" + visitorString + "','" + meString + "','" + timeString + "','" + editTextBox.Text + "',1)");
                    using (MySqlCommand myCommand = new MySqlCommand(modifyString1, conn))
                    {
                        myCommand.ExecuteNonQuery();
                    }

                    string modifyString2 = string.Format("insert into chat_transcript value('" + meString + "','" + visitorString + "','" + visitorString + "','" + timeString + "','" + editTextBox.Text + "',1)");
                    using (MySqlCommand myCommand = new MySqlCommand(modifyString2, conn))
                    {
                        myCommand.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                editTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please select who to send to first!");
            }
        }

        /// <summary>
        /// make the chat box allways display at the bottom 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chatTranscriptTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (chatTranscriptTxtBox.Text.Length > 0)
            {
                chatTranscriptTxtBox.SelectionStart = chatTranscriptTxtBox.Text.Length - 1;
                chatTranscriptTxtBox.ScrollToCaret();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }

        /// <summary>
        /// start to indicate new message when the form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chatroom_Load(object sender, EventArgs e)
        {
            /*连接字符串*/
            connectionStr = "server=rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com;port=3306;user=try;password=scut666!; database=chat_transcript";

            addUserToListView();
            /* 线程更新新消息信息 */
            thUpdateNewMessage = new Thread(updateNewMessage);  //实例化线程
            thUpdateNewMessage.IsBackground = true;
            thUpdateNewMessage.Start();  //启动线程
        }

        /// <summary>
        /// make form movable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chatroom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void chatroom_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void chatroom_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xOffSet = -e.X;
                int yOffSet = -e.Y;
                formPoint = new Point(xOffSet, yOffSet);
                formMove = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
