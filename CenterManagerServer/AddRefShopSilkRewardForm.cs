using System;
using System.ComponentModel;
using System.Windows.Forms;

internal class AddRefShopSilkRewardForm : Form {
    private IContainer icontainer_0=null;

    private TextBox textBox2;

    private Label label3;

    private Button button2;

    private Button button1;

    private TextBox textBox1;

    private Label label2;

    private TextBox textBox3;
	private Label label1;

    public AddRefShopSilkRewardForm() {
        InitializeComponent();
    }
    private void button2_Click(object sender, EventArgs e)
    {
        Dispose();
    }

    private void AddRefShopSilkRewardForm_Load(object sender, EventArgs e)
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
    private void button1_Click(object sender, EventArgs e) {
        if (textBox1.Text == "") {
            MessageBox.Show("名次不能为空!");
        }
        else if (textBox3.Text == "") {
            MessageBox.Show("消费金珠不能为空");
        }
        else if (textBox2.Text == "") {
            MessageBox.Show("奖励金珠不能为空");
        }
        else if (Class5.smethod_105(textBox1.Text)) {
            MessageBox.Show("该消费名次不能重复添加！");
        }
        else if (!Class5.smethod_127("1", textBox1.Text, textBox3.Text, textBox2.Text)) {
            MessageBox.Show("添加失败 SQL_Add_RefShopSilkReward");
        }
        else {
            Dispose();
        }
    }



    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRefShopSilkRewardForm));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 21);
            this.textBox2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "奖励金珠：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 26);
            this.button2.TabIndex = 33;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 26);
            this.button1.TabIndex = 32;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 21);
            this.textBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "消费级别：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 21);
            this.textBox3.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "消费数额：";
            // 
            // AddRefShopSilkRewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 66);
            this.ControlBox = false;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddRefShopSilkRewardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加累计消费奖励";
            this.Load += new System.EventHandler(this.AddRefShopSilkRewardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
