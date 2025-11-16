using System;
using System.ComponentModel;
using System.Windows.Forms;

internal class DisabledChatForm : Form {
    private IContainer icontainer_0=null;

    private TextBox textBox1;

    private Button button1;

    private Button button2;

    private ListView listView1;

    private ColumnHeader columnHeader_0;
	private ColumnHeader columnHeader_1;

    public DisabledChatForm() {
        InitializeComponent();
    }

    private void DisabledChatForm_Load(object sender, EventArgs e) {
		method_0();
    }

    private void button1_Click(object sender, EventArgs e) {
        if (textBox1.Text == "") {
            MessageBox.Show("角色名称不能为空！");
            return;
        }
        if (Class5.smethod_84(textBox1.Text) != 1) {
            MessageBox.Show("添加失败！");
            return;
        }
        Class5.smethod_43();
        method_0();
    }
    private void method_0()
    {
        listView1.Items.Clear();
        for (int i = 0; i < Class5.list_12.Count; i++)
        {
            var listViewItem = new ListViewItem();
            listViewItem.Text = Class5.list_12[i].string_0;
            listViewItem.SubItems.Add(Class5.list_12[i].string_1);
            listView1.Items.Add(listViewItem);
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

    private void button2_Click(object sender, EventArgs e) {
        if (listView1.SelectedItems.Count > 0) {
            if (Class5.smethod_85(listView1.SelectedItems[0].SubItems[1].Text) != 1) {
                MessageBox.Show("删除失败！");
                return;
            }
            Class5.smethod_43();
            method_0();
        }
        else {
            MessageBox.Show("请选择一个角色");
        }
    }


    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisabledChatForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 21);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(294, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(294, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 21);
            this.button2.TabIndex = 4;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_0,
            this.columnHeader_1});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 453);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_0
            // 
            this.columnHeader_0.Text = "时间";
            this.columnHeader_0.Width = 120;
            // 
            // columnHeader_1
            // 
            this.columnHeader_1.Text = "角色名";
            this.columnHeader_1.Width = 120;
            // 
            // DisabledChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 494);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DisabledChatForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "禁止玩家发言";
            this.Load += new System.EventHandler(this.DisabledChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
