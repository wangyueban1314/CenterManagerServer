using System;
using System.Runtime.InteropServices;
using System.Text;

internal class Class43 {
    public delegate Enum2 Delegate26(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

    public delegate Enum2 Delegate27(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

    public delegate Enum2 Delegate28(IntPtr intptr_0, IntPtr intptr_1, int int_0);

    public delegate Enum2 Delegate29(IntPtr intptr_0, IntPtr intptr_1, Enum3 enum3_0, int int_0);

    public delegate Enum2 Delegate30(IntPtr intptr_0, IntPtr intptr_1);

    public delegate Enum2 Delegate31(IntPtr intptr_0);

    public delegate Enum2 Delegate32(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

    public delegate Enum2 Delegate33(IntPtr intptr_0, IntPtr intptr_1);

    public delegate Enum2 Delegate34(IntPtr intptr_0, IntPtr intptr_1);

    public delegate Enum2 Delegate35(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

    public const string string_0 = "QiangweidiewuYstem.dll";

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpServer(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpClient(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpAgent(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPullServer(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPullClient(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPullAgent(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPackServer(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPackAgent(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPackClient(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_UdpServer(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_UdpClient(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_UdpCast(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpServer(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpClient(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpAgent(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPullServer(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPullClient(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPullAgent(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPackServer(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPackAgent(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPackClient(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_UdpServer(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_UdpClient(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_UdpCast(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpServerListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpClientListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpAgentListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPullServerListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPullClientListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPullAgentListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPackServerListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPackClientListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_TcpPackAgentListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_UdpServerListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_UdpClientListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Create_Center_UdpCastListener();

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpServerListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpClientListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpAgentListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPullServerListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPullClientListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPullAgentListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPackServerListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPackClientListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_TcpPackAgentListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_UdpServerListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_UdpClientListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Destroy_Center_UdpCastListener(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Server_OnPrepareListen(IntPtr intptr_0, Delegate34 delegate34_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Server_OnAccept(IntPtr intptr_0, Delegate35 delegate35_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Server_OnHandShake(IntPtr intptr_0, Delegate30 delegate30_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Server_OnSend(IntPtr intptr_0, Delegate26 delegate26_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Server_OnReceive(IntPtr intptr_0, Delegate27 delegate27_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Server_OnPullReceive(IntPtr intptr_0, Delegate28 delegate28_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Server_OnClose(IntPtr intptr_0, Delegate29 delegate29_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Server_OnShutdown(IntPtr intptr_0, Delegate31 delegate31_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Client_OnPrepareConnect(IntPtr intptr_0, Delegate32 delegate32_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Client_OnConnect(IntPtr intptr_0, Delegate33 delegate33_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Client_OnHandShake(IntPtr intptr_0, Delegate30 delegate30_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Client_OnSend(IntPtr intptr_0, Delegate26 delegate26_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Client_OnReceive(IntPtr intptr_0, Delegate27 delegate27_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Client_OnPullReceive(IntPtr intptr_0, Delegate28 delegate28_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Client_OnClose(IntPtr intptr_0, Delegate29 delegate29_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Agent_OnPrepareConnect(IntPtr intptr_0, Delegate32 delegate32_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Agent_OnConnect(IntPtr intptr_0, Delegate33 delegate33_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Agent_OnHandShake(IntPtr intptr_0, Delegate30 delegate30_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Agent_OnSend(IntPtr intptr_0, Delegate26 delegate26_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Agent_OnReceive(IntPtr intptr_0, Delegate27 delegate27_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Agent_OnPullReceive(IntPtr intptr_0, Delegate28 delegate28_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Agent_OnClose(IntPtr intptr_0, Delegate29 delegate29_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Set_FN_Agent_OnShutdown(IntPtr intptr_0, Delegate31 delegate31_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode)]
    public static extern bool Center_Server_Start(IntPtr intptr_0, string string_1, ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_Stop(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern bool Center_Server_Send(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Server_Send(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern bool Center_Server_SendPart(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, int int_1);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Server_SendPart(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Server_SendPackets(IntPtr intptr_0, IntPtr intptr_1, Struct38[] struct38_0, int int_0);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Server_PauseReceive(IntPtr intptr_0, IntPtr intptr_1, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_Disconnect(IntPtr intptr_0, IntPtr intptr_1, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_DisconnectLongConnections(IntPtr intptr_0, uint uint_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_DisconnectSilenceConnections(IntPtr intptr_0, uint uint_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Server_SetSendPolicy(IntPtr intptr_0, Enum4 enum4_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum4 Center_Server_GetSendPolicy(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_SetConnectionExtra(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_GetConnectionExtra(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_IsSecure(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_HasStarted(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum5 Center_Server_GetState(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum6 Center_Server_GetLastError(IntPtr intptr_0);
    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum7 Center_Server_GetOnSendSyncPolicy(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Server_SetFreeSocketObjLockTime(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Server_SetFreeSocketObjPool(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Server_SetFreeBufferObjPool(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Server_SetFreeSocketObjHold(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Server_SetFreeBufferObjHold(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Server_SetMaxConnectionCount(IntPtr intptr_0, uint uint_0);
    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Center_Server_GetLastErrorDesc(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_GetPendingDataLength(IntPtr intptr_0, IntPtr intptr_1, ref int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_IsPauseReceive(IntPtr intptr_0, IntPtr intptr_1, ref int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_IsConnected(IntPtr intptr_0, IntPtr intptr_1);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Server_GetConnectionCount(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_GetAllConnectionIDs(IntPtr intptr_0, IntPtr[] intptr_1, ref uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_GetConnectPeriod(IntPtr intptr_0, IntPtr intptr_1, ref uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_GetSilencePeriod(IntPtr intptr_0, IntPtr intptr_1, ref uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_GetListenAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_GetLocalAddress(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_GetRemoteAddress(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Server_SetOnSendSyncPolicy(IntPtr intptr_0, Enum7 enum7_0);



    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Server_SetWorkerThreadCount(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Server_SetMarkSilence(IntPtr intptr_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Server_GetFreeSocketObjLockTime(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Server_GetFreeSocketObjPool(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Server_GetFreeBufferObjPool(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Server_GetFreeSocketObjHold(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Server_GetFreeBufferObjHold(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Server_GetMaxConnectionCount(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Server_GetWorkerThreadCount(IntPtr intptr_0);
    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum8 Center_UdpCast_GetCastMode(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpCast_SetMultiCastTtl(IntPtr intptr_0, int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern int Center_UdpCast_GetMultiCastTtl(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpCast_SetMultiCastLoop(IntPtr intptr_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_UdpCast_IsMultiCastLoop(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode)]
    public static extern bool Center_Agent_Start(IntPtr intptr_0, string string_1, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_Stop(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool Center_Agent_Connect(IntPtr intptr_0, string string_1, ushort ushort_0, ref IntPtr intptr_1);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool Center_Agent_ConnectWithExtra(IntPtr intptr_0, string string_1, ushort ushort_0, ref IntPtr intptr_1, IntPtr intptr_2);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool Center_Agent_ConnectWithLocalPort(IntPtr intptr_0, string string_1, ushort ushort_0, ref IntPtr intptr_1, ushort ushort_1);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool Center_Agent_ConnectWithExtraAndLocalPort(IntPtr intptr_0, string string_1, ushort ushort_0, ref IntPtr intptr_1, IntPtr intptr_2, ushort ushort_1);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern bool Center_Agent_Send(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Agent_Send(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Agent_SendPart(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, int int_1);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Agent_SendPart(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Agent_SendPackets(IntPtr intptr_0, IntPtr intptr_1, Struct38[] struct38_0, int int_0);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Agent_PauseReceive(IntPtr intptr_0, IntPtr intptr_1, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_Disconnect(IntPtr intptr_0, IntPtr intptr_1, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_DisconnectLongConnections(IntPtr intptr_0, uint uint_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_DisconnectSilenceConnections(IntPtr intptr_0, uint uint_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool Center_TcpAgent_SendSmallFile(IntPtr intptr_0, IntPtr intptr_1, string string_1, ref Struct38 struct38_0, ref Struct38 struct38_1);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Agent_SetSendPolicy(IntPtr intptr_0, Enum4 enum4_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum4 Center_Agent_GetSendPolicy(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum7 Center_Agent_GetOnSendSyncPolicy(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Agent_SetOnSendSyncPolicy(IntPtr intptr_0, Enum7 enum7_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_SetConnectionExtra(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_GetConnectionExtra(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_IsSecure(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_HasStarted(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum5 Center_Agent_GetState(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Agent_GetConnectionCount(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_GetAllConnectionIDs(IntPtr intptr_0, IntPtr[] intptr_1, ref uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_GetConnectPeriod(IntPtr intptr_0, IntPtr intptr_1, ref uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_GetSilencePeriod(IntPtr intptr_0, IntPtr intptr_1, ref uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_GetLocalAddress(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_GetRemoteAddress(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_GetRemoteHost(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum6 Center_Agent_GetLastError(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Center_Agent_GetLastErrorDesc(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_GetPendingDataLength(IntPtr intptr_0, IntPtr intptr_1, ref int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_IsPauseReceive(IntPtr intptr_0, IntPtr intptr_1, ref int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_IsConnected(IntPtr intptr_0, IntPtr intptr_1);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Agent_SetFreeSocketObjLockTime(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Agent_SetFreeSocketObjPool(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Agent_SetFreeBufferObjPool(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Agent_SetFreeSocketObjHold(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Agent_SetFreeBufferObjHold(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Agent_SetMaxConnectionCount(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Agent_SetWorkerThreadCount(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Agent_SetMarkSilence(IntPtr intptr_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Agent_GetFreeSocketObjLockTime(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Agent_GetFreeSocketObjPool(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Agent_GetFreeBufferObjPool(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Agent_GetFreeSocketObjHold(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Agent_GetFreeBufferObjHold(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Agent_GetMaxConnectionCount(IntPtr intptr_0);
    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Server_IsMarkSilence(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool Center_TcpServer_SendSmallFile(IntPtr intptr_0, IntPtr intptr_1, string string_1, ref Struct38 struct38_0, ref Struct38 struct38_1);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpServer_SetAcceptSocketCount(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpServer_SetSocketBufferSize(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpServer_SetSocketListenQueue(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpServer_SetKeepAliveTime(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpServer_SetKeepAliveInterval(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpServer_GetAcceptSocketCount(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpServer_GetSocketBufferSize(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpServer_GetSocketListenQueue(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpServer_GetKeepAliveTime(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpServer_GetKeepAliveInterval(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpServer_SetMaxDatagramSize(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_UdpServer_GetMaxDatagramSize(IntPtr intptr_0);
    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode)]
    public static extern bool Center_Client_StartWithBindAddressAndLocalPort(IntPtr intptr_0, string string_1, ushort ushort_0, bool bool_0, string string_2, ushort ushort_1);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Client_Stop(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern bool Center_Client_Send(IntPtr intptr_0, byte[] byte_0, int int_0);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Client_Send(IntPtr intptr_0, IntPtr intptr_1, int int_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern bool Center_Client_SendPart(IntPtr intptr_0, byte[] byte_0, int int_0, int int_1);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Client_SendPart(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1);
    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpServer_SetPostReceiveCount(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_UdpServer_GetPostReceiveCount(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpServer_SetDetectAttempts(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpServer_SetDetectInterval(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_UdpServer_GetDetectAttempts(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_UdpServer_GetDetectInterval(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode)]
    public static extern bool Center_Client_Start(IntPtr intptr_0, string string_1, ushort ushort_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode)]
    public static extern bool Center_Client_StartWithBindAddress(IntPtr intptr_0, string string_1, ushort ushort_0, bool bool_0, string string_2);



    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Client_SendPackets(IntPtr intptr_0, Struct38[] struct38_0, int int_0);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern bool Center_Client_PauseReceive(IntPtr intptr_0, int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Client_SetExtra(IntPtr intptr_0, IntPtr intptr_1);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Center_Client_GetExtra(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Client_IsSecure(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Client_HasStarted(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum5 Center_Client_GetState(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum6 Center_Client_GetLastError(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Center_Client_GetLastErrorDesc(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Center_Client_GetConnectionID(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Client_GetLocalAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Client_GetRemoteHost(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Client_GetPendingDataLength(IntPtr intptr_0, ref int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Client_IsPauseReceive(IntPtr intptr_0, ref int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Client_IsConnected(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Client_SetFreeBufferPoolSize(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_Client_SetFreeBufferPoolHold(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Client_GetFreeBufferPoolSize(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Client_GetFreeBufferPoolHold(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool Center_TcpClient_SendSmallFile(IntPtr intptr_0, string string_1, ref Struct38 struct38_0, ref Struct38 struct38_1);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpClient_SetSocketBufferSize(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpClient_SetKeepAliveTime(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpClient_SetKeepAliveInterval(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpClient_GetSocketBufferSize(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpClient_GetKeepAliveTime(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpClient_GetKeepAliveInterval(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpClient_SetMaxDatagramSize(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_UdpClient_GetMaxDatagramSize(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpClient_SetDetectAttempts(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpClient_SetDetectInterval(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_UdpClient_GetDetectAttempts(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_UdpClient_GetDetectInterval(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpCast_SetMaxDatagramSize(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_UdpCast_GetMaxDatagramSize(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_UdpCast_GetRemoteAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, ref ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpCast_SetReuseAddress(IntPtr intptr_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_UdpCast_IsReuseAddress(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_UdpCast_SetCastMode(IntPtr intptr_0, Enum8 enum8_0);

 

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_Agent_GetWorkerThreadCount(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_Agent_IsMarkSilence(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpAgent_SetReuseAddress(IntPtr intptr_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool Center_TcpAgent_IsReuseAddress(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpAgent_SetSocketBufferSize(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpAgent_SetKeepAliveTime(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpAgent_SetKeepAliveInterval(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpAgent_GetSocketBufferSize(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpAgent_GetKeepAliveTime(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpAgent_GetKeepAliveInterval(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum9 Center_TcpPullServer_Fetch(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum9 Center_TcpPullServer_Peek(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum9 Center_TcpPullClient_Fetch(IntPtr intptr_0, IntPtr intptr_1, int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum9 Center_TcpPullClient_Peek(IntPtr intptr_0, IntPtr intptr_1, int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum9 Center_TcpPullAgent_Fetch(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern Enum9 Center_TcpPullAgent_Peek(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpPackServer_SetMaxPackSize(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpPackServer_SetPackHeaderFlag(IntPtr intptr_0, ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpPackServer_GetMaxPackSize(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern ushort Center_TcpPackServer_GetPackHeaderFlag(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpPackAgent_SetMaxPackSize(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpPackAgent_SetPackHeaderFlag(IntPtr intptr_0, ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpPackAgent_GetMaxPackSize(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern ushort Center_TcpPackAgent_GetPackHeaderFlag(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpPackClient_SetMaxPackSize(IntPtr intptr_0, uint uint_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void Center_TcpPackClient_SetPackHeaderFlag(IntPtr intptr_0, ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_TcpPackClient_GetMaxPackSize(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern ushort Center_TcpPackClient_GetPackHeaderFlag(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern uint Center_GetHPSocketVersion();

    public static string smethod_0() {
        uint num = Center_GetHPSocketVersion();
        uint num2 = num >> 24;
        uint num3 = num << 8 >> 24;
        uint num4 = num << 16 >> 24;
        uint num5 = num << 24 >> 24;
        return $"{num2}.{num3}.{num4}_{num5}";
    }

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr Center_GetSocketErrorDesc(Enum6 enum6_0);

    public static int smethod_1() {
        return Marshal.GetLastWin32Error();
    }

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern int SYS_WSAGetLastError();

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern int SYS_SetSocketOption(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1, int int_2);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern int SYS_GetSocketOption(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1, ref int int_2);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern int SYS_IoctlSocket(IntPtr intptr_0, long long_0, IntPtr intptr_1);

    [DllImport("QiangweidiewuYstem.dll", SetLastError = true)]
    public static extern int SYS_WSAIoctl(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, uint uint_1, IntPtr intptr_2, uint uint_2, uint uint_3);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern int SYS_SSO_NoDelay(IntPtr intptr_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern int SYS_SSO_DontLinger(IntPtr intptr_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern int SYS_SSO_Linger(IntPtr intptr_0, ushort ushort_0, ushort ushort_1);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern int SYS_SSO_RecvBuffSize(IntPtr intptr_0, int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern int SYS_SSO_SendBuffSize(IntPtr intptr_0, int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern int SYS_SSO_ReuseAddress(IntPtr intptr_0, bool bool_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool SYS_GetSocketLocalAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool SYS_GetSocketRemoteAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref ushort ushort_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode)]
    public static extern bool SYS_EnumHostIPAddresses(string string_1, Enum10 enum10_0, ref IntPtr intptr_0, ref int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern bool SYS_FreeHostIPAddresses(IntPtr intptr_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode)]
    public static extern bool SYS_IsIPAddress(string string_1, ref Enum10 enum10_0);

    [DllImport("QiangweidiewuYstem.dll", CharSet = CharSet.Unicode)]
    public static extern bool SYS_GetIPAddress(string string_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, ref int int_0, ref Enum10 enum10_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern ulong SYS_NToH64(ulong ulong_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern ulong SYS_HToN64(ulong ulong_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr SYS_Malloc(int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern IntPtr SYS_Realloc(IntPtr intptr_0, int int_0);

    [DllImport("QiangweidiewuYstem.dll")]
    public static extern void SYS_Free(IntPtr intptr_0);
}
