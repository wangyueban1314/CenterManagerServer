using System;
using System.IO;
using System.Text;

internal class Class14 : BinaryReader {
    private byte[] byte_0;

    public Class14(byte[] byte_1)
        : base(new MemoryStream(byte_1, writable: false)) {
        try {
            byte_0 = byte_1;
        }
        catch {
        }
    }
    public string method_0()
    {
        try
        {
            ushort count = ReadUInt16();
            byte[] bytes = ReadBytes(count);
            return Encoding.Default.GetString(bytes);
        }
        catch
        {
            return "";
        }
    }

    public byte[] method_1()
    {
        try
        {
            int count = ReadInt32();
            return ReadBytes(count);
        }
        catch
        {
            return null;
        }
    }
    public Class14(byte[] byte_1, int int_0, int int_1)
        : base(new MemoryStream(byte_1, int_0, int_1, writable: false)) {
        try {
            byte_0 = byte_1;
        }
        catch {
        }
    }



    public string method_2() {
        try {
            byte[] array = ReadBytes(6);
            byte[] array2 = new byte[0];
            ushort num = 0;
            if (BitConverter.ToString(array) == "11-00-25-56-00-33") {
                num = ReadUInt16();
                if (num <= 0) {
                    return "---2";
                }
                byte[] bytes = Class28.smethod_3(ReadBytes(num), "15652296");
                string @string = Encoding.Default.GetString(bytes);
                if (!(@string != "")) {
                    return "---3";
                }
                ushort num2 = ReadUInt16();
                if (num2 <= 0) {
                    return "---5";
                }
                array2 = Class28.smethod_3(ReadBytes(num2), @string);
                if (Encoding.Default.GetString(array2).IndexOf("77777") == 0) {
                    return Class28.smethod_5(array2).ToString("X2");
                }
                if (Class8.byte_9 == 2) {
                    return "---6";
                }
            }
            if (Class8.byte_9 == 1) {
                if (num == 0) {
                    return "---8";
                }
                return Class28.smethod_5(array2).ToString("X2");
            }
            if (Class8.byte_9 == 2) {
                return "---7";
            }
            if (array2.Length != 0) {
                return Class28.smethod_5(array2).ToString("X2");
            }
            array = Class28.smethod_1(array, "1100223366");
            return BitConverter.ToString(array);
        }
        catch {
            return "---1";
        }
    }
}
