using System;
using System.ComponentModel;
using System.Windows.Forms;

internal class AddAlchemyRewardForm : Form {
    private IContainer icontainer_0=null;

    private Button button1;

    private TextBox textBox1;
	private Label label1;

    public AddAlchemyRewardForm() {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
        if (textBox1.Text == "") {
            MessageBox.Show("代码区不能为空!");
            return;
        }
        try {
            string text = "";
            string[] array = textBox1.Text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            if (array == null) {
                MessageBox.Show("代码区格式不正确!");
                return;
            }
            if (array.Length == 0) {
                MessageBox.Show("代码区格式不正确!");
                return;
            }
            for (int i = 0; i < array.Length; i++) {
                string[] array2 = array[i].Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (array2 == null) {
                    continue;
                }
                if (array2.Length == 4) {
                    if (array2[0].Substring(0, 5) == "ITEM_") {
						switch (Class5.smethod_21(array2[0], out int int_)) {
							case 1: {
								if (int.TryParse(array2[2], out int result)) {
									if (result <= 250) {
										if (int.TryParse(array2[3], out result)) {
											if (Class5.smethod_108(int_)) {
												MessageBox.Show("该代码已经添加无法重复添加,错误代码：" + array[i]);
												return;
											}
											text = ((!(text == "")) ? (text + ",('1', '" + int_ + "', '" + array2[0] + "', '" + array2[1] + "', '" + array2[2] + "', '" + array2[3] + "')") : ("INSERT INTO [dbo].[_RefAlchemyReward] ([Service], [ID], [CodeName128], [ObjName128], [OptLevel], [silk_own]) VALUES ('1', '" + int_ + "', '" + array2[0] + "', '" + array2[1] + "', '" + array2[2] + "', '" + array2[3] + "')"));
											break;
										}
										MessageBox.Show("金珠数量不正确,错误代码：" + array[i]);
										return;
									}
									MessageBox.Show("炼金等级不能超过250,错误代码：" + array[i]);
									return;
								}
								MessageBox.Show("炼金等级不正确,错误代码：" + array[i]);
								return;
							}
							case 2:
								MessageBox.Show("物品代码不存在,错误代码：" + array[i]);
								return;
							case 3:
								MessageBox.Show("物品代码已存在但没有开放,错误代码：" + array[i]);
								return;
							default:
								MessageBox.Show("检测物品代码失败,错误代码：" + array[i]);
								return;
						}
						continue;
                    }
                    MessageBox.Show("物品代码不正确,错误代码：" + array[i]);
                    return;
                }
                MessageBox.Show("代码格式不正确,错误代码：" + array[i]);
                return;
            }
            if (!Class5.smethod_111(text)) {
                MessageBox.Show("导入失败!");
                return;
            }
            MessageBox.Show("导入完成,请刷新查看!");
        }
        catch {
            MessageBox.Show("导入代码失败!");
            return;
        }
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlchemyRewardForm));
        this.button1 = new System.Windows.Forms.Button();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.button1.Location = new System.Drawing.Point(382, 465);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 23);
        this.button1.TabIndex = 5;
        this.button1.Text = "添加";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // textBox1
        // 
        this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.textBox1.Location = new System.Drawing.Point(3, 2);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textBox1.Size = new System.Drawing.Size(454, 457);
        this.textBox1.TabIndex = 4;
        // 
        // label1
        // 
        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 470);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(359, 12);
        this.label1.TabIndex = 3;
        this.label1.Text = "添加格式:物品代码+空格+物品名称+空格+炼金等级+空格+金珠数量";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // AddAlchemyRewardForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(461, 496);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.label1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MinimizeBox = false;
        this.Name = "AddAlchemyRewardForm";
        this.ShowIcon = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "添加炼金奖励";
        this.Load += new System.EventHandler(this.AddAlchemyRewardForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    private void AddAlchemyRewardForm_Load(object sender, EventArgs e) {

	}

}
