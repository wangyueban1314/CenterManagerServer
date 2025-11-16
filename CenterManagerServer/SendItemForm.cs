using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

internal class SendItemForm : Form {
    internal List<Struct29> list_0 = new List<Struct29>();

    private int int_0;

    private SortOrder sortOrder_0;

    private IContainer icontainer_0=null;

    private ListView listView1;

    private ColumnHeader columnHeader_0;

    private ColumnHeader columnHeader_1;

    private ColumnHeader columnHeader_2;

    private ColumnHeader columnHeader_3;

    private CheckBox checkBox1;

    private Button button1;

    private TextBox textBox2;

    private CheckBox checkBox2;

    private CheckBox checkBox3;

    private TextBox textBox1;

    private TextBox textBox3;

    private TabControl tabControl1;

    private TabPage tabPage1;

    private TabControl tabControl2;

    private TabPage tabPage2;

    private TabControl tabControl3;

    private TabPage tabPage3;

    private Label label1;

    private ColumnHeader columnHeader_4;
	private CheckBox checkBox4;

    public SendItemForm() {
        InitializeComponent();
    }
    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        for (int i = 0; i < listView1.Items.Count; i++)
        {
            listView1.Items[i].Checked = checkBox1.Checked;
        }
    }

    private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        try
        {
            listView1.ListViewItemSorter = new Class42(int_0, sortOrder_0);
            var listView = sender as ListView;
            if (e.Column == (listView.ListViewItemSorter as Class42).method_2())
            {
                if ((listView.ListViewItemSorter as Class42).method_4() == SortOrder.Ascending)
                {
                    sortOrder_0 = SortOrder.Descending;
                    (listView.ListViewItemSorter as Class42).method_3(SortOrder.Descending);
                }
                else
                {
                    sortOrder_0 = SortOrder.Ascending;
                    (listView.ListViewItemSorter as Class42).method_3(SortOrder.Ascending);
                }
            }
            else
            {
                int_0 = e.Column;
                sortOrder_0 = SortOrder.Ascending;
                (listView.ListViewItemSorter as Class42).method_1(e.Column);
                (listView.ListViewItemSorter as Class42).method_3(SortOrder.Ascending);
            }
            ((ListView)sender).Sort();
            listView1.ListViewItemSorter = null;
        }
        catch
        {
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (!checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("请选择奖励类型！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (!checkBox2.Checked)
            {
                goto IL_00c7;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("请填写金币数量！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            int num = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Checked)
                {
                    num++;
                }
            }
            if (num >= 1)
            {
                goto IL_00c7;
            }
            MessageBox.Show("请选择您要发送金珠的玩家！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            goto end_IL_0001;
        IL_0233:
            try
            {
                var list = new List<string>();
                if (list_0.Count > 0)
                {
                    for (int j = 0; j < list_0.Count; j++)
                    {
                        var @struct = list_0[j];
                        if (@struct.byte_0 != 2)
                        {
                            continue;
                        }
                        for (int k = 0; k < listView1.Items.Count; k++)
                        {
                            if (!listView1.Items[k].Checked || !(listView1.Items[k].SubItems[1].Text == @struct.string_1))
                            {
                                continue;
                            }
                            bool flag = false;
                            for (int l = 0; l < list.Count; l++)
                            {
                                if (list[l] == listView1.Items[k].SubItems[3].Text)
                                {
                                    flag = true;
                                }
                            }
                            if (flag)
                            {
                                textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 发送状态：该机器码已跳过" + Environment.NewLine;
                                continue;
                            }
                            if (checkBox4.Checked)
                            {
                                list.Add(listView1.Items[k].SubItems[3].Text);
                            }
                            if (checkBox2.Checked)
                            {
                                if (Class5.smethod_12(@struct.string_1, 1, "GOLD", "金币", long.Parse(textBox1.Text), 0, 0) != 1)
                                {
                                    textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 获得金币:" + textBox1.Text + " 发送状态：失败,数据库表更新失败" + Environment.NewLine;
                                }
                                else if (!Class9.smethod_27(@struct.intptr_0, Class8.string_48[0] + @struct.string_1 + Class8.string_48[1] + textBox1.Text + Class8.string_48[2]))
                                {
                                    textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 获得金币:" + textBox1.Text + " 发送状态：失败,更新信息发送失败" + Environment.NewLine;
                                }
                                else
                                {
                                    textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 获得金币:" + textBox1.Text + " 发送状态：成功" + Environment.NewLine;
                                }
                            }
                            if (!checkBox3.Checked)
                            {
                                continue;
                            }
                            string[] array = textBox3.Text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                            for (int m = 0; m < array.Length; m++)
                            {
                                string[] array2 = array[m].Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
                                if (Class5.smethod_12(@struct.string_1, 0, array2[1], array2[0], long.Parse(array2[2]), byte.Parse(array2[3]), 0) != 1)
                                {
                                    textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 获得物品:" + array2[0] + " 发送状态：失败,数据库表更新失败" + Environment.NewLine;
                                }
                                else if (!Class9.smethod_27(@struct.intptr_0, Class8.string_47[0] + @struct.string_1 + Class8.string_47[1] + array2[0] + Class8.string_47[2] + array2[2] + Class8.string_47[3]))
                                {
                                    textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 获得物品:" + array2[0] + " 发送状态：失败,更新信息发送失败" + Environment.NewLine;
                                }
                                else
                                {
                                    textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 获得物品:" + array2[0] + " 发送状态：成功" + Environment.NewLine;
                                }
                            }
                        }
                    }
                }
                else
                {
                    textBox2.Text = textBox2.Text + "没有玩家可发送奖励" + Environment.NewLine;
                }
            }
            catch
            {
                textBox2.Text = textBox2.Text + "发送奖励异常" + Environment.NewLine;
            }
            goto end_IL_0001;
        IL_00c7:
            if (!checkBox3.Checked)
            {
                goto IL_0233;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("请填写物品信息！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            string[] array3 = textBox3.Text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            if (array3 == null)
            {
                MessageBox.Show("请填写正确的物品信息！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (array3.Length == 0)
            {
                MessageBox.Show("请填写正确的物品信息！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            for (int n = 0; n < array3.Length; n++)
            {
                string[] array4 = array3[n].Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (array4 != null)
                {
                    if (array4.Length == 4)
                    {
                        switch (Class5.smethod_21(array4[1], out int num2))
                        {
                            case 1:
                                break;
                            case 2:
                                MessageBox.Show("物品代码不存在！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                return;
                            case 3:
                                MessageBox.Show("物品代码没有开放！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                return;
                            default:
                                MessageBox.Show("物品代码不正确！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                return;
                        }
                        continue;
                    }
                    MessageBox.Show("物品信息格式不正确！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                MessageBox.Show("物品信息格式不正确！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            goto IL_0233;
        end_IL_0001:;
        }
        catch
        {
        }
    }
    private void SendItemForm_Load(object sender, EventArgs e) {
		try {
            if (list_0.Count > 0) {
                listView1.Items.Clear();
                for (int i = 0; i < list_0.Count; i++) {
                    var @struct = list_0[i];
                    string text = "";
                    if (@struct.byte_0 == 2) {
                        text = "进入游戏";
                        var listViewItem = new ListViewItem();
                        listViewItem.Text = @struct.string_0;
                        listViewItem.SubItems.Add(@struct.string_1);
                        listViewItem.SubItems.Add(@struct.string_4);
                        listViewItem.SubItems.Add(@struct.string_3);
                        listViewItem.SubItems.Add(text);
                        listView1.Items.Add(listViewItem);
                    }
                }
            }
            else {
                listView1.Items.Clear();
            }
        }
        catch {
            listView1.Items.Clear();
        }
    }



    protected override void Dispose(bool disposing) {
        if (disposing && icontainer_0 != null) {
            icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendItemForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2,
            this.columnHeader_3,
            this.columnHeader_4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(679, 320);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader_0
            // 
            this.columnHeader_0.Text = "账号";
            this.columnHeader_0.Width = 120;
            // 
            // columnHeader_1
            // 
            this.columnHeader_1.Text = "角色名";
            this.columnHeader_1.Width = 160;
            // 
            // columnHeader_2
            // 
            this.columnHeader_2.Text = "IP";
            this.columnHeader_2.Width = 120;
            // 
            // columnHeader_3
            // 
            this.columnHeader_3.Text = "机器码";
            this.columnHeader_3.Width = 160;
            // 
            // columnHeader_4
            // 
            this.columnHeader_4.Text = "状态";
            this.columnHeader_4.Width = 80;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(626, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "全部玩家";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(620, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "确认发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(7, 626);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(692, 58);
            this.textBox2.TabIndex = 13;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(626, 564);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "发送金币";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(626, 358);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 16);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "发送物品";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(679, 21);
            this.textBox1.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(3, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(679, 162);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "HP恢复 ITEM_ETC_HP_POTION_05 5 0";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 352);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "在线信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(7, 358);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(696, 199);
            this.tabControl2.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 173);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "物品信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Location = new System.Drawing.Point(7, 563);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(696, 57);
            this.tabControl3.TabIndex = 22;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(688, 31);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "金币信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(91, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "物品信息格式：物品名称+空格+物品代码+空格+数量+空格+等级";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(517, 5);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(96, 16);
            this.checkBox4.TabIndex = 23;
            this.checkBox4.Text = "按机器码发送";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // SendItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 726);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendItemForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发送物品";
            this.Load += new System.EventHandler(this.SendItemForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
