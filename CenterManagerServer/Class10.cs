using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Timers;

internal class Class10 {
    private delegate void Delegate36(int int_0, object object_0);

    private static System.Timers.Timer timer_0;

    private static List<Struct37> list_0;

    private static int int_0;

    static Class10() {
        timer_0 = new System.Timers.Timer();
        list_0 = new List<Struct37>();
        int_0 = 0;
        timer_0.Interval = Class15.Center_Get_Task_Length();
        timer_0.Elapsed += smethod_0;
        timer_0.Start();
    }

    private static void smethod_0(object sender, ElapsedEventArgs e) {
        try {
            if (Interlocked.Exchange(ref int_0, 1) == 0) {
                smethod_1();
                Interlocked.Exchange(ref int_0, 0);
            }
        }
        catch {
            list_0.Clear();
        }
    }

    private static void smethod_1() {
        if (list_0 == null || list_0.Count <= 0) {
            return;
        }
        for (int num = list_0.Count - 1; num >= 0; num--) {
            if (list_0[num].int_2 == 1) {
                list_0.Remove(list_0[num]);
            }
        }
        int num2 = 0;
        while (true) {
            if (num2 < list_0.Count) {
                if (list_0[num2].int_2 == 0 && Class9.smethod_0() >= list_0[num2].int_1) {
                    break;
                }
                num2++;
                continue;
            }
            return;
        }
        smethod_3(list_0[num2].int_0, list_0[num2].object_0);
        var value = list_0[num2];
        value.int_2 = 1;
        list_0[num2] = value;
    }

    public static void smethod_2(int int_1, object object_0, int int_2) {
        var item = default(Struct37);
        item.int_2 = 0;
        item.int_0 = int_1;
        item.object_0 = object_0;
        item.int_1 = Class9.smethod_0() + int_2;
        list_0.Add(item);
    }
    private static void smethod_4(IAsyncResult iasyncResult_0)
    {
        _ = (Delegate36)((AsyncResult)iasyncResult_0).AsyncDelegate;
    }

