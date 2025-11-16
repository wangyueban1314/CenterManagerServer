using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

internal class SettingForm : Form {
    private IContainer icontainer_0=null;

    private TabControl tabControl1;

    private TabPage tabPage1;

    private Label label1;

    private TabPage tabPage2;

    private TextBox textBox2;

    private Label label2;

    private CheckBox checkBox1;

    private TextBox textBox1;

    private TabPage tabPage3;

    private Button button1;

    private Button button2;

    private TextBox textBox4;

    private Label label4;

    private TextBox textBox3;

    private Label label3;

    private TextBox textBox8;

    private TextBox textBox7;

    private Label label8;

    private Label label7;

    private TextBox textBox5;

    private Label label5;

    private TextBox textBox6;

    private Label label6;

    private TabPage tabPage7;

    private TextBox textBox14;

    private Label label14;

    private TextBox textBox13;

    private Label label13;

    private TextBox textBox12;

    private Label label12;

    private TextBox textBox11;

    private Label label11;

    private TextBox textBox10;

    private Label label10;

    private TextBox textBox9;

    private Label label9;

    private TextBox textBox16;

    private TextBox textBox15;

    private Label label15;

    private Label label16;

    private TextBox textBox20;

    private Label label20;

    private TextBox textBox19;

    private Label label19;

    private TextBox textBox18;

    private Label label18;

    private TextBox textBox17;

    private Label label17;

    private Button button5;

    private Button button4;

    private Button button3;

    private ListView listView1;

    private ColumnHeader columnHeader_0;

    private ColumnHeader columnHeader_1;

    private ColumnHeader columnHeader_2;

    private GroupBox groupBox2;

    private Button button9;

    private Button button10;

    private Button button11;

    private ListView listView3;

    private ColumnHeader columnHeader_3;

    private ColumnHeader columnHeader_4;

    private ColumnHeader columnHeader_5;

    private GroupBox groupBox1;

    private ListView listView2;

    private ColumnHeader columnHeader_6;

    private ColumnHeader columnHeader_7;

    private ColumnHeader columnHeader_8;

    private Button button6;

    private Button button7;

    private Button button8;

    private ColumnHeader columnHeader_9;

    private GroupBox groupBox6;

    private GroupBox groupBox5;

    private GroupBox groupBox4;

    private GroupBox groupBox3;

    private Label label21;

    private TextBox textBox21;

    private Label label23;

    private TextBox textBox23;

    private Label label22;

    private TextBox textBox22;

    private GroupBox groupBox7;

    private Label label24;

    private TextBox textBox24;

    private GroupBox groupBox8;

    private TextBox textBox26;

    private Label label26;

    private TextBox textBox25;

    private Label label25;

    private TextBox textBox28;

    private Label label28;

    private CheckBox checkBox3;

    private CheckBox checkBox2;

    private TabPage tabPage4;

    private Button button14;

    private Button button13;

    private Button button12;

    private ListView listView4;

    private ColumnHeader columnHeader_10;

    private ColumnHeader columnHeader_11;

    private ColumnHeader columnHeader_12;

    private TextBox textBox31;

    private Label label31;

    private TextBox textBox30;

    private Label label30;

    private TextBox textBox29;

    private Label label29;

    private TextBox textBox27;

    private Label label27;

    private Button button15;

    private Button button16;

    private Button button17;

    private ListView listView5;

    private ColumnHeader columnHeader_13;

    private ColumnHeader columnHeader_14;

    private ColumnHeader columnHeader_15;

    private ColumnHeader columnHeader_16;

    private CheckBox checkBox4;

    private GroupBox groupBox14;

    private CheckBox checkBox5;

    private GroupBox groupBox13;

    private GroupBox groupBox12;

    private GroupBox groupBox11;

    private GroupBox groupBox10;

    private GroupBox groupBox9;

    private CheckBox checkBox6;

    private CheckBox checkBox7;

    private CheckBox checkBox8;

    private TextBox textBox32;

    private Label label32;

    private GroupBox groupBox16;

