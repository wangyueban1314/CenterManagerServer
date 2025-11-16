using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

internal class Class7 {
    private static object object_0 = new object();
    public static bool smethod_2(string string_0, string string_1)
    {
        string text = string_0;
        if (string_0 == "")
        {
            text = "Error";
        }
        try
        {
            smethod_3(DateTime.Now.ToString("yyyy-MM-dd") + ".Log", DateTime.Now.ToString() + " Client IP:" + text + " " + string_1);
        }
        catch
        {
            return false;
        }
        return true;
    }
    public static void smethod_1(string string_0, params string[] string_1)
    {
        try
        {
            string text = "";
            for (int i = 0; i < string_1.Length; i++)
            {
                text = ((!(text == "")) ? (text + "," + string_1[i].ToString()) : (text + string_1[i].ToString()));
            }
            smethod_3(DateTime.Now.ToString("yyyy-MM-dd") + "_SQl_System_Error.Log", DateTime.Now.ToString() + " " + string_0 + " " + text);
        }
        catch
        {
        }
    }
    public static bool smethod_0(string string_0, params string[] string_1) {
        try {
            Class10.smethod_3(21, new Struct35(string_0, string_1));
            return true;
        }
        catch {
            return false;
        }
    }

    public static void smethod_3(string string_0, string string_1)
    {
        try
        {
            if (Class8.bool_67)
            {
                lock (object_0)
                {
                    string_0 = Application.StartupPath + "\\Log\\" + string_0;
                    var streamWriter = new StreamWriter(string_0, append: false);
                    streamWriter.WriteLine(string_1);
                    streamWriter.Close();
                }
            }
        }
        catch
        {
        }
    }


    public static void smethod_5(string string_0, List<Struct2> list_0) {
        try {
            string text = "";
            for (int i = 0; i < list_0.Count; i++) {
                text = text + list_0[i].string_0 + ":" + list_0[i].ushort_0 + ":" + list_0[i].string_1 + Environment.NewLine;
            }
            string_0 = Application.StartupPath + "\\" + string_0;
            byte[] byte_ = Class28.smethod_2(Encoding.Unicode.GetBytes(text), "CenterManagerServerForm");
            byte_ = Class1.smethod_12(Encoding.Default.GetBytes("MDMP"), byte_);
            File.WriteAllBytes(string_0, byte_);
        }
        catch {
        }
    }
}
