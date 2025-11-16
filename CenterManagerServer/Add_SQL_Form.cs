using System;
using System.ComponentModel;
using System.Windows.Forms;

internal class Add_SQL_Form : Form {
    internal ushort ushort_0;

    internal string string_0 = "";

    private IContainer icontainer_0=null;

    private Label label1;

    private TextBox servertextBox;

    private TextBox uidtextBox;

    private Label label3;

    private TextBox pwdtextBox;

    private Label label4;

    private Button button1;
	private Button button2;

    public Add_SQL_Form() {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
        if (servertextBox.Text == "") {
            MessageBox.Show("服务器地址不能为空!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (uidtextBox.Text == "") {
            MessageBox.Show("数据库用户名不能为空!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (pwdtextBox.Text == "") {
            MessageBox.Show("数据库密码不能为空!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (ushort_0 == 1) {
            string_0 = "server=" + servertextBox.Text + ";uid=" + uidtextBox.Text + ";pwd=" + pwdtextBox.Text + ";";
        }
        Dispose();
    }

    private void button2_Click(object sender, EventArgs e) {
        Dispose();
    }
    protected override void Dispose(bool disposing)
    {
        if (disposing && icontainer_0 != null)
        {
            icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_SQL_Form));
        this.label1 = new System.Windows.Forms.Label();
        this.servertextBox = new System.Windows.Forms.TextBox();
        this.uidtextBox = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.pwdtextBox = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 18);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(53, 12);
        this.label1.TabIndex = 0;
        this.label1.Text = "服务器：";
        // 
        // servertextBox
        // 
        this.servertextBox.Location = new System.Drawing.Point(61, 15);
        this.servertextBox.Name = "servertextBox";
        this.servertextBox.Size = new System.Drawing.Size(211, 21);
        this.servertextBox.TabIndex = 1;
        // 
        // uidtextBox
        // 
        this.uidtextBox.Location = new System.Drawing.Point(61, 42);
        this.uidtextBox.Name = "uidtextBox";
        this.uidtextBox.Size = new System.Drawing.Size(211, 21);
        this.uidtextBox.TabIndex = 5;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(12, 45);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(53, 12);
        this.label3.TabIndex = 4;
        this.label3.Text = "用户名：";
        // 
        // pwdtextBox
        // 
        this.pwdtextBox.Location = new System.Drawing.Point(61, 69);
        this.pwdtextBox.Name = "pwdtextBox";
        this.pwdtextBox.Size = new System.Drawing.Size(211, 21);
        this.pwdtextBox.TabIndex = 7;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(24, 72);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(41, 12);
        this.label4.TabIndex = 6;
        this.label4.Text = "密码：";
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(136, 96);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(65, 23);
        this.button1.TabIndex = 8;
        this.button1.Text = "确认";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(207, 96);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(65, 23);
        this.button2.TabIndex = 9;
        this.button2.Text = "取消";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // Add_SQL_Form
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(283, 129);
        this.ControlBox = false;
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.pwdtextBox);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.uidtextBox);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.servertextBox);
        this.Controls.Add(this.label1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.Name = "Add_SQL_Form";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "SQL连接";
        this.Load += new System.EventHandler(this.Add_SQL_Form_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    private void Add_SQL_Form_Load(object sender, EventArgs e) {
		if (string_0 != "") {
            string[] array = string_0.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (array.Length == 4) {
                servertextBox.Text = array[0].Substring(7, array[0].Length - 7);
                uidtextBox.Text = array[2].Substring(4, array[2].Length - 4);
                pwdtextBox.Text = array[3].Substring(4, array[3].Length - 4);
            }
            else if (array.Length == 3) {
                servertextBox.Text = array[0].Substring(7, array[0].Length - 7);
                uidtextBox.Text = array[1].Substring(4, array[1].Length - 4);
                pwdtextBox.Text = array[2].Substring(4, array[2].Length - 4);
            }
        }
    }


}
