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
        public FormNotice()
        {
            InitializeComponent();

        }
        string table_name;
        string strSql;
        sqlhelp sqlTemp = new sqlhelp();
        DataTable dtTmp;
        //private UIButton btn = new UIButton();
        //private UISymbolButton OKbtn = new UISymbolButton();
        
        
       


        
        


        private void FormNotice_Load(object sender, EventArgs e)
        {

            
            showNotice();

        }
        private void showNotice()
        {
            strSql = "select * from [PLAN].[dbo].[" + table_name + "Employer] where SIGN=0";
            dtTmp = sqlTemp.ExecuteQuery(strSql);
            if (dtTmp != null)
            {
                for (int i = 0; i < dtTmp.Rows.Count; i++)
                {
                    string name = dtTmp.Rows[i]["USERNAME"].ToString();
                    AddThings(listViewNotice, dtTmp.Rows[i]["USERNAME"].ToString(), dtTmp.Rows[i]["ID"].ToString());
                    //uiDataGridView1.AddButtonColumn(Text="同意");
                    //uiDataGridView1.AddRow(dtTmp.Rows[i]["USERNAME"].ToString()) ;

                }

                myButtonOK.Visible = false;
                myButtonNo.Visible = false;
                //btn.Text = "同意";
                // OKbtn.Controls.UISymbolButton1();
                //this.btn.Font = new Font("Tahoma", 8, FontStyle.Bold);
                //myButtonOK.Click += this.button_Click;
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem[] lvs = new ListViewItem[3];
            if (this.listViewNotice.SelectedItems.Count > 0)
            {
                this.listViewNotice.Controls.Add(myButtonOK);
                this.myButtonOK.Size = new Size(this.listViewNotice.Items[0].SubItems[1].Bounds.Width,
                this.listViewNotice.Items[0].SubItems[1].Bounds.Height);

                //myButtonNo.Click += this.button_Click;
                this.listViewNotice.Controls.Add(myButtonNo);
                this.myButtonNo.Size = new Size(this.listViewNotice.Items[0].SubItems[2].Bounds.Width,
                this.listViewNotice.Items[0].SubItems[2].Bounds.Height);
                this.myButtonOK.Location = new Point(this.listViewNotice.SelectedItems[0].SubItems[1].Bounds.Left, this.listViewNotice.SelectedItems[0].SubItems[1].Bounds.Top);
                this.myButtonOK.Visible = true;

                this.myButtonNo.Location = new Point(this.listViewNotice.SelectedItems[0].SubItems[2].Bounds.Left, this.listViewNotice.SelectedItems[0].SubItems[2].Bounds.Top);
                this.myButtonNo.Visible = true;
            }
        }
        


        public FormNotice(String tableName)
        {
            InitializeComponent();
            table_name = tableName;
            
        }

        private void AddThings(ListView lv, string user_name, string id)
        {
            ListViewItem lvi = new ListViewItem(user_name);
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
            lv.Items.Add(lvi);


        }

        private void myButtonOK_Click(object sender, EventArgs e)
        {
            //string employer=listViewNotice
                        if (listViewNotice.SelectedIndices != null && listViewNotice.SelectedIndices.Count > 0)
            {
                //ListView.SelectedIndexCollection c = listview.SelectedIndices;
                //lblTitle.Text = listview.Items[c[0]].Text;
                int s = listViewNotice.SelectedIndices[0];
                ///string st = listViewNotice.Items[0].Text;
                strSql = "insert into [PLAN].[dbo].[" + listViewNotice.Items[s].Text + "Employee] (USERNAME) values('" + table_name + "')  select @@identity";
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                //strSql = "insert into [PLAN].[dbo].[" + textBox_addEmployee.Text + "Employer] (USERNAME,SIGN) values('" + tableName + "',0)  select @@identity";
                strSql = "update [PLAN].[dbo].[" + table_name + "Employer] set SIGN=1 where USERNAME='" + listViewNotice.Items[s].Text + "'";
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                if (dtTmp != null)
                {
                    UIMessageTip.ShowOk("接受"+ listViewNotice.Items[s].Text+"的请求成功！");
                }
                else
                {
                    UIMessageTip.ShowWarning("接受" + listViewNotice.Items[s].Text + "的请求失败！");
                }
                listViewNotice.Items[s].Remove();
                showNotice();
                //this.Close();

            }
        }

        private void myButtonNo_Click(object sender, EventArgs e)
        {
            if (listViewNotice.SelectedIndices != null && listViewNotice.SelectedIndices.Count > 0)
            {
                //ListView.SelectedIndexCollection c = listview.SelectedIndices;
                //lblTitle.Text = listview.Items[c[0]].Text;
                int s = listViewNotice.SelectedIndices[0];
                strSql = "update [PLAN].[dbo].[" + table_name + "Employer] set SIGN=2 where USERNAME='" + listViewNotice.Items[s].Text + "'";
                dtTmp = sqlTemp.ExecuteQuery(strSql);
                if (dtTmp != null)
                {
                    UIMessageTip.ShowOk("拒绝" + listViewNotice.Items[s].Text + "的请求成功！");
                }
                else
                {
                    UIMessageTip.ShowWarning("拒绝" + listViewNotice.Items[s].Text + "的请求失败！");
                }
                listViewNotice.Items[s].Remove();
                showNotice();
                
            }
        }
         
    }
}
