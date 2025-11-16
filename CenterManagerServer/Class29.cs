using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Timers;

internal class Class29 {
    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private string string_1;

    [CompilerGenerated]
    private ushort ushort_1;

    private object object_0 = new object();

    private object object_1 = new object();

    private object object_2 = new object();

    private object object_3 = new object();



    private List<IntPtr> list_1 = new List<IntPtr>();

    public List<Class30> list_0 = new List<Class30>();

    protected Class46 class46_0 = new Class46();
    public bool bool_0 = true;

    public long long_0;

    public long long_1;

    public long long_2;

    public string string_0 = "";

    private Timer timer_0 = new Timer();
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

    public Class29() {
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
        timer_0.Interval = 1.0;
        timer_0.Elapsed += timer_0_Elapsed;
        timer_0.Start();
    }

    private void timer_0_Elapsed(object sender, ElapsedEventArgs e) {
        try {
            for (int i = 0; i < list_1.Count; i++) {
                class46_0.method_40(list_1[i]);
            }
            if (list_1.Count > 0) {
                list_1.Clear();
            }
        }
        catch {
        }
    }
    protected virtual Enum2 vmethod_5(IntPtr intptr_0, Enum3 enum3_0, int int_0)
    {
        try
        {
            var class30_ = new Class30();
            lock (object_3)
            {
                if (!method_27(intptr_0, ref class30_, bool_1: false))
                {
                    return Enum2.const_2;
                }
                if (class30_.uint_0 == 0)
                {
                    class30_.uint_0 = 1u;
                    if (!method_26(intptr_0, class30_, bool_1: false))
                    {
                        return Enum2.const_2;
                    }
                    class46_0.method_40(class30_.intptr_0);
                }
                else if (class30_.uint_0 == 2)
                {
                    method_25(intptr_0, bool_1: false);
                }
            }
            if (Class8.bool_69)
            {
                Class7.smethod_2(class30_.string_1, "ConnId:" + class30_.intptr_0.ToString() + " FreeType:" + class30_.uint_0 + " System Exit D Client Close");
            }
        }
        catch
        {
        }
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_6(Class46 class46_1, IntPtr intptr_0)
    {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_7(Class46 class46_1)
    {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_8(Class46 class46_1, IntPtr intptr_0, IntPtr intptr_1)
    {
        try
        {
            if (!bool_0)
            {
                return Enum2.const_2;
            }
            string empty = string.Empty;
            ushort num = 0;
            if (!class46_0.method_47(intptr_0, ref empty, ref num))
            {
                return Enum2.const_2;
            }
            if (empty.Length < 7)
            {
                return Enum2.const_2;
            }
            lock (object_2)
            {
                long_2++;
            }
            if (string_0 != empty && string_0 != "" && empty != Class8.string_2)
            {
                return Enum2.const_2;
            }
            if (method_9(empty))
            {
                return Enum2.const_2;
            }
            lock (object_3)
            {
                var intptr_2 = IntPtr.Zero;
                if (!class48_0.method_25(method_2(), method_4(), ref intptr_2) && !class48_0.method_25(method_2(), method_4(), ref intptr_2) && !class48_0.method_25(method_2(), method_4(), ref intptr_2))
                {
                    return Enum2.const_2;
                }
                var @class = new Class30();
                @class.intptr_0 = intptr_0;
                @class.intptr_1 = intptr_2;
                @class.uint_0 = 0u;
                @class.string_0 = empty;
                @class.string_1 = empty + ":" + num;
                @class.byte_0 = null;
                @class.byte_1 = null;
                @class.byte_2 = null;
                @class.uint_1 = 0u;
                @class.uint_2 = 0u;
                @class.int_0 = 0;
                @class.int_1 = 0;
                @class.int_2 = Class9.smethod_0();
                if (!method_21(@class))
                {
                    return Enum2.const_2;
                }
            }
            return Enum2.const_0;
        }
        catch
        {
            return Enum2.const_2;
        }
    }

    protected virtual Enum2 vmethod_9(Class46 class46_1, IntPtr intptr_0, byte[] byte_0)
    {
        return Enum2.const_0;
    }

    protected virtual Enum2 vmethod_10(Class46 class46_1, IntPtr intptr_0, byte[] byte_0)
    {
        try
        {
            var class30_ = new Class30();
            if (!method_24(intptr_0, ref class30_, bool_1: true))
            {
                return Enum2.const_2;
            }
            byte[] byte_ = new byte[0];
            int int_ = 0;
            int num = method_16(intptr_0, ref class30_, byte_0, out byte_, ref int_);
            if (int_ > 0 && !method_23(intptr_0, class30_, bool_1: true))
            {
                Class7.smethod_2(class30_.string_1, "System Error D S UpdCun Set ErrorCode: 0001");
            }
            switch (num)
            {
                case 0:
                    if (!class48_0.method_29(class30_.intptr_1, byte_0, byte_0.Length))
                    {
                        return Enum2.const_2;
                    }
                    break;
                case 1:
                    list_1.Add(intptr_0);
                    return Enum2.const_0;
                case 2:
                    if (byte_.Length != 0 && !class48_0.method_29(class30_.intptr_1, byte_, byte_.Length))
                    {
                        return Enum2.const_2;
                    }
                    break;
                case 3:
                    list_1.Add(intptr_0);
                    return Enum2.const_0;
            }
            return Enum2.const_0;
        }
        catch
        {
            return Enum2.const_2;
        }
    }
    public bool method_6() {
        string text = "0.0.0.0";
        class46_0.method_7(text);
        class46_0.method_9(method_0());
        bool result;
        if (!(result = class46_0.method_27())) {
            return result;
        }
        return result = class48_0.method_23(text, bool_1: false);
    }

    public bool method_7() {
        if (class46_0.method_28()) {
            return class48_0.method_24();
        }
        return false;
    }

    public bool method_8(IntPtr intptr_0, bool bool_1 = true) {
        return class46_0.method_40(intptr_0, bool_1);
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
            var class30_ = new Class30();
            if (!method_24(intptr_0, ref class30_, bool_1: false)) {
                return Enum2.const_2;
            }
            byte[] byte_ = new byte[0];
            int int_ = 0;
            int num = method_15(intptr_0, ref class30_, byte_0, out byte_, ref int_);
            if (int_ > 0 && !method_23(intptr_0, class30_, bool_1: false)) {
                Class7.smethod_2(class30_.string_1, "System Error D C UpdCun Set ErrorCode: 0001");
            }
            switch (num) {
                case 0:
                    if (!class46_0.method_30(class30_.intptr_0, byte_0, byte_0.Length)) {
                        return Enum2.const_2;
                    }
                    break;
                case 1:
                    class48_0.method_39(intptr_0);
                    return Enum2.const_0;
                case 2:
                    if (byte_.Length != 0 && !class46_0.method_30(class30_.intptr_0, byte_, byte_.Length)) {
                        return Enum2.const_2;
                    }
                    break;
                case 3:
                    class48_0.method_39(intptr_0);
                    return Enum2.const_0;
            }
        }
        catch {
        }
        return Enum2.const_0;
    }



    protected virtual Enum2 vmethod_11(Class46 class46_1, IntPtr intptr_0, Enum3 enum3_0, int int_0) {
        try {
            var class30_ = new Class30();
            lock (object_3) {
                if (!method_27(intptr_0, ref class30_, bool_1: true)) {
                    return Enum2.const_2;
                }
                if (class30_.uint_0 == 0) {
                    class30_.uint_0 = 2u;
                    if (!method_26(intptr_0, class30_, bool_1: true)) {
                        return Enum2.const_2;
                    }
                    class48_0.method_39(class30_.intptr_1);
                }
                else if (class30_.uint_0 == 1) {
                    method_25(intptr_0, bool_1: true);
                }
            }
            if (Class8.bool_66 || Class8.bool_69) {
                if (class30_.uint_0 == 2) {
                    Class7.smethod_2(class30_.string_1, "ConnId:" + class30_.intptr_0.ToString() + " FreeType:" + class30_.uint_0 + " System Exit D User Close");
                }
                else if (class30_.uint_0 == 1) {
                    Class7.smethod_2(class30_.string_1, "ConnId:" + class30_.intptr_0.ToString() + " FreeType:" + class30_.uint_0 + " System Exit D Server Close");
                }
                else {
                    Class7.smethod_2(class30_.string_1, "ConnId:" + class30_.intptr_0.ToString() + " FreeType:" + class30_.uint_0 + " System Exit D Try Close");
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

    public ushort method_10(string string_2) {
        try {
            if (list_0.Count > 0) {
                string text = "";
                ushort num = 0;
                ushort num2 = 0;
                for (int i = 0; i < list_0.Count; i++) {
                    text = "";
                    num = 0;
                    var @class = list_0[i];
                    class46_0.method_47(@class.intptr_0, ref text, ref num);
                    if (string_2 == text) {
                        num2 = (ushort)(num2 + 1);
                    }
                }
                return num2;
            }
            return 0;
        }
        catch {
            return 0;
        }
    }
    private bool method_21(Class30 class30_0)
    {
        try
        {
            list_0.Add(class30_0);
            return true;
        }
        catch
        {
            return false;
        }
    }

    private bool method_22(IntPtr intptr_0, bool bool_1)
    {
        try
        {
            lock (object_3)
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
        }
        catch
        {
            return false;
        }
    }

    private bool method_23(IntPtr intptr_0, Class30 class30_0, bool bool_1)
    {
        try
        {
            lock (object_3)
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
                    list_0[num] = class30_0;
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

    private bool method_24(IntPtr intptr_0, ref Class30 class30_0, bool bool_1)
    {
        try
        {
            lock (object_3)
            {
                class30_0 = new Class30();
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
                        if (Class8.bool_69)
                        {
                            Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A DownloadGetConnectionExtra 1 Close");
                        }
                        return false;
                    }
                    class30_0 = list_0[num];
                    return true;
                }
                if (Class8.bool_69)
                {
                    Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A DownloadGetConnectionExtra 2 Close");
                }
                return false;
            }
        }
        catch
        {
            if (Class8.bool_69)
            {
                Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A DownloadGetConnectionExtra 3 Close");
            }
            return false;
        }
    }

    private bool method_25(IntPtr intptr_0, bool bool_1)
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

    private bool method_26(IntPtr intptr_0, Class30 class30_0, bool bool_1)
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
                list_0[num] = class30_0;
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }
    public bool method_11(IntPtr intptr_0, ushort ushort_2, byte[] byte_0) {
        try {
            var @class = new Class21();
            @class.Write((ushort)byte_0.Length);
            @class.Write(ushort_2);
            @class.Write((ushort)0);
            @class.Write(byte_0);
            if (class46_0.method_30(intptr_0, @class.method_0(), @class.method_0().Length)) {
                return true;
            }
            return false;
        }
        catch {
            return false;
        }
    }

    public bool method_12(out int int_0, out int int_1, out int int_2) {
        int_0 = 0;
        int_1 = 0;
        int_2 = 0;
        try {
            int num = 0;
            int num2 = 0;
            var array = class46_0.method_53();
            if (array != null) {
                for (int i = 0; i < list_0.Count; i++) {
                    var @class = list_0[i];
                }
                int_2 = array.Length;
            }
            else {
                int_2 = 0;
            }
            int_0 = num;
            int_1 = num2;
            return true;
        }
        catch {
            return false;
        }
    }

    public int method_13(IntPtr intptr_0, ref Class30 class30_0, byte[] byte_0, ref int int_0) {
        ushort num = BitConverter.ToUInt16(byte_0, 2);
        if (byte_0[0] == 37 && byte_0.Length > 27 && num == 20480) {
            try {
                if (class30_0.int_0 == 0) {
                    uint num2 = 0u;
                    uint num3 = 0u;
                    byte[] array = new byte[8];
                    Array.Copy(byte_0, 23, array, 0, 8);
                    num2 = BitConverter.ToUInt32(byte_0, 35) & 0x7FFFFFFFu;
                    num3 = BitConverter.ToUInt32(byte_0, 19);
                    class30_0.int_0 = 1;
                    class30_0.uint_2 = num2;
                    class30_0.byte_2 = array;
                    class30_0.uint_1 = num3;
                    int_0++;
                }
            }
            catch {
                Class7.smethod_2(class30_0.string_1, "System Error D K Try Error: 0014");
            }
        }
        if (num == 8193 && Class8.bool_58 && byte_0.Length > 9) {
            var @class = new Class14(byte_0);
            @class.ReadBytes(6);
            string text = @class.method_0();
            byte b = @class.ReadByte();
            if (b == 0 && text == "DownloadServer") {
                var class2 = new Class21();
                class2.method_1("Down1oadServer");
                class2.Write(b);
                var class3 = new Class21();
                class3.Write((ushort)class2.method_0().Length);
                class3.Write((ushort)9009);
                class3.Write((ushort)0);
                byte[] array2 = Class28.smethod_2(class2.method_0(), "169841");
                if (array2.Length == class2.method_0().Length) {
                    class3.Write(array2);
                    class46_0.method_30(class30_0.intptr_0, class3.method_0(), class3.method_0().Length);
                    return 2;
                }
                Class7.smethod_2(class30_0.string_1, "System Error D S Enc Set ErrorCode: 0001");
            }
        }
        return 0;
    }
    public int method_16(IntPtr intptr_0, ref Class30 class30_0, byte[] byte_0, out byte[] byte_1, ref int int_0)
    {
        lock (object_1)
        {
            long_0 += byte_0.Length;
        }
        byte_1 = byte_0;
        byte[] byte_2 = class30_0.byte_1;
        if (byte_2 != null && byte_2.Length > 65535)
        {
            Class7.smethod_2(class30_0.string_1, "System Error D Wait Set ErrorCode: 6501 Len:" + byte_2.Length);
            return 1;
        }
        int num = 0;
        var list = new List<byte[]>();
        byte[] array = null;
        if (byte_2 != null)
        {
            int num2 = 0;
            byte[] array2 = Class1.smethod_12(byte_2, byte_0);
            if (array2.Length < 6)
            {
                class30_0.byte_1 = array2;
                int_0++;
                byte_2 = array2;
                return 0;
            }
            num2 = Class17.smethod_6(array2, 0) - byte_2.Length;
            if (byte_0.Length < num2)
            {
                class30_0.byte_1 = array2;
                int_0++;
                byte_2 = array2;
                return 0;
            }
            class30_0.byte_1 = null;
            int_0++;
            byte_2 = null;
            array = array2;
        }
        else if (byte_0.Length < 6)
        {
            class30_0.byte_1 = byte_0;
            int_0++;
            byte_2 = byte_0;
            return 0;
        }
        if (array == null)
        {
            array = byte_0;
        }
        ushort num3 = Class17.smethod_6(array, 0);
        if (num3 == array.Length)
        {
            num = method_14(intptr_0, ref class30_0, array, ref int_0);
            if (num == 2)
            {
                list.Add(array);
            }
        }
        else
        {
            if (num3 > array.Length)
            {
                class30_0.byte_1 = array;
                int_0++;
                byte_2 = array;
                return 0;
            }
            if (num3 < array.Length)
            {
                int num4 = 0;
                while (array.Length != 0)
                {
                    if (array.Length >= 6)
                    {
                        num3 = Class17.smethod_6(array, 0);
                        if (num3 <= array.Length)
                        {
                            num4++;
                            if (num4 <= Class8.int_34)
                            {
                                byte[] array3 = Class1.smethod_14(array, num3);
                                array = Class1.smethod_13(array, array.Length - num3);
                                num = method_14(intptr_0, ref class30_0, array3, ref int_0);
                                switch (num)
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
                                if (!Class9.smethod_15(class30_0.string_0))
                                {
                                    Class7.smethod_2(class30_0.string_1, "System Error:Add_BlockedIP");
                                }
                                Class6.smethod_0(2, "System DownloadServer 扫描到一次未知攻击,类型:Max", 0);
                                Class7.smethod_2(class30_0.string_1, "System D Type:MAX " + num4);
                                num = 1;
                            }
                            break;
                        }
                        class30_0.byte_1 = array;
                        int_0++;
                        byte_2 = array;
                        return 0;
                    }
                    class30_0.byte_1 = array;
                    int_0++;
                    byte_2 = array;
                    return 0;
                }
            }
        }
        switch (num)
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
                return num;
        }
    }

    public bool method_17(IntPtr intptr_0, Class30 class30_0, ushort ushort_2, byte byte_0, byte[] byte_1)
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
            array[5] = Class17.smethod_5(class30_0.uint_1, array);
            return class48_0.method_29(intptr_0, array, array.Length);
        }
        catch
        {
            return false;
        }
    }

    public bool method_18(IntPtr intptr_0, Class30 class30_0, ushort ushort_2, byte byte_0)
    {
        try
        {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_2);
            @class.Write((ushort)0);
            byte[] array = @class.method_0();
            array[4] = byte_0;
            array[5] = Class17.smethod_5(class30_0.uint_1, array);
            return class48_0.method_29(class30_0.intptr_1, array, array.Length);
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
    public int method_14(IntPtr intptr_0, ref Class30 class30_0, byte[] byte_0, ref int int_0) {
        byte[] array = new byte[0];
        if (Class15.Center_Get_Buffer_Enc(byte_0, byte_0.Length)) {
            try {
                if (class30_0.byte_2 == null) {
                    Class7.smethod_2(class30_0.string_1, "System Error D Key Code:null " + BitConverter.ToString(array));
                    return 1;
                }
                var @class = new Class16();
                @class.method_0(class30_0.byte_2);
                array = @class.method_5(byte_0, 2, byte_0.Length - 2);
                ushort value = Class17.smethod_6(byte_0, 0);
                byte[] array2 = new byte[array.Length + 2];
                Array.Copy(BitConverter.GetBytes(value), array2, 2);
                Array.Copy(array, 0, array2, 2, array.Length);
                array = array2;
            }
            catch {
                Class7.smethod_2(class30_0.string_1, "System Error D DeKey Code: 0001");
                return 1;
            }
        }
        else {
            array = byte_0;
        }
        if (array.Length > 5) {
            ushort num = (ushort)BitConverter.ToInt16(array, 2);
            switch (num) {
                case 20480:
                    try {
                        if (class30_0.int_0 == 1) {
                            byte[] byte_2 = class30_0.byte_2;
                            uint uint_ = class30_0.uint_2;
                            var class5 = new Class16();
                            uint uint_2 = BitConverter.ToUInt32(array, 6);
                            uint uint_3 = class5.method_6(uint_, 2147483647u, uint_2);
                            Class15.Center_Update_Key(byte_2, uint_3, 3);
                            class30_0.int_0 = 2;
                            class30_0.uint_2 = uint_;
                            class30_0.byte_2 = byte_2;
                            int_0++;
                        }
                        else if (class30_0.int_0 == 2) {
                            Class7.smethod_2(class30_0.string_1, "System Error D K Oet ErrorCode: 0001");
                            return 1;
                        }
                    }
                    catch {
                        Class7.smethod_2(class30_0.string_1, "System Error D K Try ErrorCode: 0001");
                        return 1;
                    }
                    break;
                case 9009: {
                    if (!Class8.bool_58 || array.Length <= 9) {
                        break;
                    }
                    var class2 = new Class14(array);
                    class2.ReadBytes(6);
                    byte[] array3 = Class28.smethod_3(class2.ReadBytes(array.Length - 6), "169841");
                    if (array3 != null) {
                        if (array3.Length > 3) {
                            var class3 = new Class14(array3);
                            string text = class3.method_0();
                            byte b = class3.ReadByte();
                            if (b == 0) {
                                if (text == "SR_Ciiint") {
                                    var class4 = new Class21();
                                    class4.method_1("SR_Client");
                                    class4.Write(b);
                                    byte byte_ = array[4];
                                    method_17(class30_0.intptr_1, class30_0, 8193, byte_, class4.method_0());
                                    return 2;
                                }
                                Class7.smethod_2(class30_0.string_1, "System Error D R Enc Set ErrorCode: 0001");
                            }
                            else {
                                Class7.smethod_2(class30_0.string_1, "System Error D R Enc Set ErrorCode: 0002");
                            }
                        }
                        else {
                            Class7.smethod_2(class30_0.string_1, "System Error D R Enc Set ErrorCode: 0003");
                        }
                    }
                    else {
                        Class7.smethod_2(class30_0.string_1, "System Error D R Enc Set ErrorCode: 0005");
                    }
                    break;
                }
                case 24589:
                    if (class30_0.string_0 != Class8.string_2) {
                        Class7.smethod_2(class30_0.string_1, "System Error D K 6R ErrorCode: 0001");
                        return 1;
                    }
                    break;
                default: {
                    if (!(class30_0.string_0 != Class8.string_2)) {
                        break;
                    }
                    bool flag = false;
                    for (int i = 0; i < Class8.int_29.Length; i++) {
                        if (Class8.int_29[i] == num) {
                            flag = true;
                        }
                    }
                    if (!flag) {
                        Class7.smethod_2(class30_0.string_1, "System Error D OpEr Code: " + num);
                        return 1;
                    }
                    break;
                }
            }
        }
        return 0;
    }

    public int method_15(IntPtr intptr_0, ref Class30 class30_0, byte[] byte_0, out byte[] byte_1, ref int int_0) {
        lock (object_0) {
            long_1 += byte_0.Length;
        }
        byte_1 = byte_0;
        byte[] byte_2 = class30_0.byte_0;
        int num = 0;
        var list = new List<byte[]>();
        byte[] array = null;
        if (byte_2 != null) {
            int num2 = 0;
            byte[] array2 = Class1.smethod_12(byte_2, byte_0);
            if (array2.Length < 6) {
                class30_0.byte_0 = array2;
                int_0++;
                byte_2 = array2;
                return 0;
            }
            num2 = Class17.smethod_6(array2, 0) - byte_2.Length;
            if (byte_0.Length < num2) {
                class30_0.byte_0 = array2;
                int_0++;
                byte_2 = array2;
                return 0;
            }
            class30_0.byte_0 = null;
            int_0++;
            byte_2 = null;
            array = array2;
        }
        else if (byte_0.Length < 6) {
            class30_0.byte_0 = byte_0;
            int_0++;
            byte_2 = byte_0;
            return 0;
        }
        if (array == null) {
            array = byte_0;
        }
        ushort num3 = Class17.smethod_6(array, 0);
        if (num3 == array.Length) {
            num = method_13(intptr_0, ref class30_0, array, ref int_0);
            if (num == 2) {
                list.Add(array);
            }
        }
        else {
            if (num3 > array.Length) {
                class30_0.byte_0 = array;
                int_0++;
                byte_2 = array;
                return 0;
            }
            if (num3 < array.Length) {
                while (array.Length != 0) {
                    if (array.Length >= 6) {
                        num3 = Class17.smethod_6(array, 0);
                        if (num3 <= array.Length) {
                            byte[] array3 = Class1.smethod_14(array, num3);
                            array = Class1.smethod_13(array, array.Length - num3);
                            num = method_13(intptr_0, ref class30_0, array3, ref int_0);
                            switch (num) {
                                case 2:
                                    list.Add(array3);
                                    continue;
                                default:
                                    continue;
                                case 1:
                                    break;
                            }
                            break;
                        }
                        class30_0.byte_0 = array;
                        int_0++;
                        byte_2 = array;
                        return 0;
                    }
                    class30_0.byte_0 = array;
                    int_0++;
                    byte_2 = array;
                    return 0;
                }
            }
        }
        switch (num) {
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
                return num;
        }
    }



    private bool method_20(IntPtr intptr_0, Class30 class30_0) {
        try {
            lock (object_3) {
                list_0.Add(class30_0);
                return true;
            }
        }
        catch {
            return false;
        }
    }



    private bool method_27(IntPtr intptr_0, ref Class30 class30_0, bool bool_1) {
        try {
            class30_0 = new Class30();
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
                    if (Class8.bool_69) {
                        Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A DownloadGetConnectionExtra 1 Close");
                    }
                    return false;
                }
                class30_0 = list_0[num];
                return true;
            }
            if (Class8.bool_69) {
                Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A DownloadGetConnectionExtra 2 Close");
            }
            return false;
        }
        catch {
            if (Class8.bool_69) {
                Class7.smethod_2("0.0.0.1", "ConnId:" + intptr_0 + " FreeType:Error System Exit A DownloadGetConnectionExtra 3 Close");
            }
            return false;
        }
    }
}
