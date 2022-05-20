using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mySQLtest;
using System.IO;
using Sunny.UI;

namespace PlanTables
{
    public partial class FormLoginAndReg : Form
    {
        public FormLoginAndReg()
        {
            InitializeComponent();
        }
        private void FormLoginAndReg_Load(object sender, EventArgs e)
        {

        }
        sqlhelp sqlTemp = new sqlhelp();
        string strSql;
        DataTable dtTmp;
        public String tableNames = "本地模式";
        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            strSql = "select * from [PLAN].[dbo].[LOGIN] where (USERNAME='" + textBoxLoginUser.Text + "' and PASSWORD='" + textBoxLoginPass.Text + "')";
            dtTmp = sqlTemp.ExecuteQuery(strSql);
            try
            {
                if (dtTmp.Rows.Count != 1)
                {
                    UIMessageTip.ShowWarning("账号密码不存在");
                }
                else
                {
                    UIMessageTip.ShowOk("登陆成功");
                    tableNames = textBoxLoginUser.Text;
                    File.WriteAllText(@"C:\待办事项\pass.ini", textBoxLoginUser.Text + "\r\n" + textBoxLoginPass.Text);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                UIMessageTip.ShowWarning("没有网络");
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (textBoxRegPass.Text == textBoxRegRepass.Text)
            {
                strSql = "insert into [PLAN].[dbo].[LOGIN] (USERNAME,PASSWORD) values('" + textBoxRegUser.Text + "','" + textBoxRegPass.Text + "')";
                int judge = sqlTemp.ExecuteUpdate(strSql);

                try
                {
                    if (judge != 1)
                    {
                        UIMessageTip.ShowWarning("注册失败");
                    }
                    else
                    {
                        UIMessageTip.ShowOk("注册成功");
                        linkLabel2_LinkClicked(null, null);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    UIMessageTip.ShowWarning("没有网络");
                }

                strSql = "create table " + textBoxRegUser.Text + "( ID int IDENTITY(1,1) NOT NULL,STARTTIME date null,ENDTIME date null,PLANCONTENT  varchar(50) null,OPERATOR  varchar(50) null,GRADE int null,LINKID int null)";
                sqlTemp.ExecuteQuery(strSql);
                strSql = "create table " + textBoxRegUser.Text + "Employee( ID int IDENTITY(1,1) NOT NULL UNIQUE,USERNAME varchar(50) null UNIQUE)";
                sqlTemp.ExecuteQuery(strSql);
                strSql = "create table " + textBoxRegUser.Text + "Employer( ID int IDENTITY(1,1) NOT NULL UNIQUE,USERNAME varchar(50) null UNIQUE,SIGN int)";
                sqlTemp.ExecuteQuery(strSql);
                //strSql = "insert into [PLAN].[dbo].[" + textBoxRegUser.Text + "] (USERNAME) values('" + textBoxRegUser.Text + "')";
            }
            else
            {
                UIMessageTip.ShowWarning("密码不一致");
            }
        }

        private void textBoxRegRepass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonReg_Click(sender, e);
            }
        }

        private void textBoxLoginPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void textBoxRegPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonReg_Click(sender, e);
            }
        }

        private void textBoxRegUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonReg_Click(sender, e);
            }
        }

        private void textBoxLoginUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonLogin_Click(sender, e);
            }
        }
    }
}
