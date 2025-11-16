using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

internal class Class0 {














	[DllImport("iphlpapi.dll", SetLastError = true)]
    private static extern uint GetExtendedTcpTable(IntPtr intptr_0, ref int int_0, bool bool_0, int int_1, Enum0 enum0_0, uint uint_0 = 0u);

	public uint uint_0=0;
	private static Struct0[] smethod_0() {
        int int_ = 2;
        int int_2 = 0;
        GetExtendedTcpTable(IntPtr.Zero, ref int_2, bool_0: true, 2, Enum0.const_5);
        var intPtr = Marshal.AllocHGlobal(int_2);
        try {
            if (GetExtendedTcpTable(intPtr, ref int_2, bool_0: true, int_, Enum0.const_5) != 0) {
                return null;
            }
			  var @struct = (Struct1)Marshal.PtrToStructure(intPtr, typeof(Struct1));
			var intPtr2 = (IntPtr)((long)intPtr + Marshal.SizeOf((object)@struct.uint_0));
            var array = new Struct0[@struct.uint_0];
            for (int i = 0; i < @struct.uint_0; i++) {
                var struct2 = (array[i] = (Struct0)Marshal.PtrToStructure(intPtr2, typeof(Struct0)));
                intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)struct2));
            }
            return array;
        }
        finally {
            Marshal.FreeHGlobal(intPtr);
        }
    }

    internal static bool smethod_1(ushort ushort_0, out int int_0, out string string_0) {
        int_0 = 0;
        string_0 = "";
        try {
            var array = smethod_0();
            int num = 0;
            Struct0 @struct;
            while (true) {
                if (num < array.Length) {
                    @struct = array[num];
                    if (@struct.method_1() == ushort_0) {
                        break;
                    }
                    num++;
                    continue;
                }
                return false;
            }
            int_0 = @struct.int_0;
            string_0 = Process.GetProcessById(int_0).MainWindowTitle;
            if (string_0 == "") {
                string_0 = Class1.smethod_1(int_0);
            }
            return true;
        }
        catch {
            return false;
        }
    }
}
