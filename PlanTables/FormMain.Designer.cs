
namespace PlanTables
{
    partial class FormMain
    {


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.login = new Sunny.UI.UIButton();
            this.buttonAddPlan = new Sunny.UI.UIButton();
            this.listViewDoneToday = new System.Windows.Forms.ListView();
            this.contentDoneToday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idDoneToday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewNotDoneToday = new System.Windows.Forms.ListView();
            this.contentNotDoneToday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idNotDoneToday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SwitchMode = new Sunny.UI.UISwitch();
            this.Avatar = new Sunny.UI.UIAvatar();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(106, 1);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(96, 23);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "未完成任务";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(332, 1);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(109, 23);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "已完成任务";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // login
            // 
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.login.Location = new System.Drawing.Point(355, 203);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.MinimumSize = new System.Drawing.Size(1, 1);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(86, 25);
            this.login.TabIndex = 6;
            this.login.Text = "登录";
            this.login.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // buttonAddPlan
            // 
            this.buttonAddPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddPlan.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonAddPlan.Location = new System.Drawing.Point(105, 203);
            this.buttonAddPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPlan.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonAddPlan.Name = "buttonAddPlan";
            this.buttonAddPlan.Size = new System.Drawing.Size(86, 25);
            this.buttonAddPlan.TabIndex = 5;
            this.buttonAddPlan.Text = "增加任务";
            this.buttonAddPlan.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddPlan.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.buttonAddPlan.Click += new System.EventHandler(this.buttonAddPlan_Click);
            // 
            // listViewDoneToday
            // 
            this.listViewDoneToday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.contentDoneToday,
            this.idDoneToday});
            this.listViewDoneToday.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Strikeout);
            this.listViewDoneToday.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewDoneToday.HideSelection = false;
            this.listViewDoneToday.Location = new System.Drawing.Point(274, 26);
            this.listViewDoneToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewDoneToday.Name = "listViewDoneToday";
            this.listViewDoneToday.Scrollable = false;
            this.listViewDoneToday.Size = new System.Drawing.Size(238, 174);
            this.listViewDoneToday.TabIndex = 9;
            this.listViewDoneToday.TabStop = false;
            this.listViewDoneToday.UseCompatibleStateImageBehavior = false;
            this.listViewDoneToday.View = System.Windows.Forms.View.Details;
            // 
            // contentDoneToday
            // 
            this.contentDoneToday.Text = "";
            this.contentDoneToday.Width = 500;
            // 
            // idDoneToday
            // 
            this.idDoneToday.Text = "ID";
            this.idDoneToday.Width = 0;
            // 
            // listViewNotDoneToday
            // 
            this.listViewNotDoneToday.CheckBoxes = true;
            this.listViewNotDoneToday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.contentNotDoneToday,
            this.idNotDoneToday});
            this.listViewNotDoneToday.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold);
            this.listViewNotDoneToday.ForeColor = System.Drawing.Color.Red;
            this.listViewNotDoneToday.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewNotDoneToday.HideSelection = false;
            this.listViewNotDoneToday.Location = new System.Drawing.Point(10, 26);
            this.listViewNotDoneToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewNotDoneToday.Name = "listViewNotDoneToday";
            this.listViewNotDoneToday.Scrollable = false;
            this.listViewNotDoneToday.ShowItemToolTips = true;
            this.listViewNotDoneToday.Size = new System.Drawing.Size(259, 174);
            this.listViewNotDoneToday.TabIndex = 10;
            this.listViewNotDoneToday.TabStop = false;
            this.listViewNotDoneToday.UseCompatibleStateImageBehavior = false;
            this.listViewNotDoneToday.View = System.Windows.Forms.View.Details;
            this.listViewNotDoneToday.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewNotDoneToday_ItemChecked);
            // 
            // contentNotDoneToday
            // 
            this.contentNotDoneToday.Text = "";
            this.contentNotDoneToday.Width = 300;
            // 
            // idNotDoneToday
            // 
            this.idNotDoneToday.Text = "ID";
            this.idNotDoneToday.Width = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.user_Click);
            // 
            // SwitchMode
            // 
            this.SwitchMode.Active = true;
            this.SwitchMode.ActiveText = "网络模式";
            this.SwitchMode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.SwitchMode.InActiveText = "本地模式";
            this.SwitchMode.Location = new System.Drawing.Point(10, 1);
            this.SwitchMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SwitchMode.MinimumSize = new System.Drawing.Size(1, 1);
            this.SwitchMode.Name = "SwitchMode";
            this.SwitchMode.Size = new System.Drawing.Size(90, 20);
            this.SwitchMode.TabIndex = 101;
            this.SwitchMode.TabStop = false;
            this.SwitchMode.Text = "uiSwitch1";
            this.SwitchMode.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.SwitchMode.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.SwitchMode_ValueChanged);
            // 
            // Avatar
            // 
            this.Avatar.AvatarSize = 25;
            this.Avatar.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.Avatar.Icon = Sunny.UI.UIAvatar.UIIcon.Text;
            this.Avatar.Location = new System.Drawing.Point(468, 1);
            this.Avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avatar.MinimumSize = new System.Drawing.Size(1, 1);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(44, 20);
            this.Avatar.TabIndex = 102;
            this.Avatar.TabStop = false;
            this.Avatar.Text = "本地模式";
            this.Avatar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Avatar.Click += new System.EventHandler(this.user_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 234);
            this.Controls.Add(this.Avatar);
            this.Controls.Add(this.SwitchMode);
            this.Controls.Add(this.listViewNotDoneToday);
            this.Controls.Add(this.listViewDoneToday);
            this.Controls.Add(this.buttonAddPlan);
            this.Controls.Add(this.login);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.Text = "任务表";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton login;
        private Sunny.UI.UIButton buttonAddPlan;
        private System.Windows.Forms.ListView listViewDoneToday;
        private System.Windows.Forms.ColumnHeader contentDoneToday;
        private System.Windows.Forms.ColumnHeader idDoneToday;
        private System.Windows.Forms.ListView listViewNotDoneToday;
        private System.Windows.Forms.ColumnHeader contentNotDoneToday;
        private System.Windows.Forms.ColumnHeader idNotDoneToday;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UISwitch SwitchMode;
        private Sunny.UI.UIAvatar Avatar;
    }
}




