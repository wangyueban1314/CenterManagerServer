using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

internal class Class25 {
    protected IntPtr intptr_0 = IntPtr.Zero;

    protected IntPtr intptr_1 = IntPtr.Zero;

    protected bool bool_0;

    private Class45 class45_0 = new Class45();

    [CompilerGenerated]
    private Class27.Delegate19 delegate19_0;

    [CompilerGenerated]
    private Class27.Delegate20 delegate20_0;

    [CompilerGenerated]
    private Class27.Delegate21 delegate21_0;

    [CompilerGenerated]
    private Class27.Delegate22 delegate22_0;

    [CompilerGenerated]
    private Class27.Delegate24 delegate24_0;

    [CompilerGenerated]
    private Class27.Delegate23 delegate23_0;

    [CompilerGenerated]
    private Class27.Delegate25 delegate25_0;

    private Class43.Delegate32 delegate32_0;

    private Class43.Delegate33 delegate33_0;

    private Class43.Delegate27 delegate27_0;

    private Class43.Delegate26 delegate26_0;

    private Class43.Delegate29 delegate29_0;

    private Class43.Delegate30 delegate30_0;

    protected IntPtr method_0() {
        return intptr_0;
    }

    protected void method_1(IntPtr intptr_2) {
        intptr_0 = intptr_2;
    }

