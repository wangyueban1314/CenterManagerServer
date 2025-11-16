using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Timers;

internal class Class3 {
    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private ushort ushort_1;

    private Random random_0 = new Random();

    private Random random_1 = new Random();

    private object object_0 = new object();

    private object object_1 = new object();

    private object object_2 = new object();

    private object object_3 = new object();



    public long long_0;

    public long long_1;

    public long long_2;

    public long long_3;

    public string string_0 = "";

    private Timer timer_1 = new Timer();

    private Timer timer_2 = new Timer();

    private List<IntPtr> list_3 = new List<IntPtr>();

    public List<Struct4> list_1 = new List<Struct4>();

    private List<Class4> list_4 = new List<Class4>();
    private object object_4 = new object();

    private object object_5 = new object();

    private object object_6 = new object();

    private object object_7 = new object();

    private object object_8 = new object();

    private object object_9 = new object();

    private object object_10 = new object();

    private int int_0;

    private int int_1;

    private string string_2;

    private List<Struct2> list_2 = new List<Struct2>();

    public List<Struct3> list_0 = new List<Struct3>();

    private Timer timer_0 = new Timer();

    private int int_2;

    private int int_3;

    private int int_4;

    private bool bool_1;

    public bool bool_0 = true;
    private List<Class4> list_5 = new List<Class4>();

    private int int_5 = Class9.smethod_0();

    protected Class46 class46_0 = new Class46();

    protected Class48 class48_0 = new Class48();

