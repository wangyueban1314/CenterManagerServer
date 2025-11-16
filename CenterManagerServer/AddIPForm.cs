using System;
using System.ComponentModel;
using System.Windows.Forms;

internal class AddIPForm : Form {
    private int int_0;

    private IContainer icontainer_0=null;

    private ComboBox comboBox1;

    private Label label1;

    private Label label2;

    private TextBox textBox1;

    private Button button2;

    private Button button1;

    private ComboBox comboBox2;
	private Label label3;

    public AddIPForm(int int_1) {
        int_0 = int_1;
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
        if (comboBox1.SelectedIndex == -1) {
            MessageBox.Show("请选择启用或者禁用！");
            return;
        }
        if (comboBox2.SelectedIndex == -1) {
            MessageBox.Show("请选择添加类型！");
            return;
        }
        if (textBox1.Text == "") {
            MessageBox.Show("Info内容不能为空！");
            return;
        }
        if (comboBox2.SelectedIndex == 0 && textBox1.Text.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries).Length != 4) {
            MessageBox.Show("Info内容不是正确IP！");
            return;
        }
        if (int_0 == 0) {
            if (Class5.smethod_95((byte)comboBox1.SelectedIndex, (byte)comboBox2.SelectedIndex, textBox1.Text) != 1) {
                MessageBox.Show("添加失败！");
                return;
            }
            var struct33_ = default(Struct33);
            struct33_.byte_0 = (byte)comboBox1.SelectedIndex;
            struct33_.string_1 = textBox1.Text;
            struct33_.string_0 = DateTime.Now.ToString();
            if (!Class13.smethod_3(struct33_)) {
                MessageBox.Show("ManageAddIPList 添加失败！");
                return;
            }
        }
        else if (int_0 == 1 && Class5.smethod_99((byte)comboBox1.SelectedIndex, (byte)comboBox2.SelectedIndex, textBox1.Text) != 1) {
            MessageBox.Show("添加失败！");
            return;
        }
        Dispose();
    }
    private void AddIPForm_Load(object sender, EventArgs e)
    {

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIPForm));
        this.comboBox1 = new System.Windows.Forms.ComboBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.button2 = new System.Windows.Forms.Button();
        this.button1 = new System.Windows.Forms.Button();
        this.comboBox2 = new System.Windows.Forms.ComboBox();
        this.label3 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // comboBox1
        // 
        this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Items.AddRange(new object[] {
            "禁用",
            "启用"});
        this.comboBox1.Location = new System.Drawing.Point(65, 9);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new System.Drawing.Size(49, 20);
        this.comboBox1.TabIndex = 3;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(18, 12);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(41, 12);
        this.label1.TabIndex = 2;
        this.label1.Text = "服务：";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(207, 12);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(41, 12);
        this.label2.TabIndex = 4;
        this.label2.Text = "方式：";
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(242, 9);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(205, 21);
        this.textBox1.TabIndex = 5;
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(389, 36);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(58, 26);
        this.button2.TabIndex = 21;
        this.button2.Text = "取消";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(325, 36);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(58, 26);
        this.button1.TabIndex = 20;
        this.button1.Text = "确认";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // comboBox2
        // 
        this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBox2.FormattingEnabled = true;
        this.comboBox2.Items.AddRange(new object[] {
            "IP",
            "机器码"});
        this.comboBox2.Location = new System.Drawing.Point(152, 9);
        this.comboBox2.Name = "comboBox2";
        this.comboBox2.Size = new System.Drawing.Size(49, 20);
        this.comboBox2.TabIndex = 23;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(120, 12);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(41, 12);
        this.label3.TabIndex = 22;
        this.label3.Text = "类型：";
        // 
        // AddIPForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(458, 74);
        this.ControlBox = false;
        this.Controls.Add(this.comboBox2);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.comboBox1);
        this.Controls.Add(this.label1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.Name = "AddIPForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "添加方式";
        this.Load += new System.EventHandler(this.AddIPForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    private void button2_Click(object sender, EventArgs e) {
        Dispose();
    }


}
