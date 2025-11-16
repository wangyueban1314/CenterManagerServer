using System;
using System.ComponentModel;
using System.Windows.Forms;

internal class AppSettingEditForm : Form {
    internal int int_0;

    internal int int_1;

    internal string string_0 = "";

    private IContainer icontainer_0=null;

    private Label label1;

    private Button button2;

    private Button button1;

    private TextBox textBox1;
	private ComboBox comboBox1;

    public AppSettingEditForm() {
        InitializeComponent();
    }

    private void AppSettingEditForm_Load(object sender, EventArgs e) {
		if (int_0 == 1) {
            if (string_0 == "启用") {
                string_0 = "1";
            }
            else if (string_0 == "禁用") {
                string_0 = "0";
            }
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = int.Parse(string_0);
        }
        else {
            textBox1.Visible = true;
            textBox1.Text = string_0;
        }
    }
    private void button2_Click(object sender, EventArgs e)
    {
        Dispose();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        if (int_0 == 1)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择一个设置值！");
                return;
            }
            if (Class5.smethod_90(int_1, comboBox1.SelectedIndex.ToString()) != 1)
            {
                MessageBox.Show("编辑失败！");
                return;
            }
        }
        else
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("设置值不能为空！");
                return;
            }
            if (Class5.smethod_90(int_1, textBox1.Text) != 1)
            {
                MessageBox.Show("编辑失败！");
                return;
            }
        }
        Dispose();
    }



    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingEditForm));
        this.label1 = new System.Windows.Forms.Label();
        this.button2 = new System.Windows.Forms.Button();
        this.button1 = new System.Windows.Forms.Button();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.comboBox1 = new System.Windows.Forms.ComboBox();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(9, 16);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(53, 12);
        this.label1.TabIndex = 0;
        this.label1.Text = "设置值：";
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(438, 10);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(58, 26);
        this.button2.TabIndex = 23;
        this.button2.Text = "取消";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(374, 10);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(58, 26);
        this.button1.TabIndex = 22;
        this.button1.Text = "确认";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(68, 12);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(300, 21);
        this.textBox1.TabIndex = 24;
        this.textBox1.Visible = false;
        // 
        // comboBox1
        // 
        this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Items.AddRange(new object[] {
            "禁用",
            "启用"});
        this.comboBox1.Location = new System.Drawing.Point(68, 12);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new System.Drawing.Size(300, 20);
        this.comboBox1.TabIndex = 25;
        this.comboBox1.Visible = false;
        // 
        // AppSettingEditForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(509, 46);
        this.ControlBox = false;
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.comboBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "AppSettingEditForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "设置编辑";
        this.Load += new System.EventHandler(this.AppSettingEditForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    protected override void Dispose(bool disposing)
    {
        if (disposing && icontainer_0 != null)
        {
            icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

}