    public void method_0(ref Class4 class4_0, string string_3) {
        long num = 0L;
        int num2 = 0;
		int num4 = 0;
		int num5 = 0;
        var list = Class5.smethod_3(string_3, out int num3);
        if (list.Count <= 0) {
            return;
        }
        int num6 = Class5.smethod_9(string_3);
        for (int i = 0; i < list.Count; i++) {
            if (list[i].byte_0 == 0) {
                if (num6 < 1) {
                    num4 = ((num5 == 0) ? 1 : 2);
                }
                else {
                    long num7 = list[i].long_1;
                    if (Class5.smethod_16(list[i].string_0)) {
                        num7 = 0L;
                    }
                    int num8 = Class5.smethod_15(string_3, list[i].string_0, (ushort)num7, list[i].byte_1);
                    if (num8 == 1) {
                        if (!Class5.smethod_7(list[i].long_0, 1)) {
                            Class6.smethod_0(2, "SQL Error: SQL_Update_CharItemSendList_Status False", 0);
                            Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Update_CharItemSendList_Status Code:False Param:" + list[i].long_0);
                        }
                    }
                    else {
                        Class6.smethod_0(2, "SQL Error: SQL_Add_Char_Item False", 0);
                        Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Add_Char_Item Code:" + num8 + " Param:" + list[i].long_0);
                    }
                    num6--;
                    num5++;
                }
            }
            if (list[i].byte_0 == 1) {
                if (Class5.smethod_8(string_3, list[i].long_1)) {
                    num += list[i].long_1;
                    if (!Class5.smethod_7(list[i].long_0, 1)) {
                        Class6.smethod_0(2, "SQL Error: SQL_Update_CharItemSendList_Status False", 0);
                        Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Update_CharItemSendList_Status Code:False Param:" + list[i].long_0);
                    }
                }
                else {
                    Class6.smethod_0(2, "SQL Error: SQL_Update_Char_Gold False", 0);
                    Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Update_Char_Gold Code:False Param:" + list[i].long_0);
                }
            }
            if (list[i].byte_0 != 2) {
                continue;
            }
            int num9 = Class5.smethod_54(string_3, (int)list[i].long_1);
            if (num9 >= 1) {
                num2 += (int)list[i].long_1;
                if (!Class5.smethod_7(list[i].long_0, 1)) {
                    Class6.smethod_0(2, "SQL Error: SQL_Update_CharItemSendList_Status False", 0);
                    Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Update_CharItemSendList_Status Code:False Param:" + list[i].long_0);
                }
            }
            else {
                Class6.smethod_0(2, "SQL Error: SQL_Update_Char_Silk False", 0);
                Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Update_Char_Silk Code:" + num9 + " Param:" + list[i].long_0);
            }
        }
        if (num3 > 0) {
            switch (num4) {
                case 1:
                    class4_0.list_0.Add(new Struct6(0, Class8.string_50 + num3));
                    break;
                case 2:
                    class4_0.list_0.Add(new Struct6(0, Class8.string_51[0] + num5 + Class8.string_51[1] + (num3 - num5) + Class8.string_51[2]));
                    break;
                default:
                    if (num5 == num3) {
                        class4_0.list_0.Add(new Struct6(0, Class8.string_52 + num5));
                    }
                    break;
            }
        }
        if (num > 0L) {
            class4_0.list_0.Add(new Struct6(0, Class8.string_53 + num));
        }
        if (num2 > 0) {
            class4_0.list_0.Add(new Struct6(0, Class8.string_54 + num2));
        }
    }
    public bool method_8(int int_6)
    {
        try
        {
            lock (object_6)
            {
                if (list_4 != null && list_4.Count > 0)
                {
                    for (int i = 0; i < list_4.Count; i++)
                    {
                        var @class = list_4[i];
                        if (@class.byte_4 == 2)
                        {
                            @class.int_12 = int_6;
                            list_4[i] = @class;
                        }
                    }
                }
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool method_9(int int_6, int int_7, bool bool_2 = false, int int_8 = 10, int int_9 = 300)
    {
        try
        {
            var list = new List<Struct29>(Class12.class3_0.method_45());
            if (list.Count > 0)
            {
                if (list.Count < int_6)
                {
                    int_6 = list.Count;
                }
                string text = ",";
                for (int i = 0; i < int_6; i++)
                {
                    string text2 = ",";
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (text.IndexOf("," + j + ",") == -1)
                        {
                            text2 = text2 + j + ",";
                        }
                    }
                    string[] array = text2.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    if (array != null)
                    {
                        int num = new Random().Next(0, array.Length - 1);
                        text = text + array[num].ToString() + ",";
                    }
                }
                string[] array2 = text.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
                if (array2 != null)
                {
                    for (int k = 0; k < array2.Length; k++)
                    {
                        int index = int.Parse(array2[k]);
                        var @struct = list[index];
                        if (@struct.byte_0 != 2)
                        {
                            continue;
                        }
                        if (bool_2)
                        {
                            int_7 = new Random().Next(int_8, int_9);
                        }
                        if (Class8.bool_44)
                        {
                            int num2 = Class9.smethod_19(@struct.intptr_0, @struct.string_1, int_7, 17, bool_0: true);
                            if (num2 == 1)
                            {
                                method_21(Class8.string_46[0] + @struct.string_1 + Class8.string_46[1] + int_7 + Class8.string_46[2]);
                            }
                            else
                            {
                                Class6.smethod_0(2, "SQL Error: Send_Clinet_Char_Silk False", 0);
                                Class7.smethod_2("0.0.0.0:0", "SQL Error: Send_Clinet_Char_Silk Code:" + num2 + " Param:" + @struct.string_1 + " " + int_7);
                            }
                        }
                        if (Class8.bool_42)
                        {
                            if (Class8.bool_45)
                            {
                                if (Class5.list_11.Count > 0)
                                {
                                    for (int l = 0; l < Class8.int_22; l++)
                                    {
                                        int index2 = new Random().Next(0, Class5.list_11.Count);
                                        if (Class5.list_11[index2].byte_0 == 0 && !Class9.smethod_1(@struct.string_1, 0, Class5.list_11[index2].string_0, Class5.list_11[index2].string_1, Class5.list_11[index2].long_0, Class5.list_11[index2].byte_1))
                                        {
                                            Class6.smethod_0(2, "SQL Error: Send_Char_Item False", 0);
                                            Class7.smethod_2("0.0.0.0:0", "SQL Error: Send_Char_Item Code:" + Class5.list_11[index2].int_0 + " Param:" + @struct.string_1 + " " + int_7);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                for (int m = 0; m < Class5.list_11.Count; m++)
                                {
                                    if (Class5.list_11[m].byte_0 == 0 && !Class9.smethod_1(@struct.string_1, 0, Class5.list_11[m].string_0, Class5.list_11[m].string_1, Class5.list_11[m].long_0, Class5.list_11[m].byte_1))
                                    {
                                        Class6.smethod_0(2, "SQL Error: Send_Char_Item False", 0);
                                        Class7.smethod_2("0.0.0.0:0", "SQL Error: Send_Char_Item Code:" + Class5.list_11[m].int_0 + " Param:" + @struct.string_1 + " " + int_7);
                                    }
                                }
                            }
                        }
                        if (Class8.bool_43 && !Class9.smethod_1(@struct.string_1, 1, "GOLD", "金币", Class8.long_0, 0))
                        {
                            Class6.smethod_0(2, "SQL Error: Send_Char_Item False", 0);
                            Class7.smethod_2("0.0.0.0:0", "SQL Error: Send_Char_Item Code:False Param:" + @struct.string_1 + " " + int_7);
                        }
                    }
                }
                return true;
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool method_10(int int_6, int int_7, string string_3 = "")
    {
        try
        {
            Class10.smethod_3(18, new Struct31(int_6, int_7, string_3));
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool method_11()
    {
        try
        {
            Class10.smethod_3(19, null);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public int method_12(int int_6, int int_7, string string_3 = "")
    {
        try
        {
            if (Class13.bool_0)
            {
                return -1;
            }
            if (method_8(1))
            {
                Class13.int_4 = int_6;
                Class13.int_0 = Class9.smethod_0();
                Class13.string_0 = string_3;
                Class13.int_1 = int_7;
                Class13.int_2 = Class8.int_15;
                Class13.int_3 = Class8.int_16;
                Class13.bool_0 = true;
                return 1;
            }
            return -2;
        }
        catch
        {
            return -3;
        }
    }

    public int method_13()
    {
        try
        {
            if (!Class13.bool_0)
            {
                return -1;
            }
            if (method_8(0))
            {
                if (Class13.int_4 == 0)
                {
                    if (Class13.int_1 > 0)
                    {
                        int num = method_24(Class13.string_0, Class13.int_1, 10, bool_2: true);
                        if (num != 1)
                        {
                            Class6.smethod_0(2, "SQL Error: Return_Char_Silk False", 0);
                            Class7.smethod_2("0.0.0.0:0", "SQL Error: Return_Char_Silk Code:" + num + " Param:" + Class13.string_0);
                        }
                        else
                        {
                            method_21(Class8.string_34[0] + Class13.int_1 + Class8.string_34[1] + Class13.string_0);
                        }
                    }
                }
                else if (Class13.int_4 == 1)
                {
                    method_21(Class8.string_32 + Class13.int_1);
                }
                Class13.int_0 = 0;
                Class13.int_1 = 0;
                Class13.string_0 = "";
                Class13.bool_0 = false;
                Class6.smethod_0(4, "", 0);
                return 1;
            }
            return -2;
        }
        catch
        {
            return -3;
        }
    }

    private void method_62(Class4 class4_0, int int_6)
    {
        if (!Class8.bool_9 || class4_0.byte_4 != 2)
        {
            return;
        }
        try
        {
            if (class4_0.int_3 != 0)
            {
                class4_0.int_4 = Class9.smethod_0();
                int num = (class4_0.int_4 - class4_0.int_3) / 60000;
                if (num > 0)
                {
                    var @struct = default(Struct21);
                    @struct.intptr_0 = class4_0.intptr_0;
                    @struct.string_1 = class4_0.string_0;
                    @struct.string_0 = class4_0.string_1;
                    @struct.string_4 = class4_0.string_2;
                    @struct.string_2 = class4_0.string_3;
                    @struct.string_3 = class4_0.string_4;
                    @struct.int_0 = num;
                    @struct.int_1 = int_6;
                    Class10.smethod_3(8, @struct);
                }
            }
        }
        catch
        {
            Class7.smethod_2(class4_0.string_1, "System SellReward_Close_Send Error: 0008");
        }
    }

    public bool method_14(short short_0, byte[] byte_0, out byte byte_1, out byte byte_2, out byte byte_3, out byte byte_4, out byte byte_5)
    {
        byte_1 = 0;
        byte_2 = 0;
        byte_3 = 0;
        byte_4 = 0;
        byte_5 = 0;
        try
        {
            if (Class8.bool_64)
            {
                short num = short_0;
                byte_5 = byte_0[10];
                byte_4 = byte_0[9];
                byte_3 = (byte)(num / 1024);
                byte_2 = (byte)((num - byte_3 * 1024) / 16);
                byte_1 = (byte)(num - byte_3 * 1024 - byte_2 * 16);
                return true;
            }
            short num2 = short_0;
            if (byte_0.Length >= 11)
            {
                if (byte_0[9] == 3 && byte_0[10] == 5)
                {
                    byte_5 = byte_0[10];
                    byte_4 = byte_0[9];
                    byte_3 = (byte)(num2 / 1024);
                    byte_2 = (byte)((num2 - byte_3 * 1024) / 16);
                    byte_1 = (byte)(num2 - byte_3 * 1024 - byte_2 * 16);
                }
                else
                {
                    byte_5 = (byte)(num2 / 2048);
                    byte_4 = (byte)((num2 - byte_5 * 2048) / 128);
                    byte_3 = (byte)((num2 - byte_5 * 2048 - byte_4 * 128) / 32);
                    byte_2 = (byte)((num2 - byte_5 * 2048 - byte_4 * 128 - byte_3 * 32) / 4);
                    byte_1 = (byte)(num2 - byte_5 * 2048 - byte_4 * 128 - byte_3 * 32 - byte_2 * 4);
                }
            }
            else
            {
                byte_5 = (byte)(num2 / 2048);
                byte_4 = (byte)((num2 - byte_5 * 2048) / 128);
                byte_3 = (byte)((num2 - byte_5 * 2048 - byte_4 * 128) / 32);
                byte_2 = (byte)((num2 - byte_5 * 2048 - byte_4 * 128 - byte_3 * 32) / 4);
                byte_1 = (byte)(num2 - byte_5 * 2048 - byte_4 * 128 - byte_3 * 32 - byte_2 * 4);
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool method_15(IntPtr[] intptr_0)
    {
        try
        {
            for (int i = 0; i < intptr_0.Length; i++)
            {
                class46_0.method_40(intptr_0[i]);
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool method_16(IntPtr intptr_0)
    {
        try
        {
            class46_0.method_40(intptr_0);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool method_17(string string_3)
    {
        try
        {
            var list = method_61();
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].string_4 == string_3)
                    {
                        class46_0.method_40(list[i].intptr_0);
                        return true;
                    }
                }
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    public bool method_18(string string_3)
    {
        try
        {
            var list = method_61();
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].byte_4 == 2)
                    {
                        byte[] array = Class9.smethod_4(string_3);
                        if (array != null && !Class12.class3_0.class46_0.method_30(list[i].intptr_0, array, array.Length))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
    public void method_1(ref Class4 class4_0, ref int int_6) {
        int num = 0;
        num = Class5.smethod_76(class4_0.string_4);
        if (num < 0) {
            Class6.smethod_0(2, "SQL Error: SQL_Get_Char_CurLevel False", 0);
            Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Get_Char_CurLevel Code:" + num + " Param:" + class4_0.string_4);
        }
        if (num < Class8.byte_1) {
            return;
        }
		if (Class5.smethod_89(class4_0.string_3, class4_0.string_4, out var dateTime_, out int num2)) {
			int days = (DateTime.Now.Date - dateTime_.Date).Days;
			if (days < 1) {
				return;
			}
			if (days > 1) {
				num2 = 0;
			}
			if (num2 == 0) {
				num2 = 1;
				int int_7 = Class8.int_7;
				int num3 = Class5.smethod_54(class4_0.string_4, int_7);
				if (num3 > 0) {
					int num4 = Class5.smethod_63(class4_0.string_3, class4_0.string_4, 6, int_7, num3);
					if (num4 < 1) {
						Class6.smethod_0(2, "SQL Error: SQL_Add_Send_Silk_Log False", 0);
						Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Add_Send_Silk_Log 0 Code:" + num4 + " Param:" + class4_0.string_3 + " " + class4_0.string_4 + " " + int_7 + " " + num3);
					}
					num4 = Class5.smethod_86(class4_0.string_3, class4_0.string_4, num2);
					if (num4 < 1) {
						Class6.smethod_0(2, "SQL Error: SQL_Add_CharLogin False", 0);
						Class7.smethod_2(class4_0.string_1, "SQL Error: Add_CharLogin 0 Code:" + num4 + " Param:" + class4_0.string_3 + " " + class4_0.string_4 + " " + num2);
					}
					class4_0.list_0.Add(new Struct6(0, Class8.string_15[0] + class4_0.string_4 + Class8.string_15[1] + num2 + Class8.string_15[2] + int_7 + Class8.string_15[3]));
					int_6++;
				}
				else if (num3 < 0) {
					Class6.smethod_0(2, "SQL Error: SQL_Update_Char_Silk False", 0);
					Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Update_Char_Silk 0 Code:" + num3 + " Param:" + class4_0.string_4 + " " + int_7);
				}
			}
			else {
				if (num2 <= 0) {
					return;
				}
				num2++;
				int num5 = 0;
				num5 = ((num2 >= 15) ? Class8.int_11 : ((num2 >= 10) ? Class8.int_10 : ((num2 >= 5) ? Class8.int_9 : ((num2 < 3) ? Class8.int_7 : Class8.int_8))));
				int num6 = Class5.smethod_54(class4_0.string_4, num5);
				if (num6 > 0) {
					int num7 = Class5.smethod_63(class4_0.string_3, class4_0.string_4, 6, num5, num6);
					if (num7 < 1) {
						Class6.smethod_0(2, "SQL Error: SQL_Add_Send_Silk_Log False", 0);
						Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Add_Send_Silk_Log 1 Code:" + num7 + " Param:" + class4_0.string_3 + " " + class4_0.string_4 + " " + num5 + " " + num6);
					}
					num7 = Class5.smethod_86(class4_0.string_3, class4_0.string_4, num2);
					if (num7 < 1) {
						Class6.smethod_0(2, "SQL Error: SQL_Add_CharLogin False", 0);
						Class7.smethod_2(class4_0.string_1, "SQL Error: Add_CharLogin 1 Code:" + num7 + " Param:" + class4_0.string_3 + " " + class4_0.string_4 + " " + num2);
					}
					class4_0.list_0.Add(new Struct6(0, Class8.string_15[0] + class4_0.string_4 + Class8.string_15[1] + num2 + Class8.string_15[2] + num5 + Class8.string_15[3]));
					int_6++;
				}
				else if (num6 < 0) {
					Class6.smethod_0(2, "SQL Error: SQL_Update_Char_Silk False", 0);
					Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Update_Char_Silk 1 Code:" + num6 + " Param:" + class4_0.string_4 + " " + num5);
				}
			}
		}
		else {
			Class6.smethod_0(2, "SQL Error: SQL_Get_CharLogin_Data False", 0);
			Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Get_CharLogin_Data Param:" + class4_0.string_3 + " " + class4_0.string_4);
		}
	}

    public int method_2(IntPtr intptr_0, ref Class4 class4_0, byte byte_0, ref int int_6, byte byte_1, string string_3, string string_4) {
        string_3 = string_3.Remove(0, 1);
        for (int i = 0; i < Class5.list_9.Count; i++) {
            var @struct = Class5.list_9[i];
            switch (byte_1) {
                case 2: {
                    if (@struct.int_1 != 2 || string_3.Length < @struct.string_0.Length || !(string_3.Substring(0, @struct.string_0.Length) == @struct.string_0)) {
                        break;
                    }
                    if (@struct.byte_0 > 0) {
                        if (!(@struct.string_2 == "@TargetAndCommandParam")) {
                            break;
                        }
                        string[] array4 = string_3.Split(new string[1] { "*" }, StringSplitOptions.RemoveEmptyEntries);
                        if (array4 == null || array4.Length != 2) {
                            break;
                        }
						switch (Class5.smethod_129(@struct.string_1, class4_0.string_4, string_4, array4[1], out string string_10, out string string_11)) {
							default:
								Class6.smethod_0(2, "SQL Error: " + @struct.string_1 + " False", 0);
								Class7.smethod_2(class4_0.string_1, "SQL Error: " + @struct.string_1 + " Q Code:" + string_11.ToString() + " Param:" + class4_0.string_4 + " " + string_4 + " " + array4[1]);
								break;
							case 1:
								if (@struct.string_3 == "1") {
									string[] array5 = @struct.string_7.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
									if (array5 != null) {
										string[] array6 = string_10.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
										if (array6 != null && array5.Length == array6.Length) {
											var intptr_ = IntPtr.Zero;
											for (int k = 0; k < array5.Length; k++) {
												if (array5[k] == "$UICharSilk") {
													method_27(intptr_0, int.Parse(array6[k]));
												}
												else if (array5[k] == "$UITargetSilk") {
													method_26(string_4, int.Parse(array6[k]), out intptr_);
												}
												else if (array5[k] == "$CharInfo") {
													Class9.smethod_27(intptr_0, array6[k]);
												}
												else if (array5[k] == "$TargetInfo") {
													if (intptr_ != IntPtr.Zero) {
														Class9.smethod_27(intptr_, array6[k]);
													}
												}
												else if (array5[k] == "$AllSilk") {
													method_22(int.Parse(array6[k]), class4_0.string_4);
												}
												else if (array5[k] == "$ServerInfo") {
													method_21(array6[k]);
												}
											}
										}
									}
								}
								else if (@struct.string_3 == "0") {
									string_10 = @struct.string_7 + string_10;
									Class9.smethod_27(intptr_0, string_10);
								}
								method_55(class4_0, 8194, byte_0);
								return 2;
							case 2:
								Class9.smethod_27(intptr_0, string_10);
								method_55(class4_0, 8194, byte_0);
								return 2;
						}
						break;
                    }
					if (Class5.smethod_131(@struct.string_1, string_4, out string text4, out var string_12) != 1) {
						Class6.smethod_0(2, "SQL Error: " + @struct.string_1 + " False", 0);
						Class7.smethod_2(class4_0.string_1, "SQL Error: " + @struct.string_1 + " Q Code:" + string_12.ToString() + " Param:" + class4_0.string_4);
						break;
					}
					if (text4 != null) {
                        text4 = @struct.string_7 + text4;
                        method_55(class4_0, 8194, byte_0);
                        Class9.smethod_27(intptr_0, text4);
                    }
                    else {
                        method_55(class4_0, 8194, byte_0);
                    }
                    return 2;
                }
                case 1:
                case 3:
                    if (@struct.int_1 != 1 || string_3.Length < @struct.string_0.Length || !(string_3.Substring(0, @struct.string_0.Length) == @struct.string_0)) {
                        break;
                    }
                    if (@struct.byte_0 > 0) {
                        if (@struct.string_2 == "@Rank") {
							if (Class5.smethod_131(@struct.string_1, string_4, out string text, out var string_5) == 1) {
								text = Class9.smethod_3(text, int.Parse(@struct.string_3), int.Parse(@struct.string_4), int.Parse(@struct.string_5));
								method_55(class4_0, 8194, byte_0);
								Class9.smethod_25(intptr_0, text);
								return 2;
							}
							Class6.smethod_0(2, "SQL Error: " + @struct.string_1 + " False", 0);
                            Class7.smethod_2(class4_0.string_1, "SQL Error: " + @struct.string_1 + " Q Code:" + string_5.ToString() + " Param:" + string_4);
                        }
                        else if (@struct.string_2 == "@Link_Stored") {
							switch (Class5.smethod_131(@struct.string_1, string_4, out string text2, out string string_6)) {
								default:
									Class6.smethod_0(2, "SQL Error: " + @struct.string_1 + " False", 0);
									Class7.smethod_2(class4_0.string_1, "SQL Error: " + @struct.string_1 + " Q Code:" + string_6.ToString() + " Param:" + string_4);
									break;
								case 1:
									method_55(class4_0, 8194, byte_0);
									Class9.smethod_27(intptr_0, text2);
									return 2;
								case 2: {
									method_55(class4_0, 8194, byte_0);
									Class9.smethod_27(intptr_0, text2);
									var struct2 = default(Struct8);
									struct2.string_0 = string_4;
									struct2.string_1 = @struct.string_7;
									Class10.smethod_2(11, struct2, int.Parse(@struct.string_3));
									class4_0.byte_4 = 4;
									int_6++;
									return 3;
								}
							}
						}
                        else {
                            if (!(@struct.string_2 == "@CommandParam")) {
                                break;
                            }
                            string[] array = string_3.Split(new string[1] { "*" }, StringSplitOptions.RemoveEmptyEntries);
                            if (array == null || array.Length != 2) {
                                break;
                            }
							switch (Class5.smethod_130(@struct.string_1, class4_0.string_4, array[1], out string string_7, out string string_8)) {
								case 1: {
									int num = 0;
									if (@struct.string_3 == "1") {
										string[] array2 = @struct.string_7.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
										if (array2 != null) {
											string[] array3 = string_7.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
											if (array3 != null && array2.Length == array3.Length) {
												for (int j = 0; j < array2.Length; j++) {
													if (array2[j] == "$UICharSilk") {
														method_27(intptr_0, int.Parse(array3[j]));
													}
													else if (array2[j] == "$CharInfo") {
														Class9.smethod_27(intptr_0, array3[j]);
													}
													else if (array2[j] == "$AllSilk") {
														method_22(int.Parse(array3[j]), class4_0.string_4);
													}
													else if (array2[j] == "$ServerInfo") {
														method_21(array3[j]);
													}
													else if (array2[j] == "$HwanLevel") {
														Class12.class11_0.method_8();
														Class10.smethod_2(20, new Struct9(intptr_0, class4_0.int_14, byte.Parse(array3[j])), 3000);
													}
													else if (array2[j] == "$TransferUser") {
														num = 1;
														method_52(class4_0, byte_0, array3[j]);
													}
													else if (array2[j] == "$SummonMonster") {
														num = 1;
														method_51(class4_0, byte_0, int.Parse(array3[j]));
													}
												}
											}
										}
									}
									else if (@struct.string_3 == "0") {
										string_7 = @struct.string_7 + string_7;
										Class9.smethod_27(intptr_0, string_7);
									}
									switch (num) {
										case 1:
											return 2;
										case 0:
											method_55(class4_0, 8194, byte_0);
											return 2;
									}
									break;
								}
								default:
									Class6.smethod_0(2, "SQL Error: " + @struct.string_1 + " False", 0);
									Class7.smethod_2(class4_0.string_1, "SQL Error: " + @struct.string_1 + " Q Code:" + string_8.ToString() + " Param:" + class4_0.string_4 + " " + array[1]);
									break;
								case 2:
									Class9.smethod_27(intptr_0, string_7);
									method_55(class4_0, 8194, byte_0);
									return 2;
							}
						}
                    }
                    else {
						switch (Class5.smethod_131(@struct.string_1, string_4, out string text3, out string string_9)) {
							default:
								Class6.smethod_0(2, "SQL Error: " + @struct.string_1 + " False", 0);
								Class7.smethod_2(class4_0.string_1, "SQL Error: " + @struct.string_1 + " Q Code:" + string_9.ToString() + " Param:" + string_4);
								break;
							case 1:
								text3 = @struct.string_7 + text3;
								method_55(class4_0, 8194, byte_0);
								Class9.smethod_27(intptr_0, text3);
								return 2;
							case 2:
								text3 = @struct.string_7 + text3;
								method_55(class4_0, 8194, byte_0);
								Class9.smethod_27(intptr_0, text3);
								class4_0.byte_4 = 4;
								int_6++;
								return 3;
						}
					}
                    break;
            }
        }
        return 0;
    }

    public int method_3(IntPtr intptr_0, ref Class4 class4_0, byte byte_0, ref int int_6, byte byte_1, short short_0, short short_1, string string_3) {
        string text = "抢红包";
        text = ((Class13.int_4 == 0) ? "抢红包" : ((!Class8.bool_55) ? "抢红包" : ((!(Class8.string_55 != "")) ? "抢红包" : Class8.string_55)));
        if (string_3.Length >= text.Length && string_3.IndexOf(text) == 0) {
            if (!Class13.bool_0) {
                method_55(class4_0, 8194, byte_0);
                Class9.smethod_27(intptr_0, Class8.string_30);
                return 2;
            }
            if (class4_0.int_12 == 1) {
                if (Class13.int_1 == 0) {
                    method_55(class4_0, 8194, byte_0);
                    Class9.smethod_27(intptr_0, Class8.string_18);
                    return 2;
                }
                bool flag = false;
                int num = random_0.Next(Class13.int_3, Class13.int_2);
                if (num >= Class13.int_1) {
                    num = Class13.int_1;
                    flag = true;
                }
                Class13.smethod_0(num, bool_1: false);
                class4_0.int_12 = 10;
                int_6++;
                int num2 = Class9.smethod_19(intptr_0, class4_0.string_4, num, 8, bool_0: true);
                if (num2 == 1) {
                    Class9.smethod_27(intptr_0, Class8.string_24[0] + num + Class8.string_24[1]);
                    if (short_1 > 0) {
                        if (Class8.bool_64) {
                            method_48(intptr_0, class4_0, 28748, byte_0, byte_1, short_0, short_1, Class8.string_28[0] + num + Class8.string_28[1]);
                        }
                        else {
                            method_47(intptr_0, class4_0, 28748, byte_0, byte_1, short_0, short_1, Class8.string_28[0] + num + Class8.string_28[1]);
                        }
                    }
                    else {
                        method_46(intptr_0, class4_0, 28748, byte_0, byte_1, short_0, Class8.string_28[0] + num + Class8.string_28[1]);
                    }
                    Class6.smethod_0(5, "", num);
                    if (flag) {
                        method_11();
                        method_21(Class8.string_19);
                    }
                    return 2;
                }
                Class6.smethod_0(2, "SQL Error: Send_Clinet_Char_Silk False", 0);
                Class7.smethod_2(class4_0.string_1, "SQL Error: Send_Clinet_Char_Silk Q Code:" + num2 + " Param:" + class4_0.string_4 + " " + num);
            }
            else {
                if (class4_0.int_12 == 10) {
                    method_55(class4_0, 8194, byte_0);
                    Class9.smethod_27(intptr_0, Class8.string_20);
                    return 2;
                }
                if (class4_0.int_12 == 0) {
                    method_55(class4_0, 8194, byte_0);
                    Class9.smethod_27(intptr_0, Class8.string_31);
                    return 2;
                }
            }
        }
        if (Class8.bool_18 && string_3.IndexOf("发红包") == 0) {
            if (Class13.bool_0) {
                method_55(class4_0, 8194, byte_0);
                Class9.smethod_27(intptr_0, Class8.string_21);
                return 2;
            }
            string[] array = string_3.Split(new string[1] { "*" }, StringSplitOptions.RemoveEmptyEntries);
            if (array.Length == 2) {
				if (!int.TryParse(array[1], out int result)) {
					method_55(class4_0, 8194, byte_0);
					Class9.smethod_27(intptr_0, Class8.string_22);
					return 2;
				}
				if (result <= 0) {
                    method_55(class4_0, 8194, byte_0);
                    Class9.smethod_27(intptr_0, Class8.string_23);
                    return 2;
                }
                if (result < Class8.int_16) {
                    method_55(class4_0, 8194, byte_0);
                    Class9.smethod_27(intptr_0, Class8.string_25[0] + Class8.int_16 + Class8.string_25[1]);
                    return 2;
                }
                int num3 = Class5.smethod_73(class4_0.string_3);
                if (num3 < 0) {
                    Class6.smethod_0(2, "SQL Error: SQL_Get_User_Silk False", 0);
                    Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Get_User_Silk Code:" + num3 + " Param:" + class4_0.string_3);
                }
                if (num3 < result) {
                    method_55(class4_0, 8194, byte_0);
                    Class9.smethod_27(intptr_0, Class8.string_26[0] + result + Class8.string_26[1]);
                    return 2;
                }
                int num4 = Class9.smethod_19(intptr_0, class4_0.string_4, result, 9, bool_0: false);
                if (num4 == 1) {
                    method_10(0, result, class4_0.string_4);
                    method_21(Class8.string_27[0] + class4_0.string_4 + Class8.string_27[1] + result + Class8.string_27[2]);
                    Class6.smethod_0(3, "", result);
                }
                else {
                    Class6.smethod_0(2, "SQL Error: Send_Clinet_Char_Silk False", 0);
                    Class7.smethod_2(class4_0.string_1, "SQL Error: Send_Clinet_Char_Silk S Code:" + num4 + " Param:" + class4_0.string_4 + " " + result);
                }
            }
        }
        return 0;
    }

    public void method_4(IntPtr intptr_0, ref Class4 class4_0, byte[] byte_0, ref int int_6) {
        ushort num = BitConverter.ToUInt16(byte_0, 2);
        if (byte_0[0] == 37 && byte_0.Length > 27 && num == 20480) {
            try {
                if (class4_0.int_0 == 0) {
                    uint num2 = 0u;
                    uint num3 = 0u;
                    byte[] array = new byte[8];
                    Array.Copy(byte_0, 23, array, 0, 8);
                    num2 = BitConverter.ToUInt32(byte_0, 35) & 0x7FFFFFFFu;
                    num3 = BitConverter.ToUInt32(byte_0, 19);
                    class4_0.int_0 = 1;
                    class4_0.uint_2 = num2;
                    class4_0.byte_2 = array;
                    class4_0.uint_1 = num3;
                    class4_0.int_9 = Class9.smethod_0();
                    int_6++;
                }
            }
            catch {
                Class7.smethod_2(class4_0.string_1, "System Error A K Try Error: 0014");
            }
        }
        switch (num) {
            case 12300: {
                if (byte_0.Length < 14) {
                    return;
                }
                var class2 = new Class14(byte_0);
                class2.ReadBytes(6);
                byte b3 = class2.ReadByte();
                byte b4 = class2.ReadByte();
                if (b3 != 6 || b4 != 12) {
                    return;
                }
                try {
                    uint uint_2 = class2.ReadUInt32();
                    string text = class2.method_0();
                    if (text == class4_0.string_4 || text == class4_0.string_5) {
                        var struct2 = default(Struct10);
                        struct2.intptr_0 = class4_0.intptr_0;
                        struct2.string_0 = class4_0.string_0;
                        struct2.string_1 = class4_0.string_1;
                        struct2.string_2 = class4_0.string_2;
                        struct2.string_3 = class4_0.string_3;
                        struct2.string_4 = class4_0.string_4;
                        struct2.string_5 = text;
                        struct2.uint_0 = uint_2;
                        Class10.smethod_3(1, struct2);
                    }
                }
                catch {
                    Class6.smethod_0(2, "SQL Error: Send_MonsterKillReward False", 0);
                    Class7.smethod_2(class4_0.string_1, "SQL Error: Send_MonsterKillReward 0009");
                }
                return;
            }
            case 45392: {
                if (byte_0.Length < 19) {
                    return;
                }
                var @class = new Class14(byte_0);
                @class.ReadBytes(6);
                byte b = @class.ReadByte();
                byte b2 = @class.ReadByte();
                if (b == 1 && b2 == 2 && @class.ReadByte() == 1) {
                    try {
                        byte byte_ = @class.ReadByte();
                        @class.ReadBytes(4);
                        uint uint_ = @class.ReadUInt32();
                        byte byte_2 = @class.ReadByte();
                        var @struct = default(Struct11);
                        @struct.intptr_0 = class4_0.intptr_0;
                        @struct.string_0 = class4_0.string_0;
                        @struct.string_1 = class4_0.string_1;
                        @struct.string_2 = class4_0.string_2;
                        @struct.string_3 = class4_0.string_3;
                        @struct.string_4 = class4_0.string_4;
                        @struct.uint_0 = uint_;
                        @struct.byte_0 = byte_2;
                        @struct.byte_1 = byte_;
                        Class10.smethod_3(2, @struct);
                    }
                    catch {
                        Class6.smethod_0(2, "SQL Error: Send_AlchemyReward False", 0);
                        Class7.smethod_2(class4_0.string_1, "SQL Error: Send_AlchemyReward 0010");
                    }
                }
                return;
            }
            case 13061:
                if (byte_0.Length <= 5) {
                    return;
                }
                try {
                    class4_0.byte_4 = 2;
                    int_6++;
                }
                catch {
                    Class7.smethod_2(class4_0.string_1, "System Error A: 0012");
                }
                try {
                    if (!class4_0.bool_4) {
                        class4_0.bool_4 = true;
                        int_6++;
                    }
                    if (!class4_0.bool_3) {
                        class4_0.bool_3 = true;
                        int_6++;
                    }
                    if (!class4_0.bool_1) {
                        class4_0.bool_1 = true;
                        int_6++;
                    }
                    if (!class4_0.bool_2) {
                        class4_0.bool_2 = true;
                        int_6++;
                    }
					int num4 = Class5.smethod_77(class4_0.string_4, class4_0.string_0, class4_0.string_2, out string string_, out string string_2);
					if (num4 < 1) {
                        Class6.smethod_0(2, "SQL Error: SQL_Center_System_Event_Char_Data_Loading_End False", 0);
                        Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Center_System_Event_Char_Data_Loading_End Code:" + num4 + " Param:" + class4_0.string_4 + " " + class4_0.string_2);
                    }
                    else {
                        if (string_ != "NULL") {
                            if (string_.IndexOf("SQL_SET_SupportTargetState=0") > -1) {
                                class4_0.bool_1 = false;
                                int_6++;
                            }
                            if (string_.IndexOf("SQL_SET_TrackTargetState=0") > -1) {
                                class4_0.bool_2 = false;
                                int_6++;
                            }
                            if (string_.IndexOf("SQL_SET_UseItemResurrectionState=0") > -1) {
                                class4_0.bool_4 = false;
                                int_6++;
                            }
                            if (string_.IndexOf("SQL_SET_Char_UseItemReturnState=0") > -1) {
                                class4_0.bool_3 = false;
                                int_6++;
                            }
                        }
                        if (string_2 != "NULL" && !Class9.smethod_27(class4_0.intptr_0, string_2)) {
                            Class7.smethod_2(class4_0.string_1, "System Error A: 11001");
                        }
                        if (num4 == 2) {
                            list_1.Add(new Struct4(class4_0.intptr_0, Class9.smethod_0(), 300));
                        }
                    }
                }
                catch {
                    Class7.smethod_2(class4_0.string_1, "System Error ALoginNot: A020");
                }



          /*         if (class4_0.string_2 == "00") {
                    if (!Class9.smethod_27(class4_0.intptr_0, "检测到您客户端无法加载组件,请关闭系统杀毒软件(winds7以上系统)或检查客户端是否纯在组件,请联系管理员")) {
                        Class7.smethod_2(class4_0.string_1, "System Error A: Pci");
                    }
                    list_1.Add(new Struct4(class4_0.intptr_0, Class9.smethod_0(), 300));//踢出服务器
                }
                try {
                    if (class4_0.list_0.Count() > 0) {
                        var list = new List<Struct6>(class4_0.list_0);
                        for (int i = 0; i < list.Count; i++) {
                            if (list[i].int_0 == 0) {
                                if (!Class9.smethod_27(class4_0.intptr_0, list[i].string_0)) {
                                    Class7.smethod_2(class4_0.string_1, "System Error A: 0113");
                                }
                            }
                            else if (!Class9.smethod_25(class4_0.intptr_0, list[i].string_0)) {
                                Class7.smethod_2(class4_0.string_1, "System Error A 0: 0113");
                            }
                        }
                        list.Clear();
                        class4_0.list_0 = list;
                        int_6++;
                    }
                }
                catch {
                    Class7.smethod_2(class4_0.string_1, "System Error ALoginNot: A012");
                }   */



                try {
                    if (int_0 > 0) {
                        int num5 = Class5.smethod_53(class4_0.string_4);
                        if (num5 != 1) {
                            Class6.smethod_0(2, "SQL Error: SQL_Add_Char_WorldCodeName False", 0);
                            Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Add_Char_WorldCodeName Code:" + num5 + " Param:" + class4_0.string_4);
                        }
                    }
                }
                catch {
                    Class7.smethod_2(class4_0.string_1, "System Error ALoginSie: A013");
                }
                if (Class8.bool_64) {
                    try {
                        Class10.smethod_2(15, new Struct15(class4_0.intptr_0, class4_0.string_3, class4_0.string_1), 500);
                    }
                    catch {
                        Class7.smethod_2(class4_0.string_1, "System Error ALoginRSilk: A015");
                    }
                }
                if (!Class8.bool_40) {
                    return;
                }
                try {
                    if (class4_0.bool_0) {
                        Class10.smethod_2(12, new Struct16(class4_0.intptr_0, class4_0.string_4, class4_0.string_1), 1000);
                    }
                }
                catch {
                    Class7.smethod_2(class4_0.string_1, "System Error ALoginCam: A016");
                }
                return;
            case 13477:
                if (byte_0.Length > 5) {
                    try {
                        class4_0.byte_4 = 3;
                        int_6++;
                    }
                    catch {
                        Class7.smethod_2(class4_0.string_1, "System Error: 3A13");
                    }
                }
                return;
            case 12374:
                if (byte_0.Length == 29) {
                    var class3 = new Class14(byte_0);
                    class3.ReadBytes(27);
                    if (class3.ReadUInt16() > 0) {
                        var struct3 = default(Struct12);
                        struct3.intptr_0 = class4_0.intptr_0;
                        struct3.string_0 = class4_0.string_1;
                        struct3.string_1 = class4_0.string_3;
                        struct3.string_2 = class4_0.string_4;
                        struct3.byte_0 = Class8.byte_2;
                        Class10.smethod_2(3, struct3, 3000);
                    }
                }
                return;
            case 12320:
                if (byte_0.Length >= 10) {
                    var class4 = new Class14(byte_0);
                    class4.ReadBytes(6);
                    int num6 = class4.ReadInt32();
                    if (num6 > 0) {
                        class4_0.int_14 = num6;
                        int_6++;
                    }
                }
                return;
        }
        if (num == Class15.ushort_0) {
            if (byte_0.Length < 26 || !Class8.bool_51) {
                return;
            }
            var class5 = new Class14(byte_0);
            class5.ReadBytes(9);
            int num7 = class5.ReadInt32();
            int num8 = class5.ReadInt32();
            if (class4_0.int_14 != num8) {
                return;
            }
            for (int j = 0; j < class4_0.list_1.Count; j++) {
                var value = class4_0.list_1[j];
                if (value.int_0 == num7) {
                    if (value.int_1 == 0) {
                        value.int_1 = Class9.smethod_0();
                        class4_0.list_1[j] = value;
                        int_6++;
                    }
                    else if (Class9.smethod_0() - value.int_1 > value.int_2) {
                        value.int_1 = Class9.smethod_0();
                        class4_0.list_1[j] = value;
                        int_6++;
                    }
                }
            }
            return;
        }
        if (num == Class15.ushort_1) {
            if (byte_0.Length >= 87 && !class4_0.bool_0) {
                try {
                    class4_0.bool_0 = true;
                    int_6++;
                }
                catch {
                    Class7.smethod_2(class4_0.string_1, "System Error: 38C2");
                }
            }
            return;
        }
        if (num == 15488) {
            if (byte_0.Length < 13 || !Class8.bool_40) {
                return;
            }
            try {
                var class6 = new Class14(byte_0);
                class6.ReadBytes(6);
                if (class6.ReadByte() == 5) {
                    class6.ReadInt32();
                    if (class6.ReadByte() == 3 && class4_0.bool_0) {
                        Class10.smethod_2(12, new Struct16(class4_0.intptr_0, class4_0.string_4, class4_0.string_1), 500);
                    }
                }
            }
            catch {
                Class7.smethod_2(class4_0.string_1, "System Error: 380C");
            }
            return;
        }
        if (num == Class15.ushort_2) {
            if (byte_0.Length == 6) {
                class4_0.byte_4 = 4;
                int_6++;
                Class7.smethod_2(class4_0.string_1, "ExitGame");
            }
            return;
        }
        if (num == 12627) {
            if (byte_0.Length >= 18 && class4_0.int_13 > 0) {
                var class7 = new Class14(byte_0);
                class7.ReadBytes(6);
                int num9 = class7.ReadInt32();
                int num10 = class4_0.int_13 - num9;
                class4_0.int_13 = 0;
                int_6++;
                var struct4 = default(Struct14);
                struct4.intptr_0 = class4_0.intptr_0;
                struct4.string_0 = class4_0.string_1;
                struct4.string_1 = class4_0.string_3;
                struct4.string_2 = class4_0.string_4;
                struct4.int_0 = num10;
                Class10.smethod_3(4, struct4);
            }
            return;
        }
        if (num != Class15.ushort_3 || byte_0.Length < 7 || !Class8.bool_27) {
            return;
        }
        var class8 = new Class14(byte_0);
        class8.ReadBytes(6);
        switch (class8.ReadByte()) {
            case 2:
                lock (object_9) {
                    if (int_0 == 0) {
                        int_1 = 0;
                        int_0 = Class9.smethod_0();
                        this.string_2 = DateTime.Now.ToString();
                        Class6.smethod_0(2, "Sieg Reward System 要塞活动已开启", 0);
                    }
                    else if (Class9.smethod_0() - int_0 > Class15.int_0) {
                        int_0 = 0;
                        int_1 = Class9.smethod_0();
                        this.string_2 = DateTime.Now.ToString();
                        Class6.smethod_0(2, "Sieg Reward System 要塞活动已开启", 0);
                    }
                }
                break;
            case 6:
                lock (object_10) {
                    if (int_1 == 0) {
                        int_0 = 0;
                        int_1 = Class9.smethod_0();
                        string text2 = this.string_2;
                        Class10.smethod_2(10, text2, 3000);
                        Class6.smethod_0(2, "Sieg Reward System 要塞活动已结束", 0);
                    }
                    else if (Class9.smethod_0() - int_1 > Class15.int_0) {
                        int_0 = 0;
                        int_1 = Class9.smethod_0();
                        string text3 = this.string_2;
                        Class10.smethod_2(10, text3, 3000);
                        Class6.smethod_0(2, "Sieg Reward System 要塞活动已结束", 0);
                    }
                }
                break;
        }
    }

    public int method_5(IntPtr intptr_0, ref Class4 class4_0, byte[] byte_0, ref int int_6) {
        byte[] array = new byte[0];
        if (Class15.Center_Get_Buffer_Enc(byte_0, byte_0.Length)) {
            try {
                if (class4_0.byte_2 == null) {
                    Class7.smethod_2(class4_0.string_1, "System Error A Key Code:null " + BitConverter.ToString(array));
                    return 1;
                }
                var @class = new Class16();
                @class.method_0(class4_0.byte_2);
                array = @class.method_5(byte_0, 2, byte_0.Length - 2);
                ushort value = Class17.smethod_6(byte_0, 0);
                byte[] array2 = new byte[array.Length + 2];
                Array.Copy(BitConverter.GetBytes(value), array2, 2);
                Array.Copy(array, 0, array2, 2, array.Length);
                array = array2;
                if (Class8.bool_66) {
                    var @struct = default(Struct17);
                    @struct.string_0 = class4_0.string_3;
                    @struct.string_1 = DateTime.Now.ToString() + "\t" + class4_0.byte_4 + "\tIP:" + class4_0.string_1 + "\tEncAgentServerRecv:(" + array.Length + ")\t" + BitConverter.ToString(array);
                    Class10.smethod_3(9, @struct);
                }
            }
            catch {
                Class7.smethod_2(class4_0.string_1, "System Error A DeKey Code: 0001");
                return 1;
            }
        }
        else {
            array = byte_0;
        }
        if (array.Length > 5) {
            ushort num = (ushort)BitConverter.ToInt16(array, 2);
            if (class4_0.byte_4 <= 1 && Class15.smethod_5(num) == 0) {
                if (!Class9.smethod_15(class4_0.string_0)) {
                    Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                }
                Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                if (Class8.bool_66) {
                    Class7.smethod_2(class4_0.string_1, "System Att A Opcode Code:" + num + " Buffer:" + BitConverter.ToString(array));
                }
                else {
                    Class7.smethod_2(class4_0.string_1, "System Att A Opcode Code:AgentState");
                }
                return 1;
            }
            if (class4_0.byte_4 == 2 && Class15.smethod_6(num) == 0) {
                if (!Class9.smethod_15(class4_0.string_0)) {
                    Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                }
                Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                if (Class8.bool_66) {
                    Class7.smethod_2(class4_0.string_1, "System Att A Opcode Code:" + num + " Buffer:" + BitConverter.ToString(array));
                }
                else {
                    Class7.smethod_2(class4_0.string_1, "System Att A Opcode Code:GamesState");
                }
                return 1;
            }
            if (Class8.int_30 == 1) {
                bool flag = false;
                for (int i = 0; i < list_2.Count; i++) {
                    if (list_2[i].ushort_0 == num) {
                        flag = true;
                        break;
                    }
                }
                if (!flag) {
                    lock (object_8) {
                        var item = default(Struct2);
                        item.string_0 = DateTime.Now.ToString();
                        item.ushort_0 = num;
                        item.string_1 = BitConverter.ToString(array);
                        list_2.Add(item);
                        Class7.smethod_5("CenterManager.dmp", list_2);
                    }
                }
            }
            if (Class8.int_30 == 2) {
                bool flag2 = false;
                for (int j = 0; j < list_2.Count; j++) {
                    if (list_2[j].ushort_0 == num) {
                        flag2 = true;
                        break;
                    }
                }
                if (!flag2) {
                    Class7.smethod_2(class4_0.string_1, "Opcode:" + num + " Data:" + BitConverter.ToString(array));
                    return 0;
                }
            }
            if (Class8.int_30 == 3) {
                bool flag3 = false;
                for (int k = 0; k < list_2.Count; k++) {
                    if (list_2[k].ushort_0 == num) {
                        flag3 = true;
                        break;
                    }
                }
                if (!flag3) {
                    Class7.smethod_2(class4_0.string_1, "Opcode:" + num + " Data:" + BitConverter.ToString(array));
                }
            }
			//新增往下
			if (class4_0.string_2 == "00") {
				if (!Class9.smethod_27(class4_0.intptr_0, "禁止机器人进入游戏[非机器码]"))
					{
					Class7.smethod_2(class4_0.string_1, "System Error A: Pci");
				}
				Class6.smethod_0(2, class4_0.string_1 + "使用工具或非完整组件进入游戏，强制踢出", 0);
				list_1.Add(new Struct4(class4_0.intptr_0, Class9.smethod_0(), 300));//踢出服务器

			}
			try {
				if (class4_0.list_0.Count() > 0) {
					var list = new List<Struct6>(class4_0.list_0);
					for (int i = 0; i < list.Count; i++) {
						if (list[i].int_0 == 0) {
							if (!Class9.smethod_27(class4_0.intptr_0, list[i].string_0)) {
								Class7.smethod_2(class4_0.string_1, "System Error A: 0113");
							}
						}
						else if (!Class9.smethod_25(class4_0.intptr_0, list[i].string_0)) {
							Class7.smethod_2(class4_0.string_1, "System Error A 0: 0113");
						}
					}
					list.Clear();
					class4_0.list_0 = list;
					int_6++;
				}
			}
			catch {
			}
			///////////////////////////////////////////////新增往上
			if (num == 20480) {
                try {
                    if (class4_0.int_0 == 1) {
                        byte[] byte_ = class4_0.byte_2;
                        uint uint_ = class4_0.uint_2;
                        var class2 = new Class16();
                        uint uint_2 = BitConverter.ToUInt32(array, 6);
                        uint uint_3 = class2.method_6(uint_, 2147483647u, uint_2);
                        Class15.Center_Update_Key(byte_, uint_3, 3);
                        class4_0.int_0 = 2;
                        class4_0.uint_2 = uint_;
                        class4_0.byte_2 = byte_;
                        class4_0.int_10 = Class9.smethod_0() - class4_0.int_9;
                        int_6++;
                    }
                    else if (class4_0.int_0 == 2) {
                        Class7.smethod_2(class4_0.string_1, "System Error A K Oet ErrorCode: 0001");
                        return 1;
                    }
                }
                catch {
                    Class7.smethod_2(class4_0.string_1, "System Error A K Try ErrorCode: 0001");
                    return 1;
                }
            }


		if (num == 0X3510) {
				if (array.Length != 4) {
					if (!Class9.smethod_15(class4_0.string_0)) {
						Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
					}
					Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击 3510!", 0);
					Class7.smethod_2(class4_0.string_1, "System Att 3510 Opcode Code:x");
					return 1;
				}
				var class3 = new Class14(array);
				class3.ReadBytes(6);
				ushort num2 = class3.ReadUInt16();
				if (array.Length != num2 + 8) {
					if (!Class9.smethod_15(class4_0.string_0)) {
						Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
					}
					Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击 3510!", 0);
					Class7.smethod_2(class4_0.string_1, "System Att  3510 Opcode Code:x");
					return 1;
				}
			}




			if (num == 28673) {
                if (array.Length < 8) {
                    if (!Class9.smethod_15(class4_0.string_0)) {
                        Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                    }
                    Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                    Class7.smethod_2(class4_0.string_1, "System Att A712 Opcode Code:x");
                    return 1;
                }
                var class3 = new Class14(array);
                class3.ReadBytes(6);
                ushort num2 = class3.ReadUInt16();
                if (array.Length != num2 + 8) {
                    if (!Class9.smethod_15(class4_0.string_0)) {
                        Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                    }
                    Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                    Class7.smethod_2(class4_0.string_1, "System Att A711 Opcode Code:x");
                    return 1;
                }
            }



            if (num == 28679) {
                if (array.Length < 7) {
                    if (!Class9.smethod_15(class4_0.string_0)) {
                        Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                    }
                    Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                    Class7.smethod_2(class4_0.string_1, "System Att A7012 Opcode Code:x");
                    return 1;
                }
                var class4 = new Class14(array);
                class4.ReadBytes(6);
                switch (class4.ReadByte()) {
                    case 1:
                        if (array.Length > 30) {
                            ushort num5 = class4.ReadUInt16();
                            if (array.Length != num5 + 30) {
                                if (!Class9.smethod_15(class4_0.string_0)) {
                                    Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                                }
                                Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                                Class7.smethod_2(class4_0.string_1, "System Att A717 Opcode Code:x");
                                return 1;
                            }
                            break;
                        }
                        if (!Class9.smethod_15(class4_0.string_0)) {
                            Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                        }
                        Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                        Class7.smethod_2(class4_0.string_1, "System Att A718 Opcode Code:x");
                        return 1;
                    case 4:
                        if (array.Length > 9) {
                            ushort num6 = class4.ReadUInt16();
                            if (array.Length != num6 + 9) {
                                if (!Class9.smethod_15(class4_0.string_0)) {
                                    Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                                }
                                Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                                Class7.smethod_2(class4_0.string_1, "System Att A741 Opcode Code:x");
                                return 1;
                            }
                            break;
                        }
                        if (!Class9.smethod_15(class4_0.string_0)) {
                            Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                        }
                        Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                        Class7.smethod_2(class4_0.string_1, "System Att A742 Opcode Code:x");
                        return 1;
                    case 16: {
                        ushort num4 = class4.ReadUInt16();
                        if (array.Length != num4 + 10) {
                            if (!Class9.smethod_15(class4_0.string_0)) {
                                Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                            }
                            Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                            Class7.smethod_2(class4_0.string_1, "System Att A7161 Opcode Code:x");
                            return 1;
                        }
                        break;
                    }
                    default:
                        if (!Class9.smethod_15(class4_0.string_0)) {
                            Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                        }
                        Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                        Class7.smethod_2(class4_0.string_1, "System Att A7010 Opcode Code:x");
                        return 1;
                    case 2:
                    case 9:
                        if (array.Length != 7) {
                            if (!Class9.smethod_15(class4_0.string_0)) {
                                Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                            }
                            Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                            Class7.smethod_2(class4_0.string_1, "System Att A72 Opcode Code:x");
                            return 1;
                        }
                        break;
                    case 3:
                    case 5:
                        if (array.Length > 9) {
                            ushort num3 = class4.ReadUInt16();
                            if (array.Length != num3 + 9) {
                                if (!Class9.smethod_15(class4_0.string_0)) {
                                    Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                                }
                                Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                                Class7.smethod_2(class4_0.string_1, "System Att A731 Opcode Code:x");
                                return 1;
                            }
                            break;
                        }
                        if (!Class9.smethod_15(class4_0.string_0)) {
                            Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                        }
                        Class6.smethod_0(2, "System AgentServer 已拦截一次未知攻击!", 0);
                        Class7.smethod_2(class4_0.string_1, "System Att A732 Opcode Code:x");
                        return 1;
                }
            }
            int num7 = Class15.Center_Get_Buffer_Enc_Length(array, array.Length, num);
            if (num7 == -10 || num7 == -11) {
                if (!Class9.smethod_15(class4_0.string_0)) {
                    Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                }
                Class6.smethod_0(2, "System AgentServer 已拦截一次攻击!", 0);
                if (Class8.bool_66) {
                    Class7.smethod_2(class4_0.string_1, "System Att A Opcode Code:" + num + " Buffer:" + BitConverter.ToString(array));
                }
                else {
                    Class7.smethod_2(class4_0.string_1, "System Att A Opcode Code:Enc_Leng");
                }
                return 1;
            }
            switch (Class15.Get_AgentOpcodeState(num, array.Length)) {
                case 1:
                    if (!Class9.smethod_15(class4_0.string_0)) {
                        Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                    }
                    Class6.smethod_0(2, "System AgentServer 已拦截一次攻击!", 0);
                    if (Class8.bool_66) {
                        Class7.smethod_2(class4_0.string_1, "System Att A Opcode Code:" + num + " Buffer:" + BitConverter.ToString(array));
                    }
                    else {
                        Class7.smethod_2(class4_0.string_1, "System Att A Opcode Code:OpcodeS");
                    }
                    return 1;
                case 2:
                    Class6.smethod_0(2, "System AgentServer 已拦截一次攻击!", 0);
                    if (Class8.bool_66) {
                        Class7.smethod_2(class4_0.string_1, "System Att A Opcode Code:" + num + " Buffer:" + BitConverter.ToString(array));
                    }
                    else {
                        Class7.smethod_2(class4_0.string_1, "System Att A 0pcode Code:x2");
                    }
                    break;
            }
            switch (num) {
                case 24835:
                    if (array.Length <= 12) {
                        break;
                    }
                    try {
                        var class10 = new Class14(array);
                        class10.ReadBytes(6);
                        int int_7 = class10.ReadInt32();
                        string string_2 = class10.method_0();
                        string string_3 = class10.method_0();
                        byte byte_16 = class10.ReadByte();
                        string text3 = class10.method_2();
                        long num12 = 0L;
                        try {
                            if (class10.BaseStream.Length - class10.BaseStream.Position >= 8L) {
                                num12 = class10.ReadInt64();
                            }
                        }
                        catch {
                        }
                        if (Class9.smethod_9(string_2, 64) == 1) {
                            Class7.smethod_2(class4_0.string_1, "System Error A Login Check ErrorCode: 0001");
                            return 1;
                        }
                        if (class4_0.string_3 != "") {
                            Class7.smethod_2(class4_0.string_1, "System Error A Login Check ErrorCode: 0002");
                            return 1;
                        }
                        if (text3.IndexOf("---") == 0) {
                            Class7.smethod_2(class4_0.string_1, "System Error A Login Check ErrorCode: " + text3);
                            text3 = "00";
                        }
                        if (Class8.bool_65 && method_40(class4_0.string_0, text3)) {
                            class46_0.method_30(intptr_0, new byte[8] { 2, 0, 2, 161, 0, 0, 2, 8 }, 8);
                            return 1;
                        }
                        if (!method_41(text3)) {
                            return 1;
                        }
                        class4_0.string_3 = string_2;
                        class4_0.string_2 = text3;
                        class4_0.byte_4 = 1;
                        class4_0.long_0 = num12;
                        int_6++;
                        if (text3.IndexOf("-") == -1) {
                            byte byte_17 = array[4];
                            method_50(class4_0, byte_17, int_7, string_2, string_3, byte_16, new byte[6] { 1, 2, 3, 4, 5, 6 });
                            return 2;
                        }
                    }
                    catch {
                        Class7.smethod_2(class4_0.string_1, "System Error Us: 0002");
                    }
                    break;
                case 28673:
                    if (array.Length <= 8) {
                        break;
                    }
                    try {
                        if (class4_0.byte_4 != 1) {
                            Class7.smethod_2(class4_0.string_1, "System Error A Char NoLogin ErrorCode: 0001");
                            return 1;
                        }
                        if (class4_0.string_3 == "") {
                            Class7.smethod_2(class4_0.string_1, "System Error A Char NoLogin ErrorCode: 0002");
                            return 1;
                        }
                        string text4 = "";
						var class11 = new Class14(array);
						class11.ReadBytes(6);
                        text4 = class11.method_0();
                        if (Class9.smethod_9(text4, 64) == 1) {
                            Class7.smethod_2(class4_0.string_1, "System Error A Char Check ErrorCode: 0001");
                            return 1;
                        }
                        if (class4_0.string_4 != "") {
                            Class7.smethod_2(class4_0.string_1, "System Error A Char Check ErrorCode: 0002");
                            return 1;
                        }
                        if (!Class5.smethod_19(class4_0.string_3, text4)) {
                            Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Exists_UserID_CharName Code:False Param:" + class4_0.string_3 + " " + text4);
                            return 1;
                        }
                        class4_0.int_11 = Class9.smethod_0();
                        class4_0.string_4 = text4;
                        int num14 = Class5.smethod_75(text4, out string string_4);
                        if (num14 != 1) {
                            Class6.smethod_0(2, "SQL Error: SQL_Get_Char_NickName False", 0);
                            Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Get_Char_NickName Code:" + num14 + " Param:" + class4_0.string_4);
                        }
                        class4_0.string_5 = string_4;
                        if (Class8.bool_39 && class4_0.string_4 != "") {
                            class4_0.list_0.Add(new Struct6(0, "本服务器已启用智能助手,聊天框输入\"*小助手\"即可查看"));
                        }
						int num15 = Class5.smethod_25(text4, class4_0.string_0, class4_0.string_2, out string string_5);
						if (string_5 != "NULL" && class4_0.string_4 != "") {
                            class4_0.list_0.Add(new Struct6(0, string_5));
                        }
                        if (num15 != 1) {
                            Class6.smethod_0(2, "SQL Error: SQL_Event_CharLogin False", 0);
                            Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Event_CharLogin Code:" + num15 + " Param:" + class4_0.string_4);
                        }
                        else if (num15 == 2) {
                            list_1.Add(new Struct4(intptr_0, Class9.smethod_0(), 2000));
                        }
                        method_0(ref class4_0, text4);
                        if (Class8.bool_5 && class4_0.string_4 != "") {
                            class4_0.list_0.Add(new Struct6(0, Class8.string_9[0] + class4_0.string_4 + Class8.string_9[1]));
                        }
                        if (Class8.bool_37 && class4_0.string_4 != "") {
                            if (Class8.bool_36) {
                                if (!Class5.smethod_87(class4_0.string_3, class4_0.string_4)) {
                                    class4_0.list_0.Add(new Struct6(1, Class9.smethod_2(Class8.string_45)));
                                }
                            }
                            else {
                                class4_0.list_0.Add(new Struct6(1, Class9.smethod_2(Class8.string_45)));
                            }
                        }
                        int_6++;
                        if (Class8.bool_12) {
                            method_1(ref class4_0, ref int_6);
                        }
                        var struct4 = default(Struct18);
                        struct4.string_0 = class4_0.string_1;
                        struct4.string_1 = class4_0.string_0;
                        struct4.string_2 = class4_0.string_3;
                        struct4.string_3 = class4_0.string_4;
                        struct4.int_0 = class4_0.int_10;
                        struct4.string_4 = class4_0.string_2;
                        Class10.smethod_3(6, struct4);
                    }
                    catch {
                        Class7.smethod_2(class4_0.string_1, "System Error: 1703");
                    }
                    break;
                case 29008:
                    if (array.Length <= 10 || !Class8.bool_7 || class4_0.byte_4 != 2) {
                        break;
                    }
                    try {
                        var class14 = new Class14(array);
                        class14.ReadBytes(6);
                        byte b5 = class14.ReadByte();
                        byte b6 = class14.ReadByte();
                        if (b5 != 2 || (b6 != 3 && b6 != 17)) {
                            break;
                        }
                        byte b7 = class14.ReadByte();
                        if (b7 == 2 || b7 == 3) {
                            byte byte_37 = class14.ReadByte();
                            class14.ReadByte();
                            int num28 = Class9.smethod_37(intptr_0, class4_0.string_4, byte_37);
                            if (num28 == 1) {
                                byte byte_38 = array[4];
                                method_55(class4_0, 8194, byte_38);
                                class46_0.method_30(intptr_0, new byte[8] { 2, 0, 80, 177, 0, 0, 1, 1 }, 8);
                                Class9.smethod_27(intptr_0, Class8.string_11);
                                return 2;
                            }
                            if (num28 < 0 && num28 != -3) {
                                Class6.smethod_0(2, "SQL Error: Send_AlchemyLimit False", 0);
                                Class7.smethod_2(class4_0.string_1, "SQL Error: Send_AlchemyLimit Code:" + num28 + " Param:" + class4_0.string_4 + " " + byte_37);
                            }
                        }
                    }
                    catch {
                        Class7.smethod_2(class4_0.string_1, "System Error: 5704");
                    }
                    break;
                case 28748:
                    if (array.Length < 10 || class4_0.byte_4 != 2) {
                        break;
                    }
                    try {
                        var class13 = new Class14(array);
                        class13.ReadBytes(6);
                        byte b4 = class13.ReadByte();
                        short short_ = class13.ReadInt16();
                        if (b4 >= 13) {
							if (!method_14(short_, array, out byte byte_25, out byte byte_26, out byte byte_27, out byte byte_28, out byte byte_29)) {
								break;
							}
							if (byte_26 == 3 && byte_27 == 3 && byte_28 == 3 && byte_29 == 5) {
                                if (array.Length <= 17) {
                                    break;
                                }
								int num24 = Class5.smethod_72(class4_0.string_4, b4, out int num23);
								if (num24 == -100) {
                                    if (num23 != 0) {
                                        Class6.smethod_0(2, "SQL Error: SQL_Get_Char_Slot_Item_Info False", 0);
                                        Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Get_Char_Slot_Item_Info Code:" + num24 + " Param:" + class4_0.string_4 + " " + b4 + " " + num23);
                                    }
                                    else {
                                        Class6.smethod_0(2, "SQL Error: SQL_Get_Char_Slot_Item_Info False", 0);
                                        Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Get_Char_Slot_Item_Info Code:" + num24 + " Param:" + class4_0.string_4 + " " + b4 + " " + short_);
                                    }
                                }
                                if (!Class9.smethod_13(num23)) {
                                    break;
                                }
                                short short_2 = 0;
                                if (array[9] == 3 && array[10] == 5) {
                                    short_2 = class13.ReadInt16();
                                    if (Class8.bool_64) {
                                        class13.ReadByte();
                                    }
                                }
                                if (Class8.bool_6) {
                                    byte byte_30 = array[4];
                                    method_55(class4_0, 8194, byte_30);
                                    Class9.smethod_27(intptr_0, Class8.string_10);
                                    return 2;
                                }
                                if (Class8.bool_46) {
                                    for (int n = 0; n < Class5.list_12.Count; n++) {
                                        if (Class5.list_12[n].string_1 == class4_0.string_4) {
                                            byte byte_31 = array[4];
                                            method_55(class4_0, 8194, byte_31);
                                            return 2;
                                        }
                                    }
                                }
                                if (Class8.bool_14) {
                                    if (class4_0.int_8 == 0) {
                                        class4_0.int_8 = Class9.smethod_0();
                                        int_6++;
                                    }
                                    else {
                                        if ((Class9.smethod_0() - class4_0.int_8) / 1000 < Class8.int_13) {
                                            byte byte_32 = array[4];
                                            method_55(class4_0, 8194, byte_32);
                                            Class9.smethod_27(intptr_0, Class8.string_17);
                                            return 2;
                                        }
                                        class4_0.int_8 = Class9.smethod_0();
                                        int_6++;
                                    }
                                }
                                string text8 = class13.method_0();
                                if (!(text8 != "")) {
                                    break;
                                }
                                Class6.smethod_0(6, class4_0.string_4 + ":" + text8, 0);
                                var struct6 = default(Struct19);
                                struct6.string_0 = class4_0.string_1;
                                struct6.string_1 = class4_0.string_3;
                                struct6.string_2 = class4_0.string_4;
                                struct6.string_3 = text8;
                                Class10.smethod_3(5, struct6);
                                if (text8.Length >= 3) {
                                    byte byte_33 = array[4];
                                    int num25 = method_3(intptr_0, ref class4_0, byte_33, ref int_6, b4, short_, short_2, text8);
                                    if (num25 != 0) {
                                        return num25;
                                    }
                                }
                            }
                            else if (byte_26 == 3 && byte_27 == 3 && byte_28 == 3 && byte_29 == 3) {
                                if (array.Length >= 10 && !class4_0.bool_3) {
                                    byte byte_34 = array[4];
                                    method_55(class4_0, 8194, byte_34);
                                    return 2;
                                }
                            }
                            else if (byte_26 == 3 && byte_27 == 3 && byte_28 == 13 && byte_29 == 6) {
                                if (array.Length >= 10 && !class4_0.bool_4) {
                                    byte byte_35 = array[4];
                                    method_55(class4_0, 8194, byte_35);
                                    return 2;
                                }
                            }
                            else if (byte_26 == 3 && byte_27 == 3 && byte_28 == 3 && byte_29 == 2 && array.Length >= 10 && class13.ReadByte() >= 0) {
								int num26 = Class5.smethod_29(class4_0.string_4, class4_0.string_0, class4_0.string_2, b4, out string string_6);
								if (string_6 != "NULL" && !Class9.smethod_27(intptr_0, string_6)) {
                                    Class7.smethod_2(class4_0.string_1, "System Error A Send_Clinet_Notice: 11001");
                                }
                                switch (num26) {
                                    case 2:
                                        list_1.Add(new Struct4(intptr_0, Class9.smethod_0(), 300));
                                        break;
                                    case 3: {
                                        byte byte_36 = array[4];
                                        method_55(class4_0, 8194, byte_36);
                                        return 2;
                                    }
                                }
                            }
                            break;
                        }
                        Class7.smethod_2(class4_0.string_1, "System Error: 0173 " + short_);
                    }
                    catch {
                        Class7.smethod_2(class4_0.string_1, "System Error: 0073");
                    }
                    break;
                case 28801: {
                    if (array.Length <= 9 || !Class8.bool_13 || class4_0.byte_4 != 2) {
                        break;
                    }
                    int num29 = class4_0.int_5;
                    if (num29 == 0) {
                        class4_0.int_5 = Class9.smethod_0();
                        int_6++;
                    }
                    else if (num29 != 0) {
                        if ((Class9.smethod_0() - num29) / 1000 < Class8.int_12) {
                            byte byte_39 = array[4];
                            method_55(class4_0, 8194, byte_39);
                            Class9.smethod_27(intptr_0, Class8.string_16);
                            return 2;
                        }
                        class4_0.int_5 = Class9.smethod_0();
                        int_6++;
                    }
                    break;
                }
                case 28777:
                    if (array.Length > 6 && Class8.bool_8 && class4_0.byte_4 == 2) {
                        try {
                            class4_0.int_1 = Class9.smethod_0();
                            int_6++;
                        }
                        catch {
                            Class7.smethod_2(class4_0.string_1, "System Error: 0005");
                        }
                    }
                    break;
                case 28779:
                    if (array.Length <= 6 || !Class8.bool_8 || class4_0.byte_4 != 2) {
                        break;
                    }
                    try {
                        if (class4_0.int_1 != 0) {
                            class4_0.int_2 = Class9.smethod_0();
                            int num27 = (class4_0.int_2 - class4_0.int_1) / 60000;
                            class4_0.int_1 = 0;
                            class4_0.int_2 = 0;
                            int_6++;
                            var struct7 = default(Struct20);
                            struct7.intptr_0 = class4_0.intptr_0;
                            struct7.string_0 = class4_0.string_1;
                            struct7.string_1 = class4_0.string_3;
                            struct7.string_2 = class4_0.string_4;
                            struct7.int_0 = num27;
                            Class10.smethod_3(7, struct7);
                        }
                    }
                    catch {
                        Class7.smethod_2(class4_0.string_1, "System Error: 0006");
                    }
                    break;
                case 28849:
                    if (array.Length > 6 && Class8.bool_9 && class4_0.byte_4 == 2) {
                        try {
                            class4_0.int_3 = Class9.smethod_0();
                            int_6++;
                        }
                        catch {
                            Class7.smethod_2(class4_0.string_1, "System Error: 0007");
                        }
                    }
                    break;
                case 28850:
                    if (array.Length < 6 || !Class8.bool_9 || class4_0.byte_4 != 2) {
                        break;
                    }
                    try {
                        if (class4_0.int_3 != 0) {
                            class4_0.int_4 = Class9.smethod_0();
                            int num13 = (class4_0.int_4 - class4_0.int_3) / 60000;
                            if (num13 > 0) {
                                class4_0.int_3 = 0;
                                class4_0.int_4 = 0;
                                int_6++;
                                var struct3 = default(Struct21);
                                struct3.intptr_0 = class4_0.intptr_0;
                                struct3.string_1 = class4_0.string_0;
                                struct3.string_0 = class4_0.string_1;
                                struct3.string_4 = class4_0.string_2;
                                struct3.string_2 = class4_0.string_3;
                                struct3.string_3 = class4_0.string_4;
                                struct3.int_0 = num13;
                                struct3.int_1 = 0;
                                Class10.smethod_3(8, struct3);
                            }
                        }
                    }
                    catch {
                        Class7.smethod_2(class4_0.string_1, "System Error: 0008");
                    }
                    break;
                case 28724: {
                    if (array.Length < 8 || class4_0.byte_4 != 2) {
                        break;
                    }
                    var class12 = new Class14(array);
                    class12.ReadBytes(6);
                    switch (class12.ReadByte()) {
                        case 7:
                            if (Class8.bool_15) {
                                byte byte_23 = array[4];
                                method_55(class4_0, 8194, byte_23);
                                return 2;
                            }
                            break;
                        case 27:
                            if (Class8.bool_16) {
                                byte byte_19 = array[4];
                                method_55(class4_0, 8194, byte_19);
                                return 2;
                            }
                            break;
                        case 10:
                            if (array.Length < 15) {
                                break;
                            }
                            if (Class8.bool_48) {
                                byte byte_21 = array[4];
                                method_55(class4_0, 8194, byte_21);
                                return 2;
                            }
                            if (class4_0.int_15 == 0) {
                                class4_0.int_15 = Class9.smethod_0();
                                int_6++;
                                break;
                            }
                            if (Class9.smethod_0() - class4_0.int_15 < 60000) {
                                byte byte_22 = array[4];
                                method_55(class4_0, 8194, byte_22);
                                return 2;
                            }
                            class4_0.int_15 = Class9.smethod_0();
                            int_6++;
                            break;
                        case 19:
                            if (array.Length == 19 && Class8.bool_61) {
                                var now2 = DateTime.Now;
                                string text7 = now2.ToString("yyyy-MM-dd");
                                var dateTime3 = DateTime.Parse(text7 + " " + Class8.string_59);
                                var dateTime4 = DateTime.Parse(text7 + " " + Class8.string_60);
                                if (dateTime3 > dateTime4) {
                                    dateTime4 = dateTime4.AddDays(1.0);
                                }
                                if (now2 < dateTime3 || now2 > dateTime4) {
                                    Class9.smethod_27(intptr_0, Class8.string_61[0] + Class8.string_59 + Class8.string_61[1] + Class8.string_60 + Class8.string_61[2]);
                                    byte byte_24 = array[4];
                                    method_55(class4_0, 8194, byte_24);
                                    return 2;
                                }
                            }
                            break;
                        case 20:
                            if (array.Length == 18 && Class8.bool_61) {
                                var now = DateTime.Now;
                                string text6 = now.ToString("yyyy-MM-dd");
                                var dateTime = DateTime.Parse(text6 + " " + Class8.string_59);
                                var dateTime2 = DateTime.Parse(text6 + " " + Class8.string_60);
                                if (dateTime > dateTime2) {
                                    dateTime2 = dateTime2.AddDays(1.0);
                                }
                                if (now < dateTime || now > dateTime2) {
                                    Class9.smethod_27(intptr_0, Class8.string_61[0] + Class8.string_59 + Class8.string_61[1] + Class8.string_60 + Class8.string_61[2]);
                                    byte byte_20 = array[4];
                                    method_55(class4_0, 8194, byte_20);
                                    return 2;
                                }
                            }
                            break;
                        case 8:
                        case 24:
                            if (array.Length < 16 || array.Length < 29) {
                                break;
                            }
                            class4_0.int_13 = Class5.smethod_73(class4_0.string_3);
                            int_6++;
                            if (Class8.bool_64) {
                                class12.ReadInt32();
                                class12.ReadByte();
                                string text5 = class12.method_0();
                                ushort num16 = class12.ReadUInt16();
                                Class9.smethod_24(intptr_0);
								int num20 = Class5.smethod_20(class4_0.string_4, text5, num16, out int num17, out int num18, out int num19);
								if (num20 == 1) {
                                    int num21 = num17;
                                    int num22 = class4_0.int_13 - num21;
                                    class4_0.int_13 = 0;
                                    int_6++;
                                    var struct5 = default(Struct14);
                                    struct5.intptr_0 = class4_0.intptr_0;
                                    struct5.string_0 = class4_0.string_1;
                                    struct5.string_1 = class4_0.string_3;
                                    struct5.string_2 = class4_0.string_4;
                                    struct5.int_0 = num22;
                                    Class10.smethod_3(4, struct5);
                                    Class9.smethod_22(class4_0.intptr_0, num17, num18, num19);
                                    Class9.smethod_27(class4_0.intptr_0, Class8.string_44);
                                }
                                else {
                                    Class6.smethod_0(2, "SQL Error: SQL_Add_Game_MallBox_Item False", 0);
                                    Class7.smethod_2(class4_0.string_1, "SQL Error: SQL_Add_Game_MallBox_Item 2 Code:" + num20 + " Param:" + class4_0.string_4 + " " + text5 + " " + num16);
                                }
                                byte byte_18 = array[4];
                                method_55(class4_0, 8194, byte_18);
                                return 2;
                            }
                            break;
                    }
                    break;
                }
                default:
                    if (num == Class15.ushort_4) {
                        if (array.Length < 17) {
                            break;
                        }
                        var class5 = new Class14(array);
                        class5.ReadBytes(6);
                        class5.ReadBytes(4);
                        int num8 = class5.ReadInt32();
                        class5.ReadBytes(1);
                        if (num8 == 282 && Class9.smethod_9(class5.method_0(), 120) == 1) {
                            if (!Class9.smethod_15(class4_0.string_0)) {
                                Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                            }
                            Class6.smethod_0(2, "System AgentServer 已拦截一次已知攻击!", 0);
                            Class7.smethod_2(class4_0.string_1, "System Att A57 Opcode Code:x");
                            return 1;
                        }
                        break;
                    }
                    if (num == Class15.ushort_5) {
                        if (array.Length < 12 || class4_0.byte_4 != 2) {
                            break;
                        }
                        if (Class8.bool_39) {
                            try {
                                var class6 = new Class14(array);
                                class6.ReadBytes(6);
                                byte b = class6.ReadByte();
                                class6.ReadByte();
                                if (b == 1 || b == 2 || b == 3) {
                                    if (Class8.bool_64) {
                                        class6.ReadByte();
                                    }
                                    string text = class6.method_0();
                                    if (text != "") {
                                        string text2 = "";
                                        switch (b) {
                                            case 3:
                                                text2 = text;
                                                text = class4_0.string_4;
                                                break;
                                            case 1:
                                                text2 = text;
                                                text = class4_0.string_4;
                                                break;
                                            case 2:
                                                text2 = class6.method_0();
                                                break;
                                        }
                                        if (text2 != "" && text2.Length > 1 && text2.Substring(0, 1) == "*") {
                                            byte byte_2 = array[4];
                                            int num9 = method_2(intptr_0, ref class4_0, byte_2, ref int_6, b, text2, text);
                                            if (num9 != 0) {
                                                return num9;
                                            }
                                        }
                                    }
                                }
                            }
                            catch {
                            }
                        }
                        if (!Class8.bool_46) {
                            break;
                        }
                        for (int l = 0; l < Class5.list_12.Count; l++) {
                            if (Class5.list_12[l].string_1 == class4_0.string_4) {
                                byte byte_3 = array[4];
                                method_55(class4_0, 8194, byte_3);
                                return 2;
                            }
                        }
                        break;
                    }
                    switch (num) {
                        case 29816:
                            if (array.Length != 10 || class4_0.byte_4 != 2) {
                                break;
                            }
                            if (Class8.bool_41) {
                                byte byte_11 = array[4];
                                method_55(class4_0, 8194, byte_11);
                                return 2;
                            }
                            if (Class8.bool_40) {
                                bool flag4;
                                if (!(flag4 = Class9.smethod_16(intptr_0))) {
                                    Class6.smethod_0(2, "SQL Error: Send_Clinet_TrainingCampList False", 0);
                                    Class7.smethod_2(class4_0.string_1, "SQL Error: Send_Clinet_TrainingCampList Code:" + flag4 + " Param:" + class4_0.string_4);
                                }
                                byte byte_12 = array[4];
                                method_55(class4_0, 8194, byte_12);
                                return 2;
                            }
                            break;
                        case 29818:
                            if (array.Length >= 10 && class4_0.byte_4 == 2 && Class8.bool_41) {
                                byte byte_8 = array[4];
                                method_55(class4_0, 8194, byte_8);
                                return 2;
                            }
                            break;
                        case 29808:
                            if (array.Length >= 10 && class4_0.byte_4 == 2 && Class8.bool_41) {
                                byte byte_13 = array[4];
                                method_55(class4_0, 8194, byte_13);
                                return 2;
                            }
                            break;
                        case 29822:
                            if (array.Length >= 10 && class4_0.byte_4 == 2 && Class8.bool_41) {
                                byte byte_9 = array[4];
                                method_55(class4_0, 8194, byte_9);
                                return 2;
                            }
                            break;
                        case 29810:
                            if (array.Length >= 10 && class4_0.byte_4 == 2 && Class8.bool_41) {
                                byte byte_14 = array[4];
                                method_55(class4_0, 8194, byte_14);
                                return 2;
                            }
                            break;
                        case 28788: {
                            if (array.Length < 13 || class4_0.byte_4 != 2) {
                                break;
                            }
                            var class7 = new Class14(array);
                            class7.ReadBytes(6);
                            byte b2 = class7.ReadByte();
                            byte b3 = class7.ReadByte();
                            if (class4_0.bool_5 && DateTime.Now > class4_0.dateTime_0) {
                                return 1;
                            }
                            if (b2 == 1 && b3 == 4) {
                                if (!Class8.bool_51) {
                                    break;
                                }
                                int num10 = class7.ReadInt32();
                                if (num10 <= 0) {
                                    break;
                                }
                                int num11 = Class9.smethod_41(num10);
                                if (num11 == 0) {
                                    num11 = Class9.smethod_42(num10);
                                }
                                if (num11 <= 0) {
                                    break;
                                }
                                for (int m = 0; m < class4_0.list_1.Count; m++) {
                                    var struct2 = class4_0.list_1[m];
                                    if (struct2.int_1 <= 0) {
                                        continue;
                                    }
                                    if (struct2.int_3 == num11) {
                                        if (Class9.smethod_0() - struct2.int_1 <= struct2.int_2) {
                                            byte byte_5 = array[4];
                                            method_55(class4_0, 8194, byte_5);
                                            Class9.smethod_26(intptr_0, 68);
                                            return 2;
                                        }
                                    }
                                    else if (struct2.int_3 == 0 && struct2.int_4 == num11 && Class9.smethod_0() - struct2.int_1 <= struct2.int_2) {
                                        byte byte_6 = array[4];
                                        method_55(class4_0, 8194, byte_6);
                                        Class9.smethod_26(intptr_0, 68);
                                        return 2;
                                    }
                                }
                            }
                            else if (b2 == 1 && b3 == 3 && array.Length == 13 && (Class8.bool_60 || !class4_0.bool_2) && class7.ReadByte() == 1) {
                                byte byte_7 = array[4];
                                method_55(class4_0, 8194, byte_7);
                                return 2;
                            }
                            break;
                        }
                        case 28899: {
                            if (array.Length < 14 || class4_0.byte_4 != 2) {
                                break;
                            }
                            var class9 = new Class14(array);
                            class9.ReadBytes(6);
                            if (class9.ReadInt32() > 0 && class9.ReadByte() == 1) {
                                string string_ = class9.method_0();
                                if (Class9.smethod_9(string_, 64) == 1) {
                                    Class7.smethod_2(class4_0.string_1, "System Error A SetNickName Check ErrorCode: 0001");
                                    return 1;
                                }
                                if (class4_0.string_4 == "") {
                                    Class7.smethod_2(class4_0.string_1, "System Error A SetNickName Check ErrorCode: 0002");
                                    return 1;
                                }
                                class4_0.string_5 = string_;
                                int_6++;
                            }
                            break;
                        }
                        case 12484:
                            if (array.Length == 10 && class4_0.byte_4 == 2 && (Class8.bool_59 || !class4_0.bool_1)) {
                                byte byte_15 = array[4];
                                method_55(class4_0, 8194, byte_15);
                                return 2;
                            }
                            break;
                        case 28762:
                            if (array.Length != 15) {
                            }
                            break;
                        case 29023: {
                            if (array.Length < 15 || class4_0.byte_4 != 2) {
                                break;
                            }
                            var class8 = new Class14(array);
                            class8.ReadBytes(6);
                            if (class8.ReadInt32() <= 0 || class8.ReadInt32() <= 0) {
                                break;
                            }
                            switch (class8.ReadByte()) {
                                case 2:
                                case 3:
                                case 7:
                                    if (!class4_0.bool_3) {
                                        byte byte_10 = array[4];
                                        method_55(class4_0, 8194, byte_10);
                                        return 2;
                                    }
                                    break;
                            }
                            break;
                        }
                        case 28688:
                            if (array.Length == 8 && class4_0.byte_4 == 1 && !Class5.smethod_10(class4_0.string_3)) {
                                byte byte_4 = array[4];
                                method_55(class4_0, 8194, byte_4);
                                return 2;
                            }
                            break;
                    }
                    break;
            }
        }
        return 0;
    }

    public void method_6(IntPtr intptr_0, ref Class4 class4_0, byte[] byte_0, ref int int_6) {
        lock (object_0) {
            long_1 += byte_0.Length;
        }
        byte[] byte_ = class4_0.byte_0;
        if (byte_ != null && byte_.Length > 65535) {
            class48_0.method_39(intptr_0);
            return;
        }
        new List<byte[]>();
        byte[] array = null;
        if (byte_ != null) {
            int num = 0;
            byte[] array2 = Class1.smethod_12(byte_, byte_0);
            if (array2.Length < 6) {
                class4_0.byte_0 = array2;
                int_6++;
                byte_ = array2;
                return;
            }
            num = Class17.smethod_6(array2, 0) - byte_.Length;
            if (byte_0.Length < num) {
                class4_0.byte_0 = array2;
                int_6++;
                byte_ = array2;
                return;
            }
            class4_0.byte_0 = null;
            int_6++;
            byte_ = null;
            array = array2;
        }
        else if (byte_0.Length < 6) {
            class4_0.byte_0 = byte_0;
            int_6++;
            byte_ = byte_0;
            return;
        }
        if (array == null) {
            array = byte_0;
        }
        ushort num2 = Class17.smethod_6(array, 0);
        if (num2 == array.Length) {
            method_4(intptr_0, ref class4_0, array, ref int_6);
        }
        else if (num2 > array.Length) {
            class4_0.byte_0 = array;
            int_6++;
            byte_ = array;
        }
        else {
            if (num2 >= array.Length) {
                return;
            }
            while (true) {
                if (array.Length != 0) {
                    if (array.Length < 6) {
                        break;
                    }
                    num2 = Class17.smethod_6(array, 0);
                    if (num2 <= array.Length) {
                        byte[] byte_2 = Class1.smethod_14(array, num2);
                        array = Class1.smethod_13(array, array.Length - num2);
                        method_4(intptr_0, ref class4_0, byte_2, ref int_6);
                        continue;
                    }
                    class4_0.byte_0 = array;
                    int_6++;
                    byte_ = array;
                    return;
                }
                return;
            }
            class4_0.byte_0 = array;
            int_6++;
            byte_ = array;
        }
    }

    public int method_7(IntPtr intptr_0, ref Class4 class4_0, byte[] byte_0, out byte[] byte_1, ref int int_6) {
        if (Class8.bool_66) {
            var @struct = default(Struct17);
            @struct.string_0 = class4_0.string_3;
            @struct.string_1 = DateTime.Now.ToString() + "\t" + class4_0.byte_4 + "\tIP:" + class4_0.string_1 + "\tAgentServerRecv:(" + byte_0.Length + ")\t" + BitConverter.ToString(byte_0);
            Class10.smethod_3(9, @struct);
        }
        int num = 0;
        if (byte_0.Length >= 2) {
            int num2 = BitConverter.ToUInt16(byte_0, 0);
            if (num2 > 0) {
                num = Class15.Get_OpcodeAttack(num2, byte_0.Length);
                if (num == 1) {
                    byte_1 = null;
                    return 1;
                }
                if (num == 2) {
                    byte_1 = null;
                    return 1;
                }
                if (num < 65535) {
                    byte[] bytes = BitConverter.GetBytes(num);
                    class46_0.method_30(intptr_0, bytes, 4);
                }
            }
        }
        lock (object_1) {
            long_0 += byte_0.Length;
        }
        byte_1 = byte_0;
        if (Class8.bool_0 && byte_0.Length >= Class8.int_31) {
            if (Class9.smethod_0() - class4_0.int_7 < Class8.int_32) {
                if (class4_0.int_6 > Class8.int_33) {
                    if (!Class9.smethod_15(class4_0.string_0)) {
                        Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                    }
                    Class6.smethod_0(2, "System AgentServer 扫描到一次未知攻击,类型:Speed", 0);
                    Class7.smethod_2(class4_0.string_1, "System Att A Count Code:Speed " + class4_0.int_6);
                    class4_0.int_6 = 0;
                    class4_0.int_7 = Class9.smethod_0();
                    int_6++;
                    return 1;
                }
                class4_0.int_6++;
                class4_0.int_7 = Class9.smethod_0();
                int_6++;
            }
            else {
                class4_0.int_7 = Class9.smethod_0();
                class4_0.int_6 = 0;
                int_6++;
            }
        }
        byte[] byte_2 = class4_0.byte_1;
        int num3 = 0;
        var list = new List<byte[]>();
        byte[] array = null;
        if (byte_2 != null) {
            int num4 = 0;
            byte[] array2 = Class1.smethod_12(byte_2, byte_0);
            if (array2.Length < 6) {
                class4_0.byte_1 = array2;
                int_6++;
                byte_2 = array2;
                return 0;
            }
            num4 = Class17.smethod_6(array2, 0) - byte_2.Length;
            if (byte_0.Length < num4) {
                class4_0.byte_1 = array2;
                int_6++;
                byte_2 = array2;
                return 0;
            }
            class4_0.byte_1 = null;
            int_6++;
            byte_2 = null;
            array = array2;
        }
        else if (byte_0.Length < 6) {
            class4_0.byte_1 = byte_0;
            int_6++;
            byte_2 = byte_0;
            return 0;
        }
        if (array == null) {
            array = byte_0;
        }
        ushort num5 = Class17.smethod_6(array, 0);
        if (num5 == array.Length) {
            num3 = method_5(intptr_0, ref class4_0, array, ref int_6);
            if (num3 == 2) {
                list.Add(array);
            }
        }
        else {
            if (num5 > array.Length) {
                class4_0.byte_1 = array;
                int_6++;
                byte_2 = array;
                return 0;
            }
            if (num5 < array.Length) {
                int num6 = 0;
                while (array.Length != 0) {
                    if (array.Length >= 6) {
                        num5 = Class17.smethod_6(array, 0);
                        if (num5 <= array.Length) {
                            num6++;
                            if (num6 <= Class8.int_34) {
                                byte[] array3 = Class1.smethod_14(array, num5);
                                array = Class1.smethod_13(array, array.Length - num5);
                                num3 = method_5(intptr_0, ref class4_0, array3, ref int_6);
                                switch (num3) {
                                    case 2:
                                        list.Add(array3);
                                        continue;
                                    default:
                                        continue;
                                    case 1:
                                        break;
                                }
                            }
                            else {
                                if (!Class9.smethod_15(class4_0.string_0)) {
                                    Class7.smethod_2(class4_0.string_1, "System Error:Add_BlockedIP");
                                }
								Class6.smethod_0(2, "System AgentServer 扫描到一次未知攻击,类型:Max", 0);
								Class7.smethod_2(class4_0.string_1, "System A Type:MAX " + num6);
								Class6.smethod_0(2, "攻击IP:" + class4_0.string_1 + " 接收:(" + byte_0.Length + ")" + "类型:" + num6, 0);



								num3 = 1;
                            }
                            break;
                        }
                        class4_0.byte_1 = array;
                        int_6++;
                        byte_2 = array;
                        return 0;
                    }
                    class4_0.byte_1 = array;
                    int_6++;
                    byte_2 = array;
                    return 0;
                }
            }
        }
        switch (num3) {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                if (list.Count > 0) {
                    for (int i = 0; i < list.Count; i++) {
                        byte[] byte_3 = list[i];
                        byte_1 = Class1.smethod_11(byte_1, byte_3);
                    }
                }
                return 2;
            default:
                return num3;
        }
    }



    public bool method_19(byte[] byte_0) {
        try {
            var list = method_61();
            if (list != null && list.Count > 0) {
                for (int i = 0; i < list.Count; i++) {
                    if (list[i].byte_4 == 2 && !Class12.class3_0.class46_0.method_30(list[i].intptr_0, byte_0, byte_0.Length)) {
                        return false;
                    }
                }
            }
            return true;
        }
        catch {
            return false;
        }
    }

    public bool method_20(string string_3) {
        try {
            Class6.smethod_0(6, "公告:" + string_3, 0);
            var list = method_61();
            if (list != null && list.Count > 0) {
                for (int i = 0; i < list.Count; i++) {
                    if (list[i].byte_4 == 2 && !Class9.smethod_27(list[i].intptr_0, string_3)) {
                        return false;
                    }
                }
            }
            return true;
        }
        catch {
            return false;
        }
    }



    public bool method_27(IntPtr intptr_0, int int_6, string string_3 = "") {
        try {
            if (!Class9.smethod_21(intptr_0, int_6)) {
                return false;
            }
            if (string_3 != "") {
                Class9.smethod_27(intptr_0, string_3);
            }
            return true;
        }
        catch {
            return false;
        }
    }

    [CompilerGenerated]
    public ushort method_28() {
        return ushort_0;
    }

    [CompilerGenerated]
    public void method_29(ushort ushort_2) {
        ushort_0 = ushort_2;
    }

    [CompilerGenerated]
    public string method_30() {
        return string_1;
    }

    [CompilerGenerated]
    public void method_31(string string_3) {
        string_1 = string_3;
    }

    [CompilerGenerated]
    public ushort method_32() {
        return ushort_1;
    }

    [CompilerGenerated]
    public void method_33(ushort ushort_2) {
        ushort_1 = ushort_2;
    }

    public Class3() {
        class46_0.method_14(vmethod_6);
        class46_0.method_10(vmethod_8);
        class46_0.method_12(vmethod_9);
        class46_0.method_16(vmethod_10);
        class46_0.method_20(vmethod_11);
        class46_0.method_22(vmethod_7);
        class46_0.method_64(Class15.Center_Get_Socket_Length());
        class46_0.method_84(Enum4.const_2);
        class48_0.method_10(vmethod_0);
        class48_0.method_6(vmethod_1);
        class48_0.method_8(vmethod_3);
        class48_0.method_12(vmethod_4);
        class48_0.method_16(vmethod_5);
        class48_0.method_18(vmethod_2);
        class48_0.method_66(Class15.Center_Get_Socket_Length());
        class48_0.method_84(Enum4.const_2);
        timer_1.Interval = 1.0;
        timer_1.Elapsed += timer_1_Elapsed;
        timer_1.Start();
        timer_2.Interval = 1.0;
        timer_2.Elapsed += timer_2_Elapsed;
        timer_2.Start();
        timer_0.Interval = 1000.0;
        timer_0.Elapsed += timer_0_Elapsed;
        timer_0.Start();
    }

    private void timer_0_Elapsed(object sender, ElapsedEventArgs e) {
        if (!Class8.bool_0 || !bool_1) {
            return;
        }
        lock (object_7) {
            int num = 0;
            while (true) {
                if (num < list_0.Count) {
                    if (Class9.smethod_0() - list_0[num].int_0 > 10000) {
                        break;
                    }
                    num++;
                    continue;
                }
                return;
            }
            list_0.RemoveAt(num);
        }
    }

    private void timer_1_Elapsed(object sender, ElapsedEventArgs e) {
        try {
            for (int i = 0; i < list_3.Count; i++) {
                class46_0.method_40(list_3[i]);
            }
            if (list_3.Count > 0) {
                list_3.Clear();
            }
        }
        catch {
        }
    }

    private void timer_2_Elapsed(object sender, ElapsedEventArgs e) {
        try {
            int num = 0;
            while (true) {
                if (num < list_1.Count) {
                    if (Class9.smethod_0() - list_1[num].int_0 >= list_1[num].int_1) {
                        break;
                    }
                    num++;
                    continue;
                }
                return;
            }
            class46_0.method_40(list_1[num].intptr_0);
            list_1.RemoveAt(num);
        }
        catch {
            list_1.Clear();
        }
    }
    public bool method_21(string string_3)
    {
        try
        {
            Class10.smethod_3(16, string_3);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool method_22(int int_6, string string_3)
    {
        try
        {
            var list = method_61();
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].string_4 != string_3 && list[i].byte_4 == 2)
                    {
                        Class9.smethod_18(list[i].intptr_0, list[i].string_4, int_6, bool_0: true);
                    }
                }
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    public int method_23(string string_3, string string_4)
    {
        try
        {
            var list = method_61();
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].byte_4 == 2 && list[i].string_4 == string_3)
                    {
                        if (!Class9.smethod_27(list[i].intptr_0, string_4))
                        {
                            return -2;
                        }
                        return 1;
                    }
                }
            }
            return -3;
        }
        catch
        {
            return -4;
        }
    }

    public int method_24(string string_3, int int_6, byte byte_0, bool bool_2)
    {
        try
        {
            var list = method_61();
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].byte_4 == 2 && list[i].string_4 == string_3)
                    {
                        int num = Class9.smethod_19(list[i].intptr_0, string_3, int_6, byte_0, bool_2);
                        if (num != 1)
                        {
                            return num;
                        }
                        return 1;
                    }
                }
            }
            if (bool_2)
            {
                int num2 = Class5.smethod_54(string_3, int_6);
                if (num2 < 0)
                {
                    return -20000 + num2;
                }
                num2 = Class5.smethod_63("Sys.Ret.Char_Silk", string_3, byte_0, int_6, num2);
                if (num2 != 1)
                {
                    return -30000 + num2;
                }
                return 1;
            }
            int num3 = Class5.smethod_61(string_3, int_6);
            if (num3 < 0)
            {
                return -20000 + num3;
            }
            num3 = Class5.smethod_63("Sys.Ret.Char_Silk", string_3, byte_0, int_6, num3);
            if (num3 != 1)
            {
                return -30000 + num3;
            }
            return 1;
        }
        catch
        {
            return -20000;
        }
    }
    private bool method_65(IntPtr intptr_0, bool bool_2)
    {
        try
        {
            lock (object_6)
            {
                if (list_4.Count > 0)
                {
                    int num = 0;
                    while (true)
                    {
                        if (num < list_4.Count)
                        {
                            var @class = list_4[num];
                            var zero = IntPtr.Zero;
                            zero = ((!bool_2) ? @class.intptr_1 : @class.intptr_0);
                            if (zero == intptr_0)
                            {
                                break;
                            }
                            num++;
                            continue;
                        }
                        return false;
                    }
                    list_4.RemoveAt(num);
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

    private bool method_66(IntPtr intptr_0, Class4 class4_0, bool bool_2)
    {
        try
        {
            lock (object_6)
            {
                if (list_4.Count > 0)
                {
                    int num = 0;
                    while (true)
                    {
                        if (num < list_4.Count)
                        {
                            var @class = list_4[num];
                            var zero = IntPtr.Zero;
                            zero = ((!bool_2) ? @class.intptr_1 : @class.intptr_0);
                            if (zero == intptr_0)
                            {
                                break;
                            }
                            num++;
                            continue;
                        }
                        return false;
                    }
                    list_4[num] = class4_0;
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

    private bool method_67(IntPtr intptr_0, ref Class4 class4_0, bool bool_2)
    {
        try
        {
            lock (object_6)
            {
                class4_0 = new Class4();
                if (list_4.Count > 0)
                {
                    int num = 0;
                    while (true)
                    {
                        if (num < list_4.Count)
                        {
                            var @class = list_4[num];
                            var zero = IntPtr.Zero;
                            zero = ((!bool_2) ? @class.intptr_1 : @class.intptr_0);
                            if (zero == intptr_0)
                            {
                                break;
                            }
                            num++;
                            continue;
                        }
                        if (Class8.bool_69)
                        {
                            Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A AgentGetConnectionExtra 1 Close");
                        }
                        return false;
                    }
                    class4_0 = list_4[num];
                    return true;
                }
                if (Class8.bool_69)
                {
                    Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A AgentGetConnectionExtra 2 Close");
                }
                return false;
            }
        }
        catch
        {
            if (Class8.bool_69)
            {
                Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A AgentGetConnectionExtra 3 Close");
            }
            return false;
        }
    }

    private bool method_68(Class4 class4_0)
    {
        try
        {
            list_4.Add(class4_0);
            return true;
        }
        catch
        {
            return false;
        }
    }

    private bool method_69(IntPtr intptr_0, bool bool_2)
    {
        try
        {
            if (list_4.Count > 0)
            {
                int num = 0;
                while (true)
                {
                    if (num < list_4.Count)
                    {
                        var @class = list_4[num];
                        var zero = IntPtr.Zero;
                        zero = ((!bool_2) ? @class.intptr_1 : @class.intptr_0);
                        if (zero == intptr_0)
                        {
                            break;
                        }
                        num++;
                        continue;
                    }
                    return false;
                }
                list_4.RemoveAt(num);
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    private bool method_70(IntPtr intptr_0, Class4 class4_0, bool bool_2)
    {
        try
        {
            if (list_4.Count > 0)
            {
                int num = 0;
                while (true)
                {
                    if (num < list_4.Count)
                    {
                        var @class = list_4[num];
                        var zero = IntPtr.Zero;
                        zero = ((!bool_2) ? @class.intptr_1 : @class.intptr_0);
                        if (zero == intptr_0)
                        {
                            break;
                        }
                        num++;
                        continue;
                    }
                    return false;
                }
                list_4[num] = class4_0;
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    private bool method_71(IntPtr intptr_0, ref Class4 class4_0, bool bool_2)
    {
        try
        {
            class4_0 = new Class4();
            if (list_4.Count > 0)
            {
                int num = 0;
                while (true)
                {
                    if (num < list_4.Count)
                    {
                        var @class = list_4[num];
                        var zero = IntPtr.Zero;
                        zero = ((!bool_2) ? @class.intptr_1 : @class.intptr_0);
                        if (zero == intptr_0)
                        {
                            break;
                        }
                        num++;
                        continue;
                    }
                    if (Class8.bool_69)
                    {
                        Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A AgentGetConnectionExtra_NotLock 1 Close");
                    }
                    return false;
                }
                class4_0 = list_4[num];
                return true;
            }
            if (Class8.bool_69)
            {
                Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A AgentGetConnectionExtra_NotLock 2 Close");
            }
            return false;
        }
        catch
        {
            if (Class8.bool_69)
            {
                Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A AgentGetConnectionExtra_NotLock 3 Close");
            }
            return false;
        }
    }

    public int method_25(string string_3, int int_6, byte byte_0, bool bool_2, bool bool_3, string string_4 = "")
    {
        try
        {
            var list = method_61();
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].byte_4 == 2 && list[i].string_4 == string_3)
                    {
                        int num = Class9.smethod_19(list[i].intptr_0, string_3, int_6, byte_0, bool_2);
                        if (num != 1)
                        {
                            return num;
                        }
                        if (string_4 != "")
                        {
                            Class9.smethod_27(list[i].intptr_0, string_4);
                        }
                        return 1;
                    }
                }
            }
            if (!bool_3)
            {
                int num2 = Class9.smethod_20(string_3, int_6, byte_0, bool_2);
                if (num2 != 1)
                {
                    return num2;
                }
                return 1;
            }
            return -3;
        }
        catch
        {
            return -4;
        }
    }

    public bool method_26(string string_3, int int_6, out IntPtr intptr_0, string string_4 = "")
    {
        intptr_0 = IntPtr.Zero;
        try
        {
            var list = method_61();
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].byte_4 == 2 && list[i].string_4 == string_3)
                    {
                        if (!Class9.smethod_21(list[i].intptr_0, int_6))
                        {
                            return false;
                        }
                        if (string_4 != "")
                        {
                            Class9.smethod_27(list[i].intptr_0, string_4);
                        }
                        intptr_0 = list[i].intptr_0;
                        return true;
                    }
                }
            }
            return false;
        }
        catch
        {
            return false;
        }
    }
    public bool method_34() {
        string value = "0.0.0.0";
        if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(method_30()) && method_28() != 0 && method_32() != 0) {
            class46_0.method_7(value);
            class46_0.method_9(method_28());
            bool result;
            if (!(result = class46_0.method_27())) {
                return result;
            }
            return result = class48_0.method_23(value, bool_1: false);
        }
        throw new Exception("请先设置属性[BindAddr,TargetAddr,BindPort,TargetPort,AddMsgDelegate]");
    }

    public bool method_35() {
        if (class46_0.method_28()) {
            return class48_0.method_24();
        }
        return false;
    }

    public bool method_36(IntPtr intptr_0, bool bool_2 = true) {
        return class46_0.method_40(intptr_0, bool_2);
    }

    protected virtual Enum2 vmethod_0(IntPtr intptr_0, IntPtr intptr_1) {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_1(IntPtr intptr_0) {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_2() {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_3(IntPtr intptr_0, byte[] byte_0) {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_4(IntPtr intptr_0, byte[] byte_0) {
        try {
            var class4_ = new Class4();
            if (!method_67(intptr_0, ref class4_, bool_2: false)) {
                return Enum2.const_2;
            }
            int int_ = 0;
            method_6(intptr_0, ref class4_, byte_0, ref int_);
            if (int_ > 0 && !method_66(intptr_0, class4_, bool_2: false)) {
                Class7.smethod_2(class4_.string_1, "System Error A C UpdCun Set ErrorCode: 0001");
            }
            if (!class46_0.method_30(class4_.intptr_0, byte_0, byte_0.Length)) {
                return Enum2.const_2;
            }
        }
        catch {
        }
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_5(IntPtr intptr_0, Enum3 enum3_0, int int_6) {
        try {
            var class4_ = new Class4();
            lock (object_6) {
                if (!method_71(intptr_0, ref class4_, bool_2: false)) {
                    return Enum2.const_2;
                }
                if (Class8.bool_69) {
                    Class7.smethod_2(class4_.string_1, "ConnId:" + class4_.intptr_0.ToString() + " FreeType:" + class4_.uint_0 + " System Exit A Client Close");
                }
                if (class4_.uint_0 == 0) {
                    class4_.uint_0 = 1u;
                    if (!method_70(intptr_0, class4_, bool_2: false)) {
                        return Enum2.const_2;
                    }
                    class46_0.method_40(class4_.intptr_0);
                }
                else if (class4_.uint_0 == 2) {
                    method_69(intptr_0, bool_2: false);
                }
            }
        }
        catch {
        }
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_6(Class46 class46_1, IntPtr intptr_0) {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_7(Class46 class46_1) {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_8(Class46 class46_1, IntPtr intptr_0, IntPtr intptr_1) {
        try {
            if (!bool_0) {
                return Enum2.const_2;
            }
            string empty = string.Empty;
            ushort num = 0;
            if (!class46_0.method_47(intptr_0, ref empty, ref num)) {
                return Enum2.const_2;
            }
            if (empty.Length < 7) {
                return Enum2.const_2;
            }
            lock (object_4) {
                long_2++;
                method_63();
            }
            if (Class8.bool_54 && method_42(empty)) {
                return Enum2.const_2;
            }
            if (Class8.bool_0 && bool_1) {
                lock (object_7) {
                    if (list_0.Count > 0) {
                        for (int i = 0; i < list_0.Count; i++) {
                            if (list_0[i].string_0 == empty) {
                                list_0.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
            }
            if (string_0 != empty && string_0 != "" && empty != Class8.string_2) {
                return Enum2.const_2;
            }
            if (method_37(empty)) {
                return Enum2.const_2;
            }
            lock (object_6) {
                var intptr_2 = IntPtr.Zero;
                if (!class48_0.method_25(method_30(), method_32(), ref intptr_2) && !class48_0.method_25(method_30(), method_32(), ref intptr_2) && !class48_0.method_25(method_30(), method_32(), ref intptr_2)) {
                    return Enum2.const_2;
                }
                var @class = new Class4();
                @class.intptr_0 = intptr_0;
                @class.intptr_1 = intptr_2;
                @class.uint_0 = 0u;
                @class.string_2 = "";
                @class.string_0 = empty;
                @class.string_1 = empty + ":" + num;
                @class.string_4 = "";
                @class.string_5 = "";
                @class.string_3 = "";
                @class.byte_0 = null;
                @class.byte_1 = null;
                @class.byte_2 = null;
                @class.uint_1 = 0u;
                @class.uint_2 = 0u;
                @class.int_0 = 0;
                @class.int_1 = 0;
                @class.int_2 = 0;
                @class.int_3 = 0;
                @class.int_4 = 0;
                @class.list_0 = new List<Struct6>();
                @class.int_5 = 0;
                @class.byte_4 = 0;
                @class.int_6 = 0;
                @class.int_7 = Class9.smethod_0();
                @class.int_9 = 0;
                @class.int_8 = 0;
                @class.int_10 = 0;
                @class.int_11 = 0;
                @class.int_12 = 0;
                @class.int_13 = 0;
                @class.bool_0 = false;
                @class.int_14 = 0;
                @class.list_1 = new List<Struct13>(Class5.list_13);
                @class.bool_1 = true;
                @class.bool_2 = true;
                @class.bool_4 = true;
                @class.bool_3 = true;
                @class.int_15 = 0;
                @class.bool_5 = false;
                @class.long_0 = 0L;
                @class.dateTime_0 = DateTime.Now;
                if (!method_68(@class)) {
                    return Enum2.const_2;
                }
            }
            if (Class8.bool_69) {
                Class7.smethod_2(empty, "ConnId:" + intptr_0 + " FreeType:0 System Exit A Accept");
            }
            return Enum2.const_0;
        }
        catch {
            return Enum2.const_2;
        }
    }

    protected virtual Enum2 vmethod_9(Class46 class46_1, IntPtr intptr_0, byte[] byte_0) {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_10(Class46 class46_1, IntPtr intptr_0, byte[] byte_0) {
        try {
            var class4_ = new Class4();
            if (!method_67(intptr_0, ref class4_, bool_2: true)) {
                return Enum2.const_2;
            }
            byte[] byte_ = new byte[0];
            int int_ = 0;
            int num = method_7(intptr_0, ref class4_, byte_0, out byte_, ref int_);
            if (int_ > 0 && !method_66(intptr_0, class4_, bool_2: true)) {
                Class7.smethod_2(class4_.string_1, "System Error A S UpdCun Set ErrorCode: 0001");
            }
            switch (num) {
                case 0:
                    if (!class48_0.method_29(class4_.intptr_1, byte_0, byte_0.Length)) {
                        return Enum2.const_2;
                    }
                    break;
                case 1:
                    list_3.Add(intptr_0);
                    return Enum2.const_0;
                case 2:
                    if (byte_.Length != 0 && !class48_0.method_29(class4_.intptr_1, byte_, byte_.Length)) {
                        return Enum2.const_2;
                    }
                    break;
                case 3:
                    list_1.Add(new Struct4(intptr_0, Class9.smethod_0(), 300));
                    return Enum2.const_0;
            }
            return Enum2.const_0;
        }
        catch {
            return Enum2.const_2;
        }
    }

    protected virtual Enum2 vmethod_11(Class46 class46_1, IntPtr intptr_0, Enum3 enum3_0, int int_6) {
        try {
            var class4_ = new Class4();
            lock (object_6) {
                if (!method_71(intptr_0, ref class4_, bool_2: true)) {
                    return Enum2.const_2;
                }
                if (Class8.bool_9) {
                    method_62(class4_, 1);
                }
                if (class4_.byte_4 == 2 || class4_.byte_4 == 3) {
                    lock (object_5) {
                        long_3++;
                    }
                    Class7.smethod_2(class4_.string_1, "Try Exit");
                }
                if (class4_.string_3 != "" && class4_.string_4 != "") {
                    var @struct = default(Struct32);
                    @struct.intptr_0 = class4_.intptr_0;
                    @struct.string_0 = class4_.string_1;
                    @struct.string_1 = class4_.string_3;
                    @struct.string_2 = class4_.string_4;
                    Class10.smethod_3(13, @struct);
                }
                if (Class8.bool_66 || Class8.bool_69) {
                    if (class4_.uint_0 == 2) {
                        Class7.smethod_2(class4_.string_1, "ConnId:" + class4_.intptr_0.ToString() + " FreeType:" + class4_.uint_0 + " System Exit A User Close");
                    }
                    else if (class4_.uint_0 == 1) {
                        Class7.smethod_2(class4_.string_1, "ConnId:" + class4_.intptr_0.ToString() + " FreeType:" + class4_.uint_0 + " System Exit A Server Close");
                    }
                    else {
                        Class7.smethod_2(class4_.string_1, "ConnId:" + class4_.intptr_0.ToString() + " FreeType:" + class4_.uint_0 + " System Exit A Try Close");
                    }
                }
                if (class4_.uint_0 == 0) {
                    class4_.uint_0 = 2u;
                    if (!method_70(intptr_0, class4_, bool_2: true)) {
                        return Enum2.const_2;
                    }
                    class48_0.method_39(class4_.intptr_1);
                }
                else if (class4_.uint_0 == 1) {
                    method_69(intptr_0, bool_2: true);
                }
            }
        }
        catch {
        }
        return Enum2.const_0;
    }

    public bool method_37(string string_3) {
        try {
            if (class46_0.method_51() <= 100000) {
                lock (Class13.object_1) {
                    int num = 0;
                    while (true) {
                        if (num >= Class13.list_0.Count) {
                            return false;
                        }
                        var @struct = Class13.list_0[num];
                        if (@struct.byte_0 == 1 && @struct.byte_1 == 0 && @struct.string_1 == string_3) {
                            break;
                        }
                        num++;
                    }
                    return true;
                }
            }
            return true;
        }
        catch {
            return false;
        }
    }

    public ushort method_38(string string_3) {
        try {
            var list = method_61();
            if (list.Count > 0) {
                ushort num = 0;
                for (int i = 0; i < list.Count; i++) {
                    if (list[i].string_0 == string_3) {
                        num = (ushort)(num + 1);
                    }
                }
                return num;
            }
            return 0;
        }
        catch {
            return 0;
        }
    }

    public ushort method_39(string string_3) {
        try {
            var list = method_61();
            if (list.Count > 0) {
                ushort num = 0;
                for (int i = 0; i < list.Count; i++) {
                    if (string_3 == list[i].string_2) {
                        num = (ushort)(num + 1);
                    }
                }
                return num;
            }
            return 0;
        }
        catch {
            return 0;
        }
    }

    public bool method_40(string string_3, string string_4) {
        try {
            int num = 0;
            while (true) {
                if (num < Class5.list_10.Count) {
                    if (Class5.list_10[num].byte_1 == 0) {
                        if (Class5.list_10[num].string_1 == string_3) {
                            return false;
                        }
                    }
                    else if (Class5.list_10[num].byte_1 == 1 && Class5.list_10[num].string_1 == string_4) {
                        break;
                    }
                    num++;
                    continue;
                }
                if (Class12.class3_0.method_39(string_4) >= Class8.ushort_14) {
                    return true;
                }
                return false;
            }
            return false;
        }
        catch {
            return false;
        }
    }

    public bool method_41(string string_3) {
        try {
            int num = 0;
            while (true) {
                if (num < Class5.list_5.Count) {
                    if (Class5.list_5[num].byte_1 == 1 && Class5.list_5[num].string_1 == string_3) {
                        break;
                    }
                    num++;
                    continue;
                }
                return true;
            }
            return false;
        }
        catch {
            return false;
        }
    }



    public bool method_50(Class4 class4_0, byte byte_0, int int_6, string string_3, string string_4, byte byte_1, byte[] byte_2) {
        var @class = new Class21();
        @class.Write(int_6);
        @class.method_1(string_3);
        @class.method_1(string_4);
        @class.Write(byte_1);
        @class.Write(byte_2);
        return method_53(class4_0, 24835, byte_0, @class.method_0());
    }

    public bool method_51(Class4 class4_0, byte byte_0, int int_6) {
        var @class = new Class21();
        @class.Write((ushort)6);
        @class.Write(int_6);
        @class.Write((ushort)0);
        return method_53(class4_0, 28688, byte_0, @class.method_0());
    }

    public bool method_52(Class4 class4_0, byte byte_0, string string_3) {
        var @class = new Class21();
        @class.Write((ushort)8);
        @class.method_1(string_3);
        return method_53(class4_0, 28688, byte_0, @class.method_0());
    }

    public bool method_53(Class4 class4_0, ushort ushort_2, byte byte_0, byte[] byte_1) {
        try {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_2);
            @class.Write((ushort)0);
            @class.Write(byte_1);
            byte[] array = @class.method_0();
            byte[] bytes = BitConverter.GetBytes((ushort)byte_1.Length);
            array[0] = bytes[0];
            array[1] = bytes[1];
            array[4] = byte_0;
            array[5] = Class17.smethod_5(class4_0.uint_1, array);
            return class48_0.method_29(class4_0.intptr_1, array, array.Length);
        }
        catch {
            return false;
        }
    }

    public bool method_54(Class4 class4_0, ushort ushort_2, byte byte_0, bool bool_2, byte[] byte_1) {
        try {
            if (bool_2) {
                var @class = new Class21();
                @class.Write((ushort)0);
                @class.Write(ushort_2);
                @class.Write((ushort)0);
                @class.Write(byte_1);
                byte[] array = @class.method_0();
                byte[] bytes = BitConverter.GetBytes((ushort)byte_1.Length);
                bytes[1] = (byte)(bytes[1] + 128);
                array[0] = bytes[0];
                array[1] = bytes[1];
                array[4] = byte_0;
                array[5] = Class17.smethod_5(class4_0.uint_1, array);
                byte[] array2 = new byte[array.Length - 2];
                Array.Copy(array, 2, array2, 0, array2.Length);
                var class2 = new Class16();
                class2.method_0(class4_0.byte_2);
                byte[] byte_2 = class2.method_2(array2);
                array = Class1.smethod_12(bytes, byte_2);
                return class48_0.method_29(class4_0.intptr_1, array, array.Length);
            }
            var class3 = new Class21();
            class3.Write((ushort)0);
            class3.Write(ushort_2);
            class3.Write((ushort)0);
            class3.Write(byte_1);
            byte[] array3 = class3.method_0();
            byte[] bytes2 = BitConverter.GetBytes((ushort)byte_1.Length);
            array3[0] = bytes2[0];
            array3[1] = bytes2[1];
            array3[4] = byte_0;
            array3[5] = Class17.smethod_5(class4_0.uint_1, array3);
            return class48_0.method_29(class4_0.intptr_1, array3, array3.Length);
        }
        catch {
            return false;
        }
    }

    public bool method_55(Class4 class4_0, ushort ushort_2, byte byte_0) {
        try {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_2);
            @class.Write((ushort)0);
            byte[] array = @class.method_0();
            array[4] = byte_0;
            array[5] = Class17.smethod_5(class4_0.uint_1, array);
            return class48_0.method_29(class4_0.intptr_1, array, array.Length);
        }
        catch {
            return false;
        }
    }

    public bool method_56(IntPtr intptr_0, uint uint_0, ushort ushort_2, byte byte_0) {
        try {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_2);
            @class.Write((ushort)0);
            byte[] array = @class.method_0();
            array[4] = byte_0;
            array[5] = Class17.smethod_5(uint_0, array);
            return class48_0.method_29(intptr_0, array, array.Length);
        }
        catch {
            return false;
        }
    }

    public bool method_57(long long_4) {
        var list = method_61();
        for (int i = 0; i < list.Count; i++) {
            if (long_4 == list[i].long_0) {
                if (!list[i].bool_5) {
                    var @class = list[i];
                    int num = random_1.Next(Class2.int_2, Class2.int_3);
                    @class.dateTime_0 = DateTime.Now.AddMinutes(num);
                    @class.bool_5 = true;
                    method_66(list[i].intptr_0, @class, bool_2: true);
                }
                break;
            }
        }
        return true;
    }

    public int method_58() {
        lock (object_8) {
            return list_2.Count();
        }
    }

    public bool method_59(List<Struct2> list_6) {
        lock (object_8) {
            list_2 = list_6;
            return true;
        }
    }

    public bool method_60(string string_3) {
        if (Class8.bool_0 && bool_1) {
            lock (object_7) {
                list_0.Add(new Struct3(string_3));
            }
        }
        return true;
    }

    private void method_63() {
        if (int_2 == 0) {
            int_2 = Class9.smethod_0();
        }
        else {
            if (Class9.smethod_0() - int_2 < 100) {
                if (int_3 == 0) {
                    int_3 = Class9.smethod_0();
                    int_4 = 1;
                }
                else if (Class9.smethod_0() - int_3 > 60000) {
                    int_3 = Class9.smethod_0();
                    int_4 = 1;
                }
                else {
                    int_3 = Class9.smethod_0();
                    int_4++;
                }
            }
            else if (int_4 >= 100 && Class9.smethod_0() - int_3 > 600000) {
                int_3 = 0;
                int_4 = 0;
            }
            int_2 = Class9.smethod_0();
        }
        if (!bool_1) {
            if (int_4 >= 100) {
                bool_1 = true;
                Class6.smethod_0(1, "防火墙已启用：检测到代理类攻击已开始", 0);
            }
        }
        else if (int_4 < 100) {
            bool_1 = false;
            Class6.smethod_0(1, "防火墙已停用：检测到代理类攻击已停止", 0);
        }
    }
    public bool method_42(string string_3)
    {
        try
        {
            int num = 0;
            while (true)
            {
                if (num < Class5.list_10.Count)
                {
                    if (Class5.list_10[num].byte_1 == 0 && Class5.list_10[num].string_1 == string_3)
                    {
                        break;
                    }
                    num++;
                    continue;
                }
                if (Class12.class3_0.method_38(string_3) >= Class8.ushort_14)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    public bool method_43(IntPtr intptr_0, ushort ushort_2, byte[] byte_0)
    {
        try
        {
            var @class = new Class21();
            @class.Write((ushort)byte_0.Length);
            @class.Write(ushort_2);
            @class.Write((ushort)0);
            @class.Write(byte_0);
            if (class46_0.method_30(intptr_0, @class.method_0(), @class.method_0().Length))
            {
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    public bool method_44(out int int_6, out int int_7, out int int_8, out int int_9, out int int_10)
    {
        int_6 = 0;
        int_7 = 0;
        int_8 = 0;
        int_9 = 0;
        int_10 = 0;
        try
        {
            int num = 0;
            int num2 = 0;
            var list = method_61();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].byte_4 == 2)
                {
                    if (list[i].string_2.IndexOf("-") > -1)
                    {
                        int_9++;
                    }
                    int_10++;
                }
            }
            int_8 = list.Count;
            int_6 = num;
            int_7 = num2;
            return true;
        }
        catch
        {
            return false;
        }
    }

    public List<Struct29> method_45()
    {
        try
        {
            var list = new List<Struct29>();
            var list2 = method_61();
            if (list2 != null && list2.Count > 0)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    var item = default(Struct29);
                    item.string_1 = list2[i].string_4;
                    item.intptr_0 = list2[i].intptr_0;
                    item.byte_0 = list2[i].byte_4;
                    item.string_2 = list2[i].string_5;
                    item.string_0 = list2[i].string_3;
                    item.int_0 = list2[i].int_10;
                    item.int_1 = list2[i].int_11;
                    item.string_3 = list2[i].string_2;
                    item.string_5 = list2[i].string_1;
                    item.string_4 = list2[i].string_0;
                    list.Add(item);
                }
            }
            return list;
        }
        catch
        {
            return new List<Struct29>();
        }
    }

    public bool method_46(IntPtr intptr_0, Class4 class4_0, ushort ushort_2, byte byte_0, byte byte_1, short short_0, string string_3)
    {
        try
        {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_2);
            @class.Write((ushort)0);
            @class.Write(byte_1);
            @class.Write(short_0);
            @class.method_1(string_3);
            byte[] array = @class.method_0();
            byte[] bytes = BitConverter.GetBytes((ushort)array.Length - 6);
            array[0] = bytes[0];
            array[1] = (byte)(bytes[1] + 128);
            array[4] = byte_0;
            array[5] = Class17.smethod_5(class4_0.uint_1, array);
            var class2 = new Class16();
            class2.method_0(class4_0.byte_2);
            byte[] array2 = class2.method_3(array, 2, array.Length - 2);
            byte[] array3 = new byte[array2.Length + 2];
            Array.Copy(array2, 0, array3, 2, array2.Length);
            array3[0] = bytes[0];
            array3[1] = (byte)(bytes[1] + 128);
            class48_0.method_29(class4_0.intptr_1, array3, array3.Length);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool method_47(IntPtr intptr_0, Class4 class4_0, ushort ushort_2, byte byte_0, byte byte_1, short short_0, short short_1, string string_3)
    {
        try
        {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_2);
            @class.Write((ushort)0);
            @class.Write(byte_1);
            @class.Write(short_0);
            @class.Write(short_1);
            @class.method_1(string_3);
            byte[] array = @class.method_0();
            byte[] bytes = BitConverter.GetBytes((ushort)array.Length - 6);
            array[0] = bytes[0];
            array[1] = (byte)(bytes[1] + 128);
            array[4] = byte_0;
            array[5] = Class17.smethod_5(class4_0.uint_1, array);
            var class2 = new Class16();
            class2.method_0(class4_0.byte_2);
            byte[] array2 = class2.method_3(array, 2, array.Length - 2);
            byte[] array3 = new byte[array2.Length + 2];
            Array.Copy(array2, 0, array3, 2, array2.Length);
            array3[0] = bytes[0];
            array3[1] = (byte)(bytes[1] + 128);
            class48_0.method_29(class4_0.intptr_1, array3, array3.Length);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool method_48(IntPtr intptr_0, Class4 class4_0, ushort ushort_2, byte byte_0, byte byte_1, short short_0, short short_1, string string_3)
    {
        try
        {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_2);
            @class.Write((ushort)0);
            @class.Write(byte_1);
            @class.Write(short_0);
            @class.Write(short_1);
            @class.Write((byte)0);
            @class.method_1(string_3);
            byte[] array = @class.method_0();
            byte[] bytes = BitConverter.GetBytes((ushort)array.Length - 6);
            array[0] = bytes[0];
            array[1] = (byte)(bytes[1] + 128);
            array[4] = byte_0;
            array[5] = Class17.smethod_5(class4_0.uint_1, array);
            var class2 = new Class16();
            class2.method_0(class4_0.byte_2);
            byte[] array2 = class2.method_3(array, 2, array.Length - 2);
            byte[] array3 = new byte[array2.Length + 2];
            Array.Copy(array2, 0, array3, 2, array2.Length);
            array3[0] = bytes[0];
            array3[1] = (byte)(bytes[1] + 128);
            class48_0.method_29(class4_0.intptr_1, array3, array3.Length);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool method_49(Class4 class4_0, byte byte_0, byte byte_1, byte byte_2, float float_0, float float_1, float float_2, ushort ushort_2)
    {
        var @class = new Class21();
        @class.Write((ushort)16);
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.Write(float_0);
        @class.Write(float_1);
        @class.Write(float_2);
        @class.Write(ushort_2);
        return method_53(class4_0, 28688, byte_0, @class.method_0());
    }
    private bool method_64(Class4 class4_0) {
        try {
            lock (object_6) {
                list_4.Add(class4_0);
                return true;
            }
        }
        catch {
            return false;
        }
    }


    public List<Class4> method_61() {
        if (Class9.smethod_0() - int_5 > 500) {
            lock (object_6) {
                list_5 = new List<Class4>();
                if (list_4 != null && list_4.Count > 0) {
                    for (int i = 0; i < list_4.Count; i++) {
                        var @class = new Class4();
                        @class.intptr_0 = list_4[i].intptr_0;
                        @class.intptr_1 = list_4[i].intptr_1;
                        @class.uint_0 = list_4[i].uint_0;
                        @class.string_0 = list_4[i].string_0;
                        @class.string_1 = list_4[i].string_1;
                        @class.string_2 = list_4[i].string_2;
                        @class.string_3 = list_4[i].string_3;
                        @class.string_4 = list_4[i].string_4;
                        @class.string_5 = list_4[i].string_5;
                        @class.byte_0 = list_4[i].byte_0;
                        @class.byte_1 = list_4[i].byte_1;
                        @class.byte_2 = list_4[i].byte_2;
                        @class.uint_1 = list_4[i].uint_1;
                        @class.byte_3 = list_4[i].byte_3;
                        @class.uint_2 = list_4[i].uint_2;
                        @class.int_0 = list_4[i].int_0;
                        @class.int_1 = list_4[i].int_1;
                        @class.int_2 = list_4[i].int_2;
                        @class.int_3 = list_4[i].int_3;
                        @class.int_4 = list_4[i].int_4;
                        @class.list_0 = list_4[i].list_0;
                        @class.int_5 = list_4[i].int_5;
                        @class.int_6 = list_4[i].int_6;
                        @class.int_7 = list_4[i].int_7;
                        @class.byte_4 = list_4[i].byte_4;
                        @class.int_8 = list_4[i].int_8;
                        @class.int_9 = list_4[i].int_9;
                        @class.int_10 = list_4[i].int_10;
                        @class.int_11 = list_4[i].int_11;
                        @class.int_12 = list_4[i].int_12;
                        @class.int_13 = list_4[i].int_13;
                        @class.bool_0 = list_4[i].bool_0;
                        @class.int_14 = list_4[i].int_14;
                        @class.list_1 = list_4[i].list_1;
                        @class.bool_1 = list_4[i].bool_1;
                        @class.bool_2 = list_4[i].bool_2;
                        @class.bool_4 = list_4[i].bool_4;
                        @class.bool_3 = list_4[i].bool_3;
                        @class.int_15 = list_4[i].int_15;
                        @class.dateTime_0 = list_4[i].dateTime_0;
                        @class.long_0 = list_4[i].long_0;
                        @class.bool_5 = list_4[i].bool_5;
                        list_5.Add(@class);
                    }
                }
                int_5 = Class9.smethod_0();
            }
        }
        return list_5;
    }
}
