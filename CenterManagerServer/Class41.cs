using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;

internal class Class41 {
    public List<Class44> list_0 = new List<Class44>();

    private object object_0 = new object();

    [CompilerGenerated]
    private ushort ushort_0;

    protected Class46 class46_0 = new Class46();

    [CompilerGenerated]
    public ushort method_0() {
        return ushort_0;
    }

    [CompilerGenerated]
    public void method_1(ushort ushort_1) {
        ushort_0 = ushort_1;
    }



    public bool method_4(IntPtr intptr_0, bool bool_0 = true) {
        return class46_0.method_40(intptr_0, bool_0);
    }

    protected virtual Enum2 vmethod_0(Class46 class46_1, IntPtr intptr_0) {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_1(Class46 class46_1) {
        return Enum2.const_0;
    }
    public void method_7(IntPtr intptr_0, ushort ushort_1, byte[] byte_0)
    {
        try
        {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_1);
            @class.Write((ushort)0);
            @class.Write(byte_0);
            byte[] array = @class.method_0();
            Array.Copy(BitConverter.GetBytes((ushort)byte_0.Length), 0, array, 0, 2);
            array = Class28.smethod_2(array, "Reg");
            class46_0.method_30(intptr_0, array, array.Length);
        }
        catch
        {
        }
    }