    private Label label34;

    private Label label33;

    private DateTimePicker dateTimePicker1;

    private DateTimePicker dateTimePicker2;

    private RadioButton radioButton3;

    private RadioButton radioButton2;
	private RadioButton radioButton1;

    public SettingForm() {
        InitializeComponent();
    }

    private void method_0() {
        try {
            Class8.bool_19 = checkBox1.Checked;
            Class8.int_3 = int.Parse(textBox6.Text);
            Class8.int_4 = int.Parse(textBox5.Text);
            Class8.byte_0 = byte.Parse(textBox7.Text);
            Class8.short_0 = short.Parse(textBox8.Text);
            Class8.int_1 = int.Parse(textBox3.Text);
            Class8.int_2 = int.Parse(textBox4.Text);
            Class8.byte_1 = byte.Parse(textBox9.Text);
            Class8.int_7 = int.Parse(textBox10.Text);
            Class8.int_8 = int.Parse(textBox11.Text);
            Class8.int_9 = int.Parse(textBox12.Text);
            Class8.int_10 = int.Parse(textBox13.Text);
            Class8.int_11 = int.Parse(textBox14.Text);
            Class8.ushort_0 = ushort.Parse(textBox15.Text);
            Class8.ushort_1 = ushort.Parse(textBox16.Text);
            Class8.ushort_8 = ushort.Parse(textBox32.Text);
            Class8.int_15 = int.Parse(textBox17.Text);
            Class8.int_16 = int.Parse(textBox18.Text);
            Class8.string_29 = textBox19.Text;
            Class8.int_17 = int.Parse(textBox20.Text);
            Class8.ushort_14 = ushort.Parse(textBox21.Text);
            Class8.ushort_10 = ushort.Parse(textBox22.Text);
            Class8.ushort_11 = ushort.Parse(textBox23.Text);
            Class8.byte_2 = byte.Parse(textBox24.Text);
            Class8.int_19 = int.Parse(textBox25.Text);
            Class8.byte_3 = byte.Parse(textBox26.Text);
            Class8.int_20 = int.Parse(textBox28.Text);
            Class8.bool_28 = checkBox3.Checked;
            Class8.bool_29 = checkBox2.Checked;
            Class8.byte_5 = byte.Parse(textBox30.Text);
            Class8.byte_6 = byte.Parse(textBox27.Text);
            Class8.byte_7 = byte.Parse(textBox29.Text);
            Class8.byte_8 = byte.Parse(textBox31.Text);
            Class8.bool_34 = checkBox4.Checked;
            Class8.bool_36 = checkBox5.Checked;
            Class8.bool_50 = checkBox6.Checked;
            Class8.bool_54 = checkBox7.Checked;
            Class8.bool_56 = checkBox8.Checked;
            Class8.string_59 = dateTimePicker1.Value.ToString("HH:mm:ss");
            Class8.string_60 = dateTimePicker2.Value.ToString("HH:mm:ss");
			/*
            if (radioButton3.Checked) {
                Class8.byte_9 = 0;
            }
            else if (radioButton1.Checked) {
                Class8.byte_9 = 2;
            }
            else if (radioButton2.Checked) {
                Class8.byte_9 = 1;
            }
			*/
            Class5.smethod_115(textBox1.Text, short.Parse(textBox2.Text), Class8.ushort_0, Class8.ushort_1, Class8.ushort_8);
            Class8.smethod_2();
        }
        catch {
            MessageBox.Show("保存失败！");
        }
    }

