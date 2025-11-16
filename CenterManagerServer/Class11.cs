using System;
using System.Collections.Generic;
using System.Timers;

internal class Class11 {
    private Timer timer_0 = new Timer();

    private object object_0 = new object();

    protected Class46 class46_0 = new Class46();

    private List<Class22> list_0 = new List<Class22>();

    private void timer_0_Elapsed(object sender, ElapsedEventArgs e) {
        try {
            var list = method_22();
            int num = 0;
            while (true) {
                if (num < list.Count) {
                    if (Class9.smethod_0() - list[num].int_0 > 120000) {
                        break;
                    }
                    num++;
                    continue;
                }
                return;
            }
            class46_0.method_40(list[num].intptr_0);
        }
        catch {
        }
    }
    protected virtual Enum2 vmethod_4(Class46 class46_1, IntPtr intptr_0, byte[] byte_0)
    {
        try
        {
            try
            {
                var class22_ = new Class22();
                if (!method_30(intptr_0, ref class22_))
                {
                    return Enum2.const_2;
                }
                method_2(intptr_0, class22_, byte_0);
            }
            catch
            {
                return Enum2.const_2;
            }
            return Enum2.const_0;
        }
        catch
        {
            return Enum2.const_2;
        }
    }

    protected virtual Enum2 vmethod_5(Class46 class46_1, IntPtr intptr_0, Enum3 enum3_0, int int_0)
    {
        try
        {
            var class22_ = new Class22();
            if (!method_30(intptr_0, ref class22_))
            {
                return Enum2.const_2;
            }
            method_28(intptr_0);
            Class6.smethod_1(1, "GameControlServer 连接关闭");
        }
        catch
        {
            return Enum2.const_2;
        }
        return Enum2.const_0;
    }

    public void method_2(IntPtr intptr_0, Class22 class22_0, byte[] byte_0)
    {
        byte[] byte_ = class22_0.byte_0;
        byte[] array = null;
        if (byte_ != null)
        {
            int num = 0;
            byte[] array2 = Class1.smethod_12(byte_, byte_0);
            if (array2.Length < 8)
            {
                method_26(intptr_0, class22_0, array2);
                byte_ = array2;
                return;
            }
            num = Class17.smethod_7(array2, 0) - byte_.Length;
            if (byte_0.Length < num)
            {
                method_26(intptr_0, class22_0, array2);
                byte_ = array2;
                return;
            }
            method_26(intptr_0, class22_0, null);
            byte_ = null;
            array = array2;
        }
        else if (byte_0.Length < 8)
        {
            method_26(intptr_0, class22_0, byte_0);
            byte_ = byte_0;
            return;
        }
        if (array == null)
        {
            array = byte_0;
        }
        int num2 = Class17.smethod_7(array, 0);
        if (num2 == array.Length)
        {
            method_3(intptr_0, class22_0, array);
        }
        else if (num2 > array.Length)
        {
            method_26(intptr_0, class22_0, array);
            byte_ = array;
        }
        else
        {
            if (num2 >= array.Length)
            {
                return;
            }
            while (true)
            {
                if (array.Length != 0)
                {
                    if (array.Length < 8)
                    {
                        break;
                    }
                    num2 = Class17.smethod_7(array, 0);
                    if (num2 <= array.Length)
                    {
                        byte[] byte_2 = Class1.smethod_14(array, num2);
                        array = Class1.smethod_13(array, array.Length - num2);
                        method_3(intptr_0, class22_0, byte_2);
                        continue;
                    }
                    method_26(intptr_0, class22_0, array);
                    byte_ = array;
                    return;
                }
                return;
            }
            method_26(intptr_0, class22_0, array);
            byte_ = array;
        }
    }

