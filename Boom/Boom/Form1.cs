using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mytesy.Model;
using System.Reflection;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Sys.Help;
using System.IO;

namespace Boom
{
    public partial class Form1 : Form
    {
        //获取窗口标题
        [DllImport("user32", SetLastError = true)]
        public static extern int GetWindowText(
        IntPtr hWnd,//窗口句柄
        StringBuilder lpString,//标题
        int nMaxCount //最大值
        );

        //获取类的名字
        [DllImport("user32.dll")]
        private static extern int GetClassName(
        IntPtr hWnd,//句柄
        StringBuilder lpString, //类名
        int nMaxCount //最大值
        );

        //根据坐标获取窗口句柄
        [DllImport("user32")]
        private static extern IntPtr WindowFromPoint(
        Point Point  //坐标
        );

        [DllImport("user32.dll")]//引入user32.dll
        public static extern IntPtr PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);//hwnd是另一个窗口句柄，msg消息ID

        [DllImport("user32.dll ", CharSet = CharSet.Unicode)]
        public static extern IntPtr PostMessage(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr PostMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", EntryPoint = "PostMessage")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        
        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(
            byte bVk,
            byte bScan,
            int dwFlags,  //这里是整数类型  0 为按下，2为释放
            int dwExtraInfo  //这里是整数类型 一般情况下设成为 0
        );

        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(System.IntPtr hWnd);

        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(System.IntPtr hWnd, int cmdShow);

        public static MsgState CURMSGSTATE = MsgState.text;
        //private static string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["mvctest"].ConnectionString.Trim();
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection conn;
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    conn = new SqlConnection();
        //    conn.ConnectionString = CONNECTIONSTRING;
        //    conn.Open();

        //    //实例化数据库命令
        //    //SqlCommand com = new SqlCommand();
        //    //这个操作的目标指向conn
        //    //com.Connection = conn;
        //    //在数据库中执行以下文本的内容
        //    //com.CommandText = "INSERT T_XT_User(UserId,UserName,Account,Password,CreateTime) VALUES('" + Guid.NewGuid().ToString("N") + "','" + this.Name.Text + "','" + this.Account.Text + "','"+this.Psw.Text+"','" + DateTime.Now + "')";
        //    SqlDataAdapter Adapter = new SqlDataAdapter("select * from T_XT_User",conn);
        //    DataSet ds = new DataSet();

        //    Adapter.Fill(ds, "T_XT_User");



        //    DataTable dt = ds.Tables[0];
        //    var _len = dt.Rows.Count;
        //    List<T_XT_User> _list=new List<T_XT_User>();
        //    foreach (DataRow dr in dt.Rows) {
        //        _list.Add((T_XT_User)DataRowToObj(dr,new T_XT_User()));
        //    }

        //    try
        //    {
        //        //com.ExecuteNonQuery();返回一个值
        //        //正值：表示的是之前COMMAND语句影响的行数
        //        //负值表示没成功
        //        //com.ExecuteNonQuery();
        //        //MessageBox.Show("添加成功!");
        //    }
        //    catch (Exception ex)
        //    {
        //        //弹出一个提示框显示错误内容
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        #region
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object DataRowToObj(System.Data.DataRow dr, object obj)
        {
            try
            {
                if (dr != null && obj != null)
                {
                    Type t = obj.GetType();
                    PropertyInfo[] f = t.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                    // |表示
                    string tableName = t.Name;
                    foreach (PropertyInfo pi in f)
                    {
                        string field = pi.Name;
                        if (dr.Table.Columns.Contains(field) && dr[field] != DBNull.Value)
                            pi.SetValue(obj, dr[field], null);
                    }
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.ToString());
                return null;
            }
            return obj;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            //Graphics g = this.CreateGraphics();
            //var ran=(int)new Random().Next(0,colors.Length);
            //Pen p = new Pen(colors[ran]);
            //Point p1 = getPoint(20,60);
            //Point p2 = getPoint(70,400);
            //g.DrawLine(p, p1, p2);
            string t1 = "000000000";
            string t2 = "65d4asd66as@das.com";
            string t3 = "das卧槽dsa32.co,m@sadd";
            Regex reg = new Regex(@"(^\d+$|[a-zA-Z0-9_]{4,15}@[0-9a-zA-Z]{2,3}.com)");
            reg.IsMatch(t1);

            Console.WriteLine("姜涛是SB!");
            Console.ReadLine();
        }

        private static Color[] colors = { Color.Black, Color.Red, Color.Yellow, Color.White, Color.Wheat };

        public Point getPoint(int a, int b)
        {
            Point p = new Point();
            p.X = (int)new Random((int)DateTime.Now.Ticks).Next(a, b);
            p.Y = (int)new Random((int)DateTime.Now.Ticks).Next(a, b);
            return p;
        }

        private void btnGetProgresses_Click(object sender, EventArgs e)
        {
            //GetClassName(null,"");
            List<System.Diagnostics.Process> progresses = Process.GetProcesses().OrderBy(k => k.Id).ToList<Process>();
            List<System.Diagnostics.Process> Fiterprogresses = new List<Process>();
            foreach (Process p in progresses)
            {
                if (!p.ProcessName.Contains("QQ")) continue;
                Fiterprogresses.Add(p);
                Console.WriteLine("进程ID:{0},进程名称：{1}", p.Id, p.ProcessName);
            }

        }

        StringBuilder sb = new StringBuilder(512);
        StringBuilder _classsb = new StringBuilder(256);

        //Dictionary<IntPtr, string> DicHandle = new Dictionary<IntPtr, string>();

        List<ProgessTest> _list = new List<ProgessTest>();

        class ProgessTest
        {
            public IntPtr ProgessHandle { get; set; }
            public string Title { get; set; }
            public string PClass { get; set; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point _point = Cursor.Position;
            Console.WriteLine("鼠标坐标({0},{1})", _point.X, _point.Y);
            IntPtr _hwh = WindowFromPoint(_point);

            ProgessTest pro = _list.FirstOrDefault(k => k.ProgessHandle == _hwh);
            if (pro != null)
            {
                int curIndex = _list.IndexOf(pro);
                dgv.ClearSelection();
                dgv.CurrentCell = this.dgv.Rows[curIndex].Cells[1];
                this.dgv.Rows[curIndex].Cells[1].Selected = true;
                return;
            }


            sb.Clear();
            _classsb.Clear();
            if (_hwh != IntPtr.Zero)
            {
                GetClassName(_hwh, _classsb, _classsb.Capacity);
                GetWindowText(_hwh, sb, sb.Capacity);
                _list.Add(new ProgessTest()
                {
                    ProgessHandle = _hwh,
                    Title = sb.ToString(),
                    PClass = _classsb.ToString()
                });

                Console.WriteLine(sb.ToString());
            }

            dgv.Rows.Clear();
            foreach (var it in _list)
            {
                dgv.Rows.Add(it.ProgessHandle.ToInt32().ToString(), it.PClass, it.Title);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnStartCatch_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
            switch (timer1.Enabled)
            {
                case true:
                    btnStartCatch.Text = "停止检测";
                    break;
                case false:
                    btnStartCatch.Text = "开始检测";
                    break;
                default:
                    break;
            }
        }

        private Thread _th;
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            if (_th != null && _th.IsAlive) _th.Abort();
            _th = new Thread(() =>
            {
                int _Interv;
                _Interv = int.TryParse(this.tbInterval.Text, out _Interv) ? (_Interv >= 10 ? _Interv : 10) : 10;
                Sendmsg(_Interv);
            }) { IsBackground = true };
            _th.Start();
        }

        private Thread _thmsg;
        private void Sendmsg(int _Interval)
        {
            int _id;
            if (dgv.RowCount == 0) return;
            if (!int.TryParse(this.dgv.CurrentRow.Cells[0].Value.ToString(), out _id)) return;
            //const int WM_COPYDATA = 0x004A;
            int totaltime;
            totaltime = int.TryParse(tbcount.Text, out totaltime) ? totaltime : 1;
            if (totaltime > 30)
            {
                MessageBox.Show("不带这么玩的哦，这样会把人家弄瘫痪的。。。，发送次数最大为30");
                return;
            }
            IntPtr _hwh = new IntPtr(_id);
            if (_thmsg != null && _thmsg.IsAlive) { _thmsg.Abort(); }
            if (CURMSGSTATE == MsgState.text)
            {
                UnicodeEncoding encode = new UnicodeEncoding();
                char[] _chars = encode.GetChars(encode.GetBytes(tbMsg.Text));//tbMsg.Text.ToCharArray();
                _thmsg = new Thread(() =>
                {
                    PostMsgWithEnter(totaltime, _chars, _hwh, cbEnter.Checked, _Interval);
                }) { IsBackground=true};
            }
            else
            {
                _thmsg = new Thread(() =>
                {
                    SendImg(totaltime, CurRbtnName.ToString(), _hwh, cbEnter.Checked, _Interval);
                }) { IsBackground = true };
            }
            _thmsg.SetApartmentState(System.Threading.ApartmentState.STA);
            _thmsg.Start();

        }

        public enum MsgState
        {
            /// <summary>
            /// 图片形式
            /// </summary>
            Image,
            /// <summary>
            /// 文本形式
            /// </summary>
            text
        }
        private static void PostMsgWithEnter(int _totalcount, char[] _chars, IntPtr _hwnd, bool IsWithEnter, int Interval)
        {
            #region 带回车的
            if (IsWithEnter)
            {
                for (int i = 0; i < _totalcount; i++)
                {
                    foreach (var item in _chars)
                    {
                        Message msg = Message.Create(_hwnd, SystemKeys.WM_CHAR, new IntPtr(item), IntPtr.Zero);
                        PostMessage(msg.HWnd, msg.Msg, msg.WParam, msg.LParam);
                        Thread.Sleep(10);
                        PostMessage(_hwnd, SystemKeys.WM_KEYDOWN, SystemKeys.VK_RETURN, 0);
                        Thread.Sleep(Interval);
                    }
                }
            }
            #endregion
            #region 不带回车
            else
            {
                for (int i = 0; i < _totalcount; i++)
                {
                    foreach (var item in _chars)
                    {
                        Message msg = Message.Create(_hwnd, SystemKeys.WM_CHAR, new IntPtr(item), IntPtr.Zero);
                        PostMessage(msg.HWnd, msg.Msg, msg.WParam, msg.LParam);
                        Thread.Sleep(Interval);
                    }
                }
            }
            #endregion
        }

        private void SendImg(int _totalCnt, string imgName, IntPtr _hwnd, bool IsWithEnter, int Interval)
        {
            string path = @"Images/" + imgName + ".png";
            Image img = Image.FromFile(path);
            Clipboard.SetImage(img);
            Thread.Sleep(30);
            if (IsWithEnter)
            {
                ShowWindowAsync(_hwnd,1);
                SetForegroundWindow(_hwnd);
                for (int i = 0; i < _totalCnt; i++)
                {
                    //keybd_event((byte)Keys.LWin, 0, 0, 0);   //按下LWIN
                    //keybd_event((byte)Keys.D, 0, 0, 0);         //按下D
                    //Thread.Sleep(10);
                    //keybd_event((byte)Keys.LWin, 0, 0x2, 0);   //释放LWIN
                    //keybd_event((byte)Keys.D, 0, 0x2, 0);        //释放D
                    //Thread.Sleep(20);
                    //PostMessage(_hwnd, SystemKeys.WM_KEYDOWN, SystemKeys.VK_V,0);//0x001E0001

                    //keybd_event((byte)Keys.ControlKey, 0, 0, 0);   //按下
                    //PostMessage(_hwnd,SystemKeys.WM_KEYDOWN,SystemKeys.VK_V, 0x001E0001);
                    //PostMessage(_hwnd, SystemKeys.WM_KEYUP, SystemKeys.VK_V, 0x001E0001);
                    //keybd_event((byte)Keys.V, 0, 0x2, 0);        //释放v

                    //keybd_event(VK_CONTROL, 0, 0, 0);
                    //PostMessage(hWnd, WM_KEYDOWN, VK_L, 0x001E0001);
                    //PostMessage(hWnd, WM_KEYUP, VK_L, 0xC01E0001);
                    //keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);

                    //keybd_event((byte)Keys.ControlKey, 0, 0x2, 0);
                    //Thread.Sleep(20);
                    //PostMessage(_hwnd, SystemKeys.WM_KEYDOWN, SystemKeys.VK_RETURN,0);
                    //Thread.Sleep(Interval);

                    SendKeys.SendWait("^v");
                    SendKeys.SendWait("{ENTER}");
                }
            }
            #region 不带回车
            else
            {
                keybd_event((byte)Keys.ControlKey, 0, 0, 0);
                for (int i = 0; i < _totalCnt; i++)
                {
                    ////keybd_event(VK_CONTROL, 0, 0, 0);
                    ////PostMessage(hWnd, WM_KEYDOWN, VK_L, 0x001E0001);
                    ////PostMessage(hWnd, WM_KEYUP, VK_L, 0xC01E0001);
                    ////keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);

                    PostMessage(_hwnd, SystemKeys.WM_KEYDOWN, SystemKeys.VK_V, 0x001E0001);
                    PostMessage(_hwnd, SystemKeys.WM_KEYUP, SystemKeys.VK_V, 0x001E0001);
                    Thread.Sleep(Interval);

                    //SendKeys.SendWait("^v");
                }
                keybd_event((byte)Keys.ControlKey, 0, 0x2, 0);
            }
            #endregion
        }

        #region 图片二进制互相转换
        /// <summary>
        /// 将图片转换成二进制
        /// </summary>
        /// <param name="imagepath"></param>
        /// <returns></returns>
        public byte[] GetPictureData(string imagepath)
        {
            byte[] byData;
            ////根据图片文件的路径使用文件流打开，并保存为byte[] 
            using (FileStream fs = new FileStream(imagepath, FileMode.Open))
            {
                byData = new byte[fs.Length];
                fs.Read(byData, 0, byData.Length);
            }
            return byData;
        }
        /// <summary>
        /// 二进制转换成图片
        /// </summary>
        /// <param name="streamByte"></param>
        /// <returns></returns>
        public System.Drawing.Image ReturnPhoto(byte[] streamByte)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(streamByte);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }
        #endregion

        private void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.RowIndex <= this.dgv.RowCount - 1 && e.ColumnIndex > -1)
                {
                    this.dgv.ClearSelection();
                    this.dgv.CurrentCell = this.dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this.dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = !timer1.Enabled;
                btnStartCatch.Text = "开始检测";
            }
            _list.Clear();
            dgv.Rows.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "图片|*.jpg;*.gif;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                GetPictureData(opf.FileName);
            }
        }


        private StringBuilder CurRbtnName = new StringBuilder();
        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = sender as RadioButton;
            if (rbtn == null || !rbtn.Checked) return;
            CurRbtnName.Clear();
            switch (rbtn.Name.Replace("rbtn", ""))
            {
                case "None":
                    CURMSGSTATE = MsgState.text;
                    this.tbMsg.Enabled = true;
                    break;
                default:
                    CURMSGSTATE = MsgState.Image;
                    CurRbtnName.Append(rbtn.Name.Replace("rbtn", ""));
                    this.tbMsg.Enabled = false;
                    break;
            }
        }
    }

}