    private void SettingForm_Load(object sender, EventArgs e) {
		try {
            checkBox1.Checked = Class8.bool_19;
            textBox6.Text = Class8.int_3.ToString();
            textBox5.Text = Class8.int_4.ToString();
            textBox7.Text = Class8.byte_0.ToString();
            textBox8.Text = Class8.short_0.ToString();
            textBox3.Text = Class8.int_1.ToString();
            textBox4.Text = Class8.int_2.ToString();
            textBox9.Text = Class8.byte_1.ToString();
            textBox10.Text = Class8.int_7.ToString();
            textBox11.Text = Class8.int_8.ToString();
            textBox12.Text = Class8.int_9.ToString();
            textBox13.Text = Class8.int_10.ToString();
            textBox14.Text = Class8.int_11.ToString();
            textBox21.Text = Class8.ushort_14.ToString();
            textBox22.Text = Class8.ushort_10.ToString();
            textBox23.Text = Class8.ushort_11.ToString();
            textBox24.Text = Class8.byte_2.ToString();
            textBox25.Text = Class8.int_19.ToString();
            textBox26.Text = Class8.byte_3.ToString();
            textBox28.Text = Class8.int_20.ToString();
            checkBox2.Checked = Class8.bool_29;
            checkBox3.Checked = Class8.bool_28;
            textBox30.Text = Class8.byte_5.ToString();
            textBox27.Text = Class8.byte_6.ToString();
            textBox29.Text = Class8.byte_7.ToString();
            textBox31.Text = Class8.byte_8.ToString();
            checkBox4.Checked = Class8.bool_34;
            checkBox5.Checked = Class8.bool_36;
            checkBox6.Checked = Class8.bool_50;
            checkBox7.Checked = Class8.bool_54;
            checkBox8.Checked = Class8.bool_56;
			/*
            if (Class8.byte_9 == 0) {
                radioButton3.Checked = true;
            }
            else if (Class8.byte_9 == 1) {
                radioButton2.Checked = true;
            }
            else if (Class8.byte_9 == 2) {
                radioButton1.Checked = true;
            }
			*/
            var now = DateTime.Now;
            dateTimePicker1.Value = DateTime.Parse(now.ToString("yyyy-MM-dd") + " " + Class8.string_59);
            dateTimePicker2.Value = DateTime.Parse(now.ToString("yyyy-MM-dd") + " " + Class8.string_60);
			Class5.smethod_116(out byte byte_, out string string_, out string string_2, out string string_3, out string string_4, out string string_5, out short short_, out ushort ushort_, out ushort ushort_2, out ushort ushort_3);
			textBox1.Text = string_5;
            textBox2.Text = short_.ToString();
            textBox15.Text = Class8.ushort_0.ToString();
            textBox16.Text = Class8.ushort_1.ToString();
            textBox32.Text = Class8.ushort_8.ToString();
            textBox17.Text = Class8.int_15.ToString();
            textBox18.Text = Class8.int_16.ToString();
            textBox19.Text = Class8.string_29;
            textBox20.Text = Class8.int_17.ToString();
            method_1();
        }
        catch {
        }
    }
    private void method_3()
    {
        listView5.Items.Clear();
        var list_ = Class5.list_1;
        for (int i = 0; i < list_.Count; i++)
        {
            var listViewItem = new ListViewItem();
            listViewItem.Text = list_[i].string_0.ToString();
            listViewItem.SubItems.Add(list_[i].string_1.ToString());
            listViewItem.SubItems.Add(list_[i].byte_0.ToString());
            listViewItem.SubItems.Add(list_[i].int_2.ToString());
            listView5.Items.Add(listViewItem);
        }
    }

    private void method_4()
    {
        listView1.Items.Clear();
        var list_ = Class5.list_7;
        for (int i = 0; i < list_.Count; i++)
        {
            var listViewItem = new ListViewItem();
            listViewItem.Text = list_[i].int_0.ToString();
            listViewItem.SubItems.Add(list_[i].int_1.ToString());
            listViewItem.SubItems.Add(list_[i].int_2.ToString());
            listView1.Items.Add(listViewItem);
        }
    }

    private void method_5()
    {
        listView2.Items.Clear();
        var list_ = Class5.list_6;
        for (int i = 0; i < list_.Count; i++)
        {
            var listViewItem = new ListViewItem();
            listViewItem.Text = list_[i].int_0.ToString();
            listViewItem.SubItems.Add(list_[i].int_1.ToString());
            listViewItem.SubItems.Add(list_[i].int_2.ToString());
            listView2.Items.Add(listViewItem);
        }
    }

