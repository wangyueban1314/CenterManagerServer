using System;
using System.ComponentModel;
using System.Windows.Forms;

internal class AedSpawnGameMonsterForm : Form {
    private int int_0;

    private byte byte_0;

    private byte byte_1 = 1;

    private string string_0 = "12:00:00";

    private string string_1 = "MOB_CH_TIGER,24744,1035,-10.29057,1367,1";

    private IContainer icontainer_0=null;

    private Label label2;

    private ComboBox comboBox1;

    private Label label1;

    private RadioButton radioButton1;

    private RadioButton radioButton2;

    private GroupBox groupBox2;

    private Label label9;

    private TextBox textBox6;

    private Label label8;

    private TextBox textBox5;

    private Label label7;

    private Label label6;

    private Label label5;

    private TextBox textBox4;

    private TextBox textBox3;

    private TextBox textBox2;

    private TextBox textBox1;

    private Label label3;

    private Button button2;

    private Button button1;

    private TextBox textBox7;
	private Label label4;

    public AedSpawnGameMonsterForm() {
        InitializeComponent();
    }

    public AedSpawnGameMonsterForm(byte byte_2, int int_1, byte byte_3, string string_2, string string_3) {
        int_0 = int_1;
        byte_0 = byte_2;
        byte_1 = byte_3;
        string_0 = string_2;
        string_1 = string_3;
        InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox5.Text == "")
        {
            MessageBox.Show("怪物代码未设置!");
            return;
        }
        if (textBox6.Text == "")
        {
            MessageBox.Show("怪物数量未设置!");
            return;
        }
        if (textBox1.Text == "")
        {
            MessageBox.Show("RegionID 未设置!");
            return;
        }
        if (textBox2.Text == "")
        {
            MessageBox.Show("PosX 未设置!");
            return;
        }
        if (textBox3.Text == "")
        {
            MessageBox.Show("PosY 未设置!");
            return;
        }
        if (textBox4.Text == "")
        {
            MessageBox.Show("PosZ 未设置!");
            return;
        }
        byte_0 = (byte)comboBox1.SelectedIndex;
        if (radioButton1.Checked)
        {
            byte_1 = 1;
        }
        if (radioButton2.Checked)
        {
            byte_1 = 2;
        }
        if (radioButton2.Checked)
        {
            string[] array = textBox7.Text.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++)
            {
                if (!TimeSpan.TryParse(array[i], out var _))
                {
                    MessageBox.Show("刷新时间设置错误!");
                    return;
                }
            }
        }
        if (radioButton1.Checked && !TimeSpan.TryParse(textBox7.Text, out var _))
        {
            MessageBox.Show("刷新时间设置错误!");
            return;
        }
        string_0 = textBox7.Text;
        string_1 = textBox5.Text + "," + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + "," + textBox6.Text;
        if (int_0 > 0)
        {
            if (Class5.smethod_82(int_0, byte_0, byte_1, string_0.ToString(), string_1) != 1)
            {
                MessageBox.Show("编辑怪物信息失败!");
                return;
            }
        }
        else if (Class5.smethod_81(byte_0, byte_1, string_0.ToString(), string_1) != 1)
        {
            MessageBox.Show("添加怪物信息失败!");
            return;
        }
        Dispose();
    }

    private void button2_Click(object sender, EventArgs e)
    {
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
    private void AedSpawnGameMonsterForm_Load(object sender, EventArgs e) {
		comboBox1.SelectedIndex = byte_0;
        if (byte_1 == 1) {
            radioButton2.Checked = false;
            radioButton1.Checked = true;
        }
        else {
            radioButton2.Checked = true;
            radioButton1.Checked = false;
        }
        textBox7.Text = string_0.ToString();
        if (string_1.Length != 0) {
            string[] array = string_1.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
            if (array != null && array.Length == 6) {
                textBox5.Text = array[0];
                textBox1.Text = array[1];
                textBox2.Text = array[2];
                textBox3.Text = array[3];
                textBox4.Text = array[4];
                textBox6.Text = array[5];
            }
        }
    }



    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AedSpawnGameMonsterForm));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "刷出时间：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "禁用",
            "启用"});
            this.comboBox1.Location = new System.Drawing.Point(79, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "启用状态：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(338, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "定时刷新";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(239, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "随机刷新";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(4, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 127);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(79, 39);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(330, 21);
            this.textBox7.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "数量：";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(79, 66);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(154, 21);
            this.textBox6.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "怪物代码：";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(330, 21);
            this.textBox5.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "坐标Z:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "坐标Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "坐标X:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(488, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(488, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(488, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "地图ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 27);
            this.button2.TabIndex = 20;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "提示:当设定为随机刷新时,刷出时间可以用,号分隔为多个时间";
            // 
            // AedSpawnGameMonsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 160);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AedSpawnGameMonsterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置信息";
            this.Load += new System.EventHandler(this.AedSpawnGameMonsterForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
