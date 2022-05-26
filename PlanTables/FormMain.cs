using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using mySQLtest;
using System.Text.RegularExpressions;
using Sunny.UI;
using System.Configuration;


namespace PlanTables
{
    public partial class FormMain : Form
    {
        /**
         * 主窗口的构造函数，点击应用图标时触发
         * **/
        public FormMain()
        {
            //初始化
            InitializeComponent();

        }
        //设置本地模式为真
        public static bool local = true;
        //创建数据库操作的对象，后面要用
        sqlhelp sqlTemp = new sqlhelp();
        //创建一个字符串保存数据库操作
        string strSql;
        //创建一个数据表用来保存数据库操作的结果
        DataTable dtTmp;
        //默认图标显示为“本地模式”
        public static string UIuserName = "本地模式";


        /**
         * 加载窗口时执行下面的方法
         * **/
        private void Form1_Load(object sender, EventArgs e)
        {
            //锁定窗口位置
            //设置为桌面最右边
            Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width - this.Size.Width - 5;
            //设置为桌面最上边
            Top = 5;
            //设置为开机自启
            StartUp("1");
            //加载配置文件中的模式，如果为网络模式则读取pass文件登录（本地模式或网络模式）
            ModifyLocal();
            //将实际模式匹配上窗口UI中的模式选择器
            matchSwitch();
            //展示数据
            ShowData();
        }

        /**
         * 将实际模式匹配上窗口UI中的模式选择器
         * **/
        private void matchSwitch()
        {
            //定义一个字符串保存配置文件中的本地模式字段
            string localModel = ConfigurationManager.AppSettings["localModel"];
            //如果配置文件中本地模式字段为0
            if (localModel == "0")
            {
                //则UI界面中模式选择为false
                SwitchMode.Active = false;
                local = true;
            }
            else
            {
                local = false;
            }
        }

        /**
         * 点击增加计划按钮执行下列方法
         * **/
        private void buttonAddPlan_Click(object sender, EventArgs e)
        {
            //创建一个增加任务的窗口对象并将UIuserName和local传过去，因为在增加任务的窗口中有数据库操作，所有有可能会发现无法连接
            //从而改变为本地模式，所以local字段时共同可改的
            FormAddThing form = new FormAddThing(UIuserName, ref local);
            //展示创建的增加任务窗口对象
            form.ShowDialog();
            //如果增加任务床口传过来的任务内容为空
            if (form.strContent == "")
            {
                //则提示输入为空
                UIMessageTip.ShowWarning("输入为空。");
            }
            //否则
            else
            {
                //刷新数据
                ShowData();
            }
        }

