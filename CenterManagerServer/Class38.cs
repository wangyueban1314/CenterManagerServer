using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Timers;

internal class Class38 {
    private int int_0;

    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private ushort ushort_1;

    private object object_0 = new object();



    public string string_0 = "";

    private Timer timer_0 = new Timer();

    private List<IntPtr> list_1 = new List<IntPtr>();

    public List<Class39> list_0 = new List<Class39>();
    private object object_1 = new object();

    private object object_2 = new object();

    public bool bool_0 = true;

    public long long_0;

    public long long_1;
    protected Class46 class46_0 = new Class46();

    protected Class48 class48_0 = new Class48();

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
        return string_1;
    }

    [CompilerGenerated]
    public void method_3(string string_2) {
        string_1 = string_2;
    }

    [CompilerGenerated]
    public ushort method_4() {
        return ushort_1;
    }

    [CompilerGenerated]
    public void method_5(ushort ushort_2) {
        ushort_1 = ushort_2;
    }

    public Class38() {
        class46_0.method_14(vmethod_6);
        class46_0.method_10(vmethod_8);
        class46_0.method_12(vmethod_9);
        class46_0.method_16(vmethod_10);
        class46_0.method_20(vmethod_11);
        class46_0.method_22(vmethod_7);
        class46_0.method_64(4096u);
        class46_0.method_84(Enum4.const_2);
        class48_0.method_10(vmethod_0);
        class48_0.method_6(vmethod_1);
        class48_0.method_8(vmethod_3);
        class48_0.method_12(vmethod_4);
        class48_0.method_16(vmethod_5);
        class48_0.method_18(vmethod_2);
        class48_0.method_66(4096u);
        class48_0.method_84(Enum4.const_2);
        timer_0.Interval = 1.0;
        timer_0.Elapsed += timer_0_Elapsed;
        timer_0.Start();
    }

    private void timer_0_Elapsed(object sender, ElapsedEventArgs e) {
        for (int i = 0; i < list_1.Count; i++) {
            class46_0.method_40(list_1[i]);
        }
        if (list_1.Count > 0) {
            list_1.Clear();
        }
    }



    public bool method_8(IntPtr intptr_0, bool bool_1 = true) {
        return class46_0.method_40(intptr_0, bool_1);
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
            if (string_0 != empty && string_0 != "" && empty != Class8.string_2) {
                return Enum2.const_2;
            }
            if (method_9(empty)) {
                return Enum2.const_2;
            }
            lock (object_2) {
                var intptr_2 = IntPtr.Zero;
                if (!class48_0.method_25(method_2(), method_4(), ref intptr_2) && !class48_0.method_25(method_2(), method_4(), ref intptr_2) && !class48_0.method_25(method_2(), method_4(), ref intptr_2)) {
                    return Enum2.const_2;
                }
                var @class = new Class39();
                @class.intptr_0 = intptr_0;
                @class.intptr_1 = intptr_2;
                @class.uint_0 = 0u;
                @class.string_0 = empty;
                @class.string_1 = empty + ":" + num;
                @class.byte_0 = null;
                @class.byte_1 = null;
                @class.uint_1 = 0u;
                @class.uint_2 = 0u;
                @class.int_0 = 0;
                @class.int_1 = 0;
                @class.int_2 = Class9.smethod_0();
                if (!method_23(@class)) {
                    return Enum2.const_2;
                }
            }
        }
        catch {
        }
        return Enum2.const_0;
    }
    public int method_14(IntPtr intptr_0, Class39 class39_0, byte[] byte_0, out byte[] byte_1)
    {
        int num = 0;
        if (byte_0.Length >= 2)
        {
            int num2 = BitConverter.ToUInt16(byte_0, 0);
            if (num2 > 0)
            {
                num = Class15.Get_OpcodeAttack(num2, byte_0.Length);
                if (num == 1)
                {
                    byte_1 = null;
                    return 1;
                }
                if (num == 2)
                {
                    byte_1 = null;
                    return 1;
                }
                if (num < 65535)
                {
                    byte[] bytes = BitConverter.GetBytes(num);
                    class46_0.method_30(intptr_0, bytes, 4);
                }
            }
        }
        lock (object_1)
        {
            long_0 += byte_0.Length;
        }
        byte_1 = byte_0;

        if (Class8.bool_0 && byte_0.Length >= Class8.int_31)
        {
            if (Class9.smethod_0() - class39_0.int_2 < Class8.int_32)
            {
                if (class39_0.int_1 > Class8.int_33)
                {
                    if (!Class9.smethod_15(class39_0.string_0))
                    {
                        Class7.smethod_2(class39_0.string_1, "System Error:Add_BlockedIP");
                    }
                    Class6.smethod_0(2, "System GatewayServer 扫描到一次未知攻击,类型:Speed", 0);
                    Class7.smethod_2(class39_0.string_1, "System Att G Count Code:Speed " + class39_0.int_1);
                    return 1;
                }
                class39_0.int_1++;
                class39_0.int_2 = Class9.smethod_0();
                if (!method_25(intptr_0, class39_0, bool_1: true))
                {
                    Class7.smethod_2(class39_0.string_1, "System Error G Speed Set ErrorCode: 0002");
                    return 1;
                }
            }
            else
            {
                class39_0.int_2 = Class9.smethod_0();
                class39_0.int_1 = 0;
                if (!method_25(intptr_0, class39_0, bool_1: true))
                {
                    Class7.smethod_2(class39_0.string_1, "System Error G Speed Set ErrorCode: 0001");
                    return 1;
                }
            }
        }
        byte[] byte_2 = class39_0.byte_0;
        if (byte_2 != null && byte_2.Length > num)
        {
            return 1;
        }
        int num3 = 0;
        var list = new List<byte[]>();
        byte[] array = null;
        if (byte_2 != null)
        {
            int num4 = 0;
            byte[] array2 = Class1.smethod_12(byte_2, byte_0);
            if (array2.Length < 6)
            {
                method_21(intptr_0, class39_0, array2);
                byte_2 = array2;
                return 0;
            }
            num4 = Class17.smethod_6(array2, 0) - byte_2.Length;
            if (byte_0.Length < num4)
            {
                method_21(intptr_0, class39_0, array2);
                byte_2 = array2;
                return 0;
            }
            method_21(intptr_0, class39_0, null);
            byte_2 = null;
            array = array2;
        }
        else if (byte_0.Length < 6)
        {
            method_21(intptr_0, class39_0, byte_0);
            byte_2 = byte_0;
            return 0;
        }
        if (array == null)
        {
            array = byte_0;
        }
        ushort num5 = Class17.smethod_6(array, 0);
        if (num5 == array.Length)
        {
            num3 = method_15(intptr_0, class39_0, array);
            if (num3 == 2)
            {
                list.Add(array);
            }
        }
        else
        {
            if (num5 > array.Length)
            {
                method_21(intptr_0, class39_0, array);
                byte_2 = array;
                return 0;
            }
            if (num5 < array.Length)
            {
                int num6 = 0;
                while (array.Length != 0)
                {
                    if (array.Length >= 6)
                    {
                        num5 = Class17.smethod_6(array, 0);
                        if (num5 <= array.Length)
                        {
                            num6++;
                            if (num6 <= Class8.int_34)
                            {
                                byte[] array3 = Class1.smethod_14(array, num5);
                                array = Class1.smethod_13(array, array.Length - num5);
                                num3 = method_15(intptr_0, class39_0, array3);
                                switch (num3)
                                {
                                    case 2:
                                        list.Add(array3);
                                        continue;
                                    default:
                                        continue;
                                    case 1:
                                        break;
                                }
                            }
                            else
                            {
                                if (!Class9.smethod_15(class39_0.string_0))
                                {
                                    Class7.smethod_2(class39_0.string_1, "System Error:Add_BlockedIP");
                                }
                                Class6.smethod_0(2, "System GatewayServer 扫描到一次未知攻击,类型:Max", 0);
                                Class7.smethod_2(class39_0.string_1, "System Att G Count Code:MAX " + num6);
                                num3 = 1;
                            }
                            break;
                        }
                        method_21(intptr_0, class39_0, array);
                        byte_2 = array;
                        return 0;
                    }
                    method_21(intptr_0, class39_0, array);
                    byte_2 = array;
                    return 0;
                }
            }
        }
        switch (num3)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                if (list.Count > 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        byte[] byte_3 = list[i];
                        byte_1 = Class1.smethod_11(byte_1, byte_3);
                    }
                }
                return 2;
            default:
                return num3;
        }
    }
    public bool method_6()
    {
        string value = "0.0.0.0";
        if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(method_2()) && method_0() != 0 && method_4() != 0)
        {
            class46_0.method_7(value);
            class46_0.method_9(method_0());
            bool result;
            if (!(result = class46_0.method_27()))
            {
                return result;
            }
            return result = class48_0.method_23(value, bool_1: false);
        }
        throw new Exception("请先设置属性[BindAddr,TargetAddr,BindPort,TargetPort]");
    }

    public bool method_7()
    {
        if (class46_0.method_28())
        {
            return class48_0.method_24();
        }
        return false;
    }
    public int method_15(IntPtr intptr_0, Class39 class39_0, byte[] byte_0)
    {
        byte[] array = new byte[0];
        if (Class15.Center_Get_Buffer_Enc(byte_0, byte_0.Length))
        {
            try
            {
                if (class39_0.byte_1 == null)
                {
                    Class7.smethod_2(class39_0.string_1, "System Error G K ErrorCode:Keynull " + BitConverter.ToString(array));
                    return 1;
                }
                var @class = new Class16();
                @class.method_0(class39_0.byte_1);
                array = @class.method_5(byte_0, 2, byte_0.Length - 2);
                ushort value = Class17.smethod_6(byte_0, 0);
                byte[] array2 = new byte[array.Length + 2];
                Array.Copy(BitConverter.GetBytes(value), array2, 2);
                Array.Copy(array, 0, array2, 2, array.Length);
                array = array2;
            }
            catch
            {
                Class7.smethod_2(class39_0.string_1, "System Error G K ErrorCode: 0001");
                return 1;
            }
        }
        else
        {
            array = byte_0;
        }
        if (array.Length > 5)
        {
            ushort num = (ushort)BitConverter.ToInt16(array, 2);
            if (num == 20480)
            {
                try
                {
                    if (class39_0.int_0 == 1)
                    {
                        byte[] byte_ = class39_0.byte_1;
                        uint uint_ = class39_0.uint_2;
                        var class2 = new Class16();
                        uint uint_2 = BitConverter.ToUInt32(array, 6);
                        uint uint_3 = class2.method_6(uint_, 2147483647u, uint_2);
                        Class15.Center_Update_Key(byte_, uint_3, 3);
                        class39_0.int_0 = 2;
                        class39_0.uint_2 = uint_;
                        class39_0.byte_1 = byte_;
                        if (!method_25(intptr_0, class39_0, bool_1: true))
                        {
                            Class7.smethod_2(class39_0.string_1, "System Error G K Set ErrorCode: 0001");
                            return 1;
                        }
                    }
                    else if (class39_0.int_0 == 2)
                    {
                        return 1;
                    }
                }
                catch
                {
                    Class7.smethod_2(class39_0.string_1, "System Error G K Try ErrorCode: 0001");
                    return 1;
                }
            }

            //新增

            if (Class15.Get_GatewayState(num) == 0)
            {
                if (!Class9.smethod_15(class39_0.string_0))
                {
                    Class7.smethod_2(class39_0.string_1, "System Error:Add_BlockedIP");
                }
                Class6.smethod_0(2, "System GatewayServer 已拦截一次未知攻击!", 0);
                Class7.smethod_2(class39_0.string_1, "System Att G Opcode Code:x");
                return 1;
            }
            if (Class15.Get_GatewayOpcodeState(num, array.Length) == 1)
            {
                if (!Class9.smethod_15(class39_0.string_0))
                {
                    Class7.smethod_2(class39_0.string_1, "System Error:Add_BlockedIP");
                }
                Class6.smethod_0(2, "System GatewayServer 已拦截一次攻击!", 0);
                Class7.smethod_2(class39_0.string_1, "System Att G Opcode Code:x");
                return 1;
            }
            switch (num)
            {
                case 24834:
                    if (Class8.bool_54 && method_10(intptr_0))
                    {
                        class46_0.method_30(intptr_0, new byte[8] { 2, 0, 2, 161, 0, 0, 2, 8 }, 8);
                        return 1;
                    }
                    break;
                case 25379:
                    if (Class8.bool_54 && method_10(intptr_0))
                    {
                        class46_0.method_30(intptr_0, new byte[8] { 2, 0, 2, 161, 0, 0, 2, 8 }, 8);
                        return 1;
                    }
                    break;
                case 9009:
                    {
                        if (!Class8.bool_58 || array.Length <= 9)
                        {
                            break;
                        }
                        var class3 = new Class14(array);
                        class3.ReadBytes(6);
                        byte[] array3 = Class28.smethod_3(class3.ReadBytes(array.Length - 6), "169841");
                        if (array3 != null)
                        {
                            if (array3.Length > 3)
                            {
                                var class4 = new Class14(array3);
                                string text = class4.method_0();
                                byte b = class4.ReadByte();
                                if (b == 0)
                                {
                                    if (text == "SR_Ciiint")
                                    {
                                        var class5 = new Class21();
                                        class5.method_1("SR_Client");
                                        class5.Write(b);
                                        byte byte_2 = array[4];
                                        method_17(class39_0.intptr_1, class39_0, 8193, byte_2, class5.method_0());
                                        return 2;
                                    }
                                    Class7.smethod_2(class39_0.string_1, "System Error G I Enc Set ErrorCode: 0001");
                                }
                                else
                                {
                                    Class7.smethod_2(class39_0.string_1, "System Error G I Enc Set ErrorCode: 0002");
                                }
                            }
                            else
                            {
                                Class7.smethod_2(class39_0.string_1, "System Error G I Enc Set ErrorCode: 0003");
                            }
                        }
                        else
                        {
                            Class7.smethod_2(class39_0.string_1, "System Error G I Enc Set ErrorCode: 0005");
                        }
                        break;
                    }
            }
        }
        return 0;
    }

    public bool method_16(IntPtr intptr_0, ushort ushort_2, byte[] byte_0)
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
    public bool method_19(IntPtr intptr_0, uint uint_0, ushort ushort_2, byte byte_0)
    {
        try
        {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_2);
            @class.Write((ushort)0);
            byte[] array = @class.method_0();
            array[4] = byte_0;
            array[5] = Class17.smethod_5(uint_0, array);
            return class48_0.method_29(intptr_0, array, array.Length);
        }
        catch
        {
            return false;
        }
    }
    private bool method_25(IntPtr intptr_0, Class39 class39_0, bool bool_1)
    {
        try
        {
            lock (object_2)
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
                            zero = ((!bool_1) ? @class.intptr_1 : @class.intptr_0);
                            if (zero == intptr_0)
                            {
                                break;
                            }
                            num++;
                            continue;
                        }
                        return false;
                    }
                    list_0[num] = class39_0;
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

    private bool method_26(IntPtr intptr_0, ref Class39 class39_0, bool bool_1)
    {
        try
        {
            lock (object_2)
            {
                class39_0 = new Class39();
                if (list_0.Count > 0)
                {
                    int num = 0;
                    while (true)
                    {
                        if (num < list_0.Count)
                        {
                            var @class = list_0[num];
                            var zero = IntPtr.Zero;
                            zero = ((!bool_1) ? @class.intptr_1 : @class.intptr_0);
                            if (zero == intptr_0)
                            {
                                break;
                            }
                            num++;
                            continue;
                        }
                        return false;
                    }
                    class39_0 = list_0[num];
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

    private bool method_27(IntPtr intptr_0, bool bool_1)
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
                        zero = ((!bool_1) ? @class.intptr_1 : @class.intptr_0);
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
    public bool method_20(out int int_1, out int int_2, out int int_3)
    {
        int_1 = 0;
        int_2 = 0;
        int_3 = 0;
        try
        {
            int num = 0;
            int num2 = 0;
            var array = class46_0.method_53();
            if (array != null)
            {
                for (int i = 0; i < list_0.Count; i++)
                {
                    var @class = list_0[i];
                    if (@class.byte_0 != null)
                    {
                        num2 = 0;
                    }
                }
                int_3 = array.Length;
            }
            else
            {
                int_3 = 0;
            }
            int_1 = num;
            int_2 = num2;
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool method_21(IntPtr intptr_0, Class39 class39_0, byte[] byte_0)
    {
        try
        {
            class39_0.byte_0 = byte_0;
            if (method_25(intptr_0, class39_0, bool_1: true))
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

    private bool method_22(Class39 class39_0)
    {
        try
        {
            lock (object_2)
            {
                list_0.Add(class39_0);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private bool method_23(Class39 class39_0)
    {
        try
        {
            list_0.Add(class39_0);
            return true;
        }
        catch
        {
            return false;
        }
    }
    protected virtual Enum2 vmethod_9(Class46 class46_1, IntPtr intptr_0, byte[] byte_0) {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_10(Class46 class46_1, IntPtr intptr_0, byte[] byte_0) {
        try {
            var class39_ = new Class39();
            if (!method_26(intptr_0, ref class39_, bool_1: true)) {
                return Enum2.const_2;
            }
            try {
                if (byte_0.Length == 2) {
                    ushort num = BitConverter.ToUInt16(byte_0, 0);
                    if (int_0 == 0) {
                        if (num == 27013) {
                            int_0 = 1;
                        }
                    }
                    else if (int_0 == 1) {
                        if (num == 42789) {
                            int_0 = 2;
                        }
                    }
                    else if (int_0 == 2) {
                        if (num == 43301) {
                            int_0 = 3;
                        }
                    }
                    else if (int_0 == 3) {
                        Class8.bool_0 = false;
                    }
                }
                byte[] byte_ = new byte[0];
                switch (method_14(intptr_0, class39_, byte_0, out byte_)) {
                    case 0:
                        if (!class48_0.method_29(class39_.intptr_1, byte_0, byte_0.Length)) {
                            return Enum2.const_2;
                        }
                        break;
                    case 1:
                        list_1.Add(intptr_0);
                        return Enum2.const_0;
                    case 2:
                        if (byte_.Length != 0 && !class48_0.method_29(class39_.intptr_1, byte_, byte_.Length)) {
                            return Enum2.const_2;
                        }
                        break;
                }
            }
            catch {
            }
        }
        catch {
        }
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_11(Class46 class46_1, IntPtr intptr_0, Enum3 enum3_0, int int_1) {
        try {
            lock (object_2) {
                var class39_ = new Class39();
                if (!method_29(intptr_0, ref class39_, bool_1: true)) {
                    return Enum2.const_2;
                }
                if (class39_.uint_0 == 0) {
                    class39_.uint_0 = 2u;
                    if (!method_28(intptr_0, class39_, bool_1: true)) {
                        return Enum2.const_2;
                    }
                    class48_0.method_39(class39_.intptr_1);
                }
                else if (class39_.uint_0 == 1) {
                    method_27(intptr_0, bool_1: true);
                }
            }
        }
        catch {
        }
        return Enum2.const_0;
    }

    public bool method_9(string string_2) {
        try {
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
                    if (@struct.byte_0 == 1 && @struct.byte_1 == 0 && @struct.string_1 == string_2)
                    {
                        break;
                    }
                    num++;
                }
                return true;
            }
        }
        catch {
            return false;
        }
    }

    public bool method_10(IntPtr intptr_0) {
        try {
            string text = "";
            ushort num = 0;
            if (!class46_0.method_47(intptr_0, ref text, ref num)) {
                return false;
            }
            int num2 = 0;
            while (true) {
                if (num2 < Class5.list_10.Count) {
                    if (Class5.list_10[num2].byte_1 == 0 && Class5.list_10[num2].string_1 == text) {
                        break;
                    }
                    num2++;
                    continue;
                }
                if (Class12.class3_0.method_38(text) >= Class8.ushort_14) {
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
    public int method_11(string string_2) {
        try {
            string[] array = string_2.Split(new string[1] { ":" }, StringSplitOptions.RemoveEmptyEntries);
            if (array != null) {
                if (array.Length == 2) {
                    string_2 = array[0];
                    string text = string_2;
                    int num = 0;
                    while (true) {
                        if (num < Class5.list_10.Count) {
                            if (Class5.list_10[num].byte_1 == 0 && Class5.list_10[num].string_1 == text) {
                                break;
                            }
                            num++;
                            continue;
                        }
                        return Class12.class3_0.method_38(text);
                    }
                    return -1;
                }
                return -3;
            }
            return -4;
        }
        catch {
            return -2;
        }
    }



    public bool method_18(IntPtr intptr_0, Class39 class39_0, ushort ushort_2, byte byte_0) {
        try {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_2);
            @class.Write((ushort)0);
            byte[] array = @class.method_0();
            array[4] = byte_0;
            array[5] = Class17.smethod_5(class39_0.uint_1, array);
            return class48_0.method_29(class39_0.intptr_1, array, array.Length);
        }
        catch {
            return false;
        }
    }



    private bool method_24(IntPtr intptr_0, bool bool_1) {
        try {
            lock (object_2) {
                if (list_0.Count > 0) {
                    int num = 0;
                    while (true) {
                        if (num < list_0.Count) {
                            var @class = list_0[num];
                            var zero = IntPtr.Zero;
                            zero = ((!bool_1) ? @class.intptr_1 : @class.intptr_0);
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



    private bool method_28(IntPtr intptr_0, Class39 class39_0, bool bool_1) {
        try {
            if (list_0.Count > 0) {
                int num = 0;
                while (true) {
                    if (num < list_0.Count) {
                        var @class = list_0[num];
                        var zero = IntPtr.Zero;
                        zero = ((!bool_1) ? @class.intptr_1 : @class.intptr_0);
                        if (zero == intptr_0) {
                            break;
                        }
                        num++;
                        continue;
                    }
                    return false;
                }
                list_0[num] = class39_0;
                return true;
            }
            return false;
        }
        catch {
            return false;
        }
    }
    public int method_12(IntPtr intptr_0, Class39 class39_0, byte[] byte_0)
    {
        lock (object_0)
        {
            long_1 += byte_0.Length;
        }
        return method_13(intptr_0, class39_0, byte_0);
    }

    public int method_13(IntPtr intptr_0, Class39 class39_0, byte[] byte_0)
    {
        byte[] array = new byte[0];
        if (Class15.Center_Get_Buffer_Enc(byte_0, byte_0.Length))
        {
            try
            {
                if (class39_0.byte_1 == null)
                {
                    Class7.smethod_2(class39_0.string_1, "System Error G K ErrorCode:Keynull " + BitConverter.ToString(array));
                    return 1;
                }
                var @class = new Class16();
                @class.method_0(class39_0.byte_1);
                array = @class.method_5(byte_0, 2, byte_0.Length - 2);
                ushort value = Class17.smethod_6(byte_0, 0);
                byte[] array2 = new byte[array.Length + 2];
                Array.Copy(BitConverter.GetBytes(value), array2, 2);
                Array.Copy(array, 0, array2, 2, array.Length);
                array = array2;
            }
            catch
            {
                Class7.smethod_2(class39_0.string_1, "System Error G K ErrorCode: 0001");
                return 1;
            }
        }
        else
        {
            array = byte_0;
        }
        if (array.Length != 0)
        {
            switch ((ushort)BitConverter.ToInt16(array, 2))
            {
                case 20480:
                    if (array[0] != 37 || array.Length <= 27)
                    {
                        break;
                    }
                    try
                    {
                        if (class39_0.int_0 == 0)
                        {
                            uint num = 0u;
                            uint num2 = 0u;
                            byte[] array3 = new byte[8];
                            Array.Copy(array, 23, array3, 0, 8);
                            num = BitConverter.ToUInt32(array, 35) & 0x7FFFFFFFu;
                            num2 = BitConverter.ToUInt32(array, 19);
                            class39_0.int_0 = 1;
                            class39_0.uint_2 = num;
                            class39_0.uint_1 = num2;
                            class39_0.byte_1 = array3;
                            if (!method_25(intptr_0, class39_0, bool_1: false))
                            {
                                Class7.smethod_2(class39_0.string_1, "System Error G K Set ErrorCode: 0014");
                            }
                        }
                    }
                    catch
                    {
                        Class7.smethod_2(class39_0.string_1, "System Error G K try ErrorCode: 0014");
                    }
                    break;
                case 41218:
                    if (Class8.bool_0 && array.Length > 16 && array[6] == 1)
                    {
                        Class12.class3_0.method_60(class39_0.string_0);
                    }
                    if (Class8.bool_63 && array.Length > 15)
                    {
                        var class2 = new Class14(array);
                        class2.ReadBytes(6);
                        byte value2 = class2.ReadByte();
                        uint value3 = class2.ReadUInt32();
                        class2.method_0();
                        ushort value4 = class2.ReadUInt16();
                        var class3 = new Class21();
                        class3.Write(value2);
                        class3.Write(value3);
                        class3.method_1(Class8.string_62);
                        class3.Write(value4);
                        method_16(class39_0.intptr_0, 41218, class3.method_0());
                        return 3;
                    }
                    break;
            }
        }
        return 0;
    }

    protected virtual Enum2 vmethod_4(IntPtr intptr_0, byte[] byte_0)
    {
        try
        {
            var class39_ = new Class39();
            if (!method_26(intptr_0, ref class39_, bool_1: false))
            {
                return Enum2.const_2;
            }
            switch (method_12(intptr_0, class39_, byte_0))
            {
                case 0:
                    if (!class46_0.method_30(class39_.intptr_0, byte_0, byte_0.Length))
                    {
                        return Enum2.const_2;
                    }
                    break;
                case 1:
                    list_1.Add(class39_.intptr_0);
                    return Enum2.const_0;
                case 3:
                    return Enum2.const_0;
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
            lock (object_2)
            {
                var class39_ = new Class39();
                if (!method_29(intptr_0, ref class39_, bool_1: false))
                {
                    return Enum2.const_2;
                }
                if (class39_.uint_0 == 0)
                {
                    class39_.uint_0 = 1u;
                    if (!method_28(intptr_0, class39_, bool_1: false))
                    {
                        return Enum2.const_2;
                    }
                    class46_0.method_40(class39_.intptr_0);
                }
                else if (class39_.uint_0 == 2)
                {
                    method_27(intptr_0, bool_1: false);
                }
            }
        }
        catch
        {
        }
        return Enum2.const_0;
    }
    public bool method_17(IntPtr intptr_0, Class39 class39_0, ushort ushort_2, byte byte_0, byte[] byte_1)
    {
        try
        {
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
            array[5] = Class17.smethod_5(class39_0.uint_1, array);
            return class48_0.method_29(intptr_0, array, array.Length);
        }
        catch
        {
            return false;
        }
    }
    private bool method_29(IntPtr intptr_0, ref Class39 class39_0, bool bool_1) {
        try {
            class39_0 = new Class39();
            if (list_0.Count > 0) {
                int num = 0;
                while (true) {
                    if (num < list_0.Count) {
                        var @class = list_0[num];
                        var zero = IntPtr.Zero;
                        zero = ((!bool_1) ? @class.intptr_1 : @class.intptr_0);
                        if (zero == intptr_0) {
                            break;
                        }
                        num++;
                        continue;
                    }
                    return false;
                }
                class39_0 = list_0[num];
                return true;
            }
            return false;
        }
        catch {
            return false;
        }
    }
}
