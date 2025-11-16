using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

internal class Class48 : Class45 {
    protected IntPtr intptr_0 = IntPtr.Zero;

    protected IntPtr intptr_1 = IntPtr.Zero;

    [CompilerGenerated]
    private Class20.Delegate12 delegate12_0;

    [CompilerGenerated]
    private Class20.Delegate13 delegate13_0;

    [CompilerGenerated]
    private Class20.Delegate11 delegate11_0;

    [CompilerGenerated]
    private Class20.Delegate14 delegate14_0;

    [CompilerGenerated]
    private Class20.Delegate17 delegate17_0;

    [CompilerGenerated]
    private Class20.Delegate15 delegate15_0;

    [CompilerGenerated]
    private Class20.Delegate16 delegate16_0;

    [CompilerGenerated]
    private Class20.Delegate18 delegate18_0;

    protected bool bool_0;

    private Class43.Delegate32 delegate32_0;

    private Class43.Delegate33 delegate33_0;

    private Class43.Delegate27 delegate27_0;

    private Class43.Delegate26 delegate26_0;

    private Class43.Delegate29 delegate29_0;

    private Class43.Delegate31 delegate31_0;

    private Class43.Delegate30 delegate30_0;

    protected IntPtr method_4() {
        return intptr_0;
    }

    protected void method_5(IntPtr intptr_2) {
        intptr_0 = intptr_2;
    }