    private static void smethod_5(int int_1, object object_0)
    {
        try
        {
            switch (int_1)
            {
                case 1:
                    {
                        var struct10 = (Struct10)object_0;
                        int num9 = 0;
                        if (Class8.bool_3)
                        {
                            num9 = Class9.smethod_34(struct10.intptr_0, struct10.string_3, struct10.string_4, struct10.string_5, struct10.uint_0);
                            if (num9 != 1)
                            {
                                Class6.smethod_0(2, "SQL Error: Send_MonsterKillReward False", 0);
                                Class7.smethod_2(struct10.string_1, "SQL Error: Send_MonsterKillReward Code:" + num9 + " Param:" + struct10.string_3 + " " + struct10.string_4 + " " + struct10.string_5 + " " + struct10.uint_0);
                            }
                        }
                        num9 = Class5.smethod_26(struct10.string_4, struct10.string_0, struct10.string_2, (int)struct10.uint_0, out var string_3);
                        if (num9 < 1)
                        {
                            Class6.smethod_0(2, "SQL Error: SQL_Center_System_Event_Char_Kill_Rare_Monster False", 0);
                            Class7.smethod_2(struct10.string_1, "SQL Error: SQL_Center_System_Event_Char_Kill_Rare_Monster Code:" + num9 + " Param:" + struct10.string_4 + " " + struct10.string_2);
                        }
                        else
                        {
                            if (string_3 != "NULL" && !Class9.smethod_27(struct10.intptr_0, string_3))
                            {
                                Class7.smethod_2(struct10.string_1, "System Error A: 11002");
                            }
                            if (num9 == 2)
                            {
                                Class12.class3_0.list_1.Add(new Struct4(struct10.intptr_0, Class9.smethod_0(), 300));
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        var struct14 = (Struct11)object_0;
                        int num15 = 0;
                        if (Class8.bool_4)
                        {
                            num15 = Class9.smethod_30(struct14.intptr_0, struct14.string_3, struct14.string_4, struct14.uint_0, struct14.byte_0, struct14.byte_1);
                            if (num15 != 1)
                            {
                                Class6.smethod_0(2, "SQL Error: Send_AlchemyReward False", 0);
                                Class7.smethod_2(struct14.string_1, "SQL Error: Send_AlchemyReward Code:" + num15 + " Param:" + struct14.string_3 + " " + struct14.string_4 + " " + struct14.uint_0 + " " + struct14.byte_0 + " " + struct14.byte_1);
                            }
                        }
                        num15 = Class5.smethod_27(struct14.string_4, struct14.string_0, struct14.string_2, (int)struct14.uint_0, struct14.byte_0, struct14.byte_1, out var string_4);
                        if (num15 < 1)
                        {
                            Class6.smethod_0(2, "SQL Error: SQL_Center_System_Event_Char_Alchemy_Success False", 0);
                            Class7.smethod_2(struct14.string_1, "SQL Error: SQL_Center_System_Event_Char_Alchemy_Success Code:" + num15 + " Param:" + struct14.string_4 + " " + struct14.string_2);
                            break;
                        }
                        if (string_4 != "NULL")
                        {
                            if (string_4.Substring(0, 5) == "@ALL_")
                            {
                                string_4 = string_4.Remove(0, 5);
                                Class12.class3_0.method_21(string_4);
                            }
                            else if (!Class9.smethod_27(struct14.intptr_0, string_4))
                            {
                                Class7.smethod_2(struct14.string_1, "System Error A: 11003");
                            }
                        }
                        if (num15 == 2)
                        {
                            Class12.class3_0.list_1.Add(new Struct4(struct14.intptr_0, Class9.smethod_0(), 300));
                        }
                        break;
                    }
                case 3:
                    {
                        var struct15 = (Struct12)object_0;
                        if (Class5.smethod_76(struct15.string_2) != Class8.byte_2)
                        {
                            break;
                        }
                        try
                        {
                            int num17 = Class9.smethod_35(struct15.intptr_0, struct15.string_1, struct15.string_2, struct15.byte_0);
                            if (num17 != 1)
                            {
                                Class6.smethod_0(2, "SQL Error: Send_MaxLevelReward False", 0);
                                Class7.smethod_2(struct15.string_0, "SQL Error: Send_MaxLevelReward Code:" + num17 + " Param:" + struct15.string_1 + " " + struct15.string_2 + " " + struct15.byte_0);
                            }
                        }
                        catch
                        {
                            Class6.smethod_0(2, "SQL Error: Send_MaxLevelReward False", 0);
                            Class7.smethod_2(struct15.string_0, "SQL Error:Send_MaxLevelReward 0010");
                        }
                        if (!Class8.bool_20)
                        {
                            break;
                        }
                        try
                        {
                            int num18 = 0;
                            num18 = Class5.smethod_69(Class8.byte_2);
                            if (num18 < 0)
                            {
                                Class6.smethod_0(2, "SQL Error: SQL_Get_Char_Count False", 0);
                                Class7.smethod_2(struct15.string_0, "SQL Error: SQL_Get_Char_Count Code:" + num18 + " Param:" + struct15.string_1 + " " + struct15.string_2);
                            }
                            else
                            {
                                Class9.smethod_27(struct15.intptr_0, Class8.string_36[0] + num18 + Class8.string_36[1]);
                            }
                        }
                        catch
                        {
                            Class6.smethod_0(2, "SQL Error: Char_Count_Info False", 0);
                            Class7.smethod_2(struct15.string_0, "SQL Error:SQL_Get_Char_Count 0010");
                        }
                        break;
                    }
                case 4:
                    {
                        var struct5 = (Struct14)object_0;
                        if (struct5.int_0 <= 0)
                        {
                            break;
                        }
                        int num3 = Class5.smethod_117(struct5.string_2, struct5.int_0);
                        if (num3 != 1)
                        {
                            Class6.smethod_0(2, "SQL Error: SQL_Add_CharShopSilk False", 0);
                            Class7.smethod_2(struct5.string_0, "SQL Error: SQL_Add_CharShopSilk Code:" + num3 + " Param:" + struct5.string_2 + " " + struct5.int_0);
                        }
                        if (!Class8.bool_22)
                        {
                            break;
                        }
                        int num4 = 0;
                        num3 = Class5.smethod_66(struct5.string_2);
                        if (num3 < 1)
                        {
                            Class6.smethod_0(2, "SQL Error: SQL_Get_CharShopSilk False", 0);
                            Class7.smethod_2(struct5.string_0, "SQL Error: SQL_Get_CharShopSilk Code:" + num3 + " Param:" + struct5.string_2);
                            break;
                        }
                        num4 = num3;
                        num3 = Class9.smethod_36(struct5.intptr_0, struct5.string_1, struct5.string_2, num4);
                        if (num3 != 1)
                        {
                            Class6.smethod_0(2, "SQL Error: Send_ShopSilkReward False", 0);
                            Class7.smethod_2(struct5.string_0, "SQL Error: Send_ShopSilkReward Code:" + num3 + " Param:" + struct5.string_2 + " " + struct5.int_0);
                        }
                        break;
                    }
                case 5:
                    {
                        var struct6 = (Struct19)object_0;
                        int num5 = Class5.smethod_71(struct6.string_1, struct6.string_2, struct6.string_3);
                        if (num5 != 1)
                        {
                            Class6.smethod_0(2, "SQL Error: SQL_Add_LogCharChat False", 0);
                            Class7.smethod_2(struct6.string_0, "SQL Error: SQL_Add_LogCharChat Code:" + num5 + " Param:" + struct6.string_1 + " " + struct6.string_2);
                        }
                        break;
                    }
                case 6:
                    {
                        var struct11 = (Struct18)object_0;
                        int num10 = Class5.smethod_88(struct11.string_2, struct11.string_3, struct11.string_1, struct11.string_4);
                        if (num10 < 1)
                        {
                            Class6.smethod_0(2, "SQL Error: SQL_Add_LogCharLogin False", 0);
                            Class7.smethod_2(struct11.string_0, "SQL Error: SQL_Add_LogCharLogin Code:" + num10 + " Param:" + struct11.string_2 + " " + struct11.string_3 + " " + struct11.string_1);
                        }
                        num10 = Class5.smethod_4(struct11.string_2, struct11.string_3, struct11.string_1, struct11.int_0, struct11.string_4);
                        if (num10 < 1)
                        {
                            Class6.smethod_0(2, "SQL Error: SQL_Add_CharOnlineInfo False", 0);
                            Class7.smethod_2(struct11.string_0, "SQL Error: SQL_Add_CharOnlineInfo Code:" + num10 + " Param:" + struct11.string_2 + " " + struct11.string_3 + " " + struct11.string_1);
                        }
                        break;
                    }
                case 7:
                    {
                        var struct12 = (Struct20)object_0;
                        if (struct12.int_0 > 0)
                        {
                            int num11 = Class5.smethod_93(struct12.string_2, struct12.int_0);
                            if (num11 != 1)
                            {
                                Class6.smethod_0(2, "SQL Error: SQL_Add_CharTeamRegister False", 0);
                                Class7.smethod_2(struct12.string_0, "SQL Error: SQL_Add_CharTeamRegister Code:" + num11 + " Param:" + struct12.string_2 + " " + struct12.int_0);
                            }
                        }
                        int num12 = Class5.smethod_78(struct12.string_2, Class8.int_1);
                        if (num12 >= Class8.int_1)
                        {
                            int num13 = Class8.int_2 * (num12 / Class8.int_1);
                            int num14 = Class9.smethod_31(struct12.intptr_0, struct12.string_1, struct12.string_2, num13);
                            if (num14 != 1)
                            {
                                Class6.smethod_0(2, "SQL Error: Send_TeamRegisterReward False", 0);
                                Class7.smethod_2(struct12.string_0, "SQL Error: Send_TeamRegisterReward Code:" + num14 + " " + num12 + " Param:" + struct12.string_1 + " " + struct12.string_2 + " " + num13);
                            }
                        }
                        else if (num12 < 0)
                        {
                            Class6.smethod_0(2, "SQL Error: SQL_Get_CharTeamRegisterTime False", 0);
                            Class7.smethod_2(struct12.string_0, "SQL Error: SQL_Get_CharTeamRegisterTime Code:" + num12 + " Param:" + struct12.string_2);
                        }
                        break;
                    }
                case 8:
                    {
                        var struct8 = (Struct21)object_0;
                        int num7 = Class9.smethod_32(struct8.intptr_0, struct8.string_2, struct8.string_3, struct8.int_0, struct8.string_1, struct8.string_0, struct8.string_4, struct8.int_1, Class8.byte_0, Class8.short_0, Class8.int_3, Class8.int_4);
                        if (num7 != 1)
                        {
                            Class6.smethod_0(2, "SQL Error: SellRegister_Reward_Send False", 0);
                            Class7.smethod_2(struct8.string_0, "SQL Error: SellRegister_Reward_Send Code:" + num7 + " Param:" + struct8.string_2 + " " + struct8.string_3);
                        }
                        break;
                    }
                case 9:
                    {
                        var struct16 = (Struct17)object_0;
                        if (struct16.string_0 != "")
                        {
                            Class7.smethod_3(struct16.string_0 + ".Log", struct16.string_1);
                        }
                        else
                        {
                        }
                        break;
                    }
                case 10:
                    {
                        int num16 = Class9.smethod_29((string)object_0);
                        if (num16 < 0)
                        {
                            Class6.smethod_0(2, "SQL Error: Send_SiegFortressReward False", 0);
                            Class7.smethod_2("0.0.0.0:0", "SQL Error: Send_SiegFortressReward Code:" + num16);
                        }
                        break;
                    }
                case 11:
                    {
                        var struct13 = (Struct8)object_0;
                        bool flag;
                        if (!(flag = Class5.smethod_118(struct13.string_1, struct13.string_0)))
                        {
                            Class6.smethod_0(2, "SQL Error: SQL_Add_GameLoginFunction False", 0);
                            Class7.smethod_2("0.0.0.0:0", "SQL Error: SQL_Add_GameLoginFunction " + struct13.string_1 + " Code:" + flag);
                        }
                        break;
                    }
                case 12:
                    {
                        var struct9 = (Struct16)object_0;
                        if (Class5.smethod_11(struct9.string_1, out int num8, out int int_4))
                        {
                            if (int_4 > 0)
                            {
                                Class9.smethod_17(struct9.intptr_0, num8, int_4);
                            }
                        }
                        else
                        {
                            Class6.smethod_0(2, "SQL Error: SQL_Get_Char_Hornor_Point#335 False", 0);
                            Class7.smethod_2(struct9.string_0, "SQL Error: SQL_Get_Char_Hornor_Point#335 Code:" + struct9.string_1 + " Param:" + int_4);
                        }
                        break;
                    }
                case 13:
                    {
                        var struct7 = (Struct32)object_0;
                        int num6 = Class5.smethod_5(struct7.string_1, struct7.string_2);
                        if (num6 < 1)
                        {
                            Class6.smethod_0(2, "SQL Error: SQL_Del_CharOnlineInfo False", 0);
                            Class7.smethod_2(struct7.string_0, "SQL Error: SQL_Del_CharOnlineInfo Code:" + num6 + " Param:" + struct7.string_1 + " " + struct7.string_2);
                        }
                        break;
                    }
                case 15:
                    {
                        var struct4 = (Struct15)object_0;
                        int num2 = Class5.smethod_22(struct4.string_1, out int num, out int int_2, out int int_3);
                        if (num2 == 1)
                        {
                            Class9.smethod_22(struct4.intptr_0, num, int_2, int_3);
                            break;
                        }
                        Class6.smethod_0(2, "SQL Error: SQL_Get_User_Silk_Info False", 0);
                        Class7.smethod_2(struct4.string_0, "SQL Error: SQL_Get_User_Silk_Info R Code:" + num2 + " Param:" + struct4.string_1);
                        break;
                    }
                case 16:
                    {
                        string string_2 = (string)object_0;
                        Class12.class3_0.method_20(string_2);
                        break;
                    }
                case 17:
                    {
                        string string_ = (string)object_0;
                        Class12.class3_0.method_20(string_);
                        break;
                    }
                case 18:
                    {
                        var struct3 = (Struct31)object_0;
                        Class12.class3_0.method_12(struct3.int_0, struct3.int_1, struct3.string_0);
                        break;
                    }
                case 19:
                    Class12.class3_0.method_13();
                    break;
                case 20:
                    {
                        var struct2 = (Struct9)object_0;
                        Class9.smethod_28(struct2.intptr_0, struct2.int_0, struct2.byte_0);
                        break;
                    }
                case 21:
                    {
                        var @struct = (Struct35)object_0;
                        Class7.smethod_1(@struct.string_0, @struct.string_1);
                        break;
                    }
            }
        }
        catch
        {
            Class7.smethod_2("0.0.0.0:0", "Start_Task Error: " + int_1);
        }
    }
    public static void smethod_3(int int_1, object object_0) {
        new Delegate36(smethod_5).BeginInvoke(int_1, object_0, smethod_4, null);
    }


}
