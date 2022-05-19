
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
            this.panel1 = new Sunny.UI.UIPanel();
            this.linkLabel1 = new Sunny.UI.UILinkLabel();
            this.textBoxLoginPass = new Sunny.UI.UITextBox();
            this.textBoxLoginUser = new Sunny.UI.UITextBox();
            this.buttonLogin = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.panel2 = new Sunny.UI.UIPanel();
            this.textBoxRegPass = new Sunny.UI.UITextBox();
            this.linkLabel2 = new Sunny.UI.UILinkLabel();
            this.textBoxRegRepass = new Sunny.UI.UITextBox();
            this.textBoxRegUser = new Sunny.UI.UITextBox();
            this.buttonReg = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.textBoxLoginPass);
            this.panel1.Controls.Add(this.textBoxLoginUser);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 175);
            this.panel1.TabIndex = 0;
            this.panel1.Text = null;
            this.panel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(26, 125);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "注册";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(3, 10);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "姓名";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxRegPass);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.textBoxRegRepass);
            this.panel2.Controls.Add(this.textBoxRegUser);
            this.panel2.Controls.Add(this.buttonReg);
            this.panel2.Controls.Add(this.uiLabel3);
            this.panel2.Controls.Add(this.uiLabel4);
            this.panel2.Controls.Add(this.uiLabel5);
            this.panel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.panel2.Location = new System.Drawing.Point(11, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 173);
            this.panel2.TabIndex = 1;
            this.panel2.Text = null;
            this.panel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panel2.Visible = false;
            this.panel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(37, 137);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(100, 23);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "登录";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLoginAndReg";
            this.Text = "登陆注册";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panel1;
        private Sunny.UI.UILinkLabel linkLabel1;
        private Sunny.UI.UITextBox textBoxLoginPass;
        private Sunny.UI.UITextBox textBoxLoginUser;
        private Sunny.UI.UIButton buttonLogin;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel panel2;
        private Sunny.UI.UITextBox textBoxRegPass;
        private Sunny.UI.UILinkLabel linkLabel2;
        private Sunny.UI.UITextBox textBoxRegRepass;
        private Sunny.UI.UITextBox textBoxRegUser;
        private Sunny.UI.UIButton buttonReg;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
    }
}