    public void method_3(IntPtr intptr_0, Class22 class22_0, byte[] byte_0)
    {
        if (byte_0.Length >= 8)
        {
            var @class = new Class14(byte_0);
            @class.ReadInt32();
            ushort num = @class.ReadUInt16();
            ushort ushort_ = @class.ReadUInt16();
            switch (num)
            {
                case 4096:
                    class22_0.int_0 = Class9.smethod_0();
                    method_29(intptr_0, class22_0);
                    break;
                case 4097:
                    method_24(intptr_0, class22_0, @class, ushort_);
                    break;
                case 4113:
                    method_25(intptr_0, class22_0, @class, ushort_);
                    break;
                case 4128:
                    method_23(intptr_0, class22_0, @class, ushort_);
                    break;
            }
        }
    }

    private void method_23(IntPtr intptr_0, Class22 class22_0, Class14 class14_0, ushort ushort_0)
    {
        byte b = class14_0.ReadByte();
        byte b2 = class14_0.ReadByte();
        switch (b)
        {
            case 1:
                if (b2 == 0)
                {
                    int count2 = class14_0.ReadInt32();
                    class14_0.ReadBytes(count2);
                }
                break;
            case 2:
                if (b2 == 0)
                {
                    int count = class14_0.ReadInt32();
                    byte[] byte_ = class14_0.ReadBytes(count);
                    Class24.class23_0.method_3(2, 0, byte_);
                }
                break;
        }
    }

    private void method_24(IntPtr intptr_0, Class22 class22_0, Class14 class14_0, ushort ushort_0)
    {
        byte b = class14_0.ReadByte();
        class14_0.ReadByte();
        string text = class14_0.method_0();
        if (text == "")
        {
            Class6.smethod_1(1, "GameControlServer Name 参数错误");
            return;
        }
        int num = class14_0.ReadInt32();
        if (num < 0)
        {
            Class6.smethod_1(1, "GameControlServer Ver 参数错误");
            return;
        }
        if (class14_0.method_0() == "")
        {
            Class6.smethod_1(1, "GameControlServer AppMD5 参数错误");
            return;
        }
        string text2 = class14_0.method_0();
        if (text2 == "")
        {
            Class6.smethod_1(1, "GameControlServer PCName 参数错误");
            return;
        }
        if (class14_0.method_0() == "")
        {
            Class6.smethod_1(1, "GameControlServer PCInfo 参数错误");
            return;
        }
        class22_0.string_0 = text;
        class22_0.int_1 = num;
        class22_0.string_1 = text2;
        class22_0.int_0 = Class9.smethod_0();
        if (!method_29(intptr_0, class22_0))
        {
            Class7.smethod_2(class22_0.string_2, "GameControlServer SetConnectionExtra Error Opcode:0x1001");
            return;
        }
        if (Class2.byte_0 == 1)
        {
            method_13(intptr_0, 10, 0, 1, Class2.int_1, Class2.int_0, Class2.byte_1);
        }
        else
        {
            method_12(intptr_0, 10, 0, 0);
        }
        switch (b)
        {
            case 1:
                method_18(intptr_0, 1, 0);
                method_19(intptr_0, 1, 0, Class2.ushort_0);
                if (Class2.int_4 == 1)
                {
                    method_10(intptr_0, 2, 0, Class2.int_4, Class2.byte_2);
                }
                Class24.class23_0.method_7(8, 0, num);
                Class6.smethod_1(1, "GameControlServer 已连接");
                break;
            case 2:
                method_18(intptr_0, 2, 0);
                Class6.smethod_1(1, "GameControlServer 已重新连接");
                break;
            default:
                Class6.smethod_1(1, "GameControlServer 连接异常");
                break;
        }
    }

    private void method_25(IntPtr intptr_0, Class22 class22_0, Class14 class14_0, ushort ushort_0)
    {
        byte num = class14_0.ReadByte();
        byte b = class14_0.ReadByte();
        if (num == 1 && b == 0)
        {
            long long_ = class14_0.ReadInt64();
            Class12.class3_0.method_57(long_);
        }
    }

    public bool method_4(byte[] byte_0)
    {
        var list = method_22();
        for (int i = 0; i < list.Count; i++)
        {
            method_16(list[i].intptr_0, 1, 0, byte_0);
        }
        return true;
    }

