using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal static class Class52 {
    [STAThread]
	

	private static void Main() {
		
	   
		Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(defaultValue: false);
        Class9.smethod_46(Application.StartupPath);
        if (!File.Exists("CenterManager.Data")) {
            MessageBox.Show("CenterManager.Data 不存在！");
            return;
        }
		
        if (!File.Exists("QiangweidiewuApi.dll")) {
            MessageBox.Show("QiangweidiewuApi.dll 不存在！");
            return;
        }
        if (!File.Exists("QiangweidiewuYstem.dll")) {
            MessageBox.Show("QiangweidiewuYstem.dll 不存在！");
            return;
        }


      /*  if (!File.Exists(Marshal.PtrToStringAnsi(Class15.Get_Center_Net_Kernel_Sys_Name()))) {
            MessageBox.Show("QiangweidiewuYstem.dll 文件不存在！");
            return;
	  */


			if (!File.Exists(Marshal.PtrToStringAnsi(Class15.Get_CenterNetKernelSysName()))) {
				MessageBox.Show("QiangweidiewuYstem.dll 文件不存在！");
				return;
			}
  
        if (File.Exists("Updater.exe.NEW")) {
            File.Move("Updater.exe", "Updater.exe.DEL");
            File.Move("Updater.exe.NEW", "Updater.exe");
        }
        Class8.class32_0 = new Class32("CenterManager.ini");
        if (!File.Exists("CenterManager.ini")) {
            File.Copy("CenterManager.Data", "CenterManager.ini");
        }
        bool num = Class8.class32_0.method_4();
        Class8.smethod_4();
        if (!num) {
            File.Copy("CenterManager.Data", "CenterManager.ini", overwrite: true);
            Class8.smethod_2();
        }
        if (Class8.string_2 == "192.168.1.70") {
            new GuideForm().ShowDialog();
        }
        if (!(Class8.string_2 == "192.168.1.70")) {
            Class15.smethod_0();
            Application.Run(new LoginForm());
        }
    }

}
