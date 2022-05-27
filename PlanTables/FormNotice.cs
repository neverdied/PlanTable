using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Sunny.UI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mySQLtest;

namespace PlanTables
{
    public partial class FormNotice : Form
    {
        //构造函数
        public FormNotice()
        {
            //初始化组件
            InitializeComponent();

        }
        //定义用户名
        string table_name;
        //定义存sql语句的字符串
        string strSql;
        //定义sql对象
        sqlhelp sqlTemp = new sqlhelp();
        //定义存sql结果的数据集
        DataTable dtTmp;

        /**
         * 加载窗口时调用此方法
         * **/
        private void FormNotice_Load(object sender, EventArgs e)
        {

            //展示注意事项
            showNotice();

        }


        /**
         * 
         * **/
        private void showNotice()
        {
            //定义一个sql语句获取未同意的增哈下属请求
            strSql = "select * from [PLAN].[dbo].[" + table_name + "Employer] where SIGN=0";
            //执行这个sql语句
            dtTmp = sqlTemp.ExecuteQuery(strSql);
            //如果有网
            if (dtTmp != null)
            {
                //遍历未同意请求
                for (int i = 0; i < dtTmp.Rows.Count; i++)
                {
                    //定义一个变量存储上级用户名
                    string name = dtTmp.Rows[i]["USERNAME"].ToString();
                    //增加请求到列表
                    AddThings(listViewNotice, dtTmp.Rows[i]["USERNAME"].ToString(), dtTmp.Rows[i]["ID"].ToString());
                }
                //OK按钮隐藏
                myButtonOK.Visible = false;
                //NO按钮隐藏
                myButtonNo.Visible = false;
            }
        }

        /**
         * 列表项被鼠标划过，执行下列代码
         * **/
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //定义一个数组保存请求项，最多100个
            ListViewItem[] lvs = new ListViewItem[100];
            //如果鼠标移到一个请求项
            if (this.listViewNotice.SelectedItems.Count > 0)
            {
                //增加OK按钮
                this.listViewNotice.Controls.Add(myButtonOK);
                //将OK按扭宽高设为第二列的宽高
                this.myButtonOK.Size = new Size(this.listViewNotice.Items[0].SubItems[1].Bounds.Width,
                this.listViewNotice.Items[0].SubItems[1].Bounds.Height);
                //定义OK的按钮位置为被选择的第二列
                this.myButtonOK.Location = new Point(this.listViewNotice.SelectedItems[0].SubItems[1].Bounds.Left, this.listViewNotice.SelectedItems[0].SubItems[1].Bounds.Top);
                //OK可见性设为真
                this.myButtonOK.Visible = true;

                //增加NO按钮
                this.listViewNotice.Controls.Add(myButtonNo);
                //将NO按钮的宽高设为第三列的宽高
                this.myButtonNo.Size = new Size(this.listViewNotice.Items[0].SubItems[2].Bounds.Width,
                this.listViewNotice.Items[0].SubItems[2].Bounds.Height);
                //定义NO的位置为备选行第三列
                this.myButtonNo.Location = new Point(this.listViewNotice.SelectedItems[0].SubItems[2].Bounds.Left, this.listViewNotice.SelectedItems[0].SubItems[2].Bounds.Top);
                //NO可见性设为真
                this.myButtonNo.Visible = true;
            }
        }


        //构造函数，增加任务窗口将用户传过来
        public FormNotice(String UIuserName)
        {
            //初始化组件，调用加载窗口
            InitializeComponent();
            //将传过来的用户名赋给本地变量
            table_name = UIuserName;

        }

        /**
         * 将数据增加到列表
         * **/
        private void AddThings(ListView lv, string user_name, string id)
        {
            //定义列表项，第一列为用户名
            ListViewItem lvi = new ListViewItem(user_name);
            //列表项第二列为空，给OK按钮占位置
            lvi.SubItems.Add("");
            //第三列为空，给NO按钮占位置
            lvi.SubItems.Add("");
            //增加列表项到列表
            lv.Items.Add(lvi);


        }


        /**
         * 点击OK按钮，触发下列代码
         * **/

        private void myButtonOK_Click(object sender, EventArgs e)
        {
            //如果被选择的项不为空且有未同意的请求
            if (listViewNotice.SelectedIndices != null && listViewNotice.SelectedIndices.Count > 0)
            {
                //存储被选择的项
                int s = listViewNotice.SelectedIndices[0];
                //保存被选择的项插入上级的雇员表的sql
                strSql = "insert into [PLAN].[dbo].[" + listViewNotice.Items[s].Text + "Employee] (USERNAME) values('" + table_name + "')  select @@identity";
                //执行这个sql语句
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                //将未同意请求改为同意请求
                strSql = "update [PLAN].[dbo].[" + table_name + "Employer] set SIGN=1 where USERNAME='" + listViewNotice.Items[s].Text + "'";
                //执行这个sql语句
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                //如果有网
                if (dtTmp != null)
                {
                    //提示请求成功
                    UIMessageTip.ShowOk("接受" + listViewNotice.Items[s].Text + "的请求成功！");
                }
                //如果没网
                else
                {
                    //提示请求失败
                    UIMessageTip.ShowWarning("接受" + listViewNotice.Items[s].Text + "的请求失败！");
                }
                //移除OK的项
                listViewNotice.Items[s].Remove();
                //展示提示
                showNotice();


            }
        }


        /**
         * 
         * 点击No按钮，执行一下代码
         * **/
        private void myButtonNo_Click(object sender, EventArgs e)
        {
            //如果被选择的项不为空且有未同意的请求
            if (listViewNotice.SelectedIndices != null && listViewNotice.SelectedIndices.Count > 0)
            {
                //定义一个变量存储选择的项
                int s = listViewNotice.SelectedIndices[0];
                //定义一个字符串存储将未同意请求改为拒绝请求
                strSql = "delete from [PLAN].[dbo].[" + table_name + "Employer] where  USERNAME='" + listViewNotice.Items[s].Text + "'";
                //执行这个sql语句
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                //如果有网
                if (dtTmp != null)
                {
                    //提示请求成功
                    UIMessageTip.ShowOk("拒绝" + listViewNotice.Items[s].Text + "的请求成功！");
                }
                //如果没网
                else
                {
                    //提示请求失败
                    UIMessageTip.ShowWarning("拒绝" + listViewNotice.Items[s].Text + "的请求失败！");
                }
                //移除被选择的项
                listViewNotice.Items[s].Remove();
                //展示提示
                showNotice();

            }
        }

    }
}