    private void method_6()
    {
        listView3.Items.Clear();
        var list_ = Class5.list_8;
        for (int i = 0; i < list_.Count; i++)
        {
            var listViewItem = new ListViewItem();
            listViewItem.Text = list_[i].int_0.ToString();
            listViewItem.SubItems.Add(list_[i].byte_0.ToString());
            listViewItem.SubItems.Add(list_[i].int_1.ToString());
            listViewItem.SubItems.Add(list_[i].int_2.ToString());
            listView3.Items.Add(listViewItem);
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        method_4();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        method_5();
    }
    private void button1_Click(object sender, EventArgs e) {
		if (!int.TryParse(textBox18.Text, out int result)) {
			MessageBox.Show("红包最小数额不对");
			return;
		}
		if (!int.TryParse(textBox17.Text, out int result2)) {
            MessageBox.Show("红包最大数额不对");
            return;
        }
        if (result2 < result) {
            MessageBox.Show("红包最小数额不对");
            return;
        }
        method_0();
        Dispose();
    }

    private void button2_Click(object sender, EventArgs e) {
        Dispose();
    }

    private void button3_Click(object sender, EventArgs e) {
        new AddRefLevelMaxRewardForm().ShowDialog();
        Class5.smethod_35();
        method_4();
    }

    private void button4_Click(object sender, EventArgs e) {
        if (listView1.SelectedItems.Count > 0) {
            if (!Class5.smethod_124(listView1.SelectedItems[0].SubItems[1].Text)) {
                MessageBox.Show("删除失败！");
                return;
            }
            Class5.smethod_35();
            method_4();
        }
        else {
            MessageBox.Show("请选择一条内容");
        }
    }



    private void button14_Click(object sender, EventArgs e) {
        new AddMonsterKillRewardForm().ShowDialog();
    }


    private void method_1()
    {
        method_2();
        method_3();
        method_4();
        method_5();
        method_6();
    }

    private void method_2()
    {
        listView4.Items.Clear();
        var list_ = Class5.list_0;
        for (int i = 0; i < list_.Count; i++)
        {
            var listViewItem = new ListViewItem();
            listViewItem.Text = list_[i].string_0.ToString();
            listViewItem.SubItems.Add(list_[i].string_1.ToString());
            listViewItem.SubItems.Add(list_[i].int_2.ToString());
            listView4.Items.Add(listViewItem);
        }
    }



    private void button9_Click(object sender, EventArgs e)
    {
        method_6();
    }

    private void button8_Click(object sender, EventArgs e)
    {
        new AddRefShopSilkRankingRewardForm().ShowDialog();
        Class5.smethod_36();
        method_5();
    }

    private void button7_Click(object sender, EventArgs e)
    {
        if (listView2.SelectedItems.Count > 0)
        {
            if (!Class5.smethod_126(listView2.SelectedItems[0].SubItems[1].Text))
            {
                MessageBox.Show("删除失败！");
                return;
            }
            Class5.smethod_36();
            method_5();
        }
        else
        {
            MessageBox.Show("请选择一条内容");
        }
    }

    private void button11_Click(object sender, EventArgs e)
    {
        new AddRefShopSilkRewardForm().ShowDialog();
        Class5.smethod_34();
        method_6();
    }

    private void button10_Click(object sender, EventArgs e)
    {
        if (listView3.SelectedItems.Count > 0)
        {
            if (!Class5.smethod_128(listView3.SelectedItems[0].SubItems[1].Text))
            {
                MessageBox.Show("删除失败！");
                return;
            }
            Class5.smethod_34();
            method_6();
        }
        else
        {
            MessageBox.Show("请选择一条内容");
        }
    }
    private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
        if (dateTimePicker1.Value.ToString("HH:mm:ss") == "00:00:00") {
            var now = DateTime.Now;
            dateTimePicker1.Value = DateTime.Parse(now.ToString("yyyy-MM-dd") + " 23:59:59");
        }
    }

