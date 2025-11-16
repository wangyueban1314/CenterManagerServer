using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Linq;

internal class GuideForm : Form {
    private int int_0 = 5;

    private IContainer icontainer_0=null;

    private Label label1;

    private TextBox textBox1;

    private TextBox textBox2;

    private Label label2;

    private TextBox textBox3;

    private Label label3;

    private Button button3;

    private TextBox SQLtextBox;

    private Label label4;

    private Button button1;

    private Button button2;

    private TextBox textBox4;

    private Label label5;

    private Button button4;

    private OpenFileDialog openFileDialog_0;

    private TextBox textBox5;
    private CheckBox checkBox1;

    private TextBox textBox6;

    private TextBox textBox7;

    private Label label8;

    private Label label9;
    private Timer timer_0;

    private Label label6;

    private ComboBox comboBox1;

    private ComboBox comboBox2;

    private Label label7;



    private ComboBox comboBox3;

    private Label label10;

    private TextBox textBox8;

    private Label label11;

    private Label label12;
	private IContainer components;
	private TextBox textBox9;

    public GuideForm() {
        InitializeComponent();
    }

    private string GetLocalIPAddress()
    {
        // 获取所有活动的网络接口
        var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces()
            .Where(nic => nic.OperationalStatus == OperationalStatus.Up) // 只考虑活动的接口
            .Where(nic => nic.NetworkInterfaceType != NetworkInterfaceType.Loopback); // 排除回环接口

        foreach (var nic in networkInterfaces)
        {
            // 获取接口的IP地址信息
            var unicastAddresses = nic.GetIPProperties().UnicastAddresses;
            foreach (var unicastAddress in unicastAddresses)
            {
                // 筛选IPv4地址且非回环地址
                if (unicastAddress.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork &&
                    !IPAddress.IsLoopback(unicastAddress.Address))
                {
                    return unicastAddress.Address.ToString();
                }
            }
        }

        // 如果没有找到有效IP，返回默认值
        return "127.0.0.1";
    }

