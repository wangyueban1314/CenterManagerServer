using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.Net.Sockets;

public class LoginForm : Form {
	public Button button1;
	private Button button2;
	private Button button3;
	private IContainer icontainer_0=null;
	private Label label1;
	public Label label2;
	private TextBox textBox1;
	private IContainer components;
	private ProgressBar progressBar_UI_Pro;
	private TextBox textBox_UI_Notice;
	private Timer timer_0;

	public LoginForm() {
		this.InitializeComponent();
		ZC Z = new ZC();

		textBox1.Text = Z.getMNum();
	}

	private void button1_Click(object sender, EventArgs e) {
		if (this.textBox1.Text != "") {
			Class8.bool_0 = false;
			this.button1.Enabled = false;
			this.label2.Text = "连接服务器获取授权...";
			try {
				int num = 0x647;
				if (num == -2000) {
					this.method_0();
				}
				else if ((num >= -4) && (num <= -1)) {
					this.method_5();
				}
				else if (num == -1000) {
					this.method_6();
				}
				else if ((num >= 0x5dc) && (num <= 0x5df)) {
					this.method_6();
				}
				else if (num == 0x647) {
					this.method_10(0);
				}
				else if (num == 0x63e) {
					this.method_1();
				}
				else if (num == 0x63f) {
					this.method_2();
				}
				else if (num == 0x640) {
					this.method_3();
				}
				else if (num == 0x641) {
					this.method_4();
				}
				else if (num == 0x642) {
					this.method_5();
				}
				else if (num == 0x643) {
					this.method_6();
				}
				else if (num == 0x644) {
					this.method_7();
				}
				else if (num == 0x645) {
					this.method_8();
				}
				else if (num == 0x646) {
					this.method_9();
				}
				else {
					this.method_5();
				}
			}
			catch {
				this.method_0();
			}
		}

	}
	//无验证

	private void method_8()
	{
		this.label2.Text = "该服务器授权已经结束！";
	}

	private void method_9()
	{
		this.label2.Text = "服务器载入数据失败！";
	}

	public static string smethod_0()
	{
		new ManagementClass("Win32_NetworkAdapterConfiguration");
		ManagementObject obj2 = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
		obj2.Get();
		return obj2.GetPropertyValue("VolumeSerialNumber").ToString();
	}

