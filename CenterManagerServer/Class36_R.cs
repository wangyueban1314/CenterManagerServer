using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

internal class Class36_R {
	[CompilerGenerated]
	private ushort ushort_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private ushort ushort_1;

	private object object_0 = new object();

	protected Class46 class46_0 = new Class46();

	protected Class48 class48_0 = new Class48();

	public List<Class37> list_0 = new List<Class37>();

	private int int_0;

	[CompilerGenerated]
	public ushort method_0() {
		return ushort_0;
	}

	[CompilerGenerated]
	public void method_1(ushort ushort_2) {
		ushort_0 = ushort_2;
	}

	[CompilerGenerated]
	public string method_2() {
		return string_0;
	}

	[CompilerGenerated]
	public void method_3(string string_1) {
		string_0 = string_1;
	}

	[CompilerGenerated]
	public ushort method_4() {
		return ushort_1;
	}

	[CompilerGenerated]
	public void method_5(ushort ushort_2) {
		ushort_1 = ushort_2;
	}

	public Class36_R() {
		class46_0.method_14(vmethod_6);
		class46_0.method_10(vmethod_8);
		class46_0.method_12(vmethod_9);
		class46_0.method_16(vmethod_10);
		class46_0.method_20(vmethod_11);
		class46_0.method_22(vmethod_7);
		class46_0.method_64(Class15.Center_Get_Socket_Length());
		class48_0.method_10(vmethod_0);
		class48_0.method_6(vmethod_1);
		class48_0.method_8(vmethod_3);
		class48_0.method_12(vmethod_4);
		class48_0.method_16(vmethod_5);
		class48_0.method_18(vmethod_2);
		class48_0.method_66(Class15.Center_Get_Socket_Length());
	}
	protected virtual Enum2 vmethod_7(Class46 class46_1)
	{
		return Enum2.const_0;
	}

	protected virtual Enum2 vmethod_8(Class46 class46_1, IntPtr intptr_0, IntPtr intptr_1)
	{
		try
		{
			if (int_0 == 0)
			{
				int_0 = Class9.smethod_0();
			}
			else
			{
				int num = Class9.smethod_0();
				if (num - int_0 < 2000)
				{
					Thread.Sleep(2000);
					int_0 = num;
				}
				else
				{
					int_0 = num;
				}
			}
			string string_ = string.Empty;
			ushort num2 = 0;
			if (!class46_0.method_47(intptr_0, ref string_, ref num2))
			{
				return Enum2.const_2;
			}
			if (string_ != Class8.string_2)
			{
				return Enum2.const_2;
			}
			if (!Class0.smethod_1(num2, out int num3, out string text))
			{
				return Enum2.const_2;
			}
			var intptr_2 = IntPtr.Zero;
			if (!class48_0.method_25(method_2(), method_4(), ref intptr_2) && !class48_0.method_25(method_2(), method_4(), ref intptr_2) && !class48_0.method_25(method_2(), method_4(), ref intptr_2))
			{
				return Enum2.const_2;
			}
			var @class = new Class37();
			@class.intptr_0 = intptr_0;
			@class.intptr_1 = intptr_2;
			@class.uint_0 = 0u;
			@class.byte_1 = null;
			@class.byte_0 = null;
			@class.int_0 = num3;
			@class.string_0 = text;
			if (!method_12(intptr_0, @class))
			{
				return Enum2.const_2;
			}
		}
		catch
		{
		}
		return Enum2.const_0;
	}

