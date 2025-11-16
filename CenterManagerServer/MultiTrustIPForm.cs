using System;
using System.ComponentModel;
using System.Windows.Forms;

internal class MultiTrustIPForm : Form {
    private IContainer icontainer_0=null;

    private Button button13;

    private Button button12;

    private Button button10;

    private ListView listView3;

    private ColumnHeader columnHeader_0;

    private ColumnHeader columnHeader_1;

    private ColumnHeader columnHeader_2;
	private ColumnHeader columnHeader_3;

    public MultiTrustIPForm() {
        InitializeComponent();
    }
    private void button10_Click(object sender, EventArgs e)
    {
        if (listView3.SelectedItems.Count > 0)
        {
            if (Class5.smethod_101(byte.Parse(listView3.SelectedItems[0].SubItems[2].Text), listView3.SelectedItems[0].SubItems[3].Text) != 1)
            {
                MessageBox.Show("删除失败！");
                return;
            }
            Class5.smethod_44();
            method_0();
        }
        else
        {
            MessageBox.Show("请选择一条IP");
        }
    }



    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiTrustIPForm));
        this.button13 = new System.Windows.Forms.Button();
        this.button12 = new System.Windows.Forms.Button();
        this.button10 = new System.Windows.Forms.Button();
        this.listView3 = new System.Windows.Forms.ListView();
        this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.SuspendLayout();
        // 
        // button13
        // 
        this.button13.Location = new System.Drawing.Point(83, 455);
        this.button13.Name = "button13";
        this.button13.Size = new System.Drawing.Size(75, 23);
        this.button13.TabIndex = 15;
        this.button13.Text = "编辑";
        this.button13.UseVisualStyleBackColor = true;
        this.button13.Click += new System.EventHandler(this.button13_Click);
        // 
        // button12
        // 
        this.button12.Location = new System.Drawing.Point(2, 455);
        this.button12.Name = "button12";
        this.button12.Size = new System.Drawing.Size(75, 23);
        this.button12.TabIndex = 14;
        this.button12.Text = "添加";
        this.button12.UseVisualStyleBackColor = true;
        this.button12.Click += new System.EventHandler(this.button12_Click);
        // 
        // button10
        // 
        this.button10.Location = new System.Drawing.Point(341, 455);
        this.button10.Name = "button10";
        this.button10.Size = new System.Drawing.Size(75, 23);
        this.button10.TabIndex = 13;
        this.button10.Text = "删除";
        this.button10.UseVisualStyleBackColor = true;
        this.button10.Click += new System.EventHandler(this.button10_Click);
        // 
        // listView3
        // 
        this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2,
            this.columnHeader_3});
        this.listView3.FullRowSelect = true;
        this.listView3.HideSelection = false;
        this.listView3.Location = new System.Drawing.Point(2, 2);
        this.listView3.Name = "listView3";
        this.listView3.Size = new System.Drawing.Size(414, 447);
        this.listView3.TabIndex = 12;
        this.listView3.UseCompatibleStateImageBehavior = false;
        this.listView3.View = System.Windows.Forms.View.Details;
        // 
        // columnHeader_0
        // 
        this.columnHeader_0.Text = "服务";
        // 
        // columnHeader_1
        // 
        this.columnHeader_1.Text = "时间";
        this.columnHeader_1.Width = 120;
        // 
        // columnHeader_2
        // 
        this.columnHeader_2.Text = "类型";
        // 
        // columnHeader_3
        // 
        this.columnHeader_3.Text = "服务";
        this.columnHeader_3.Width = 135;
        // 
        // MultiTrustIPForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(419, 484);
        this.Controls.Add(this.button13);
        this.Controls.Add(this.button12);
        this.Controls.Add(this.button10);
        this.Controls.Add(this.listView3);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "MultiTrustIPForm";
        this.ShowIcon = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "多开信任IP";
        this.Load += new System.EventHandler(this.MultiTrustIPForm_Load);
        this.ResumeLayout(false);

    }
    private void button12_Click(object sender, EventArgs e) {
        new AddIPForm(1).ShowDialog();
        Class5.smethod_44();
        method_0();
    }
    private void method_0()
    {
        listView3.Items.Clear();
        for (int i = 0; i < Class5.list_10.Count; i++)
        {
            var listViewItem = new ListViewItem();
            listViewItem.Text = Class5.list_10[i].byte_0.ToString();
            listViewItem.SubItems.Add(Class5.list_10[i].string_0);
            listViewItem.SubItems.Add(Class5.list_10[i].byte_1.ToString());
            listViewItem.SubItems.Add(Class5.list_10[i].string_1);
            listView3.Items.Add(listViewItem);
        }
    }

    private void MultiTrustIPForm_Load(object sender, EventArgs e)
    {
        method_0();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && icontainer_0 != null)
        {
            icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }
    private void button13_Click(object sender, EventArgs e) {
        if (listView3.SelectedItems.Count > 0) {
            var updIPForm = new UpdIPForm(1);
            updIPForm.byte_0 = Convert.ToByte(listView3.SelectedItems[0].SubItems[0].Text);
            updIPForm.byte_1 = Convert.ToByte(listView3.SelectedItems[0].SubItems[2].Text);
            updIPForm.string_0 = listView3.SelectedItems[0].SubItems[3].Text;
            updIPForm.ShowDialog();
            Class5.smethod_44();
            method_0();
        }
        else {
            MessageBox.Show("请选择一条IP");
        }
    }


}
