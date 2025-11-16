using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

internal class SendSilkForm : Form {
    internal List<Struct29> list_0 = new List<Struct29>();

    private int int_0;

    private SortOrder sortOrder_0;

    private IContainer icontainer_0=null;

    private ListView listView1;

    private ColumnHeader columnHeader_0;

    private ColumnHeader columnHeader_1;

    private ColumnHeader columnHeader_2;

    private ColumnHeader columnHeader_3;

    private Button button1;

    private Label label1;

    private TextBox textBox1;

    private CheckBox checkBox1;

    private TextBox textBox2;

    private ColumnHeader columnHeader_4;
	private CheckBox checkBox2;

    public SendSilkForm() {
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
    private void SendSilkForm_Load(object sender, EventArgs e) {
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

    private void button1_Click(object sender, EventArgs e) {
        try {
            if (textBox1.Text == "") {
                MessageBox.Show("请填写金珠数量！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            int num = 0;
            for (int i = 0; i < listView1.Items.Count; i++) {
                if (listView1.Items[i].Checked) {
                    num++;
                }
            }
            if (num < 1) {
                MessageBox.Show("请选择您要发送金珠的玩家！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            int num2 = int.Parse(textBox1.Text);
            try {
                var list = new List<string>();
                if (list_0.Count > 0) {
                    for (int j = 0; j < list_0.Count; j++) {
                        var @struct = list_0[j];
                        if (@struct.byte_0 != 2) {
                            continue;
                        }
                        for (int k = 0; k < listView1.Items.Count; k++) {
                            if (!listView1.Items[k].Checked || !(listView1.Items[k].SubItems[1].Text == @struct.string_1)) {
                                continue;
                            }
                            bool flag = false;
                            for (int l = 0; l < list.Count; l++) {
                                if (list[l] == listView1.Items[k].SubItems[3].Text) {
                                    flag = true;
                                }
                            }
                            if (flag) {
                                textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 发送状态：该机器码已跳过" + Environment.NewLine;
                                continue;
                            }
                            if (checkBox2.Checked) {
                                list.Add(listView1.Items[k].SubItems[3].Text);
                            }
                            int num3 = Class5.smethod_54(@struct.string_1, num2);
                            if (num3 > 0) {
                                if (Class5.smethod_63(@struct.string_0, @struct.string_1, 5, num2, num3) < 1) {
                                    textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 获得金珠:" + num2 + " 发送状态：失败,数据库表更新失败" + Environment.NewLine;
                                }
                                else if (!Class9.smethod_21(@struct.intptr_0, num3)) {
                                    textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 获得金珠:" + num2 + " 发送状态：失败,更新信息发送失败" + Environment.NewLine;
                                }
                                else if (!Class9.smethod_27(@struct.intptr_0, Class8.string_14[0] + @struct.string_1 + Class8.string_14[1] + num2 + Class8.string_14[2])) {
                                    textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 获得金珠:" + num2 + " 发送状态：失败,更新信息发送失败" + Environment.NewLine;
                                }
                                else {
                                    textBox2.Text = textBox2.Text + "账号：" + @struct.string_0 + " 角色：" + @struct.string_1 + " 获得金珠:" + num2 + " 发送状态：成功" + Environment.NewLine;
                                }
                            }
                        }
                    }
                }
                else {
                    textBox2.Text = textBox2.Text + "没有玩家可发送金珠奖励" + Environment.NewLine;
                }
            }
            catch {
                textBox2.Text = textBox2.Text + "发送金珠异常" + Environment.NewLine;
            }
        }
        catch {
            textBox2.Text = textBox2.Text + "发送金珠出错" + Environment.NewLine;
        }
    }



    protected override void Dispose(bool disposing) {
        if (disposing && icontainer_0 != null) {
            icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendSilkForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
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
            this.listView1.Location = new System.Drawing.Point(4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(675, 520);
            this.listView1.TabIndex = 1;
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
            this.columnHeader_1.Text = "角色";
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(600, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "确认发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "金珠数量：";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(494, 530);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 532);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "全部玩家";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(4, 558);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(675, 182);
            this.textBox2.TabIndex = 9;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(82, 532);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 16);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "按机器码发送";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // SendSilkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 745);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendSilkForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发送金珠";
            this.Load += new System.EventHandler(this.SendSilkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
