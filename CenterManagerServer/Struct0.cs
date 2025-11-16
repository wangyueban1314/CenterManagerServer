using System;
using System.Net;
using System.Runtime.InteropServices;

internal struct Struct0
//public class Struct0
	{
    public Enum1 enum1_0;

    public uint uint_0;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] byte_0;

    public uint uint_1;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] byte_1;


	public int int_0;

    public Struct0(Enum1 enum1_0, uint uint_0, byte[] byte_0, uint uint_1, byte[] byte_1, int int_0)
    {
        this.enum1_0 = enum1_0;
        this.uint_0 = uint_0;
        this.byte_0 = byte_0;
        this.uint_1 = uint_1;
        this.byte_1 = byte_1;
        this.int_0 = int_0;
    }

    public IPAddress method_0() {
        return new IPAddress(uint_0);
    }
	
	public ushort method_1() {
        return BitConverter.ToUInt16(new byte[2]
        {
            byte_0[1],
            byte_0[0]
        }, 0);
    }

    public IPAddress method_2() {
        return new IPAddress(uint_1);
    }

    public ushort method_3() {
        return BitConverter.ToUInt16(new byte[2]
        {
            byte_1[1],
            byte_1[0]
        }, 0);
    }
}
