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
    public partial class FormAddThing : Form
    {
        private void FormAddThing_Load(object sender, EventArgs e)
        {
            strSql = "select * from [PLAN].[dbo].[" + tableName + "Employer] where SIGN=0";
            dtTmp = sqlTemp.ExecuteQuery(strSql);
            if (dtTmp.Rows.Count != 0)
            {
                uiButton_notice.SetStyle(UIStyle.Red);
                uiButton_notice.Text = "有" + dtTmp.Rows.Count + "个添加您为下属的消息";

            }
            
        }

        public FormAddThing(string tN, ref bool l)
        {
            tableName = tN;
            local = l;
            InitializeComponent();

            comboBoxTableName.Items.Add(tableName);
            try
            {
                string sql = "select * from [PLAN].[dbo].[" + tableName + "Employee]";
                dtTmp = sqlTemp.ExecuteQuery(sql);
                if (dtTmp != null)
                {
                    for (int i = 0; i < dtTmp.Rows.Count; i++)
                    {
                        comboBoxTableName.Items.Add(dtTmp.Rows[i]["USERNAME"].ToString());
                    }
                }
                
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (comboBoxTableName.Items.Count > 0)
            {
                comboBoxTableName.SelectedIndex = 0;
            }
        }
        public static bool local;
        String tableName;
        sqlhelp sqlTemp = new sqlhelp();
        string strSql;
        public string strContent = "";
        public string strId = "";
        //public static bool local = false;
        DataTable dtTmp;
        /// <summary>
        /// 点击增加事情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddThing_Click(object sender, EventArgs e)
        {
            //this.Hide();
            strContent = textBoxAddThing.Text;

            if (local == false)
            {

                try
                {
                    string addName = comboBoxTableName.Text;
                    string grade;
                    string linkId = "0";
                    if (addName != tableName)
                    {
                        grade = "3";
                        strSql = "insert into [PLAN].[dbo].[" + tableName + "] (PLANCONTENT,STARTTIME,OPERATOR,GRADE) values('" + addName + ":" + strContent + "','" + DateTime.Now.ToShortDateString() + "','self',3)  select @@identity AS ID";
                        dtTmp = sqlTemp.ExecuteQuery(strSql);
                        linkId = dtTmp.Rows[0]["ID"].ToString();
                        grade = "2";
                        strSql = "insert into [PLAN].[dbo].[" + addName + "] (PLANCONTENT,STARTTIME,OPERATOR,GRADE,LINKID) values('" + tableName + ":" + strContent + "','" + DateTime.Now.ToShortDateString() + "','" + tableName + "'," + grade + "," + linkId + ")";
                        dtTmp = sqlTemp.ExecuteQuery(strSql);
                        UIMessageTip.ShowOk("增加任务成功");
                    }
                    else if (strContent != "")
                    {
                        grade = "1";
                        strSql = "insert into [PLAN].[dbo].[" + addName + "] (PLANCONTENT,STARTTIME,OPERATOR,GRADE,LINKID) values('"+ strContent + "','" + DateTime.Now.ToShortDateString() + "','" + tableName + "'," + grade + "," + linkId + ")";
                        dtTmp = sqlTemp.ExecuteQuery(strSql);
                        UIMessageTip.ShowOk("增加任务成功");

                    }
                    
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    local = true;
                    UIMessageTip.ShowWarning("网络断开");
                    Console.Write(ex.Message);
                }
            }
            else
            {
                File.AppendAllText(@"C:\待办事项\" + DateTime.Now.ToLongDateString().ToString() + "待办.ini", textBoxAddThing.Text + "\r\n");
            }
            this.Close();

        }
        /// <summary>
        /// 在输入框按下回车，触发点击增加事情按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAddThing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAddThing_Click(sender, e);
            }
        }

        

        private void button_addEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                //strSql = "insert into [PLAN].[dbo].[" + tableName + "Employee] (USERNAME) values('" + textBox_addEmployee.Text + "')  select @@identity";
                strSql = "insert into [PLAN].[dbo].[" + textBox_addEmployee.Text + "Employer] (USERNAME,SIGN) values('" + tableName + "',0)  select @@identity";
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                if (dtTmp != null)
                {
                    UIMessageTip.ShowOk("发送增加下属请求成功");
                }
                else
                {
                    UIMessageTip.ShowWarning("发送增加下属请求失败");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void textBox_addEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button_addEmployee_Click(sender, e);
            }
        }

        private void uiButton_notice_Click(object sender, EventArgs e)
        {
            FormNotice form = new FormNotice(tableName);
            form.ShowDialog();
        }
    }
}

