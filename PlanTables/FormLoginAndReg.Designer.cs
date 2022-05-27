
namespace PlanTables
{
    partial class FormLoginAndReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLog = new Sunny.UI.UIPanel();
            this.linkLabelReg = new Sunny.UI.UILinkLabel();
            this.textBoxLoginPass = new Sunny.UI.UITextBox();
            this.textBoxLoginUser = new Sunny.UI.UITextBox();
            this.buttonLogin = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.panelReg = new Sunny.UI.UIPanel();
            this.textBoxRegPass = new Sunny.UI.UITextBox();
            this.linkLabelLog = new Sunny.UI.UILinkLabel();
            this.textBoxRegRepass = new Sunny.UI.UITextBox();
            this.textBoxRegUser = new Sunny.UI.UITextBox();
            this.buttonReg = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.panelLog.SuspendLayout();
            this.panelReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.linkLabelReg);
            this.panelLog.Controls.Add(this.textBoxLoginPass);
            this.panelLog.Controls.Add(this.textBoxLoginUser);
            this.panelLog.Controls.Add(this.buttonLogin);
            this.panelLog.Controls.Add(this.uiLabel2);
            this.panelLog.Controls.Add(this.uiLabel1);
            this.panelLog.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.panelLog.Location = new System.Drawing.Point(11, 10);
            this.panelLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLog.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(311, 175);
            this.panelLog.TabIndex = 0;
            this.panelLog.Text = null;
            this.panelLog.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelLog.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // linkLabelReg
            // 
            this.linkLabelReg.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkLabelReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.linkLabelReg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.linkLabelReg.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelReg.Location = new System.Drawing.Point(26, 125);
            this.linkLabelReg.Name = "linkLabelReg";
            this.linkLabelReg.Size = new System.Drawing.Size(100, 23);
            this.linkLabelReg.TabIndex = 5;
            this.linkLabelReg.TabStop = true;
            this.linkLabelReg.Text = "注册";
            this.linkLabelReg.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkLabelReg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.linkLabelReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReg_LinkClicked);
            // 
            // textBoxLoginPass
            // 
            this.textBoxLoginPass.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxLoginPass.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxLoginPass.Location = new System.Drawing.Point(64, 62);
            this.textBoxLoginPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLoginPass.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxLoginPass.Name = "textBoxLoginPass";
            this.textBoxLoginPass.PasswordChar = '*';
            this.textBoxLoginPass.ShowText = false;
            this.textBoxLoginPass.Size = new System.Drawing.Size(195, 29);
            this.textBoxLoginPass.TabIndex = 3;
            this.textBoxLoginPass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxLoginPass.Watermark = "请输入密码";
            this.textBoxLoginPass.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxLoginPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoginPass_KeyPress);
            // 
            // textBoxLoginUser
            // 
            this.textBoxLoginUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLoginUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxLoginUser.Location = new System.Drawing.Point(64, 10);
            this.textBoxLoginUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLoginUser.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxLoginUser.Name = "textBoxLoginUser";
            this.textBoxLoginUser.ShowText = false;
            this.textBoxLoginUser.Size = new System.Drawing.Size(195, 29);
            this.textBoxLoginUser.TabIndex = 2;
            this.textBoxLoginUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxLoginUser.Watermark = "请输入姓名";
            this.textBoxLoginUser.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxLoginUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoginUser_KeyPress);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonLogin.Location = new System.Drawing.Point(132, 113);
            this.buttonLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 35);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(1, 68);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(3, 10);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "姓名";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // panelReg
            // 
            this.panelReg.Controls.Add(this.textBoxRegPass);
            this.panelReg.Controls.Add(this.linkLabelLog);
            this.panelReg.Controls.Add(this.textBoxRegRepass);
            this.panelReg.Controls.Add(this.textBoxRegUser);
            this.panelReg.Controls.Add(this.buttonReg);
            this.panelReg.Controls.Add(this.uiLabel3);
            this.panelReg.Controls.Add(this.uiLabel4);
            this.panelReg.Controls.Add(this.uiLabel5);
            this.panelReg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.panelReg.Location = new System.Drawing.Point(11, 10);
            this.panelReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelReg.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelReg.Name = "panelReg";
            this.panelReg.Size = new System.Drawing.Size(311, 173);
            this.panelReg.TabIndex = 1;
            this.panelReg.Text = null;
            this.panelReg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelReg.Visible = false;
            this.panelReg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // textBoxRegPass
            // 
            this.textBoxRegPass.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxRegPass.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxRegPass.Location = new System.Drawing.Point(83, 49);
            this.textBoxRegPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRegPass.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxRegPass.Name = "textBoxRegPass";
            this.textBoxRegPass.PasswordChar = '*';
            this.textBoxRegPass.ShowText = false;
            this.textBoxRegPass.Size = new System.Drawing.Size(199, 29);
            this.textBoxRegPass.TabIndex = 7;
            this.textBoxRegPass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxRegPass.Watermark = "请输入密码";
            this.textBoxRegPass.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxRegPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegPass_KeyPress);
            // 
            // linkLabelLog
            // 
            this.linkLabelLog.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkLabelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.linkLabelLog.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.linkLabelLog.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelLog.Location = new System.Drawing.Point(37, 137);
            this.linkLabelLog.Name = "linkLabelLog";
            this.linkLabelLog.Size = new System.Drawing.Size(100, 23);
            this.linkLabelLog.TabIndex = 9;
            this.linkLabelLog.TabStop = true;
            this.linkLabelLog.Text = "登录";
            this.linkLabelLog.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkLabelLog.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.linkLabelLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLog_LinkClicked);
            // 
            // textBoxRegRepass
            // 
            this.textBoxRegRepass.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxRegRepass.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxRegRepass.Location = new System.Drawing.Point(83, 88);
            this.textBoxRegRepass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRegRepass.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxRegRepass.Name = "textBoxRegRepass";
            this.textBoxRegRepass.PasswordChar = '*';
            this.textBoxRegRepass.ShowText = false;
            this.textBoxRegRepass.Size = new System.Drawing.Size(199, 29);
            this.textBoxRegRepass.TabIndex = 8;
            this.textBoxRegRepass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxRegRepass.Watermark = "请重新输入密码";
            this.textBoxRegRepass.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxRegRepass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegRepass_KeyPress);
            // 
            // textBoxRegUser
            // 
            this.textBoxRegUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxRegUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxRegUser.Location = new System.Drawing.Point(83, 10);
            this.textBoxRegUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRegUser.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxRegUser.Name = "textBoxRegUser";
            this.textBoxRegUser.ShowText = false;
            this.textBoxRegUser.Size = new System.Drawing.Size(199, 29);
            this.textBoxRegUser.TabIndex = 6;
            this.textBoxRegUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxRegUser.Watermark = "请输入姓名";
            this.textBoxRegUser.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxRegUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegUser_KeyPress);
            // 
            // buttonReg
            // 
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonReg.Location = new System.Drawing.Point(159, 125);
            this.buttonReg.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(100, 35);
            this.buttonReg.TabIndex = 9;
            this.buttonReg.TabStop = false;
            this.buttonReg.Text = "注册";
            this.buttonReg.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(3, 94);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "确认密码";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(3, 16);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 0;
            this.uiLabel4.Text = "姓名";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(3, 54);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "密码";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FormLoginAndReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 198);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.panelReg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLoginAndReg";
            this.Text = "登陆注册";
            this.panelLog.ResumeLayout(false);
            this.panelReg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panelLog;
        private Sunny.UI.UILinkLabel linkLabelReg;
        private Sunny.UI.UITextBox textBoxLoginPass;
        private Sunny.UI.UITextBox textBoxLoginUser;
        private Sunny.UI.UIButton buttonLogin;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel panelReg;
        private Sunny.UI.UITextBox textBoxRegPass;
        private Sunny.UI.UILinkLabel linkLabelLog;
        private Sunny.UI.UITextBox textBoxRegRepass;
        private Sunny.UI.UITextBox textBoxRegUser;
        private Sunny.UI.UIButton buttonReg;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
    }
}