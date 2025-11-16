using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

internal class Class46 : Class45 {
    protected IntPtr intptr_0 = IntPtr.Zero;

    protected IntPtr intptr_1 = IntPtr.Zero;

    [CompilerGenerated]
    private string string_0;

    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private Class19.Delegate4 delegate4_0;

    [CompilerGenerated]
    private Class19.Delegate5 delegate5_0;

    [CompilerGenerated]
    private Class19.Delegate3 delegate3_0;

    [CompilerGenerated]
    private Class19.Delegate6 delegate6_0;

    [CompilerGenerated]
    private Class19.Delegate9 delegate9_0;

    [CompilerGenerated]
    private Class19.Delegate7 delegate7_0;

    [CompilerGenerated]
    private Class19.Delegate8 delegate8_0;

    [CompilerGenerated]
    private Class19.Delegate10 delegate10_0;

    protected bool bool_0;

    private Class43.Delegate34 delegate34_0;

    private Class43.Delegate35 delegate35_0;

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
    public string method_6() {
        return string_0;
    }

    [CompilerGenerated]
    public void method_7(string string_1) {
        string_0 = string_1;
    }

    [CompilerGenerated]
    public ushort method_8() {
        return ushort_0;
    }

    [CompilerGenerated]
    public void method_9(ushort ushort_1) {
        ushort_0 = ushort_1;
    }

