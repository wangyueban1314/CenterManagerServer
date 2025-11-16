using System;
using System.Threading;
using System.Timers;

internal class Class23 {
    private int int_0;

    private Thread thread_0;

    private Class25 class25_0 = new Class25();

    private System.Timers.Timer timer_0 = new System.Timers.Timer();

    private System.Timers.Timer timer_1 = new System.Timers.Timer();

    private byte[] byte_0;

    private bool bool_0;

    private bool bool_1 = true;

    private Class21 class21_0 = new Class21();

    private int int_1;

    private int int_2;

    public Class23() {
        class25_0.method_2(method_11);
        class25_0.method_4(method_12);
        class25_0.method_6(method_13);
        class25_0.method_8(method_14);
        class25_0.method_12(method_15);
        timer_0.Interval = 30000.0;
        timer_0.Elapsed += timer_0_Elapsed;
        timer_1.Interval = 15000.0;
        timer_1.Elapsed += timer_1_Elapsed;
    }

    public bool method_0() {
        try {
            Class6.smethod_6(5, 2);
            Class6.smethod_6(8, 10);
            thread_0 = new Thread(method_9);
            thread_0.Start();
            return true;
        }
        catch {
            return false;
        }
    }

    public bool method_1() {
        try {
            if (thread_0.IsAlive) {
                thread_0.Abort();
            }
            int_1 = 0;
            timer_0.Stop();
            bool_1 = false;
            bool_0 = false;
            class25_0.method_20();
            return true;
        }
        catch {
            return false;
        }
    }

    private void method_9() {
        try {
			//     if (!class25_0.method_17(Class24.string_2, Class24.ushort_0, bool_1: false) && !class25_0.method_17(Class24.string_2, Class24.ushort_0, bool_1: false) && !class25_0.method_17(Class24.string_2, Class24.ushort_0, bool_1: false)) {

			if (!class25_0.method_17(Class8.shouquanip, Class8.shouquanduankou1, bool_1: false) && !class25_0.method_17(Class8.shouquanip, Class8.shouquanduankou1, bool_1: false) && !class25_0.method_17(Class8.shouquanip, Class8.shouquanduankou1, bool_1: false)) {
				Class6.smethod_6(5, 1);
            }
            else if (bool_1) {
                Class6.smethod_6(8, 30);
                Class6.smethod_6(5, 3);
                if (method_34(1, 0)) {
                    Class6.smethod_6(8, 50);
                }
                else {
                    Class6.smethod_6(5, 4);
                }
            }
        }
        catch {
        }
    }

    private void method_10() {
        try {
            timer_0.Stop();
            bool flag = class25_0.method_17(Class8.shouquanip, Class8.shouquanduankou1, bool_1: false);
            if (bool_1) {
                if (!flag) {
                    timer_0.Start();
                }
                else {
                    method_2(2, 0);
                }
            }
        }
        catch {
        }
    }

    private void timer_1_Elapsed(object sender, ElapsedEventArgs e) {
        method_28(4096);
    }

    private void timer_0_Elapsed(object sender, ElapsedEventArgs e) {
        try {
            if (Interlocked.Exchange(ref int_1, 1) == 0) {
                method_10();
                Interlocked.Exchange(ref int_1, 0);
            }
        }
        catch {
        }
    }

