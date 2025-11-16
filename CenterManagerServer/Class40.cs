using System;
using System.Runtime.CompilerServices;

internal class Class40 {
    [CompilerGenerated]
    private ushort ushort_0;

    protected Class46 class46_0 = new Class46();

    private byte[] byte_0;

    [CompilerGenerated]
    public ushort method_0() {
        return ushort_0;
    }

    [CompilerGenerated]
    public void method_1(ushort ushort_1) {
        ushort_0 = ushort_1;
    }

    public Class40() {
        class46_0.method_14(vmethod_0);
        class46_0.method_10(vmethod_2);
        class46_0.method_12(vmethod_3);
        class46_0.method_16(vmethod_4);
        class46_0.method_20(vmethod_5);
        class46_0.method_22(vmethod_1);
        class46_0.method_64(4096u);
        class46_0.method_84(Enum4.const_2);
    }

    protected virtual Enum2 vmethod_4(Class46 class46_1, IntPtr intptr_0, byte[] byte_1)
    {
        try
        {
            string string_ = string.Empty;
            ushort ushort_ = 0;
            if (!class46_0.method_47(intptr_0, ref string_, ref ushort_))
            {
                return Enum2.const_2;
            }
            if (string_ != Class8.string_2)
            {
                class46_0.method_40(intptr_0);
            }
            try
            {
                method_5(intptr_0, byte_1);
            }
            catch
            {
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
        return Enum2.const_0;
    }
    public bool method_2() {
        string text = "0.0.0.0";
        if (string.IsNullOrEmpty(text)) {
            throw new Exception("请先设置属性[BindAddr,TargetAddr,BindPort,TargetPort]");
        }
        class46_0.method_7(text);
        class46_0.method_9(method_0());
        return class46_0.method_27();
    }

    public bool method_3() {
        return class46_0.method_28();
    }

    public bool method_4(IntPtr intptr_0, bool bool_0 = true) {
        return class46_0.method_40(intptr_0, bool_0);
    }
    public void method_6(IntPtr intptr_0, byte[] byte_1)
    {
        if (byte_1.Length <= 5)
        {
            return;
        }
        ushort num = (ushort)BitConverter.ToInt16(byte_1, 2);
        var @class = new Class14(byte_1);
        @class.ReadBytes(6);
        switch (num)
        {
            case 8193:
                {
                    string text = @class.method_0();
                    switch (@class.ReadByte())
                    {
                        case 0:
                            if (text == "GlobalManager")
                            {
                                var class3 = new Class21();
                                class3.method_1("Certification");
                                class3.Write((byte)0);
                                method_7(intptr_0, 8193, class3.method_0());
                            }
                            break;
                        case 1:
                            if (text == "GlobalManager")
                            {
                                var class2 = new Class21();
                                class2.method_1("Certification");
                                class2.Write((byte)1);
                                method_7(intptr_0, 8193, class2.method_0());
                            }
                            break;
                    }
                    break;
                }
            case 24579:
                {
                    @class.method_0();
                    @class.method_0();
                    byte[] byte_2 = Class9.smethod_7();
                    method_9(intptr_0, byte_2);
                    Class6.smethod_0(2, "GlobalManager 读取架构数据完成", 0);
                    break;
                }
        }
    }

    public void method_7(IntPtr intptr_0, ushort ushort_1, byte[] byte_1)
    {
        try
        {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_1);
            @class.Write((ushort)0);
            @class.Write(byte_1);
            byte[] array = @class.method_0();
            Array.Copy(BitConverter.GetBytes((ushort)byte_1.Length), 0, array, 0, 2);
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
            byte[] array = @class.method_0();
            class46_0.method_30(intptr_0, array, array.Length);
        }
        catch
        {
        }
    }
    protected virtual Enum2 vmethod_0(Class46 class46_1, IntPtr intptr_0) {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_1(Class46 class46_1) {
        return Enum2.const_0;
    }




    public void method_5(IntPtr intptr_0, byte[] byte_1) {
        byte[] array = null;
        if (byte_0 != null) {
            int num = 0;
            byte[] array2 = Class1.smethod_12(byte_0, byte_1);
            if (array2.Length < 6) {
                byte_0 = array2;
                return;
            }
            num = Class17.smethod_6(array2, 0) - byte_0.Length;
            if (byte_1.Length < num) {
                byte_0 = array2;
                return;
            }
            byte_0 = null;
            array = array2;
        }
        else if (byte_1.Length < 6) {
            byte_0 = byte_1;
            return;
        }
        if (array == null) {
            array = byte_1;
        }
        ushort num2 = Class17.smethod_6(array, 0);
        if (num2 == array.Length) {
            method_6(intptr_0, array);
        }
        else if (num2 > array.Length) {
            byte_0 = array;
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
                        method_6(intptr_0, byte_2);
                        continue;
                    }
                    byte_0 = array;
                    return;
                }
                return;
            }
            byte_0 = array;
        }
    }

    protected virtual Enum2 vmethod_2(Class46 class46_1, IntPtr intptr_0, IntPtr intptr_1)
    {
        try
        {
            string string_ = string.Empty;
            ushort ushort_ = 0;
            if (!class46_0.method_47(intptr_0, ref string_, ref ushort_))
            {
                return Enum2.const_2;
            }
            if (string_ != Class8.string_2)
            {
                class46_0.method_40(intptr_0);
            }
            class46_0.method_30(intptr_0, new byte[7] { 1, 0, 0, 80, 0, 0, 1 }, 7);
            return Enum2.const_0;
        }
        catch
        {
            return Enum2.const_2;
        }
    }

    protected virtual Enum2 vmethod_3(Class46 class46_1, IntPtr intptr_0, byte[] byte_1)
    {
        return Enum2.const_0;
    }

    public void method_9(IntPtr intptr_0, byte[] byte_1) {
        try {
            int num = 0;
            int num2 = 0;
            while (num2 != byte_1.Length) {
                if (byte_1.Length - num2 > 4089) {
                    num2 += 4089;
                    num++;
                }
                else {
                    num2 = num2 + byte_1.Length - num2;
                    num++;
                }
            }
            var @class = new Class21();
            @class.Write((ushort)5);
            @class.Write((ushort)24589);
            @class.Write((ushort)0);
            @class.Write((byte)1);
            @class.Write((ushort)num);
            @class.Write((ushort)40963);
            class46_0.method_30(intptr_0, @class.method_0(), @class.method_0().Length);
            if (byte_1.Length <= 4089) {
                return;
            }
            int num3 = 0;
            while (num3 != byte_1.Length) {
                if (byte_1.Length - num3 > 4089) {
                    byte[] array = new byte[4089];
                    Array.Copy(byte_1, num3, array, 0, 4089);
                    num3 += 4089;
                    num--;
                    @class = new Class21();
                    @class.Write((ushort)(array.Length + 1));
                    @class.Write((ushort)24589);
                    @class.Write((ushort)0);
                    @class.Write((byte)0);
                    @class.Write(array);
                    class46_0.method_30(intptr_0, @class.method_0(), @class.method_0().Length);
                }
                else {
                    byte[] array2 = new byte[byte_1.Length - num3];
                    Array.Copy(byte_1, num3, array2, 0, byte_1.Length - num3);
                    num3 = num3 + byte_1.Length - num3;
                    @class = new Class21();
                    @class.Write((ushort)(array2.Length + 1));
                    @class.Write((ushort)24589);
                    @class.Write((ushort)0);
                    @class.Write((byte)0);
                    @class.Write(array2);
                    class46_0.method_30(intptr_0, @class.method_0(), @class.method_0().Length);
                }
            }
        }
        catch {
        }
    }
}