    [CompilerGenerated]
    public void method_10(Class19.Delegate4 delegate4_1) {
        var @delegate = delegate4_0;
        Class19.Delegate4 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate4)Delegate.Combine(delegate2, delegate4_1);
            @delegate = Interlocked.CompareExchange(ref delegate4_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_11(Class19.Delegate4 delegate4_1) {
        var @delegate = delegate4_0;
        Class19.Delegate4 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate4)Delegate.Remove(delegate2, delegate4_1);
            @delegate = Interlocked.CompareExchange(ref delegate4_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_12(Class19.Delegate5 delegate5_1) {
        var @delegate = delegate5_0;
        Class19.Delegate5 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate5)Delegate.Combine(delegate2, delegate5_1);
            @delegate = Interlocked.CompareExchange(ref delegate5_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_13(Class19.Delegate5 delegate5_1) {
        var @delegate = delegate5_0;
        Class19.Delegate5 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate5)Delegate.Remove(delegate2, delegate5_1);
            @delegate = Interlocked.CompareExchange(ref delegate5_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_14(Class19.Delegate3 delegate3_1) {
        var @delegate = delegate3_0;
        Class19.Delegate3 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate3)Delegate.Combine(delegate2, delegate3_1);
            @delegate = Interlocked.CompareExchange(ref delegate3_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_15(Class19.Delegate3 delegate3_1) {
        var @delegate = delegate3_0;
        Class19.Delegate3 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate3)Delegate.Remove(delegate2, delegate3_1);
            @delegate = Interlocked.CompareExchange(ref delegate3_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_16(Class19.Delegate6 delegate6_1) {
        var @delegate = delegate6_0;
        Class19.Delegate6 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate6)Delegate.Combine(delegate2, delegate6_1);
            @delegate = Interlocked.CompareExchange(ref delegate6_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_17(Class19.Delegate6 delegate6_1) {
        var @delegate = delegate6_0;
        Class19.Delegate6 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate6)Delegate.Remove(delegate2, delegate6_1);
            @delegate = Interlocked.CompareExchange(ref delegate6_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_18(Class19.Delegate9 delegate9_1) {
        var @delegate = delegate9_0;
        Class19.Delegate9 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate9)Delegate.Combine(delegate2, delegate9_1);
            @delegate = Interlocked.CompareExchange(ref delegate9_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_19(Class19.Delegate9 delegate9_1) {
        var @delegate = delegate9_0;
        Class19.Delegate9 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate9)Delegate.Remove(delegate2, delegate9_1);
            @delegate = Interlocked.CompareExchange(ref delegate9_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_20(Class19.Delegate7 delegate7_1) {
        var @delegate = delegate7_0;
        Class19.Delegate7 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate7)Delegate.Combine(delegate2, delegate7_1);
            @delegate = Interlocked.CompareExchange(ref delegate7_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_21(Class19.Delegate7 delegate7_1) {
        var @delegate = delegate7_0;
        Class19.Delegate7 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate7)Delegate.Remove(delegate2, delegate7_1);
            @delegate = Interlocked.CompareExchange(ref delegate7_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_22(Class19.Delegate8 delegate8_1) {
        var @delegate = delegate8_0;
        Class19.Delegate8 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate8)Delegate.Combine(delegate2, delegate8_1);
            @delegate = Interlocked.CompareExchange(ref delegate8_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_23(Class19.Delegate8 delegate8_1) {
        var @delegate = delegate8_0;
        Class19.Delegate8 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate8)Delegate.Remove(delegate2, delegate8_1);
            @delegate = Interlocked.CompareExchange(ref delegate8_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_24(Class19.Delegate10 delegate10_1) {
        var @delegate = delegate10_0;
        Class19.Delegate10 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate10)Delegate.Combine(delegate2, delegate10_1);
            @delegate = Interlocked.CompareExchange(ref delegate10_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_25(Class19.Delegate10 delegate10_1) {
        var @delegate = delegate10_0;
        Class19.Delegate10 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class19.Delegate10)Delegate.Remove(delegate2, delegate10_1);
            @delegate = Interlocked.CompareExchange(ref delegate10_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    public IntPtr method_26() {
        return method_4();
    }

    public Class46() {
        vmethod_0();
    }

    ~Class46() {
        vmethod_1();
    }

    protected virtual bool vmethod_0() {
        if (!bool_0 && !(intptr_1 != IntPtr.Zero) && !(method_4() != IntPtr.Zero)) {
            intptr_1 = Class43.Create_Center_TcpServerListener();
            if (intptr_1 == IntPtr.Zero) {
                return false;
            }
            method_5(Class43.Create_Center_TcpServer(intptr_1));
            if (method_4() == IntPtr.Zero) {
                return false;
            }
            bool_0 = true;
            return true;
        }
        return false;
    }

    public virtual void vmethod_1() {
        method_28();
        if (method_4() != IntPtr.Zero) {
            Class43.Destroy_Center_TcpServer(method_4());
            method_5(IntPtr.Zero);
        }
        if (intptr_1 != IntPtr.Zero) {
            Class43.Destroy_Center_TcpServerListener(intptr_1);
            intptr_1 = IntPtr.Zero;
        }
        bool_0 = false;
    }

    public bool method_27() {
        if (!bool_0) {
            return false;
        }
        if (method_49()) {
            return false;
        }
        vmethod_2();
        return Class43.Center_Server_Start(method_4(), method_6(), method_8());
    }

    public bool method_28() {
        if (!method_49()) {
            return false;
        }
        return Class43.Center_Server_Stop(method_4());
    }

    public bool method_29(IntPtr intptr_2, byte[] byte_0) {
        return Class43.Center_Server_Send(method_4(), intptr_2, byte_0, byte_0.Length);
    }

    public bool method_46(IntPtr intptr_2, ref string string_1, ref ushort ushort_1)
    {
        int int_ = 40;
        var stringBuilder = new StringBuilder(40);
        int num;
        if (Class43.Center_Server_GetLocalAddress(method_4(), intptr_2, stringBuilder, ref int_, ref ushort_1))
        {
            num = ((int_ > 0) ? 1 : 0);
            if (num != 0)
            {
                string_1 = stringBuilder.ToString();
            }
        }
        else
        {
            num = 0;
        }
        return (byte)num != 0;
    }

    public bool method_47(IntPtr intptr_2, ref string string_1, ref ushort ushort_1)
    {
        int int_ = 40;
        var stringBuilder = new StringBuilder(40);
        int num;
        if (Class43.Center_Server_GetRemoteAddress(method_4(), intptr_2, stringBuilder, ref int_, ref ushort_1))
        {
            num = ((int_ > 0) ? 1 : 0);
            if (num != 0)
            {
                string_1 = stringBuilder.ToString();
            }
        }
        else
        {
            num = 0;
        }
        return (byte)num != 0;
    }

    public bool method_48(IntPtr intptr_2, ref int int_0)
    {
        return Class43.Center_Server_GetPendingDataLength(method_4(), intptr_2, ref int_0);
    }

    public bool method_49()
    {
        if (method_4() == IntPtr.Zero)
        {
            return false;
        }
        return Class43.Center_Server_HasStarted(method_4());
    }

    public Enum5 method_50()
    {
        return Class43.Center_Server_GetState(method_4());
    }

    public uint method_51()
    {
        return Class43.Center_Server_GetConnectionCount(method_4());
    }

    public bool method_52()
    {
        return Class43.Center_Server_IsSecure(method_4());
    }

    public IntPtr[] method_53()
    {
        IntPtr[] array = null;
        while (true)
        {
            uint uint_ = method_51();
            if (uint_ == 0)
            {
                break;
            }
            array = new IntPtr[uint_];
            if (Class43.Center_Server_GetAllConnectionIDs(method_4(), array, ref uint_))
            {
                if (array.Length > uint_)
                {
                    var array2 = new IntPtr[uint_];
                    Array.Copy(array, array2, uint_);
                    array = array2;
                }
                break;
            }
        }
        return array;
    }

    public bool method_34(IntPtr intptr_2, object object_0) {
        byte[] array = method_106(object_0);
        return method_30(intptr_2, array, array.Length);
    }

    public bool method_35(IntPtr intptr_2, Struct38[] struct38_0, int int_0) {
        return Class43.Center_Server_SendPackets(method_4(), intptr_2, struct38_0, int_0);
    }

    public bool method_36<T>(IntPtr intptr_2, T[] gparam_0) {
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
            return method_35(intptr_2, array, array.Length);
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

    public bool method_37(IntPtr intptr_2, string string_1, ref Struct38 struct38_0, ref Struct38 struct38_1) {
        return Class43.Center_TcpServer_SendSmallFile(method_4(), intptr_2, string_1, ref struct38_0, ref struct38_1);
    }

    public bool method_38(IntPtr intptr_2, string string_1, byte[] byte_0, byte[] byte_1) {
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
        if (byte_0 != null) {
            struct38_.int_0 = byte_0.Length;
            struct38_.intptr_0 = Marshal.UnsafeAddrOfPinnedArrayElement((Array)byte_0, 0);
        }
        if (byte_1 != null) {
            struct38_.int_0 = byte_1.Length;
            struct38_.intptr_0 = Marshal.UnsafeAddrOfPinnedArrayElement((Array)byte_1, 0);
        }
        return method_37(intptr_2, string_1, ref struct38_, ref struct38_2);
    }

    public bool method_39<T, U>(IntPtr intptr_2, string string_1, T gparam_0, U gparam_1) {
        byte[] byte_ = null;
        if (gparam_0 != null) {
            byte_ = method_104(gparam_0);
        }
        byte[] byte_2 = null;
        if (gparam_1 != null) {
            byte_2 = method_104(gparam_1);
        }
        return method_38(intptr_2, string_1, byte_, byte_2);
    }

    public bool method_40(IntPtr intptr_2, bool bool_1 = true) {
        return Class43.Center_Server_Disconnect(method_4(), intptr_2, bool_1);
    }

    public bool method_41(uint uint_0, bool bool_1 = true) {
        return Class43.Center_Server_DisconnectLongConnections(method_4(), uint_0, bool_1);
    }

    public bool method_42(IntPtr intptr_2) {
        return Class43.Center_Server_PauseReceive(method_4(), intptr_2, bool_0: true);
    }
    public bool method_30(IntPtr intptr_2, byte[] byte_0, int int_0)
    {
        return Class43.Center_Server_Send(method_4(), intptr_2, byte_0, int_0);
    }

    public bool method_31(IntPtr intptr_2, IntPtr intptr_3, int int_0)
    {
        return Class43.Center_Server_Send(method_4(), intptr_2, intptr_3, int_0);
    }

    public bool method_32(IntPtr intptr_2, byte[] byte_0, int int_0, int int_1)
    {
        return Class43.Center_Server_SendPart(method_4(), intptr_2, byte_0, int_1, int_0);
    }

    public bool method_33(IntPtr intptr_2, IntPtr intptr_3, int int_0, int int_1)
    {
        return Class43.Center_Server_SendPart(method_4(), intptr_2, intptr_3, int_1, int_0);
    }
    public bool method_43(IntPtr intptr_2) {
        return Class43.Center_Server_PauseReceive(method_4(), intptr_2, bool_0: false);
    }

    public Enum11 method_44(IntPtr intptr_2) {
        int int_ = -1;
        if (Class43.Center_Server_IsPauseReceive(method_4(), intptr_2, ref int_)) {
            return (Enum11)int_;
        }
        return Enum11.const_0;
    }

    public bool method_45(uint uint_0, bool bool_1 = true) {
        return Class43.Center_Server_DisconnectSilenceConnections(method_4(), uint_0, bool_1);
    }



    public bool method_54(ref string string_1, ref ushort ushort_1) {
        int int_ = 40;
        var stringBuilder = new StringBuilder(40);
        bool num = Class43.Center_Server_GetListenAddress(method_4(), stringBuilder, ref int_, ref ushort_1);
        if (num) {
            string_1 = stringBuilder.ToString();
        }
        return num;
    }

    public bool method_55(IntPtr intptr_2, ref uint uint_0) {
        return Class43.Center_Server_GetConnectPeriod(method_4(), intptr_2, ref uint_0);
    }

    public bool method_56(IntPtr intptr_2, ref uint uint_0) {
        return Class43.Center_Server_GetSilencePeriod(method_4(), intptr_2, ref uint_0);
    }

    public uint method_57() {
        return Class43.Center_Server_GetMaxConnectionCount(method_4());
    }

    public void method_58(uint uint_0) {
        Class43.Center_Server_SetMaxConnectionCount(method_4(), uint_0);
    }

    public uint method_59() {
        return Class43.Center_Server_GetWorkerThreadCount(method_4());
    }

    public void method_60(uint uint_0) {
        Class43.Center_Server_SetWorkerThreadCount(method_4(), uint_0);
    }

    public uint method_61() {
        return Class43.Center_TcpServer_GetAcceptSocketCount(method_4());
    }

    public void method_62(uint uint_0) {
        Class43.Center_TcpServer_SetAcceptSocketCount(method_4(), uint_0);
    }

    public uint method_63() {
        return Class43.Center_TcpServer_GetSocketBufferSize(method_4());
    }

    public void method_64(uint uint_0) {
        Class43.Center_TcpServer_SetSocketBufferSize(method_4(), uint_0);
    }

    public uint method_65() {
        return Class43.Center_TcpServer_GetSocketListenQueue(method_4());
    }

    public void method_66(uint uint_0) {
        Class43.Center_TcpServer_SetSocketListenQueue(method_4(), uint_0);
    }

    public uint method_67() {
        return Class43.Center_Server_GetFreeSocketObjLockTime(method_4());
    }

    public void method_68(uint uint_0) {
        Class43.Center_Server_SetFreeSocketObjLockTime(method_4(), uint_0);
    }

    public uint method_69() {
        return Class43.Center_Server_GetFreeSocketObjPool(method_4());
    }

    public void method_70(uint uint_0) {
        Class43.Center_Server_SetFreeSocketObjPool(method_4(), uint_0);
    }

    public uint method_71() {
        return Class43.Center_Server_GetFreeBufferObjPool(method_4());
    }

    public void method_72(uint uint_0) {
        Class43.Center_Server_SetFreeBufferObjPool(method_4(), uint_0);
    }

    public uint method_73() {
        return Class43.Center_Server_GetFreeSocketObjHold(method_4());
    }



    public Enum7 method_85() {
        return Class43.Center_Server_GetOnSendSyncPolicy(method_4());
    }

    public void method_86(Enum7 enum7_0) {
        Class43.Center_Server_SetOnSendSyncPolicy(method_4(), enum7_0);
    }

    public int method_87() {
        return Class43.smethod_1();
    }

    public int method_88() {
        return Class43.SYS_WSAGetLastError();
    }

    public Enum6 method_89() {
        return Class43.Center_Server_GetLastError(method_4());
    }

    public string method_90() {
        return Class43.smethod_0();
    }

    public string method_91() {
        return Marshal.PtrToStringUni(Class43.Center_Server_GetLastErrorDesc(method_4()));
    }

    protected virtual void vmethod_2() {
        delegate34_0 = method_93;
        delegate35_0 = method_94;
        delegate26_0 = method_95;
        delegate27_0 = method_96;
        delegate29_0 = method_97;
        delegate31_0 = method_98;
        delegate30_0 = method_92;
        Class43.Center_Set_FN_Server_OnPrepareListen(intptr_1, delegate34_0);
        Class43.Center_Set_FN_Server_OnAccept(intptr_1, delegate35_0);
        Class43.Center_Set_FN_Server_OnSend(intptr_1, delegate26_0);
        Class43.Center_Set_FN_Server_OnReceive(intptr_1, delegate27_0);
        Class43.Center_Set_FN_Server_OnClose(intptr_1, delegate29_0);
        Class43.Center_Set_FN_Server_OnShutdown(intptr_1, delegate31_0);
        Class43.Center_Set_FN_Server_OnHandShake(intptr_1, delegate30_0);
    }

    protected Enum2 method_92(IntPtr intptr_2, IntPtr intptr_3) {
        if (delegate10_0 != null) {
            return delegate10_0(this, intptr_3);
        }
        return Enum2.const_1;
    }

    protected Enum2 method_93(IntPtr intptr_2, IntPtr intptr_3) {
        if (delegate3_0 != null) {
            return delegate3_0(this, intptr_3);
        }
        return Enum2.const_1;
    }

    protected Enum2 method_94(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4) {
        if (delegate4_0 != null) {
            return delegate4_0(this, intptr_3, intptr_4);
        }
        return Enum2.const_1;
    }

    protected Enum2 method_95(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, int int_0) {
        if (delegate5_0 != null) {
            byte[] array = new byte[int_0];
            Marshal.Copy(intptr_4, array, 0, int_0);
            return delegate5_0(this, intptr_3, array);
        }
        return Enum2.const_1;
    }

    protected Enum2 method_96(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, int int_0) {
        if (delegate9_0 != null) {
            return delegate9_0(this, intptr_3, intptr_4, int_0);
        }
        if (delegate6_0 != null) {
            byte[] array = new byte[int_0];
            Marshal.Copy(intptr_4, array, 0, int_0);
            return delegate6_0(this, intptr_3, array);
        }
        return Enum2.const_1;
    }

    protected Enum2 method_97(IntPtr intptr_2, IntPtr intptr_3, Enum3 enum3_0, int int_0) {
        if (delegate7_0 != null) {
            return delegate7_0(this, intptr_3, enum3_0, int_0);
        }
        return Enum2.const_1;
    }

    protected Enum2 method_98(IntPtr intptr_2) {
        if (delegate8_0 != null) {
            return delegate8_0(this);
        }
        return Enum2.const_1;
    }

    public string method_99(Enum6 enum6_0) {
        return Marshal.PtrToStringUni(Class43.Center_GetSocketErrorDesc(enum6_0));
    }

    public int method_100(IntPtr intptr_2, int int_0, int int_1, IntPtr intptr_3, int int_2) {
        return Class43.SYS_SetSocketOption(intptr_2, int_0, int_1, intptr_3, int_2);
    }

    public int method_101(IntPtr intptr_2, int int_0, int int_1, IntPtr intptr_3, ref int int_2) {
        return Class43.SYS_GetSocketOption(intptr_2, int_0, int_1, intptr_3, ref int_2);
    }

    public int method_102(IntPtr intptr_2, long long_0, IntPtr intptr_3) {
        return Class43.SYS_IoctlSocket(intptr_2, long_0, intptr_3);
    }
    public void method_74(uint uint_0)
    {
        Class43.Center_Server_SetFreeSocketObjHold(method_4(), uint_0);
    }

    public uint method_75()
    {
        return Class43.Center_Server_GetFreeBufferObjHold(method_4());
    }

    public void method_76(uint uint_0)
    {
        Class43.Center_Server_SetFreeBufferObjHold(method_4(), uint_0);
    }

    public uint method_77()
    {
        return Class43.Center_TcpServer_GetKeepAliveTime(method_4());
    }

    public void method_78(uint uint_0)
    {
        Class43.Center_TcpServer_SetKeepAliveTime(method_4(), uint_0);
    }

    public uint method_79()
    {
        return Class43.Center_TcpServer_GetKeepAliveInterval(method_4());
    }

    public void method_80(uint uint_0)
    {
        Class43.Center_TcpServer_SetKeepAliveInterval(method_4(), uint_0);
    }

    public bool method_81()
    {
        return Class43.Center_Server_IsMarkSilence(method_4());
    }

    public void method_82(bool bool_1)
    {
        Class43.Center_Server_SetMarkSilence(method_4(), bool_1);
    }

    public Enum4 method_83()
    {
        return Class43.Center_Server_GetSendPolicy(method_4());
    }

    public void method_84(Enum4 enum4_0)
    {
        Class43.Center_Server_SetSendPolicy(method_4(), enum4_0);
    }
    public int method_103(IntPtr intptr_2, uint uint_0, IntPtr intptr_3, uint uint_1, IntPtr intptr_4, uint uint_2, uint uint_3) {
        return Class43.SYS_WSAIoctl(intptr_2, uint_0, intptr_3, uint_1, intptr_4, uint_2, uint_3);
    }

    public byte[] method_104<T>(T gparam_0) {
        int num = Marshal.SizeOf(typeof(T));
        byte[] array = new byte[num];
        var intPtr = Marshal.AllocHGlobal(num);
        try {
            Marshal.StructureToPtr((object)gparam_0, intPtr, fDeleteOld: true);
            Marshal.Copy(intPtr, array, 0, num);
            return array;
        }
        finally {
            Marshal.FreeHGlobal(intPtr);
        }
    }

    public T method_105<T>(byte[] byte_0) {
        object obj = null;
        int num = Marshal.SizeOf(typeof(T));
        var intPtr = Marshal.AllocHGlobal(num);
        try {
            Marshal.Copy(byte_0, 0, intPtr, num);
            obj = Marshal.PtrToStructure(intPtr, typeof(T));
        }
        finally {
            Marshal.FreeHGlobal(intPtr);
        }
        return (T)obj;
    }

    public byte[] method_106(object object_0) {
        using (var memoryStream = new MemoryStream()) {
            ((IFormatter)new BinaryFormatter()).Serialize((Stream)memoryStream, object_0);
            return memoryStream.GetBuffer();
        }
    }

    public object method_107(byte[] byte_0) {
        using (var serializationStream = new MemoryStream(byte_0)) {
            return ((IFormatter)new BinaryFormatter()).Deserialize((Stream)serializationStream);
        }
    }

    public T method_108<T>(byte[] byte_0) {
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
