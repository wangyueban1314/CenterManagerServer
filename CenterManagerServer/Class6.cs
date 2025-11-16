internal static class Class6 {
    public delegate void Delegate1(Struct53 struct53_0);

    public delegate void Delegate2(Struct53 struct53_0);

    public static Delegate1 delegate1_0;

    public static Delegate2 delegate2_0=null;

    public static bool smethod_0(ushort ushort_0, string string_0, int int_0) {
        try {
            if (Class8.bool_68) {
                var struct53_ = default(Struct53);
                struct53_.ushort_0 = ushort_0;
                struct53_.int_0 = int_0;
                struct53_.string_0 = string_0;
                delegate1_0(struct53_);
            }
            return true;
        }
        catch {
            return false;
        }
    }
    public static bool smethod_4(ushort ushort_0, string string_0, params string[] string_1)
    {
        try
        {
            var struct53_ = default(Struct53);
            struct53_.ushort_0 = ushort_0;
            struct53_.int_0 = 0;
            string text = "";
            for (int i = 0; i < string_1.Length; i++)
            {
                text = ((!(text == "")) ? (text + "," + string_1[i].ToString()) : (text + string_1[i].ToString()));
            }
            struct53_.string_0 = string_0 + " " + text;
            delegate2_0(struct53_);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool smethod_5(ushort ushort_0, string string_0)
    {
        try
        {
            var struct53_ = default(Struct53);
            struct53_.ushort_0 = ushort_0;
            struct53_.int_0 = 0;
            struct53_.string_0 = string_0;
            delegate2_0(struct53_);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public static bool smethod_2(ushort ushort_0)
    {
        try
        {
            if (Class8.bool_68)
            {
                var struct53_ = default(Struct53);
                struct53_.ushort_0 = ushort_0;
                struct53_.int_0 = 0;
                struct53_.string_0 = "";
                delegate1_0(struct53_);
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool smethod_3(ushort ushort_0, string string_0, params string[] string_1)
    {
        var struct53_ = default(Struct53);
        struct53_.ushort_0 = ushort_0;
        struct53_.int_0 = 0;
        string text = "";
        for (int i = 0; i < string_1.Length; i++)
        {
            text = ((!(text == "")) ? (text + "," + string_1[i].ToString()) : (text + string_1[i].ToString()));
        }
        struct53_.string_0 = string_0 + " " + text;
        delegate1_0(struct53_);
        return true;
    }



    public static bool smethod_7(ushort ushort_0)
    {
        try
        {
            var struct53_ = default(Struct53);
            struct53_.ushort_0 = ushort_0;
            struct53_.int_0 = 0;
            struct53_.string_0 = "";
            delegate2_0(struct53_);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public static bool smethod_6(ushort ushort_0, int int_0)
    {
        try
        {
            var struct53_ = default(Struct53);
            struct53_.ushort_0 = ushort_0;
            struct53_.int_0 = int_0;
            struct53_.string_0 = "";
            delegate2_0(struct53_);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public static bool smethod_1(ushort ushort_0, string string_0) {
        try {
            if (Class8.bool_68) {
                var struct53_ = default(Struct53);
                struct53_.ushort_0 = ushort_0;
                struct53_.int_0 = 0;
                struct53_.string_0 = string_0;
                delegate1_0(struct53_);
            }
            return true;
        }
        catch {
            return false;
        }
    }



    public static bool smethod_8() {
        try {
            if (Class8.bool_68) {
                var struct53_ = default(Struct53);
                struct53_.ushort_0 = 10;
                struct53_.int_0 = 0;
                struct53_.string_0 = "Msg";
                delegate1_0(struct53_);
            }
            return true;
        }
        catch {
            return false;
        }
    }
}
