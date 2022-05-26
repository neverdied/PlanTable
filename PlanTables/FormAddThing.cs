using System;
using System.Data;
using System.Windows.Forms;
using mySQLtest;
using System.IO;
using Sunny.UI;

namespace PlanTables
{
    public partial class FormAddThing : Form
    {

        /**加载增加任务窗口时执行下面的方法**/
        private void FormAddThing_Load(object sender, EventArgs e)
        {
            //定义一个sql语句去获取所有添加下属请求
            strSql = "select * from [PLAN].[dbo].[" + UIuserName + "Employer] where SIGN=0";
            //执行这个sql语句
            dtTmp = sqlTemp.ExecuteQuery(strSql);
            //如果有网络
            if (dtTmp != null)
            {
                //如果有任意下属
                if (dtTmp.Rows.Count != 0)
                {
                    //注意按钮变为红色
                    uiButton_notice.SetStyle(UIStyle.Red);
                    //注意按钮显示文本有n个添加为下属的消息
                    uiButton_notice.Text = "有" + dtTmp.Rows.Count + "个添加您为下属的消息";

                }
            }

        }


        /**构造函数，在主窗口中调用**/
        public FormAddThing(string tN, ref bool l)
        {
            //用户名改为形参的参数
            UIuserName = tN;
            //设置未网络模式
            local = l;
            //初始化组件，调用加载窗口的方法
            InitializeComponent();
            //将用户名添加到下拉框
            comboBoxUIuserName.Items.Add(UIuserName);
            //定义一个获取所有下属的sql字符串
            string sql = "select * from [PLAN].[dbo].[" + UIuserName + "Employee]";
            //执行这个sql语句
            dtTmp = sqlTemp.ExecuteQuery(sql);
            //如果有网络
            if (dtTmp != null)
            {
                //遍历获得的下属
                for (int i = 0; i < dtTmp.Rows.Count; i++)
                {
                    //将获得的下属添加到下拉框里面
                    comboBoxUIuserName.Items.Add(dtTmp.Rows[i]["USERNAME"].ToString());
                }
            }

            //默认下拉框使用第一个用户（即操作用户）
            comboBoxUIuserName.SelectedIndex = 0;

        }


        //定义一个静态的是否本地模式的变量
        public static bool local;
        //定义一个用户名的变量
        String UIuserName;
        //创建一个sqlTemp的对象，在这个对象上执行sql语句
        sqlhelp sqlTemp = new sqlhelp();
        //定义一个存储sql的字符串
        string strSql;
        //定义一个内容的字符串
        public string strContent = "";
        //定义id的字符串
        public string strId = "";
        //定义一个数据集存储sql的执行结果
        DataTable dtTmp;


