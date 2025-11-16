using System;
using System.Collections.Generic;

internal class Class13 {
    public static object object_0 = new object();

    public static object object_1 = new object();

    public static int int_0 = 0;

    public static string string_0 = "";

    public static bool bool_0 = false;

    public static int int_1 = 0;

    public static int int_2 = 100;

    public static int int_3 = 10;

    public static int int_4 = 0;

    public static List<Struct33> list_0 = new List<Struct33>();

    public static bool smethod_0(int int_5, bool bool_1) {
        lock (object_0) {
            if (bool_1) {
                int_1 += int_5;
            }
            else {
                int_1 -= int_5;
            }
        }
        return true;
    }
    public static int smethod_2(string string_1)
    {
        try
        {
            lock (object_1)
            {
                int num = 0;
                while (true)
                {
                    if (num < list_0.Count)
                    {
                        _ = list_0[num];
                        if (list_0[num].byte_1 == 0 && list_0[num].string_1 == string_1)
                        {
                            break;
                        }
                        num++;
                        continue;
                    }
                    var item = default(Struct33);
                    item.byte_0 = 1;
                    item.string_1 = string_1;
                    item.byte_1 = 0;
                    item.string_0 = DateTime.Now.ToString();
                    list_0.Add(item);
                    return 1;
                }
                return -1;
            }
        }
        catch
        {
            return -2;
        }
    }

    public static bool smethod_3(Struct33 struct33_0)
    {
        try
        {
            lock (object_1)
            {
                list_0.Add(struct33_0);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    public static bool smethod_4(string string_1, Struct33 struct33_0)
    {
        try
        {
            lock (object_1)
            {
                int num = 0;
                while (true)
                {
                    if (num < list_0.Count)
                    {
                        _ = list_0[num];
                        if (list_0[num].byte_1 == 0 && list_0[num].string_1 == string_1)
                        {
                            break;
                        }
                        num++;
                        continue;
                    }
                    return false;
                }
                list_0[num] = struct33_0;
                return true;
            }
        }
        catch
        {
            return false;
        }
    }
    public static bool smethod_1() {
        try {
            lock (object_1) {
                list_0.Clear();
                return true;
            }
        }
        catch {
            return false;
        }
    }



    public static bool smethod_5(string string_1) {
        try {
            lock (object_1) {
                for (int i = 0; i < list_0.Count; i++) {
                    _ = list_0[i];
                    if (list_0[i].byte_1 == 0 && list_0[i].string_1 == string_1) {
                        list_0.RemoveAt(i);
                    }
                }
                return true;
            }
        }
        catch {
            return false;
        }
    }
}
