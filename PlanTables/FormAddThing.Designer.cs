
namespace PlanTables
{
    partial class FormAddThing
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
            this.comboBoxTableName = new Sunny.UI.UIComboBox();
            this.textBoxAddThing = new Sunny.UI.UITextBox();
            this.textBox_addEmployee = new Sunny.UI.UITextBox();
            this.buttonAddThing = new Sunny.UI.UIButton();
            this.button_addEmployee = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // comboBoxTableName
            // 
            this.comboBoxTableName.DataSource = null;
            this.comboBoxTableName.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboBoxTableName.FillColor = System.Drawing.Color.White;
            this.comboBoxTableName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comboBoxTableName.Location = new System.Drawing.Point(11, 10);
            this.comboBoxTableName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTableName.MinimumSize = new System.Drawing.Size(54, 0);
            this.comboBoxTableName.Name = "comboBoxTableName";
            this.comboBoxTableName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBoxTableName.Size = new System.Drawing.Size(129, 29);
            this.comboBoxTableName.TabIndex = 0;
            this.comboBoxTableName.TabStop = false;
            this.comboBoxTableName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBoxTableName.Watermark = "选择下属";
            this.comboBoxTableName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // textBoxAddThing
            // 
            this.textBoxAddThing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddThing.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxAddThing.Location = new System.Drawing.Point(147, 10);
            this.textBoxAddThing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddThing.MinimumSize = new System.Drawing.Size(1, 11);
            this.textBoxAddThing.Name = "textBoxAddThing";
            this.textBoxAddThing.ShowText = false;
            this.textBoxAddThing.Size = new System.Drawing.Size(265, 29);
            this.textBoxAddThing.TabIndex = 1;
            this.textBoxAddThing.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxAddThing.Watermark = "添加任务";
            this.textBoxAddThing.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxAddThing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddThing_KeyPress);
            // 
            // textBox_addEmployee
            // 
            this.textBox_addEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_addEmployee.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBox_addEmployee.Location = new System.Drawing.Point(11, 47);
            this.textBox_addEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_addEmployee.MinimumSize = new System.Drawing.Size(1, 11);
            this.textBox_addEmployee.Name = "textBox_addEmployee";
            this.textBox_addEmployee.ShowText = false;
            this.textBox_addEmployee.Size = new System.Drawing.Size(129, 30);
            this.textBox_addEmployee.TabIndex = 2;
            this.textBox_addEmployee.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBox_addEmployee.Watermark = "添加下属";
            this.textBox_addEmployee.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBox_addEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddThing_KeyPress);
            // 
            // buttonAddThing
            // 
            this.buttonAddThing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddThing.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonAddThing.Location = new System.Drawing.Point(417, 10);
            this.buttonAddThing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddThing.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonAddThing.Name = "buttonAddThing";
            this.buttonAddThing.Size = new System.Drawing.Size(78, 29);
            this.buttonAddThing.TabIndex = 3;
            this.buttonAddThing.TabStop = false;
            this.buttonAddThing.Text = "添加任务";
            this.buttonAddThing.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddThing.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.buttonAddThing.Click += new System.EventHandler(this.buttonAddThing_Click);
            // 
            // button_addEmployee
            // 
            this.button_addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addEmployee.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button_addEmployee.Location = new System.Drawing.Point(146, 47);
            this.button_addEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_addEmployee.MinimumSize = new System.Drawing.Size(1, 1);
            this.button_addEmployee.Name = "button_addEmployee";
            this.button_addEmployee.Size = new System.Drawing.Size(81, 30);
            this.button_addEmployee.TabIndex = 4;
            this.button_addEmployee.TabStop = false;
            this.button_addEmployee.Text = "添加下属";
            this.button_addEmployee.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_addEmployee.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.button_addEmployee.Click += new System.EventHandler(this.button_addEmployee_Click);
            // 
            // FormAddThing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 83);
            this.Controls.Add(this.button_addEmployee);
            this.Controls.Add(this.buttonAddThing);
            this.Controls.Add(this.textBox_addEmployee);
            this.Controls.Add(this.textBoxAddThing);
            this.Controls.Add(this.comboBoxTableName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddThing";
            this.Text = "增加任务";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox comboBoxTableName;
        private Sunny.UI.UITextBox textBoxAddThing;
        private Sunny.UI.UITextBox textBox_addEmployee;
        private Sunny.UI.UIButton buttonAddThing;
        private Sunny.UI.UIButton button_addEmployee;
    }
}