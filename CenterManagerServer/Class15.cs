using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

internal class Class15 {
    public static ushort ushort_0 = 0;

    public static ushort ushort_1 = 0;

    public static ushort ushort_2 = 0;

    public static ushort ushort_3 = 0;

    public static int int_0 = 0;

    public static ushort ushort_4 = 0;

    public static ushort ushort_5 = 0;

    public static ushort ushort_6 = 0;

    public static ushort ushort_7 = 0;

    public static ushort ushort_8 = 0;

    public static int int_1 = 0;

    public static List<int> list_0 = new List<int>();

    public static List<int> list_1 = new List<int>();

    public static List<int> list_2 = new List<int>();

    public static List<int> list_3 = new List<int>();

    public static List<int> list_4 = new List<int>();

    public static List<Struct36> list_5 = new List<Struct36>();

    public static bool smethod_0() {
        ushort_0 = (ushort)Center_Get_Agent_Length(1);
        ushort_1 = (ushort)Center_Get_Agent_Length(2);
        ushort_3 = (ushort)Center_Get_Agent_Length(3);
        int_0 = Center_Get_Agent_Length(4);
        ushort_4 = (ushort)Center_Get_Agent_Length(5);
        ushort_5 = (ushort)Center_Get_Agent_Length(6);
        ushort_6 = (ushort)Center_Get_Agent_Length(7);
        ushort_7 = (ushort)Center_Get_Agent_Length(8);
        ushort_8 = (ushort)Center_Get_Agent_Length(9);
        int_1 = Center_Get_Agent_Length(10);
        return true;
    }
    public static int smethod_2(int int_2, int int_3)
    {
        int num = 0;
        while (true)
        {
            if (num < list_0.Count)
            {
                if (int_2 == list_0[num])
                {
                    break;
                }
                num++;
                continue;
            }
            int num2 = 0;
            while (true)
            {
                if (num2 < list_1.Count)
                {
                    if (int_2 == list_1[num2])
                    {
                        break;
                    }
                    num2++;
                    continue;
                }
                int num3 = 0;
                while (true)
                {
                    if (num3 < list_5.Count)
                    {
                        if (int_2 == list_5[num3].int_0 && int_3 == list_5[num3].int_1)
                        {
                            break;
                        }
                        num3++;
                        continue;
                    }
                    return 0;
                }
                return 1;
            }
            return 2;
        }
        return 1;
    }

    public static int smethod_3(int int_2, int int_3)
    {
        int num = 0;
        while (true)
        {
            if (num < list_0.Count)
            {
                if (int_2 == list_0[num])
                {
                    break;
                }
                num++;
                continue;
            }
            int num2 = 0;
            while (true)
            {
                if (num2 < list_1.Count)
                {
                    if (int_2 == list_1[num2])
                    {
                        break;
                    }
                    num2++;
                    continue;
                }
                int num3 = 0;
                while (true)
                {
                    if (num3 < list_5.Count)
                    {
                        if (int_2 == list_5[num3].int_0 && int_3 == list_5[num3].int_1)
                        {
                            break;
                        }
                        num3++;
                        continue;
                    }
                    return 0;
                }
                return 1;
            }
            return 2;
        }
        return 1;
    }