    [CompilerGenerated]
    public void method_2(Class27.Delegate19 delegate19_1) {
        var @delegate = delegate19_0;
        Class27.Delegate19 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate19)Delegate.Combine(delegate2, delegate19_1);
            @delegate = Interlocked.CompareExchange(ref delegate19_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_3(Class27.Delegate19 delegate19_1) {
        var @delegate = delegate19_0;
        Class27.Delegate19 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate19)Delegate.Remove(delegate2, delegate19_1);
            @delegate = Interlocked.CompareExchange(ref delegate19_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_4(Class27.Delegate20 delegate20_1) {
        var @delegate = delegate20_0;
        Class27.Delegate20 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate20)Delegate.Combine(delegate2, delegate20_1);
            @delegate = Interlocked.CompareExchange(ref delegate20_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_5(Class27.Delegate20 delegate20_1) {
        var @delegate = delegate20_0;
        Class27.Delegate20 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate20)Delegate.Remove(delegate2, delegate20_1);
            @delegate = Interlocked.CompareExchange(ref delegate20_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_6(Class27.Delegate21 delegate21_1) {
        var @delegate = delegate21_0;
        Class27.Delegate21 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate21)Delegate.Combine(delegate2, delegate21_1);
            @delegate = Interlocked.CompareExchange(ref delegate21_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_7(Class27.Delegate21 delegate21_1) {
        var @delegate = delegate21_0;
        Class27.Delegate21 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate21)Delegate.Remove(delegate2, delegate21_1);
            @delegate = Interlocked.CompareExchange(ref delegate21_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_8(Class27.Delegate22 delegate22_1) {
        var @delegate = delegate22_0;
        Class27.Delegate22 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate22)Delegate.Combine(delegate2, delegate22_1);
            @delegate = Interlocked.CompareExchange(ref delegate22_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_9(Class27.Delegate22 delegate22_1) {
        var @delegate = delegate22_0;
        Class27.Delegate22 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate22)Delegate.Remove(delegate2, delegate22_1);
            @delegate = Interlocked.CompareExchange(ref delegate22_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_10(Class27.Delegate24 delegate24_1) {
        var @delegate = delegate24_0;
        Class27.Delegate24 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate24)Delegate.Combine(delegate2, delegate24_1);
            @delegate = Interlocked.CompareExchange(ref delegate24_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_11(Class27.Delegate24 delegate24_1) {
        var @delegate = delegate24_0;
        Class27.Delegate24 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate24)Delegate.Remove(delegate2, delegate24_1);
            @delegate = Interlocked.CompareExchange(ref delegate24_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_12(Class27.Delegate23 delegate23_1) {
        var @delegate = delegate23_0;
        Class27.Delegate23 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate23)Delegate.Combine(delegate2, delegate23_1);
            @delegate = Interlocked.CompareExchange(ref delegate23_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_13(Class27.Delegate23 delegate23_1) {
        var @delegate = delegate23_0;
        Class27.Delegate23 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate23)Delegate.Remove(delegate2, delegate23_1);
            @delegate = Interlocked.CompareExchange(ref delegate23_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_14(Class27.Delegate25 delegate25_1) {
        var @delegate = delegate25_0;
        Class27.Delegate25 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate25)Delegate.Combine(delegate2, delegate25_1);
            @delegate = Interlocked.CompareExchange(ref delegate25_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    [CompilerGenerated]
    public void method_15(Class27.Delegate25 delegate25_1) {
        var @delegate = delegate25_0;
        Class27.Delegate25 delegate2;
        do {
            delegate2 = @delegate;
            var value = (Class27.Delegate25)Delegate.Remove(delegate2, delegate25_1);
            @delegate = Interlocked.CompareExchange(ref delegate25_0, value, delegate2);
        }
        while ((object)@delegate != delegate2);
    }

    public Class25() {
        vmethod_0();
    }

    ~Class25() {
        vmethod_1();
    }

    public IntPtr method_16() {
        return method_0();
    }

    protected virtual bool vmethod_0() {
        if (!bool_0 && !(intptr_1 != IntPtr.Zero) && !(method_0() != IntPtr.Zero)) {
            intptr_1 = Class43.Create_Center_TcpClientListener();
            if (intptr_1 == IntPtr.Zero) {
                return false;
            }
            method_1(Class43.Create_Center_TcpClient(intptr_1));
            if (method_0() == IntPtr.Zero) {
                return false;
            }
            bool_0 = true;
            return true;
        }
        return false;
    }

    public virtual void vmethod_1() {
        method_20();
        if (method_0() != IntPtr.Zero) {
            Class43.Destroy_Center_TcpClient(method_0());
            method_1(IntPtr.Zero);
        }
        if (intptr_1 != IntPtr.Zero) {
            Class43.Destroy_Center_TcpClientListener(intptr_1);
            intptr_1 = IntPtr.Zero;
        }
        bool_0 = false;
    }

    public bool method_17(string string_0, ushort ushort_0, bool bool_1 = true) {
        if (string.IsNullOrEmpty(string_0)) {
            throw new Exception("address is null");
        }
        if (ushort_0 == 0) {
            throw new Exception("port is zero");
        }
        if (method_43()) {
            return false;
        }
        vmethod_2();
        return Class43.Center_Client_Start(method_0(), string_0, ushort_0, bool_1);
    }

    public bool method_18(string string_0, ushort ushort_0, string string_1, bool bool_1 = true) {
        if (string.IsNullOrEmpty(string_0)) {
            throw new Exception("address is null");
        }
        if (ushort_0 == 0) {
            throw new Exception("port is zero");
        }
        if (method_43()) {
            return false;
        }
        vmethod_2();
        return Class43.Center_Client_StartWithBindAddress(method_0(), string_0, ushort_0, bool_1, string_1);
    }

    public bool method_19(string string_0, ushort ushort_0, string string_1, ushort ushort_1, bool bool_1 = true) {
        if (string.IsNullOrEmpty(string_0)) {
            throw new Exception("address is null");
        }
        if (ushort_0 == 0) {
            throw new Exception("port is zero");
        }
        if (method_43()) {
            return false;
        }
        vmethod_2();
        return Class43.Center_Client_StartWithBindAddressAndLocalPort(method_0(), string_0, ushort_0, bool_1, string_1, ushort_1);
    }

    public bool method_20() {
        if (!method_43()) {
            return false;
        }
        return Class43.Center_Client_Stop(method_0());
    }

    public bool method_21(byte[] byte_0, int int_0) {
        return Class43.Center_Client_Send(method_0(), byte_0, int_0);
    }

    public bool method_22(IntPtr intptr_2, int int_0) {
        return Class43.Center_Client_Send(method_0(), intptr_2, int_0);
    }

    public bool method_23<T>(T gparam_0) {
        byte[] array = method_70(gparam_0);
        return method_21(array, array.Length);
    }

    public bool method_24(object object_0) {
        byte[] array = method_72(object_0);
        return method_21(array, array.Length);
    }

    public bool method_25(byte[] byte_0, int int_0, int int_1) {
        return Class43.Center_Client_SendPart(method_0(), byte_0, int_1, int_0);
    }

    public bool method_26(IntPtr intptr_2, int int_0, int int_1) {
        return Class43.Center_Client_SendPart(method_0(), intptr_2, int_1, int_0);
    }

    public bool method_27(Struct38[] struct38_0, int int_0) {
        return Class43.Center_Client_SendPackets(method_0(), struct38_0, int_0);
    }



    public T method_38<T>() {
        return (T)class45_0.method_0(method_0());
    }

    public bool method_39(object object_0) {
        return class45_0.method_2(method_0(), object_0);
    }

    public bool method_40() {
        return class45_0.method_3(method_0());
    }

    public bool method_41(ref string string_0, ref ushort ushort_0) {
        int int_ = 40;
        var stringBuilder = new StringBuilder(40);
        bool num = Class43.Center_Client_GetLocalAddress(method_0(), stringBuilder, ref int_, ref ushort_0);
        if (num) {
            string_0 = stringBuilder.ToString();
        }
        return num;
    }

    public bool method_42(ref string string_0, ref ushort ushort_0) {
        int int_ = 40;
        var stringBuilder = new StringBuilder(40);
        bool num = Class43.Center_Client_GetRemoteHost(method_0(), stringBuilder, ref int_, ref ushort_0);
        if (num) {
            string_0 = stringBuilder.ToString();
        }
        return num;
    }

    public bool method_43() {
        if (method_0() == IntPtr.Zero) {
            return false;
        }
        return Class43.Center_Client_HasStarted(method_0());
    }

    public Enum5 method_44() {
        return Class43.Center_Client_GetState(method_0());
    }

    public IntPtr method_45() {
        return Class43.Center_Client_GetConnectionID(method_0());
    }

    public bool method_46() {
        return Class43.Center_Client_IsSecure(method_0());
    }

    public uint method_47() {
        return Class43.Center_Client_GetFreeBufferPoolSize(method_0());
    }

    public void method_48(uint uint_0) {
        Class43.Center_Client_SetFreeBufferPoolSize(method_0(), uint_0);
    }

    public uint method_49() {
        return Class43.Center_Client_GetFreeBufferPoolHold(method_0());
    }

    public void method_50(uint uint_0) {
        Class43.Center_Client_SetFreeBufferPoolHold(method_0(), uint_0);
    }
    public bool method_28<T>(T[] gparam_0)
    {
        //   bool flag = false;
        var array = new Struct38[gparam_0.Length];
        var array2 = new IntPtr[array.Length];
        try
        {
            for (int i = 0; i < gparam_0.Length; i++)
            {
                array[i].int_0 = Marshal.SizeOf(typeof(T));
                array2[i] = Marshal.AllocHGlobal(array[i].int_0);
                Marshal.StructureToPtr((object)gparam_0[i], array2[i], fDeleteOld: true);
                array[i].intptr_0 = array2[i];
            }
            return method_27(array, array.Length);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array2[j] != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(array2[j]);
                }
            }
        }
    }

    public bool method_29(string string_0, ref Struct38 struct38_0, ref Struct38 struct38_1)
    {
        return Class43.Center_TcpClient_SendSmallFile(method_0(), string_0, ref struct38_0, ref struct38_1);
    }

    public bool method_30(string string_0, byte[] byte_0, byte[] byte_1)
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
        return method_29(string_0, ref struct38_, ref struct38_2);
    }

    public bool method_31<T, U>(string string_0, T gparam_0, U gparam_1)
    {
        byte[] byte_ = null;
        if (gparam_0 != null)
        {
            byte_ = method_70(gparam_0);
        }
        byte[] byte_2 = null;
        if (gparam_1 != null)
        {
            byte_2 = method_70(gparam_1);
        }
        return method_30(string_0, byte_, byte_2);
    }

    public Enum6 method_32()
    {
        return Class43.Center_Client_GetLastError(method_0());
    }

    public string method_33()
    {
        return Class43.smethod_0();
    }

    public string method_34()
    {
        return Marshal.PtrToStringUni(Class43.Center_Client_GetLastErrorDesc(method_0()));
    }

    public Enum11 method_35()
    {
        int int_ = -1;
        if (Class43.Center_Client_IsPauseReceive(method_0(), ref int_))
        {
            return (Enum11)int_;
        }
        return Enum11.const_0;
    }

    public void method_36(Enum11 enum11_0)
    {
        Class43.Center_Client_PauseReceive(method_0(), (int)enum11_0);
    }

    public bool method_37(ref int int_0)
    {
        return Class43.Center_Client_GetPendingDataLength(method_0(), ref int_0);
    }
    public uint method_51() {
        return Class43.Center_TcpClient_GetSocketBufferSize(method_0());
    }

    public void method_52(uint uint_0) {
        Class43.Center_TcpClient_SetSocketBufferSize(method_0(), uint_0);
    }

    public uint method_53() {
        return Class43.Center_TcpClient_GetKeepAliveTime(method_0());
    }

    public void method_54(uint uint_0) {
        Class43.Center_TcpClient_SetKeepAliveTime(method_0(), uint_0);
    }

    public uint method_55() {
        return Class43.Center_TcpClient_GetKeepAliveInterval(method_0());
    }
    protected Enum2 method_58(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
    {
        if (delegate19_0 != null)
        {
            return delegate19_0(this, intptr_4);
        }
        return Enum2.const_1;
    }

    protected Enum2 method_59(IntPtr intptr_2, IntPtr intptr_3)
    {
        if (delegate20_0 != null)
        {
            return delegate20_0(this);
        }
        return Enum2.const_1;
    }

    protected Enum2 method_60(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, int int_0)
    {
        if (delegate21_0 != null)
        {
            byte[] array = new byte[int_0];
            Marshal.Copy(intptr_4, array, 0, int_0);
            return delegate21_0(this, array);
        }
        return Enum2.const_1;
    }

    protected Enum2 method_61(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, int int_0)
    {
        if (delegate24_0 != null)
        {
            return delegate24_0(this, intptr_4, int_0);
        }
        if (delegate22_0 != null)
        {
            byte[] array = new byte[int_0];
            Marshal.Copy(intptr_4, array, 0, int_0);
            return delegate22_0(this, array);
        }
        return Enum2.const_1;
    }

    protected Enum2 method_62(IntPtr intptr_2, IntPtr intptr_3, Enum3 enum3_0, int int_0)
    {
        if (delegate23_0 != null)
        {
            return delegate23_0(this, enum3_0, int_0);
        }
        return Enum2.const_1;
    }

    protected Enum2 method_63(IntPtr intptr_2, IntPtr intptr_3)
    {
        if (delegate25_0 != null)
        {
            return delegate25_0(this);
        }
        return Enum2.const_1;
    }

    public int method_64()
    {
        return Class43.smethod_1();
    }

    public int method_65()
    {
        return Class43.SYS_WSAGetLastError();
    }

    public int method_66(IntPtr intptr_2, int int_0, int int_1, IntPtr intptr_3, int int_2)
    {
        return Class43.SYS_SetSocketOption(intptr_2, int_0, int_1, intptr_3, int_2);
    }

    public int method_67(IntPtr intptr_2, int int_0, int int_1, IntPtr intptr_3, ref int int_2)
    {
        return Class43.SYS_GetSocketOption(intptr_2, int_0, int_1, intptr_3, ref int_2);
    }

    public int method_68(IntPtr intptr_2, long long_0, IntPtr intptr_3)
    {
        return Class43.SYS_IoctlSocket(intptr_2, long_0, intptr_3);
    }

    public int method_69(IntPtr intptr_2, uint uint_0, IntPtr intptr_3, uint uint_1, IntPtr intptr_4, uint uint_2, uint uint_3)
    {
        return Class43.SYS_WSAIoctl(intptr_2, uint_0, intptr_3, uint_1, intptr_4, uint_2, uint_3);
    }

    public byte[] method_70<T>(T gparam_0)
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

    public T method_71<T>(byte[] byte_0)
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
    public void method_56(uint uint_0) {
        Class43.Center_TcpClient_SetKeepAliveInterval(method_0(), uint_0);
    }

    public string method_57(Enum6 enum6_0) {
        return Marshal.PtrToStringUni(Class43.Center_GetSocketErrorDesc(enum6_0));
    }

    protected virtual void vmethod_2() {
        delegate32_0 = method_58;
        delegate33_0 = method_59;
        delegate26_0 = method_60;
        delegate27_0 = method_61;
        delegate29_0 = method_62;
        delegate30_0 = method_63;
        Class43.Center_Set_FN_Client_OnPrepareConnect(intptr_1, delegate32_0);
        Class43.Center_Set_FN_Client_OnConnect(intptr_1, delegate33_0);
        Class43.Center_Set_FN_Client_OnSend(intptr_1, delegate26_0);
        Class43.Center_Set_FN_Client_OnReceive(intptr_1, delegate27_0);
        Class43.Center_Set_FN_Client_OnClose(intptr_1, delegate29_0);
        Class43.Center_Set_FN_Client_OnHandShake(intptr_1, delegate30_0);
    }



    public byte[] method_72(object object_0) {
        using (var memoryStream = new MemoryStream()) {
            ((IFormatter)new BinaryFormatter()).Serialize((Stream)memoryStream, object_0);
            return memoryStream.GetBuffer();
        }
    }

    public object method_73(byte[] byte_0) {
        using (var serializationStream = new MemoryStream(byte_0)) {
            return ((IFormatter)new BinaryFormatter()).Deserialize((Stream)serializationStream);
        }
    }

    public T method_74<T>(byte[] byte_0) {
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