	protected virtual Enum2 vmethod_9(Class46 class46_1, IntPtr intptr_0, byte[] byte_0)
	{
		return Enum2.const_0;
	}
	public bool method_6() {
		string text = "0.0.0.0";
		if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(method_2()) && method_0() != 0 && method_4() != 0) {
			class46_0.method_7(text);
			class46_0.method_9(method_0());
			bool result;
			if (!(result = class46_0.method_27())) {
				return result;
			}
			return result = class48_0.method_23(text);
		}
		throw new Exception("请先设置属性[BindAddr,TargetAddr,BindPort,TargetPort]");
	}

	public bool method_7() {
		if (class46_0.method_28()) {
			return class48_0.method_24();
		}
		return false;
	}

	public bool method_8(IntPtr intptr_0, bool bool_0 = true) {
		return class46_0.method_40(intptr_0, bool_0);
	}




	protected virtual Enum2 vmethod_10(Class46 class46_1, IntPtr intptr_0, byte[] byte_0) {
		try {
			var class37_ = new Class37();
			if (!method_15(intptr_0, ref class37_, bool_0: true)) {
				return Enum2.const_2;
			}
			byte[] byte_ = new byte[0];
			switch (method_10(intptr_0, byte_0, out byte_)) {
				case 0:
					if (!class48_0.method_29(class37_.intptr_1, byte_0, byte_0.Length)) {
						return Enum2.const_2;
					}
					break;
				case 2:
					if (!class48_0.method_29(class37_.intptr_1, byte_, byte_.Length)) {
						return Enum2.const_2;
					}
					break;
			}
		}
		catch {
		}
		return Enum2.const_0;
	}

	protected virtual Enum2 vmethod_11(Class46 class46_1, IntPtr intptr_0, Enum3 enum3_0, int int_1) {
		try {
			lock (object_0) {
				var class37_ = new Class37();
				if (!method_18(intptr_0, ref class37_, bool_0: true)) {
					return Enum2.const_2;
				}
				if (class37_.uint_0 == 0) {
					class37_.uint_0 = 2u;
					if (!method_17(intptr_0, class37_, bool_0: true)) {
						return Enum2.const_2;
					}
					class48_0.method_39(class37_.intptr_1);
				}
				else if (class37_.uint_0 == 1) {
					method_16(intptr_0, bool_0: true);
				}
			}
		}
		catch {
		}
		return Enum2.const_0;
	}

	public int method_9(IntPtr intptr_0, Class37 class37_0, byte[] byte_0, out byte[] byte_1) {
		byte_1 = byte_0;
		if ((ushort)BitConverter.ToInt16(byte_0, 2) == 20480) {
			if (class37_0.string_0.IndexOf("GatewayServe") > -1) {
				string text = Class1.smethod_3(class37_0.int_0);
				if (text == "") {
					MessageBox.Show("启动 GatewayServer 失败！");
					Class6.smethod_8();
					return 1;
				}
				text += "server.cfg";
				if (!File.Exists(text)) {
					MessageBox.Show("启动 GatewayServer 失败,找不到server.cfg文件！");
					Class6.smethod_8();
					return 1;
				}
				if (Class9.smethod_8(text, "GatewayServer") != Class8.ushort_6) {
					MessageBox.Show("server.cfg 文件内的GatewayServer5 -> Certification 项未将端口设置为 35880，请手动设置该选项后再进行启动！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Class6.smethod_8();
					return 1;
				}
				if (Class8.bool_57 && Class9.smethod_8(text, "DownloadServer") != Class8.ushort_6) {
					MessageBox.Show("server.cfg 文件内的DownloadServer -> Certification 项未将端口设置为 35880，请手动设置该选项后再进行启动！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Class6.smethod_8();
					return 1;
				}
				if (Class9.smethod_8(text, "AgentServer") != Class8.ushort_7) {
					MessageBox.Show("server.cfg 文件内的AgentServer -> Certification 项未将端口设置为 35882，请手动设置该选项后再进行启动！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Class6.smethod_8();
					return 1;
				}
				int int_ = 0;
				if (Class8.int_28 == 0) {
					int_ = ((!Class8.bool_64) ? Class15.Get_GatewayIp() : (4));
				}
				else if (Class8.int_28 == 1) {
					int_ = (4);

				}
				else if (Class8.int_28 == 2) {
					int_ = Class15.Get_GatewayIp();
				}
				else if (Class8.int_28 == 3) {
					int_ = (5);
				}
				else if (Class8.int_28 == 5) {
					int_ = (6);
				}
				int num = 0;
				int num2 = 0;
				byte[] array = new byte[6];
				num = class37_0.int_0;
				if (num < 1) {
					MessageBox.Show("读取GatewayServer信息失败 001！");
					Class6.smethod_8();
					return 1;
				}
				num2 = Class1.OpenProcess(2035711, bool_0: false, num);
				if (num2 < 1) {
					MessageBox.Show("读取GatewayServer信息失败 002！");
					Class6.smethod_8();
					return 1;
				}
				if (!Class1.ReadProcessMemory(num2, 0X49F002, array, 6, out int int_2)) {
					Class1.CloseHandle(num2);
					MessageBox.Show("读取GatewayServer信息失败 003！");
					Class6.smethod_8();
					return 1;
				}


				if (Class1.smethod_10(array, new byte[6] { 129, 225, 255, 255, 255, 127 }) < 0 && Class1.smethod_10(array, new byte[6] { 185, 255, 255, 255, 127, 144 }) < 0) {
					Class1.CloseHandle(num2);
					MessageBox.Show("读取GatewayServer信息失败 004！");
					Class6.smethod_8();
					return 1;
				}
				if (Class1.WriteProcessMemory(num2, 0X49F002, new byte[6] { 185, 255, 255, 255, 127, 144 }, 6, 0) == 0) {
					Class1.CloseHandle(num2);
					MessageBox.Show("读取GatewayServer信息失败 005！");
					Class6.smethod_8();
					return 1;
				}


				if (!Class1.CloseHandle(num2)) {
					MessageBox.Show("读取GatewayServer信息失败 006！");
					Class6.smethod_8();
					return 1;
				}
				if (array.Length != 0 && array[0] != 185) {
					Class6.smethod_0(2, "System GatewayServer 连接完成", 0);
				}
			}
			else if (class37_0.string_0.IndexOf("DownloadServe") > -1 && Class8.bool_57) {
				string text2 = Class1.smethod_3(class37_0.int_0);
				if (text2 == "") {
					MessageBox.Show("启动 DownloadServer 失败！");
					Class6.smethod_8();
					return 1;
				}
				text2 += "server.cfg";
				if (!File.Exists(text2)) {
					MessageBox.Show("启动 DownloadServer 失败,找不到server.cfg文件！");
					Class6.smethod_8();
					return 1;
				}
				if (Class9.smethod_8(text2, "GatewayServer") != Class8.ushort_6) {
					MessageBox.Show("server.cfg 文件内的GatewayServer6 -> Certification 项未将端口设置为 35880，请手动设置该选项后再进行启动！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Class6.smethod_8();
					return 1;
				}
				if (Class8.bool_57 && Class9.smethod_8(text2, "DownloadServer") != Class8.ushort_6) {
					MessageBox.Show("server.cfg 文件内的DownloadServer -> Certification 项未将端口设置为 35880，请手动设置该选项后再进行启动！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Class6.smethod_8();
					return 1;
				}
				if (Class9.smethod_8(text2, "AgentServer") != Class8.ushort_7) {
					MessageBox.Show("server.cfg 文件内的AgentServer -> Certification 项未将端口设置为 35882，请手动设置该选项后再进行启动！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Class6.smethod_8();
					return 1;
				}
				int int_3 = 0;
				if (Class8.int_28 == 0) {
					int_3 = ((!Class8.bool_64) ? (8) : (7));
				}
				else if (Class8.int_28 == 1) {
					int_3 = (7);
				}
				else if (Class8.int_28 == 2) {
					int_3 = (8);
				}
				else if (Class8.int_28 == 3) {
					int_3 = (9);
				}
				else if (Class8.int_28 == 5) {
					int_3 = (10);
				}
				int num3 = 0;
				int num4 = 0;
				byte[] array2 = new byte[6];
				num3 = class37_0.int_0;
				if (num3 < 1) {
					MessageBox.Show("读取DownloadServer信息失败 001！");
					Class6.smethod_8();
					return 1;
				}
				num4 = Class1.OpenProcess(2035711, bool_0: false, num3);
				if (num4 < 1) {
					MessageBox.Show("读取DownloadServer信息失败 002！");
					Class6.smethod_8();
					return 1;
				}
				if (!Class1.ReadProcessMemory(num4, 0X4835D2, array2, 6, out int int_4)) {
					Class1.CloseHandle(num4);
					MessageBox.Show("读取DownloadServer信息失败 003！");
					Class6.smethod_8();
					return 1;
				}
				if (Class1.smethod_10(array2, new byte[6] { 129, 225, 255, 255, 255, 127 }) < 0 && Class1.smethod_10(array2, new byte[6] { 185, 255, 255, 255, 127, 144 }) < 0) {
					Class1.CloseHandle(num4);
					MessageBox.Show("读取DownloadServer信息失败 004！");
					Class6.smethod_8();
					return 1;
				}
				if (Class1.WriteProcessMemory(num4, 0X4835D2, new byte[6] { 185, 255, 255, 255, 127, 144 }, 6, 0) == 0) {
					Class1.CloseHandle(num4);
					MessageBox.Show("读取DownloadServer信息失败 005！");
					Class6.smethod_8();
					return 1;
				}
				if (!Class1.CloseHandle(num4)) {
					MessageBox.Show("读取DownloadServer信息失败 006！");
					Class6.smethod_8();
					return 1;
				}
				if (array2.Length != 0 && array2[0] != 185) {
					Class6.smethod_0(2, "System DownloadServer 连接完成", 0);
				}
			}
		}
		int num5 = 0;
		int num6 = -1;
		if (Class8.bool_53) {
			num6 = Class1.smethod_10(byte_1, BitConverter.GetBytes(Class8.ushort_2));
			if (num6 > -1) {
				Array.Copy(BitConverter.GetBytes(Class8.ushort_6), 0, byte_1, num6, 2);
				num5++;
			}
		}
		if (Class8.bool_57 && class37_0.string_0.IndexOf("DownloadServe") > -1) {
			num6 = Class1.smethod_10(byte_1, BitConverter.GetBytes(Class8.ushort_8));
			if (num6 > -1) {
				Array.Copy(BitConverter.GetBytes(Class8.ushort_9), 0, byte_1, num6, 2);
				num5++;
			}
		}
		if (class37_0.string_0.IndexOf("GatewayServe") > -1) {
			num6 = Class1.smethod_10(byte_1, BitConverter.GetBytes(Class8.ushort_0));
			if (num6 > -1) {
				Array.Copy(BitConverter.GetBytes(Class8.ushort_4), 0, byte_1, num6, 2);
				num5++;
				Thread.Sleep(2000);
			}
		}
		if (num5 > 0) {
			return 2;
		}
		return 0;
	}

	public int method_10(IntPtr intptr_0, byte[] byte_0, out byte[] byte_1) {
		byte_1 = byte_0;
		if ((ushort)BitConverter.ToInt16(byte_0, 2) == 24584 && Class8.bool_53 && byte_0.Length > 18 && (ushort)BitConverter.ToInt16(byte_0, 12) == 25091) {
			ushort num = (ushort)BitConverter.ToInt16(byte_0, 10);
			if (num == Class8.ushort_12) {
				Array.Copy(Class9.smethod_10(Class8.string_2), 0, byte_1, 14, 4);
				return 2;
			}
			if (num == Class8.ushort_13) {
				Array.Copy(Class9.smethod_10(Class8.string_58), 0, byte_1, 14, 4);
				return 2;
			}
		}
		return 0;
	}

	public bool method_11(IntPtr intptr_0, Class37 class37_0, byte[] byte_0) {
		try {
			class37_0.byte_1 = byte_0;
			if (method_14(intptr_0, class37_0, bool_0: true)) {
				return true;
			}
			return false;
		}
		catch {
			return false;
		}
	}
	protected virtual Enum2 vmethod_6(Class46 class46_1, IntPtr intptr_0)
	{
		return Enum2.const_0;
	}

	private bool method_14(IntPtr intptr_0, Class37 class37_0, bool bool_0)
	{
		try
		{
			lock (object_0)
			{
				if (list_0.Count > 0)
				{
					int num = 0;
					while (true)
					{
						if (num < list_0.Count)
						{
							var @class = list_0[num];
							var zero = IntPtr.Zero;
							zero = ((!bool_0) ? @class.intptr_1 : @class.intptr_0);
							if (zero == intptr_0)
							{
								break;
							}
							num++;
							continue;
						}
						return false;
					}
					list_0[num] = class37_0;
					return true;
				}
				return false;
			}
		}
		catch
		{
			return false;
		}
	}

	private bool method_15(IntPtr intptr_0, ref Class37 class37_0, bool bool_0)
	{
		try
		{
			lock (object_0)
			{
				class37_0 = new Class37();
				if (list_0.Count > 0)
				{
					int num = 0;
					while (true)
					{
						if (num < list_0.Count)
						{
							var @class = list_0[num];
							var zero = IntPtr.Zero;
							zero = ((!bool_0) ? @class.intptr_1 : @class.intptr_0);
							if (zero == intptr_0)
							{
								break;
							}
							num++;
							continue;
						}
						return false;
					}
					class37_0 = list_0[num];
					return true;
				}
				return false;
			}
		}
		catch
		{
			return false;
		}
	}

	private bool method_16(IntPtr intptr_0, bool bool_0)
	{
		try
		{
			if (list_0.Count > 0)
			{
				int num = 0;
				while (true)
				{
					if (num < list_0.Count)
					{
						var @class = list_0[num];
						var zero = IntPtr.Zero;
						zero = ((!bool_0) ? @class.intptr_1 : @class.intptr_0);
						if (zero == intptr_0)
						{
							break;
						}
						num++;
						continue;
					}
					return false;
				}
				list_0.RemoveAt(num);
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	private bool method_17(IntPtr intptr_0, Class37 class37_0, bool bool_0)
	{
		try
		{
			if (list_0.Count > 0)
			{
				int num = 0;
				while (true)
				{
					if (num < list_0.Count)
					{
						var @class = list_0[num];
						var zero = IntPtr.Zero;
						zero = ((!bool_0) ? @class.intptr_1 : @class.intptr_0);
						if (zero == intptr_0)
						{
							break;
						}
						num++;
						continue;
					}
					return false;
				}
				list_0[num] = class37_0;
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}
	private bool method_12(IntPtr intptr_0, Class37 class37_0) {
		try {
			lock (object_0) {
				list_0.Add(class37_0);
				return true;
			}
		}
		catch {
			return false;
		}
	}

	private bool method_13(IntPtr intptr_0, bool bool_0) {
		try {
			lock (object_0) {
				if (list_0.Count > 0) {
					int num = 0;
					while (true) {
						if (num < list_0.Count) {
							var @class = list_0[num];
							var zero = IntPtr.Zero;
							zero = ((!bool_0) ? @class.intptr_1 : @class.intptr_0);
							if (zero == intptr_0) {
								break;
							}
							num++;
							continue;
						}
						return false;
					}
					list_0.RemoveAt(num);
					return true;
				}
				return false;
			}
		}
		catch {
			return false;
		}
	}
	protected virtual Enum2 vmethod_0(IntPtr intptr_0, IntPtr intptr_1)
	{
		return Enum2.const_0;
	}

	protected virtual Enum2 vmethod_1(IntPtr intptr_0)
	{
		return Enum2.const_0;
	}

	protected virtual Enum2 vmethod_2()
	{
		return Enum2.const_0;
	}

	protected virtual Enum2 vmethod_3(IntPtr intptr_0, byte[] byte_0)
	{
		return Enum2.const_0;
	}

	protected virtual Enum2 vmethod_4(IntPtr intptr_0, byte[] byte_0)
	{
		try
		{
			var class37_ = new Class37();
			if (!method_15(intptr_0, ref class37_, bool_0: false))
			{
				return Enum2.const_2;
			}
			byte[] byte_ = new byte[0];
			switch (method_9(intptr_0, class37_, byte_0, out byte_))
			{
				case 0:
					if (!class46_0.method_30(class37_.intptr_0, byte_0, byte_0.Length))
					{
						return Enum2.const_2;
					}
					break;
				case 2:
					if (!class46_0.method_30(class37_.intptr_0, byte_, byte_.Length))
					{
						return Enum2.const_2;
					}
					break;
			}
		}
		catch
		{
		}
		return Enum2.const_0;
	}

	protected virtual Enum2 vmethod_5(IntPtr intptr_0, Enum3 enum3_0, int int_1)
	{
		try
		{
			lock (object_0)
			{
				var class37_ = new Class37();
				if (!method_18(intptr_0, ref class37_, bool_0: false))
				{
					return Enum2.const_2;
				}
				if (class37_.uint_0 == 0)
				{
					class37_.uint_0 = 1u;
					if (!method_17(intptr_0, class37_, bool_0: false))
					{
						return Enum2.const_2;
					}
					class46_0.method_40(class37_.intptr_0);
				}
				else if (class37_.uint_0 == 2)
				{
					method_16(intptr_0, bool_0: false);
				}
			}
		}
		catch
		{
		}
		return Enum2.const_0;
	}



	private bool method_18(IntPtr intptr_0, ref Class37 class37_0, bool bool_0) {
		try {
			class37_0 = new Class37();
			if (list_0.Count > 0) {
				int num = 0;
				while (true) {
					if (num < list_0.Count) {
						var @class = list_0[num];
						var zero = IntPtr.Zero;
						zero = ((!bool_0) ? @class.intptr_1 : @class.intptr_0);
						if (zero == intptr_0) {
							break;
						}
						num++;
						continue;
					}
					return false;
				}
				class37_0 = list_0[num];
				return true;
			}
			return false;
		}
		catch {
			return false;
		}
	}
}
