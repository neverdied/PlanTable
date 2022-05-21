using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using mySQLtest;
using System.Timers;
using System.Text.RegularExpressions;
using Sunny.UI;
using System.Configuration;


namespace PlanTables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public static bool local = true;
        sqlhelp sqlTemp = new sqlhelp();
        string strSql;
        DataTable dtTmp;
        public static string tableName = "本地模式";
        private void Form1_Load(object sender, EventArgs e)
        {
            /**
             * 锁定窗口打开位置
             **/

            Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width - this.Size.Width - 5;
            Top = 5;
            //comboBox_modeChoose.SelectedIndex = 0;
            /**
             * 开机自启
             **/
            StartUp("1");
            ModifyLocal();
            //EDIR(@"C:\待办事项\config.ini");
            //List<string> co = READFILE(@"C:\待办事项\config.ini");
            string localModel = ConfigurationManager.AppSettings["localModel"];
            
                if (localModel == "0")
                {
                    SwitchMode.Active = false;
                }
            
            ShowData();
        }
        private void buttonAddPlan_Click(object sender, EventArgs e)
        {
            FormAddThing form = new FormAddThing(tableName, ref local);
            form.ShowDialog();

            if (form.strContent == "")
            {
                UIMessageTip.ShowWarning("输入为空。");
            }
            else
            {
                ShowData();

            }
        }
        private void listViewNotDoneToday_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < listViewNotDoneToday.Items.Count; i++)
            {
                if (listViewNotDoneToday.Items[i].Checked == true)
                {



                    //AddThings(listViewDoneToday, listViewNotDoneToday.Items[i].SubItems[1].Text, listViewNotDoneToday.Items[i].SubItems[0].T
                    if (local == false)
                    {
                        strSql = "update [PLAN].[dbo].[" + tableName + "] set ENDTIME='" + DateTime.Now.ToShortDateString() + "' where id='" + listViewNotDoneToday.Items[i].SubItems[1].Text + "'";
                        dtTmp = sqlTemp.ExecuteQuery(strSql);
                        strSql = "select * from [PLAN].[dbo].[" + tableName + "] where id='" + listViewNotDoneToday.Items[i].SubItems[1].Text + "'";
                        dtTmp = sqlTemp.ExecuteQuery(strSql);
                        if (dtTmp.Rows[0]["GRADE"].ToString() == "2")
                        {
                            strSql = "update [PLAN].[dbo].[" + dtTmp.Rows[0]["OPERATOR"] + "] set ENDTIME='" + DateTime.Now.ToShortDateString() + "' where id='" + dtTmp.Rows[0]["LINKID"] + "'";
                            dtTmp = sqlTemp.ExecuteQuery(strSql);
                        }
                    }
                    else
                    {
                        List<string> lines = new List<string>(File.ReadAllLines(@"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "待办.ini"));//先读取到内存变量
                        lines.RemoveAt(i);//指定删除的行
                        File.WriteAllLines(@"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "待办.ini", lines.ToArray());//在写回硬盤
                        File.AppendAllText(@"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "已办.ini", listViewNotDoneToday.Items[i].SubItems[0].Text + "\r\n");
                    }
                    ShowData();
                    break;
                }
            }

        }
        private void login_Click(object sender, EventArgs e)
        {
            SwitchMode.Active = true;
            //comboBox_modeChoose.SelectedIndex = 0;
            FormLoginAndReg form = new FormLoginAndReg();
            form.ShowDialog();
            if (form.tableNames != "本地模式")
            {
                tableName = form.tableNames;
                //user.Text = form.tableNames;
                Avatar.Text = form.tableNames;
                ModifyLocal();
                ShowData();
            }
        }



        private void ModifyLocal()
        {

            if (local == true)
            {
                local = false;
                try
                {
                    EDIR(@"C:\待办事项\pass.ini");
                    List<string> l = READFILE(@"C:\待办事项\pass.ini");
                    string userName = l[0];
                    string password = l[1];
                    strSql = "select * from [PLAN].[dbo].[LOGIN] where (USERNAME='" + userName + "' and PASSWORD='" + password + "')";
                    dtTmp = sqlTemp.ExecuteQuery(strSql);
                    if (dtTmp != null)
                    {
                        if (dtTmp.Rows.Count != 1)
                        {
                            UIMessageTip.ShowWarning("账号密码不存在");
                        }
                        else
                        {
                            tableName = userName;
                            //user.Text = userName;
                            Avatar.Text = tableName;
                            ShowData();

                        }
                    }
                    else
                    {
                        local = true;
                    }
                }
                catch (Exception ex)
                {
                    local = true;
                    Console.WriteLine(ex.Message);
                    //ShowData();
                }
            }
            else if (local == false)
            {
                strSql = "select * from [PLAN].[dbo].[" + tableName + "] where (STARTTIME='" + DateTime.Now.ToShortDateString() + "' and ENDTIME is NULL)";
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                try
                {
                    if (dtTmp != null)
                    {
                        if (dtTmp.Rows.Count != listViewNotDoneToday.Items.Count)
                        {
                            ShowData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void EDIR(string filePath)
        {
            //spath：文件夹路径名
            string dirPath = filePath.Substring(0, filePath.LastIndexOf('\\'));
            if (Directory.Exists(dirPath))
            {
                // filePath 文件路径名

                if (!File.Exists(filePath))
                {
                    //MessageBox.Show(filePath + "  not exists!");
                    FileStream fs = File.Create(filePath);//创建文件
                    fs.Close();
                    string fileName = Path.GetFileName(filePath);
                    if (fileName == DateTime.Now.ToLongDateString().ToString() + "待办.ini")
                    {
                        int dis = 1;
                        string path = @"C:\待办事项\" + DateTime.Now.AddDays(-dis).ToLongDateString().ToString() + "待办.ini";
                        while (!File.Exists(path))
                        {
                            dis++;
                            path = @"C:\待办事项\" + DateTime.Now.AddDays(-dis).ToLongDateString().ToString() + "待办.ini";
                        }
                        List<string> l = READFILE(path);
                        for (int i = 0; i < l.Count; i++)
                        {
                            string[] strArray = Regex.Split(l[i], "已拖延", RegexOptions.IgnoreCase);
                            if (strArray.Length == 1)
                            {
                                File.AppendAllText(@"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "待办.ini", l[i] + "已拖延"+dis+"天\r\n");
                            }
                            else if (strArray.Length == 2)
                            {
                                char[] chArray = strArray[1].ToCharArray();
                                int delay = chArray[0] + dis - '0';
                                File.AppendAllText(@"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "待办.ini", strArray[0] + "已拖延" + delay + "天\r\n");

                            }
                        }
                    }
                    return;
                }
                else
                {
                    //MessageBox.Show(filePath + "  exists!");
                    //执行读写操作
                }
            }
            else
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);
                directoryInfo.Create();
            }
        }
        private List<string> READFILE(string filePath)
        {
            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);//创建文件
                fs.Close();
            }

            List<string> l = new List<string>();
            StreamReader sr = File.OpenText(filePath);
            string nextLine;
            while ((nextLine = sr.ReadLine()) != null)
            {
                //Console.WriteLine(nextLine);
                l.Add(nextLine);
            }
            sr.Close();
            return l;
        }
        private void SHOWLIST()
        {
            SHOWFILE(listViewNotDoneToday, @"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "待办.ini");
            SHOWFILE(listViewDoneToday, @"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "已办.ini");
            tableName = "本地模式";
            SwitchMode.Active = false;
            // user.Text = tableName;
            Avatar.Text = tableName;

        }
        private void SHOWFILE(ListView lv, string filePath)
        {
            EDIR(filePath);
            lv.Items.Clear();
            List<string> l = READFILE(filePath);
            for (int i = 0; i < l.Count; i++)
            {
                AddThings(lv, "-1", l[i]);
            }
        }
        private void AddThings(ListView lv, string id, string content)
        {
            ListViewItem lvi = new ListViewItem(content);
            lvi.SubItems.Add(id);
            lv.Items.Add(lvi);
        }
        private void StartUp(string flag)
        {
            string path = Application.StartupPath;
            string keyName = path.Substring(path.LastIndexOf("\\") + 1);
            Microsoft.Win32.RegistryKey Rkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (flag.Equals("1"))
            {
                if (Rkey == null)
                {
                    Rkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                }
                Rkey.SetValue(keyName, path + @"\PlanTables.exe");
            }
            else
            {
                if (Rkey != null)
                {
                    Rkey.DeleteValue(keyName, false);
                }
            }
        }
        private void ShowData()
        {
            if (local == false)
            {

                #region 加载今日未完成
                /**
         * 加载今日的任务
         * **/

                listViewNotDoneToday.Items.Clear();
                strSql = "select * from [PLAN].[dbo].[" + tableName + "] where (STARTTIME='" + DateTime.Now.ToShortDateString() + "' and ENDTIME is NULL)";
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                if (dtTmp != null)
                {
                    for (int i = 0; i < dtTmp.Rows.Count; i++)
                    {

                        AddThings(listViewNotDoneToday, dtTmp.Rows[i]["ID"].ToString(), dtTmp.Rows[i]["PLANCONTENT"].ToString());
                        if (dtTmp.Rows[i]["GRADE"].ToString() == "2")
                        {
                            listViewNotDoneToday.Items[i].ForeColor = System.Drawing.Color.Orange;
                        }
                        if (dtTmp.Rows[i]["GRADE"].ToString() == "3")
                        {
                            listViewNotDoneToday.Items[i].ForeColor = System.Drawing.Color.Green;
                        }
                    }
                    /**
                     * 加载历史遗留任务
                     * **/
                    strSql = "select * from [PLAN].[dbo].[" + tableName + "] where (STARTTIME<'" + DateTime.Now.ToShortDateString() + "' and ENDTIME IS NULL)";
                    dtTmp = sqlTemp.ExecuteQuery(strSql);
                    for (int i = 0; i < dtTmp.Rows.Count; i++)
                    {
                        TimeSpan delayTime = DateTime.Parse(DateTime.Now.ToShortDateString()) - DateTime.Parse(dtTmp.Rows[i]["STARTTIME"].ToString());
                        int days = delayTime.Days;
                        string history = dtTmp.Rows[i]["PLANCONTENT"].ToString() + ",已拖延" + days + "天";
                        AddThings(listViewNotDoneToday, dtTmp.Rows[i]["ID"].ToString(), history);
                    }


                    #endregion
                    #region 加载今日已完成
                    listViewDoneToday.Items.Clear();
                    strSql = "select * from [PLAN].[dbo].[" + tableName + "] where (ENDTIME='" + DateTime.Now.ToShortDateString() + "')";
                    dtTmp = sqlTemp.ExecuteQuery(strSql);
                    for (int i = 0; i < dtTmp.Rows.Count; i++)
                    {
                        AddThings(listViewDoneToday, dtTmp.Rows[i]["ID"].ToString(), dtTmp.Rows[i]["PLANCONTENT"].ToString());
                    }
                    #endregion
                    Avatar.Text = tableName;
                }

                else
                {
                    
                    SHOWLIST();

                }
            }


            else
            {
                SHOWLIST();


            }

        }

        private void user_Click(object sender, EventArgs e)
        {
            Console.WriteLine("user  click");
            ModifyLocal();
            SwitchMode.Active = true;

        }

        //private void comboBox_modeChoose_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox_modeChoose.SelectedIndex == 1)
        //    {
        //        local = true;
        //        timer1.Stop();
        //        ShowData();
        //    }
        //    else
        //    {
        //        local = false;
        //        timer1.Start();
        //        ShowData();
        //    }
        //}

        private void SwitchMode_ValueChanged(object sender, bool value)
        {
            //if (comboBox_modeChoose.SelectedIndex == 1)
            if (SwitchMode.Active == false)
            {
                local = true;
                tableName = "本地模式";
                //EDIR(@"C:\待办事项\config.ini");
                //File.WriteAllText(@"C:\待办事项\config.ini", "local=0");
                //List<string> co = READFILE(@"C:\待办事项\config.ini");
                //ConfigurationManager.AppSettings["localModel"] = "0";
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["localModel"].Value = "0";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                timer1.Stop();
                ShowData();
            }
            else
            {
                //local = false;
                //EDIR(@"C:\待办事项\config.ini");
                //File.WriteAllText(@"C:\待办事项\config.ini", "local=1");
                //ConfigurationManager.AppSettings["localModel"] = "1";
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["localModel"].Value = "1";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                ModifyLocal();
                ShowData();
            }
        }
    }
}


