using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal class CenterManagerServerForm : Form {



	private DateTime dateTime_0;

	private DateTime dateTime_1;

	private int int_0;

	private int int_1;

	private bool bool_0 = true;

	private int int_2;

	private bool bool_1;

	private int int_3;

	private int int_4;

	private List<Struct2> list_0 = new List<Struct2>();

	private int int_5;

	private string string_0 = "";

	private List<Struct53> list_1 = new List<Struct53>();

	private List<int> list_2 = new List<int>();

	private List<int> list_3 = new List<int>();

	private ListViewItem listViewItem_0;

	private int int_6;

	private System.Windows.Forms.SortOrder sortOrder_0;

	private List<Struct51> list_4 = new List<Struct51>();

	private List<Struct7> list_5 = new List<Struct7>();

	private IContainer icontainer_0 = null;

	private TabControl tabControl1;

	private GroupBox groupBox3;

	private Label label6;

	private GroupBox groupBox2;

	private Label labelAgentSend;

	private Label labelAgentRecv;

	private Label labelGatewayCenter;

	private GroupBox groupBox1;

	private Label labelGatewayRecv;

	private Label labelGatewaySend;

	private Button button16;

	private TextBox textBox2;

	private Button button14;

	private Button button9;

	private Button button2;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private Button button8;

	private TextBox textBox1;

	private Label label7;

	private Button button18;

	public ListView listView2;

	private ColumnHeader columnHeader_4;

	private ColumnHeader columnHeader_5;

	private ColumnHeader columnHeader_6;

	private ColumnHeader columnHeader_7;

	private ColumnHeader columnHeader_8;

	private Button button17;

	private Button button4;

	private Button button1;

	private Button button3;

	private Button button5;

	private TabPage tabPage5;

	private TabPage tabPage4;

	private TabPage tabPage3;

	private TabPage tabPage2;

	private TabPage tabPage1;

	private ListBox listBox1;

	private System.Windows.Forms.Timer timer_0;

	private Label labelAgentWaitRecv;

	private Label labelAgentWaitSend;

	private Label labelGatewayWaitSend;

	private Label labelGatewayWaitRecv;

	private Label labelAgentCenter;

	private System.Windows.Forms.Timer timer_1;

	private System.Windows.Forms.Timer timer_2;

	private ColumnHeader columnHeader_9;

	private CheckBox checkBox6;

	private CheckBox checkBox5;

	private Button button13;

	private Button button12;

	private Button button11;

	private Button button10;

	private ListView listView3;

	private ColumnHeader columnHeader_10;

	private ColumnHeader columnHeader_11;

	private ColumnHeader columnHeader_12;

	private GroupBox groupBox5;

	private Button button19;

	private GroupBox groupBox4;

	private CheckBox checkBoxATTState;

	private CheckBox checkBoxTradeDelay;

	private CheckBox checkBoxLoginReward;

	private CheckBox checkBoxNotAlchemy;

	private CheckBox checkBoxMonsterKill;

	private CheckBox checkBox_0;

	private CheckBox checkBoxAlchemy;

	private CheckBox checkBox4;

	private CheckBox checkBox3;

	private CheckBox checkBox2;

	private CheckBox checkBox1;

	private CheckBox checkBox7;

	private TabPage tabPage7;

	private CheckBox checkBox11;

	private CheckBox checkBox10;

	private CheckBox checkBox9;

	private Label label1;

	private Label label2;

	private Label label4;

	private TabPage tabPage8;

	private Button button22;

	private TextBox textBox4;

	private TextBox textBox3;

	private Label label8;

	private Label label9;

	private TextBox textBox6;

	private Label label10;

	private CheckBox checkBox14;

	private CheckBox checkBox13;

	private CheckBox checkBox12;

	private ColumnHeader columnHeader_13;

	private TabControl tabControl2;

	private TabPage tabPage9;

	private CheckBox checkBox8;

	private Button button21;

	private TextBox textBox5;

	private Label label3;

	private Button button20;

	private TabPage tabPage10;

	private Button button25;

	private Button button24;

	private Button button23;

	private ListView listView4;

	private ColumnHeader columnHeader_14;

	private ColumnHeader columnHeader_15;

	private ColumnHeader columnHeader_16;

	private ColumnHeader columnHeader_17;

	private ColumnHeader columnHeader_18;

	private TabPage tabPage11;

	private Button button27;

	private ListView listView5;

	private ColumnHeader columnHeader_19;

	private ColumnHeader columnHeader_20;

	private ColumnHeader columnHeader_21;

	private ColumnHeader columnHeader_22;

	private ColumnHeader columnHeader_23;

	private ColumnHeader columnHeader_24;

	private Button button28;

	private CheckBox checkBox16;

	private CheckBox checkBox15;

	private CheckBox checkBox17;

	private CheckedListBox checkedListBox1;

	private CheckBox checkBox18;

	private TextBox textBox7;

	private Label label11;

	private GroupBox groupBox7;

	private CheckBox checkBox19;

	private Label label12;

	private GroupBox groupBox6;

	private Label label13;

	private GroupBox groupBox9;

	private CheckBox checkBox21;

	private CheckBox checkBox20;

	private Button button32;

	private Button button26;

	private Button button33;

	private CheckBox checkBox23;

	private CheckBox checkBox24;

	private TextBox textBox8;

	private Label label14;

	private CheckBox checkBox25;

	private ToolTip toolTip_0;

	private Button button35;

	private CheckBox checkBox26;

	private Button button7;

	private PictureBox pictureBox1;

	private Button button15;

	private TextBox textBox10;

	private Label label16;

	private TextBox textBox9;

	private Label label15;

	private GroupBox groupBox10;

	private TextBox textBox11;

	private Label label17;

	private CheckBox checkBox27;

	private CheckBox checkBox28;

	private System.Windows.Forms.Timer timer_3;

	private Label label18;

	private Label label20;

	private TextBox textBox12;

	private Label label19;

	private TextBox textBox13;

	private CheckBox checkBox31;

	private Button button6;

	private CheckBox checkBox33;

	private CheckBox checkBox32;

	private Button button29;

	private GroupBox groupBox8;

	private Button button30;

	private CheckBox checkBox34;

	private Button button31;

	private CheckBox checkBox35;

	private TabPage tabPage12;

	private Button button34;

	private ListView listView6;

	private Button button38;

	private Button button37;

	private Button button36;

	private ColumnHeader columnHeader_25;

	private ColumnHeader columnHeader_26;

	private ColumnHeader columnHeader_27;

	private ColumnHeader columnHeader_28;

	private TabPage tabPage13;

	private Button button40;

	private Button button41;

	private Button button42;

	private Button button39;

	private ListView listView7;

	private ColumnHeader columnHeader_29;

	private ColumnHeader columnHeader_30;

	private ColumnHeader columnHeader_31;

	private ColumnHeader columnHeader_32;

	private ColumnHeader columnHeader_33;

	private ColumnHeader columnHeader_34;

	private ColumnHeader columnHeader_35;

	private ColumnHeader columnHeader_36;

	private ColumnHeader columnHeader_37;

	private CheckBox checkBox37;

	private GroupBox groupBox12;

	private Label labelDownloadWaitSend;

	private Label labelDownloadWaitRecv;

	private Label labelDownloadRecv;

	private Label labelDownloadSend;

	private Label labelDownloadCenter;

	private CheckBox checkBox38;

	private CheckBox checkBox39;

	private CheckBox checkBox40;

	private System.Windows.Forms.Timer timer_4;

	private ColumnHeader columnHeader_38;

	private TabControl tabControl3;

	private TabPage tabPage14;

	private TabPage tabPage15;

	private Button button47;

	private Button button46;

	private Button button44;

	private ListView listView8;

	private ColumnHeader columnHeader_39;

	private ColumnHeader columnHeader_40;

	private ColumnHeader columnHeader_41;

	private ColumnHeader columnHeader_42;

	private ColumnHeader columnHeader_43;

	private ColumnHeader columnHeader_44;

	private ColumnHeader columnHeader_45;

	private ColumnHeader columnHeader_46;

	private ColumnHeader columnHeader_47;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem1;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem3;

	private ColumnHeader columnHeader_48;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem toolStripMenuItem4;

	private ToolStripMenuItem toolStripMenuItem5;

	private ListView listView9;

	private Button button52;

	private Button button51;

	private Button button50;

	private Button button49;

	private ColumnHeader columnHeader_49;

	private ColumnHeader columnHeader_50;

	private ColumnHeader columnHeader_51;

	private ColumnHeader columnHeader_52;

	private ColumnHeader columnHeader_53;

	private System.Windows.Forms.Timer timer_5;

	private ColumnHeader columnHeader_54;




	



	private GroupBox groupBox13;
	private IContainer components;
	private GroupBox groupBox16;
	private GroupBox groupBox15;
	private TabPage tabPage17;

	public CenterManagerServerForm() {
		InitializeComponent();
	}

	private bool method_0() {
		try {
			if (!bool_1) {
				return false;
			}
			Class8.bool_5 = checkBox_0.Checked;
			Class8.bool_3 = checkBoxMonsterKill.Checked;
			Class8.bool_4 = checkBoxAlchemy.Checked;
			Class8.bool_7 = checkBoxNotAlchemy.Checked;
			Class8.bool_12 = checkBoxLoginReward.Checked;
			Class8.bool_13 = checkBoxTradeDelay.Checked;
			Class8.bool_0 = checkBoxATTState.Checked;
			Class8.bool_1 = checkBox6.Checked;
			Class8.bool_2 = checkBox5.Checked;
			Class8.bool_15 = checkBox10.Checked;
			Class8.bool_16 = checkBox11.Checked;
			Class8.bool_14 = checkBox7.Checked;
			Class8.bool_6 = checkBox1.Checked;
			Class8.bool_8 = checkBox2.Checked;
			Class8.bool_9 = checkBox3.Checked;
			Class8.bool_18 = checkBox8.Checked;
			Class8.bool_21 = checkBox15.Checked;
			Class8.bool_20 = checkBox16.Checked;
			Class8.bool_22 = checkBox17.Checked;
			Class8.bool_23 = checkBox18.Checked;
			Class8.bool_24 = checkBox19.Checked;
			Class8.int_18 = int.Parse(textBox7.Text);
			Class8.bool_38 = checkBox27.Checked;
			Class8.bool_25 = checkBox20.Checked;
			Class8.bool_26 = checkBox21.Checked;
			Class8.bool_65 = checkBox23.Checked;
			Class8.bool_27 = checkBox24.Checked;
			Class8.bool_37 = checkBox26.Checked;
			Class8.bool_39 = checkBox28.Checked;
			Class8.bool_40 = checkBox33.Checked;
			Class8.bool_41 = checkBox32.Checked;
			Class8.bool_46 = checkBox34.Checked;
			Class8.int_21 = int.Parse(textBox9.Text);
			Class8.int_23 = int.Parse(textBox5.Text);
			Class8.string_55 = textBox8.Text;
			Class8.int_24 = int.Parse(textBox11.Text);
			Class8.int_25 = int.Parse(textBox10.Text);
			Class8.int_26 = int.Parse(textBox12.Text);
			Class8.int_27 = int.Parse(textBox13.Text);
			Class8.bool_47 = checkBox31.Checked;
			Class8.string_56 = textBox6.Text;
			Class8.bool_51 = checkBox35.Checked;
			Class8.bool_48 = checkBox37.Checked;
			Class8.bool_55 = checkBox25.Checked;
			Class8.bool_59 = checkBox38.Checked;
			Class8.bool_60 = checkBox39.Checked;
			Class8.bool_61 = checkBox40.Checked;
			method_3();
			Class8.smethod_2();
			return true;
		}
		catch {
			return false;
		}
	}

	private bool method_1() {
		try {
			checkBox_0.Checked = Class8.bool_5;
			checkBoxMonsterKill.Checked = Class8.bool_3;
			checkBoxAlchemy.Checked = Class8.bool_4;
			checkBoxNotAlchemy.Checked = Class8.bool_7;
			checkBoxLoginReward.Checked = Class8.bool_12;
			checkBoxTradeDelay.Checked = Class8.bool_13;
			checkBoxATTState.Checked = Class8.bool_0;
			checkBox6.Checked = Class8.bool_1;
			checkBox5.Checked = Class8.bool_2;
			checkBox10.Checked = Class8.bool_15;
			checkBox11.Checked = Class8.bool_16;
			checkBox7.Checked = Class8.bool_14;
			checkBox1.Checked = Class8.bool_6;
			checkBox2.Checked = Class8.bool_8;
			checkBox3.Checked = Class8.bool_9;
			checkBox8.Checked = Class8.bool_18;
			checkBox4.Checked = Class8.bool_11;
			checkBox9.Checked = Class8.bool_17;
			checkBox15.Checked = Class8.bool_21;
			checkBox16.Checked = Class8.bool_20;
			checkBox17.Checked = Class8.bool_22;
			checkBox18.Checked = Class8.bool_23;
			checkBox19.Checked = Class8.bool_24;
			checkBox27.Checked = Class8.bool_38;
			textBox7.Text = Class8.int_18.ToString();
			checkBox20.Checked = Class8.bool_25;
			checkBox21.Checked = Class8.bool_26;
			checkBox23.Checked = Class8.bool_65;
			checkBox24.Checked = Class8.bool_27;
			checkBox26.Checked = Class8.bool_37;
			checkBox28.Checked = Class8.bool_39;
			checkBox33.Checked = Class8.bool_40;
			checkBox32.Checked = Class8.bool_41;
			checkBox34.Checked = Class8.bool_46;
			textBox9.Text = Class8.int_21.ToString();
			textBox5.Text = Class8.int_23.ToString();
			textBox8.Text = Class8.string_55;
			textBox11.Text = Class8.int_24.ToString();
			textBox10.Text = Class8.int_25.ToString();
			textBox12.Text = Class8.int_26.ToString();
			textBox13.Text = Class8.int_27.ToString();
			textBox6.Text = Class8.string_56;
			checkBox31.Checked = Class8.bool_47;
			checkBox35.Checked = Class8.bool_51;
			checkBox37.Checked = Class8.bool_48;
			checkBox25.Checked = Class8.bool_55;
			checkBox38.Checked = Class8.bool_59;
			checkBox39.Checked = Class8.bool_60;
			checkBox40.Checked = Class8.bool_61;
			method_2();
			bool_1 = true;
			return true;
		}
		catch {
			return false;
		}
	}

	private void method_2() {
		for (int i = 0; i < checkedListBox1.Items.Count; i++) {
			if (Class8.string_40.IndexOf(checkedListBox1.Items[i].ToString() + ",") != -1) {
				checkedListBox1.SetItemChecked(i, value: true);
			}
		}
	}

	private void method_3() {
		Class8.string_40 = "";
		for (int i = 0; i < checkedListBox1.Items.Count; i++) {
			if (checkedListBox1.GetItemChecked(i)) {
				Class8.string_40 = Class8.string_40 + checkedListBox1.Items[i].ToString() + ",";
			}
		}
	}

	private void method_4(Struct53 struct53_0) {
		if (base.InvokeRequired) {
			BeginInvoke(Class6.delegate1_0, struct53_0);
			return;
		}
		try {
			if (struct53_0.ushort_0 == 1) {
				listBox1.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + struct53_0.string_0);
				listBox1.TopIndex = listBox1.Items.Count - listBox1.Height / listBox1.ItemHeight;
			}
			else if (struct53_0.ushort_0 == 2) {
				list_1.Add(struct53_0);
			}
			else if (struct53_0.ushort_0 == 3) {
				label4.Text = "活动金珠数量:" + struct53_0.int_0;
				button20.Enabled = false;
			}
			else if (struct53_0.ushort_0 == 4) {
				button20.Enabled = true;
			}
			else if (struct53_0.ushort_0 == 5) {
				label4.Text = "活动金珠数量:" + Class13.int_1;
			}
			else if (struct53_0.ushort_0 == 6) {
				string[] lines = textBox3.Lines;
				if (lines != null && lines.Length > 300) {
					textBox3.Clear();
				}
				textBox3.AppendText(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + struct53_0.string_0 + Environment.NewLine);
			}
			else if (struct53_0.ushort_0 == 7) {
				int_5++;
			}
			else if (struct53_0.ushort_0 == 8) {
				tabControl1.SelectedIndex = 0;
				label18.Text = struct53_0.string_0;
			}
			else if (struct53_0.ushort_0 == 9) {
				if (struct53_0.string_0 == "Exit") {
					Class7.smethod_2("0.0.0.0:0", "Center System:Support Exit");
					method_28();
				}
			}
			else if (struct53_0.ushort_0 == 10 && struct53_0.string_0 == "Msg") {
				timer_4.Start();
			}
		}
		catch {
		}
	}

	private bool method_5() {
		if (Class8.ushort_0 < 1) {
			MessageBox.Show("刺陵防御配置文件内 GatewayCenterPort设置错误！");
			method_28();
			return false;
		}
		if (Class8.ushort_1 < 1) {
			MessageBox.Show("刺陵防御配置文件内 AgentCenterPort设置错误！");
			method_28();
			return false;
		}
		if (Class8.ushort_2 < 1) {
			MessageBox.Show("刺陵防御配置文件内 GlobalManagerPort设置错误！");
			method_28();
			return false;
		}
		if (Class8.ushort_3 < 1) {
			MessageBox.Show("刺陵防御配置文件内 FarmManagerPort设置错误！");
			method_28();
			return false;
		}
		if (!(Class8.string_2 == "") && Class8.string_2.Length >= 7) {
			if (Class8.string_3 == "") {
				MessageBox.Show("刺陵防御配置文件内 Center_DBCSQL设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_5 < 1) {
				MessageBox.Show("刺陵防御配置文件内 NoticeDelayTime设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_1 < 1) {
				MessageBox.Show("刺陵防御配置文件内 TeamRegisterRewardTime设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_3 < 1) {
				MessageBox.Show("刺陵防御配置文件内 SellRegisterRewardTime设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_2 < 0) {
				MessageBox.Show("刺陵防御配置文件内 TeamRegisterRewardSilk设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_4 < 0) {
				MessageBox.Show("刺陵防御配置文件内 TeamRegisterRewardSilk设置错误！");
				method_28();
				return false;
			}
			if (Class8.byte_0 < 1) {
				MessageBox.Show("刺陵防御配置文件内 SellRegisterRewardLevel设置错误！");
				method_28();
				return false;
			}
			if (Class8.short_0 == 0) {
				MessageBox.Show("刺陵防御配置文件内 SellRegisterRewardRegionID设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_12 < 1) {
				MessageBox.Show("刺陵防御配置文件内 TradeDelayTime设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_6 < 0) {
				MessageBox.Show("刺陵防御配置文件内 CustomNoticeTime设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_14 < 0) {
				MessageBox.Show("刺陵防御配置文件内 CustomFunctionTime设置错误！");
				method_28();
				return false;
			}
			if (Class8.string_10 == "") {
				MessageBox.Show("刺陵防御配置文件内 NotAllChatString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_16 == "") {
				MessageBox.Show("刺陵防御配置文件内 TradeDelayString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_11 == "") {
				MessageBox.Show("刺陵防御配置文件内 NotAlchemyString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.int_7 < 1) {
				MessageBox.Show("刺陵防御配置文件内 LoginRewardSilk设置错误！");
				method_28();
				return false;
			}
			if (Class8.byte_1 < 1) {
				MessageBox.Show("刺陵防御配置文件内 LoginRewardLevel设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_8 < 1) {
				MessageBox.Show("刺陵防御配置文件内 Login3RewardSilk设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_9 < 1) {
				MessageBox.Show("刺陵防御配置文件内 Login5RewardSilk设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_10 < 1) {
				MessageBox.Show("刺陵防御配置文件内 Login10RewardSilk设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_11 < 1) {
				MessageBox.Show("刺陵防御配置文件内 Login15RewardSilk设置错误！");
				method_28();
				return false;
			}
			if (Class8.int_16 > Class8.int_15) {
				MessageBox.Show("刺陵防御配置文件内 GiftEventCountMin,GiftEventCountMax设置错误！");
				method_28();
				return false;
			}
			if (Class8.string_29 == "") {
				MessageBox.Show("刺陵防御配置文件内 GiftEventAllChatRefItemIDString设置错误！");
				method_28();
				return false;
			}
			if (Class8.string_7.Length != 4) {
				MessageBox.Show("刺陵防御配置文件内 MonsterKillRewardString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_8.Length != 5) {
				MessageBox.Show("刺陵防御配置文件内 AlchemyRewardString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_9.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 OnlineString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_12.Length != 3) {
				MessageBox.Show("刺陵防御配置文件内 TeamRegisterRewardString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_13.Length != 3) {
				MessageBox.Show("刺陵防御配置文件内 SellRegisterRewardString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_14.Length != 3) {
				MessageBox.Show("刺陵防御配置文件内 SendSilkString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_15.Length != 4) {
				MessageBox.Show("刺陵防御配置文件内 LoginRewardString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_24.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 GiftEventGetString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_25.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 GiftEventNotCountMinString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_26.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 GiftEventNotCountSilkString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_27.Length != 3) {
				MessageBox.Show("刺陵防御配置文件内 GiftEventStartString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_28.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 GiftEventAllChatString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_34.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 GiftEventReturnString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_35.Length != 4) {
				MessageBox.Show("刺陵防御配置文件内 LevelMaxRewardString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_36.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 LevelMaxSpeedInfoString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_38.Length != 3) {
				MessageBox.Show("刺陵防御配置文件内 ShopSilkRewardString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_39.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 ShopSilkRewardRankingString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_37.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 LevelMaxRewardRankingString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_41.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 SiegFortressRewardWinString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_42.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 SiegFortressRewardCharString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_43.Length != 2) {
				MessageBox.Show("刺陵防御配置文件内 SiegFortressRewardJoinString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_46.Length != 3) {
				MessageBox.Show("刺陵防御配置文件内 GiftEventLuckyRewardString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_47.Length != 4) {
				MessageBox.Show("刺陵防御配置文件内 CharItemListSendItemString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_48.Length != 3) {
				MessageBox.Show("刺陵防御配置文件内 CharItemListSendGoldString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_49.Length != 3) {
				MessageBox.Show("刺陵防御配置文件内 CharItemListSendSilkString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_51.Length != 3) {
				MessageBox.Show("刺陵防御配置文件内 CharItemListGetNotInvString字符格式错误！");
				method_28();
				return false;
			}
			if (Class8.string_33.Length != 3) {
				MessageBox.Show("刺陵防御配置文件内 GiftEventSysStartString字符格式错误！");
				method_28();
				return false;
			}
			if (!Class9.smethod_14()) {
				MessageBox.Show("刺陵防御配置文件内 GiftEventAllChatRefItemIDString字符格式错误！");
				method_28();
				return false;
			}
			return true;
		}
		MessageBox.Show("刺陵防御配置文件内 ServerLocalIP设置错误！");
		method_28();
		return false;
	}

	private bool method_6() {
		if (!Class5.smethod_110("")) {
			MessageBox.Show("数据库连接失败,请检查配置文件中的Center_Query是否正确,或重新设置！");
			method_28();
			return false;
		}
		Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System 状态：检测修复系统开始运行");
		if (!Class9.smethod_38()) {
			MessageBox.Show("检测修复系统运行失败,请查看SQL_Check_Repair.Log确认内容！");
			method_28();
			return false;
		}
		return true;
	}

	private bool method_7() {
		switch (Class5.smethod_37()) {
			case -100:
				MessageBox.Show("SQL_Load_RefMonsterKillReward 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
				method_28();
				return false;
			case -200:
				MessageBox.Show("_RefMonsterKillReward 不能为空！");
				method_28();
				return false;
			default:
				switch (Class5.smethod_38()) {
					case -100:
						MessageBox.Show("SQL_Load_RefAlchemyReward 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
						method_28();
						return false;
					case -200:
						MessageBox.Show("_RefAlchemyReward 不能为空！");
						method_28();
						return false;
					default:
						switch (Class5.smethod_39()) {
							case -100:
								MessageBox.Show("SQL_Load_RefAlchemyLimit 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
								method_28();
								return false;
							case -200:
								MessageBox.Show("_RefAlchemyLimit 不能为空！");
								method_28();
								return false;
							default: {
								int num = Class5.smethod_40();
								if (num == -100) {
									MessageBox.Show("SQL_Load_GameNotice 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
									method_28();
									return false;
								}
								num = Class5.smethod_41();
								if (num == -100) {
									MessageBox.Show("SQL_Load_Data_GameMonster 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
									method_28();
									return false;
								}
								num = Class5.smethod_42();
								if (num == -100) {
									MessageBox.Show("SQL_Load_GameBlocked 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
									method_28();
									return false;
								}
								num = Class5.smethod_35();
								if (num == -100) {
									MessageBox.Show("SQL_Load_RefLevelMaxReward 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
									method_28();
									return false;
								}
								num = Class5.smethod_34();
								if (num == -100) {
									MessageBox.Show("SQL_Load_RefShopSilkReward 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
									method_28();
									return false;
								}
								num = Class5.smethod_36();
								if (num == -100) {
									MessageBox.Show("SQL_Load_RefShopSilkRankingReward 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
									method_28();
									return false;
								}
								num = Class5.smethod_33();
								if (num == -100) {
									MessageBox.Show("SQL_Load_RefChatCommand 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
									method_28();
									return false;
								}
								num = Class5.smethod_44();
								if (num == -100) {
									MessageBox.Show("SQL_Load_GameMultiTrust 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
									method_28();
									return false;
								}
								num = Class5.smethod_45();
								if (num == -100) {
									MessageBox.Show("SQL_Load_MoreReward 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
									method_28();
									return false;
								}
								num = Class5.smethod_43();
								if (num == -100) {
									MessageBox.Show("SQL_Load_GameBlockedChat 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
									method_28();
									return false;
								}
								num = Class5.smethod_46();
								if (num == -100) {
									MessageBox.Show("SQL_Load_GameSkillUselimit 数据表读取失败,请检查配置文件中的Center_Query是否正确！");
									method_28();
									return false;
								}
								return true;
							}
						}
				}
		}
	}

	private void method_8() {
		if (Class8.int_30 == 1 && File.Exists("CenterManager.dmp") && File.ReadAllText("CenterManager.dmp") != "") {
			File.Copy("CenterManager.dmp", DateTime.Now.ToString("yyyy-MM-dd-") + Class9.smethod_0() + "-CenterManager.dmp");
			File.Create("CenterManager.dmp");
		}
		if (Class8.int_30 == 0) {
			return;
		}
		try {
			byte[] array = File.ReadAllBytes("CenterManager.dmp");
			if (array.Length == 0) {
				return;
			}
			byte[] array2 = new byte[array.Length - 4];
			Array.Copy(array, 4, array2, 0, array2.Length);
			string[] array3 = Encoding.Unicode.GetString(Class28.smethod_3(array2, "CenterManagerServerForm")).Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array3.Length; i++) {
				string[] array4 = array3[i].Split(new string[1] { ":" }, StringSplitOptions.RemoveEmptyEntries);
				if (array4 != null && array4.Length == 5) {
					if (ushort.TryParse(array4[3], out ushort result)) {
						var item = default(Struct2);
						item.string_0 = array4[0] + ":" + array4[1] + ":" + array4[2];
						item.ushort_0 = result;
						item.string_1 = array4[4];
						list_0.Add(item);
					}
				}
			}
			Class12.class3_0.method_59(list_0);
		}
		catch {
		}
	}

	private bool method_9() {
		Class12.class38_0.method_1(Class8.ushort_0);
		Class12.class38_0.method_3(Class8.string_2);
		Class12.class38_0.method_5(Class8.ushort_4);
		if (!Class12.class38_0.method_6()) {
			MessageBox.Show("控制器启动失败!端口可能被占用,请先启动本服务再启动其他服务,端口号:" + Class8.ushort_0, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			method_28();
			return false;
		}
		if (Class8.bool_57) {
			Class12.class29_0.method_1(Class8.ushort_8);
			Class12.class29_0.method_3(Class8.string_2);
			Class12.class29_0.method_5(Class8.ushort_9);
			if (!Class12.class29_0.method_6()) {
				MessageBox.Show("控制器启动失败!端口可能被占用,请先启动本服务再启动其他服务,端口号:" + Class8.ushort_8, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				method_28();
				return false;
			}
		}
		Class12.class36_0.method_1(Class8.ushort_6);
		Class12.class36_0.method_3(Class8.string_2);
		Class12.class36_0.method_5(Class8.ushort_2);
		if (!Class12.class36_0.method_6()) {
			MessageBox.Show("控制器启动失败!端口可能被占用,请先启动本服务再启动其他服务,端口号:" + Class8.ushort_6, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			method_28();
			return false;
		}
		Class12.class3_0.method_29(Class8.ushort_1);
		Class12.class3_0.method_31(Class8.string_2);
		Class12.class3_0.method_33(Class8.ushort_5);
		if (!Class12.class3_0.method_34()) {
			MessageBox.Show("控制器启动失败!端口可能被占用,请先启动本服务再启动其他服务,端口号:" + Class8.ushort_1, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			method_28();
			return false;
		}
		Class12.class33_0.method_1(Class8.ushort_7);
		if (Class8.bool_53) {
			Class12.class33_0.method_3(Class8.string_57);
		}
		else {
			Class12.class33_0.method_3(Class8.string_2);
		}
		Class12.class33_0.method_5(Class8.ushort_3);
		if (!Class12.class33_0.method_6()) {
			MessageBox.Show("控制器启动失败!端口可能被占用,请先启动本服务再启动其他服务,端口号:" + Class8.ushort_7, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			method_28();
			return false;
		}
		if (Class8.bool_19) {
			if (!Class15.Set_CertificationPort(Class8.ushort_10)) {
				MessageBox.Show("控制器启动失败!端口号:" + Class8.ushort_10, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				method_28();
				return false;
			}
			Class12.class40_0.method_1(Class8.ushort_10);
			if (!Class12.class40_0.method_2()) {
				MessageBox.Show("控制器启动失败!端口可能被占用,请先启动本服务再启动其他服务,端口号:" + Class8.ushort_10, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				method_28();
				return false;
			}
			Class6.smethod_0(2, "CertificationServer 启动完成 端口号:" + Class8.ushort_10, 0);
		}
		else {
			Class6.smethod_0(2, "CertificationServer 未启动", 0);
		}
		if (Class8.bool_62) {
			if (!Class12.class11_0.method_0()) {
				MessageBox.Show("游戏控制器启动失败!端口可能被占用,请先启动本服务再启动其他服务,端口号:" + Class2.ushort_1, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				method_28();
				return false;
			}
			Class6.smethod_0(2, "GameControlAgent 启动完成 端口号:" + Class2.ushort_1, 0);
			try {
				if (File.Exists(Application.StartupPath + "\\Qiangweidiewu.exe")) {
					if (Process.GetProcessesByName("CenterGameServer").Length == 0) {
						Process.Start(Application.StartupPath + "\\Qiangweidiewu.exe");
						Class6.smethod_0(2, "CenterGameServer 启动成功", 0);
					}
					else {
						Class6.smethod_0(2, "CenterGameServer 已启动", 0);
					}
				}
			}
			catch {
				Class6.smethod_0(2, "CenterGameServer 启动失败", 0);
			}
		}
		return true;
	}
    private void button34_Click(object sender, EventArgs e)
    {
        method_16();
    }

    private void button36_Click(object sender, EventArgs e)
    {
        if (listView6.SelectedItems.Count > 0)
        {
            int index = int.Parse(listView6.SelectedItems[0].SubItems[4].Text);
            if (Class5.smethod_140(list_5[index].string_0, 1) != 1)
            {
                MessageBox.Show("自定义命令更新失败");
                return;
            }
            method_16();
            Class5.smethod_33();
        }
        else
        {
            MessageBox.Show("请选择一条自定义命令");
        }
    }

    private void button37_Click(object sender, EventArgs e)
    {
        if (listView6.SelectedItems.Count > 0)
        {
            int index = int.Parse(listView6.SelectedItems[0].SubItems[4].Text);
            if (Class5.smethod_140(list_5[index].string_0, 0) != 1)
            {
                MessageBox.Show("自定义命令更新失败");
                return;
            }
            method_16();
            Class5.smethod_33();
        }
        else
        {
            MessageBox.Show("请选择一条自定义命令");
        }
    }

    private void button38_Click(object sender, EventArgs e)
    {
        if (listView6.SelectedItems.Count > 0)
        {
            int index = int.Parse(listView6.SelectedItems[0].SubItems[4].Text);
            MessageBox.Show(list_5[index].string_9, "详细信息");
        }
        else
        {
            MessageBox.Show("请选择一条自定义命令");
        }
    }

    private void CenterManagerServerForm_FormClosing(object sender, FormClosingEventArgs e)

    {
        Process.GetCurrentProcess().Kill();
        if (MessageBox.Show("确认关闭 CenterManagerServer 吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        {

            e.Cancel = true;
        }
    }

    private void button26_Click(object sender, EventArgs e)
    {
        method_21();
    }

    private void button32_Click(object sender, EventArgs e)
    {
        Class6.smethod_0(2, "Center System 用户管理服务器停止运行", 0);
        Class12.class41_0.method_3();
        button26.Enabled = true;
    }

    private void button33_Click(object sender, EventArgs e)
    {
        new SettingForm().ShowDialog();
    }

    private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControl2.SelectedIndex == 1)
        {
            method_30();
        }
        else if (tabControl2.SelectedIndex == 2)
        {
            method_29();
        }
        else if (tabControl2.SelectedIndex == 3)
        {
            method_19();
        }
    }

    private void checkBox25_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
        if (checkBox25.Checked)
        {
            textBox8.Enabled = false;
        }
        else
        {
            textBox8.Enabled = true;
        }
    }

    private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        try
        {
            listView1.ListViewItemSorter = new Class42(int_6, sortOrder_0);
            var listView = sender as ListView;
            if (e.Column == (listView.ListViewItemSorter as Class42).method_2())
            {
                if ((listView.ListViewItemSorter as Class42).method_4() == System.Windows.Forms.SortOrder.Ascending)
                {
                    sortOrder_0 = System.Windows.Forms.SortOrder.Descending;
                    (listView.ListViewItemSorter as Class42).method_3(System.Windows.Forms.SortOrder.Descending);
                }
                else
                {
                    sortOrder_0 = System.Windows.Forms.SortOrder.Ascending;
                    (listView.ListViewItemSorter as Class42).method_3(System.Windows.Forms.SortOrder.Ascending);
                }
            }
            else
            {
                int_6 = e.Column;
                sortOrder_0 = System.Windows.Forms.SortOrder.Ascending;
                (listView.ListViewItemSorter as Class42).method_1(e.Column);
                (listView.ListViewItemSorter as Class42).method_3(System.Windows.Forms.SortOrder.Ascending);
            }
            ((ListView)sender).Sort();
            listView1.ListViewItemSorter = null;
        }
        catch
        {
        }
    }

    private void textBox6_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F11)
        {
            if (!textBox13.Visible)
            {
                textBox13.Visible = true;
            }

        }
    }

    private void button35_Click(object sender, EventArgs e)
    {
        Class5.smethod_38();
        Class6.smethod_0(2, "Center System 刷新炼金奖励完成", 0);
        Class5.smethod_37();
        Class6.smethod_0(2, "Center System 刷新击杀奖励完成", 0);
        Class5.smethod_39();
        Class6.smethod_0(2, "Center System 刷新炼金限制完成", 0);
        Class5.smethod_36();
        Class6.smethod_0(2, "Center System 刷新消费奖励完成", 0);
        Class5.smethod_35();
        Class6.smethod_0(2, "Center System 刷新满级奖励完成", 0);
        Class5.smethod_34();
        Class6.smethod_0(2, "Center System 刷新累计消费奖励完成", 0);
        Class5.smethod_33();
        Class6.smethod_0(2, "Center System 刷新游戏命令完成", 0);
        Class5.smethod_45();
        Class6.smethod_0(2, "Center System 刷新详细奖励完成", 0);
        Class5.smethod_44();
        Class6.smethod_0(2, "Center System 刷新多开信任完成", 0);
        Class5.smethod_46();
        Class6.smethod_0(2, "Center System 刷新技能限制完成", 0);
        Class12.class11_0.method_8();
        Class6.smethod_0(2, "Center System 刷新焕数据完成", 0);
    }

    private void button15_Click(object sender, EventArgs e)
    {
        if (!(textBox10.Text == "") && !(textBox9.Text == ""))
        {
            method_31();
        }
    }

    private void method_31()
    {
        try
        {
            int num = int.Parse(textBox10.Text);
            int int_ = int.Parse(textBox9.Text);
            int int_2 = int.Parse(textBox12.Text);
            int int_3 = int.Parse(textBox13.Text);
            if (!Class12.class3_0.method_9(num, int_, checkBox31.Checked, int_2, int_3))
            {
                Class6.smethod_0(2, "SQL Error: Send_Lucky_Silk False", 0);
            }
        }
        catch
        {
        }
    }
    private void timer_3_Tick(object sender, EventArgs e)
    {
        try
        {
            if (list_1 != null)
            {
                if (list_1.Count > 30)
                {
                    listBox1.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " 等待连接大于：" + list_1.Count + " 个,已全部忽略");
                    listBox1.TopIndex = listBox1.Items.Count - listBox1.Height / listBox1.ItemHeight;
                    list_1.Clear();
                }
                else if (list_1.Count > 0)
                {
                    listBox1.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + list_1[0].string_0);
                    listBox1.TopIndex = listBox1.Items.Count - listBox1.Height / listBox1.ItemHeight;
                    list_1.RemoveAt(0);
                }
            }
        }
        catch
        {
        }
    }

    private void button6_Click(object sender, EventArgs e)
    {
        new MultiTrustIPForm().ShowDialog();
    }

    private void button29_Click(object sender, EventArgs e)
    {
        new MoreRewardForm().ShowDialog();
        textBox9.Text = Class8.int_21.ToString();
    }

    private void button30_Click(object sender, EventArgs e)
    {
        new DisabledChatForm().ShowDialog();
    }

    private void button31_Click(object sender, EventArgs e)
    {
        var sendItemForm = new SendItemForm();
        sendItemForm.list_0 = Class12.class3_0.method_45();
        sendItemForm.Show();
    }

    private void checkBox15_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox16_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox17_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox18_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
        if (checkBox18.Checked)
        {
            textBox7.Enabled = false;
        }
        else
        {
            textBox7.Enabled = true;
        }
    }

    private void checkBox19_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
        if (checkBox19.Checked)
        {
            checkedListBox1.Enabled = false;
        }
        else
        {
            checkedListBox1.Enabled = true;
        }
    }

    private void checkBox21_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox20_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox23_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox24_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox10_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox11_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox8_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBoxMonsterKill_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBoxTradeDelay_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBoxAlchemy_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBoxNotAlchemy_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBoxLoginReward_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox_0_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox6_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox5_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBoxATTState_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox7_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }




    private delegate void AddOnlineDelegate(string message);
	/// <summary>
	/// 在在线框（lst_Online)中添加其他客户端信息
	/// </summary>
	/// <param name="userName"></param>
	private void CenterManagerServerForm_Load(object sender, EventArgs e) {
		zhujiemian();

	}

	







		private void zhujiemian() {
		try {
			Class6.delegate1_0 = method_4;
			Class15.smethod_1();
			if (Class8.int_31 > 0 && Class8.int_32 > 0 && Class8.int_33 > 0 && Class8.int_34 > 0) {
				Class15.ushort_2 = (ushort)Class15.Get_GamesCode();
				if (!method_5() || !method_6() || !method_7()) {
					return;
				}
				method_8();
				if (!method_9()) {
					return;
				}
				method_1();
				timer_2.Interval = 120000;
				timer_2.Start();
				timer_0.Start();
				timer_3.Start();
				timer_5.Start();
				method_20();
				method_17();
				method_16();
				method_15();
				if (!Class8.bool_57) {
					groupBox12.Enabled = false;
					labelDownloadCenter.Enabled = false;
				}
				if (Class8.bool_25) {
					method_21();
				}
				if (Class8.bool_10) {
					method_22();
				}
				if (Class8.bool_11) {
					dateTime_0 = DateTime.Now;
					Class8.bool_11 = true;
					new Thread(method_27).Start();
				}
				if (Class8.bool_17) {
					dateTime_1 = DateTime.Now;
					Class8.bool_17 = true;
					new Thread(method_26).Start();
				}
				if (Class5.smethod_134() < 1) {
					MessageBox.Show("SQL_Sys_Custom_Event_Start 执行失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					method_28();
					return;
				}
				Class8.bool_52 = true;
				new Thread(method_25).Start();
				if (Class5.smethod_6() < 1) {
					MessageBox.Show("SQL_Clear_CharOnlineInfo 执行失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					method_28();
					return;
				}
				Class8.bool_64 = Class5.smethod_23();
				if (Class8.bool_64) {
					Class6.smethod_0(2, "Center System 启动完成(R)", 0);
				}
				else {
					Class6.smethod_0(2, "Center System 启动完成", 0);
				}
				if (Class8.bool_58) {
					Class6.smethod_0(2, "Center System 数据加密已启用", 0);
				}
				Class24.class23_0.method_6(1, 0);
				Class12.class31_0.method_0();
				return;
			}
			MessageBox.Show("数据参数读取失败！");
			method_28();
		}
		catch {
			MessageBox.Show("CenterManagerServer_Load 检测到错误,无法启动！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			method_28();
		}
	}


	private void timer_0_Tick(object sender, EventArgs e) {
		try {
			int num2 = 0;
			string text = "";
			labelGatewaySend.Text = "网关服务器发送:" + Class12.class38_0.long_1 + " 字节";
			labelGatewayRecv.Text = "网关服务器接收:" + Class12.class38_0.long_0 + " 字节";
			labelAgentSend.Text = "代理服务器发送:" + Class12.class3_0.long_1 + " 字节";
			labelAgentRecv.Text = "代理服务器接收:" + Class12.class3_0.long_0 + " 字节";
			labelDownloadSend.Text = "下载服务器发送:" + Class12.class29_0.long_1 + " 字节";
			labelDownloadRecv.Text = "下载服务器接收:" + Class12.class29_0.long_0 + " 字节";
			Class12.class3_0.method_44(out int num, out int int_, out int int_2, out int int_3, out int int_4);
			labelAgentWaitRecv.Text = "代理服务器等待接收:" + num + " 字节";
			labelAgentWaitSend.Text = "代理服务器等待发送:" + int_ + " 字节";
			labelAgentCenter.Text = "代理服务器连接数:" + int_2;
			Class12.class38_0.method_20(out num, out int_, out int_2);
			labelGatewayWaitRecv.Text = "网关服务器等待接收:" + num + " 字节";
			labelGatewayWaitSend.Text = "网关服务器等待发送:" + int_ + " 字节";
			labelGatewayCenter.Text = "网关服务器连接数:" + int_2;
			Class12.class29_0.method_12(out num, out int_, out int_2);
			labelDownloadWaitRecv.Text = "下载服务器等待接收:" + num + " 字节";
			labelDownloadWaitSend.Text = "下载服务器等待发送:" + int_ + " 字节";
			labelDownloadCenter.Text = "下载服务器连接数:" + int_2;
			label6.Text = "禁止IP数量:" + Class13.list_0.Count;
			label8.Text = "代理服务器连接总数:" + Class12.class3_0.long_2;
			label9.Text = "代理服务器尝试连接总数:" + Class12.class3_0.long_3;
			label13.Text = "注册服务器数量总数:" + int_5;
			try {
				if (Class13.int_0 != 0) {
					num2 = (Class9.smethod_0() - Class13.int_0) / 1000;
					if (num2 > Class8.int_17) {
						Class12.class3_0.method_13();
					}
					text = Class13.string_0;
					if (text == "") {
						text = "*Sys*";
					}
					label1.Text = "活动超时:" + num2 + "/" + Class8.int_17;
					label2.Text = "活动角色名:" + text;
				}
				if (int_0 == 0) {
					int_0 = Class9.smethod_0();
				}
				else {
					int num3 = Class9.smethod_0() - int_0;
					if (num3 > 10000) {
						Class6.smethod_0(2, "Center System 检测到未响应时间 Time:" + num3, 0);
						Class7.smethod_3("TimeOutFailed.Log", DateTime.Now.ToString() + " Center System 检测到未响应时间 Time:" + num3);
					}
					int_0 = Class9.smethod_0();
				}
				if (bool_0 && Class8.byte_9 != 0) {
					if (int_1 == 0) {
						int_1 = Class9.smethod_0();
					}
					else if (Class9.smethod_0() - int_1 > 10000) {
						if (int_4 > 0) {
							if (int_4 == int_3) {
								Class6.smethod_1(2, "Center System 检测到未安装客户端组件(SCGControl.dll)");
							}
							else if (int_3 > 0) {
								Class6.smethod_1(2, "Center System 检测到有玩家未安装客户端组件(SCGControl.dll)");
							}
							bool_0 = false;
						}
						int_1 = Class9.smethod_0();
					}
				}
				if (!Class8.bool_64) {
					method_12();
				}
				method_13();
				method_10();
			}
			catch {
			}
		}
		catch {
		}
	}

	private void method_10() {
		try {
			if (checkBox27.Checked) {
				if (int_4 == 0) {
					int_4 = Class9.smethod_0();
				}
				else if ((Class9.smethod_0() - int_4) / 1000 > int.Parse(textBox11.Text)) {
					method_31();
					int_4 = Class9.smethod_0();
				}
			}
			if (checkBox18.Checked) {
				if (int_3 == 0) {
					int_3 = Class9.smethod_0();
				}
				else if ((Class9.smethod_0() - int_3) / 1000 > int.Parse(textBox7.Text)) {
					method_11();
					int_3 = Class9.smethod_0();
				}
			}
			if (!checkBox19.Checked) {
				return;
			}
			if (string_0 == "") {
				string[] array = Class8.string_40.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
				int num = 0;
				string s;
				while (true) {
					if (num < array.Length) {
						s = DateTime.Now.ToString("yyyy-MM-dd") + " " + array[num];
						if (DateTime.Parse(s) > DateTime.Now) {
							break;
						}
						num++;
						continue;
					}
					return;
				}
				string_0 = s;
			}
			else if (DateTime.Now >= DateTime.Parse(string_0)) {
				method_11();
				string_0 = "";
			}
		}
		catch {
		}
	}

	private void method_11() {
		try {
			switch (Class12.class3_0.method_12(1, int.Parse(textBox5.Text))) {
				case -1:
					Class7.smethod_2("0.0.0.0:0", "System Gift_Event_Start Info 已有红包活动在运行");
					break;
				case 1:
					button20.Enabled = false;
					label4.Text = "活动金珠数量:" + textBox5.Text;
					Class12.class3_0.method_21(Class9.smethod_43());
					break;
				default:
					Class7.smethod_2("0.0.0.0:0", "System Gift_Event_Start Error 2");
					break;
			}
		}
		catch {
		}
	}

	private void button2_Click(object sender, EventArgs e) {
		method_14();
	}

	private void method_12() {
		try {
			int num = 0;
			var intPtr = Class1.FindWindow("SR_ShardManager", "SR_ShardManager");
			if ((int)intPtr > 0) {
				bool flag = false;
				for (int i = 0; i < list_2.Count; i++) {
					if (list_2[i] == (int)intPtr) {
						flag = true;
					}
				}
				if (!flag) {
					Class1.GetWindowThreadProcessId(intPtr, out num);
				}
			}
			if (num > 0) {
				Class15.Set_UpdateSRServer(num, num);
				list_2.Add((int)intPtr);
			}
		}
		catch {
		}
	}

	private void method_13() {
		try {
			int num = 0;
			var intPtr = Class1.FindWindow("SR_GameServer", "SR_GameServer");
			if ((int)intPtr > 0) {
				bool flag = false;
				for (int i = 0; i < list_3.Count; i++) {
					if (list_3[i] == (int)intPtr) {
						flag = true;
					}
				}
				if (!flag) {
					Class1.GetWindowThreadProcessId(intPtr, out num);
				}
			}
			if (num > 0) {
				if (Class1.smethod_16(num, (1)) == 117) {
					Class1.smethod_15(num, (1), 235);
				}
				else if (Class1.smethod_16(num, (2)) == 117) {
					Class1.smethod_15(num, (2), 235);
				}
				else if (Class1.smethod_16(num, (3)) == 117) {
					Class1.smethod_15(num, (3), 235);
				}
				list_3.Add((int)intPtr);
			}
		}
		catch {
		}
	}

	private void method_14() {
		try {
			var list = new List<Struct29>(Class12.class3_0.method_45());
			if (list.Count > 0) {
				listView1.Items.Clear();
				for (int i = 0; i < list.Count; i++) {
					var @struct = list[i];
					var listViewItem = new ListViewItem();
					listViewItem.Text = @struct.string_0;
					listViewItem.SubItems.Add(@struct.string_1);
					listViewItem.SubItems.Add(@struct.string_5);
					string text = "";
					if (@struct.byte_0 == 1) {
						text = "选择角色";
					}
					else if (@struct.byte_0 == 2) {
						text = "进入游戏";
					}
					else if (@struct.byte_0 == 3) {
						text = "正在加载";
					}
					int num = 0;
					if (@struct.int_1 > 0) {
						num = (Class9.smethod_0() - @struct.int_1) / 60000;
					}
					listViewItem.SubItems.Add(text);
					listViewItem.SubItems.Add(@struct.int_0 + " ms");
					listViewItem.SubItems.Add(num + " Min");
					listViewItem.SubItems.Add(@struct.string_3);
					listViewItem.SubItems.Add(@struct.intptr_0.ToString());
					listView1.Items.Add(listViewItem);
				}
			}
			else {
				listView1.Items.Clear();
			}
		}
		catch {
		}
	}

	private void button3_Click(object sender, EventArgs e) {
		new AddNoticeForm().ShowDialog();
		Class5.smethod_40();
		method_17();
	}

	private void button5_Click(object sender, EventArgs e) {
		if (listView2.SelectedItems.Count > 0) {
			var updNoticeForm = new UpdNoticeForm();
			updNoticeForm.struct41_0 = new Struct41(Convert.ToByte(listView2.SelectedItems[0].SubItems[0].Text), Convert.ToInt32(listView2.SelectedItems[0].SubItems[1].Text), listView2.SelectedItems[0].SubItems[2].Text, listView2.SelectedItems[0].SubItems[3].Text, listView2.SelectedItems[0].SubItems[4].Text);
			updNoticeForm.ShowDialog();
			Class5.smethod_40();
			method_17();
		}
		else {
			MessageBox.Show("请选择一条公告");
		}
	}

	private void method_15() {
		listView8.Items.Clear();
		var list = new List<Struct50>(Class5.smethod_136());
		for (int i = 0; i < list.Count; i++) {
			var listViewItem = new ListViewItem();
			switch (list[i].int_0) {
				case 1:
					listViewItem.Text = "开启";
					break;
				case 0:
					listViewItem.Text = "关闭";
					break;
				default:
					listViewItem.Text = "未知";
					break;
			}
			listViewItem.SubItems.Add(list[i].string_0);
			listViewItem.SubItems.Add(list[i].string_1);
			if (list[i].int_2 == 1) {
				if (list[i].string_2 == "1") {
					listViewItem.SubItems.Add("启用");
				}
				else if (list[i].string_2 == "0") {
					listViewItem.SubItems.Add("禁用");
				}
				else {
					listViewItem.SubItems.Add(list[i].string_2);
				}
			}
			else {
				listViewItem.SubItems.Add(list[i].string_2);
			}
			listViewItem.SubItems.Add(list[i].string_3);
			listViewItem.SubItems.Add(list[i].string_4);
			listViewItem.SubItems.Add(list[i].int_1.ToString());
			listViewItem.SubItems.Add(list[i].int_2.ToString());
			listViewItem.SubItems.Add(i.ToString());
			listView8.Items.Add(listViewItem);
		}
	}

	private void method_16() {
		listView6.Items.Clear();
		list_5 = new List<Struct7>(Class5.smethod_137());
		for (int i = 0; i < list_5.Count; i++) {
			var listViewItem = new ListViewItem();
			switch (list_5[i].int_0) {
				case 1:
					listViewItem.Text = "开启";
					break;
				case 0:
					listViewItem.Text = "关闭";
					break;
				default:
					listViewItem.Text = "未知";
					break;
			}
			listViewItem.SubItems.Add(list_5[i].string_0);
			listViewItem.SubItems.Add(list_5[i].string_1);
			listViewItem.SubItems.Add(list_5[i].string_8);
			listViewItem.SubItems.Add(i.ToString());
			listView6.Items.Add(listViewItem);
		}
	}

	private void method_17() {
		listView2.Items.Clear();
		for (int i = 0; i < Class5.list_2.Count; i++) {
			var listViewItem = new ListViewItem();
			listViewItem.Text = Class5.list_2[i].byte_0.ToString();
			listViewItem.SubItems.Add(Class5.list_2[i].int_0.ToString());
			listViewItem.SubItems.Add(Class5.list_2[i].string_0);
			listViewItem.SubItems.Add(Class5.list_2[i].string_1);
			listViewItem.SubItems.Add(Class5.list_2[i].string_2);
			listView2.Items.Add(listViewItem);
		}
	}

	private void method_18(bool bool_2 = true) {
		try {
			if (bool_2) {
				Class5.smethod_41();
			}
			listView9.Items.Clear();
			for (int i = 0; i < Class5.list_3.Count; i++) {
				var value = new ListViewItem(new string[6]
				{
					Class5.list_3[i].byte_0.ToString(),
					Class5.list_3[i].int_0.ToString(),
					Class5.list_3[i].byte_1.ToString(),
					Class5.list_3[i].string_0.ToString(),
					Class5.list_3[i].dateTime_0.ToString(),
					Class5.list_3[i].string_1.ToString()
				});
				listView9.Items.Add(value);
			}
		}
		catch {
		}
	}

	private void method_19() {
		listView7.Items.Clear();
		list_4 = new List<Struct51>(Class5.smethod_138());
		for (int i = 0; i < list_4.Count; i++) {
			var listViewItem = new ListViewItem();
			switch (list_4[i].int_0) {
				case 1:
					listViewItem.Text = "开启";
					break;
				case 0:
					listViewItem.Text = "关闭";
					break;
				default:
					listViewItem.Text = "未知";
					break;
			}
			listViewItem.SubItems.Add(list_4[i].string_0);
			listViewItem.SubItems.Add(list_4[i].string_1);
			switch (list_4[i].int_2) {
				case 1:
					listViewItem.SubItems.Add("开始活动");
					break;
				case 2:
					listViewItem.SubItems.Add("停止活动");
					break;
				case 3:
					listViewItem.SubItems.Add("发放奖励");
					break;
				default:
					listViewItem.SubItems.Add("未知");
					break;
			}
			switch (list_4[i].int_5) {
				case 0:
					listViewItem.SubItems.Add("未执行");
					break;
				case 1:
					listViewItem.SubItems.Add("已执行");
					break;
				default:
					listViewItem.SubItems.Add("未知");
					break;
			}
			if (list_4[i].int_3 > 0) {
				listViewItem.SubItems.Add("有奖励");
			}
			else {
				listViewItem.SubItems.Add("无奖励");
			}
			listViewItem.SubItems.Add(list_4[i].string_3);
			listViewItem.SubItems.Add(i.ToString());
			listView7.Items.Add(listViewItem);
		}
	}

	private void method_20() {
		listView3.Items.Clear();
		Class13.list_0 = Class5.list_5;
		for (int i = 0; i < Class5.list_5.Count; i++) {
			var listViewItem = new ListViewItem();
			listViewItem.Text = Class5.list_5[i].byte_0.ToString();
			listViewItem.SubItems.Add(Class5.list_5[i].string_0);
			listViewItem.SubItems.Add(Class5.list_5[i].byte_1.ToString());
			listViewItem.SubItems.Add(Class5.list_5[i].string_1);
			listView3.Items.Add(listViewItem);
		}
	}

	private void button4_Click(object sender, EventArgs e) {
		if (listView2.SelectedItems.Count > 0) {
			if (Class5.smethod_92(Convert.ToInt32(listView2.SelectedItems[0].SubItems[1].Text)) != 1) {
				MessageBox.Show("删除失败！");
				return;
			}
			Class5.smethod_40();
			method_17();
		}
		else {
			MessageBox.Show("请选择一条公告");
		}
	}

	private void button1_Click(object sender, EventArgs e) {
		method_17();
	}

	private void button17_Click(object sender, EventArgs e) {
		method_22();
	}

	private void button18_Click(object sender, EventArgs e) {
		method_23();
	}

	private void method_21() {
		button26.Enabled = false;
		Class12.class41_0.method_1(Class8.ushort_11);
		if (!Class12.class41_0.method_2()) {
			Class6.smethod_0(2, "Center System 用户管理服务器启动失败", 0);
			button26.Enabled = true;
		}
		else {
			Class6.smethod_0(2, "Center System 用户管理服务器启动完成", 0);
		}
	}

	private void method_22() {
		timer_1.Interval = Class8.int_5 * 60000;
		timer_1.Start();
		button17.Enabled = false;
		label7.Text = "延迟时间（分钟）：" + Class8.int_5;
	}

	private void method_23() {
		timer_1.Stop();
		button17.Enabled = true;
		label7.Text = "延迟时间（分钟）：0";
	}

	private void timer_1_Tick(object sender, EventArgs e) {
		try {
			var list = new List<Struct41>();
			for (int i = 0; i < Class5.list_2.Count; i++) {
				if (Class5.list_2[i].byte_0 == 1 && DateTime.Now > DateTime.Parse(Class5.list_2[i].string_0) && DateTime.Now < DateTime.Parse(Class5.list_2[i].string_1)) {
					list.Add(Class5.list_2[i]);
				}
			}
			int count = list.Count;
			if (count > 0) {
				if (int_2 >= count) {
					Class12.class3_0.method_21(list[0].string_2);
					int_2 = 1;
				}
				else {
					Class12.class3_0.method_21(list[int_2].string_2);
					int_2++;
				}
			}
		}
		catch {
		}
	}

	private void button8_Click(object sender, EventArgs e) {
		if (textBox1.Text == "") {
			MessageBox.Show("公告内容不能为空！");
			return;
		}
		Class12.class3_0.method_21(textBox1.Text);
		textBox1.Text = "";
	}

	private void method_24() {
		if (listView1.SelectedItems.Count <= 0) {
			return;
		}
		if (listView1.SelectedItems.Count == 1) {
			if (Class12.class3_0.method_16((IntPtr)int.Parse(listView1.SelectedItems[0].SubItems[7].Text))) {
				int index = listView1.SelectedItems[0].Index;
				listView1.Items[index].Remove();
			}
			else {
				MessageBox.Show("踢出失败！");
			}
			return;
		}
		var array = new IntPtr[listView1.SelectedItems.Count];
		if (array == null || array.Length == 0) {
			return;
		}
		for (int i = 0; i < listView1.SelectedItems.Count; i++) {
			array[i] = (IntPtr)int.Parse(listView1.SelectedItems[i].SubItems[7].Text);
		}
		if (!Class12.class3_0.method_15(array)) {
			MessageBox.Show("踢出失败！");
			return;
		}
		for (int j = 0; j < array.Length; j++) {
			for (int k = 0; k < listView1.Items.Count; k++) {
				if (listView1.Items[k].SubItems[7].Text == array[j].ToInt32().ToString()) {
					int index2 = listView1.Items[k].Index;
					listView1.Items[index2].Remove();
					break;
				}
			}
		}
	}

	private void button9_Click(object sender, EventArgs e) {
		method_24();
	}

	private void button11_Click(object sender, EventArgs e) {
		method_20();
	}

	private void button12_Click(object sender, EventArgs e) {
		new AddIPForm(0).ShowDialog();
		Class5.smethod_42();
		method_20();
	}

	private void button13_Click(object sender, EventArgs e) {
		if (listView3.SelectedItems.Count > 0) {
			var updIPForm = new UpdIPForm(0);
			updIPForm.byte_0 = Convert.ToByte(listView3.SelectedItems[0].SubItems[0].Text);
			updIPForm.byte_1 = Convert.ToByte(listView3.SelectedItems[0].SubItems[2].Text);
			updIPForm.string_0 = listView3.SelectedItems[0].SubItems[3].Text;
			updIPForm.ShowDialog();
			Class5.smethod_42();
			method_20();
		}
		else {
			MessageBox.Show("请选择一条IP");
		}
	}

	private void button10_Click(object sender, EventArgs e) {
		if (listView3.SelectedItems.Count > 0) {
			if (!Class13.smethod_5(listView3.SelectedItems[0].SubItems[3].Text)) {
				MessageBox.Show("ManageDelIPList 删除失败！");
				return;
			}
			if (Class5.smethod_98(byte.Parse(listView3.SelectedItems[0].SubItems[2].Text), listView3.SelectedItems[0].SubItems[3].Text) != 1) {
				MessageBox.Show("删除失败！");
				return;
			}
			Class5.smethod_42();
			method_20();
		}
		else {
			MessageBox.Show("请选择一条IP");
		}
	}
    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void button7_Click(object sender, EventArgs e)
    {
        new NewGuideEditForm().ShowDialog();
        method_0();
    }

    private void checkBox26_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox27_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
        if (checkBox27.Checked)
        {
            textBox11.Enabled = false;
        }
        else
        {
            textBox11.Enabled = true;
        }
    }

    private void checkBox28_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox31_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
        if (checkBox31.Checked)
        {
            textBox9.Enabled = false;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
        }
        else
        {
            textBox9.Enabled = true;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
        }
    }

    private void checkBox33_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox32_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox34_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void textBox5_Leave(object sender, EventArgs e)
    {
        method_0();
    }

    private void textBox8_Leave(object sender, EventArgs e)
    {
        method_0();
    }

    private void textBox11_Leave(object sender, EventArgs e)
    {
        method_0();
    }

    private void textBox9_Leave(object sender, EventArgs e)
    {
        method_0();
    }

    private void textBox12_Leave(object sender, EventArgs e)
    {
        method_0();
    }

    private void textBox13_Leave(object sender, EventArgs e)
    {
        method_0();
    }

    private void textBox10_Leave(object sender, EventArgs e)
    {
        method_0();
    }

    private void textBox7_Leave(object sender, EventArgs e)
    {
        method_0();
    }

    private void textBox6_Leave(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox35_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void button39_Click(object sender, EventArgs e)
    {
        method_19();
    }

    private void button41_Click(object sender, EventArgs e)
    {
        if (listView7.SelectedItems.Count > 0)
        {
            int index = int.Parse(listView7.SelectedItems[0].SubItems[7].Text);
            if (Class5.smethod_139(list_4[index].int_1, 0) != 1)
            {
                MessageBox.Show("自定义事件更新失败");
            }
            else
            {
                method_19();
            }
        }
        else
        {
            MessageBox.Show("请选择一条自定义事件");
        }
    }

    private void button42_Click(object sender, EventArgs e)
    {
        if (listView7.SelectedItems.Count > 0)
        {
            int index = int.Parse(listView7.SelectedItems[0].SubItems[7].Text);
            if (Class5.smethod_139(list_4[index].int_1, 1) != 1)
            {
                MessageBox.Show("自定义事件更新失败");
            }
            else if (Class5.smethod_135(list_4[index].int_1) < 1)
            {
                MessageBox.Show("SQL_Sys_Custom_Event_Initial 初始失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                method_19();
            }
        }
        else
        {
            MessageBox.Show("请选择一条自定义事件");
        }
    }

    private void button40_Click(object sender, EventArgs e)
    {
        if (listView7.SelectedItems.Count > 0)
        {
            int index = int.Parse(listView7.SelectedItems[0].SubItems[7].Text);
            MessageBox.Show(list_4[index].string_4, "详细信息");
        }
        else
        {
            MessageBox.Show("请选择一条自定义事件");
        }
    }

    private void button43_Click(object sender, EventArgs e)
    {
        MessageBox.Show(string.Concat("" + Class12.class3_0.method_61().Count + Environment.NewLine, Class12.class38_0.list_0.Count.ToString(), Environment.NewLine));
    }

    private void button45_Click(object sender, EventArgs e)
    {
        try
        {
            string text = "";
            var list = Class12.class3_0.method_61();
            for (int i = 0; i < list.Count; i++)
            {
                text = text + list[i].intptr_0.ToInt32() + "|";
                text = text + list[i].intptr_1.ToInt32() + "|";
                text = text + list[i].string_3 + "|";
                text = text + list[i].string_4 + "|";
                text = ((list[i].byte_0 == null) ? (text + "null|") : (text + BitConverter.ToString(list[i].byte_0) + "|"));
                text = ((list[i].byte_1 == null) ? (text + "null|") : (text + BitConverter.ToString(list[i].byte_1) + "|"));
                text = text + list[i].int_11 + "|";
                text = text + list[i].int_10 + "|";
                text = text + list[i].byte_4 + "|";
                text = text + list[i].uint_0 + "|";
                text = text + list[i].int_7 + Environment.NewLine;
            }
            Class7.smethod_3("ClientList.txt", text);
        }
        catch
        {
        }
    }

    private void checkBox37_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox38_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox39_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void checkBox40_CheckedChanged(object sender, EventArgs e)
    {
        method_0();
    }

    private void timer_4_Tick(object sender, EventArgs e)
    {
        Class7.smethod_2("0.0.0.0:0", "Center System:Msg Exit");
        timer_4.Stop();
        method_28();
    }

    private void button44_Click(object sender, EventArgs e)
    {
        method_15();
    }

    private void button46_Click(object sender, EventArgs e)
    {
        if (listView8.SelectedItems.Count > 0)
        {
            if (int.Parse(listView8.SelectedItems[0].SubItems[7].Text) == 3)
            {
                var appSettingRankEditForm = new AppSettingRankEditForm();
                appSettingRankEditForm.int_1 = int.Parse(listView8.SelectedItems[0].SubItems[6].Text);
                appSettingRankEditForm.string_0 = listView8.SelectedItems[0].SubItems[3].Text;
                appSettingRankEditForm.int_0 = int.Parse(listView8.SelectedItems[0].SubItems[7].Text);
                appSettingRankEditForm.ShowDialog();
            }
            else
            {
                var appSettingEditForm = new AppSettingEditForm();
                appSettingEditForm.int_1 = int.Parse(listView8.SelectedItems[0].SubItems[6].Text);
                appSettingEditForm.string_0 = listView8.SelectedItems[0].SubItems[3].Text;
                appSettingEditForm.int_0 = int.Parse(listView8.SelectedItems[0].SubItems[7].Text);
                appSettingEditForm.ShowDialog();
            }
            method_15();
        }
        else
        {
            MessageBox.Show("请选择一条功能选项");
        }
    }

    private void button47_Click(object sender, EventArgs e)
    {
        if (listView8.SelectedItems.Count > 0)
        {
            MessageBox.Show(listView8.SelectedItems[0].SubItems[5].Text, "详细信息");
        }
        else
        {
            MessageBox.Show("请选择一条功能选项");
        }
    }

    private void button48_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems.Count == 1)
        {
            try
            {
                Class9.smethod_28(Class12.class3_0.method_61()[0].intptr_0, Class12.class3_0.method_61()[0].int_14, 1);
            }
            catch
            {
            }
        }
    }

    private void method_32(object sender, CancelEventArgs e)
    {
        try
        {
            if (listView1.SelectedItems.Count > 0)
            {
                toolStripMenuItem1.Enabled = true;
                toolStripMenuItem2.Enabled = true;
                toolStripMenuItem3.Enabled = true;
            }
            else
            {
                toolStripMenuItem1.Enabled = false;
                toolStripMenuItem2.Enabled = false;
                toolStripMenuItem3.Enabled = false;
            }
        }
        catch
        {
        }
    }
    private void checkBox4_CheckedChanged(object sender, EventArgs e) {
		if (checkBox4.Checked) {
			if (!Class8.bool_11) {
				dateTime_0 = DateTime.Now;
				Class8.bool_11 = true;
				new Thread(method_27).Start();
			}
		}
		else {
			Class8.bool_11 = false;
		}
		method_0();
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e) {
		if (checkBox9.Checked) {
			if (!Class8.bool_17) {
				dateTime_1 = DateTime.Now;
				Class8.bool_17 = true;
				new Thread(method_26).Start();
			}
		}
		else {
			Class8.bool_17 = false;
		}
		method_0();
	}

	private void method_25() {
		while (Class8.bool_52) {
			try {
				Class5.smethod_133();
				Thread.Sleep(1000);
			}
			catch {
			}
		}
	}

	private void method_26() {
		try {
			var sqlConnection = new SqlConnection(Class8.string_3);
			sqlConnection.Open();
			while (Class8.bool_17) {
				try {
					var sqlDataReader = new SqlCommand("SELECT TOP 1 * FROM [dbo].[_GameCustomFunction] WHERE [Time] > '" + dateTime_1.ToString() + "' and SendState = 0", sqlConnection).ExecuteReader();
					if (sqlDataReader.Read()) {
						long @int = sqlDataReader.GetInt64(0);
						sqlDataReader.GetDateTime(1).ToString();
						byte @byte = sqlDataReader.GetByte(2);
						byte byte2 = sqlDataReader.GetByte(3);
						string @string = sqlDataReader.GetString(4);
						int int2 = sqlDataReader.GetInt32(5);
						string string2 = sqlDataReader.GetString(6);
						sqlDataReader.GetByte(7);
						int num = 0;
						sqlDataReader.Close();
						switch (@byte) {
							case 1:
								if (Class12.class3_0.method_17(@string)) {
									num = 1;
								}
								break;
							case 2:
								num = Class12.class3_0.method_25(@string, int2, 7, bool_2: true, bool_3: false);
								break;
							case 3:
								num = 1;
								break;
							case 5:
								Class12.class31_0.method_3(string2);
								break;
						}
						if (byte2 == 0) {
							Class12.class3_0.method_23(@string, string2);
						}
						else {
							Class12.class3_0.method_21(string2);
						}
						new SqlCommand("UPDATE TOP(1) [dbo].[_GameCustomFunction] SET SendState = 1,ReturnError = " + num + " WHERE SendState = 0 AND ID = " + @int, sqlConnection).ExecuteNonQuery();
					}
					else {
						sqlDataReader.Close();
					}
				}
				catch {
					sqlConnection.Close();
					return;
				}
				if (Class8.int_14 == 0) {
					Thread.Sleep(500);
				}
				else {
					Thread.Sleep(Class8.int_14 * 1000);
				}
			}
			sqlConnection.Close();
		}
		catch {
		}
	}

	private void method_27() {
		try {
			var sqlConnection = new SqlConnection(Class8.string_3);
			sqlConnection.Open();
			while (Class8.bool_11) {
				try {
					var sqlDataReader = new SqlCommand("SELECT TOP 1 * FROM [dbo].[_GameCustomNotice] WHERE [Time] > '" + dateTime_0.ToString() + "' and SendState = 0", sqlConnection).ExecuteReader();
					if (sqlDataReader.Read()) {
						long @int = sqlDataReader.GetInt64(0);
						sqlDataReader.GetDateTime(1).ToString();
						string @string = sqlDataReader.GetString(2);
						sqlDataReader.GetByte(3);
						sqlDataReader.Close();
						Class12.class3_0.method_21(@string);
						new SqlCommand("UPDATE TOP(1) [dbo].[_GameCustomNotice] SET SendState = 1 WHERE SendState = 0 AND ID = " + @int, sqlConnection).ExecuteNonQuery();
					}
					else {
						sqlDataReader.Close();
					}
				}
				catch {
					sqlConnection.Close();
					return;
				}
				if (Class8.int_6 == 0) {
					Thread.Sleep(500);
				}
				else {
					Thread.Sleep(Class8.int_6 * 1000);
				}
			}
			sqlConnection.Close();
		}
		catch {
		}
	}

	private void button14_Click(object sender, EventArgs e) {
		var sendSilkForm = new SendSilkForm();
		sendSilkForm.list_0 = Class12.class3_0.method_45();
		sendSilkForm.Show();
	}

	private void button16_Click(object sender, EventArgs e) {
		if (listView1.Items.Count < 1) {
			return;
		}
		if (textBox2.Text == "") {
			MessageBox.Show("请填写要搜索的内容！");
			return;
		}
		listViewItem_0 = listView1.FindItemWithText(textBox2.Text, includeSubItemsInSearch: true, 0, isPrefixSearch: true);
		if (listViewItem_0 != null) {
			listViewItem_0.BackColor = Color.Peru;
			listView1.TopItem = listViewItem_0;
		}
		else {
			MessageBox.Show("没有找到信息");
		}
	}

	private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
		try {
			if (listViewItem_0 != null && listViewItem_0.BackColor != listView1.BackColor) {
				listViewItem_0.BackColor = listView1.BackColor;
			}
		}
		catch {
		}
	}

	private void button19_Click(object sender, EventArgs e) {
		switch (Class5.smethod_74()) {
			case 1:
				Class6.smethod_0(2, "Center System 清除刺陵防御用户数据完成", 0);
				MessageBox.Show("清除刺陵防御用户数据完成！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			case -1:
				MessageBox.Show("_LogCharLogin 清除数据失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			case -2:
				MessageBox.Show("_LogSendSilk 清除数据失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			case -3:
				MessageBox.Show("_LogAlchemy 清除数据失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			case -4:
				MessageBox.Show("_GameCustomNotice 清除数据失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			case -5:
				MessageBox.Show("_CharTeamRegister 清除数据失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			case -6:
				MessageBox.Show("_CharSellRegister 清除数据失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			case -7:
				MessageBox.Show("_CharLogin 清除数据失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			default:
				MessageBox.Show("清除数据失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
		}
	}

	private void method_28(bool bool_2 = false) {
		try {
			if (bool_2) {
				if (Class12.class41_0.method_0() != 0) {
					Class12.class41_0.method_3();
				}
				if (Class12.class40_0.method_0() != 0) {
					Class12.class40_0.method_3();
				}
				Class12.class36_0.method_7();
				Class12.class38_0.method_7();
				Class12.class29_0.method_7();
				Class12.class33_0.method_7();
				Class12.class3_0.method_35();
				Class12.class11_0.method_1();
				Class24.class23_0.method_1();
				Class12.class31_0.method_1();
				Class8.bool_11 = false;
				Class8.bool_17 = false;
				Class8.bool_52 = false;
				Application.OpenForms["LoginForm"].Dispose();
				return;
			}
			if (Class12.class41_0.method_0() != 0) {
				Class12.class41_0.method_3();
			}
			if (Class12.class40_0.method_0() != 0) {
				Class12.class40_0.method_3();
			}
			Class12.class36_0.method_7();
			Class12.class38_0.method_7();
			Class12.class29_0.method_7();
			Class12.class33_0.method_7();
			Class12.class3_0.method_35();
			Class12.class11_0.method_1();
			Class24.class23_0.method_1();
			Class12.class31_0.method_1();
			Class8.bool_11 = false;
			Class8.bool_17 = false;
			Class8.bool_52 = false;
			Application.OpenForms["LoginForm"].Dispose();
			Dispose();
		}
		catch {
			Environment.Exit(0);
		}
	}

	private void CenterManagerServerForm_FormClosed(object sender, FormClosedEventArgs e) {
		Class6.smethod_0(2, "Center System Exit", 0);
		Class7.smethod_2("0.0.0.0:0", "Center System:Exit");
		method_28(bool_2: true);
	}

	private void timer_2_Tick(object sender, EventArgs e) {
		try {
			if (checkBox5.Checked && Class13.list_0.Count > 0) {
				listView3.Items.Clear();
				Class13.smethod_1();
				if (!Class5.smethod_97()) {
					Class7.smethod_2("0.0.0.0:0", "SQL Error:SQL_Cle_BlockedIP");
				}
			}
		}
		catch {
		}
	}

	private void button20_Click(object sender, EventArgs e) {
		switch (Class12.class3_0.method_12(1, int.Parse(textBox5.Text))) {
			case -1:
				MessageBox.Show("有活动在进行");
				break;
			case 1:
				button20.Enabled = false;
				label4.Text = "活动金珠数量:" + textBox5.Text;
				Class12.class3_0.method_21(Class9.smethod_43());
				break;
			default:
				Class6.smethod_0(2, "System Gift_Event_Start Error 1", 0);
				break;
		}
	}

	private void button21_Click(object sender, EventArgs e) {
		Class12.class3_0.method_13();
	}

	private void button22_Click(object sender, EventArgs e) {
		if (textBox4.Text == "") {
			MessageBox.Show("公告内容不能为空！");
			return;
		}
		Class12.class3_0.method_21(textBox4.Text);
		textBox4.Text = "";
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e) {
		if (checkBox12.Checked) {
			Class12.class38_0.bool_0 = false;
		}
		else {
			Class12.class38_0.bool_0 = true;
		}
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e) {
		if (checkBox13.Checked) {
			Class12.class3_0.bool_0 = false;
		}
		else {
			Class12.class3_0.bool_0 = true;
		}
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e) {
		if (checkBox14.Checked) {
			textBox6.Enabled = false;
			Class12.class38_0.string_0 = textBox6.Text;
			Class12.class3_0.string_0 = textBox6.Text;
			Class12.class29_0.string_0 = textBox6.Text;
		}
		else {
			textBox6.Enabled = true;
			Class12.class38_0.string_0 = "";
			Class12.class3_0.string_0 = "";
			Class12.class29_0.string_0 = "";
		}
	}

	private void button24_Click(object sender, EventArgs e) {
		if (Class5.smethod_120() != 1) {
			MessageBox.Show("_CharShopSilkRanking 清除数据失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		listView4.Items.Clear();
		Class6.smethod_0(2, "Center System 重置消费排行榜完成", 0);
	}

	private void button23_Click(object sender, EventArgs e) {
		if (Class5.smethod_119() != 1) {
			MessageBox.Show("刷新消费排行榜失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else {
			method_30();
		}
	}

	private void button25_Click(object sender, EventArgs e) {
		for (int i = 0; i < listView4.Items.Count; i++) {
			int num = int.Parse(listView4.Items[i].SubItems[3].Text);
			if (num > 0) {
				int num2 = Class12.class3_0.method_25(listView4.Items[i].SubItems[1].Text, num, 12, bool_2: true, bool_3: false, Class8.string_39[0] + num + Class8.string_39[1]);
				if (!Class5.smethod_48(listView4.Items[i].SubItems[1].Text, num2)) {
					num2 = -10;
				}
				if (num2 == 1) {
					listView4.Items[i].SubItems[4].Text = "成功";
				}
				else {
					listView4.Items[i].SubItems[4].Text = num2.ToString();
				}
			}
		}
	}

	private void method_29() {
		var list = new List<Struct47>(Class5.smethod_0());
		if (list == null) {
			return;
		}
		listView5.Items.Clear();
		for (int i = 0; i < list.Count; i++) {
			var listViewItem = new ListViewItem();
			listViewItem.Text = list[i].string_0;
			listViewItem.SubItems.Add(list[i].int_0.ToString());
			listViewItem.SubItems.Add(list[i].string_1);
			listViewItem.SubItems.Add(list[i].byte_0.ToString());
			listViewItem.SubItems.Add(list[i].int_1.ToString());
			if (list[i].int_2 == 1) {
				listViewItem.SubItems.Add("成功");
			}
			else if (list[i].int_2 == 0) {
				listViewItem.SubItems.Add("未发送");
			}
			else {
				listViewItem.SubItems.Add("失败");
			}
			listView5.Items.Add(listViewItem);
		}
	}

	private void method_30() {
		var list = new List<Struct48>(Class5.smethod_1());
		if (list == null) {
			return;
		}
		listView4.Items.Clear();
		for (int i = 0; i < list.Count; i++) {
			var listViewItem = new ListViewItem();
			listViewItem.Text = list[i].int_0.ToString();
			listViewItem.SubItems.Add(list[i].string_0);
			listViewItem.SubItems.Add(list[i].int_1.ToString());
			listViewItem.SubItems.Add(Class9.smethod_5(list[i].int_0).ToString());
			if (list[i].int_2 == 1) {
				listViewItem.SubItems.Add("成功");
			}
			else if (list[i].int_2 == 0) {
				listViewItem.SubItems.Add("未发送");
			}
			else {
				listViewItem.SubItems.Add("失败");
			}
			listView4.Items.Add(listViewItem);
		}
	}

	private void button27_Click(object sender, EventArgs e) {
		method_29();
	}

	private void button28_Click(object sender, EventArgs e) {
		for (int i = 0; i < listView5.Items.Count; i++) {
			int num = int.Parse(listView5.Items[i].SubItems[4].Text);
			if (num > 0) {
				int num2 = Class12.class3_0.method_25(listView5.Items[i].SubItems[2].Text, num, 13, bool_2: true, bool_3: false, Class8.string_37[0] + num + Class8.string_37[1]);
				if (!Class5.smethod_47(listView5.Items[i].SubItems[2].Text, num2)) {
					num2 = -10;
				}
				if (num2 == 1) {
					listView5.Items[i].SubItems[5].Text = "成功";
				}
				else {
					listView5.Items[i].SubItems[5].Text = num2.ToString();
				}
			}
		}
	}





	private void toolStripMenuItem2_Click(object sender, EventArgs e) {
		if (listView1.SelectedItems.Count != 1) {
			return;
		}
		if (Class5.smethod_95(1, 0, Class9.smethod_45(listView1.SelectedItems[0].SubItems[2].Text)) != 1) {
			MessageBox.Show("添加失败！");
			return;
		}
		if (Class12.class3_0.method_16((IntPtr)int.Parse(listView1.SelectedItems[0].SubItems[7].Text))) {
			int index = listView1.SelectedItems[0].Index;
			listView1.Items[index].Remove();
		}
		Class5.smethod_42();
	}

	private void toolStripMenuItem3_Click(object sender, EventArgs e) {
		if (listView1.SelectedItems.Count != 1) {
			return;
		}
		if (listView1.SelectedItems[0].SubItems[6].Text == "") {
			MessageBox.Show("该玩家还没有进入游戏，不能添加机器码封禁！");
			return;
		}
		if (Class5.smethod_95(1, 1, listView1.SelectedItems[0].SubItems[6].Text) != 1) {
			MessageBox.Show("添加失败！");
			return;
		}
		if (Class12.class3_0.method_16((IntPtr)int.Parse(listView1.SelectedItems[0].SubItems[7].Text))) {
			int index = listView1.SelectedItems[0].Index;
			listView1.Items[index].Remove();
		}
		Class5.smethod_42();
	}

	private void toolStripMenuItem1_Click(object sender, EventArgs e) {
		method_24();
	}

	private void toolStripMenuItem4_Click(object sender, EventArgs e) {
		if (listView1.SelectedItems.Count == 1) {
			if (Class5.smethod_99(1, 0, Class9.smethod_45(listView1.SelectedItems[0].SubItems[2].Text)) != 1) {
				MessageBox.Show("添加失败！");
			}
			else {
				Class5.smethod_44();
			}
		}
	}

	private void toolStripMenuItem5_Click(object sender, EventArgs e) {
		if (listView1.SelectedItems.Count == 1) {
			if (listView1.SelectedItems[0].SubItems[6].Text == "") {
				MessageBox.Show("该玩家还没有进入游戏，不能添加机器码封禁！");
			}
			else if (Class5.smethod_99(1, 1, listView1.SelectedItems[0].SubItems[6].Text) != 1) {
				MessageBox.Show("添加失败！");
			}
			else {
				Class5.smethod_44();
			}
		}
	}

	private void button49_Click(object sender, EventArgs e) {
		method_18(bool_2: false);
	}

	private void timer_5_Tick(object sender, EventArgs e) {
		try {
			for (int i = 0; i < Class5.list_3.Count; i++) {
				if (Class5.list_3[i].byte_0 != 1) {
					continue;
				}
				if (Class5.list_3[i].byte_1 == 1) {
					var timeSpan = TimeSpan.Parse(Class5.list_3[i].string_0);
					if (Class5.list_3[i].dateTime_0 == DateTime.MinValue) {
						if (DateTime.Now.TimeOfDay >= timeSpan) {
							var value = Class5.list_3[i];
							value.dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds).AddDays(1.0);
							Class5.list_3[i] = value;
						}
						else {
							var value2 = Class5.list_3[i];
							value2.dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
							Class5.list_3[i] = value2;
						}
					}
					else if (DateTime.Now >= Class5.list_3[i].dateTime_0) {
						if ((DateTime.Now - Class5.list_3[i].dateTime_0).TotalSeconds >= 60.0) {
							var value3 = Class5.list_3[i];
							value3.dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds).AddDays(1.0);
							Class5.list_3[i] = value3;
						}
						else {
							Class12.class31_0.method_3(Class5.list_3[i].string_1);
							var value4 = Class5.list_3[i];
							value4.dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds).AddDays(1.0);
							Class5.list_3[i] = value4;
						}
					}
				}
				else {
					if (Class5.list_3[i].byte_1 != 2) {
						continue;
					}
					if (Class5.list_3[i].dateTime_0 == DateTime.MinValue) {
						string[] array = Class5.list_3[i].string_0.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
						var list = new List<TimeSpan>();
						for (int j = 0; j < array.Length; j++) {
							var timeSpan2 = TimeSpan.Parse(array[j]);
							if (DateTime.Now.TimeOfDay < timeSpan2) {
								list.Add(timeSpan2);
							}
						}
						var timeSpan3 = ((list.Count != 0) ? list[Class2.random_0.Next(0, list.Count - 1)] : TimeSpan.Parse(array[Class2.random_0.Next(0, array.Length - 1)]));
						var value5 = Class5.list_3[i];
						if (list.Count == 0) {
							value5.dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, timeSpan3.Hours, timeSpan3.Minutes, timeSpan3.Seconds).AddDays(1.0);
						}
						else {
							value5.dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, timeSpan3.Hours, timeSpan3.Minutes, timeSpan3.Seconds);
						}
						Class5.list_3[i] = value5;
					}
					else if (DateTime.Now >= Class5.list_3[i].dateTime_0) {
						if ((DateTime.Now - Class5.list_3[i].dateTime_0).TotalSeconds >= 60.0) {
							string[] array2 = Class5.list_3[i].string_0.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
							var timeSpan4 = TimeSpan.Parse(array2[Class2.random_0.Next(0, array2.Length - 1)]);
							var value6 = Class5.list_3[i];
							value6.dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, timeSpan4.Hours, timeSpan4.Minutes, timeSpan4.Seconds).AddDays(1.0);
							Class5.list_3[i] = value6;
						}
						else {
							Class12.class31_0.method_3(Class5.list_3[i].string_1);
							string[] array3 = Class5.list_3[i].string_0.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
							var timeSpan5 = TimeSpan.Parse(array3[Class2.random_0.Next(0, array3.Length - 1)]);
							var value7 = Class5.list_3[i];
							value7.dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, timeSpan5.Hours, timeSpan5.Minutes, timeSpan5.Seconds).AddDays(1.0);
							Class5.list_3[i] = value7;
						}
					}
				}
			}
		}
		catch {
		}
	}

	private void button50_Click(object sender, EventArgs e) {
		new AedSpawnGameMonsterForm().ShowDialog();
		method_18();
	}

	private void button51_Click(object sender, EventArgs e) {
		if (listView9.SelectedItems.Count > 0) {
			new AedSpawnGameMonsterForm(byte.Parse(listView9.SelectedItems[0].SubItems[0].Text), int.Parse(listView9.SelectedItems[0].SubItems[1].Text), byte.Parse(listView9.SelectedItems[0].SubItems[2].Text), listView9.SelectedItems[0].SubItems[3].Text, listView9.SelectedItems[0].SubItems[5].Text).ShowDialog();
			method_18();
		}
		else {
			MessageBox.Show("请选择一个怪物信息!");
		}
	}

	private void button52_Click(object sender, EventArgs e) {
		if (listView9.SelectedItems.Count > 0) {
			if (Class5.smethod_83(int.Parse(listView9.SelectedItems[0].SubItems[1].Text)) != 1) {
				MessageBox.Show("删除失败！");
			}
			else {
				method_18();
			}
		}
		else {
			MessageBox.Show("请选择一个怪物信息!");
		}
	}

	private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
		if (tabControl1.SelectedIndex == 3) {
			method_18(bool_2: false);
		}
	}

	protected override void Dispose(bool disposing) {
		if (disposing && icontainer_0 != null) {
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CenterManagerServerForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.labelGatewayCenter = new System.Windows.Forms.Label();
            this.labelDownloadCenter = new System.Windows.Forms.Label();
            this.labelAgentCenter = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.labelDownloadWaitSend = new System.Windows.Forms.Label();
            this.labelDownloadWaitRecv = new System.Windows.Forms.Label();
            this.labelDownloadRecv = new System.Windows.Forms.Label();
            this.labelDownloadSend = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAgentWaitSend = new System.Windows.Forms.Label();
            this.labelAgentWaitRecv = new System.Windows.Forms.Label();
            this.labelAgentSend = new System.Windows.Forms.Label();
            this.labelAgentRecv = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelGatewayWaitSend = new System.Windows.Forms.Label();
            this.labelGatewayWaitRecv = new System.Windows.Forms.Label();
            this.labelGatewayRecv = new System.Windows.Forms.Label();
            this.labelGatewaySend = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button31 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button17 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.button52 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.listView9 = new System.Windows.Forms.ListView();
            this.columnHeader_49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_51 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader_10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button29 = new System.Windows.Forms.Button();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.button21 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button20 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader_14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader_19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.listView7 = new System.Windows.Forms.ListView();
            this.columnHeader_29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.listView6 = new System.Windows.Forms.ListView();
            this.columnHeader_25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button38 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.button47 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.listView8 = new System.Windows.Forms.ListView();
            this.columnHeader_39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox40 = new System.Windows.Forms.CheckBox();
            this.checkBox39 = new System.Windows.Forms.CheckBox();
            this.checkBox38 = new System.Windows.Forms.CheckBox();
            this.checkBox37 = new System.Windows.Forms.CheckBox();
            this.checkBox35 = new System.Windows.Forms.CheckBox();
            this.button30 = new System.Windows.Forms.Button();
            this.checkBox34 = new System.Windows.Forms.CheckBox();
            this.checkBox33 = new System.Windows.Forms.CheckBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBoxATTState = new System.Windows.Forms.CheckBox();
            this.checkBoxTradeDelay = new System.Windows.Forms.CheckBox();
            this.checkBoxLoginReward = new System.Windows.Forms.CheckBox();
            this.checkBoxNotAlchemy = new System.Windows.Forms.CheckBox();
            this.checkBoxMonsterKill = new System.Windows.Forms.CheckBox();
            this.checkBox_0 = new System.Windows.Forms.CheckBox();
            this.checkBoxAlchemy = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.button32 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button35 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button22 = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.timer_2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip_0 = new System.Windows.Forms.ToolTip(this.components);
            this.timer_3 = new System.Windows.Forms.Timer(this.components);
            this.timer_4 = new System.Windows.Forms.Timer(this.components);
            this.timer_5 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox16.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage17);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage12);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 554);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox16);
            this.tabPage1.Controls.Add(this.groupBox13);
            this.tabPage1.Controls.Add(this.groupBox12);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主界面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(738, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.toolTip_0.SetToolTip(this.pictureBox1, "您只需要将鼠标移动到选项上，即可看到帮助信息");
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.listBox1);
            this.groupBox16.Location = new System.Drawing.Point(289, 110);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(473, 397);
            this.groupBox16.TabIndex = 34;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "日志";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(5, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(462, 376);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.labelGatewayCenter);
            this.groupBox13.Controls.Add(this.labelDownloadCenter);
            this.groupBox13.Controls.Add(this.labelAgentCenter);
            this.groupBox13.Location = new System.Drawing.Point(4, 443);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(276, 79);
            this.groupBox13.TabIndex = 17;
            this.groupBox13.TabStop = false;
            // 
            // labelGatewayCenter
            // 
            this.labelGatewayCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGatewayCenter.AutoSize = true;
            this.labelGatewayCenter.Location = new System.Drawing.Point(6, 36);
            this.labelGatewayCenter.Name = "labelGatewayCenter";
            this.labelGatewayCenter.Size = new System.Drawing.Size(113, 12);
            this.labelGatewayCenter.TabIndex = 6;
            this.labelGatewayCenter.Text = "网关服务器连接数:0";
            // 
            // labelDownloadCenter
            // 
            this.labelDownloadCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDownloadCenter.AutoSize = true;
            this.labelDownloadCenter.Location = new System.Drawing.Point(7, 55);
            this.labelDownloadCenter.Name = "labelDownloadCenter";
            this.labelDownloadCenter.Size = new System.Drawing.Size(113, 12);
            this.labelDownloadCenter.TabIndex = 16;
            this.labelDownloadCenter.Text = "下载服务器连接数:0";
            // 
            // labelAgentCenter
            // 
            this.labelAgentCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAgentCenter.AutoSize = true;
            this.labelAgentCenter.Location = new System.Drawing.Point(7, 17);
            this.labelAgentCenter.Name = "labelAgentCenter";
            this.labelAgentCenter.Size = new System.Drawing.Size(113, 12);
            this.labelAgentCenter.TabIndex = 7;
            this.labelAgentCenter.Text = "代理服务器连接数:0";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.labelDownloadWaitSend);
            this.groupBox12.Controls.Add(this.labelDownloadWaitRecv);
            this.groupBox12.Controls.Add(this.labelDownloadRecv);
            this.groupBox12.Controls.Add(this.labelDownloadSend);
            this.groupBox12.Location = new System.Drawing.Point(6, 112);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(276, 98);
            this.groupBox12.TabIndex = 15;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "下载服务器";
            // 
            // labelDownloadWaitSend
            // 
            this.labelDownloadWaitSend.AutoSize = true;
            this.labelDownloadWaitSend.Location = new System.Drawing.Point(6, 74);
            this.labelDownloadWaitSend.Name = "labelDownloadWaitSend";
            this.labelDownloadWaitSend.Size = new System.Drawing.Size(155, 12);
            this.labelDownloadWaitSend.TabIndex = 7;
            this.labelDownloadWaitSend.Text = "下载服务器等待发送:0 字节";
            // 
            // labelDownloadWaitRecv
            // 
            this.labelDownloadWaitRecv.AutoSize = true;
            this.labelDownloadWaitRecv.Location = new System.Drawing.Point(6, 56);
            this.labelDownloadWaitRecv.Name = "labelDownloadWaitRecv";
            this.labelDownloadWaitRecv.Size = new System.Drawing.Size(155, 12);
            this.labelDownloadWaitRecv.TabIndex = 6;
            this.labelDownloadWaitRecv.Text = "下载服务器等待接收:0 字节";
            // 
            // labelDownloadRecv
            // 
            this.labelDownloadRecv.AutoSize = true;
            this.labelDownloadRecv.Location = new System.Drawing.Point(6, 38);
            this.labelDownloadRecv.Name = "labelDownloadRecv";
            this.labelDownloadRecv.Size = new System.Drawing.Size(131, 12);
            this.labelDownloadRecv.TabIndex = 1;
            this.labelDownloadRecv.Text = "下载服务器接收:0 字节";
            // 
            // labelDownloadSend
            // 
            this.labelDownloadSend.AutoSize = true;
            this.labelDownloadSend.Location = new System.Drawing.Point(6, 21);
            this.labelDownloadSend.Name = "labelDownloadSend";
            this.labelDownloadSend.Size = new System.Drawing.Size(131, 12);
            this.labelDownloadSend.TabIndex = 0;
            this.labelDownloadSend.Text = "下载服务器发送:0 字节";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(4, 389);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(276, 48);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "注册服务器";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "注册服务器数量总数:0";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(289, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 98);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 48;
            this.label4.Text = "活动金珠数量:0";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(119, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 39);
            this.label18.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "活动角色名:Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "活动超时:0/0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "禁止IP数量:0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelAgentWaitSend);
            this.groupBox2.Controls.Add(this.labelAgentWaitRecv);
            this.groupBox2.Controls.Add(this.labelAgentSend);
            this.groupBox2.Controls.Add(this.labelAgentRecv);
            this.groupBox2.Location = new System.Drawing.Point(4, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 167);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "代理服务器";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "代理服务器尝试连接总数:0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "代理服务器连接总数:0";
            // 
            // labelAgentWaitSend
            // 
            this.labelAgentWaitSend.AutoSize = true;
            this.labelAgentWaitSend.Location = new System.Drawing.Point(6, 74);
            this.labelAgentWaitSend.Name = "labelAgentWaitSend";
            this.labelAgentWaitSend.Size = new System.Drawing.Size(155, 12);
            this.labelAgentWaitSend.TabIndex = 5;
            this.labelAgentWaitSend.Text = "代理服务器等待发送:0 字节";
            // 
            // labelAgentWaitRecv
            // 
            this.labelAgentWaitRecv.AutoSize = true;
            this.labelAgentWaitRecv.Location = new System.Drawing.Point(6, 56);
            this.labelAgentWaitRecv.Name = "labelAgentWaitRecv";
            this.labelAgentWaitRecv.Size = new System.Drawing.Size(155, 12);
            this.labelAgentWaitRecv.TabIndex = 4;
            this.labelAgentWaitRecv.Text = "代理服务器等待接收:0 字节";
            // 
            // labelAgentSend
            // 
            this.labelAgentSend.AutoSize = true;
            this.labelAgentSend.Location = new System.Drawing.Point(6, 21);
            this.labelAgentSend.Name = "labelAgentSend";
            this.labelAgentSend.Size = new System.Drawing.Size(131, 12);
            this.labelAgentSend.TabIndex = 3;
            this.labelAgentSend.Text = "代理服务器发送:0 字节";
            // 
            // labelAgentRecv
            // 
            this.labelAgentRecv.AutoSize = true;
            this.labelAgentRecv.Location = new System.Drawing.Point(6, 38);
            this.labelAgentRecv.Name = "labelAgentRecv";
            this.labelAgentRecv.Size = new System.Drawing.Size(131, 12);
            this.labelAgentRecv.TabIndex = 2;
            this.labelAgentRecv.Text = "代理服务器接收:0 字节";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelGatewayWaitSend);
            this.groupBox1.Controls.Add(this.labelGatewayWaitRecv);
            this.groupBox1.Controls.Add(this.labelGatewayRecv);
            this.groupBox1.Controls.Add(this.labelGatewaySend);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网关服务器";
            // 
            // labelGatewayWaitSend
            // 
            this.labelGatewayWaitSend.AutoSize = true;
            this.labelGatewayWaitSend.Location = new System.Drawing.Point(6, 74);
            this.labelGatewayWaitSend.Name = "labelGatewayWaitSend";
            this.labelGatewayWaitSend.Size = new System.Drawing.Size(155, 12);
            this.labelGatewayWaitSend.TabIndex = 7;
            this.labelGatewayWaitSend.Text = "网关服务器等待发送:0 字节";
            // 
            // labelGatewayWaitRecv
            // 
            this.labelGatewayWaitRecv.AutoSize = true;
            this.labelGatewayWaitRecv.Location = new System.Drawing.Point(6, 56);
            this.labelGatewayWaitRecv.Name = "labelGatewayWaitRecv";
            this.labelGatewayWaitRecv.Size = new System.Drawing.Size(155, 12);
            this.labelGatewayWaitRecv.TabIndex = 6;
            this.labelGatewayWaitRecv.Text = "网关服务器等待接收:0 字节";
            // 
            // labelGatewayRecv
            // 
            this.labelGatewayRecv.AutoSize = true;
            this.labelGatewayRecv.Location = new System.Drawing.Point(6, 38);
            this.labelGatewayRecv.Name = "labelGatewayRecv";
            this.labelGatewayRecv.Size = new System.Drawing.Size(131, 12);
            this.labelGatewayRecv.TabIndex = 1;
            this.labelGatewayRecv.Text = "网关服务器接收:0 字节";
            // 
            // labelGatewaySend
            // 
            this.labelGatewaySend.AutoSize = true;
            this.labelGatewaySend.Location = new System.Drawing.Point(6, 21);
            this.labelGatewaySend.Name = "labelGatewaySend";
            this.labelGatewaySend.Size = new System.Drawing.Size(131, 12);
            this.labelGatewaySend.TabIndex = 0;
            this.labelGatewaySend.Text = "网关服务器发送:0 字节";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button31);
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button31.Location = new System.Drawing.Point(80, 5);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(68, 23);
            this.button31.TabIndex = 6;
            this.button31.Text = "发放物品";
            this.toolTip_0.SetToolTip(this.button31, "点我可以给玩家发放物品");
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Location = new System.Drawing.Point(698, 5);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(63, 23);
            this.button16.TabIndex = 5;
            this.button16.Text = "搜索";
            this.toolTip_0.SetToolTip(this.button16, "点我可以搜索玩家");
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(154, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(538, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.WordWrap = false;
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Location = new System.Drawing.Point(6, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 23);
            this.button14.TabIndex = 3;
            this.button14.Text = "发放金珠";
            this.toolTip_0.SetToolTip(this.button14, "点我可以给玩家发放金珠");
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(698, 499);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "踢出";
            this.toolTip_0.SetToolTip(this.button9, "可以将玩家踢出游戏");
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(6, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "刷新";
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
            this.columnHeader_1,
            this.columnHeader_2,
            this.columnHeader_3,
            this.columnHeader_9,
            this.columnHeader_13,
            this.columnHeader_38,
            this.columnHeader_48});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(755, 461);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader_0
            // 
            this.columnHeader_0.Text = "账户";
            this.columnHeader_0.Width = 100;
            // 
            // columnHeader_1
            // 
            this.columnHeader_1.Text = "角色名";
            this.columnHeader_1.Width = 100;
            // 
            // columnHeader_2
            // 
            this.columnHeader_2.Text = "IP";
            this.columnHeader_2.Width = 120;
            // 
            // columnHeader_3
            // 
            this.columnHeader_3.Text = "状态";
            this.columnHeader_3.Width = 80;
            // 
            // columnHeader_9
            // 
            this.columnHeader_9.Text = "延迟";
            // 
            // columnHeader_13
            // 
            this.columnHeader_13.Text = "时间";
            // 
            // columnHeader_38
            // 
            this.columnHeader_38.Text = "机器码";
            this.columnHeader_38.Width = 130;
            // 
            // columnHeader_48
            // 
            this.columnHeader_48.Text = "连接ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 126);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.method_32);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "踢出";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem2.Text = "封禁IP";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem3.Text = "封禁机器码";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem4.Text = "信任此IP";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem5.Text = "信任此机器码";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.button18);
            this.tabPage3.Controls.Add(this.listView2);
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "公告";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(692, 496);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 25);
            this.button8.TabIndex = 22;
            this.button8.Text = "发送通知";
            this.toolTip_0.SetToolTip(this.button8, "给玩家发送公告");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 348);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(755, 142);
            this.textBox1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "延迟时间（分钟）：0";
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.Location = new System.Drawing.Point(707, 313);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(54, 28);
            this.button18.TabIndex = 19;
            this.button18.Text = "停止";
            this.toolTip_0.SetToolTip(this.button18, "停止自动公告");
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_4,
            this.columnHeader_5,
            this.columnHeader_6,
            this.columnHeader_7,
            this.columnHeader_8});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(755, 300);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_4
            // 
            this.columnHeader_4.Text = "服务";
            // 
            // columnHeader_5
            // 
            this.columnHeader_5.Text = "ID";
            this.columnHeader_5.Width = 50;
            // 
            // columnHeader_6
            // 
            this.columnHeader_6.Text = "开始时间";
            this.columnHeader_6.Width = 120;
            // 
            // columnHeader_7
            // 
            this.columnHeader_7.Text = "结束时间";
            this.columnHeader_7.Width = 120;
            // 
            // columnHeader_8
            // 
            this.columnHeader_8.Text = "公告文字";
            this.columnHeader_8.Width = 220;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.Location = new System.Drawing.Point(647, 313);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(54, 29);
            this.button17.TabIndex = 18;
            this.button17.Text = "开始";
            this.toolTip_0.SetToolTip(this.button17, "开始自动公告");
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(135, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 29);
            this.button4.TabIndex = 17;
            this.button4.Text = "删除";
            this.toolTip_0.SetToolTip(this.button4, "删除自动公告");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(565, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(6, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "添加";
            this.toolTip_0.SetToolTip(this.button3, "添加自动公告");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(75, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 29);
            this.button5.TabIndex = 16;
            this.button5.Text = "编辑";
            this.toolTip_0.SetToolTip(this.button5, "编辑自动公告");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.button52);
            this.tabPage17.Controls.Add(this.button51);
            this.tabPage17.Controls.Add(this.listView9);
            this.tabPage17.Controls.Add(this.button49);
            this.tabPage17.Controls.Add(this.button50);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(768, 528);
            this.tabPage17.TabIndex = 9;
            this.tabPage17.Text = "怪物";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // button52
            // 
            this.button52.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button52.Location = new System.Drawing.Point(688, 499);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(75, 23);
            this.button52.TabIndex = 5;
            this.button52.Text = "删除";
            this.button52.UseVisualStyleBackColor = true;
            this.button52.Click += new System.EventHandler(this.button52_Click);
            // 
            // button51
            // 
            this.button51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button51.Location = new System.Drawing.Point(607, 499);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(75, 23);
            this.button51.TabIndex = 4;
            this.button51.Text = "编辑";
            this.button51.UseVisualStyleBackColor = true;
            this.button51.Click += new System.EventHandler(this.button51_Click);
            // 
            // listView9
            // 
            this.listView9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView9.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_49,
            this.columnHeader_50,
            this.columnHeader_51,
            this.columnHeader_52,
            this.columnHeader_53,
            this.columnHeader_54});
            this.listView9.FullRowSelect = true;
            this.listView9.HideSelection = false;
            this.listView9.Location = new System.Drawing.Point(5, 6);
            this.listView9.Name = "listView9";
            this.listView9.Size = new System.Drawing.Size(759, 489);
            this.listView9.TabIndex = 0;
            this.listView9.UseCompatibleStateImageBehavior = false;
            this.listView9.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_49
            // 
            this.columnHeader_49.Text = "状态";
            this.columnHeader_49.Width = 50;
            // 
            // columnHeader_50
            // 
            this.columnHeader_50.Text = "编号";
            this.columnHeader_50.Width = 50;
            // 
            // columnHeader_51
            // 
            this.columnHeader_51.Text = "类型";
            this.columnHeader_51.Width = 50;
            // 
            // columnHeader_52
            // 
            this.columnHeader_52.Text = "刷出时间";
            this.columnHeader_52.Width = 120;
            // 
            // columnHeader_53
            // 
            this.columnHeader_53.Text = "执行时间";
            this.columnHeader_53.Width = 120;
            // 
            // columnHeader_54
            // 
            this.columnHeader_54.Text = "参数信息";
            this.columnHeader_54.Width = 300;
            // 
            // button49
            // 
            this.button49.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button49.Location = new System.Drawing.Point(5, 501);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(75, 23);
            this.button49.TabIndex = 2;
            this.button49.Text = "刷新";
            this.button49.UseVisualStyleBackColor = true;
            this.button49.Click += new System.EventHandler(this.button49_Click);
            // 
            // button50
            // 
            this.button50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button50.Location = new System.Drawing.Point(526, 499);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(75, 23);
            this.button50.TabIndex = 3;
            this.button50.Text = "添加";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBox6);
            this.tabPage4.Controls.Add(this.checkBox5);
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.listView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 528);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "限制";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(252, 503);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(84, 16);
            this.checkBox6.TabIndex = 13;
            this.checkBox6.Text = "自动禁止IP";
            this.toolTip_0.SetToolTip(this.checkBox6, "当出现攻击等异常现象将自动封禁IP");
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(96, 503);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(150, 16);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "自动解除禁止IP(2分钟)";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Location = new System.Drawing.Point(596, 499);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 11;
            this.button13.Text = "编辑";
            this.toolTip_0.SetToolTip(this.button13, "编辑需要封禁的IP");
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Location = new System.Drawing.Point(515, 499);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 10;
            this.button12.Text = "添加";
            this.toolTip_0.SetToolTip(this.button12, "添加需要封禁的IP");
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button11.Location = new System.Drawing.Point(6, 499);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 9;
            this.button11.Text = "刷新";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Location = new System.Drawing.Point(686, 499);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 8;
            this.button10.Text = "删除";
            this.toolTip_0.SetToolTip(this.button10, "删除需要封禁的IP");
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_10,
            this.columnHeader_11,
            this.columnHeader_12,
            this.columnHeader_47});
            this.listView3.FullRowSelect = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(6, 4);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(755, 489);
            this.listView3.TabIndex = 7;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_10
            // 
            this.columnHeader_10.Text = "服务";
            // 
            // columnHeader_11
            // 
            this.columnHeader_11.Text = "时间";
            this.columnHeader_11.Width = 160;
            // 
            // columnHeader_12
            // 
            this.columnHeader_12.Text = "类型";
            // 
            // columnHeader_47
            // 
            this.columnHeader_47.Text = "方式";
            this.columnHeader_47.Width = 160;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tabControl2);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(768, 528);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "活动";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Controls.Add(this.tabPage11);
            this.tabControl2.Controls.Add(this.tabPage13);
            this.tabControl2.Location = new System.Drawing.Point(0, 1);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(761, 528);
            this.tabControl2.TabIndex = 46;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBox10);
            this.tabPage9.Controls.Add(this.groupBox8);
            this.tabPage9.Controls.Add(this.groupBox7);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(753, 502);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "礼物";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.button29);
            this.groupBox10.Controls.Add(this.checkBox31);
            this.groupBox10.Controls.Add(this.textBox13);
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.Controls.Add(this.textBox12);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.textBox11);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.checkBox27);
            this.groupBox10.Controls.Add(this.textBox10);
            this.groupBox10.Controls.Add(this.button15);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.textBox9);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Location = new System.Drawing.Point(6, 347);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(741, 149);
            this.groupBox10.TabIndex = 63;
            this.groupBox10.TabStop = false;
            // 
            // button29
            // 
            this.button29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button29.BackgroundImage")));
            this.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button29.FlatAppearance.BorderSize = 0;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Location = new System.Drawing.Point(157, 20);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(16, 16);
            this.button29.TabIndex = 71;
            this.toolTip_0.SetToolTip(this.button29, "详细奖励设置");
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Location = new System.Drawing.Point(470, 76);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(48, 16);
            this.checkBox31.TabIndex = 70;
            this.checkBox31.Text = "随机";
            this.checkBox31.UseVisualStyleBackColor = true;
            this.checkBox31.CheckedChanged += new System.EventHandler(this.checkBox31_CheckedChanged);
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(653, 74);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(57, 21);
            this.textBox13.TabIndex = 69;
            this.textBox13.Text = "300";
            this.textBox13.Leave += new System.EventHandler(this.textBox13_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(620, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 68;
            this.label20.Text = "最大：";
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(559, 74);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(57, 21);
            this.textBox12.TabIndex = 67;
            this.textBox12.Text = "10";
            this.textBox12.Leave += new System.EventHandler(this.textBox12_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(524, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 66;
            this.label19.Text = "最小：";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(386, 23);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(324, 21);
            this.textBox11.TabIndex = 65;
            this.textBox11.Text = "10800";
            this.textBox11.Leave += new System.EventHandler(this.textBox11_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(295, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 12);
            this.label17.TabIndex = 64;
            this.label17.Text = "间隔时间(秒)：";
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(17, 20);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(144, 16);
            this.checkBox27.TabIndex = 63;
            this.checkBox27.Text = "启用间隔发放幸运红包";
            this.toolTip_0.SetToolTip(this.checkBox27, "启用后服务器将自动按照间隔时间发放幸运红包");
            this.checkBox27.UseVisualStyleBackColor = true;
            this.checkBox27.CheckedChanged += new System.EventHandler(this.checkBox27_CheckedChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(386, 101);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(324, 21);
            this.textBox10.TabIndex = 61;
            this.textBox10.Text = "5";
            this.textBox10.Leave += new System.EventHandler(this.textBox10_Leave);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(17, 74);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(140, 45);
            this.button15.TabIndex = 62;
            this.button15.Text = "立即发放";
            this.toolTip_0.SetToolTip(this.button15, "立即发放一个幸运红包");
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(295, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 58;
            this.label15.Text = "幸运金珠数量：";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(386, 74);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(76, 21);
            this.textBox9.TabIndex = 59;
            this.textBox9.Text = "200";
            this.textBox9.Leave += new System.EventHandler(this.textBox9_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(295, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 12);
            this.label16.TabIndex = 60;
            this.label16.Text = "幸运玩家数量：";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.textBox8);
            this.groupBox8.Controls.Add(this.checkBox25);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Location = new System.Drawing.Point(6, 290);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(741, 94);
            this.groupBox8.TabIndex = 57;
            this.groupBox8.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(386, 18);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(324, 21);
            this.textBox8.TabIndex = 2;
            this.textBox8.Text = "中秋快乐";
            this.textBox8.Leave += new System.EventHandler(this.textBox8_Leave);
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Location = new System.Drawing.Point(17, 20);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(144, 16);
            this.checkBox25.TabIndex = 0;
            this.checkBox25.Text = "启用自定义抢红包口令";
            this.toolTip_0.SetToolTip(this.checkBox25, "启用该功能后您可以自己修改抢红包指令");
            this.checkBox25.UseVisualStyleBackColor = true;
            this.checkBox25.CheckedChanged += new System.EventHandler(this.checkBox25_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(307, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "抢红包口令：";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.checkBox8);
            this.groupBox7.Controls.Add(this.checkBox19);
            this.groupBox7.Controls.Add(this.button21);
            this.groupBox7.Controls.Add(this.textBox5);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.checkedListBox1);
            this.groupBox7.Controls.Add(this.button20);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.checkBox18);
            this.groupBox7.Controls.Add(this.textBox7);
            this.groupBox7.Location = new System.Drawing.Point(6, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(741, 284);
            this.groupBox7.TabIndex = 56;
            this.groupBox7.TabStop = false;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(17, 23);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(120, 16);
            this.checkBox8.TabIndex = 49;
            this.checkBox8.Text = "启用玩家互发红包";
            this.toolTip_0.SetToolTip(this.checkBox8, "启用该功能后玩家就可以自己发红包了");
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(17, 77);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(156, 16);
            this.checkBox19.TabIndex = 54;
            this.checkBox19.Text = "启用按时发放服务器红包";
            this.toolTip_0.SetToolTip(this.checkBox19, "启用该功能后服务器将按照您选择的时间自动开启红包活动");
            this.checkBox19.UseVisualStyleBackColor = true;
            this.checkBox19.CheckedChanged += new System.EventHandler(this.checkBox19_CheckedChanged);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(609, 21);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(101, 50);
            this.button21.TabIndex = 48;
            this.button21.Text = "关闭红包活动";
            this.toolTip_0.SetToolTip(this.button21, "点击后关闭当前的红包活动");
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(386, 21);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 46;
            this.textBox5.Text = "100000";
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 55;
            this.label12.Text = "指定时间(时)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 45;
            this.label3.Text = "服务器金珠红包总额：";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "00:00:00",
            "01:00:00",
            "02:00:00",
            "03:00:00",
            "04:00:00",
            "05:00:00",
            "06:00:00",
            "07:00:00",
            "08:00:00",
            "09:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "13:00:00",
            "14:00:00",
            "15:00:00",
            "16:00:00",
            "17:00:00",
            "18:00:00",
            "19:00:00",
            "20:00:00",
            "21:00:00",
            "22:00:00",
            "23:00:00"});
            this.checkedListBox1.Location = new System.Drawing.Point(386, 77);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(324, 196);
            this.checkedListBox1.TabIndex = 51;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(492, 21);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(111, 50);
            this.button20.TabIndex = 40;
            this.button20.Text = "发放服务器红包";
            this.toolTip_0.SetToolTip(this.button20, "点击后将立即开启一个红包活动");
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 52;
            this.label11.Text = "间隔时间(秒)：";
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(17, 52);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(156, 16);
            this.checkBox18.TabIndex = 50;
            this.checkBox18.Text = "启用间隔发放服务器红包";
            this.toolTip_0.SetToolTip(this.checkBox18, "启用该功能后服务器将每隔一段时间自动开启一次红包活动");
            this.checkBox18.UseVisualStyleBackColor = true;
            this.checkBox18.CheckedChanged += new System.EventHandler(this.checkBox18_CheckedChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(386, 50);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 53;
            this.textBox7.Text = "10800";
            this.textBox7.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.checkBox17);
            this.tabPage10.Controls.Add(this.button25);
            this.tabPage10.Controls.Add(this.button24);
            this.tabPage10.Controls.Add(this.button23);
            this.tabPage10.Controls.Add(this.listView4);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(753, 502);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "消费排名";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(3, 477);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(120, 16);
            this.checkBox17.TabIndex = 55;
            this.checkBox17.Text = "启用累计消费奖励";
            this.toolTip_0.SetToolTip(this.checkBox17, "启用该功能后玩家消费金珠累计到指定金额将自动获得奖励");
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.checkBox17_CheckedChanged);
            // 
            // button25
            // 
            this.button25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button25.Location = new System.Drawing.Point(517, 469);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(126, 29);
            this.button25.TabIndex = 54;
            this.button25.Text = "手动发放排行榜奖励";
            this.toolTip_0.SetToolTip(this.button25, "点击后立即发放排行榜奖励");
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button24.Location = new System.Drawing.Point(396, 469);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(115, 29);
            this.button24.TabIndex = 53;
            this.button24.Text = "重置消费排行榜";
            this.toolTip_0.SetToolTip(this.button24, "点击后重置消费金珠活动数据");
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button23
            // 
            this.button23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button23.Location = new System.Drawing.Point(649, 469);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(101, 29);
            this.button23.TabIndex = 52;
            this.button23.Text = "刷新消费排行榜";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // listView4
            // 
            this.listView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_14,
            this.columnHeader_15,
            this.columnHeader_16,
            this.columnHeader_17,
            this.columnHeader_18});
            this.listView4.FullRowSelect = true;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(3, 3);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(747, 461);
            this.listView4.TabIndex = 51;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_14
            // 
            this.columnHeader_14.Text = "排名";
            this.columnHeader_14.Width = 50;
            // 
            // columnHeader_15
            // 
            this.columnHeader_15.Text = "角色名";
            this.columnHeader_15.Width = 160;
            // 
            // columnHeader_16
            // 
            this.columnHeader_16.Text = "消费金珠";
            // 
            // columnHeader_17
            // 
            this.columnHeader_17.Text = "奖励金珠";
            this.columnHeader_17.Width = 100;
            // 
            // columnHeader_18
            // 
            this.columnHeader_18.Text = "状态";
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.checkBox16);
            this.tabPage11.Controls.Add(this.checkBox15);
            this.tabPage11.Controls.Add(this.button28);
            this.tabPage11.Controls.Add(this.button27);
            this.tabPage11.Controls.Add(this.listView5);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(753, 502);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "角色排名";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(129, 477);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(120, 16);
            this.checkBox16.TabIndex = 4;
            this.checkBox16.Text = "启用满级竞速提示";
            this.toolTip_0.SetToolTip(this.checkBox16, "启用该功能每当有玩家满级时，将显示该玩家领先信息");
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
            // 
            // checkBox15
            // 
            this.checkBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(3, 477);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(120, 16);
            this.checkBox15.TabIndex = 3;
            this.checkBox15.Text = "启用满级自动奖励";
            this.toolTip_0.SetToolTip(this.checkBox15, "启用该功能后玩家升级到满级后将自动获得奖励");
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // button28
            // 
            this.button28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button28.Location = new System.Drawing.Point(517, 469);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(126, 29);
            this.button28.TabIndex = 2;
            this.button28.Text = "手动发放排行榜奖励";
            this.toolTip_0.SetToolTip(this.button28, "点击后立即发放排行榜奖励");
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button27
            // 
            this.button27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button27.Location = new System.Drawing.Point(649, 469);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(101, 29);
            this.button27.TabIndex = 1;
            this.button27.Text = "刷新满级排行榜";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // listView5
            // 
            this.listView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_19,
            this.columnHeader_20,
            this.columnHeader_21,
            this.columnHeader_22,
            this.columnHeader_23,
            this.columnHeader_24});
            this.listView5.FullRowSelect = true;
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(3, 3);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(747, 461);
            this.listView5.TabIndex = 0;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_19
            // 
            this.columnHeader_19.Text = "时间";
            this.columnHeader_19.Width = 150;
            // 
            // columnHeader_20
            // 
            this.columnHeader_20.Text = "排名";
            this.columnHeader_20.Width = 37;
            // 
            // columnHeader_21
            // 
            this.columnHeader_21.Text = "角色名";
            this.columnHeader_21.Width = 99;
            // 
            // columnHeader_22
            // 
            this.columnHeader_22.Text = "等级";
            this.columnHeader_22.Width = 44;
            // 
            // columnHeader_23
            // 
            this.columnHeader_23.Text = "奖励金珠";
            this.columnHeader_23.Width = 80;
            // 
            // columnHeader_24
            // 
            this.columnHeader_24.Text = "状态";
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.button40);
            this.tabPage13.Controls.Add(this.button41);
            this.tabPage13.Controls.Add(this.button42);
            this.tabPage13.Controls.Add(this.button39);
            this.tabPage13.Controls.Add(this.listView7);
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(753, 502);
            this.tabPage13.TabIndex = 3;
            this.tabPage13.Text = "全体聊天功能";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button40.Location = new System.Drawing.Point(675, 473);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(75, 23);
            this.button40.TabIndex = 7;
            this.button40.Text = "详细信息";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button41
            // 
            this.button41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button41.Location = new System.Drawing.Point(594, 473);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(75, 23);
            this.button41.TabIndex = 6;
            this.button41.Text = "关闭";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button42
            // 
            this.button42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button42.Location = new System.Drawing.Point(513, 473);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(75, 23);
            this.button42.TabIndex = 5;
            this.button42.Text = "开放";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button39
            // 
            this.button39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button39.Location = new System.Drawing.Point(3, 473);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(75, 23);
            this.button39.TabIndex = 1;
            this.button39.Text = "刷新";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // listView7
            // 
            this.listView7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView7.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_29,
            this.columnHeader_30,
            this.columnHeader_31,
            this.columnHeader_32,
            this.columnHeader_33,
            this.columnHeader_34,
            this.columnHeader_35,
            this.columnHeader_36});
            this.listView7.FullRowSelect = true;
            this.listView7.HideSelection = false;
            this.listView7.Location = new System.Drawing.Point(3, 3);
            this.listView7.Name = "listView7";
            this.listView7.Size = new System.Drawing.Size(748, 466);
            this.listView7.TabIndex = 0;
            this.listView7.UseCompatibleStateImageBehavior = false;
            this.listView7.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_29
            // 
            this.columnHeader_29.Text = "状态";
            this.columnHeader_29.Width = 50;
            // 
            // columnHeader_30
            // 
            this.columnHeader_30.Text = "活动名称";
            this.columnHeader_30.Width = 110;
            // 
            // columnHeader_31
            // 
            this.columnHeader_31.Text = "开始时间";
            this.columnHeader_31.Width = 120;
            // 
            // columnHeader_32
            // 
            this.columnHeader_32.Text = "活动类型";
            this.columnHeader_32.Width = 70;
            // 
            // columnHeader_33
            // 
            this.columnHeader_33.Text = "活动状态";
            this.columnHeader_33.Width = 70;
            // 
            // columnHeader_34
            // 
            this.columnHeader_34.Text = "奖励状态";
            this.columnHeader_34.Width = 70;
            // 
            // columnHeader_35
            // 
            this.columnHeader_35.Text = "作者信息";
            this.columnHeader_35.Width = 85;
            // 
            // columnHeader_36
            // 
            this.columnHeader_36.Text = "Slot";
            this.columnHeader_36.Width = 0;
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.tabControl3);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(768, 528);
            this.tabPage12.TabIndex = 8;
            this.tabPage12.Text = "插件";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage14);
            this.tabControl3.Controls.Add(this.tabPage15);
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(758, 522);
            this.tabControl3.TabIndex = 5;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.listView6);
            this.tabPage14.Controls.Add(this.button38);
            this.tabPage14.Controls.Add(this.button37);
            this.tabPage14.Controls.Add(this.button34);
            this.tabPage14.Controls.Add(this.button36);
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(750, 496);
            this.tabPage14.TabIndex = 0;
            this.tabPage14.Text = "插件控制";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // listView6
            // 
            this.listView6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_25,
            this.columnHeader_26,
            this.columnHeader_27,
            this.columnHeader_28,
            this.columnHeader_37});
            this.listView6.FullRowSelect = true;
            this.listView6.HideSelection = false;
            this.listView6.Location = new System.Drawing.Point(6, 6);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(738, 455);
            this.listView6.TabIndex = 0;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_25
            // 
            this.columnHeader_25.Text = "状态";
            // 
            // columnHeader_26
            // 
            this.columnHeader_26.Text = "命令";
            this.columnHeader_26.Width = 140;
            // 
            // columnHeader_27
            // 
            this.columnHeader_27.Text = "关联储存";
            this.columnHeader_27.Width = 220;
            // 
            // columnHeader_28
            // 
            this.columnHeader_28.Text = "作者信息";
            this.columnHeader_28.Width = 160;
            // 
            // columnHeader_37
            // 
            this.columnHeader_37.Text = "Slot";
            this.columnHeader_37.Width = 0;
            // 
            // button38
            // 
            this.button38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button38.Location = new System.Drawing.Point(669, 467);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(75, 23);
            this.button38.TabIndex = 4;
            this.button38.Text = "详细信息";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button37
            // 
            this.button37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button37.Location = new System.Drawing.Point(585, 467);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(75, 23);
            this.button37.TabIndex = 3;
            this.button37.Text = "关闭";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button34
            // 
            this.button34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button34.Location = new System.Drawing.Point(6, 467);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(75, 23);
            this.button34.TabIndex = 1;
            this.button34.Text = "刷新";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button36
            // 
            this.button36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button36.Location = new System.Drawing.Point(504, 467);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(75, 23);
            this.button36.TabIndex = 2;
            this.button36.Text = "开放";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.button47);
            this.tabPage15.Controls.Add(this.button46);
            this.tabPage15.Controls.Add(this.button44);
            this.tabPage15.Controls.Add(this.listView8);
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(750, 496);
            this.tabPage15.TabIndex = 1;
            this.tabPage15.Text = "插件设置";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // button47
            // 
            this.button47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button47.Location = new System.Drawing.Point(669, 466);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(75, 23);
            this.button47.TabIndex = 5;
            this.button47.Text = "详细信息";
            this.button47.UseVisualStyleBackColor = true;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // button46
            // 
            this.button46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button46.Location = new System.Drawing.Point(579, 466);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(75, 23);
            this.button46.TabIndex = 3;
            this.button46.Text = "设置";
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.button46_Click);
            // 
            // button44
            // 
            this.button44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button44.Location = new System.Drawing.Point(6, 467);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(75, 23);
            this.button44.TabIndex = 2;
            this.button44.Text = "刷新";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // listView8
            // 
            this.listView8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView8.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_39,
            this.columnHeader_40,
            this.columnHeader_41,
            this.columnHeader_42,
            this.columnHeader_43,
            this.columnHeader_44,
            this.columnHeader_45,
            this.columnHeader_46});
            this.listView8.FullRowSelect = true;
            this.listView8.HideSelection = false;
            this.listView8.Location = new System.Drawing.Point(6, 6);
            this.listView8.Name = "listView8";
            this.listView8.Size = new System.Drawing.Size(738, 454);
            this.listView8.TabIndex = 0;
            this.listView8.UseCompatibleStateImageBehavior = false;
            this.listView8.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_39
            // 
            this.columnHeader_39.Text = "功能状态";
            // 
            // columnHeader_40
            // 
            this.columnHeader_40.Text = "功能代码";
            this.columnHeader_40.Width = 210;
            // 
            // columnHeader_41
            // 
            this.columnHeader_41.Text = "功能名称";
            this.columnHeader_41.Width = 210;
            // 
            // columnHeader_42
            // 
            this.columnHeader_42.Text = "功能设置";
            this.columnHeader_42.Width = 160;
            // 
            // columnHeader_43
            // 
            this.columnHeader_43.Text = "作者信息";
            // 
            // columnHeader_44
            // 
            this.columnHeader_44.Text = "描述信息";
            this.columnHeader_44.Width = 0;
            // 
            // columnHeader_45
            // 
            this.columnHeader_45.Text = "ID";
            this.columnHeader_45.Width = 0;
            // 
            // columnHeader_46
            // 
            this.columnHeader_46.Text = "Type";
            this.columnHeader_46.Width = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox4);
            this.tabPage8.Controls.Add(this.groupBox9);
            this.tabPage8.Controls.Add(this.groupBox5);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(768, 528);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "设置";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.checkBox40);
            this.groupBox4.Controls.Add(this.checkBox39);
            this.groupBox4.Controls.Add(this.checkBox38);
            this.groupBox4.Controls.Add(this.checkBox37);
            this.groupBox4.Controls.Add(this.checkBox35);
            this.groupBox4.Controls.Add(this.button30);
            this.groupBox4.Controls.Add(this.checkBox34);
            this.groupBox4.Controls.Add(this.checkBox33);
            this.groupBox4.Controls.Add(this.checkBox32);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.checkBox28);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.checkBox26);
            this.groupBox4.Controls.Add(this.checkBox24);
            this.groupBox4.Controls.Add(this.checkBox23);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.checkBox14);
            this.groupBox4.Controls.Add(this.checkBox13);
            this.groupBox4.Controls.Add(this.checkBox12);
            this.groupBox4.Controls.Add(this.checkBox9);
            this.groupBox4.Controls.Add(this.checkBox11);
            this.groupBox4.Controls.Add(this.checkBox10);
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Controls.Add(this.checkBoxATTState);
            this.groupBox4.Controls.Add(this.checkBoxTradeDelay);
            this.groupBox4.Controls.Add(this.checkBoxLoginReward);
            this.groupBox4.Controls.Add(this.checkBoxNotAlchemy);
            this.groupBox4.Controls.Add(this.checkBoxMonsterKill);
            this.groupBox4.Controls.Add(this.checkBox_0);
            this.groupBox4.Controls.Add(this.checkBoxAlchemy);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(6, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 515);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // checkBox40
            // 
            this.checkBox40.AutoSize = true;
            this.checkBox40.Location = new System.Drawing.Point(287, 281);
            this.checkBox40.Name = "checkBox40";
            this.checkBox40.Size = new System.Drawing.Size(96, 16);
            this.checkBox40.TabIndex = 75;
            this.checkBox40.Text = "限制跑商买卖";
            this.toolTip_0.SetToolTip(this.checkBox40, "该选项可以限制游戏内跑商特产品买卖时间");
            this.checkBox40.UseVisualStyleBackColor = true;
            this.checkBox40.CheckedChanged += new System.EventHandler(this.checkBox40_CheckedChanged);
            // 
            // checkBox39
            // 
            this.checkBox39.AutoSize = true;
            this.checkBox39.Location = new System.Drawing.Point(287, 248);
            this.checkBox39.Name = "checkBox39";
            this.checkBox39.Size = new System.Drawing.Size(96, 16);
            this.checkBox39.TabIndex = 74;
            this.checkBox39.Text = "禁用自动跟踪";
            this.toolTip_0.SetToolTip(this.checkBox39, "禁止游戏自动跟踪功能");
            this.checkBox39.UseVisualStyleBackColor = true;
            this.checkBox39.CheckedChanged += new System.EventHandler(this.checkBox39_CheckedChanged);
            // 
            // checkBox38
            // 
            this.checkBox38.AutoSize = true;
            this.checkBox38.Location = new System.Drawing.Point(287, 204);
            this.checkBox38.Name = "checkBox38";
            this.checkBox38.Size = new System.Drawing.Size(96, 16);
            this.checkBox38.TabIndex = 73;
            this.checkBox38.Text = "禁用支持目标";
            this.toolTip_0.SetToolTip(this.checkBox38, "禁用游戏支持目标功能");
            this.checkBox38.UseVisualStyleBackColor = true;
            this.checkBox38.CheckedChanged += new System.EventHandler(this.checkBox38_CheckedChanged);
            // 
            // checkBox37
            // 
            this.checkBox37.AutoSize = true;
            this.checkBox37.Location = new System.Drawing.Point(16, 326);
            this.checkBox37.Name = "checkBox37";
            this.checkBox37.Size = new System.Drawing.Size(96, 16);
            this.checkBox37.TabIndex = 72;
            this.checkBox37.Text = "禁止丢弃金币";
            this.checkBox37.UseVisualStyleBackColor = true;
            this.checkBox37.CheckedChanged += new System.EventHandler(this.checkBox37_CheckedChanged);
            // 
            // checkBox35
            // 
            this.checkBox35.AutoSize = true;
            this.checkBox35.Location = new System.Drawing.Point(287, 226);
            this.checkBox35.Name = "checkBox35";
            this.checkBox35.Size = new System.Drawing.Size(96, 16);
            this.checkBox35.TabIndex = 70;
            this.checkBox35.Text = "启用技能限制";
            this.checkBox35.UseVisualStyleBackColor = true;
            this.checkBox35.CheckedChanged += new System.EventHandler(this.checkBox35_CheckedChanged);
            // 
            // button30
            // 
            this.button30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button30.BackgroundImage")));
            this.button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Location = new System.Drawing.Point(108, 41);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(16, 16);
            this.button30.TabIndex = 69;
            this.toolTip_0.SetToolTip(this.button30, "设置禁言玩家信息");
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // checkBox34
            // 
            this.checkBox34.AutoSize = true;
            this.checkBox34.Location = new System.Drawing.Point(16, 42);
            this.checkBox34.Name = "checkBox34";
            this.checkBox34.Size = new System.Drawing.Size(96, 16);
            this.checkBox34.TabIndex = 68;
            this.checkBox34.Text = "禁止玩家发言";
            this.toolTip_0.SetToolTip(this.checkBox34, "禁止某个玩家发言");
            this.checkBox34.UseVisualStyleBackColor = true;
            this.checkBox34.CheckedChanged += new System.EventHandler(this.checkBox34_CheckedChanged);
            // 
            // checkBox33
            // 
            this.checkBox33.AutoSize = true;
            this.checkBox33.Location = new System.Drawing.Point(287, 160);
            this.checkBox33.Name = "checkBox33";
            this.checkBox33.Size = new System.Drawing.Size(108, 16);
            this.checkBox33.TabIndex = 67;
            this.checkBox33.Text = "实时荣誉排行榜";
            this.toolTip_0.SetToolTip(this.checkBox33, "将游戏排行榜系统设置为实时显示");
            this.checkBox33.UseVisualStyleBackColor = true;
            this.checkBox33.CheckedChanged += new System.EventHandler(this.checkBox33_CheckedChanged);
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.Location = new System.Drawing.Point(287, 182);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(108, 16);
            this.checkBox32.TabIndex = 66;
            this.checkBox32.Text = "禁用荣誉排行榜";
            this.toolTip_0.SetToolTip(this.checkBox32, "禁止荣誉系统");
            this.checkBox32.UseVisualStyleBackColor = true;
            this.checkBox32.CheckedChanged += new System.EventHandler(this.checkBox32_CheckedChanged);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(379, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(16, 16);
            this.button6.TabIndex = 65;
            this.toolTip_0.SetToolTip(this.button6, "设置多开信任IP");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Location = new System.Drawing.Point(287, 116);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(96, 16);
            this.checkBox28.TabIndex = 62;
            this.checkBox28.Text = "启用智能助手";
            this.toolTip_0.SetToolTip(this.checkBox28, "启用后玩家可使用游戏命令");
            this.checkBox28.UseVisualStyleBackColor = true;
            this.checkBox28.CheckedChanged += new System.EventHandler(this.checkBox28_CheckedChanged);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(379, 83);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(16, 16);
            this.button7.TabIndex = 61;
            this.toolTip_0.SetToolTip(this.button7, "设置游戏指南");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Location = new System.Drawing.Point(287, 84);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(96, 16);
            this.checkBox26.TabIndex = 59;
            this.checkBox26.Text = "启用游戏指南";
            this.toolTip_0.SetToolTip(this.checkBox26, "启用该功能后玩家登录游戏时将显示指南信息");
            this.checkBox26.UseVisualStyleBackColor = true;
            this.checkBox26.CheckedChanged += new System.EventHandler(this.checkBox26_CheckedChanged);
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Location = new System.Drawing.Point(16, 248);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(96, 16);
            this.checkBox24.TabIndex = 58;
            this.checkBox24.Text = "启用要塞奖励";
            this.toolTip_0.SetToolTip(this.checkBox24, "启用要塞奖励后玩家参与要塞战将自动获得奖励");
            this.checkBox24.UseVisualStyleBackColor = true;
            this.checkBox24.CheckedChanged += new System.EventHandler(this.checkBox24_CheckedChanged);
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(287, 62);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(96, 16);
            this.checkBox23.TabIndex = 57;
            this.checkBox23.Text = "启用多开限制";
            this.toolTip_0.SetToolTip(this.checkBox23, "启用该功能后玩家开启的的客户端达到指定数量后，将不能再进入游戏");
            this.checkBox23.UseVisualStyleBackColor = true;
            this.checkBox23.CheckedChanged += new System.EventHandler(this.checkBox23_CheckedChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(142, 448);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(112, 21);
            this.textBox6.TabIndex = 55;
            this.textBox6.Text = "192.168.1.255";
            this.textBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyDown);
            this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 54;
            this.label10.Text = "IP:";
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(16, 450);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(96, 16);
            this.checkBox14.TabIndex = 52;
            this.checkBox14.Text = "只允许信任IP";
            this.toolTip_0.SetToolTip(this.checkBox14, "启用该功能后只有指定的IP才可进入游戏");
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(16, 428);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(144, 16);
            this.checkBox13.TabIndex = 51;
            this.checkBox13.Text = "关闭连接 AgentServer";
            this.toolTip_0.SetToolTip(this.checkBox13, "启用该功能后玩家将不能进入游戏(游戏内的玩家不受影响)");
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(16, 406);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(156, 16);
            this.checkBox12.TabIndex = 50;
            this.checkBox12.Text = "关闭连接 GatewayServer";
            this.toolTip_0.SetToolTip(this.checkBox12, "启用该功能后玩家不能打开游戏");
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(16, 84);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(108, 16);
            this.checkBox9.TabIndex = 42;
            this.checkBox9.Text = "启用自定义功能";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(16, 372);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(156, 16);
            this.checkBox11.TabIndex = 41;
            this.checkBox11.Text = "禁止转移东西到宠物包裹";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(16, 350);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(96, 16);
            this.checkBox10.TabIndex = 40;
            this.checkBox10.Text = "禁止丢弃物品";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(287, 20);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(120, 16);
            this.checkBox7.TabIndex = 38;
            this.checkBox7.Text = "启用全体聊天限制";
            this.toolTip_0.SetToolTip(this.checkBox7, "启用该功能后玩家不能连续使用全体聊天道具刷屏");
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBoxATTState
            // 
            this.checkBoxATTState.AutoSize = true;
            this.checkBoxATTState.Location = new System.Drawing.Point(16, 303);
            this.checkBoxATTState.Name = "checkBoxATTState";
            this.checkBoxATTState.Size = new System.Drawing.Size(96, 16);
            this.checkBoxATTState.TabIndex = 31;
            this.checkBoxATTState.Text = "启用主动检测";
            this.toolTip_0.SetToolTip(this.checkBoxATTState, "启用主动检测后系统将拦截未知的攻击行为");
            this.checkBoxATTState.UseVisualStyleBackColor = true;
            this.checkBoxATTState.CheckedChanged += new System.EventHandler(this.checkBoxATTState_CheckedChanged);
            // 
            // checkBoxTradeDelay
            // 
            this.checkBoxTradeDelay.AutoSize = true;
            this.checkBoxTradeDelay.Location = new System.Drawing.Point(287, 42);
            this.checkBoxTradeDelay.Name = "checkBoxTradeDelay";
            this.checkBoxTradeDelay.Size = new System.Drawing.Size(96, 16);
            this.checkBoxTradeDelay.TabIndex = 37;
            this.checkBoxTradeDelay.Text = "启用交易限制";
            this.toolTip_0.SetToolTip(this.checkBoxTradeDelay, "启用该功能后玩家不能卡交易");
            this.checkBoxTradeDelay.UseVisualStyleBackColor = true;
            this.checkBoxTradeDelay.CheckedChanged += new System.EventHandler(this.checkBoxTradeDelay_CheckedChanged);
            // 
            // checkBoxLoginReward
            // 
            this.checkBoxLoginReward.AutoSize = true;
            this.checkBoxLoginReward.Location = new System.Drawing.Point(16, 226);
            this.checkBoxLoginReward.Name = "checkBoxLoginReward";
            this.checkBoxLoginReward.Size = new System.Drawing.Size(96, 16);
            this.checkBoxLoginReward.TabIndex = 36;
            this.checkBoxLoginReward.Text = "启用签到奖励";
            this.toolTip_0.SetToolTip(this.checkBoxLoginReward, "启用签到奖励后玩家每天登录都可以获得奖励");
            this.checkBoxLoginReward.UseVisualStyleBackColor = true;
            this.checkBoxLoginReward.CheckedChanged += new System.EventHandler(this.checkBoxLoginReward_CheckedChanged);
            // 
            // checkBoxNotAlchemy
            // 
            this.checkBoxNotAlchemy.AutoSize = true;
            this.checkBoxNotAlchemy.Location = new System.Drawing.Point(16, 204);
            this.checkBoxNotAlchemy.Name = "checkBoxNotAlchemy";
            this.checkBoxNotAlchemy.Size = new System.Drawing.Size(120, 16);
            this.checkBoxNotAlchemy.TabIndex = 35;
            this.checkBoxNotAlchemy.Text = "启用炼金等级限制";
            this.toolTip_0.SetToolTip(this.checkBoxNotAlchemy, "启用该功能后将限制玩家的炼金等级");
            this.checkBoxNotAlchemy.UseVisualStyleBackColor = true;
            this.checkBoxNotAlchemy.CheckedChanged += new System.EventHandler(this.checkBoxNotAlchemy_CheckedChanged);
            // 
            // checkBoxMonsterKill
            // 
            this.checkBoxMonsterKill.AutoSize = true;
            this.checkBoxMonsterKill.Location = new System.Drawing.Point(16, 160);
            this.checkBoxMonsterKill.Name = "checkBoxMonsterKill";
            this.checkBoxMonsterKill.Size = new System.Drawing.Size(120, 16);
            this.checkBoxMonsterKill.TabIndex = 32;
            this.checkBoxMonsterKill.Text = "启用怪物击杀奖励";
            this.toolTip_0.SetToolTip(this.checkBoxMonsterKill, "启用击杀稀有怪物奖励");
            this.checkBoxMonsterKill.UseVisualStyleBackColor = true;
            this.checkBoxMonsterKill.CheckedChanged += new System.EventHandler(this.checkBoxMonsterKill_CheckedChanged);
            // 
            // checkBox_0
            // 
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Location = new System.Drawing.Point(16, 281);
            this.checkBox_0.Name = "checkBox_0";
            this.checkBox_0.Size = new System.Drawing.Size(96, 16);
            this.checkBox_0.TabIndex = 34;
            this.checkBox_0.Text = "启用上线提示";
            this.toolTip_0.SetToolTip(this.checkBox_0, "启用上线提示后玩家登录游戏将显示欢迎信息");
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new System.EventHandler(this.checkBox_0_CheckedChanged);
            // 
            // checkBoxAlchemy
            // 
            this.checkBoxAlchemy.AutoSize = true;
            this.checkBoxAlchemy.Location = new System.Drawing.Point(16, 182);
            this.checkBoxAlchemy.Name = "checkBoxAlchemy";
            this.checkBoxAlchemy.Size = new System.Drawing.Size(120, 16);
            this.checkBoxAlchemy.TabIndex = 33;
            this.checkBoxAlchemy.Text = "启用炼金等级奖励";
            this.toolTip_0.SetToolTip(this.checkBoxAlchemy, "启用炼金达到指定等级自动发放奖励功能");
            this.checkBoxAlchemy.UseVisualStyleBackColor = true;
            this.checkBoxAlchemy.CheckedChanged += new System.EventHandler(this.checkBoxAlchemy_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(16, 62);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(108, 16);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "启用自定义通知";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(16, 138);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(96, 16);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "启用摆摊奖励";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 116);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 16);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "启用组队奖励";
            this.toolTip_0.SetToolTip(this.checkBox2, "启用组队注册奖励");
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "禁用全体聊天";
            this.toolTip_0.SetToolTip(this.checkBox1, "立即禁止全聊道具");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.checkBox21);
            this.groupBox9.Controls.Add(this.checkBox20);
            this.groupBox9.Controls.Add(this.button32);
            this.groupBox9.Controls.Add(this.button26);
            this.groupBox9.Location = new System.Drawing.Point(515, 422);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(247, 100);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(17, 72);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(96, 16);
            this.checkBox21.TabIndex = 7;
            this.checkBox21.Text = "限制注册邮箱";
            this.toolTip_0.SetToolTip(this.checkBox21, "启用后玩家一个邮箱只能注册一次");
            this.checkBox21.UseVisualStyleBackColor = true;
            this.checkBox21.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(155, 72);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(72, 16);
            this.checkBox20.TabIndex = 6;
            this.checkBox20.Text = "自动启动";
            this.toolTip_0.SetToolTip(this.checkBox20, "启用后用户管理服务器将自动启动");
            this.checkBox20.UseVisualStyleBackColor = true;
            this.checkBox20.CheckedChanged += new System.EventHandler(this.checkBox20_CheckedChanged);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(153, 18);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(74, 31);
            this.button32.TabIndex = 5;
            this.button32.Text = "关闭";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(17, 18);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(130, 31);
            this.button26.TabIndex = 4;
            this.button26.Text = "启动用户管理服务器";
            this.toolTip_0.SetToolTip(this.button26, "点击后玩家可使用UserManager程序进行注册账号,修改密码等操作");
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.button35);
            this.groupBox5.Controls.Add(this.button33);
            this.groupBox5.Controls.Add(this.button19);
            this.groupBox5.Location = new System.Drawing.Point(515, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(247, 413);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(17, 20);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(210, 32);
            this.button35.TabIndex = 59;
            this.button35.Text = "刷新 所有数据缓存";
            this.toolTip_0.SetToolTip(this.button35, "点击后将刷新所有数据库缓存并且让数据库设置立即生效");
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button33
            // 
            this.button33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button33.Location = new System.Drawing.Point(17, 364);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(210, 38);
            this.button33.TabIndex = 9;
            this.button33.Text = "详细设置";
            this.toolTip_0.SetToolTip(this.button33, "点击后打开详细设置界面");
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(17, 58);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(210, 32);
            this.button19.TabIndex = 5;
            this.button19.Text = "重置 用户数据";
            this.toolTip_0.SetToolTip(this.button19, "点击后将重置刺陵防御内的用户数据(开服用于清档)");
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button22);
            this.tabPage5.Controls.Add(this.groupBox15);
            this.tabPage5.Controls.Add(this.textBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 528);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "全体聊天";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.Location = new System.Drawing.Point(679, 496);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(82, 26);
            this.button22.TabIndex = 24;
            this.button22.Text = "发送公告";
            this.toolTip_0.SetToolTip(this.button22, "发送公告信息");
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBox3);
            this.groupBox15.Location = new System.Drawing.Point(6, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(755, 487);
            this.groupBox15.TabIndex = 25;
            this.groupBox15.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(6, 20);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(743, 461);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(6, 497);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(658, 25);
            this.textBox4.TabIndex = 23;
            // 
            // timer_0
            // 
            this.timer_0.Interval = 500;
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // timer_1
            // 
            this.timer_1.Interval = 1000;
            this.timer_1.Tick += new System.EventHandler(this.timer_1_Tick);
            // 
            // timer_2
            // 
            this.timer_2.Tick += new System.EventHandler(this.timer_2_Tick);
            // 
            // timer_3
            // 
            this.timer_3.Interval = 300;
            this.timer_3.Tick += new System.EventHandler(this.timer_3_Tick);
            // 
            // timer_4
            // 
            this.timer_4.Tick += new System.EventHandler(this.timer_4_Tick);
            // 
            // timer_5
            // 
            this.timer_5.Interval = 1000;
            this.timer_5.Tick += new System.EventHandler(this.timer_5_Tick);
            // 
            // CenterManagerServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CenterManagerServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "全新刺陵防御[188版]管理器-最终章";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CenterManagerServerForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CenterManagerServerForm_FormClosed);
            this.Load += new System.EventHandler(this.CenterManagerServerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.tabPage13.ResumeLayout(false);
            this.tabPage12.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.tabPage15.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.ResumeLayout(false);

	}
}