    [CompilerGenerated]
    public void method_6(Class20.Delegate12 delegate12_1) {
        var @delegate = delegate12_0;
        Class20.Delegate12 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate12)Delegate.Combine(delegate2, delegate12_1);
            @delegate = Interlocked.CompareExchange(ref delegate12_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_7(Class20.Delegate12 delegate12_1) {
        var @delegate = delegate12_0;
        Class20.Delegate12 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate12)Delegate.Remove(delegate2, delegate12_1);
            @delegate = Interlocked.CompareExchange(ref delegate12_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_8(Class20.Delegate13 delegate13_1) {
        var @delegate = delegate13_0;
        Class20.Delegate13 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate13)Delegate.Combine(delegate2, delegate13_1);
            @delegate = Interlocked.CompareExchange(ref delegate13_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_9(Class20.Delegate13 delegate13_1) {
        var @delegate = delegate13_0;
        Class20.Delegate13 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate13)Delegate.Remove(delegate2, delegate13_1);
            @delegate = Interlocked.CompareExchange(ref delegate13_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_10(Class20.Delegate11 delegate11_1) {
        var @delegate = delegate11_0;
        Class20.Delegate11 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate11)Delegate.Combine(delegate2, delegate11_1);
            @delegate = Interlocked.CompareExchange(ref delegate11_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_11(Class20.Delegate11 delegate11_1) {
        var @delegate = delegate11_0;
        Class20.Delegate11 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate11)Delegate.Remove(delegate2, delegate11_1);
            @delegate = Interlocked.CompareExchange(ref delegate11_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_12(Class20.Delegate14 delegate14_1) {
        var @delegate = delegate14_0;
        Class20.Delegate14 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate14)Delegate.Combine(delegate2, delegate14_1);
            @delegate = Interlocked.CompareExchange(ref delegate14_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_13(Class20.Delegate14 delegate14_1) {
        var @delegate = delegate14_0;
        Class20.Delegate14 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate14)Delegate.Remove(delegate2, delegate14_1);
            @delegate = Interlocked.CompareExchange(ref delegate14_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_14(Class20.Delegate17 delegate17_1) {
        var @delegate = delegate17_0;
        Class20.Delegate17 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate17)Delegate.Combine(delegate2, delegate17_1);
            @delegate = Interlocked.CompareExchange(ref delegate17_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_15(Class20.Delegate17 delegate17_1) {
        var @delegate = delegate17_0;
        Class20.Delegate17 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate17)Delegate.Remove(delegate2, delegate17_1);
            @delegate = Interlocked.CompareExchange(ref delegate17_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_16(Class20.Delegate15 delegate15_1) {
        var @delegate = delegate15_0;
        Class20.Delegate15 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate15)Delegate.Combine(delegate2, delegate15_1);
            @delegate = Interlocked.CompareExchange(ref delegate15_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_17(Class20.Delegate15 delegate15_1) {
        var @delegate = delegate15_0;
        Class20.Delegate15 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate15)Delegate.Remove(delegate2, delegate15_1);
            @delegate = Interlocked.CompareExchange(ref delegate15_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_18(Class20.Delegate16 delegate16_1) {
        var @delegate = delegate16_0;
        Class20.Delegate16 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate16)Delegate.Combine(delegate2, delegate16_1);
            @delegate = Interlocked.CompareExchange(ref delegate16_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_19(Class20.Delegate16 delegate16_1) {
        var @delegate = delegate16_0;
        Class20.Delegate16 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate16)Delegate.Remove(delegate2, delegate16_1);
            @delegate = Interlocked.CompareExchange(ref delegate16_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_20(Class20.Delegate18 delegate18_1) {
        var @delegate = delegate18_0;
        Class20.Delegate18 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate18)Delegate.Combine(delegate2, delegate18_1);
            @delegate = Interlocked.CompareExchange(ref delegate18_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_21(Class20.Delegate18 delegate18_1) {
        var @delegate = delegate18_0;
        Class20.Delegate18 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class20.Delegate18)Delegate.Remove(delegate2, delegate18_1);
            @delegate = Interlocked.CompareExchange(ref delegate18_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    public Class48() {
        vmethod_0();
    }

    ~Class48() {
        vmethod_1();
    }

    public IntPtr method_22() {
        return method_4();
    }

    protected virtual bool vmethod_0() {
        if (!bool_0 && !(intptr_1 != IntPtr.Zero) && !(method_4() != IntPtr.Zero)) {
            intptr_1 = Class43.Create_Center_TcpAgentListener();
            if (intptr_1 == IntPtr.Zero) {
                return false;
            }
            method_5(Class43.Create_Center_TcpAgent(intptr_1));
            if (method_4() == IntPtr.Zero) {
                return false;
            }
            bool_0 = true;
            return true;
        }
        return false;
    }

    public virtual void vmethod_1() {
        method_24();
        if (method_4() != IntPtr.Zero) {
            Class43.Destroy_Center_TcpAgent(method_4());
            method_5(IntPtr.Zero);
        }
        if (intptr_1 != IntPtr.Zero) {
            Class43.Destroy_Center_TcpAgentListener(intptr_1);
            intptr_1 = IntPtr.Zero;
        }
        bool_0 = false;
    }

    public bool method_23(string string_0, bool bool_1 = true) {
        if (string.IsNullOrEmpty(string_0)) {
            throw new Exception("address is null");
        }
        if (!bool_0) {
            return false;
        }
        if (method_49()) {
            return false;
        }
        vmethod_2();
        return Class43.Center_Agent_Start(method_4(), string_0, bool_1);
    }

    public bool method_24() {
        if (!method_49()) {
            return false;
        }
        return Class43.Center_Agent_Stop(method_4());
    }

    public bool method_25(string string_0, ushort ushort_0, ref IntPtr intptr_2) {
        return Class43.Center_Agent_Connect(method_4(), string_0, ushort_0, ref intptr_2);
    }

    public bool method_26(string string_0, ushort ushort_0, ref IntPtr intptr_2, ushort ushort_1) {
        return Class43.Center_Agent_ConnectWithLocalPort(method_4(), string_0, ushort_0, ref intptr_2, ushort_1);
    }

    public IntPtr method_27(string string_0, ushort ushort_0) {
        var zero = IntPtr.Zero;
        Class43.Center_Agent_Connect(method_4(), string_0, ushort_0, ref zero);
        return zero;
    }

    public IntPtr method_28(Class50 class50_0) {
        var zero = IntPtr.Zero;
        Class43.Center_Agent_Connect(method_4(), class50_0.method_0(), class50_0.method_2(), ref zero);
        return zero;
    }

    public bool method_29(IntPtr intptr_2, byte[] byte_0, int int_0) {
        return Class43.Center_Agent_Send(method_4(), intptr_2, byte_0, int_0);
    }

    public bool method_30(IntPtr intptr_2, object object_0) {
        byte[] array = method_97(object_0);
        return method_29(intptr_2, array, array.Length);
    }

    public bool method_31(IntPtr intptr_2, IntPtr intptr_3, int int_0) {
        return Class43.Center_Agent_Send(method_4(), intptr_2, intptr_3, int_0);
    }

    public bool method_32(IntPtr intptr_2, byte[] byte_0, int int_0, int int_1) {
        return Class43.Center_Agent_SendPart(method_4(), intptr_2, byte_0, int_1, int_0);
    }

    public bool method_33(IntPtr intptr_2, IntPtr intptr_3, int int_0, int int_1) {
        return Class43.Center_Agent_SendPart(method_4(), intptr_2, intptr_3, int_1, int_0);
    }
    public bool method_37(IntPtr intptr_2, string string_0, byte[] byte_0, byte[] byte_1)
    {
        var zero = IntPtr.Zero;
        var zero2 = IntPtr.Zero;
        var @struct = default(Struct38);
        @struct.int_0 = 0;
        @struct.intptr_0 = zero;
        var struct38_ = @struct;
        @struct = default(Struct38);
        @struct.int_0 = 0;
        @struct.intptr_0 = zero2;
        var struct38_2 = @struct;
        if (byte_0 != null)
        {
            struct38_.int_0 = byte_0.Length;
            struct38_.intptr_0 = Marshal.UnsafeAddrOfPinnedArrayElement((Array)byte_0, 0);
        }
        if (byte_1 != null)
        {
            struct38_.int_0 = byte_1.Length;
            struct38_.intptr_0 = Marshal.UnsafeAddrOfPinnedArrayElement((Array)byte_1, 0);
        }
        return method_36(intptr_2, string_0, ref struct38_, ref struct38_2);
    }

    public bool method_38<T, U>(IntPtr intptr_2, string string_0, T gparam_0, U gparam_1)
    {
        byte[] byte_ = null;
        if (gparam_0 != null)
        {
            byte_ = method_95(gparam_0);
        }
        byte[] byte_2 = null;
        if (gparam_1 != null)
        {
            byte_2 = method_95(gparam_1);
        }
        return method_37(intptr_2, string_0, byte_, byte_2);
    }

    public bool method_39(IntPtr intptr_2, bool bool_1 = true)
    {
        return Class43.Center_Agent_Disconnect(method_4(), intptr_2, bool_1);
    }

    public bool method_40(uint uint_0, bool bool_1 = true)
    {
        return Class43.Center_Agent_DisconnectLongConnections(method_4(), uint_0, bool_1);
    }

    public bool method_41(uint uint_0, bool bool_1 = true)
    {
        return Class43.Center_Agent_DisconnectSilenceConnections(method_4(), uint_0, bool_1);
    }

    public bool method_42(IntPtr intptr_2)
    {
        return Class43.Center_Agent_PauseReceive(method_4(), intptr_2, bool_0: true);
    }

    public bool method_43(IntPtr intptr_2)
    {
        return Class43.Center_Agent_PauseReceive(method_4(), intptr_2, bool_0: false);
    }
    public bool method_34(IntPtr intptr_2, Struct38[] struct38_0, int int_0) {
        return Class43.Center_Agent_SendPackets(method_4(), intptr_2, struct38_0, int_0);
    }

    public bool method_35<T>(IntPtr intptr_2, T[] gparam_0) {
     //   bool flag = false;
        var array = new Struct38[gparam_0.Length];
        var array2 = new IntPtr[array.Length];
        try {
            for (int i = 0; i < gparam_0.Length; i++) {
                array[i].int_0 = Marshal.SizeOf(typeof(T));
                array2[i] = Marshal.AllocHGlobal(array[i].int_0);
                Marshal.StructureToPtr((object)gparam_0[i], array2[i], fDeleteOld: true);
                array[i].intptr_0 = array2[i];
            }
            return method_34(intptr_2, array, array.Length);
        }
        catch (Exception ex) {
            throw ex;
        }
        finally {
            for (int j = 0; j < array2.Length; j++) {
                if (array2[j] != IntPtr.Zero) {
                    Marshal.FreeHGlobal(array2[j]);
                }
            }
        }
    }



    public string method_47() {
        return Marshal.PtrToStringUni(Class43.Center_Agent_GetLastErrorDesc(method_4()));
    }

    public bool method_48(IntPtr intptr_2, ref int int_0) {
        return Class43.Center_Agent_GetPendingDataLength(method_4(), intptr_2, ref int_0);
    }

    public bool method_49() {
        if (method_4() == IntPtr.Zero) {
            return false;
        }
        return Class43.Center_Agent_HasStarted(method_4());
    }

    public Enum5 method_50() {
        return Class43.Center_Agent_GetState(method_4());
    }

    public uint method_51() {
        return Class43.Center_Agent_GetConnectionCount(method_4());
    }

    public bool method_52() {
        return Class43.Center_Agent_IsSecure(method_4());
    }

    public IntPtr[] method_53() {
        IntPtr[] array = null;
        while (true) {
            uint uint_ = method_51();
            if (uint_ == 0) {
                break;
            }
            array = new IntPtr[uint_];
            if (Class43.Center_Agent_GetAllConnectionIDs(method_4(), array, ref uint_)) {
                if (array.Length > uint_) {
                    var array2 = new IntPtr[uint_];
                    Array.Copy(array, array2, uint_);
                    array = array2;
                }
                break;
            }
        }
        return array;
    }

    public bool method_54(IntPtr intptr_2, ref string string_0, ref ushort ushort_0) {
        int int_ = 40;
        var stringBuilder = new StringBuilder(40);
        bool num = Class43.Center_Agent_GetLocalAddress(method_4(), intptr_2, stringBuilder, ref int_, ref ushort_0);
        if (num) {
            string_0 = stringBuilder.ToString();
        }
        return num;
    }

    public bool method_55(IntPtr intptr_2, ref string string_0, ref ushort ushort_0) {
        int int_ = 40;
        var stringBuilder = new StringBuilder(40);
        bool num = Class43.Center_Agent_GetRemoteAddress(method_4(), intptr_2, stringBuilder, ref int_, ref ushort_0);
        if (num) {
            string_0 = stringBuilder.ToString();
        }
        return num;
    }
    public bool method_36(IntPtr intptr_2, string string_0, ref Struct38 struct38_0, ref Struct38 struct38_1)
    {
        return Class43.Center_TcpAgent_SendSmallFile(method_4(), intptr_2, string_0, ref struct38_0, ref struct38_1);
    }



    public Enum11 method_44(IntPtr intptr_2)
    {
        int int_ = -1;
        if (Class43.Center_Agent_IsPauseReceive(method_4(), intptr_2, ref int_))
        {
            return (Enum11)int_;
        }
        return Enum11.const_0;
    }

    public Enum6 method_45()
    {
        return Class43.Center_Agent_GetLastError(method_4());
    }

    public string method_46()
    {
        return Class43.smethod_0();
    }
    public bool method_56(IntPtr intptr_2, ref string string_0, ref ushort ushort_0) {
        int int_ = 40;
        var stringBuilder = new StringBuilder(40);
        bool num = Class43.Center_Agent_GetRemoteHost(method_4(), intptr_2, stringBuilder, ref int_, ref ushort_0);
        if (num) {
            string_0 = stringBuilder.ToString();
        }
        return num;
    }

    public bool method_57(IntPtr intptr_2, ref uint uint_0) {
        return Class43.Center_Agent_GetConnectPeriod(method_4(), intptr_2, ref uint_0);
    }

    public bool method_58(IntPtr intptr_2, ref uint uint_0) {
        return Class43.Center_Agent_GetSilencePeriod(method_4(), intptr_2, ref uint_0);
    }

    public bool method_59() {
        return Class43.Center_TcpAgent_IsReuseAddress(method_4());
    }

    public void method_60(bool bool_1) {
        Class43.Center_TcpAgent_SetReuseAddress(method_4(), bool_1);
    }



    public uint method_75() {
        return Class43.Center_Agent_GetFreeBufferObjHold(method_4());
    }

    public void method_76(uint uint_0) {
        Class43.Center_Agent_SetFreeBufferObjHold(method_4(), uint_0);
    }

    public uint method_77() {
        return Class43.Center_TcpAgent_GetKeepAliveTime(method_4());
    }

    public void method_78(uint uint_0) {
        Class43.Center_TcpAgent_SetKeepAliveTime(method_4(), uint_0);
    }

    public uint method_79() {
        return Class43.Center_TcpAgent_GetKeepAliveInterval(method_4());
    }

    public void method_80(uint uint_0) {
        Class43.Center_TcpAgent_SetKeepAliveInterval(method_4(), uint_0);
    }

    public bool method_81() {
        return Class43.Center_Agent_IsMarkSilence(method_4());
    }

    public void method_82(bool bool_1) {
        Class43.Center_Agent_SetMarkSilence(method_4(), bool_1);
    }

    public Enum4 method_83() {
        return Class43.Center_Agent_GetSendPolicy(method_4());
    }

    public void method_84(Enum4 enum4_0) {
        Class43.Center_Agent_SetSendPolicy(method_4(), enum4_0);
    }
    public uint method_61()
    {
        return Class43.Center_Agent_GetMaxConnectionCount(method_4());
    }

    public void method_62(uint uint_0)
    {
        Class43.Center_Agent_SetMaxConnectionCount(method_4(), uint_0);
    }

    public uint method_63()
    {
        return Class43.Center_Agent_GetWorkerThreadCount(method_4());
    }

    public void method_64(uint uint_0)
    {
        Class43.Center_Agent_SetWorkerThreadCount(method_4(), uint_0);
    }

    public uint method_65()
    {
        return Class43.Center_TcpAgent_GetSocketBufferSize(method_4());
    }

    public void method_66(uint uint_0)
    {
        Class43.Center_TcpAgent_SetSocketBufferSize(method_4(), uint_0);
    }

    public uint method_67()
    {
        return Class43.Center_Agent_GetFreeSocketObjLockTime(method_4());
    }

    public void method_68(uint uint_0)
    {
        Class43.Center_Agent_SetFreeSocketObjLockTime(method_4(), uint_0);
    }

    public uint method_69()
    {
        return Class43.Center_Agent_GetFreeSocketObjPool(method_4());
    }

    public void method_70(uint uint_0)
    {
        Class43.Center_Agent_SetFreeSocketObjPool(method_4(), uint_0);
    }

    public uint method_71()
    {
        return Class43.Center_Agent_GetFreeBufferObjPool(method_4());
    }

    public void method_72(uint uint_0)
    {
        Class43.Center_Agent_SetFreeBufferObjPool(method_4(), uint_0);
    }

    public uint method_73()
    {
        return Class43.Center_Agent_GetFreeSocketObjHold(method_4());
    }

    public void method_74(uint uint_0)
    {
        Class43.Center_Agent_SetFreeSocketObjHold(method_4(), uint_0);
    }
    public Enum7 method_85() {
        return Class43.Center_Agent_GetOnSendSyncPolicy(method_4());
    }

    public void method_86(Enum7 enum7_0) {
        Class43.Center_Agent_SetOnSendSyncPolicy(method_4(), enum7_0);
    }

    public string method_87(Enum6 enum6_0) {
        return Marshal.PtrToStringUni(Class43.Center_GetSocketErrorDesc(enum6_0));
    }

    protected virtual void vmethod_2() {
        delegate32_0 = vmethod_3;
        delegate33_0 = vmethod_4;
        delegate26_0 = vmethod_5;
        delegate27_0 = vmethod_6;
        delegate29_0 = vmethod_7;
        delegate31_0 = vmethod_8;
        delegate30_0 = method_88;
        Class43.Center_Set_FN_Agent_OnPrepareConnect(intptr_1, delegate32_0);
        Class43.Center_Set_FN_Agent_OnConnect(intptr_1, delegate33_0);
        Class43.Center_Set_FN_Server_OnSend(intptr_1, delegate26_0);
        Class43.Center_Set_FN_Server_OnReceive(intptr_1, delegate27_0);
        Class43.Center_Set_FN_Server_OnClose(intptr_1, delegate29_0);
        Class43.Center_Set_FN_Agent_OnShutdown(intptr_1, delegate31_0);
        Class43.Center_Set_FN_Server_OnHandShake(intptr_1, delegate30_0);
    }

    protected Enum2 method_88(IntPtr intptr_2, IntPtr intptr_3) {
        if (delegate18_0 != null) {
            return delegate18_0(intptr_3);
        }
        return Enum2.const_1;
    }

    protected virtual Enum2 vmethod_3(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4) {
        if (delegate11_0 != null) {
            return delegate11_0(intptr_3, intptr_4);
        }
        return Enum2.const_1;
    }

    protected virtual Enum2 vmethod_4(IntPtr intptr_2, IntPtr intptr_3) {
        if (delegate12_0 != null) {
            return delegate12_0(intptr_3);
        }
        return Enum2.const_1;
    }

    protected virtual Enum2 vmethod_5(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, int int_0) {
        if (delegate13_0 != null) {
            byte[] array = new byte[int_0];
            Marshal.Copy(intptr_4, array, 0, int_0);
            return delegate13_0(intptr_3, array);
        }
        return Enum2.const_1;
    }

    protected virtual Enum2 vmethod_6(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, int int_0) {
        if (delegate17_0 != null) {
            return delegate17_0(intptr_3, intptr_4, int_0);
        }
        if (delegate14_0 != null) {
            byte[] array = new byte[int_0];
            Marshal.Copy(intptr_4, array, 0, int_0);
            return delegate14_0(intptr_3, array);
        }
        return Enum2.const_1;
    }

    protected virtual Enum2 vmethod_7(IntPtr intptr_2, IntPtr intptr_3, Enum3 enum3_0, int int_0) {
        if (delegate15_0 != null) {
            return delegate15_0(intptr_3, enum3_0, int_0);
        }
        return Enum2.const_1;
    }
    public int method_92(IntPtr intptr_2, int int_0, int int_1, IntPtr intptr_3, ref int int_2)
    {
        return Class43.SYS_GetSocketOption(intptr_2, int_0, int_1, intptr_3, ref int_2);
    }

    public int method_93(IntPtr intptr_2, long long_0, IntPtr intptr_3)
    {
        return Class43.SYS_IoctlSocket(intptr_2, long_0, intptr_3);
    }

    public int method_94(IntPtr intptr_2, uint uint_0, IntPtr intptr_3, uint uint_1, IntPtr intptr_4, uint uint_2, uint uint_3)
    {
        return Class43.SYS_WSAIoctl(intptr_2, uint_0, intptr_3, uint_1, intptr_4, uint_2, uint_3);
    }

    public byte[] method_95<T>(T gparam_0)
    {
        int num = Marshal.SizeOf(typeof(T));
        byte[] array = new byte[num];
        var intPtr = Marshal.AllocHGlobal(num);
        try
        {
            Marshal.StructureToPtr((object)gparam_0, intPtr, fDeleteOld: true);
            Marshal.Copy(intPtr, array, 0, num);
            return array;
        }
        finally
        {
            Marshal.FreeHGlobal(intPtr);
        }
    }

    public T method_96<T>(byte[] byte_0)
    {
        object obj = null;
        int num = Marshal.SizeOf(typeof(T));
        var intPtr = Marshal.AllocHGlobal(num);
        try
        {
            Marshal.Copy(byte_0, 0, intPtr, num);
            obj = Marshal.PtrToStructure(intPtr, typeof(T));
        }
        finally
        {
            Marshal.FreeHGlobal(intPtr);
        }
        return (T)obj;
    }

    public byte[] method_97(object object_0)
    {
        using (var memoryStream = new MemoryStream())
        {
            ((IFormatter)new BinaryFormatter()).Serialize((Stream)memoryStream, object_0);
            return memoryStream.GetBuffer();
        }
    }
    protected virtual Enum2 vmethod_8(IntPtr intptr_2) {
        if (delegate16_0 != null) {
            return delegate16_0();
        }
        return Enum2.const_1;
    }

    public int method_89() {
        return Class43.smethod_1();
    }

    public int method_90() {
        return Class43.SYS_WSAGetLastError();
    }

    public int method_91(IntPtr intptr_2, int int_0, int int_1, IntPtr intptr_3, int int_2) {
        return Class43.SYS_SetSocketOption(intptr_2, int_0, int_1, intptr_3, int_2);
    }



    public object method_98(byte[] byte_0) {
        using (var serializationStream = new MemoryStream(byte_0)) {
            return ((IFormatter)new BinaryFormatter()).Deserialize((Stream)serializationStream);
        }
    }

    public T method_99<T>(byte[] byte_0) {
        var typeFromHandle = typeof(T);
        int num = Marshal.SizeOf(typeFromHandle);
        var intPtr = Marshal.AllocHGlobal(num);
        try {
            Marshal.Copy(byte_0, 0, intPtr, num);
            return (T)Marshal.PtrToStructure(intPtr, typeFromHandle);
        }
        finally {
            Marshal.FreeHGlobal(intPtr);
        }
    }
}