	public static string smethod_1()
	{
		string str = null;
		ManagementClass class2 = new ManagementClass("win32_Processor");
		using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = class2.GetInstances().GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				ManagementObject current = (ManagementObject)enumerator.Current;
				str = current.Properties["Processorid"].Value.ToString();
			}
		}
		return str;
	}

	/* private scope */
	static ManagementObjectCollection.ManagementObjectEnumerator smethod_10(ManagementObjectCollection managementObjectCollection_0)
	{
		return managementObjectCollection_0.GetEnumerator();
	}

	/* private scope */
	static ManagementBaseObject smethod_11(ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		return managementObjectEnumerator_0.Current;
	}

	/* private scope */
	static PropertyDataCollection smethod_12(ManagementBaseObject managementBaseObject_0)
	{
		return managementBaseObject_0.Properties;
	}

	/* private scope */
	static PropertyData smethod_13(PropertyDataCollection propertyDataCollection_0, string string_0)
	{
		return propertyDataCollection_0[string_0];
	}
	private void button2_Click(object sender, EventArgs e) {
		base.Dispose();
	}

	private void button3_Click(object sender, EventArgs e) {
		Class8.class32_0.method_0("Setting", "ServerLocalIP", "192.168.1.70");
		MessageBox.Show("初始设置完成，程序将自动重启！");
		Application.ExitThread();
		Restart();
	}

	private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar_UI_Pro = new System.Windows.Forms.ProgressBar();
            this.textBox_UI_Notice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "已是最新版本！BY:QQ125661210";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "机器码:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(323, 21);
            this.textBox1.TabIndex = 5;
            // 
            // timer_0
            // 
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "重置配置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar_UI_Pro
            // 
            this.progressBar_UI_Pro.Location = new System.Drawing.Point(9, 63);
            this.progressBar_UI_Pro.Name = "progressBar_UI_Pro";
            this.progressBar_UI_Pro.Size = new System.Drawing.Size(455, 10);
            this.progressBar_UI_Pro.TabIndex = 24;
            // 
            // textBox_UI_Notice
            // 
            this.textBox_UI_Notice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_UI_Notice.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_UI_Notice.Location = new System.Drawing.Point(9, 76);
            this.textBox_UI_Notice.Multiline = true;
            this.textBox_UI_Notice.Name = "textBox_UI_Notice";
            this.textBox_UI_Notice.ReadOnly = true;
            this.textBox_UI_Notice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_UI_Notice.Size = new System.Drawing.Size(455, 236);
            this.textBox_UI_Notice.TabIndex = 26;
            this.textBox_UI_Notice.Text = resources.GetString("textBox_UI_Notice.Text");
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 324);
            this.Controls.Add(this.textBox_UI_Notice);
            this.Controls.Add(this.progressBar_UI_Pro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "丝路防御";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

	}


	

	private void LoginForm_Load(object sender, EventArgs e) {


		Class8.object_0 = new object();
	/*	if (DateTime.Now > new DateTime(2022, 4, 26, 23, 59, 59, DateTimeKind.Local)) {
			MessageBox.Show("程序测试使用时间已结束，该程序已作废！");
			base.Dispose();
			return;
		}
		*/
		if (!Directory.Exists("Log")) {
			Directory.CreateDirectory("Log");
		}
		/*
		if (!File.Exists("QiangweidiewuApi.dll")) {
			MessageBox.Show("QiangweidiewuApi.dll 文件不存在！");
			base.Dispose();
			return;
		}
		if (!File.Exists("QiangweidiewuYstem.dll")) {
			MessageBox.Show("QiangweidiewuYstem.dll 文件不存在！");
			base.Dispose();
			return;
		}
		*/
		if (Process.GetCurrentProcess().ProcessName == "CenterManagerServer") {
			return;
		}
	}


	private void method_0() {
		this.label2.Text = "连接云端服务器失败!";
	}

	private void method_1() {
		this.label2.Text = "该程序不能登录服务器！";
	}

	private void method_10(ushort ushort_0) {
		this.label2.Text = "正在验证用户信息登录中...";
		this.timer_0.Interval = 500;
		this.timer_0.Start();
	}

	void method_11() {
		base.Dispose();
	}

	private void method_2() {
		this.label2.Text = "该程序已经损坏请重新下载！代码：761";
	}

	private void method_3() {
		this.label2.Text = "该程序已经损坏请重新下载！代码：762";
	}

	private void method_4() {
		MessageBox.Show("该程序需要升级！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		
	}

	private void method_5() {
		this.label2.Text = "服务器目前无法登录！";
	}

	private void method_6() {
		this.label2.Text = "该服务器没有授权！";
	}

	private void method_7() {
		this.label2.Text = "该服务器需要重新授权！";
	}



	/* private scope */
	static object smethod_14(PropertyData propertyData_0) {
		return propertyData_0.Value;
	}

	/* private scope */
	static bool smethod_15(ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator_0) {
		return managementObjectEnumerator_0.MoveNext();
	}

	/* private scope */
	static void smethod_16(IDisposable idisposable_0) {
		idisposable_0.Dispose();
	}

	/* private scope */
	static string smethod_17(string string_0, string string_1, string string_2) {
		return (string_0 + string_1 + string_2);
	}

	/* private scope */
	static string smethod_18(string string_0, int int_0, int int_1) {
		return string_0.Substring(int_0, int_1);
	}

	/* private scope */
	static ManagementObjectSearcher smethod_19() {
		return new ManagementObjectSearcher();
	}

	public static string smethod_2() {
		return (smethod_3() + smethod_1() + smethod_0()).Substring(0, 30);
	}

	/* private scope */
	static SelectQuery smethod_20(string string_0, string string_1, string[] string_2) {
		return new SelectQuery(string_0, string_1, string_2);
	}

	/* private scope */
	static void smethod_21(ManagementObjectSearcher managementObjectSearcher_0, ObjectQuery objectQuery_0) {
		managementObjectSearcher_0.Query = objectQuery_0;
	}

	/* private scope */
	static ManagementObjectCollection smethod_22(ManagementObjectSearcher managementObjectSearcher_0) {
		return managementObjectSearcher_0.Get();
	}

	/* private scope */
	static string smethod_23(string string_0) {
		return string_0.Trim();
	}

	/* private scope */
	static object smethod_24() {
		return new object();
	}

	/* private scope */
	static bool smethod_25(string string_0) {
		return Directory.Exists(string_0);
	}

	/* private scope */
	static DirectoryInfo smethod_26(string string_0) {
		return Directory.CreateDirectory(string_0);
	}

	/* private scope */
	static bool smethod_27(string string_0) {
		return File.Exists(string_0);
	}

	/* private scope */
	static DialogResult smethod_28(string string_0) {
		return MessageBox.Show(string_0);
	}

	/* private scope */
	static string smethod_29(IntPtr intptr_0) {
		return Marshal.PtrToStringAnsi(intptr_0);
	}

	public static string smethod_3() {
		ManagementObjectSearcher searcher = new ManagementObjectSearcher {
			Query = new SelectQuery("Win32_DiskDrive", "", new string[] { "PNPDeviceID", "Signature" })
		};
		ManagementObjectCollection.ManagementObjectEnumerator enumerator = searcher.Get().GetEnumerator();
		enumerator.MoveNext();
		return enumerator.Current.Properties["signature"].Value.ToString().Trim();
	}

	/* private scope */
	static Process smethod_30() {
		return Process.GetCurrentProcess();
	}

	/* private scope */
	static string smethod_31(Process process_0) {
		return process_0.ProcessName;
	}

	/* private scope */
	static bool smethod_32(string string_0, string string_1) {
		return (string_0 == string_1);
	}

	/* private scope */
	static void smethod_33(Control control_0, string string_0) {
		control_0.Text = string_0;
	}

	/* private scope */
	static void smethod_34(Control control_0, bool bool_0) {
		control_0.Enabled = bool_0;
	}

	/* private scope */
	static DialogResult smethod_35(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0) {
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	/* private scope */
	static void smethod_36(Timer timer_1, int int_0) {
		timer_1.Interval = int_0;
	}

	/* private scope */
	static void smethod_37(Timer timer_1) {
		timer_1.Start();
	}

	/* private scope */
	static void smethod_38(Timer timer_1) {
		timer_1.Stop();
	}

	/* private scope */
	static void smethod_39(Control control_0) {
		control_0.Show();
	}

	/* private scope */
	static ManagementClass smethod_4(string string_0) {
		return new ManagementClass(string_0);
	}

	/* private scope */
	static void smethod_40(Control control_0) {
		control_0.Hide();
	}

	/* private scope */
	static string smethod_41(Control control_0) {
		return control_0.Text;
	}

	/* private scope */
	static Container smethod_42() {
		return new Container();
	}

	/* private scope */
	static System.Type smethod_43(RuntimeTypeHandle runtimeTypeHandle_0) {
		return System.Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	/* private scope */
	static ComponentResourceManager smethod_44(System.Type type_0) {
		return new ComponentResourceManager(type_0);
	}

	/* private scope */
	static Label smethod_45() {
		return new Label();
	}

	/* private scope */
	static Button smethod_46() {
		return new Button();
	}

	/* private scope */
	static TextBox smethod_47() {
		return new TextBox();
	}

	/* private scope */
	static Timer smethod_48(IContainer icontainer_1) {
		return new Timer(icontainer_1);
	}

	/* private scope */
	static void smethod_49(Control control_0) {
		control_0.SuspendLayout();
	}

	/* private scope */
	static ManagementObject smethod_5(string string_0) {
		return new ManagementObject(string_0);
	}

	/* private scope */
	static void smethod_6(ManagementObject managementObject_0) {
		managementObject_0.Get();
	}

	/* private scope */
	static object smethod_7(ManagementBaseObject managementBaseObject_0, string string_0) {
		return managementBaseObject_0.GetPropertyValue(string_0);
	}

	/* private scope */
	static string smethod_8(object object_0) {
		return object_0.ToString();
	}

	/* private scope */
	static ManagementObjectCollection smethod_9(ManagementClass managementClass_0) {
		return managementClass_0.GetInstances();
	}

	protected override void Dispose(bool disposing) {
		if (disposing && this.icontainer_0 != null) {
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}


	private void timer_0_Tick(object sender, EventArgs e) {
		this.timer_0.Stop();
		new CenterManagerServerForm().Show();
		base.Hide();
	}

	private void label2_Click(object sender, EventArgs e) {

	}


 private void Restart()
 
          {

		System.Threading.Thread thtmp = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(run));
	
            object appName = Application.ExecutablePath;

		//System.Threading.Thread.Sleep(2000);

             thtmp.Start(appName);
	
         }

         private void run(Object obj)

         {
	
             Process ps = new Process();
	
             ps.StartInfo.FileName = obj.ToString();
	
             ps.Start();
	
         }
}