        /**
         * 当今日未完成列表中的项被勾选时，执行下列代码
         * **/
        private void listViewNotDoneToday_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //遍历今日未完成的每一项
            for (int i = 0; i < listViewNotDoneToday.Items.Count; i++)
            {
                //如果被便利的项被选中
                if (listViewNotDoneToday.Items[i].Checked == true)
                {
                    //如果本地模式为假（网络模式）
                    if (local == false)
                    {
                        //用字符串保存sql语句--修改被选中的项的结束时间为现在
                        strSql = "update [PLAN].[dbo].[" + UIuserName + "] set ENDTIME='" + DateTime.Now.ToShortDateString() + "' where id='" + listViewNotDoneToday.Items[i].SubItems[1].Text + "'";
                        //执行sql语句
                        dtTmp = sqlTemp.ExecuteQuery(strSql);
                        //用字符串保存sql语句--查询被选择的id--为了实现---如果被勾选的时上级布置的任务时，下级完成任务，在上级的列表中对应项也应该删除
                        strSql = "select * from [PLAN].[dbo].[" + UIuserName + "] where id='" + listViewNotDoneToday.Items[i].SubItems[1].Text + "'";
                        //执行sql语句
                        dtTmp = sqlTemp.ExecuteQuery(strSql);
                        //如果被选择的列的grade=2（是上级布置的任务）
                        if (dtTmp.Rows[0]["GRADE"].ToString() == "2")
                        {
                            //用字符串保存sql语句--更新上级对应LINKid中的项，修改id的结束时间为现在
                            strSql = "update [PLAN].[dbo].[" + dtTmp.Rows[0]["OPERATOR"] + "] set ENDTIME='" + DateTime.Now.ToShortDateString() + "' where id='" + dtTmp.Rows[0]["LINKID"] + "'";
                            //执行sql语句
                            dtTmp = sqlTemp.ExecuteQuery(strSql);
                        }
                    }
                    //如果本地模式为真（本地模式）
                    else
                    {
                        ////先读取到今日待办文件中的所有文件到内存列表
                        List<string> lines = new List<string>(File.ReadAllLines(@"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "待办.ini"));
                        //指定删除内存列表中的勾选行
                        lines.RemoveAt(i);
                        //再将内存列表重新写入到今日待办文件
                        File.WriteAllLines(@"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "待办.ini", lines.ToArray());
                        //将勾选行加入到今日已办文件
                        File.AppendAllText(@"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "已办.ini", listViewNotDoneToday.Items[i].SubItems[0].Text + "\r\n");
                    }
                    //遍历到列表中的勾选项刷新数据
                    ShowData();
                    //跳出循环（应为一旦勾选马上执行此方法所以不存在有两个勾选的情况）
                    break;
                }
            }
        }

        /**
         * 登录按钮点击执行下列方法
         * **/
        private void login_Click(object sender, EventArgs e)
        {
            //将UI中的选择模式（本地模式；网络模式）选为真（网络模式）
            SwitchMode.Active = true;
            //创建登录窗口对象
            FormLoginAndReg form = new FormLoginAndReg();
            //展示登录窗口对象
            form.ShowDialog();
            //如果登录窗口传递过来的用户名不是默认用户名
            if (form.UIuserNames != "本地模式")
            {
                //将登录界面的用户名赋值给主界面
                UIuserName = form.UIuserNames;
                //主界面头像UI文字换为主界面
                Avatar.Text = form.UIuserNames;

                //修改登陆数据
                ModifyLocal();
                //刷新数据
                ShowData();
            }
        }



        /**
         * 修改模式，如果本地模式为真，试试有没有网，有网改成网络模式。本地模式为假，查询未完成任务数据不一致刷新列表
         * **/
        private void ModifyLocal()
        {
            //如果本地为真（本地模式）
            if (local == true)
            {
                //将本地设置为假（网络模式）
                local = false;

                
                    //获取pass.ini第一行为用户名
                    string userName = ConfigurationManager.AppSettings["userName"];
                    //获取pass.ini第二行为密码
                    string password = ConfigurationManager.AppSettings["passWord"];
                    //用字符串保存sql语句--验证账号密码是否正确
                    strSql = "select * from [PLAN].[dbo].[LOGIN] where (USERNAME='" + userName + "' and PASSWORD='" + password + "')";
                    //执行sql语句
                    dtTmp = sqlTemp.ExecuteQuery(strSql);
                    //如果执行结果不为空，及有网络
                    if (dtTmp != null)
                    {
                        //如果执行sql语句的结果行数不为1
                        if (dtTmp.Rows.Count == 1)
                        {
                            //UI上的用户名为登陆时输入的用户名
                            UIuserName = userName;
                            //将UI上的用户名渲染再头像上
                            Avatar.Text = UIuserName;
                            //将UI选择模式改为网络模式
                            SwitchMode.Active = true;
                            //刷新数据
                            ShowData();
                        }
                    }
                    //如果执行结果为空（没有网络）
                    else
                    {
                        //提示没有网络
                        UIMessageTip.ShowWarning("没有网络");
                    }

                
            }
            //如果本地模式为假（网络模式）
            else if (local == false)
            {
                //用字符串保存sql语句--查询没有结束时间的数据
                strSql = "select * from [PLAN].[dbo].[" + UIuserName + "] where (STARTTIME='" + DateTime.Now.ToShortDateString() + "' and ENDTIME is NULL)";
                //执行sql语句
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                //如果执行结果不为空（有网络）
                if (dtTmp != null)
                {
                    //如果服务器数据库数据与今日未完成列表数据数目不一致
                    if (dtTmp.Rows.Count != listViewNotDoneToday.Items.Count)
                    {
                        //刷新数据
                        ShowData();
                    }
                }
                //如果执行结果为空（没有网络）
                else
                {
                    //提示没有网络
                    UIMessageTip.ShowWarning("没有网络");
                }
            }
        }

        /**
         * 判断文件夹存不存在并创建文件夹，并将待办文件夹创建好，因为待办用到了readfile所以无法放在readfile中
         * **/
        private void EDIR(string filePath)
        {
            //dirpath：文件夹路径名，获取文件夹的路径
            string dirPath = filePath.Substring(0, filePath.LastIndexOf('\\'));
            //如果文件夹存在
            if (Directory.Exists(dirPath))
            {
                // filePath 文件路径名，如果文件不存在
                if (!File.Exists(filePath))
                {

                    //创建文件
                    FileStream fs = File.Create(filePath);
                    //关闭文件流
                    fs.Close();
                    //获取文件名
                    string fileName = Path.GetFileName(filePath);
                    //如果文件名是今日待办，进入待办处理
                    if (fileName == DateTime.Now.ToLongDateString().ToString() + "待办.ini")
                    {
                        //设置没开软件时间实际默认为1
                        int dis = 1;
                        //获取昨天的待办路径
                        string path = @"C:\待办事项\" + DateTime.Now.AddDays(-dis).ToLongDateString().ToString() + "待办.ini";
                        //如果历史待办路径不存在且没开软件时间小于30天进入循环
                        while (!File.Exists(path) && dis < 30)
                        {
                            //没开软件时间+1
                            dis++;
                            //修改历史路径（然后再通过循环判断路径存不存在）
                            path = @"C:\待办事项\" + DateTime.Now.AddDays(-dis).ToLongDateString().ToString() + "待办.ini";

                        }
                        //读取历史路径的所有文件到内存列表
                        List<string> l = READFILE(path);
                        //遍历历史路径所有文件
                        for (int i = 0; i < l.Count; i++)
                        {
                            //将每行数据通过“已拖延”切割
                            string[] strArray = Regex.Split(l[i], "已拖延", RegexOptions.IgnoreCase);
                            //设置拖延时间等于文件时间差
                            int delay = dis;
                            //如果数据中和有已拖延
                            if (strArray.Length == 2)
                            {
                                //获取已拖延后的字符数组
                                char[] chArray = strArray[1].ToCharArray();
                                //利用拖延后第一个字符及这个文件距离现在的时间算出拖延时间
                                delay = chArray[0] + dis - '0';

                            }
                            //增加数据到今天的待办并加上拖延的时间到已拖延后面
                            File.AppendAllText(@"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "待办.ini", strArray[0] + "已拖延" + delay + "天\r\n");

                        }


                    }

                }

            }
            //如果文件夹不存在
            else
            {
                //创建文件夹对象
                DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);
                //创建文件夹
                directoryInfo.Create();
            }
        }

        /**
         * 读取路径文件为列表
         * **/
        private List<string> READFILE(string filePath)
        {
            //如果文件路径的文件不存在
            if (!File.Exists(filePath))
            {
                //创建文件
                FileStream fs = File.Create(filePath);
                //关闭文件流
                fs.Close();
            }
            //创建一个字符列表对象
            List<string> l = new List<string>();
            //创建一个文件流
            StreamReader sr = File.OpenText(filePath);
            //定义下一行
            string nextLine;
            //下一行不为空是一直遍历
            while ((nextLine = sr.ReadLine()) != null)
            {
                //将下一行增加到字符列表对象
                l.Add(nextLine);
            }
            //关闭文件流
            sr.Close();
            //返回字符列表
            return l;
        }


        /**
         * 展示本地数据
         * **/
        private void SHOWLIST()
        {

            //展示待办文件的所有数据
            SHOWFILE(listViewNotDoneToday, @"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "待办.ini");
            //展示已办文件的所有数据
            SHOWFILE(listViewDoneToday, @"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "已办.ini");
            //设置UI用户为本地模式
            UIuserName = "本地模式";
            //模式选择为本地模式
            SwitchMode.Active = false;
            //头像文字渲染为本地模式
            Avatar.Text = UIuserName;
        }

        /**
         * 展示文件数据
         * **/
        private void SHOWFILE(ListView lv, string filePath)
        {
            //判断文件存不存在
            EDIR(filePath);
            //清楚列表数据
            lv.Items.Clear();
            //将文件路径中的数据读取到内存列表中
            List<string> l = READFILE(filePath);
            //遍历文件路径中的数据
            for (int i = 0; i < l.Count; i++)
            {
                //将文件路径中的数据加入到UI列表中，id为-1
                AddThings(lv, "-1", l[i]);
            }
        }

        /**
         * 增加数据到lv的UI列表中
         * **/
        private void AddThings(ListView lv, string id, string content)
        {
            //创建列表子项，并加入content
            ListViewItem lvi = new ListViewItem(content);
            //往列表子项中加入id
            lvi.SubItems.Add(id);
            //将列表子项加入lv列表
            lv.Items.Add(lvi);
        }


        /**
         * 开机自启设置
         * **/
        private void StartUp(string flag)
        {
            //获取应用的路径
            string path = Application.StartupPath;
            //获取应用文件名
            string keyName = path.Substring(path.LastIndexOf("\\") + 1);
            //打开注册表
            Microsoft.Win32.RegistryKey Rkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            //如果输入的是1，则将开机自启写入注册表
            if (flag.Equals("1"))
            {
                //如果打开注册表并未进行操作
                if (Rkey == null)
                {
                    //注册表进入写入状态
                    Rkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                }
                //开机自启写入注册表
                Rkey.SetValue(keyName, path + @"\PlanTables.exe");
            }
            //如果输入的是0，删除开机自启
            else
            {
                //如果打开注册表发现已有开机自启
                if (Rkey != null)
                {
                    //删除开机自启
                    Rkey.DeleteValue(keyName, false);
                }
            }
        }

        /**
         * 展示任务数据再UI上
         * **/
        private void ShowData()
        {
            //如果是网络模式
            if (local == false)
            {
                //清除今日未完成列表中的项
                listViewNotDoneToday.Items.Clear();
                //在数据库中获取今日未完成的数据，将sql语句写入字符串
                strSql = "select * from [PLAN].[dbo].[" + UIuserName + "] where (STARTTIME='" + DateTime.Now.ToShortDateString() + "' and ENDTIME is NULL)";
                //执行sql语句
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                //如果有网络
                if (dtTmp != null)
                {
                    #region 记载今日已完成
                    //将获取历史数据的sql语句
                    strSql = "select * from [PLAN].[dbo].[" + UIuserName + "] where ( ENDTIME IS NULL)";
                    dtTmp = sqlTemp.ExecuteQuery(strSql);
                    for (int i = 0; i < dtTmp.Rows.Count; i++)
                    {
                        TimeSpan delayTime = DateTime.Parse(DateTime.Now.ToShortDateString()) - DateTime.Parse(dtTmp.Rows[i]["STARTTIME"].ToString());
                        int days = delayTime.Days;
                        string history = dtTmp.Rows[i]["PLANCONTENT"].ToString();
                        if (days != 0)
                        {
                            history = dtTmp.Rows[i]["PLANCONTENT"].ToString() + ",已拖延" + days + "天";
                        }
                        AddThings(listViewNotDoneToday, dtTmp.Rows[i]["ID"].ToString(), history);
                        if (dtTmp.Rows[i]["GRADE"].ToString() == "2")
                        {
                            //今日未完成字体颜色就是黄色
                            listViewNotDoneToday.Items[i].ForeColor = System.Drawing.Color.Orange;
                        }
                        //如果这行数据等级等于3
                        if (dtTmp.Rows[i]["GRADE"].ToString() == "3")
                        {
                            //字体颜色就是绿色
                            listViewNotDoneToday.Items[i].ForeColor = System.Drawing.Color.Green;
                        }
                    }
                    #endregion


                    #region 加载今日已完成
                    //清除今日已完成列表
                    listViewDoneToday.Items.Clear();
                    //获取今日已完成的sql语句卸载字符串上
                    strSql = "select * from [PLAN].[dbo].[" + UIuserName + "] where (ENDTIME='" + DateTime.Now.ToShortDateString() + "')";
                    //执行这个sql语句
                    dtTmp = sqlTemp.ExecuteQuery(strSql);
                    //遍历执行结果
                    for (int i = 0; i < dtTmp.Rows.Count; i++)
                    {
                        //将执行结果每一行写入ui已完成列表
                        AddThings(listViewDoneToday, dtTmp.Rows[i]["ID"].ToString(), dtTmp.Rows[i]["PLANCONTENT"].ToString());
                    }
                    #endregion
                    //头像的文本设置为获取的用户名
                    Avatar.Text = UIuserName;
                }
                //如果没有网
                else
                {
                    //执行本地展示
                    SHOWLIST();

                }
            }

            //如果是本地模式
            else
            {
                //执行本地展示
                SHOWLIST();
            }

        }

        private void user_Click(object sender, EventArgs e)
        {
            Console.WriteLine("user  click");
            ModifyLocal();
            SwitchMode.Active = true;

        }

        /**
         * 点击改变模式执行下列代码
         * **/
        private void SwitchMode_ValueChanged(object sender, bool value)
        {
            //如果模式选择是false，本地模式
            if (SwitchMode.Active == false)
            {
                //修改local改为真
                local = true;
                //修改用户名改为本地模式
                UIuserName = "本地模式";
                //获取配置管理器，修改配置文件
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //修改配置文件中的localModel改为0
                config.AppSettings.Settings["localModel"].Value = "0";
                //保存被指文件
                config.Save(ConfigurationSaveMode.Modified);
                //刷新配置文件
                ConfigurationManager.RefreshSection("appSettings");
                //自动更新数据的计时器关闭
                timer1.Stop();
                //展示数据
                ShowData();
            }
            //如果模式宣布则的是true，网络模式
            else
            {
                //获取配置管理器修改配置文件
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //配置文件中的localModel改为1
                config.AppSettings.Settings["localModel"].Value = "1";
                //保存修改后的配置文件
                config.Save(ConfigurationSaveMode.Modified);
                //刷新配置文件
                ConfigurationManager.RefreshSection("appSettings");
                //修改模式
                ModifyLocal();
                //展示疏忽
                ShowData();
            }
        }
    }
}