        //点击增加任务的按钮执行下列的方法
        private void buttonAddThing_Click(object sender, EventArgs e)
        {
            //内容的字符串等于文本框里面的字符
            strContent = textBoxAddThing.Text;
            //如果本地模式为假（网络模式）
            if (local == false)
            {
                //获取报错，继续执行
                try
                {
                    //定义一个变量获取下拉框的文本
                    string addName = comboBoxUIuserName.Text;
                    //定义一个变量存储等级
                    string grade;
                    //定义一个变量存储id，没有id为0
                    string linkId = "0";

                    //如果不是本用户增加任务（给下属布置任务）
                    if (addName != UIuserName && strContent != "")
                    {
                        //等级为3
                        grade = "3";
                        //定义一个sql字符串将任务写入本用户的数据表
                        strSql = "insert into [PLAN].[dbo].[" + UIuserName + "] (PLANCONTENT,STARTTIME,OPERATOR,GRADE) values('" + addName + ":" + strContent + "','" + DateTime.Now.ToShortDateString() + "','self',3)  select @@identity AS ID";
                        //执行这个sql语句
                        dtTmp = sqlTemp.ExecuteQuery(strSql);
                        //获取这条新增任务的id
                        linkId = dtTmp.Rows[0]["ID"].ToString();
                        //设置等级为2
                        grade = "2";
                        //定义一个sql字符串将任务写入下属的数据表
                        strSql = "insert into [PLAN].[dbo].[" + addName + "] (PLANCONTENT,STARTTIME,OPERATOR,GRADE,LINKID) values('" + UIuserName + ":" + strContent + "','" + DateTime.Now.ToShortDateString() + "','" + UIuserName + "'," + grade + "," + linkId + ")";
                        //执行这个sql语句
                        dtTmp = sqlTemp.ExecuteQuery(strSql);
                        //提示增加任务成功
                        UIMessageTip.ShowOk("增加任务成功");
                    }
                    //如果任务不为空（给自己增加任务）
                    else if (strContent != "")
                    {
                        //定义等级为1
                        grade = "1";
                        //定义一个sql字符串插入数据
                        strSql = "insert into [PLAN].[dbo].[" + addName + "] (PLANCONTENT,STARTTIME,OPERATOR,GRADE,LINKID) values('" + strContent + "','" + DateTime.Now.ToShortDateString() + "','" + UIuserName + "'," + grade + "," + linkId + ")";
                        //执行这个sql字符串
                        dtTmp = sqlTemp.ExecuteQuery(strSql);
                        //显示增加任务成功
                        UIMessageTip.ShowOk("增加任务成功");

                    }

                }
                //如果报错，执行下列程序（没网）
                catch (Exception ex)
                {
                    //改为本地模式
                    local = true;
                    //提示网络断开
                    UIMessageTip.ShowWarning("网络断开");
                    //将报错代码写入控制台
                    Console.Write(ex.Message);
                }
            }
            //如果是本地模式
            else
            {
                //如果输入框不为空
                if (strContent != "")
                {
                    //增加任务到今日待办.ini
                    File.AppendAllText(@"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "待办.ini", textBoxAddThing.Text + "\r\n");
                }
            }
            //关闭这个窗口
            this.Close();

        }

        /**
         * 在任务文本框按回车执行下列代码，任务框按回车相当于按增加任务按钮
         * **/
        /// <summary>
        /// 在输入框按下回车，触发点击增加事情按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAddThing_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果按回车
            if (e.KeyChar == 13)
            {
                //执行点击增加任务按钮
                buttonAddThing_Click(sender, e);
            }
        }


        /**
         * 按增加下属执行下列代码
         * **/
        private void button_addEmployee_Click(object sender, EventArgs e)
        {
            //定义一个sql字符串添加数据到下属的雇主表，且标记为未拒绝
            strSql = "insert into [PLAN].[dbo].[" + textBox_addEmployee.Text + "Employer] (USERNAME,SIGN) values('" + UIuserName + "',0)  select @@identity";
            //执行这个sql语句    
            dtTmp = sqlTemp.ExecuteQuery(strSql);
            //如果有网络或下属名正确
            if (dtTmp != null)
            {
                //提示增加下属成功
                UIMessageTip.ShowOk("发送增加下属请求成功");
                //关闭窗口
                this.Close();
            }
            //如果没有网络或下属名错误
            else
            {
                //提示添加下属失败
                UIMessageTip.ShowWarning("发送增加下属请求失败");
            }


        }
        /*
        **在增加下属框按回车，执行增加下属按钮
        */
        private void textBox_addEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果按回车
            if (e.KeyChar == 13)
            {
                //按钮点击增加雇员
                button_addEmployee_Click(sender, e);
            }
        }

        /**
         * 点击提醒按钮执行下列代码
         * **/
        private void uiButton_notice_Click(object sender, EventArgs e)
        {
            //定义notice对象，并将点击人发送过去
            FormNotice form = new FormNotice(UIuserName);
            //对象显示窗口
            form.ShowDialog();
        }
    }
}

