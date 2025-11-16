using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal class Class9 {
    public static int smethod_0() {
        return Environment.TickCount & 0x7FFFFFFF;
    }

    public static bool smethod_1(string string_0, byte byte_0, string string_1, string string_2, long long_0, byte byte_1) {
        try {
            switch (byte_0) {
                case 0:
                    if (Class5.smethod_12(string_0, byte_0, string_1, string_2, long_0, byte_1, 0) == 1) {
                        Class12.class3_0.method_21(Class8.string_47[0] + string_0 + Class8.string_47[1] + string_2 + Class8.string_47[2] + long_0 + Class8.string_47[3]);
                        break;
                    }
                    return false;
                case 1:
                    if (Class5.smethod_12(string_0, byte_0, string_1, string_2, long_0, byte_1, 0) == 1) {
                        Class12.class3_0.method_21(Class8.string_48[0] + string_0 + Class8.string_48[1] + long_0 + Class8.string_48[2]);
                        break;
                    }
                    return false;
                case 2:
                    if (Class5.smethod_12(string_0, byte_0, string_1, string_2, long_0, byte_1, 0) == 1) {
                        Class12.class3_0.method_21(Class8.string_49[0] + string_0 + Class8.string_49[1] + long_0 + Class8.string_49[2]);
                        break;
                    }
                    return false;
            }
            return true;
        }
        catch {
            return false;
        }
    }

    public static string smethod_2(string string_0) {
        try {
            string text = string_0.Replace("/n/", Environment.NewLine);
            string text2 = "";
            text2 = ((!Class8.bool_64) ? "-----------------------------------------------------   " : "\t   ");
            if (text.IndexOf(Environment.NewLine) == -1 && Encoding.Default.GetByteCount(text) <= 57) {
                return text2 + text;
            }
            string[] array = text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            if (array != null && array.Length != 0) {
                for (int i = 0; i < array.Length; i++) {
                    int byteCount = Encoding.Default.GetByteCount(array[i]);
                    if (byteCount > 57) {
                        int num = byteCount / 57 + 1;
                        num *= 57;
                        string text3 = array[i];
                        while (Encoding.Default.GetByteCount(text3) != num) {
                            text3 += " ";
                        }
                        text2 += text3;
                    }
                    else {
                        string text4 = array[i];
                        while (Encoding.Default.GetByteCount(text4) != 57) {
                            text4 += " ";
                        }
                        text2 += text4;
                    }
                }
            }
            if (Class8.bool_64) {
                return text2;
            }
            return text2 + "------------------------------------------------------";
        }
        catch {
            return "";
        }
    }

    public static string smethod_3(string string_0, int int_0, int int_1, int int_2 = 0) {
        try {
            string text = "";
            text = ((!Class8.bool_64) ? "-----------------------------------------------------   " : "\t   ------------------------------------------------------   ");
            string[] array = string_0.Split(new string[1] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            if (array != null && array.Length != 0) {
                for (int i = 0; i < array.Length; i++) {
                    string[] array2 = array[i].Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (array2 != null && array2.Length >= int_0) {
                        text = text ?? "";
                        string text2 = array2[0];
                        while (Encoding.Default.GetByteCount(text2) != 57) {
                            text2 = ((Encoding.Default.GetByteCount(text2) >= int_1) ? ((Encoding.Default.GetByteCount(text2) != int_1) ? ((int_0 < 3 || int_2 <= 0 || Encoding.Default.GetByteCount(text2) != int_2) ? (text2 + " ") : (text2 + array2[2])) : (text2 + array2[1])) : (text2 + " "));
                        }
                        text += text2;
                    }
                }
            }
            if (Class8.bool_64) {
                return text + "------------------------------------------------------   ";
            }
            return text + "------------------------------------------------------";
        }
        catch {
            return "";
        }
    }
    public static int smethod_41(int int_0)
    {
        int num = 0;
        while (true)
        {
            if (num < Class5.list_13.Count)
            {
                if (int_0 == Class5.list_13[num].int_0)
                {
                    break;
                }
                num++;
                continue;
            }
            return -1000;
        }
        return Class5.list_13[num].int_3;
    }

    public static int smethod_42(int int_0)
    {
        int num = 0;
        while (true)
        {
            if (num < Class5.list_13.Count)
            {
                if (int_0 == Class5.list_13[num].int_0)
                {
                    break;
                }
                num++;
                continue;
            }
            return -1000;
        }
        return Class5.list_13[num].int_4;
    }

    public static string smethod_43()
    {
        if (Class8.bool_55)
        {
            return Class8.string_33[0] + Class8.string_55 + Class8.string_33[1] + Class13.int_1 + Class8.string_33[2];
        }
        return Class8.string_33[0] + "抢红包" + Class8.string_33[1] + Class13.int_1 + Class8.string_33[2];
    }

    public static string smethod_44(string string_0)
    {
        try
        {
            if (Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault((IPAddress ipaddress_0) => ipaddress_0.AddressFamily.ToString().Equals("InterNetwork")).ToString() == string_0)
            {
                return string_0;
            }
        }
        catch
        {
        }
        try
        {
            var addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            if (addressList != null)
            {
                for (int i = 0; i < addressList.Length; i++)
                {
                    if (addressList[i].ToString() == string_0)
                    {
                        return string_0;
                    }
                }
            }
            return "0.0.0.0";
        }
        catch
        {
            return "0.0.0.0";
        }
    }

    public static string smethod_45(string string_0)
    {
        try
        {
            string[] array = string_0.Split(new string[1] { ":" }, StringSplitOptions.RemoveEmptyEntries);
            if (array != null)
            {
                if (array.Length == 2)
                {
                    return array[0];
                }
                return "0.0.0.0";
            }
            return "0.0.0.0";
        }
        catch
        {
            return "0.0.0.0";
        }
    }

    public static void smethod_46(string string_0)
    {
        var list_ = new List<string>();
        smethod_47(string_0, string_0, ref list_);
        if (list_.Count <= 0)
        {
            return;
        }
        for (int i = 0; i < list_.Count; i++)
        {
            try
            {
                File.Delete(list_[i]);
            }
            catch
            {
            }
        }
    }

    public static void smethod_47(string string_0, string string_1, ref List<string> list_0)
    {
        var files = new DirectoryInfo(string_0).GetFiles("*.Cmsd");
        for (int i = 0; i < files.Length; i++)
        {
            list_0.Add(files[i].FullName);
        }
        var directories = new DirectoryInfo(string_0).GetDirectories();
        for (int j = 0; j < directories.Length; j++)
        {
            smethod_47(directories[j].FullName, string_1, ref list_0);
        }
    }

    public static int smethod_48()
    {
        try
        {
            var processesByName = Process.GetProcessesByName("Qiangweidiewu");
            if (processesByName.Length == 0)
            {
                return -2;
            }
            var array = processesByName;
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Kill();
            }
            return 1;
        }
        catch
        {
            return -1;
        }
    }

    public static bool smethod_49(Class14 class14_0, out bool bool_0)
    {
        bool_0 = false;
        try
        {
            int num = class14_0.ReadInt32();
            int num2 = 0;
            while (true)
            {
                if (num2 < num)
                {
                    string text = class14_0.method_0();
                    int count = class14_0.ReadInt32();
                    byte[] bytes = class14_0.ReadBytes(count);
                    string text2 = Environment.CurrentDirectory + "\\" + text;
                    if (File.Exists(text2))
                    {
                        if (text2.IndexOf("\\Sql\\") > -1)
                        {
                            File.Move(text2, text2 + "_" + smethod_0() + ".Bak");
                        }
                        else
                        {
                            File.Move(text2, text2 + "_" + smethod_0() + ".Cmsd");
                        }
                        File.WriteAllBytes(text2, bytes);
                    }
                    else
                    {
                        if (!smethod_50(text2))
                        {
                            break;
                        }
                        File.WriteAllBytes(text2, bytes);
                    }
                    num2++;
                    continue;
                }
                if (class14_0.ReadByte() == 1)
                {
                    bool_0 = true;
                }
                if (class14_0.ReadByte() == 1)
                {
                    smethod_48();
                }
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    public static bool smethod_50(string string_0)
    {
        try
        {
            string[] array = string_0.Split(new string[1] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            string text = "";
            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    text = text + array[i] + "\\";
                }
            }
            if (Directory.Exists(text))
            {
                return true;
            }
            Directory.CreateDirectory(text);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool smethod_51(Class14 class14_0, out byte[] byte_0)
    {
        byte_0 = new byte[0];
        try
        {
            var list = new List<Struct52>();
            int num = class14_0.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                string string_ = class14_0.method_0();
                string text = class14_0.method_0();
                string text2 = class14_0.method_0();
                string path = Environment.CurrentDirectory + "\\" + text;
                if (File.Exists(path))
                {
                    string text3 = smethod_52(File.ReadAllBytes(path));
                    if (text3.ToUpper() != text2.ToUpper())
                    {
                        list.Add(new Struct52(string_, text, text3));
                    }
                }
                else
                {
                    list.Add(new Struct52(string_, text, text2));
                }
            }
            if (list.Count > 0)
            {
                var @class = new Class21();
                @class.Write(list.Count);
                for (int j = 0; j < list.Count; j++)
                {
                    @class.method_1(list[j].string_0);
                    @class.method_1(list[j].string_1);
                    @class.method_1(list[j].string_2);
                }
                byte_0 = @class.method_0();
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    public static string smethod_52(byte[] byte_0)
    {
        using (var mD = MD5.Create())
        {
            byte[] array = mD.ComputeHash(byte_0);
            string text = "";
            for (int i = 0; i < array.Length; i++)
            {
                text += array[i].ToString("X2");
            }
            return text;
        }
    }
    public static byte[] smethod_4(string string_0) {
        try {
            string[] array = string_0.Split(new string[1] { "-" }, StringSplitOptions.RemoveEmptyEntries);
            byte[] array2 = new byte[array.Length];
            for (int i = 0; i < array.Length; i++) {
                array2[i] = Convert.ToByte(array[i], 16);
            }
            return array2;
        }
        catch {
            return null;
        }
    }

    public static int smethod_5(int int_0) {
        try {
            int num = 0;
            while (true) {
                if (num < Class5.list_6.Count) {
                    if (Class5.list_6[num].int_1 == int_0) {
                        break;
                    }
                    num++;
                    continue;
                }
                return 0;
            }
            return Class5.list_6[num].int_2;
        }
        catch {
            return 0;
        }
    }


    public static bool smethod_23(IntPtr intptr_0, int int_0, byte byte_0, byte byte_1, ushort ushort_0) {
        try {
            var @class = new Class21();
            @class.Write((byte)1);
            @class.Write((byte)24);
            @class.Write(int_0);
            @class.Write(byte_0);
            @class.Write((byte)1);
            @class.Write(byte_1);
            @class.Write(ushort_0);
            @class.Write(0);
            byte[] byte_2 = @class.method_0();
            return Class12.class3_0.method_43(intptr_0, 45108, byte_2);
        }
        catch {
            return false;
        }
    }

    public static bool smethod_24(IntPtr intptr_0) {
        try {
            var @class = new Class21();
            @class.Write((byte)2);
            @class.Write((byte)0);
            @class.Write((byte)24);
            byte[] byte_ = @class.method_0();
            return Class12.class3_0.method_43(intptr_0, 45108, byte_);
        }
        catch {
            return false;
        }
    }
    public static int smethod_37(IntPtr intptr_0, string string_0, byte byte_0)
    {
        try
        {
            int num = Class5.smethod_72(string_0, byte_0, out int int_);
            if (num > 0)
            {
                int num2 = 0;
                while (true)
                {
                    if (num2 < Class5.list_4.Count)
                    {
                        var @struct = Class5.list_4[num2];
                        if (@struct.int_1 == int_ && num >= @struct.byte_0)
                        {
                            break;
                        }
                        num2++;
                        continue;
                    }
                    Class5.smethod_24(int_, out string string_);
                    if (string_ != "")
                    {
                        if (Class8.bool_30 && num >= Class8.byte_5)
                        {
                            if (string_.IndexOf("_SWORD_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_BLADE_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_SPEAR_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_TBLADE_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_BOW_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_DAGGER_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_TSWORD_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_AXE_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_CROSSBOW_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_DARKSTAFF_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_TSTAFF_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_HARP_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_STAFF_") > -1)
                            {
                                return 1;
                            }
                        }
                        if (Class8.bool_33 && num >= Class8.byte_8 && string_.IndexOf("_SHIELD_") > -1)
                        {
                            return 1;
                        }
                        if (Class8.bool_31 && num >= Class8.byte_6)
                        {
                            if (string_.IndexOf("_HEAVY_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_CLOTHES_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_LIGHT_") > -1)
                            {
                                return 1;
                            }
                        }
                        if (Class8.bool_32 && num >= Class8.byte_7)
                        {
                            if (string_.IndexOf("_RING_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_EARRING_") > -1)
                            {
                                return 1;
                            }
                            if (string_.IndexOf("_NECKLACE_") > -1)
                            {
                                return 1;
                            }
                        }
                    }
                    return 2;
                }
                return 1;
            }
            if (num < 0)
            {
                return num;
            }
            return 3;
        }
        catch
        {
            return -1100;
        }
    }

    public static bool smethod_38()
    {
        try
        {
            int num = 0;
            int num2 = 0;
            string text = Application.StartupPath + "\\Sql";
            var directoryInfo = new DirectoryInfo(text);
            var files = directoryInfo.GetFiles();
            int num3 = 0;
            string[] array;
            while (true)
            {
                if (num3 < files.Length)
                {
                    string name = files[num3].Name;
                    array = name.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries);
                    if (array.Length == 3 && array[2] == "sql" && array[0] == "Tab")
                    {
                        if (Class5.smethod_102(array[1]))
                        {
                            string string_2 = Class5.smethod_18(array[1]);
                            string string_3 = File.ReadAllText(text + "\\" + name, Encoding.Default);
                            if (smethod_40(array[1], string_3, string_2, out string string_))
                            {
                                if (!Class5.smethod_111(string_))
                                {
                                    Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Tab:" + array[1] + " 状态：修复失败");
                                    return false;
                                }
                                Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Tab:" + array[1] + " 状态：修复成功");
                                num++;
                            }
                            else
                            {
                                Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Tab:" + array[1] + " 状态：正常");
                                num2++;
                            }
                        }
                        else
                        {
                            string text2 = File.ReadAllText(text + "\\" + name, Encoding.Default);
                            text2 = text2.Replace("SRO_VT_SHARD", Class8.string_5);
                            text2 = text2.Replace("SRO_VT_ACCOUNT", Class8.string_6);
                            text2 = text2.Replace("SRO_VT_SHARDLOG", Class8.string_4);
                            if (!(text2 != ""))
                            {
                                break;
                            }
                            if (!Class5.smethod_111(text2))
                            {
                                Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Tab:" + array[1] + " 状态：创建失败");
                                return false;
                            }
                            Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Tab:" + array[1] + " 状态：创建成功");
                            num++;
                        }
                    }
                    num3++;
                    continue;
                }
                string text3 = "";
                files = directoryInfo.GetFiles();
                for (num3 = 0; num3 < files.Length; num3++)
                {
                    string name2 = files[num3].Name;
                    string[] array2 = name2.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries);
                    if (array2.Length == 3 && array2[2] == "sql" && array2[0] == "Exe" && Class5.smethod_103(array2[1]))
                    {
                        string text4 = Class5.smethod_17(array2[1]);
                        string text5 = File.ReadAllText(text + "\\" + name2, Encoding.Default);
                        text5 = text5.Replace("SRO_VT_SHARD", Class8.string_5);
                        text5 = text5.Replace("SRO_VT_ACCOUNT", Class8.string_6);
                        text5 = text5.Replace("SRO_VT_SHARDLOG", Class8.string_4);
                        if (text4.ToUpper() != text5.ToUpper())
                        {
                            text3 = text3 + array2[1] + Environment.NewLine;
                        }
                    }
                }
                if (text3 != "" && MessageBox.Show("检测到刺陵防御数据库内部分数据与Sql文件夹内文件数据不同步！" + Environment.NewLine + "检测到有改动的储存过程:" + Environment.NewLine + text3 + "如您的自定义储存过程或者表有重要内容，请先备份刺陵防御数据库." + Environment.NewLine + "继续进行升级覆盖操作吗？", "覆盖警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Priority 用户中止操作");
                    return false;
                }
                if (File.Exists(text + "\\Exe._Update_Database.sql") && Class5.smethod_103("_Update_Database"))
                {
                    string text6 = Class5.smethod_17("_Update_Database");
                    string text7 = File.ReadAllText(text + "\\Exe._Update_Database.sql", Encoding.Default);
                    text7 = text7.Replace("SRO_VT_SHARD", Class8.string_5);
                    text7 = text7.Replace("SRO_VT_ACCOUNT", Class8.string_6);
                    text7 = text7.Replace("SRO_VT_SHARDLOG", Class8.string_4);
                    if (text6.ToUpper() != text7.ToUpper())
                    {
                        if (!Class5.smethod_111("Drop procedure _Update_Database"))
                        {
                            Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Priority Exe:_Update_Database 状态：修复失败,无法删除");
                            return false;
                        }
                        if (!Class5.smethod_111(text7))
                        {
                            Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Priority Exe:_Update_Database 状态：修复失败");
                            return false;
                        }
                        Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Priority Exe:_Update_Database 状态：升级成功");
                    }
                }
                files = directoryInfo.GetFiles();
                num3 = 0;
                string[] array3;
                while (true)
                {
                    if (num3 < files.Length)
                    {
                        string name3 = files[num3].Name;
                        array3 = name3.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries);
                        if (array3.Length == 3 && array3[2] == "sql" && array3[0] == "Exe")
                        {
                            if (Class5.smethod_103(array3[1]))
                            {
                                string text8 = Class5.smethod_17(array3[1]);
                                string text9 = File.ReadAllText(text + "\\" + name3, Encoding.Default);
                                text9 = text9.Replace("SRO_VT_SHARD", Class8.string_5);
                                text9 = text9.Replace("SRO_VT_ACCOUNT", Class8.string_6);
                                text9 = text9.Replace("SRO_VT_SHARDLOG", Class8.string_4);
                                if (text8.ToUpper() != text9.ToUpper())
                                {
                                    if (!Class5.smethod_111("Drop procedure " + array3[1]))
                                    {
                                        Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Exe:" + array3[1] + " 状态：修复失败,无法删除");
                                        return false;
                                    }
                                    if (!Class5.smethod_111(text9))
                                    {
                                        Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Exe:" + array3[1] + " 状态：修复失败");
                                        return false;
                                    }
                                    Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Exe:" + array3[1] + " 状态：修复成功");
                                    num++;
                                }
                                else
                                {
                                    Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Exe:" + array3[1] + " 状态：正常");
                                    num2++;
                                }
                            }
                            else
                            {
                                string text10 = File.ReadAllText(text + "\\" + name3, Encoding.Default);
                                text10 = text10.Replace("SRO_VT_SHARD", Class8.string_5);
                                text10 = text10.Replace("SRO_VT_ACCOUNT", Class8.string_6);
                                text10 = text10.Replace("SRO_VT_SHARDLOG", Class8.string_4);
                                if (!(text10 != ""))
                                {
                                    break;
                                }
                                if (!Class5.smethod_111(text10))
                                {
                                    Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Exe:" + array3[1] + " 状态：创建失败");
                                    return false;
                                }
                                Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Exe:" + array3[1] + " 状态：创建成功");
                                num++;
                            }
                        }
                        num3++;
                        continue;
                    }
                    if (Class8.bool_19)
                    {
                        int num4 = 0;
                        int num5 = 0;
                        if (!Class5.smethod_116(out byte byte_, out string string_4, out string string_5, out string string_6, out string string_7, out string string_8, out short short_, out ushort ushort_, out ushort ushort_2, out ushort ushort_3))
                        {
                            Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " Certification System SQL_Get_CertificationConfig Error Code:1");
                            num4++;
                        }
                        if (!smethod_39(Class8.string_3, out string string_9, out string string_10, out string string_11, out string string_12))
                        {
                            Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " Certification System Get_Sql_Info Error Code:2");
                            num4++;
                        }
                        string text11 = ("DRIVER={SQL Server};SERVER=" + string_9 + ";DSN=" + Class8.string_6 + ";UID=" + string_10 + ";PWD=" + string_11 + ";DATABASE=" + Class8.string_6) ?? "";
                        if (string_5 != text11)
                        {
                            string_5 = text11;
                            num5++;
                        }
                        string text12 = ("DRIVER={SQL Server};SERVER=" + string_9 + ";DSN=" + Class8.string_5 + ";UID=" + string_10 + ";PWD=" + string_11 + ";DATABASE=" + Class8.string_5) ?? "";
                        if (string_6 != text12)
                        {
                            string_6 = text12;
                            num5++;
                        }
                        string text13 = ("DRIVER={SQL Server};SERVER=" + string_9 + ";DSN=" + Class8.string_4 + ";UID=" + string_10 + ";PWD=" + string_11 + ";DATABASE=" + Class8.string_4) ?? "";
                        if (string_7 != text13)
                        {
                            string_7 = text13;
                            num5++;
                        }
                        if (string_4 != Class8.string_2)
                        {
                            string_4 = Class8.string_2;
                            num5++;
                        }
                        if (ushort_ != Class8.ushort_0)
                        {
                            ushort_ = Class8.ushort_0;
                            num5++;
                        }
                        if (ushort_3 != Class8.ushort_1)
                        {
                            ushort_3 = Class8.ushort_1;
                            num5++;
                        }
                        if (ushort_2 != Class8.ushort_8)
                        {
                            ushort_2 = Class8.ushort_8;
                            num5++;
                        }
                        if (num5 > 0)
                        {
                            if (Class5.smethod_60(string_4, string_8, (ushort)short_, byte_, string_5, string_6, string_7, ushort_, ushort_2, ushort_3) != 1)
                            {
                                Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " Certification System SQL_Update_CertificationConfig Error Code:3");
                                num4++;
                            }
                            if (num4 == 0)
                            {
                                Class6.smethod_0(2, "CertificationServer 配置已更新", 0);
                            }
                            else
                            {
                                Class6.smethod_0(2, "CertificationServer 配置更新失败", 0);
                            }
                        }
                    }
                    if (Class5.smethod_70(Class8.int_0) != 1)
                    {
                        Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System 状态：SQL_Update_Database 更新未完成");
                    }
                    else
                    {
                        Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System 状态：SQL_Update_Database 更新完成");
                    }
                    Class6.smethod_0(2, "SQL System 状态：检测修复系统完成运行 检查计数：" + num2 + " 修复计数：" + num, 0);
                    Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System 状态：检测修复系统完成运行 检查计数：" + num2 + " 修复计数：" + num);
                    return true;
                }
                Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Exe:" + array3[1] + " 状态：SQL代码错误,无法创建");
                return false;
            }
            Class7.smethod_3("SQL_Check_Repair.Log", DateTime.Now.ToString() + " SQL System Tab:" + array[1] + " 状态：SQL代码错误,无法创建");
            return false;
        }
        catch
        {
            return false;
        }
    }

    public static bool smethod_39(string string_0, out string string_1, out string string_2, out string string_3, out string string_4)
    {
        string_1 = "";
        string_2 = "";
        string_3 = "";
        string_4 = "";
        string[] array = string_0.Split(new string[1] { ";" }, StringSplitOptions.RemoveEmptyEntries);
        if (array != null)
        {
            if (array.Length == 4)
            {
                int num = 0;
                while (true)
                {
                    if (num < array.Length)
                    {
                        string[] array2 = array[num].Split(new string[1] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                        if (array2 == null)
                        {
                            break;
                        }
                        if (array2.Length == 2)
                        {
                            switch (num)
                            {
                                case 0:
                                    string_1 = array2[1];
                                    break;
                                case 1:
                                    string_4 = array2[1];
                                    break;
                                case 2:
                                    string_2 = array2[1];
                                    break;
                                case 3:
                                    string_3 = array2[1];
                                    return true;
                            }
                            num++;
                            continue;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        return false;
    }



    public static byte[] smethod_58(byte[] byte_0)
    {
        try
        {
            using (var stream = new MemoryStream(byte_0))
            {
                using (var memoryStream = new MemoryStream())
                {
                    using (var gZipStream = new GZipStream(stream, CompressionMode.Decompress))
                    {
                        gZipStream.CopyTo(memoryStream);
                        gZipStream.Close();
                        return memoryStream.ToArray();
                    }
                }
            }
        }
        catch
        {
            return new byte[0];
        }
    }
    public static bool smethod_25(IntPtr intptr_0, string string_0) {
        try {
            var @class = new Class21();
            @class.Write((byte)3);
            @class.Write(0);
            @class.method_1(string_0);
            byte[] byte_ = @class.method_0();
            return Class12.class3_0.method_43(intptr_0, 12326, byte_);
        }
        catch {
            return false;
        }
    }

    public static bool smethod_26(IntPtr intptr_0, byte byte_0) {
        try {
            var @class = new Class21();
            @class.Write((byte)2);
            @class.Write(byte_0);
            @class.Write((byte)48);
            byte[] byte_ = @class.method_0();
            return Class12.class3_0.method_43(intptr_0, Class15.ushort_7, byte_);
        }
        catch {
            return false;
        }
    }

    public static bool smethod_27(IntPtr intptr_0, string string_0) {
        try {
            var @class = new Class21();
            @class.Write((byte)7);
            @class.method_1(string_0);
            byte[] byte_ = @class.method_0();
            return Class12.class3_0.method_43(intptr_0, 12326, byte_);
        }
        catch {
            return false;
        }
    }

    public static bool smethod_28(IntPtr intptr_0, int int_0, byte byte_0) {
        try {
            var @class = new Class21();
            @class.Write(int_0);
            @class.Write(byte_0);
            byte[] byte_ = @class.method_0();
            return Class12.class3_0.method_43(intptr_0, 12511, byte_);
        }
        catch {
            return false;
        }
    }

    public static int smethod_29(string string_0) {
        try {
            string text = "";
            text = Class5.smethod_49();
            if (text != "") {
                string[] array = text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                if (array != null) {
                    for (int i = 0; i < array.Length; i++) {
                        if (array[i] != "") {
                            Class12.class3_0.method_21(Class8.string_41[0] + array[i] + Class8.string_41[1]);
                        }
                    }
                }
            }
            text = Class5.smethod_50();
            if (text != "") {
                string[] array2 = text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                if (array2 != null) {
                    for (int j = 0; j < array2.Length; j++) {
                        if (!(array2[j] != "")) {
                            continue;
                        }
                        string[] array3 = array2[j].Split(new string[1] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                        if (array3 == null || array3.Length != 3 || (Class8.bool_29 && byte.Parse(array3[1]) < Class8.byte_3)) {
                            continue;
                        }
                        int num = Class5.smethod_52(array3[0], string_0);
                        if (num == 1) {
                            num = Class12.class3_0.method_25(array3[0], Class8.int_19, 15, bool_2: true, bool_3: false, Class8.string_42[0] + Class8.int_19 + Class8.string_42[1]);
                            if (num != 1) {
                                return -1000 + num;
                            }
                        }
                    }
                }
            }
            Class6.smethod_0(2, "Sieg Reward System 要塞获胜方奖励已发送", 0);
            if (Class8.bool_28) {
                text = Class5.smethod_51(string_0);
                if (text != "") {
                    string[] array4 = text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    if (array4 != null) {
                        for (int k = 0; k < array4.Length; k++) {
                            if (array4[k] != "") {
                                int num2 = Class12.class3_0.method_25(array4[k], Class8.int_20, 16, bool_2: true, bool_3: false, Class8.string_43[0] + Class8.int_20 + Class8.string_43[1]);
                                if (num2 != 1) {
                                    return -1000 + num2;
                                }
                            }
                        }
                    }
                }
                Class6.smethod_0(2, "Sieg Reward System 要塞参与奖励已发送", 0);
            }
            return 1;
        }
        catch {
            return -1100;
        }
    }

    public static int smethod_30(IntPtr intptr_0, string string_0, string string_1, uint uint_0, byte byte_0, byte byte_1) {
        try {
            int num = Class5.smethod_62(string_1, byte_1);
            if (num != 1) {
                return -1000 + num;
            }
            string text = "";
            for (int i = 0; i < Class5.list_1.Count; i++) {
                var @struct = Class5.list_1[i];
                if (@struct.int_1 != uint_0) {
                    continue;
                }
                text = @struct.string_1;
                if (Class8.bool_34) {
                    if (byte_0 != @struct.byte_0) {
                        continue;
                    }
                    int num2 = Class5.smethod_54(string_1, @struct.int_2);
                    if (num2 > 0) {
                        num = Class5.smethod_63(string_0, string_1, 1, @struct.int_2, num2);
                        if (num < 1) {
                            return -2000 + num;
                        }
                        if (!smethod_21(intptr_0, num2)) {
                            return -3000;
                        }
                        Class12.class3_0.method_21(Class8.string_8[0] + string_1 + Class8.string_8[1] + text + Class8.string_8[2] + byte_0 + Class8.string_8[3] + @struct.int_2 + Class8.string_8[4]);
                        return 1;
                    }
                    return -4000 + num2;
                }
                if (byte_0 < @struct.byte_0) {
                    break;
                }
                int num3 = Class5.smethod_54(string_1, @struct.int_2);
                if (num3 > 0) {
                    num = Class5.smethod_63(string_0, string_1, 1, @struct.int_2, num3);
                    if (num < 1) {
                        return -2000 + num;
                    }
                    if (!smethod_21(intptr_0, num3)) {
                        return -3000;
                    }
                    Class12.class3_0.method_21(Class8.string_8[0] + string_1 + Class8.string_8[1] + text + Class8.string_8[2] + byte_0 + Class8.string_8[3] + @struct.int_2 + Class8.string_8[4]);
                    return 1;
                }
                return -4000 + num3;
            }
            return 1;
        }
        catch {
            return -1100;
        }
    }
    public static string smethod_12(string string_0)
    {
        try
        {
            string text = string_0;
            string[] array = "'|and|exec|insert|select|delete|update|count|%|chr|mid|master|truncate|char|declare|;|or|-|+|,".Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    text = text.Replace(array[i], ".");
                }
            }
            return text;
        }
        catch
        {
            return "Null";
        }
    }

    public static bool smethod_13(int int_0)
    {
        try
        {
            string[] array = Class8.string_29.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (int.TryParse(array[i], out int result) && result == int_0)
                    {
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

    public static bool smethod_14()
    {
        try
        {
            string[] array = Class8.string_29.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (int.TryParse(array[i], out int result))
                    {
                        if (result <= 0)
                        {
                            return false;
                        }
                        continue;
                    }
                    return false;
                }
            }
            return true;
        }
        catch
        {
            return true;
        }
    }

    public static bool smethod_15(string string_0)
    {
        try
        {
            if (!Class8.bool_1)
            {
                return true;
            }
            switch (Class13.smethod_2(string_0))
            {
                case -1:
                    return true;
                default:
                    return false;
                case 1:
                    if (Class5.smethod_95(1, 0, string_0) != 1)
                    {
                        return false;
                    }
                    return true;
            }
        }
        catch
        {
            return false;
        }
    }

    public static bool smethod_16(IntPtr intptr_0)
    {
        try
        {
            var @class = new Class21();
            var list = Class5.smethod_2(out int int_);
            if (int_ > 0)
            {
                @class.Write((byte)1);
                @class.Write((byte)list.Count);
                for (int i = 0; i < list.Count; i++)
                {
                    @class.Write(list[i].int_0);
                    @class.Write(list[i].byte_0);
                    @class.method_1(list[i].string_0);
                    @class.Write(list[i].byte_1);
                    @class.Write(list[i].byte_2);
                    @class.Write(list[i].int_1);
                    @class.method_1(list[i].string_1);
                }
                return Class12.class3_0.method_43(intptr_0, Class15.ushort_6, @class.method_0());
            }
            bool result = Class12.class3_0.method_43(intptr_0, Class15.ushort_6, new byte[2] { 1, 0 });
            if (list == null)
            {
                return false;
            }
            return result;
        }
        catch
        {
            return false;
        }
    }

    public static bool smethod_17(IntPtr intptr_0, int int_0, int int_1)
    {
        try
        {
            var @class = new Class21();
            @class.Write((byte)5);
            @class.Write(int_0);
            @class.Write((byte)3);
            @class.Write(int_1);
            return Class12.class3_0.method_43(intptr_0, 15488, @class.method_0());
        }
        catch
        {
            return false;
        }
    }
    public static bool smethod_40(string string_0, string string_1, string string_2, out string string_3)
    {
        string_3 = "";
        string[] array = string_1.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        if (array != null && array.Length > 2)
        {
            for (int i = 1; i < array.Length && array[i] != ")"; i++)
            {
                string[] array2 = array[i].Replace("\t", "").Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (array2 == null || array2.Length <= 1)
                {
                    continue;
                }
                if (array2[0].IndexOf("[") <= -1)
                {
                    break;
                }
                if (string_2.IndexOf(array2[0]) != -1)
                {
                    continue;
                }
                string text = "";
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j] != ",")
                    {
                        text = text + " " + array2[j];
                    }
                }
                if (text != "")
                {
                    string_3 = string_3 + "ALTER TABLE " + string_0 + " ADD" + text + Environment.NewLine;
                }
            }
        }
        if (string_3 == "")
        {
            return false;
        }
        return true;
    }



    public static int smethod_53(string string_0, out string string_1)
    {
        string_1 = "";
        try
        {
            if (!File.Exists(string_0))
            {
                return -1;
            }
            byte[] array = File.ReadAllBytes(string_0);
            if (array.Length == 0)
            {
                return -5;
            }
            string_1 = smethod_52(array);
            if (string_1 != "")
            {
                return 1;
            }
            return -3;
        }
        catch
        {
            return -2;
        }
    }

    public static void smethod_54(byte[] byte_0)
    {
        new Thread(smethod_55).Start(byte_0);
    }

    private static void smethod_55(object object_0)
    {
        try
        {
            string text = Application.StartupPath + "\\Qiangweidiewu.exe";
            string text2 = text + "_" + smethod_0() + ".bak";
            smethod_48();
            int num = Process.GetProcessesByName("Qiangweidiewu").Length;
            int num2 = smethod_0();
            while (true)
            {
                if (num > 0)
                {
                    if (smethod_0() - num2 > 30000)
                    {
                        break;
                    }
                    if (num != 0)
                    {
                        Thread.Sleep(1000);
                        num = Process.GetProcessesByName("Qiangweidiewu").Length;
                        continue;
                    }
                }
                if (File.Exists(text))
                {
                    File.Move(text, text2);
                }
                File.WriteAllBytes(text, (byte[])object_0);
                Process.Start(text);
                if (File.Exists(text2))
                {
                    File.Delete(text2);
                }
                break;
            }
        }
        catch
        {
        }
    }

    public static bool smethod_56(out byte[] byte_0)
    {
        byte_0 = new byte[0];
        try
        {
            string path = Application.StartupPath + "\\SCGControlPlugin\\SCGControl.dll";
            if (File.Exists(path))
            {
                byte_0 = File.ReadAllBytes(path);
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    public static byte[] smethod_57(byte[] byte_0)
    {
        try
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true))
                {
                    gZipStream.Write(byte_0, 0, byte_0.Length);
                    gZipStream.Close();
                    return memoryStream.ToArray();
                }
            }
        }
        catch
        {
            return new byte[0];
        }
    }
    public static int smethod_18(IntPtr intptr_0, string string_0, int int_0, bool bool_0)
    {
        int num = 0;
        num = ((!bool_0) ? Class5.smethod_61(string_0, int_0) : Class5.smethod_54(string_0, int_0));
        if (num >= 0)
        {
            if (!smethod_21(intptr_0, num))
            {
                return -2000;
            }
            return 1;
        }
        return -3000 + num;
    }

    public static int smethod_19(IntPtr intptr_0, string string_0, int int_0, byte byte_0, bool bool_0)
    {
        int num = 0;
        int num2 = 0;
        num2 = ((!bool_0) ? Class5.smethod_61(string_0, int_0) : Class5.smethod_54(string_0, int_0));
        if (num2 >= 0)
        {
            num = Class5.smethod_63("Sys.Char_Silk", string_0, byte_0, int_0, num2);
            if (num < 1)
            {
                return -1000 + num;
            }
            if (!smethod_21(intptr_0, num2))
            {
                return -2000;
            }
            return 1;
        }
        return -3000 + num2;
    }

    public static int smethod_20(string string_0, int int_0, byte byte_0, bool bool_0)
    {
        int num = 0;
        int num2 = 0;
        num2 = ((!bool_0) ? Class5.smethod_61(string_0, int_0) : Class5.smethod_54(string_0, int_0));
        if (num2 >= 0)
        {
            num = Class5.smethod_63("Sys.Char_Silk", string_0, byte_0, int_0, num2);
            if (num < 1)
            {
                return -1000 + num;
            }
            return 1;
        }
        return -3000 + num2;
    }

    public static bool smethod_21(IntPtr intptr_0, int int_0)
    {
        try
        {
            var @class = new Class21();
            @class.Write(int_0);
            @class.Write(0);
            @class.Write(0);
            byte[] byte_ = @class.method_0();
            return Class12.class3_0.method_43(intptr_0, 12627, byte_);
        }
        catch
        {
            return false;
        }
    }
    public static int smethod_31(IntPtr intptr_0, string string_0, string string_1, int int_0) {
        try {
            int num = 0;
            int num2 = Class5.smethod_54(string_1, int_0);
            if (num2 > 0) {
                num = Class5.smethod_63(string_0, string_1, 3, int_0, num2);
                if (num < 1) {
                    return -1000 + num;
                }
                if (!smethod_21(intptr_0, num2)) {
                    return -2000;
                }
                smethod_27(intptr_0, Class8.string_12[0] + string_1 + Class8.string_12[1] + int_0 + Class8.string_12[2]);
                return 1;
            }
            return -3000 + num2;
        }
        catch {
            return -1100;
        }
    }

    public static int smethod_32(IntPtr intptr_0, string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, int int_1, byte byte_0, short short_0, int int_2, int int_3) {
        try {
            int num = 0;
            num = Class5.smethod_32(string_0, string_1, int_0, string_2, string_4, int_1, byte_0, short_0, int_2, int_3, out var int_4, out var string_5);
            switch (num) {
                case 1:
                    if (int_4 > 0 && !smethod_21(intptr_0, int_4)) {
                        return -2000;
                    }
                    if (string_5 != "NULL") {
                        if (!smethod_27(intptr_0, string_5)) {
                            Class7.smethod_2(string_3, "System Error A SellRegister_Reward_Send: 11001");
                        }
                    }
                    else {
                        smethod_27(intptr_0, Class8.string_13[0] + string_1 + Class8.string_13[1] + int_4 + Class8.string_13[2]);
                    }
                    return 1;
                default:
                    return -1000 + num;
                case 101:
                case 102:
                case 103:
                case 105:
                    return 1;
            }
        }
        catch {
            return -1100;
        }
    }

    public static int smethod_33(IntPtr intptr_0, string string_0, string string_1, int int_0) {
        try {
            int num = 0;
            int num2 = Class5.smethod_54(string_1, int_0);
            if (num2 > 0) {
                num = Class5.smethod_63(string_0, string_1, 4, int_0, num2);
                if (num < 1) {
                    return -1000 + num;
                }
                if (!smethod_21(intptr_0, num2)) {
                    return -2000;
                }
                smethod_27(intptr_0, Class8.string_13[0] + string_1 + Class8.string_13[1] + int_0 + Class8.string_13[2]);
                return 1;
            }
            return -3000 + num2;
        }
        catch {
            return -1100;
        }
    }
    public static bool smethod_6(string string_0, byte byte_0)
    {
        string_0 = string_0.ToUpper();
        char[] array = new char[26]
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
            'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        char[] array2 = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] array3 = new char[3] { '@', '_', '.' };
        int num = 0;
        while (true)
        {
            if (num < string_0.Length)
            {
                if (byte_0 == 1)
                {
                    bool flag = true;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (string_0[num] == array[i])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        return true;
                    }
                }
                if (byte_0 == 2)
                {
                    bool flag2 = true;
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (string_0[num] == array2[j])
                        {
                            flag2 = false;
                            break;
                        }
                    }
                    if (flag2)
                    {
                        return true;
                    }
                }
                if (byte_0 == 3)
                {
                    bool flag3 = true;
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (string_0[num] == array[k])
                        {
                            flag3 = false;
                            break;
                        }
                    }
                    if (!flag3)
                    {
                        goto IL_0198;
                    }
                    for (int l = 0; l < array2.Length; l++)
                    {
                        if (string_0[num] == array2[l])
                        {
                            flag3 = false;
                            break;
                        }
                    }
                    if (flag3)
                    {
                        return true;
                    }
                }
                if (byte_0 == 4)
                {
                    bool flag4 = true;
                    for (int m = 0; m < array.Length; m++)
                    {
                        if (string_0[num] == array[m])
                        {
                            flag4 = false;
                            break;
                        }
                    }
                    if (flag4)
                    {
                        for (int n = 0; n < array2.Length; n++)
                        {
                            if (string_0[num] == array2[n])
                            {
                                flag4 = false;
                                break;
                            }
                        }
                        if (flag4)
                        {
                            for (int num2 = 0; num2 < array3.Length; num2++)
                            {
                                if (string_0[num] == array3[num2])
                                {
                                    flag4 = false;
                                    break;
                                }
                            }
                            if (flag4)
                            {
                                break;
                            }
                        }
                    }
                }
                goto IL_0198;
            }
            return false;
        IL_0198:
            num++;
        }
        return true;
    }

    public static byte[] smethod_7()
    {
        try
        {
            if (!Class5.smethod_116(out byte byte_, out string string_, out string string_2, out string string_3, out string string_4, out string string_5, out short short_, out ushort ushort_, out ushort ushort_2, out ushort ushort_3))
            {
                return null;
            }
            if (!Class15.Set_ContentID(byte_))
            {
                return null;
            }
            if (!Class15.Set_MachineIP(string_))
            {
                return null;
            }
            if (!Class15.Set_GlobalQuery(string_2))
            {
                return null;
            }
            if (!Class15.Set_ShardQuery(string_3))
            {
                return null;
            }
            if (!Class15.Set_ShardLogQuery(string_4))
            {
                return null;
            }
            if (!Class15.Set_ShardName(string_5))
            {
                return null;
            }
            if (!Class15.Set_ShardMax(short_))
            {
                return null;
            }
            if (!Class15.Set_GatewayServerPort(ushort_))
            {
                return null;
            }
            if (!Class15.Set_DownloadServerPort(ushort_2))
            {
                return null;
            }
            if (!Class15.Set_AgentServerPort(ushort_3))
            {
                return null;
            }
            var intptr_ = IntPtr.Zero;
            if (!Class15.Get_CertificationBuffer(out int int_, out intptr_))
            {
                return null;
            }
            byte[] array = new byte[int_];
            if (int_ > 0)
            {
                Marshal.Copy(intptr_, array, 0, int_);
                return array;
            }
            return null;
        }
        catch
        {
            return null;
        }
    }

    public static ushort smethod_8(string string_0, string string_1)
    {
        try
        {
            string text = File.ReadAllText(string_0);
            int num = -1;
            int num2 = -1;
            num = text.IndexOf(string_1);
            if (num == -1)
            {
                return 0;
            }
            num += string_1.Length;
            num = text.IndexOf("{", num);
            if (num == -1)
            {
                return 0;
            }
            num++;
            num = text.IndexOf("Certification", num);
            if (num == -1)
            {
                return 0;
            }
            num += 13;
            num = text.IndexOf(",", num);
            if (num == -1)
            {
                return 0;
            }
            num2 = text.IndexOf(Environment.NewLine, num);
            if (num2 == -1)
            {
                return 0;
            }
            num++;
            string s = text.Substring(num, num2 - num).Replace("\t", "").Replace(" ", "")
                .Substring(0, 5);
            if (ushort.TryParse(s, out ushort result))
            {
                return result;
            }
            return 0;
        }
        catch
        {
            return 0;
        }
    }

    public static int smethod_9(string string_0, int int_0)
    {
        try
        {
            if (string_0 == "")
            {
                return 1;
            }
            if (string_0.Length <= int_0)
            {
                try
                {
                    string[] array = "'|=|/|%|;|-|+|,".Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                    if (array == null && array.Length != 0)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (string_0.IndexOf(array[i]) > -1)
                            {
                                return 1;
                            }
                        }
                    }
                    return 0;
                }
                catch
                {
                    return 0;
                }
            }
            return 1;
        }
        catch
        {
            return 1;
        }
    }

    public static byte[] smethod_10(string string_0)
    {
        try
        {
            char[] separator = new char[1] { '.' };
            string[] array = string_0.Split(separator);
            return new byte[4]
            {
                byte.Parse(array[0]),
                byte.Parse(array[1]),
                byte.Parse(array[2]),
                byte.Parse(array[3])
            };
        }
        catch
        {
            return new byte[4];
        }
    }

    public static string smethod_11(string string_0)
    {
        try
        {
            string text = string_0;
            string[] array = "'|/|%|,".Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    text = text.Replace(array[i], ".");
                }
            }
            return text;
        }
        catch
        {
            return "Null";
        }
    }



    public static bool smethod_22(IntPtr intptr_0, int int_0, int int_1, int int_2)
    {
        try
        {
            var @class = new Class21();
            @class.Write(int_0);
            @class.Write(int_1);
            @class.Write(int_2);
            byte[] byte_ = @class.method_0();
            return Class12.class3_0.method_43(intptr_0, 12627, byte_);
        }
        catch
        {
            return false;
        }
    }

    public static int smethod_34(IntPtr intptr_0, string string_0, string string_1, string string_2, uint uint_0) {
        try {
            int num = 0;
            string text = "";
            int num2 = 0;
            int num3 = 0;
            int num4;
            while (true) {
                if (num3 < Class5.list_0.Count) {
                    var @struct = Class5.list_0[num3];
                    if (@struct.int_1 != uint_0) {
                        num3++;
                        continue;
                    }
                    text = @struct.string_1;
                    num2 = @struct.int_2;
                    num4 = Class5.smethod_54(string_1, @struct.int_2);
                    if (num4 <= 0) {
                        break;
                    }
                    num = Class5.smethod_63(string_0, string_1, 2, @struct.int_2, num4);
                    if (num < 1) {
                        return -1000 + num;
                    }
                    if (!smethod_21(intptr_0, num4)) {
                        return -2000;
                    }
                }
                if (text != "") {
                    if (Class8.bool_56) {
                        smethod_27(intptr_0, Class8.string_7[0] + string_2 + Class8.string_7[1] + text + Class8.string_7[2] + num2 + Class8.string_7[3]);
                    }
                    else {
                        Class12.class3_0.method_21(Class8.string_7[0] + string_2 + Class8.string_7[1] + text + Class8.string_7[2] + num2 + Class8.string_7[3]);
                    }
                }
                return 1;
            }
            return -3000 + num4;
        }
        catch {
            return -1100;
        }
    }

    public static int smethod_35(IntPtr intptr_0, string string_0, string string_1, byte byte_0) {
        try {
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            num3 = Class5.smethod_68();
            if (num3 < 1) {
                return -1000 + num3;
            }
            for (int i = 0; i < Class5.list_7.Count; i++) {
                var @struct = Class5.list_7[i];
                if (@struct.int_1 != num3) {
                    continue;
                }
                num2 = @struct.int_2;
                if (!Class8.bool_21) {
                    break;
                }
                int num4 = Class5.smethod_54(string_1, num2);
                if (num4 > 0) {
                    num = Class5.smethod_63(string_0, string_1, 1, num2, num4);
                    if (num < 1) {
                        return -2000 + num;
                    }
                    if (smethod_21(intptr_0, num4)) {
                        break;
                    }
                    return -3000;
                }
                return -4000 + num4;
            }
            if (Class8.bool_21 && num2 != 0) {
                Class12.class3_0.method_21(Class8.string_35[0] + string_1 + Class8.string_35[1] + num3 + Class8.string_35[2] + num2 + Class8.string_35[3]);
            }
            num = Class5.smethod_64(num3, string_1, byte_0, num2, Class8.bool_21);
            if (num < 1) {
                return -5000 + num;
            }
            return 1;
        }
        catch {
            return -1100;
        }
    }

    public static int smethod_36(IntPtr intptr_0, string string_0, string string_1, int int_0) {
        try {
            int num = 0;
            int num2 = 0;
            byte b = 0;
            for (int i = 0; i < Class5.list_8.Count; i++) {
                var @struct = Class5.list_8[i];
                if (int_0 >= @struct.int_1) {
                    b = @struct.byte_0;
                    num2 = @struct.int_2;
                    break;
                }
            }
            if (b == 0) {
                return 1;
            }
            if (num2 == 0) {
                return -1000;
            }
            if (Class5.smethod_65(string_1, b) == 1) {
                return 1;
            }
            int num3 = Class5.smethod_54(string_1, num2);
            if (num3 > 0) {
                num = Class5.smethod_63(string_0, string_1, 14, num2, num3);
                if (num < 1) {
                    return -2000 + num;
                }
                if (!smethod_21(intptr_0, num3)) {
                    return -3000;
                }
                Class12.class3_0.method_21(Class8.string_38[0] + b + Class8.string_38[1] + num2 + Class8.string_38[2]);
                num = Class5.smethod_67(string_1, b, int_0, num2);
                if (num < 1) {
                    return -5000 + num;
                }
                return 1;
            }
            return -4000 + num3;
        }
        catch {
            return -1100;
        }
    }


}
