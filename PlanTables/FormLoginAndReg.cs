using System;
using System.Data;
using System.Windows.Forms;
using mySQLtest;
using System.IO;
using Sunny.UI;
using System.Configuration;

namespace PlanTables
{
    public partial class FormLoginAndReg : Form
    {
        //构造函数
        public FormLoginAndReg()
        {
            //初始化组件
            InitializeComponent();
        }

        /**
         * 加载窗口时执行下列代码
         * **/
        private void FormLoginAndReg_Load(object sender, EventArgs e)
        {
        }
        //定义一个新的sql对象
        sqlhelp sqlTemp = new sqlhelp();
        //定义一个sql字符串
        string strSql;
        //定义一个sql字符串
        DataTable dtTmp;
        //定义一个用户名为本地模式
        public String UIuserNames = "本地模式";
        
        /**
         * 点击登录标签执行显示登录框
         * **/
        private void linkLabelLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //登陆面板设为可见
            panelLog.Visible = true;
            //注册面板设为不可见
            panelReg.Visible = false;
        }

        /**点击注册标签执行显示注册框**/
        private void linkLabelReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //登陆面板设为不可见
            panelLog.Visible = false;
            //注册面板设为可见
            panelReg.Visible = true;
        }

        /**
         * 点击登录按钮执行下列方法，对比登陆数据是否成功
         * **/
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //定义一个登陆验证的sql语句
            strSql = "select * from [PLAN].[dbo].[LOGIN] where (USERNAME='" + textBoxLoginUser.Text + "' and PASSWORD='" + textBoxLoginPass.Text + "')";
            //执行这个sql语句
            dtTmp = sqlTemp.ExecuteQuery(strSql);
            //如果有网
                if (dtTmp != null)
                {
                    //如果没有这个账号密码
                    if (dtTmp.Rows.Count != 1)
                    {
                        //提示账号密码不存在
                        UIMessageTip.ShowWarning("账号密码不存在");
                    }
                    //如果有这个账号密码
                    else
                    {
                    //提示登陆成功
                        UIMessageTip.ShowOk("登陆成功");
                    //UI上的用户名改为登录名
                        UIuserNames = textBoxLoginUser.Text;
                    //将账号密码写入配置文件
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    //配置文件中的用户名改为本用户
                    config.AppSettings.Settings["userName"].Value = textBoxLoginUser.Text;
                    //配置文件中的密码改为密码框中的密码
                    config.AppSettings.Settings["passWord"].Value = textBoxLoginPass.Text;
                    //保存修改后的配置文件
                    config.Save(ConfigurationSaveMode.Modified);
                    //刷新配置文件
                    ConfigurationManager.RefreshSection("appSettings");
                    //关闭登陆注册窗口
                        this.Close();
                    }
                }
                //如果没网
                else
                {
                    //提示没有网络
                    UIMessageTip.ShowWarning("没有网洛");
                }
            
            
        }

        /**
         * 点击注册按钮，执行下列代码
         * **/
        private void buttonReg_Click(object sender, EventArgs e)
        {
            //如果重复密码与密码相等
            if (textBoxRegPass.Text == textBoxRegRepass.Text)
            {
                //定义一个sql将账号
                strSql = "insert into [PLAN].[dbo].[LOGIN] (USERNAME,PASSWORD) values('" + textBoxRegUser.Text + "','" + textBoxRegPass.Text + "')";
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                //如果有网络且注册没有违规
                if (dtTmp != null)
                {
                    //提示注册成功
                        UIMessageTip.ShowOk("注册成功");
                    //点击登陆标签
                        linkLabelLog_LinkClicked(null, null);
                    //定义一个创建用户表的sql字符串
                    strSql = "create table " + textBoxRegUser.Text + "( ID int IDENTITY(1,1) NOT NULL,STARTTIME date null,ENDTIME date null,PLANCONTENT  varchar(50) null,OPERATOR  varchar(50) null,GRADE int null,LINKID int null)";
                    //执行这个sql语句
                    sqlTemp.ExecuteQuery(strSql);
                    //定义一个创建用户下属表的sql字符串
                    strSql = "create table " + textBoxRegUser.Text + "Employee( ID int IDENTITY(1,1) NOT NULL UNIQUE,USERNAME varchar(50) null UNIQUE)";
                    //执行这个sql语句
                    sqlTemp.ExecuteQuery(strSql);
                    //定义一个创建用户上司表的sql字符串
                    strSql = "create table " + textBoxRegUser.Text + "Employer( ID int IDENTITY(1,1) NOT NULL UNIQUE,USERNAME varchar(50) null UNIQUE,SIGN int)";
                    //执行这个sql语句
                    sqlTemp.ExecuteQuery(strSql);

                }
                //如果没有网络
                else
                {
                    //提示注册失败
                    UIMessageTip.ShowWarning("注册失败");
                }
            
                 
            }
            //如果密码不一致
            else
            {
                //提示密码不一致
                UIMessageTip.ShowWarning("密码不一致");
            }
        }

        /**
         * 如果在重复密码框按回车，触发下列事件
         * **/
        private void textBoxRegRepass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果按回车
            if (e.KeyChar == 13)
            {
                //点击注册
                buttonReg_Click(sender, e);
            }
        }

        /**
         * 如果在登录密码框按回车，触发下列事件
         * **/
        private void textBoxLoginPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果按回车
            if (e.KeyChar == 13)
            {
                //点击登录
                buttonLogin_Click(sender, e);
            }
        }


        /**
         * 如果在注册密码框按回车，触发下列代码
         * **/
        private void textBoxRegPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果点击回车
            if (e.KeyChar == 13)
            {
                //点击注册按钮
                buttonReg_Click(sender, e);
            }
        }

        /**
         * 如果在注册用户框按回车触发下列事件
         * **/
        private void textBoxRegUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果按回车
            if (e.KeyChar == 13)
            {
                //点击注册
                buttonReg_Click(sender, e);
            }
        }

        /**
         * 如果在登录用户按回车，执行下列事件
         * **/
        private void textBoxLoginUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果按回车
            if (e.KeyChar == 13)
            {
                //点击登录
                buttonLogin_Click(sender, e);
            }
        }
    }
}
