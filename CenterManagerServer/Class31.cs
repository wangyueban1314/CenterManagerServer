using System;
using System.Threading;
using System.Timers;

internal class Class31
//	public class Class31
	{
    private Thread thread_0;

    private Class25 class25_0 = new Class25();

    private System.Timers.Timer timer_0 = new System.Timers.Timer();

    private System.Timers.Timer timer_1 = new System.Timers.Timer();

    private byte[] byte_0;

	//  private bool bool_0 = true;

	private bool bool_1 = true;

    private int int_0;

    private byte[] byte_1 = new byte[3];

    private uint uint_0;

    private byte[] byte_2 = new byte[8];

    public Class31() {
        class25_0.method_2(method_9);
        class25_0.method_4(method_10);
        class25_0.method_6(method_11);
        class25_0.method_8(method_12);
        class25_0.method_12(method_13);
        timer_0.Interval = 30000.0;
        timer_0.Elapsed += timer_0_Elapsed;
        timer_1.Interval = 10000.0;
        timer_1.Elapsed += timer_1_Elapsed;
    }

    public bool method_0() {
        try {
            thread_0 = new Thread(method_7);
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
            int_0 = 0;
            timer_0.Stop();
            bool_1 = false;
        //    bool_0 = false;
            class25_0.method_20();
            return true;
        }
        catch {
            return false;
        }
    }

    private void method_7() {
        try {
            while (bool_1) {
                bool flag = false;
                if (Class1.FindWindow("SR_GameServer", "SR_GameServer") != IntPtr.Zero) {
                    flag = class25_0.method_17(Class8.string_2, Class8.ushort_15, bool_1: false);
                }
                if (bool_1) {
                    if (!flag) {
                        Thread.Sleep(10000);
                    }
                    continue;
                }
                break;
            }
        }
        catch {
        }
    }

    private void method_8() {
        try {
            bool flag = false;
            timer_0.Stop();
            if (Class1.FindWindow("SR_GameServer", "SR_GameServer") != IntPtr.Zero) {
                flag = class25_0.method_17(Class8.string_2, Class8.ushort_15, bool_1: false);
            }
            if (bool_1 && !flag) {
                timer_0.Start();
            }
        }
        catch {
        }
    }

    private void timer_1_Elapsed(object sender, ElapsedEventArgs e) {
        method_6(8194);
    }

    private void timer_0_Elapsed(object sender, ElapsedEventArgs e) {
        try {
            if (Interlocked.Exchange(ref int_0, 1) == 0) {
                method_8();
                Interlocked.Exchange(ref int_0, 0);
            }
        }
        catch {
        }
    }
    private void method_14(byte[] byte_3)
    {
        byte[] array = null;
        if (byte_0 != null)
        {
            int num = 0;
            byte[] array2 = Class1.smethod_12(byte_0, byte_3);
            if (array2.Length < 6)
            {
                byte_0 = array2;
                return;
            }
            num = Class17.smethod_6(array2, 0) - byte_0.Length;
            if (byte_3.Length < num)
            {
                byte_0 = array2;
                return;
            }
            byte_0 = null;
            array = array2;
        }
        else if (byte_3.Length < 6)
        {
            byte_0 = byte_3;
            return;
        }
        if (array == null)
        {
            array = byte_3;
        }
        int num2 = Class17.smethod_6(array, 0);
        if (num2 == array.Length)
        {
            method_15(array);
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
                    if (array.Length < 6)
                    {
                        break;
                    }
                    num2 = Class17.smethod_6(array, 0);
                    if (num2 <= array.Length)
                    {
                        byte[] byte_4 = Class1.smethod_14(array, num2);
                        array = Class1.smethod_13(array, array.Length - num2);
                        method_15(byte_4);
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

    private void method_15(byte[] byte_3)
    {
        if (byte_3.Length < 6)
        {
            return;
        }
        var @class = new Class14(byte_3);
        @class.ReadInt16();
        ushort num = @class.ReadUInt16();
        @class.ReadUInt16();
        switch (num)
        {
            case 20480:
                if (byte_3[0] == 17 && byte_3.Length >= 23)
                {
                    try
                    {
                        Array.Copy(byte_3, 7, byte_2, 0, 8);
                        uint uint_ = BitConverter.ToUInt32(byte_3, 15);
                        uint_0 = BitConverter.ToUInt32(byte_3, 19);
                        Class17.smethod_1(uint_, ref byte_1);
                        method_6(36864);
                        var class2 = new Class21();
                        class2.method_1("SR_ShardManager");
                        class2.Write((byte)0);
                        method_4(8193, bool_2: true, class2.method_0());
                    }
                    catch
                    {
                    }
                }
                break;
            case 8193:
                //     bool_0 = true;
                timer_1.Start();
                break;
        }
    }

    public bool method_2(string string_0, short short_0, float float_0, float float_1, float float_2)
    {
        var @class = new Class21();
        @class.method_1(string_0);
        @class.Write(short_0);
        @class.Write(float_0);
        @class.Write(float_1);
        @class.Write(float_2);
        return method_4(13499, bool_2: true, @class.method_0());
    }

    public bool method_3(string string_0)
    {
        try
        {
            if (string_0.Length == 0)
            {
                return false;
            }
            string[] array = string_0.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
            if (array == null)
            {
                return false;
            }
            if (array.Length != 6)
            {
                return false;
            }
            string string_ = array[0];
            if (!short.TryParse(array[1], out short result))
            {
                return false;
            }
            if (!float.TryParse(array[2], out float result2))
            {
                return false;
            }
            if (!float.TryParse(array[3], out float result3))
            {
                return false;
            }
            if (!float.TryParse(array[4], out float result4))
            {
                return false;
            }
            if (!int.TryParse(array[5], out int result5))
            {
                return false;
            }
            for (int i = 0; i < result5; i++)
            {
                var @class = new Class21();
                @class.method_1(string_);
                @class.Write(result);
                @class.Write(result2);
                @class.Write(result3);
                @class.Write(result4);
                method_4(13499, bool_2: true, @class.method_0());
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
    private Enum2 method_9(Class25 class25_1, IntPtr intptr_0) {
        return Enum2.const_0;
    }



    private Enum2 method_12(Class25 class25_1, byte[] byte_3) {
        try {
            method_14(byte_3);
        }
        catch {
        }
        return Enum2.const_0;
    }

    private Enum2 method_13(Class25 class25_1, Enum3 enum3_0, int int_1) {
        try {
            timer_1.Stop();
         //   bool_0 = false;
            byte_0 = null;
            byte_1 = new byte[3];
            uint_0 = 0u;
            byte_2 = new byte[8];
            if (bool_1) {
                timer_0.Start();
            }
        }
        catch {
        }
        return Enum2.const_0;
    }



    public bool method_4(ushort ushort_0, bool bool_2, byte[] byte_3) {
        try {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_0);
            @class.Write((ushort)0);
            @class.Write(byte_3);
            byte[] array = @class.method_0();
            Array.Copy(BitConverter.GetBytes((ushort)byte_3.Length), 0, array, 0, 2);
            array[4] = Class17.smethod_3(byte_1, bool_0: true);
            if (bool_2) {
                array[1] = (byte)(array[1] + 128);
                array[5] = Class17.smethod_5(uint_0, array);
                byte[] array2 = new byte[array.Length - 2];
                Array.Copy(array, 2, array2, 0, array2.Length);
                var class2 = new Class16();
                class2.method_0(byte_2);
                array2 = class2.method_2(array2);
                byte[] array3 = new byte[array2.Length + 2];
                Array.Copy(array, 0, array3, 0, 2);
                Array.Copy(array2, 0, array3, 2, array2.Length);
                array = array3;
            }
            else {
                array[5] = Class17.smethod_5(uint_0, array);
            }
            return class25_0.method_21(array, array.Length);
        }
        catch {
            return false;
        }
    }

    public bool method_5(ushort ushort_0, byte[] byte_3) {
        try {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_0);
            @class.Write((ushort)0);
            @class.Write(byte_3);
            byte[] array = @class.method_0();
            Array.Copy(BitConverter.GetBytes((ushort)byte_3.Length), 0, array, 0, 2);
            array[4] = Class17.smethod_3(byte_1, bool_0: true);
            array[5] = Class17.smethod_5(uint_0, array);
            return class25_0.method_21(array, array.Length);
        }
        catch {
            return false;
        }
    }
    private Enum2 method_10(Class25 class25_1)
    {
        return Enum2.const_0;
    }

    private Enum2 method_11(Class25 class25_1, byte[] byte_3)
    {
        return Enum2.const_0;
    }
    public bool method_6(ushort ushort_0) {
        try {
            var @class = new Class21();
            @class.Write((ushort)0);
            @class.Write(ushort_0);
            @class.Write((ushort)0);
            byte[] array = @class.method_0();
            array[4] = Class17.smethod_3(byte_1, bool_0: true);
            array[5] = Class17.smethod_5(uint_0, array);
            return class25_0.method_21(array, array.Length);
        }
        catch {
            return false;
        }
    }
}