    public static int smethod_4(int int_2)
    {
        if (list_4.Count == 0)
        {
            return 2;
        }
        int num = 0;
        while (true)
        {
            if (num < list_4.Count)
            {
                if (int_2 == list_4[num])
                {
                    break;
                }
                num++;
                continue;
            }
            return 0;
        }
        return 1;
    }
    public static bool smethod_1() {
        var source = Get_AgentInfo(168552);
        if (source.ToInt32() > 0) {
            source = (IntPtr)source.ToInt32() - 1000000;
        }
        byte[] array = new byte[4];
        if (source.ToInt32() > 0) {
            Marshal.Copy(source, array, 0, 4);
        }
        int num = BitConverter.ToInt32(array, 0);
        array = new byte[num];
        if (source.ToInt32() > 0) {
            Marshal.Copy(source, array, 0, num);
        }
        var @class = new Class14(array);
        num = @class.ReadInt32();
        int num2 = @class.ReadInt32();
        for (int i = 0; i < num2; i++) {
            int num3 = @class.ReadInt32();
            int num4 = @class.ReadInt32();
            switch (num3) {
                case 1:
                    list_0.Add(num4);
                    break;
                case 2:
                    list_1.Add(num4);
                    break;
                case 3: {
                    int int_ = @class.ReadInt32();
                    list_5.Add(new Struct36(num4, int_));
                    break;
                }
                case 5:
                    list_2.Add(num4);
                    break;
                case 6:
                    list_3.Add(num4);
                    break;
                case 7:
                    list_4.Add(num4);
                    break;
            }
        }
        return true;
    }



    public static int smethod_5(int int_2) {
        if (list_2.Count == 0) {
            return 2;
        }
        int num = 0;
        while (true) {
            if (num < list_2.Count) {
                if (int_2 == list_2[num]) {
                    break;
                }
                num++;
                continue;
            }
            return 0;
        }
        return 1;
    }

    public static int smethod_6(int int_2) {
        if (list_3.Count == 0) {
            return 2;
        }
        int num = 0;
        while (true) {
            if (num < list_3.Count) {
                if (int_2 == list_3[num]) {
                    break;
                }
                num++;
                continue;
            }
            return 0;
        }
        return 1;
    }

    [DllImport("QiangweidiewuApi.dll")]
    public static extern IntPtr Get_AgentInfo(int int_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int Set_UpdateSRServer(int int_2, int int_3);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Get_CertificationBuffer(out int int_2, out IntPtr intptr_0);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_ContentID(byte byte_0);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_MachineIP(string string_0);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_GlobalQuery(string string_0);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_ShardQuery(string string_0);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_ShardLogQuery(string string_0);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_ShardName(string string_0);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_ShardMax(short short_0);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_GatewayServerPort(int int_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_DownloadServerPort(int int_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_AgentServerPort(int int_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_CertificationPort(int int_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int StringCheck(string string_0, int int_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern string ChatSQLReplace(string string_0);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int FindBytesIndex(IntPtr intptr_0, int int_2, IntPtr intptr_1, int int_3, int int_4);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int LoginServer(string string_0, string string_1, string string_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int Get_GatewayOpcodeState(int int_2, int int_3);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int Get_AgentOpcodeState(int int_2, int int_3);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int Get_GatewayState(int int_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int Get_AgentState_(int int_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int Get_GamesState_(int int_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern string Get_Center_Net_Kernel_Api_Name(int int_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Set_CenterVer(string string_0);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int Get_OpcodeAttack(int int_2, int int_3);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int Get_GamesCode();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern int Center_Get_Buffer_Enc_Length(byte[] byte_0, int int_2, int int_3);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Get_Buffer_Enc(byte[] byte_0, int int_2);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Update_Key(byte[] byte_0, uint uint_0, byte byte_1);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern int Center_Get_Buffer_Length(int int_2);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Get_Buffer_PV(uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
  //  public static extern IntPtr Get_Center_Net_Kernel_Sys_Name();
	public static extern IntPtr Get_CenterNetKernelSysName();

	[DllImport("QiangweidiewuYstem.dll")]
    public static extern int Center_Get_Buffer_Add(int int_2);

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int Get_GatewayIp();

    [DllImport("QiangweidiewuApi.dll")]
    public static extern int Get_AgentIp();

    [DllImport("QiangweidiewuApi.dll")]
    public static extern bool Get_CenterProperty(out int int_2, out int int_3, out int int_4, out int int_5);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Get_Socket_Length();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Get_Task_Length();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern int Center_Get_Agent_Length(int int_2);
}