    protected override void Dispose(bool disposing) {
        if (disposing && icontainer_0 != null) {
            icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader_13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader_10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox16);
            this.tabPage1.Controls.Add(this.groupBox14);
            this.tabPage1.Controls.Add(this.groupBox13);
            this.tabPage1.Controls.Add(this.groupBox12);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "服务器配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.radioButton3);
            this.groupBox16.Controls.Add(this.dateTimePicker2);
            this.groupBox16.Controls.Add(this.radioButton2);
            this.groupBox16.Controls.Add(this.dateTimePicker1);
            this.groupBox16.Controls.Add(this.radioButton1);
            this.groupBox16.Controls.Add(this.label34);
            this.groupBox16.Controls.Add(this.label33);
            this.groupBox16.Location = new System.Drawing.Point(274, 120);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(338, 354);
            this.groupBox16.TabIndex = 31;
            this.groupBox16.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(12, 181);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(119, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "不检测客户端组件";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(123, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(71, 21);
            this.dateTimePicker2.TabIndex = 18;
            this.dateTimePicker2.Value = new System.DateTime(2018, 3, 20, 21, 16, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(11, 125);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(155, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "只检测未安装客户端组件";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(71, 21);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2018, 3, 20, 21, 16, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(11, 152);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "严格检测客户端组件";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 48);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(107, 12);
            this.label34.TabIndex = 2;
            this.label34.Text = "特产买卖结束时间:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(10, 21);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(107, 12);
            this.label33.TabIndex = 0;
            this.label33.Text = "特产买卖开始时间:";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.checkBox7);
            this.groupBox14.Controls.Add(this.checkBox5);
            this.groupBox14.Controls.Add(this.checkBox1);
            this.groupBox14.Location = new System.Drawing.Point(274, 6);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(338, 108);
            this.groupBox14.TabIndex = 29;
            this.groupBox14.TabStop = false;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(11, 50);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(96, 16);
            this.checkBox7.TabIndex = 27;
            this.checkBox7.Text = "强制限制代理";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(11, 20);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(132, 16);
            this.checkBox5.TabIndex = 26;
            this.checkBox5.Text = "游戏指南只显示一次";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "自动启动(验证服务器)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.textBox23);
            this.groupBox13.Controls.Add(this.label23);
            this.groupBox13.Location = new System.Drawing.Point(7, 420);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(261, 54);
            this.groupBox13.TabIndex = 28;
            this.groupBox13.TabStop = false;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(135, 20);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(114, 21);
            this.textBox23.TabIndex = 13;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 12);
            this.label23.TabIndex = 14;
            this.label23.Text = "用户管理服务器端口:";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBox21);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Location = new System.Drawing.Point(7, 363);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(261, 51);
            this.groupBox12.TabIndex = 27;
            this.groupBox12.TabStop = false;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(134, 20);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(115, 21);
            this.textBox21.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 12);
            this.label21.TabIndex = 10;
            this.label21.Text = "多开客户端数量:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox2);
            this.groupBox11.Controls.Add(this.label1);
            this.groupBox11.Controls.Add(this.textBox1);
            this.groupBox11.Controls.Add(this.label2);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.textBox22);
            this.groupBox11.Location = new System.Drawing.Point(7, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(261, 108);
            this.groupBox11.TabIndex = 25;
            this.groupBox11.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 21);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器名称:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "最大在线:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(34, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 12);
            this.label22.TabIndex = 12;
            this.label22.Text = "验证服务器端口:";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(135, 75);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(114, 21);
            this.textBox22.TabIndex = 11;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox27);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.Controls.Add(this.textBox31);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Controls.Add(this.textBox29);
            this.groupBox10.Controls.Add(this.textBox30);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Location = new System.Drawing.Point(7, 226);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(261, 131);
            this.groupBox10.TabIndex = 24;
            this.groupBox10.TabStop = false;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(135, 45);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(114, 21);
            this.textBox27.TabIndex = 16;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(119, 12);
            this.label27.TabIndex = 15;
            this.label27.Text = "炼金等级限制(防具):";
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(135, 99);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(114, 21);
            this.textBox31.TabIndex = 22;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 75);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(119, 12);
            this.label29.TabIndex = 17;
            this.label29.Text = "炼金等级限制(首饰):";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(10, 102);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(119, 12);
            this.label31.TabIndex = 21;
            this.label31.Text = "炼金等级限制(盾牌):";
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(135, 72);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(114, 21);
            this.textBox29.TabIndex = 18;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(135, 18);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(114, 21);
            this.textBox30.TabIndex = 20;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(11, 21);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(119, 12);
            this.label30.TabIndex = 19;
            this.label30.Text = "炼金等级限制(武器):";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox32);
            this.groupBox9.Controls.Add(this.label32);
            this.groupBox9.Controls.Add(this.textBox15);
            this.groupBox9.Controls.Add(this.textBox16);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Location = new System.Drawing.Point(7, 120);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(261, 100);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(135, 71);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(114, 21);
            this.textBox32.TabIndex = 9;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(29, 74);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 12);
            this.label32.TabIndex = 10;
            this.label32.Text = "服务端代理端口:";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(135, 18);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(114, 21);
            this.textBox15.TabIndex = 5;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(135, 44);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(114, 21);
            this.textBox16.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 12);
            this.label16.TabIndex = 7;
            this.label16.Text = "服务端网关端口:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 12);
            this.label15.TabIndex = 8;
            this.label15.Text = "服务端代理端口:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "角色等级奖励";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(538, 5);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 26);
            this.button5.TabIndex = 3;
            this.button5.Text = "刷新";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(538, 488);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 26);
            this.button4.TabIndex = 2;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(538, 458);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 26);
            this.button3.TabIndex = 1;
            this.button3.Text = "添加";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 6);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(527, 508);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_0
            // 
            this.columnHeader_0.Text = "服务";
            this.columnHeader_0.Width = 120;
            // 
            // columnHeader_1
            // 
            this.columnHeader_1.Text = "排名";
            this.columnHeader_1.Width = 80;
            // 
            // columnHeader_2
            // 
            this.columnHeader_2.Text = "金珠奖励";
            this.columnHeader_2.Width = 150;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(619, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "消费奖励";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(538, 467);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 26);
            this.button10.TabIndex = 9;
            this.button10.Text = "删除";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView3);
            this.groupBox2.Location = new System.Drawing.Point(6, 258);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(526, 247);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "累计消费奖励";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_3,
            this.columnHeader_4,
            this.columnHeader_5,
            this.columnHeader_9});
            this.listView3.FullRowSelect = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(12, 18);
            this.listView3.Margin = new System.Windows.Forms.Padding(2);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(505, 217);
            this.listView3.TabIndex = 4;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_3
            // 
            this.columnHeader_3.Text = "服务";
            this.columnHeader_3.Width = 115;
            // 
            // columnHeader_4
            // 
            this.columnHeader_4.Text = "等级";
            this.columnHeader_4.Width = 105;
            // 
            // columnHeader_5
            // 
            this.columnHeader_5.Text = "消费金猪";
            this.columnHeader_5.Width = 120;
            // 
            // columnHeader_9
            // 
            this.columnHeader_9.Text = "奖励金猪";
            this.columnHeader_9.Width = 135;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(538, 23);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 26);
            this.button6.TabIndex = 7;
            this.button6.Text = "刷新";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(538, 437);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(74, 26);
            this.button11.TabIndex = 8;
            this.button11.Text = "添加";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(538, 185);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 26);
            this.button8.TabIndex = 5;
            this.button8.Text = "添加";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(538, 276);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 26);
            this.button9.TabIndex = 10;
            this.button9.Text = "刷新";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(526, 250);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "消费排行榜奖励";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_6,
            this.columnHeader_7,
            this.columnHeader_8});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 19);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(505, 218);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_6
            // 
            this.columnHeader_6.Text = "服务";
            this.columnHeader_6.Width = 120;
            // 
            // columnHeader_7
            // 
            this.columnHeader_7.Text = "排名";
            this.columnHeader_7.Width = 80;
            // 
            // columnHeader_8
            // 
            this.columnHeader_8.Text = "金珠奖励";
            this.columnHeader_8.Width = 150;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(538, 215);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 26);
            this.button7.TabIndex = 6;
            this.button7.Text = "删除";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox8);
            this.tabPage7.Controls.Add(this.groupBox7);
            this.tabPage7.Controls.Add(this.groupBox6);
            this.tabPage7.Controls.Add(this.groupBox5);
            this.tabPage7.Controls.Add(this.groupBox4);
            this.tabPage7.Controls.Add(this.groupBox3);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(619, 519);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "奖励设置";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBox3);
            this.groupBox8.Controls.Add(this.checkBox2);
            this.groupBox8.Controls.Add(this.textBox28);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.textBox26);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.textBox25);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Location = new System.Drawing.Point(310, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(297, 134);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "要塞奖励";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(162, 106);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(96, 16);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "启用参与奖励";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(34, 106);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 16);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "启用等级限制";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(162, 74);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(112, 21);
            this.textBox28.TabIndex = 15;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 78);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(149, 12);
            this.label28.TabIndex = 14;
            this.label28.Text = "要塞战参与奖励金珠数量：";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(162, 47);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(112, 21);
            this.textBox26.TabIndex = 11;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(32, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 12);
            this.label26.TabIndex = 10;
            this.label26.Text = "要塞战奖励限制等级：";
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(162, 20);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(112, 21);
            this.textBox25.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(32, 24);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(125, 12);
            this.label25.TabIndex = 8;
            this.label25.Text = "要塞战奖励金珠数量：";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.textBox24);
            this.groupBox7.Location = new System.Drawing.Point(310, 429);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(297, 84);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "满级奖励";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(83, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "满级等级：";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(154, 24);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(89, 21);
            this.textBox24.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox20);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.textBox17);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.textBox19);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.textBox18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(310, 146);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(297, 277);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "红包活动";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(162, 101);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(112, 21);
            this.textBox20.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 12);
            this.label20.TabIndex = 12;
            this.label20.Text = "红包活动超时关闭时间：";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(162, 22);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(112, 21);
            this.textBox17.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 12);
            this.label18.TabIndex = 8;
            this.label18.Text = "红包领取最小数额：";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(162, 74);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(112, 21);
            this.textBox19.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "红包领取最大数额：";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(162, 48);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(112, 21);
            this.textBox18.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 12);
            this.label19.TabIndex = 10;
            this.label19.Text = "红包活动喇叭道具ID：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(7, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(297, 134);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "摆摊奖励";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(155, 101);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(88, 21);
            this.textBox8.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(155, 21);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(88, 21);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(155, 74);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(88, 21);
            this.textBox7.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "摆摊奖励金珠数量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "摆摊奖励最小分钟：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "摆摊奖励限制地区：";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(155, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(88, 21);
            this.textBox5.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "摆摊奖励限制等级：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(7, 429);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 84);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "组队奖励";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(154, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 21);
            this.textBox4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "组队奖励金珠数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "组队奖励最小分钟：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(154, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 21);
            this.textBox3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Location = new System.Drawing.Point(7, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 277);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "签到奖励";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(38, 199);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(120, 16);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "启用签到账号限制";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "签到连续5天奖励：";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(155, 156);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(88, 21);
            this.textBox14.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "签到奖励最低等级：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "签到连续15天奖励：";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(155, 21);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(88, 21);
            this.textBox9.TabIndex = 3;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(155, 129);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(88, 21);
            this.textBox13.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "签到第1天奖励：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "签到连续10天奖励：";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(155, 48);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(88, 21);
            this.textBox10.TabIndex = 5;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(155, 102);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(88, 21);
            this.textBox12.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "签到连续3天奖励：";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(155, 75);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(88, 21);
            this.textBox11.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBox8);
            this.tabPage4.Controls.Add(this.checkBox4);
            this.tabPage4.Controls.Add(this.button15);
            this.tabPage4.Controls.Add(this.button16);
            this.tabPage4.Controls.Add(this.button17);
            this.tabPage4.Controls.Add(this.listView5);
            this.tabPage4.Controls.Add(this.button14);
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Controls.Add(this.listView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(619, 519);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "游戏奖励";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(87, 237);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(156, 16);
            this.checkBox8.TabIndex = 28;
            this.checkBox8.Text = "怪物击杀奖励仅自己可见";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(87, 494);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(120, 16);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "炼金等级分开奖励";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(458, 490);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 23);
            this.button15.TabIndex = 7;
            this.button15.Text = "添加";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(537, 490);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 6;
            this.button16.Text = "删除";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(6, 490);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 5;
            this.button17.Text = "刷新";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_13,
            this.columnHeader_14,
            this.columnHeader_15,
            this.columnHeader_16});
            this.listView5.FullRowSelect = true;
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(6, 262);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(606, 222);
            this.listView5.TabIndex = 4;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_13
            // 
            this.columnHeader_13.Text = "物品代码";
            this.columnHeader_13.Width = 150;
            // 
            // columnHeader_14
            // 
            this.columnHeader_14.Text = "物品名字";
            this.columnHeader_14.Width = 150;
            // 
            // columnHeader_15
            // 
            this.columnHeader_15.Text = "强化等级";
            this.columnHeader_15.Width = 120;
            // 
            // columnHeader_16
            // 
            this.columnHeader_16.Text = "金珠奖励";
            this.columnHeader_16.Width = 150;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(458, 233);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(73, 23);
            this.button14.TabIndex = 3;
            this.button14.Text = "添加";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(537, 233);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 2;
            this.button13.Text = "删除";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 233);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 1;
            this.button12.Text = "刷新";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_10,
            this.columnHeader_11,
            this.columnHeader_12});
            this.listView4.FullRowSelect = true;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(6, 6);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(606, 221);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_10
            // 
            this.columnHeader_10.Text = "怪物代码";
            this.columnHeader_10.Width = 150;
            // 
            // columnHeader_11
            // 
            this.columnHeader_11.Text = "怪物名字";
            this.columnHeader_11.Width = 150;
            // 
            // columnHeader_12
            // 
            this.columnHeader_12.Text = "金珠奖励";
            this.columnHeader_12.Width = 150;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(463, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(542, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 583);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "详细设置";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

    }

    private void button12_Click(object sender, EventArgs e)
    {
        Class5.smethod_37();
        method_2();
    }

    private void button17_Click(object sender, EventArgs e)
    {
        Class5.smethod_38();
        method_3();
    }

    private void button13_Click(object sender, EventArgs e)
    {
        if (listView4.SelectedItems.Count > 0)
        {
            if (!Class5.smethod_123(listView4.SelectedItems[0].SubItems[0].Text))
            {
                MessageBox.Show("删除失败！");
                return;
            }
            Class5.smethod_37();
            method_2();
        }
        else
        {
            MessageBox.Show("请选择一条内容");
        }
    }

    private void button15_Click(object sender, EventArgs e)
    {
        new AddAlchemyRewardForm().ShowDialog();
    }

    private void button16_Click(object sender, EventArgs e)
    {
        if (listView5.SelectedItems.Count > 0)
        {
            if (!Class5.smethod_122(listView5.SelectedItems[0].SubItems[0].Text))
            {
                MessageBox.Show("删除失败！");
                return;
            }
            Class5.smethod_38();
            method_3();
        }
        else
        {
            MessageBox.Show("请选择一条内容");
        }
    }

    private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
    {
        if (dateTimePicker2.Value.ToString("HH:mm:ss") == "00:00:00")
        {
            var now = DateTime.Now;
            dateTimePicker2.Value = DateTime.Parse(now.ToString("yyyy-MM-dd") + " 23:59:59");
        }
    }
}