    private Enum2 method_11(Class25 class25_1, IntPtr intptr_0) {
        return Enum2.const_0;
    }
    private void method_16(byte[] byte_1)
    {
        byte[] array = null;
        if (byte_0 != null)
        {
            int num = 0;
            byte[] array2 = Class1.smethod_12(byte_0, byte_1);
            if (array2.Length < 8)
            {
                byte_0 = array2;
                return;
            }
            num = Class17.smethod_7(array2, 0) - byte_0.Length;
            if (byte_1.Length < num)
            {
                byte_0 = array2;
                return;
            }
            byte_0 = null;
            array = array2;
        }
        else if (byte_1.Length < 8)
        {
            byte_0 = byte_1;
            return;
        }
        if (array == null)
        {
            array = byte_1;
        }
        int num2 = Class17.smethod_7(array, 0);
        if (num2 == array.Length)
        {
            method_17(array);
        }
        else if (num2 > array.Length)
        {
            byte_0 = array;
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
                        method_17(byte_2);
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

    private void method_17(byte[] byte_1)
    {
        if (byte_1.Length >= 8)
        {
            byte_1 = Class28.smethod_0(byte_1, "MangagementForm");
            var @class = new Class14(byte_1);
            @class.ReadInt32();
            ushort num = @class.ReadUInt16();
            @class.ReadUInt16();
            switch (num)
            {
                case 8193:
                    method_26(@class);
                    break;
                case 8194:
                    method_24(@class);
                    break;
                case 8195:
                    method_25(@class);
                    break;
                case 8208:
                    method_23(@class);
                    break;
                case 8209:
                    method_20(@class);
                    break;
                case 8210:
                    method_21(@class);
                    break;
                case 8211:
                    method_19(@class);
                    break;
                case 8224:
                    method_18(@class);
                    break;
            }
        }
    }

    private void method_18(Class14 class14_0)
    {
        byte b = class14_0.ReadByte();
        byte b2 = class14_0.ReadByte();
        switch (b)
        {
            case 1:
                if (b2 == 0)
                {
                    int count2 = class14_0.ReadInt32();
                    var @class = new Class14(class14_0.ReadBytes(count2));
                    byte b3 = @class.ReadByte();
                    byte b4 = @class.ReadByte();
                    if (b3 == 1 && b4 == 0)
                    {
                        var class2 = new Class21();
                        class2.Write((byte)1);
                        class2.Write((byte)0);
                        class2.Write(Class2.byte_0);
                        class2.Write(Class2.int_1);
                        class2.Write(Class2.int_0);
                        class2.Write(Class2.int_4);
                        class2.Write(Class2.int_2);
                        class2.Write(Class2.int_3);
                        method_4(1, 0, class2.method_0());
                    }
                }
                break;
            case 2:
                if (b2 == 0)
                {
                    int count = class14_0.ReadInt32();
                    byte[] array = class14_0.ReadBytes(count);
                    Class12.class11_0.method_9(array);
                }
                break;
        }
    }

    private void method_19(Class14 class14_0)
    {
        byte b = class14_0.ReadByte();
        byte b2 = class14_0.ReadByte();
        switch (b)
        {
            case 1:
                switch (b2)
                {
                    case 0:
                        Class2.list_0.Clear();
                        method_30(1, 0);
                        break;
                    case 1:
                        method_29(1, 2, 0);
                        break;
                    case 2:
                        {
                            int num2 = class14_0.ReadInt32();
                            int count2 = class14_0.ReadInt32();
                            byte[] collection2 = class14_0.ReadBytes(count2);
                            method_29(1, 2, num2 + 1);
                            Class2.list_0.AddRange(collection2);
                            break;
                        }
                    case 3:
                        Class12.class11_0.method_4(Class2.list_0.ToArray());
                        break;
                }
                break;
            case 2:
                switch (b2)
                {
                    case 0:
                        Class2.list_0.Clear();
                        method_30(2, 0);
                        break;
                    case 1:
                        method_29(2, 2, 0);
                        break;
                    case 2:
                        {
                            int num = class14_0.ReadInt32();
                            int count = class14_0.ReadInt32();
                            byte[] collection = class14_0.ReadBytes(count);
                            method_29(2, 2, num + 1);
                            Class2.list_0.AddRange(collection);
                            break;
                        }
                    case 3:
                        Class9.smethod_54(Class2.list_0.ToArray());
                        break;
                }
                break;
        }
    }

    private void method_20(Class14 class14_0)
    {
        byte b = class14_0.ReadByte();
        byte b2 = class14_0.ReadByte();
        switch (b)
        {
            case 1:
                if (b2 == 0)
                {
                    string text = class14_0.method_0();
                    if (text != "")
                    {
                        Class6.smethod_1(8, text);
                    }
                }
                break;
            case 2:
                if (b2 == 0)
                {
                    Class2.int_4 = class14_0.ReadInt32();
                    Class2.int_2 = class14_0.ReadInt32();
                    Class2.int_3 = class14_0.ReadInt32();
                    Class2.byte_2 = class14_0.method_1();
                    Class12.class11_0.method_5(Class2.int_4, Class2.byte_2);
                }
                break;
            case 3:
                if (b2 == 0)
                {
                    Class2.ushort_0 = class14_0.ReadUInt16();
                    Class2.ushort_1 = class14_0.ReadUInt16();
                }
                break;
            case 5:
                if (b2 == 0)
                {
                    Class2.int_4 = class14_0.ReadInt32();
                    Class2.int_2 = class14_0.ReadInt32();
                    Class2.int_3 = class14_0.ReadInt32();
                    Class2.byte_2 = class14_0.method_1();
                }
                break;
            case 6:
                if (b2 == 0)
                {
                    Class2.int_4 = class14_0.ReadInt32();
                }
                break;
            case 7:
                if (b2 == 0)
                {
                    Class2.int_4 = class14_0.ReadInt32();
                    Class12.class11_0.method_6(Class2.int_4);
                }
                break;
            case 8:
                if (b2 == 1)
                {
                    int count = Class12.class11_0.method_22().Count;
                    method_8(8, 1, count);
                }
                break;
            case 9:
                if (b2 == 0)
                {
                    int num = class14_0.ReadInt32();
                    Class12.class11_0.method_7(num);
                }
                break;
            case 10:
                if (b2 != 0)
                {
                    break;
                }
                if (class14_0.ReadByte() == 1)
                {
                    Class2.int_1 = class14_0.ReadInt32();
                    Class2.int_0 = class14_0.ReadInt32();
                    if (class14_0.ReadByte() == 1)
                    {
                        if (Class9.smethod_56(out var byte_))
                        {
                            Class2.byte_1 = byte_;
                        }
                        else
                        {
                            method_5(10, 11);
                        }
                    }
                    else
                    {
                        Class2.byte_1 = class14_0.method_1();
                    }
                    Class2.byte_0 = 1;
                }
                else
                {
                    Class2.byte_0 = 0;
                }
                break;
        }
    }

    private void method_21(Class14 class14_0)
    {
        switch (class14_0.ReadByte())
        {
            case 1:
                if (class14_0.ReadByte() == 0)
                {
                    byte[] array = class14_0.method_1();
                    Class12.class11_0.method_4(array);
                }
                break;
            case 2:
                if (class14_0.ReadByte() == 0)
                {
                    Class9.smethod_54(class14_0.method_1());
                }
                break;
        }
    }

    private void method_22(Class14 class14_0)
    {
        class14_0.ReadByte();
        class14_0.ReadByte();
    }

    private void method_23(Class14 class14_0)
    {
        byte num = class14_0.ReadByte();
        byte b = class14_0.ReadByte();
        if (num == 1 && b == 0)
        {
            string text = class14_0.method_0();
            if (text != null)
            {
                Class6.smethod_1(9, text);
            }
        }
    }

    private void method_24(Class14 class14_0)
    {
        byte b = class14_0.ReadByte();
        byte b2 = class14_0.ReadByte();
        switch (b)
        {
            case 1:
                if (b2 == 0)
                {
                    bool_0 = true;
                    timer_1.Start();
                    Class6.smethod_7(10);
                }
                break;
            case 2:
                if (b2 == 0)
                {
                    timer_1.Start();
                }
                break;
        }
    }

    private void method_25(Class14 class14_0)
    {
        byte b = class14_0.ReadByte();
        byte b2 = class14_0.ReadByte();
        switch (b)
        {
            case 1:
                switch (b2)
                {
                    case 0:
                        {
                            if (Class9.smethod_49(class14_0, out var flag))
                            {
                                method_32(1, 0);
                                Class6.smethod_6(5, 12);
                                Class6.smethod_6(8, 100);
                                if (flag)
                                {
                                    Class6.smethod_7(9);
                                }
                            }
                            else
                            {
                                Class6.smethod_6(5, 13);
                            }
                            break;
                        }
                    case 1:
                        Class6.smethod_6(5, 14);
                        break;
                    case 2:
                        Class6.smethod_6(5, 15);
                        break;
                }
                break;
            case 2:
                switch (b2)
                {
                    case 0:
                        {
                            if (Class9.smethod_49(class14_0, out var flag3))
                            {
                                method_32(1, 0);
                                Class6.smethod_6(5, 16);
                                Class6.smethod_6(8, 100);
                                if (flag3)
                                {
                                    Class6.smethod_7(9);
                                }
                            }
                            else
                            {
                                Class6.smethod_6(5, 17);
                            }
                            break;
                        }
                    case 1:
                        int_2 = class14_0.ReadInt32();
                        class14_0.ReadInt32();
                        method_31(1, 2, 0);
                        Class6.smethod_6(5, 18);
                        Class6.smethod_6(8, 1);
                        break;
                    case 2:
                        {
                            int num = class14_0.ReadInt32();
                            int count = class14_0.ReadInt32();
                            byte[] buffer = class14_0.ReadBytes(count);
                            class21_0.Write(buffer);
                            num++;
                            method_31(1, 2, num);
                            Class6.smethod_6(8, num * 100 / int_2);
                            break;
                        }
                    case 3:
                        {
                            if (Class9.smethod_49(new Class14(class21_0.method_0()), out var flag2))
                            {
                                class21_0 = new Class21();
                                method_32(1, 0);
                                Class6.smethod_6(5, 19);
                                Class6.smethod_6(8, 100);
                                if (flag2)
                                {
                                    Class6.smethod_7(9);
                                }
                            }
                            else
                            {
                                Class6.smethod_6(5, 17);
                            }
                            break;
                        }
                    case 4:
                        Class6.smethod_6(5, 20);
                        break;
                    case 5:
                        Class6.smethod_6(5, 21);
                        break;
                }
                break;
            case 3:
                if (b2 == 0)
                {
                    Class6.smethod_6(8, 100);
                    Class6.smethod_6(5, 8);
                    Class6.smethod_7(7);
                }
                break;
        }
    }
    private Enum2 method_12(Class25 class25_1) {
        return Enum2.const_0;
    }

    private Enum2 method_13(Class25 class25_1, byte[] byte_1) {
        return Enum2.const_0;
    }

    private Enum2 method_14(Class25 class25_1, byte[] byte_1) {
        try {
            method_16(byte_1);
        }
        catch {
        }
        return Enum2.const_0;
    }

    private Enum2 method_15(Class25 class25_1, Enum3 enum3_0, int int_3) {
        try {
            timer_1.Stop();
            int_2 = 0;
            byte_0 = null;
            class21_0 = new Class21();
            if (bool_1 && bool_0) {
                timer_0.Start();
            }
        }
        catch {
        }
        return Enum2.const_0;
    }



    private void method_26(Class14 class14_0) {
        byte b = class14_0.ReadByte();
        byte b2 = class14_0.ReadByte();
        int num = 0;
        byte[] array = null;
        try {
            num = class14_0.ReadInt32();
            array = class14_0.ReadBytes(num);
            array = Class9.smethod_58(array);
        }
        catch {
            Class6.smethod_6(5, 11);
            return;
        }
        class14_0 = new Class14(array);
        int num2 = class14_0.ReadInt32();
        if (int_0 != num2) {
            Class6.smethod_6(5, 7);
        }
        switch (b) {
            case 1:
                switch (b2) {
                    case 0:
                        Class6.smethod_6(8, 100);
                        Class6.smethod_6(5, 8);
                        Class6.smethod_7(7);
                        break;
                    case 1:
                        Class6.smethod_6(5, 5);
                        break;
                    case 3:
                        Class6.smethod_6(5, 6);
                        break;
                    case 5:
                        Class6.smethod_6(5, 7);
                        break;
                }
                break;
            case 2:
                switch (b2) {
                    case 0:
                        Class6.smethod_6(8, 100);
                        Class6.smethod_6(5, 8);
                        Class6.smethod_7(7);
                        break;
                    case 1: {
                        if (Class9.smethod_51(class14_0, out var byte_)) {
                            method_33(1, 1, byte_);
                            Class6.smethod_6(5, 9);
                        }
                        else {
                            method_32(1, 0);
                            Class6.smethod_6(5, 10);
                        }
                        break;
                    }
                    case 2:
                        Class6.smethod_6(5, 11);
                        break;
                }
                break;
            case 3:
                if (b2 == 0) {
                    string text = class14_0.method_0();
                    if (text != "") {
                        Class6.smethod_6(8, 70);
                        Class6.smethod_5(6, text);
                    }
                }
                break;
        }
    }

    private bool method_27(ushort ushort_0, byte[] byte_1) {
        try {
            var @class = new Class21();
            @class.Write(0);
            @class.Write(ushort_0);
            @class.Write((ushort)0);
            @class.Write(byte_1);
            byte[] destinationArray = @class.method_0();
            Array.Copy(BitConverter.GetBytes(byte_1.Length), 0, destinationArray, 0, 4);
            destinationArray = Class28.smethod_0(destinationArray, "MangagementForm");
            return class25_0.method_21(destinationArray, destinationArray.Length);
        }
        catch {
            return false;
        }
    }
    private bool method_29(byte byte_1, byte byte_2, int int_3)
    {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.method_1(Class8.string_1);
        @class.Write(Class8.int_0);
        @class.method_1(Class24.string_0);
        @class.Write(int_3);
        return method_27(4115, @class.method_0());
    }

    private bool method_30(byte byte_1, byte byte_2)
    {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.method_1(Class8.string_1);
        @class.Write(Class8.int_0);
        @class.method_1(Class24.string_0);
        return method_27(4115, @class.method_0());
    }

    public bool method_3(byte byte_1, byte byte_2, byte[] byte_3)
    {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.Write(byte_3.Length);
        @class.Write(byte_3);
        return method_27(4128, @class.method_0());
    }

    public bool method_4(byte byte_1, byte byte_2, byte[] byte_3)
    {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.Write(byte_3.Length);
        @class.Write(byte_3);
        return method_27(4128, @class.method_0());
    }

    public bool method_5(byte byte_1, byte byte_2)
    {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        return method_27(4113, @class.method_0());
    }

    private bool method_31(byte byte_1, byte byte_2, int int_3)
    {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.method_1(Class8.string_1);
        @class.Write(Class8.int_0);
        @class.method_1(Class24.string_0);
        @class.Write(int_3);
        return method_27(4099, @class.method_0());
    }

    private bool method_32(byte byte_1, byte byte_2)
    {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.method_1(Class8.string_1);
        @class.Write(Class8.int_0);
        @class.method_1(Class24.string_0);
        return method_27(4099, @class.method_0());
    }

    private bool method_33(byte byte_1, byte byte_2, byte[] byte_3)
    {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.method_1(Class8.string_1);
        @class.Write(Class8.int_0);
        @class.method_1(Class24.string_0);
        @class.Write(byte_3);
        return method_27(4099, @class.method_0());
    }

    private bool method_34(byte byte_1, byte byte_2)
    {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        int_0 = Class9.smethod_0();
        @class.Write(int_0);
        var class2 = new Class21();
        class2.Write(int_0);
        class2.method_1(Class8.string_1);
        class2.Write(Class8.int_0);
        class2.method_1(Class24.string_0);
        class2.method_1(Class24.string_3);
        byte[] array = Class9.smethod_57(class2.method_0());
        @class.Write(array.Length);
        @class.Write(array);
        return method_27(4097, @class.method_0());
    }

    public bool method_6(byte byte_1, byte byte_2)
    {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.method_1(Class8.string_1);
        @class.Write(Class8.int_0);
        @class.method_1(Class24.string_0);
        return method_27(4113, @class.method_0());
    }
    private bool method_28(ushort ushort_0) {
        try {
            var @class = new Class21();
            @class.Write(0);
            @class.Write(ushort_0);
            @class.Write((ushort)0);
            byte[] array = @class.method_0();
            array = Class28.smethod_0(array, "MangagementForm");
            return class25_0.method_21(array, array.Length);
        }
        catch {
            return false;
        }
    }
	public bool fsfb(byte[] arr) {
		try {

			return method_27(4098, arr);

		}
		catch {
			return false;
		}
	}

	public bool method_2(byte byte_1, byte byte_2) {
        try {
            var @class = new Class21();
            @class.Write(byte_1);
            @class.Write(byte_2);
            @class.method_1(Class8.string_1);
            @class.Write(Class8.int_0);
            @class.method_1(Class24.string_0);
            @class.method_1(Class24.string_1);
            return method_27(4098, @class.method_0());
        }
        catch {
            return false;
        }
    }



    public bool method_7(byte byte_1, byte byte_2, int int_3) {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.method_1(Class8.string_1);
        @class.Write(Class8.int_0);
        @class.method_1(Class24.string_0);
        @class.Write(int_3);
        return method_27(4113, @class.method_0());
    }

    public bool method_8(byte byte_1, byte byte_2, int int_3) {
        var @class = new Class21();
        @class.Write(byte_1);
        @class.Write(byte_2);
        @class.method_1(Class8.string_1);
        @class.Write(Class8.int_0);
        @class.method_1(Class24.string_0);
        @class.Write(int_3);
        return method_27(4113, @class.method_0());
    }
}