    public bool method_5(int int_0, byte[] byte_0)
    {
        var list = method_22();
        for (int i = 0; i < list.Count; i++)
        {
            method_10(list[i].intptr_0, 2, 0, int_0, byte_0);
        }
        return true;
    }
    public Class11() {
        class46_0.method_14(vmethod_0);
        class46_0.method_10(vmethod_2);
        class46_0.method_12(vmethod_3);
        class46_0.method_16(vmethod_4);
        class46_0.method_20(vmethod_5);
        class46_0.method_22(vmethod_1);
        class46_0.method_84(Enum4.const_2);
        timer_0.Interval = 1000.0;
        timer_0.Elapsed += timer_0_Elapsed;
        timer_0.Start();
    }

    public bool method_0() {
        class46_0.method_7("0.0.0.0");
        class46_0.method_9(Class2.ushort_1);
        return class46_0.method_27();
    }

    public bool method_1() {
        return class46_0.method_28();
    }

    protected virtual Enum2 vmethod_0(Class46 class46_1, IntPtr intptr_0) {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_1(Class46 class46_1) {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_2(Class46 class46_1, IntPtr intptr_0, IntPtr intptr_1) {
        try {
            string string_ = string.Empty;
            ushort ushort_ = 0;
            if (!class46_0.method_47(intptr_0, ref string_, ref ushort_)) {
                return Enum2.const_2;
            }
            if (string_ != Class8.string_2) {
                return Enum2.const_2;
            }
            var @class = new Class22();
            @class.intptr_0 = intptr_0;
            @class.byte_0 = null;
            @class.int_0 = Class9.smethod_0();
            @class.string_2 = string_;
            @class.string_0 = "";
            @class.int_1 = 0;
            @class.string_1 = "";
            if (!method_27(@class)) {
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



    public bool method_6(int int_0) {
        var list = method_22();
        for (int i = 0; i < list.Count; i++) {
            method_11(list[i].intptr_0, 3, 0, int_0);
        }
        return true;
    }

    public bool method_7(int int_0) {
        var list = method_22();
        for (int i = 0; i < list.Count; i++) {
            method_14(list[i].intptr_0, 9, 0, int_0);
        }
        return true;
    }

    public bool method_8() {
        var list = method_22();
        for (int i = 0; i < list.Count; i++) {
            method_15(list[i].intptr_0, 1, 0);
        }
        return true;
    }

    public bool method_9(byte[] byte_0) {
        var list = method_22();
        for (int i = 0; i < list.Count; i++) {
            method_17(list[i].intptr_0, 2, 0, byte_0);
        }
        return true;
    }



    public List<Class22> method_22() {
        var result = new List<Class22>();
        try {
            lock (object_0) {
                result = new List<Class22>(list_0);
                return result;
            }
        }
        catch {
            return result;
        }
    }

    private bool method_26(IntPtr intptr_0, Class22 class22_0, byte[] byte_0) {
        try {
            class22_0.byte_0 = byte_0;
            if (method_29(intptr_0, class22_0)) {
                return true;
            }
            return false;
        }
        catch {
            return false;
        }
    }

    private bool method_27(Class22 class22_0) {
        try {
            lock (object_0) {
                list_0.Add(class22_0);
                return true;
            }
        }
        catch {
            return false;
        }
    }

    private bool method_28(IntPtr intptr_0) {
        try {
            lock (object_0) {
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
    public bool method_10(IntPtr intptr_0, byte byte_0, byte byte_1, int int_0, byte[] byte_2)
    {
        var @class = new Class21();
        @class.Write(byte_0);
        @class.Write(byte_1);
        @class.Write(int_0);
        @class.Write(byte_2.Length);
        @class.Write(byte_2);
        return method_20(intptr_0, 8209, @class.method_0());
    }

    public bool method_11(IntPtr intptr_0, byte byte_0, byte byte_1, int int_0)
    {
        var @class = new Class21();
        @class.Write(byte_0);
        @class.Write(byte_1);
        @class.Write(int_0);
        return method_20(intptr_0, 8209, @class.method_0());
    }

    public bool method_12(IntPtr intptr_0, byte byte_0, byte byte_1, byte byte_2)
    {
        var @class = new Class21();
        @class.Write(byte_0);
        @class.Write(byte_1);
        @class.Write(byte_2);
        return method_20(intptr_0, 8209, @class.method_0());
    }

    public bool method_13(IntPtr intptr_0, byte byte_0, byte byte_1, byte byte_2, int int_0, int int_1, byte[] byte_3)
    {
        var @class = new Class21();
        @class.Write(byte_0);
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.Write(int_0);
        @class.Write(int_1);
        @class.Write(byte_3.Length);
        @class.Write(byte_3);
        return method_20(intptr_0, 8209, @class.method_0());
    }

    public bool method_14(IntPtr intptr_0, byte byte_0, byte byte_1, int int_0)
    {
        var @class = new Class21();
        @class.Write(byte_0);
        @class.Write(byte_1);
        @class.Write(int_0);
        return method_20(intptr_0, 8209, @class.method_0());
    }

    public bool method_15(IntPtr intptr_0, byte byte_0, byte byte_1)
    {
        var @class = new Class21();
        @class.Write(byte_0);
        @class.Write(byte_1);
        return method_20(intptr_0, 8197, @class.method_0());
    }

    public bool method_16(IntPtr intptr_0, byte byte_0, byte byte_1, byte[] byte_2)
    {
        var @class = new Class21();
        @class.Write(byte_0);
        @class.Write(byte_1);
        @class.Write(byte_2.Length);
        @class.Write(byte_2);
        return method_20(intptr_0, 8211, @class.method_0());
    }

    public bool method_17(IntPtr intptr_0, byte byte_0, byte byte_1, byte[] byte_2)
    {
        var @class = new Class21();
        @class.Write(byte_0);
        @class.Write(byte_1);
        @class.Write(byte_2.Length);
        @class.Write(byte_2);
        return method_20(intptr_0, 8224, @class.method_0());
    }

    public bool method_18(IntPtr intptr_0, byte byte_0, byte byte_1)
    {
        var @class = new Class21();
        @class.Write(byte_0);
        @class.Write(byte_1);
        return method_20(intptr_0, 8193, @class.method_0());
    }

    public bool method_19(IntPtr intptr_0, byte byte_0, byte byte_1, ushort ushort_0)
    {
        var @class = new Class21();
        @class.Write(byte_0);
        @class.Write(byte_1);
        @class.Write(ushort_0);
        return method_20(intptr_0, 8209, @class.method_0());
    }

    public bool method_20(IntPtr intptr_0, ushort ushort_0, byte[] byte_0)
    {
        var @class = new Class21();
        @class.Write(0);
        @class.Write(ushort_0);
        @class.Write((ushort)0);
        @class.Write(byte_0);
        byte[] array = @class.method_0();
        Array.Copy(BitConverter.GetBytes(byte_0.Length), 0, array, 0, 4);
        try
        {
            return class46_0.method_30(intptr_0, array, array.Length);
        }
        catch
        {
            return false;
        }
    }

    public bool method_21(IntPtr intptr_0, ushort ushort_0)
    {
        var @class = new Class21();
        @class.Write(0);
        @class.Write(ushort_0);
        @class.Write((ushort)0);
        byte[] array = @class.method_0();
        try
        {
            return class46_0.method_30(intptr_0, array, array.Length);
        }
        catch
        {
            return false;
        }
    }
    private bool method_29(IntPtr intptr_0, Class22 class22_0) {
        try {
            lock (object_0) {
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
                    list_0[num] = class22_0;
                    return true;
                }
                return false;
            }
        }
        catch {
            return false;
        }
    }

    private bool method_30(IntPtr intptr_0, ref Class22 class22_0) {
        try {
            lock (object_0) {
                class22_0 = new Class22();
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
                    class22_0 = list_0[num];
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