    public void method_8(IntPtr intptr_0, ushort ushort_1)
    {
        try
        {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_1);
            @class.Write((ushort)0);
            byte[] byte_ = @class.method_0();
            byte_ = Class28.smethod_2(byte_, "Reg");
            class46_0.method_30(intptr_0, byte_, byte_.Length);
        }
        catch
        {
        }
    }

    public bool method_9(string string_0)
    {
        try
        {
            lock (Class13.object_1)
            {
                int num = 0;
                while (true)
                {
                    if (num >= Class13.list_0.Count)
                    {
                        return false;
                    }
                    var @struct = Class13.list_0[num];
                    if (@struct.byte_0 == 1 && @struct.byte_1 == 0 && @struct.string_1 == string_0)
                    {
                        break;
                    }
                    num++;
                }
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private string method_12(int int_0)
    {
        string text = string.Empty;
        var random = new Random();
        for (int i = 0; i < int_0; i++)
        {
            int num = random.Next();
            text += ((num % 3 != 0) ? ((char)(48 + (ushort)(num % 10))) : ((char)(65 + (ushort)(num % 26))));
        }
        return text;
    }

    private byte[] method_13(string string_0)
    {
        int num = 45;
        var bitmap = new Bitmap(string_0.Length * 16, 22);
        var graphics = Graphics.FromImage(bitmap);
        graphics.Clear(Color.AliceBlue);
        graphics.DrawRectangle(new Pen(Color.Black, 0f), 0, 0, bitmap.Width - 1, bitmap.Height - 1);
        var random = new Random();
        var pen = new Pen(Color.LightGray, 0f);
        for (int i = 0; i < 50; i++)
        {
            int x = random.Next(0, bitmap.Width);
            int y = random.Next(0, bitmap.Height);
            graphics.DrawRectangle(pen, x, y, 1, 1);
        }
        char[] array = string_0.ToCharArray();
        var stringFormat = new StringFormat(StringFormatFlags.NoClip);
        stringFormat.Alignment = StringAlignment.Center;
        stringFormat.LineAlignment = StringAlignment.Center;
        var array2 = new Color[8]
        {
            Color.Black,
            Color.Red,
            Color.DarkBlue,
            Color.Green,
            Color.Orange,
            Color.Brown,
            Color.DarkCyan,
            Color.Purple
        };
        string[] array3 = new string[5] { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };
        int num2 = random.Next(7);
        for (int j = 0; j < array.Length; j++)
        {
            int num3 = random.Next(5);
            var font = new Font(array3[num3], 14f, FontStyle.Bold);
            Brush brush = new SolidBrush(array2[num2]);
            var point = new Point(14, 14);
            float num4 = random.Next(-num, num);
            graphics.TranslateTransform(point.X, point.Y);
            graphics.RotateTransform(num4);
            graphics.DrawString(array[j].ToString(), font, brush, 1f, 1f, stringFormat);
            graphics.RotateTransform(0f - num4);
            graphics.TranslateTransform(-2f, -point.Y);
        }
        var memoryStream = new MemoryStream();
        bitmap.Save(memoryStream, ImageFormat.Gif);
        graphics.Dispose();
        bitmap.Dispose();
        return memoryStream.ToArray();
    }


    private bool method_16(IntPtr intptr_0, Class44 class44_0)
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
                            if (list_0[num].intptr_0 == intptr_0)
                            {
                                break;
                            }
                            num++;
                            continue;
                        }
                        return false;
                    }
                    list_0[num] = class44_0;
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
    protected virtual Enum2 vmethod_2(Class46 class46_1, IntPtr intptr_0, IntPtr intptr_1) {
        try {
            string string_ = string.Empty;
            ushort ushort_ = 0;
            if (!class46_0.method_47(intptr_0, ref string_, ref ushort_)) {
                return Enum2.const_2;
            }
            if (method_9(string_)) {
                method_4(intptr_0);
                return Enum2.const_0;
            }
            string string_2 = method_12(4);
            byte[] byte_ = method_13(string_2);
            method_7(intptr_0, 4097, byte_);
            var @class = new Class44();
            @class.intptr_0 = intptr_0;
            @class.byte_0 = null;
            @class.int_0 = 0;
            @class.int_1 = Class9.smethod_0();
            @class.string_0 = string_2;
            if (!method_14(intptr_0, @class)) {
                return Enum2.const_2;
            }
            return Enum2.const_0;
        }
        catch {
            return Enum2.const_2;
        }
    }

    protected virtual Enum2 vmethod_3(Class46 class46_1, IntPtr intptr_0, byte[] byte_0) {
        return Enum2.const_0;
    }
    public Class41()
    {
        class46_0.method_14(vmethod_0);
        class46_0.method_10(vmethod_2);
        class46_0.method_12(vmethod_3);
        class46_0.method_16(vmethod_4);
        class46_0.method_20(vmethod_5);
        class46_0.method_22(vmethod_1);
        class46_0.method_64(4096u);
        class46_0.method_84(Enum4.const_2);
    }

    public bool method_2()
    {
        string string_ = "0.0.0.0";
        class46_0.method_7(string_);
        class46_0.method_9(method_0());
        return class46_0.method_27();
    }

    public bool method_3()
    {
        return class46_0.method_28();
    }
    protected virtual Enum2 vmethod_4(Class46 class46_1, IntPtr intptr_0, byte[] byte_0) {
        try {
            string string_ = string.Empty;
            ushort ushort_ = 0;
            if (!class46_0.method_47(intptr_0, ref string_, ref ushort_)) {
                return Enum2.const_2;
            }
            try {
                var class44_ = new Class44();
                if (!method_17(intptr_0, ref class44_)) {
                    return Enum2.const_2;
                }
                byte[] byte_ = byte_0;
                byte_ = Class28.smethod_3(byte_, "Reg");
                method_5(intptr_0, class44_, byte_);
            }
            catch {
            }
            return Enum2.const_0;
        }
        catch {
            return Enum2.const_2;
        }
    }

    protected virtual Enum2 vmethod_5(Class46 class46_1, IntPtr intptr_0, Enum3 enum3_0, int int_0) {
        if (!method_15(intptr_0)) {
            return Enum2.const_2;
        }
        return Enum2.const_0;
    }

    public void method_5(IntPtr intptr_0, Class44 class44_0, byte[] byte_0) {
        byte[] byte_ = class44_0.byte_0;
        if (byte_ != null && byte_.Length > 65535) {
            return;
        }
        byte[] array = null;
        if (byte_ != null) {
            int num = 0;
            byte[] array2 = Class1.smethod_12(byte_, byte_0);
            if (array2.Length < 6) {
                method_11(intptr_0, class44_0, array2);
                byte_ = array2;
                return;
            }
            num = Class17.smethod_6(array2, 0) - byte_.Length;
            if (byte_0.Length < num) {
                method_11(intptr_0, class44_0, array2);
                byte_ = array2;
                return;
            }
            method_11(intptr_0, class44_0, null);
            byte_ = null;
            array = array2;
        }
        else if (byte_0.Length < 6) {
            method_11(intptr_0, class44_0, byte_0);
            byte_ = byte_0;
            return;
        }
        if (array == null) {
            array = byte_0;
        }
        ushort num2 = Class17.smethod_6(array, 0);
        if (num2 == array.Length) {
            method_6(intptr_0, class44_0, array);
        }
        else if (num2 > array.Length) {
            method_11(intptr_0, class44_0, array);
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
                        method_6(intptr_0, class44_0, byte_2);
                        continue;
                    }
                    method_11(intptr_0, class44_0, array);
                    byte_ = array;
                    return;
                }
                return;
            }
            method_11(intptr_0, class44_0, array);
            byte_ = array;
        }
    }

    public string method_10(IntPtr intptr_0, bool bool_0)
    {
        try
        {
            string string_ = string.Empty;
            ushort ushort_ = 0;
            if (class46_0.method_47(intptr_0, ref string_, ref ushort_))
            {
                if (bool_0)
                {
                    return string_ + ":" + ushort_;
                }
                return string_;
            }
            return "";
        }
        catch
        {
            return "";
        }
    }

    public bool method_11(IntPtr intptr_0, Class44 class44_0, byte[] byte_0)
    {
        try
        {
            class44_0.byte_0 = byte_0;
            if (method_16(intptr_0, class44_0))
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

    private bool method_14(IntPtr intptr_0, Class44 class44_0)
    {
        try
        {
            lock (object_0)
            {
                list_0.Add(class44_0);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private bool method_15(IntPtr intptr_0)
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
                            if (list_0[num].intptr_0 == intptr_0)
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
        }
        catch
        {
            return false;
        }
    }
    public void method_6(IntPtr intptr_0, Class44 class44_0, byte[] byte_0) {
        if (byte_0.Length <= 5) {
            return;
        }
        ushort num = (ushort)BitConverter.ToInt16(byte_0, 2);
        var @class = new Class14(byte_0);
        @class.ReadBytes(6);
        switch (num) {
            case 4097: {
                string string_ = method_12(4);
                byte[] byte_ = method_13(string_);
                method_7(intptr_0, 4097, byte_);
                class44_0.string_0 = string_;
                method_16(intptr_0, class44_0);
                break;
            }
            case 4098: {
                if (byte_0.Length <= 10) {
                    break;
                }
                string text5 = @class.method_0();
                if (text5.Length == 4) {
                    if (text5.ToLower() != class44_0.string_0.ToLower()) {
                        method_7(intptr_0, 4098, new byte[2] { 1, 1 });
                        break;
                    }
                    string text6 = @class.method_0().ToLower();
                    if (text6.Length < 16) {
                        if (Class9.smethod_6(text6, 3)) {
                            method_7(intptr_0, 4098, new byte[2] { 1, 2 });
                            break;
                        }
                        string text7 = @class.method_0().ToLower();
                        if (text7.Length == 32) {
                            if (Class9.smethod_6(text7, 3)) {
                                method_7(intptr_0, 4098, new byte[2] { 1, 3 });
                                break;
                            }
                            string text8 = @class.method_0();
                            if (text8.Length < 45) {
                                if (Class9.smethod_6(text8, 4)) {
                                    method_7(intptr_0, 4098, new byte[2] { 1, 4 });
                                    break;
                                }
                                string text9 = @class.method_0();
                                if (text9.Length < 18) {
                                    if (Class9.smethod_6(text9, 2)) {
                                        method_7(intptr_0, 4098, new byte[2] { 1, 5 });
                                        break;
                                    }
                                    if (Class5.smethod_55(text6) == 1) {
                                        method_7(intptr_0, 4098, new byte[2] { 1, 6 });
                                        break;
                                    }
                                    if (Class8.bool_26 && Class5.smethod_56(text8) != 1) {
                                        method_7(intptr_0, 4098, new byte[2] { 1, 8 });
                                        break;
                                    }
                                    if (Class5.smethod_57(text6, text7, text8, text9, method_10(intptr_0, bool_0: false)) > 0) {
                                        Class6.smethod_0(7, text6, 0);
                                        method_7(intptr_0, 4098, new byte[2] { 1, 10 });
                                        break;
                                    }
                                    Class7.smethod_2(method_10(intptr_0, bool_0: false), string.Concat("Opcode:" + num + " SQL_Add_UserID Code:" + text6, text7, " ", text8, " ", text9));
                                    method_7(intptr_0, 4098, new byte[2] { 1, 7 });
                                    break;
                                }
                            }
                        }
                    }
                }
                method_7(intptr_0, 4098, new byte[2] { 1, 9 });
                break;
            }
            case 4099: {
                if (byte_0.Length <= 10) {
                    break;
                }
                string text = @class.method_0();
                if (text.Length == 4) {
                    if (text.ToLower() != class44_0.string_0.ToLower()) {
                        method_7(intptr_0, 4099, new byte[2] { 2, 1 });
                        break;
                    }
                    string text2 = @class.method_0().ToLower();
                    if (text2.Length < 16) {
                        if (Class9.smethod_6(text2, 3)) {
                            method_7(intptr_0, 4099, new byte[2] { 2, 2 });
                            break;
                        }
                        string text3 = @class.method_0();
                        if (text3.Length == 32) {
                            if (Class9.smethod_6(text3, 3)) {
                                method_7(intptr_0, 4099, new byte[2] { 2, 3 });
                                break;
                            }
                            string text4 = @class.method_0();
                            if (text4.Length == 32) {
                                if (Class9.smethod_6(text4, 3)) {
                                    method_7(intptr_0, 4099, new byte[2] { 2, 4 });
                                }
                                else if (Class5.smethod_55(text2) != 1) {
                                    method_7(intptr_0, 4099, new byte[2] { 2, 5 });
                                }
                                else if (Class5.smethod_58(text2, text3) != 1) {
                                    method_7(intptr_0, 4099, new byte[2] { 2, 6 });
                                }
                                else if (Class5.smethod_59(text2, text4) > 0) {
                                    method_7(intptr_0, 4099, new byte[2] { 2, 10 });
                                }
                                else {
                                    Class7.smethod_2(method_10(intptr_0, bool_0: false), string.Concat("Opcode:" + num + " SQL_Update_UserID_Password_Error Code:" + text2, text3, " ", text4));
                                    method_7(intptr_0, 4099, new byte[2] { 2, 7 });
                                }
                                break;
                            }
                        }
                    }
                }
                method_7(intptr_0, 4099, new byte[2] { 2, 8 });
                break;
            }
        }
    }



    private bool method_17(IntPtr intptr_0, ref Class44 class44_0) {
        try {
            lock (object_0) {
                class44_0 = new Class44();
                if (list_0.Count > 0) {
                    int num = 0;
                    while (true) {
                        if (num < list_0.Count) {
                            if (list_0[num].intptr_0 == intptr_0) {
                                break;
                            }
                            num++;
                            continue;
                        }
                        return false;
                    }
                    class44_0 = list_0[num];
                    return true;
                }
                return false;
            }
        }
        catch {
            return false;
        }
    }
}
