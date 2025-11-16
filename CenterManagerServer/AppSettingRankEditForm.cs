using System;
using System.ComponentModel;
using System.Windows.Forms;

internal class AppSettingRankEditForm : Form {
    internal int int_0;

    internal int int_1;

    internal string string_0 = "";

    private IContainer icontainer_0=null;

    private ListView listView1;

    private ColumnHeader columnHeader_0;

    private ColumnHeader columnHeader_1;

    private Button button1;

    private Button button2;
	private Button button3;

    private bool method_0(string string_1) {
        try {
            string[] array = string_1.Split(new string[1] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            if (array != null && array.Length != 0) {
                for (int i = 0; i < array.Length; i++) {
                    string[] array2 = array[i].Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (array2 != null && array2.Length == 2) {
                        var listViewItem = new ListViewItem();
                        listViewItem.Text = array2[0];
                        listViewItem.SubItems.Add(array2[1]);
                        listView1.Items.Add(listViewItem);
                    }
                }
            }
            return true;
        }
        catch {
            return false;
        }
    }

    private bool method_1(out string string_1) {
        string_1 = "";
        try {
            if (listView1.Items.Count == 0) {
                return true;
            }
            for (int i = 0; i < listView1.Items.Count; i++) {
                string_1 = string_1 + listView1.Items[i].SubItems[0].Text + " " + listView1.Items[i].SubItems[1].Text + "/";
            }
            if (string_1 == "") {
                return false;
            }
            return true;
        }
        catch {
            return false;
        }
    }

    public AppSettingRankEditForm() {
        InitializeComponent();
    }

    private void AppSettingRankEditForm_Load(object sender, EventArgs e) {
		method_0(string_0);
    }
    private void button2_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count > 0)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        else
        {
            MessageBox.Show("请选择一条命令信息");
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (listView1.Items.Count == 0)
        {
            MessageBox.Show("小助手信息不能为空！");
        }
        else if (!method_1(out string string_))
        {
            MessageBox.Show("小助手信息读取失败！");
        }
        else if (Class5.smethod_90(int_1, string_) != 1)
        {
            MessageBox.Show("小助手信息编辑失败！");
        }
        else
        {
            Dispose();
        }
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
        var appSettingRankAddForm = new AppSettingRankAddForm();
        appSettingRankAddForm.ShowDialog();
        string text = appSettingRankAddForm.string_0;
        string string_ = appSettingRankAddForm.string_1;
        if (text != "" && string_ != "") {
            var listViewItem = new ListViewItem();
            listViewItem.Text = text;
            listViewItem.SubItems.Add(string_);
            listView1.Items.Add(listViewItem);
        }
    }



    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingRankEditForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_0,
            this.columnHeader_1});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(507, 558);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_0
            // 
            this.columnHeader_0.Text = "命令信息";
            this.columnHeader_0.Width = 200;
            // 
            // columnHeader_1
            // 
            this.columnHeader_1.Text = "命令说明";
            this.columnHeader_1.Width = 270;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(434, 567);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "确认";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AppSettingRankEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 596);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppSettingRankEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑小助手命令信息";
            this.Load += new System.EventHandler(this.AppSettingRankEditForm_Load);
            this.ResumeLayout(false);

    }
}