    private void button3_Click(object sender, EventArgs e) {
        var add_SQL_Form = new Add_SQL_Form();
        add_SQL_Form.ushort_0 = 1;
        add_SQL_Form.string_0 = SQLtextBox.Text;
        add_SQL_Form.ShowDialog();
        if (add_SQL_Form.string_0 != "") {
            SQLtextBox.Text = add_SQL_Form.string_0;
        }
    }
    private void comboBox3_DropDown(object sender, EventArgs e)
    {
        if (SQLtextBox.Text == "")
        {
            MessageBox.Show("请设置数据库连接！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        comboBox3.Items.Clear();
        string text = "";
        string text2 = "";
        string text3 = "";
        string[] array = SQLtextBox.Text.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (array.Length != 3 && array.Length != 4)
        {
            MessageBox.Show("数据库连接字符串不正确", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (array.Length == 3)
        {
            text = array[0].Substring(7, array[0].Length - 7);
            text2 = array[1].Substring(4, array[1].Length - 4);
            text3 = array[2].Substring(4, array[2].Length - 4);
        }
        if (array.Length == 4)
        {
            text = array[0].Substring(7, array[0].Length - 7);
            text2 = array[2].Substring(4, array[2].Length - 4);
            text3 = array[3].Substring(4, array[3].Length - 4);
        }
        if (Class5.smethod_113("SERVER=" + text + ";UID=" + text2 + ";PWD=" + text3 + ";", out var string_))
        {
            if (string_.Length == 0)
            {
                return;
            }
            string[] array2 = string_.Split(new char[1] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (array2.Length != 0)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    comboBox3.Items.Add(array2[i]);
                }
            }
        }
        else
        {
            MessageBox.Show("无法打开数据库" + Environment.NewLine + "1.请检查数据账号密码以及数据库服务器地址是否正确！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
    private void GuideForm_Load(object sender, EventArgs e) {

        // 自动获取本机IP并赋值给服务器IP文本框
        textBox1.Text = GetLocalIPAddress();

        comboBox1.Text = Class8.string_5;
        comboBox2.Text = Class8.string_6;
        comboBox3.Text = Class8.string_4;
      //  textBox1.Text = Class8.string_2;
        textBox2.Text = Class8.ushort_0.ToString();
        textBox3.Text = Class8.ushort_1.ToString();
        textBox8.Text = Class8.ushort_8.ToString();
        SQLtextBox.Text = Class8.string_3;
        checkBox1.Checked = Class8.bool_19;
        if (checkBox1.Checked) {
            label8.Visible = true;
            label9.Visible = true;
            label12.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox9.Visible = true;
            base.Height = 530;
        }
        else {
            label8.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox9.Visible = false;
            base.Height = 450;
        }
    }

    private void button1_Click(object sender, EventArgs e) {
        if (textBox1.Text == "") {
            MessageBox.Show("请填写服务器IP", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (textBox2.Text == "") {
            MessageBox.Show("请填写GatewayServer端口", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (textBox3.Text == "") {
            MessageBox.Show("请填写AgentServer端口", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (textBox8.Text == "") {
            MessageBox.Show("请填写DownloadServer端口", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (SQLtextBox.Text == "") {
            MessageBox.Show("请设置数据库连接字符串", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (textBox4.Text == "") {
            MessageBox.Show("请设置服务端配置文件 server.cfg 所在路径", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (comboBox1.Text == "") {
            MessageBox.Show("请选择游戏数据库主库", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (comboBox2.Text == "") {
            MessageBox.Show("请选择游戏数据库账号库", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (comboBox3.Text == "") {
            MessageBox.Show("请选择游戏数据库日志库", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (checkBox1.Checked) {
            if (textBox6.Text == "") {
                MessageBox.Show("请填写服务器名称", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (textBox7.Text == "") {
                MessageBox.Show("请填写服务器最大在线", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (textBox9.Text == "") {
                MessageBox.Show("请填写服务器区域编号", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }
        string text = "";
        string text2 = "";
        string text3 = "";
        string[] array = SQLtextBox.Text.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (array.Length != 3 && array.Length != 4) {
            MessageBox.Show("数据库连接字符串不正确", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (File.Exists(textBox4.Text)) {
            if (Class9.smethod_8(textBox4.Text, "GatewayServer") != Class8.ushort_6) {
                MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("server.cfg 文件内的GatewayServer7 -> Certification 项未将端口设置为 35880，请手动设置该选项后点击确定！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (Class8.bool_57 && Class9.smethod_8(textBox4.Text, "DownloadServer") != Class8.ushort_6) {
                MessageBox.Show("server.cfg 文件内的DownloadServer -> Certification 项未将端口设置为 35880，请手动设置该选项后点击确定！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (Class9.smethod_8(textBox4.Text, "AgentServer") != Class8.ushort_7) {
                MessageBox.Show("server.cfg 文件内的AgentServer -> Certification 项未将端口设置为 35882，请手动设置该选项后点击确定！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (array.Length == 3) {
                text = array[0].Substring(7, array[0].Length - 7);
                text2 = array[1].Substring(4, array[1].Length - 4);
                text3 = array[2].Substring(4, array[2].Length - 4);
            }
            if (array.Length == 4) {
                text = array[0].Substring(7, array[0].Length - 7);
                text2 = array[2].Substring(4, array[2].Length - 4);
                text3 = array[3].Substring(4, array[3].Length - 4);
            }
            button1.Enabled = false;
            textBox5.Clear();
            textBox5.AppendText("服务器IP检查完成" + Environment.NewLine);
            textBox5.AppendText("GatewayServer端口检查完成" + Environment.NewLine);
            textBox5.AppendText("AgentServer端口检查完成" + Environment.NewLine);
            textBox5.AppendText("server.cfg 文件检查完成" + Environment.NewLine);
            string string_ = "server=" + text + ";UID=" + text2 + ";PWD=" + text3 + ";";
            if (!Class5.smethod_110(string_)) {
                MessageBox.Show("无法连接数据库" + Environment.NewLine + "请检查数据账号密码以及数据库服务器地址是否正确！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button1.Enabled = true;
                return;
            }
            string_ = "server=" + text + ";database=" + comboBox1.Text + ";UID=" + text2 + ";PWD=" + text3 + ";";
            if (!Class5.smethod_114(string_, "_Char")) {
                MessageBox.Show("请选择正确的游戏数据库主库！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button1.Enabled = true;
                return;
            }
            textBox5.AppendText("检查游戏主库完成" + Environment.NewLine);
            string_ = "server=" + text + ";database=" + comboBox2.Text + ";UID=" + text2 + ";PWD=" + text3 + ";";
            if (!Class5.smethod_114(string_, "TB_User")) {
                MessageBox.Show("请选择正确的游戏数据库账号库！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button1.Enabled = true;
                return;
            }
            string_ = "server=" + text + ";database=" + comboBox3.Text + ";UID=" + text2 + ";PWD=" + text3 + ";";
            if (!Class5.smethod_114(string_, "_LogEventItem")) {
                MessageBox.Show("请选择正确的游戏数据库日志库！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button1.Enabled = true;
                return;
            }
            textBox5.AppendText("数据库连接测试完成" + Environment.NewLine);
            string_ = "server=" + text + ";UID=" + text2 + ";PWD=" + text3 + ";";
            if (!Class5.smethod_109(string_, "SR_Center")) {
                textBox5.AppendText("SR_Center 数据库不存在,开始创建" + Environment.NewLine);
                if (!Class5.smethod_112(string_, "SR_Center")) {
                    MessageBox.Show("无法创建数据库 SR_Center", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    button1.Enabled = true;
                    return;
                }
                textBox5.AppendText("SR_Center 数据库创建完成" + Environment.NewLine);
            }
            else {
                textBox5.AppendText("SR_Center 数据库检查完成" + Environment.NewLine);
            }
            string_ = "server=" + text + ";database=SR_Center;UID=" + text2 + ";PWD=" + text3 + ";";
            if (!Class5.smethod_110(string_)) {
                MessageBox.Show("无法连接数据库 SR_Center" + Environment.NewLine + "1.请检查数据账号密码以及数据库服务器地址是否正确！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button1.Enabled = true;
                return;
            }
            textBox5.AppendText("SR_Center 数据库连接测试完成" + Environment.NewLine);
            textBox5.AppendText("刺陵防御环境检查完成" + Environment.NewLine);
            textBox5.AppendText("开始检查数据库" + Environment.NewLine);
            Class8.string_3 = string_;
            try {
                string text4 = Application.StartupPath + "\\Sql";
                var directoryInfo = new DirectoryInfo(text4);
                var files = directoryInfo.GetFiles();
                for (int i = 0; i < files.Length; i++) {
                    string name = files[i].Name;
                    string[] array2 = name.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries);
                    if (array2.Length != 3 || !(array2[2] == "sql") || !(array2[0] == "Tab")) {
                        continue;
                    }
                    if (Class5.smethod_102(array2[1])) {
                        textBox5.AppendText("数据表:" + array2[1] + " 状态：正常" + Environment.NewLine);
                        continue;
                    }
                    string text5 = File.ReadAllText(text4 + "\\" + name, Encoding.Default);
                    text5 = text5.Replace("SRO_VT_SHARD", comboBox1.Text);
                    text5 = text5.Replace("SRO_VT_ACCOUNT", comboBox2.Text);
                    text5 = text5.Replace("SRO_VT_SHARDLOG", comboBox3.Text);
                    if (text5 != "") {
                        if (Class5.smethod_111(text5)) {
                            textBox5.AppendText("数据表:" + array2[1] + " 状态：创建成功" + Environment.NewLine);
                            continue;
                        }
                        textBox5.AppendText("数据表:" + array2[1] + " 状态：创建失败" + Environment.NewLine);
                        MessageBox.Show("无法创建数据表:" + array2[1], "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        button1.Enabled = true;
                        return;
                    }
                    textBox5.AppendText("数据表:" + array2[1] + " 状态：SQL代码错误,无法创建" + Environment.NewLine);
                    MessageBox.Show("无法创建数据表:" + array2[1], "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    button1.Enabled = true;
                    return;
                }
                string text6 = "";
                files = directoryInfo.GetFiles();
                for (int i = 0; i < files.Length; i++) {
                    string name2 = files[i].Name;
                    string[] array3 = name2.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries);
                    if (array3.Length == 3 && array3[2] == "sql" && array3[0] == "Exe" && Class5.smethod_103(array3[1])) {
                        string obj = Class5.smethod_17(array3[1]);
                        string text7 = File.ReadAllText(text4 + "\\" + name2, Encoding.Default);
                        text7 = text7.Replace("SRO_VT_SHARD", Class8.string_5);
                        text7 = text7.Replace("SRO_VT_ACCOUNT", Class8.string_6);
                        text7 = text7.Replace("SRO_VT_SHARDLOG", Class8.string_4);
                        if (obj.ToUpper() != text7.ToUpper()) {
                            text6 = text6 + array3[1] + Environment.NewLine;
                        }
                    }
                }
                if (text6 != "" && MessageBox.Show("检测到刺陵防御数据库内部分数据与Sql文件夹内文件数据不同步！" + Environment.NewLine + "检测到有改动的储存过程:" + Environment.NewLine + text6 + "如您的自定义储存过程或者表有重要内容，请先备份刺陵防御数据库." + Environment.NewLine + "继续进行升级覆盖操作吗？", "覆盖警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) {
                    textBox5.AppendText("用户中止操作" + Environment.NewLine);
                    button1.Enabled = true;
                    return;
                }
                if (File.Exists(text4 + "\\Exe._Update_Database.sql") && Class5.smethod_103("_Update_Database")) {
                    string obj2 = Class5.smethod_17("_Update_Database");
                    string text8 = File.ReadAllText(text4 + "\\Exe._Update_Database.sql", Encoding.Default);
                    text8 = text8.Replace("SRO_VT_SHARD", Class8.string_5);
                    text8 = text8.Replace("SRO_VT_ACCOUNT", Class8.string_6);
                    text8 = text8.Replace("SRO_VT_SHARDLOG", Class8.string_4);
                    if (obj2.ToUpper() != text8.ToUpper()) {
                        if (!Class5.smethod_111("Drop procedure _Update_Database")) {
                            textBox5.AppendText("储存过程:_Update_Database 状态：升级失败,无法删除" + Environment.NewLine);
                            MessageBox.Show("无法创建储存过程:_Update_Database", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            button1.Enabled = true;
                            return;
                        }
                        if (!Class5.smethod_111(text8)) {
                            textBox5.AppendText("储存过程:_Update_Database 状态：升级失败" + Environment.NewLine);
                            MessageBox.Show("无法创建储存过程:_Update_Database", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            button1.Enabled = true;
                            return;
                        }
                        textBox5.AppendText("储存过程:_Update_Database 状态：升级成功" + Environment.NewLine);
                        if (Class5.smethod_70(Class8.int_0) != 1) {
                            textBox5.AppendText("储存过程:_Update_Database 状态：升级未完成" + Environment.NewLine);
                            MessageBox.Show("无法执行储存过程:_Update_Database", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            button1.Enabled = true;
                            return;
                        }
                    }
                }
                files = directoryInfo.GetFiles();
                for (int i = 0; i < files.Length; i++) {
                    string name3 = files[i].Name;
                    string[] array4 = name3.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries);
                    if (array4.Length != 3 || !(array4[2] == "sql") || !(array4[0] == "Exe")) {
                        continue;
                    }
                    if (Class5.smethod_103(array4[1])) {
                        textBox5.AppendText("储存过程:" + array4[1] + " 状态：正常" + Environment.NewLine);
                        continue;
                    }
                    string text9 = File.ReadAllText(text4 + "\\" + name3, Encoding.Default);
                    text9 = text9.Replace("SRO_VT_SHARD", comboBox1.Text);
                    text9 = text9.Replace("SRO_VT_ACCOUNT", comboBox2.Text);
                    text9 = text9.Replace("SRO_VT_SHARDLOG", comboBox3.Text);
                    if (text9 != "") {
                        if (Class5.smethod_111(text9)) {
                            textBox5.AppendText("储存过程:" + array4[1] + " 状态：创建成功" + Environment.NewLine);
                            continue;
                        }
                        textBox5.AppendText("储存过程:" + array4[1] + " 状态：创建失败" + Environment.NewLine);
                        MessageBox.Show("无法创建储存过程:" + array4[1], "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        button1.Enabled = true;
                        return;
                    }
                    textBox5.AppendText("储存过程:" + array4[1] + " 状态：SQL代码错误,无法创建" + Environment.NewLine);
                    MessageBox.Show("无法创建储存过程:" + array4[1], "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    button1.Enabled = true;
                    return;
                }
            }
            catch {
                MessageBox.Show("无法检查数据库", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button1.Enabled = true;
                return;
            }
            textBox5.AppendText("数据库检查完成" + Environment.NewLine);
            Class8.string_2 = textBox1.Text;
            Class8.ushort_0 = ushort.Parse(textBox2.Text);
            Class8.ushort_1 = ushort.Parse(textBox3.Text);
            Class8.ushort_8 = ushort.Parse(textBox8.Text);
            Class8.string_5 = comboBox1.Text;
            Class8.string_6 = comboBox2.Text;
            Class8.string_4 = comboBox3.Text;
            Class8.smethod_0();
            string string_2 = ("DRIVER={SQL Server};SERVER=" + text + ";DSN=" + Class8.string_6 + ";UID=" + text2 + ";PWD=" + text3 + ";DATABASE=" + Class8.string_6) ?? "";
            string string_3 = ("DRIVER={SQL Server};SERVER=" + text + ";DSN=" + Class8.string_5 + ";UID=" + text2 + ";PWD=" + text3 + ";DATABASE=" + Class8.string_5) ?? "";
            string string_4 = ("DRIVER={SQL Server};SERVER=" + text + ";DSN=" + Class8.string_4 + ";UID=" + text2 + ";PWD=" + text3 + ";DATABASE=" + Class8.string_4) ?? "";
			if (!ushort.TryParse(textBox7.Text, out ushort result)) {
				result = 360;
			}
			if (!byte.TryParse(textBox9.Text, out byte result2)) {
                result2 = 22;
            }
            if (Class5.smethod_60(Class8.string_2, textBox6.Text, result, result2, string_2, string_3, string_4, Class8.ushort_0, Class8.ushort_8, Class8.ushort_1) != 1) {
                textBox5.AppendText("CertificationConfig 未保存" + Environment.NewLine);
            }
            else {
                textBox5.AppendText("CertificationConfig 已保存" + Environment.NewLine);
            }
            textBox5.AppendText("配置已保存" + Environment.NewLine);
            textBox5.AppendText("刺陵防御配置完成,5秒后进入系统." + Environment.NewLine);
            timer_0.Start();
        }
        else {
            MessageBox.Show("找不到 server.cfg 文件！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
    private void timer_0_Tick(object sender, EventArgs e)
    {
        if (int_0 == 0)
        {
            timer_0.Stop();
            Dispose();
        }
        else
        {
            int_0--;
            button1.Text = "完成(" + int_0 + ")";
        }
    }

    private void comboBox1_DropDown(object sender, EventArgs e)
    {
        if (SQLtextBox.Text == "")
        {
            MessageBox.Show("请设置数据库连接！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        comboBox1.Items.Clear();
        string text = "";
        string text2 = "";
        string text3 = "";
        string[] array = SQLtextBox.Text.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (array.Length != 3 && array.Length != 4)
        {
            MessageBox.Show("数据库连接字符串不正确", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (array.Length == 3)
        {
            text = array[0].Substring(7, array[0].Length - 7);
            text2 = array[1].Substring(4, array[1].Length - 4);
            text3 = array[2].Substring(4, array[2].Length - 4);
        }
        if (array.Length == 4)
        {
            text = array[0].Substring(7, array[0].Length - 7);
            text2 = array[2].Substring(4, array[2].Length - 4);
            text3 = array[3].Substring(4, array[3].Length - 4);
        }
        if (Class5.smethod_113("SERVER=" + text + ";UID=" + text2 + ";PWD=" + text3 + ";", out var string_))
        {
            if (string_.Length == 0)
            {
                return;
            }
            string[] array2 = string_.Split(new char[1] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (array2.Length != 0)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    comboBox1.Items.Add(array2[i]);
                }
            }
        }
        else
        {
            MessageBox.Show("无法打开数据库" + Environment.NewLine + "1.请检查数据账号密码以及数据库服务器地址是否正确！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }

    private void comboBox2_DropDown(object sender, EventArgs e)
    {
        if (SQLtextBox.Text == "")
        {
            MessageBox.Show("请设置数据库连接！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        comboBox2.Items.Clear();
        string text = "";
        string text2 = "";
        string text3 = "";
        string[] array = SQLtextBox.Text.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (array.Length != 3 && array.Length != 4)
        {
            MessageBox.Show("数据库连接字符串不正确", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        if (array.Length == 3)
        {
            text = array[0].Substring(7, array[0].Length - 7);
            text2 = array[1].Substring(4, array[1].Length - 4);
            text3 = array[2].Substring(4, array[2].Length - 4);
        }
        if (array.Length == 4)
        {
            text = array[0].Substring(7, array[0].Length - 7);
            text2 = array[2].Substring(4, array[2].Length - 4);
            text3 = array[3].Substring(4, array[3].Length - 4);
        }
        if (Class5.smethod_113("SERVER=" + text + ";UID=" + text2 + ";PWD=" + text3 + ";", out var string_))
        {
            if (string_.Length == 0)
            {
                return;
            }
            string[] array2 = string_.Split(new char[1] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (array2.Length != 0)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    comboBox2.Items.Add(array2[i]);
                }
            }
        }
        else
        {
            MessageBox.Show("无法打开数据库" + Environment.NewLine + "1.请检查数据账号密码以及数据库服务器地址是否正确！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
    private void button2_Click(object sender, EventArgs e) {
        Application.Exit();
    }

    private void button4_Click(object sender, EventArgs e) {
        if (openFileDialog_0.ShowDialog() == DialogResult.OK) {
            string fileName = openFileDialog_0.FileName;
            textBox4.Text = fileName;
        }
    }



    private void checkBox1_CheckedChanged(object sender, EventArgs e) {
        if (checkBox1.Checked) {
            label8.Visible = true;
            label9.Visible = true;
            label12.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox9.Visible = true;
            base.Height = 530;
        }
        else {
            label8.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox9.Visible = false;
            base.Height = 450;
        }
        Class8.bool_19 = checkBox1.Checked;
    }



    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuideForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SQLtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog_0 = new System.Windows.Forms.OpenFileDialog();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "192.168.0.100";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "服务端网关端口:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(308, 21);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "服务端代理端口:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(445, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 18);
            this.button3.TabIndex = 21;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SQLtextBox
            // 
            this.SQLtextBox.Location = new System.Drawing.Point(131, 116);
            this.SQLtextBox.Name = "SQLtextBox";
            this.SQLtextBox.ReadOnly = true;
            this.SQLtextBox.Size = new System.Drawing.Size(308, 21);
            this.SQLtextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "数据库连接:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(310, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(380, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 26);
            this.button2.TabIndex = 23;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(308, 21);
            this.textBox4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "服务端路径:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(445, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 18);
            this.button4.TabIndex = 26;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog_0
            // 
            this.openFileDialog_0.FileName = "server.cfg";
            this.openFileDialog_0.Filter = "文本文件(server.cfg)|server.cfg";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox5.Location = new System.Drawing.Point(131, 331);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(308, 130);
            this.textBox5.TabIndex = 27;
            this.textBox5.Text = "Hi,欢迎使用欢迎使用刺陵防御\r\n\r\n设置向导会帮助你快速安装并达到最佳化！\r\n\r\n稍候将自动帮您安装，部分操作需要您手动修改。\r\n\r\n您只需要认真设置以上信息，" +
    "然后点击确定即可。";
            // 
            // timer_0
            // 
            this.timer_0.Interval = 1000;
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "游戏主库:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 20);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "SRO_VT_SHARD";
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(131, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(308, 20);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.Text = "SRO_VT_ACCOUNT";
            this.comboBox2.DropDown += new System.EventHandler(this.comboBox2_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "游戏账号库:";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(131, 473);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 16);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "启动验证服务器";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(131, 249);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(308, 21);
            this.textBox6.TabIndex = 33;
            this.textBox6.Text = "谁与争锋[西南]";
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(131, 276);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(308, 21);
            this.textBox7.TabIndex = 34;
            this.textBox7.Text = "500";
            this.textBox7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 35;
            this.label8.Text = "服务器名称:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 36;
            this.label9.Text = "服务器最大在线:";
            this.label9.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(131, 223);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(308, 20);
            this.comboBox3.TabIndex = 38;
            this.comboBox3.Text = "SRO_VT_SHARDLOG";
            this.comboBox3.DropDown += new System.EventHandler(this.comboBox3_DropDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 37;
            this.label10.Text = "游戏日志库:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(131, 87);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(308, 21);
            this.textBox8.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 12);
            this.label11.TabIndex = 39;
            this.label11.Text = "服务端下载端口:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 42;
            this.label12.Text = "服务器区域编号:";
            this.label12.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(131, 303);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(308, 21);
            this.textBox9.TabIndex = 41;
            this.textBox9.Text = "22";
            this.textBox9.Visible = false;
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 505);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SQLtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "刺陵防御连接配置";
            this.Load += new System.EventHandler(this.GuideForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
