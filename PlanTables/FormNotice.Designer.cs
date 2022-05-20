
namespace PlanTables
{
    partial class FormNotice
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
            this.listViewNotice = new System.Windows.Forms.ListView();
            this.user_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myButtonOK = new Sunny.UI.UISymbolButton();
            this.myButtonNo = new Sunny.UI.UISymbolButton();
            this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewNotice
            // 
            this.listViewNotice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.user_name,
            this.yes,
            this.no});
            this.listViewNotice.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold);
            this.listViewNotice.ForeColor = System.Drawing.Color.Red;
            this.listViewNotice.FullRowSelect = true;
            this.listViewNotice.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewNotice.HideSelection = false;
            this.listViewNotice.HoverSelection = true;
            this.listViewNotice.Location = new System.Drawing.Point(12, 11);
            this.listViewNotice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewNotice.Name = "listViewNotice";
            this.listViewNotice.Scrollable = false;
            this.listViewNotice.ShowItemToolTips = true;
            this.listViewNotice.Size = new System.Drawing.Size(300, 229);
            this.listViewNotice.TabIndex = 11;
            this.listViewNotice.TabStop = false;
            this.listViewNotice.UseCompatibleStateImageBehavior = false;
            this.listViewNotice.View = System.Windows.Forms.View.Details;
            this.listViewNotice.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // user_name
            // 
            this.user_name.Text = "";
            this.user_name.Width = 100;
            // 
            // yes
            // 
            this.yes.Text = "";
            this.yes.Width = 100;
            // 
            // myButtonOK
            // 
            this.myButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButtonOK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myButtonOK.Location = new System.Drawing.Point(21, 12);
            this.myButtonOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.myButtonOK.Name = "myButtonOK";
            this.myButtonOK.Size = new System.Drawing.Size(100, 35);
            this.myButtonOK.Style = Sunny.UI.UIStyle.Custom;
            this.myButtonOK.StyleCustomMode = true;
            this.myButtonOK.TabIndex = 80;
            this.myButtonOK.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myButtonOK.Visible = false;
            this.myButtonOK.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.myButtonOK.Click += new System.EventHandler(this.myButtonOK_Click);
            // 
            // myButtonNo
            // 
            this.myButtonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButtonNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.myButtonNo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.myButtonNo.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.myButtonNo.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myButtonNo.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myButtonNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myButtonNo.Location = new System.Drawing.Point(127, 12);
            this.myButtonNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.myButtonNo.Name = "myButtonNo";
            this.myButtonNo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.myButtonNo.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.myButtonNo.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myButtonNo.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myButtonNo.Size = new System.Drawing.Size(100, 35);
            this.myButtonNo.Style = Sunny.UI.UIStyle.Red;
            this.myButtonNo.StyleCustomMode = true;
            this.myButtonNo.Symbol = 61453;
            this.myButtonNo.TabIndex = 81;
            this.myButtonNo.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myButtonNo.Visible = false;
            this.myButtonNo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.myButtonNo.Click += new System.EventHandler(this.myButtonNo_Click);
            // 
            // no
            // 
            this.no.Text = "";
            this.no.Width = 100;
            // 
            // FormNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 251);
            this.Controls.Add(this.myButtonNo);
            this.Controls.Add(this.myButtonOK);
            this.Controls.Add(this.listViewNotice);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "FormNotice";
            this.Text = "被添加为下属请求";
            this.Load += new System.EventHandler(this.FormNotice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewNotice;
        private System.Windows.Forms.ColumnHeader user_name;
        private System.Windows.Forms.ColumnHeader yes;
        private Sunny.UI.UISymbolButton myButtonOK;
        private Sunny.UI.UISymbolButton myButtonNo;
        private System.Windows.Forms.ColumnHeader no;
    }
}