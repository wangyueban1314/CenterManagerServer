using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

internal class Class32 {
    public string string_0;

    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string string_1, string string_2, string string_3, string string_4);

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string string_1, string string_2, string string_3, StringBuilder stringBuilder_0, int int_0, string string_4);

    public Class32(string string_1) {
        string_0 = Application.StartupPath + "\\" + string_1;
    }
    public void method_1(string string_1, string string_2, string[] string_3)
    {
        try
        {
            string text = "";
            for (int i = 0; i < string_3.Length; i++)
            {
                text = ((!(text == "")) ? (text + "%s" + string_3[i]) : (text + string_3[i]));
            }
            WritePrivateProfileString(string_1, string_2, text, string_0);
        }
        catch
        {
        }
    }

    public string method_2(string string_1, string string_2, bool bool_0, string string_3)
    {
        try
        {
            var stringBuilder = new StringBuilder(500);
            try
            {
                GetPrivateProfileString(string_1, string_2, "", stringBuilder, 500, string_0);
            }
            catch
            {
                if (bool_0)
                {
                    method_0(string_1, string_2, string_3);
                }
                return string_3;
            }
            string text = stringBuilder.ToString();
            if (text == "")
            {
                if (bool_0)
                {
                    method_0(string_1, string_2, string_3);
                }
                return string_3;
            }
            return text;
        }
        catch
        {
            return string_3;
        }
    }
    public void method_0(string string_1, string string_2, string string_3) {
        try {
            var stringBuilder = new StringBuilder(500);
            GetPrivateProfileString(string_1, string_2, "", stringBuilder, 500, string_0);
            if (stringBuilder.ToString() != string_3) {
                WritePrivateProfileString(string_1, string_2, string_3, string_0);
            }
        }
        catch {
            WritePrivateProfileString(string_1, string_2, string_3, string_0);
        }
    }



    public string[] method_3(string string_1, string string_2, bool bool_0, string string_3) {
        try {
            var stringBuilder = new StringBuilder(500);
            try {
                GetPrivateProfileString(string_1, string_2, "", stringBuilder, 500, string_0);
            }
            catch {
                if (bool_0) {
                    method_0(string_1, string_2, string_3);
                }
                return string_3.Split(new string[1] { "%s" }, StringSplitOptions.RemoveEmptyEntries);
            }
            string text = stringBuilder.ToString();
            if (text == "") {
                if (bool_0) {
                    method_0(string_1, string_2, string_3);
                }
                return string_3.Split(new string[1] { "%s" }, StringSplitOptions.RemoveEmptyEntries);
            }
            return text.Split(new string[1] { "%s" }, StringSplitOptions.RemoveEmptyEntries);
        }
        catch {
            return string_3.Split(new string[1] { "%s" }, StringSplitOptions.RemoveEmptyEntries);
        }
    }

    public bool method_4() {
        try {
            string[] array = File.ReadAllLines("CenterManager.Data", Encoding.Default);
            string[] array2 = File.ReadAllLines("CenterManager.ini", Encoding.Default);
            if (array != null && array2 != null) {
                if (array.Length != 0 && array2.Length != 0) {
                    int num = 0;
                    while (true) {
                        if (num < array.Length) {
                            if (array[num] != "" && array[num].Substring(0, 1) != "/" && array[num].Substring(0, 1) != "*" && array[num].Substring(0, 1) != "[") {
                                int num2 = array[num].IndexOf("=");
                                if (num2 > -1) {
                                    string text = array[num].Substring(0, num2);
                                    if (text != null) {
                                        int num3 = -1;
                                        for (int i = 0; i < array2.Length; i++) {
                                            if (array2[i].Length > text.Length && array2[i].Substring(0, text.Length).ToLower() == text.ToLower()) {
                                                num3 = i;
                                                break;
                                            }
                                        }
                                        if (num3 == -1) {
                                            break;
                                        }
                                    }
                                }
                            }
                            num++;
                            continue;
                        }
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        catch {
            return false;
        }
    }
}
