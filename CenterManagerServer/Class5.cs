using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

internal class Class5 {
    public static List<Struct39> list_0 = new List<Struct39>();

    public static List<Struct40> list_1 = new List<Struct40>();

    public static List<Struct41> list_2 = new List<Struct41>();

    public static List<Struct42> list_3 = new List<Struct42>();

    public static List<Struct43> list_4 = new List<Struct43>();

    public static List<Struct33> list_5 = new List<Struct33>();

    public static List<Struct44> list_6 = new List<Struct44>();

    public static List<Struct45> list_7 = new List<Struct45>();

    public static List<Struct46> list_8 = new List<Struct46>();

    public static List<Struct7> list_9 = new List<Struct7>();

    public static List<Struct34> list_10 = new List<Struct34>();

    public static List<Struct30> list_11 = new List<Struct30>();

    public static List<Struct28> list_12 = new List<Struct28>();

    public static List<Struct13> list_13 = new List<Struct13>();

    public static List<Struct47> smethod_0() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _CharLevelMaxRanking ORDER BY Rank", sqlConnection).ExecuteReader();
            var list = new List<Struct47>();
            while (sqlDataReader.Read()) {
                string string_ = sqlDataReader.GetDateTime(0).ToString();
                int @int = sqlDataReader.GetInt32(1);
                string @string = sqlDataReader.GetString(2);
                byte @byte = sqlDataReader.GetByte(3);
                int int2 = sqlDataReader.GetInt32(4);
                int int3 = sqlDataReader.GetInt32(5);
                var item = default(Struct47);
                item.string_0 = string_;
                item.int_0 = @int;
                item.string_1 = @string;
                item.byte_0 = @byte;
                item.int_1 = int2;
                item.int_2 = int3;
                list.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return list;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_CharLevelMaxRanking", ex.ToString());
            return null;
        }
    }

    public static List<Struct48> smethod_1() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _CharShopSilkRanking ORDER BY Rank", sqlConnection).ExecuteReader();
            var list = new List<Struct48>();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                string @string = sqlDataReader.GetString(1);
                int int2 = sqlDataReader.GetInt32(2);
                int int3 = sqlDataReader.GetInt32(3);
                var item = default(Struct48);
                item.int_0 = @int;
                item.string_0 = @string;
                item.int_1 = int2;
                item.int_2 = int3;
                list.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return list;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_CharShopSilkRanking", ex.ToString());
            return null;
        }
    }

    public static List<Struct49> smethod_2(out int int_0) {
        int_0 = 0;
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("\r\n            USE [" + Class8.string_5 + "]\r\n            EXEC _TRAINING_CAMP_UPDATEHONORRANK\r\n            SELECT Ranking,tchr.Rank,Tcm.CharName,Tcm.CharCurLevel,Tcm.CharMaxLevel,tc.GraduateCount,gu.Name\r\n            FROM " + Class8.string_5 + ".dbo._TrainingCampHonorRank AS Tchr \r\n            JOIN " + Class8.string_5 + ".dbo._TrainingCampMember AS Tcm\r\n            ON Tchr.CampID = Tcm.CampID\r\n            JOIN " + Class8.string_5 + ".dbo._TrainingCamp as tc\r\n            on  Tcm.CampID = tc.ID\r\n            JOIN " + Class8.string_5 + ".dbo._Char as ch\r\n            on tcm.CharID = ch.CharID\r\n            JOIN " + Class8.string_5 + ".dbo._Guild as gu \r\n            on ch.GuildID = gu.ID\r\n            WHERE Tcm.MemberClass = 0 order by Ranking\r\n            ", sqlConnection).ExecuteReader();
            var list = new List<Struct49>();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                byte @byte = sqlDataReader.GetByte(1);
                string @string = sqlDataReader.GetString(2);
                byte byte2 = sqlDataReader.GetByte(3);
                byte byte3 = sqlDataReader.GetByte(4);
                int int2 = sqlDataReader.GetInt32(5);
                string text = sqlDataReader.GetString(6);
                if (text.ToLower() == "Dummy".ToLower()) {
                    text = "";
                }
                var item = default(Struct49);
                item.int_0 = @int;
                item.byte_0 = @byte;
                item.string_0 = @string;
                item.byte_1 = byte2;
                item.byte_2 = byte3;
                item.int_1 = int2;
                item.string_1 = text;
                list.Add(item);
                int_0++;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return list;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_TrainingCampList", ex.ToString());
            return null;
        }
    }

    public static int smethod_86(string string_0, string string_1, int int_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_AddCharLogin", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@LoginDay", SqlDbType.Int);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@CharName"].Value = string_1;
            sqlCommand.Parameters["@LoginDay"].Value = int_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_CharLogin", string_0, string_1, int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static bool smethod_87(string string_0, string string_1)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("select top 1 * from _LogCharLogin where UserID = '" + string_0 + "' and CharName='" + string_1 + "'", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read())
            {
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Exist_LogCharLogin", string_0, string_1, ex.ToString());
            return false;
        }
    }

    public static int smethod_88(string string_0, string string_1, string string_2, string string_3)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [dbo].[_LogCharLogin] ([Time], [UserID], [CharName], [LoginIP], [LoginPCInfo]) VALUES (GETDATE(), '" + string_0 + "', '" + string_1 + "', '" + string_2 + "', '" + string_3 + "');", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1)
            {
                return -200;
            }
            return 1;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_LogCharLogin", string_0, string_1, string_2, string_3, ex.ToString());
            return -100;
        }
    }

    public static bool smethod_89(string string_0, string string_1, out DateTime dateTime_0, out int int_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = (Class8.bool_50 ? new SqlCommand("SELECT TOP 1 LoginTime,LoginDay FROM [dbo].[_CharLogin] WHERE UserID = '" + string_0 + "' ORDER BY LoginTime DESC", sqlConnection) : new SqlCommand("SELECT TOP 1 LoginTime,LoginDay FROM [dbo].[_CharLogin] WHERE UserID = '" + string_0 + "' and CharName = '" + string_1 + "' ORDER BY LoginTime DESC", sqlConnection));
            var sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                int_0 = sqlDataReader.GetInt32(1);
                dateTime_0 = sqlDataReader.GetDateTime(0);
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            int_0 = 0;
            dateTime_0 = DateTime.Now.AddDays(-1.0);
            sqlDataReader.Close();
            sqlConnection.Close();
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Get_CharLogin_Data", string_0, string_1, ex.ToString());
            int_0 = -1;
            dateTime_0 = DateTime.Now;
            return false;
        }
    }

    public static int smethod_90(int int_0, string string_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE [_RefAppFunctionSetting] SET [FunctionValue]='" + string_0 + "' WHERE ([FunctionID]='" + int_0 + "')", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1)
            {
                return -200;
            }
            return 1;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Upd_AppSettingEditForm", int_0.ToString(), string_0, ex.ToString());
            return -100;
        }
    }

    public static int smethod_91(int int_0, byte byte_0, string string_0, string string_1, string string_2)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE [_GameNotice] SET [Service]='" + byte_0 + "', [DateStart]='" + string_0 + "', [DateEnd]='" + string_1 + "', [Notice]='" + string_2 + "' WHERE ([ID]='" + int_0 + "')", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1)
            {
                return -200;
            }
            return 1;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Upd_AutoNotice", int_0.ToString(), byte_0.ToString(), string_0, string_1, string_2, ex.ToString());
            return -100;
        }
    }

    public static int smethod_92(int int_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _GameNotice WHERE ID = '" + int_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1)
            {
                return -200;
            }
            return 1;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Del_AutoNotice", int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_93(string string_0, int int_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [_CharTeamRegister] ([Time], [CharName], [RegisterTime]) VALUES (GETDATE(), '" + string_0 + "', " + int_0 + ");", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1)
            {
                return -200;
            }
            return 1;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_CharTeamRegister", string_0, int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_94(string string_0, int int_0, byte byte_0, short short_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Add_CharSellRegister", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@RegTime", SqlDbType.Int);
            sqlCommand.Parameters.Add("@CharLevel", SqlDbType.TinyInt);
            sqlCommand.Parameters.Add("@CharRegion", SqlDbType.SmallInt);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@RegTime"].Value = int_0;
            sqlCommand.Parameters["@CharLevel"].Value = byte_0;
            sqlCommand.Parameters["@CharRegion"].Value = short_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_CharSellRegister", string_0, int_0.ToString(), byte_0.ToString(), short_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_95(byte byte_0, byte byte_1, string string_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [_GameBlocked] ([Service], [AddTime], [AddType] ,[Info]) VALUES ('" + byte_0 + "', GETDATE()," + byte_1 + " ,'" + string_0 + "')", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1)
            {
                return -200;
            }
            return 1;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_Blocked", byte_0.ToString(), byte_1.ToString(), string_0, ex.ToString());
            return -100;
        }
    }

    public static int smethod_96(string string_0, byte byte_0, byte byte_1, string string_1)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE [_GameBlocked] SET [Service]='" + byte_1 + "', [AddTime]= GETDATE(), [Info]='" + string_1 + "' WHERE [Info]='" + string_0 + "' and AddType = " + byte_0, sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1)
            {
                return -200;
            }
            return 1;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Upd_Blocked", string_0, byte_0.ToString(), byte_1.ToString(), string_1, ex.ToString());
            return -100;
        }
    }

    public static bool smethod_11(string string_0, out int int_0, out int int_1) {
        int_0 = 0;
        int_1 = 0;
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("select top 1 CharID,HonorPoint from " + Class8.string_5 + ".dbo._TrainingCampMember where CharName='" + string_0 + "' and MemberClass=0", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read()) {
                int_0 = sqlDataReader.GetInt32(0);
                int_1 = sqlDataReader.GetInt32(1);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            if (int_0 == 0 && int_1 != 0) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_Char_Hornor_Point", string_0, ex.ToString());
            return false;
        }
    }

    public static int smethod_12(string string_0, byte byte_0, string string_1, string string_2, long long_0, byte byte_1, byte byte_2) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [dbo].[_CharItemSendList] ([AddTime], [CharName], [ItemType], [ItemCode], [ItemName], [ItemCount], [ItemOpt], [ItemState]) VALUES (getdate(), '" + string_0 + "', '" + byte_0 + "', '" + string_1 + "', '" + string_2 + "', '" + long_0 + "', '" + byte_1 + "', '" + byte_2 + "');", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_CharItemSendList", string_0, byte_0.ToString(), string_1, string_2, long_0.ToString(), byte_1.ToString(), byte_2.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_13(int int_0, byte byte_0, string string_0, string string_1, long long_0, byte byte_1) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [dbo].[_RefMoreReward] ([RewardType], [ItemType], [ItemCode], [ItemName], [ItemCount], [ItemOpt]) VALUES (" + int_0 + ", " + byte_0 + ", '" + string_0.ToString() + "', '" + string_1.ToString() + "', " + long_0 + ", " + byte_1 + ");", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_RefMoreReward", int_0.ToString(), byte_0.ToString(), string_0, string_1, long_0.ToString(), byte_1.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_14(int int_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _RefMoreReward WHERE ID = '" + int_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 0) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Del_RefMoreReward", int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_15(string string_0, string string_1, ushort ushort_0, byte byte_0) {
        try {
            int result = 0;
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("\r\n            USE [" + Class8.string_5 + "]\r\n\r\n            DECLARE\t@return_value int\r\n\r\n            EXEC\t@return_value = [dbo].[_ADD_ITEM_EXTERN]\r\n                \t@charname = '" + string_0 + "',\r\n                \t@codename = '" + string_1 + "',\r\n                \t@data = " + ushort_0 + ",\r\n\t                @opt_level = " + byte_0 + "\r\n\r\n            SELECT\t@return_value\r\n            ", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read()) {
                result = sqlDataReader.GetInt32(0);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_Char_Item", string_0, string_1, ushort_0.ToString(), byte_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static bool smethod_16(string string_0) {
        try {
            int num = 0;
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("\r\n            USE [" + Class8.string_5 + "]\r\n\r\n            DECLARE @IS_PET int\r\n            DECLARE @ITEM_LINKID int\r\n\r\n            SET @IS_PET = 0 \r\n            SET @ITEM_LINKID = 0\r\n\r\n            SELECT @ITEM_LINKID = Link FROM _RefObjCommon WHERE CodeName128 = '" + string_0 + "' AND TypeID1 = 3 and TypeID2 = 2 and TypeID3 = 1 and (TypeID4 = 1 or TypeID4 = 2 or TypeID4 = 3) AND Service = 1\r\n            IF(@ITEM_LINKID = 0)\r\n            BEGIN\r\n                SELECT 0\r\n            END\r\n            ELSE\r\n            BEGIN\r\n\t            SELECT 1\r\n            END\r\n            ", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read()) {
                num = sqlDataReader.GetInt32(0);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            if (num == 0) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exists_Item_Cos", string_0, ex.ToString());
            return false;
        }
    }
    public static List<Struct5> smethod_3(string string_0, out int int_0)
    {
        int_0 = 0;
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT ID,ItemType,ItemCode,ItemName,ItemCount,ItemOpt FROM _CharItemSendList WHERE CharName = '" + string_0 + "' AND ItemState = 0 ORDER BY ID", sqlConnection).ExecuteReader();
            var list = new List<Struct5>();
            while (sqlDataReader.Read())
            {
                long @int = sqlDataReader.GetInt64(0);
                byte @byte = sqlDataReader.GetByte(1);
                string @string = sqlDataReader.GetString(2);
                string string2 = sqlDataReader.GetString(3);
                long int2 = sqlDataReader.GetInt64(4);
                byte byte2 = sqlDataReader.GetByte(5);
                list.Add(new Struct5(@int, @byte, @string, string2, int2, byte2));
                if (@byte == 0)
                {
                    int_0++;
                }
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return list;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Get_CharItemSendList", string_0, ex.ToString());
            return new List<Struct5>();
        }
    }

    public static int smethod_4(string string_0, string string_1, string string_2, int int_0, string string_3)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Add_CharOnlineInfo", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@IP", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Speed", SqlDbType.Int);
            sqlCommand.Parameters.Add("@PCInfo", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@CharName"].Value = string_1;
            sqlCommand.Parameters["@IP"].Value = string_2;
            sqlCommand.Parameters["@Speed"].Value = int_0;
            sqlCommand.Parameters["@PCInfo"].Value = string_3;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_CharOnlineInfo", string_0, string_1, string_2, int_0.ToString(), string_3, ex.ToString());
            return -100;
        }
    }

    public static int smethod_5(string string_0, string string_1)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Del_CharOnlineInfo", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@CharName"].Value = string_1;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Del_CharOnlineInfo", string_0, string_1, ex.ToString());
            return -100;
        }
    }

    public static int smethod_6()
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Clear_CharOnlineInfo", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Clear_CharOnlineInfo", ex.ToString());
            return -100;
        }
    }

    public static bool smethod_7(long long_0, int int_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE top(1) _CharItemSendList SET ItemTime = GETDATE(),ItemState = " + int_0 + " WHERE ID = '" + long_0 + "';", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1)
            {
                return false;
            }
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Update_CharItemSendList_Status", long_0.ToString(), int_0.ToString(), ex.ToString());
            return false;
        }
    }

    public static bool smethod_8(string string_0, long long_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE TOP(1) [" + Class8.string_5 + "].[dbo].[_Char] SET RemainGold = RemainGold + " + long_0 + " WHERE CharName16 = '" + string_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1)
            {
                return false;
            }
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Update_Char_Gold", string_0, long_0.ToString(), ex.ToString());
            return false;
        }
    }

    public static int smethod_9(string string_0)
    {
        try
        {
            byte result = 0;
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("\r\n            USE [" + Class8.string_5 + "]\r\n\r\n            DECLARE @Inv_Capacity int\r\n            DECLARE @SlotCount tinyint\r\n            DECLARE @CharID int\r\n\r\n            SET @Inv_Capacity = 0\r\n            SET @SlotCount = 0\r\n            SET @CharID = 0\r\n\r\n            select top 1 @Inv_Capacity = InventorySize,@CharID = CharID from _char with (nolock) where CharName16 = '" + string_0 + "'\r\n            IF(@Inv_Capacity = 0)\r\n            BEGIN\r\n                SELECT @SlotCount\r\n                RETURN\r\n            END\r\n            select @SlotCount = COUNT(*) from _inventory with (nolock) where charid = @CharID and slot >= 13 and slot < @Inv_Capacity and itemid = 0\r\n            IF(@SlotCount > 0)\r\n            BEGIN\r\n                SELECT @SlotCount\r\n            END\r\n            ", sqlConnection).ExecuteReader();
            while (sqlDataReader.Read())
            {
                result = sqlDataReader.GetByte(0);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Get_Char_Inv_Count", string_0, ex.ToString());
            return -100;
        }
    }

    public static bool smethod_10(string string_0)
    {
        int num = 0;
        int num2 = 0;
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("select sec_content,sec_primary from " + Class8.string_6 + ".dbo.TB_User where StrUserID = '" + string_0 + "'", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read())
            {
                num = sqlDataReader.GetByte(0);
                num2 = sqlDataReader.GetByte(1);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            if (num == 0 && num2 == 0)
            {
                return false;
            }
            if (num == 3 && num2 == 3)
            {
                return false;
            }
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Get_GM_UserID", string_0, ex.ToString());
            return false;
        }
    }
    public static string smethod_17(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("select definition from sys.all_sql_modules WHERE OBJECT_ID = OBJECT_ID('" + string_0 + "')", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read()) {
                string @string = sqlDataReader.GetString(0);
                sqlDataReader.Close();
                sqlConnection.Close();
                return @string;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return "";
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_Procedure_Code", string_0, ex.ToString());
            return "";
        }
    }

    public static string smethod_18(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            string text = "";
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("Select name from syscolumns Where ID=OBJECT_ID('" + string_0 + "')", sqlConnection).ExecuteReader();
            while (sqlDataReader.Read()) {
                string @string = sqlDataReader.GetString(0);
                if (@string != "") {
                    text = text + "[" + @string + "]" + Environment.NewLine;
                }
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return text;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_TableField_Code", string_0, ex.ToString());
            return "";
        }
    }

    public static bool smethod_19(string string_0, string string_1) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT TOP 1 StrUserID FROM [" + Class8.string_6 + "].[dbo].[TB_User] WHERE JID = (SELECT TOP 1 UserJID FROM [" + Class8.string_5 + "].[dbo].[_User] WHERE CharID = (SELECT top 1 CharID FROM [" + Class8.string_5 + "].[dbo].[_Char] WHERE [CharName16] = '" + string_1 + "'))", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read()) {
                if (sqlDataReader.GetString(0).ToLower() == string_0.ToLower()) {
                    sqlDataReader.Close();
                    sqlConnection.Close();
                    return true;
                }
                sqlDataReader.Close();
                sqlConnection.Close();
                return false;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exists_UserID_CharName", string_0, string_1, ex.ToString());
            return false;
        }
    }

    public static int smethod_20(string string_0, string string_1, int int_0, out int int_1, out int int_2, out int int_3) {
        int_1 = 0;
        int_2 = 0;
        int_3 = 0;
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Add_Game_MallBox_Item", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@package_code", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Anount", SqlDbType.Int);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@package_code"].Value = string_1;
            sqlCommand.Parameters["@Anount"].Value = int_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            var sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                int_1 = sqlDataReader.GetInt32(0);
                int_2 = sqlDataReader.GetInt32(1);
                int_3 = sqlDataReader.GetInt32(2);
            }
            sqlDataReader.Close();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_Game_MallBox_Item", string_0, string_1, int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_21(string string_0, out int int_0) {
        int_0 = 0;
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Get_RefObjCommon_Code_Info", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CodeName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CodeName"].Value = string_0;
            sqlCommand.Parameters["@ID"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int_0 = (int)sqlCommand.Parameters["@ID"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_RefObjCommon_Code_Info", string_0, ex.ToString());
            return -100;
        }
    }

    public static int smethod_22(string string_0, out int int_0, out int int_1, out int int_2) {
        int_0 = 0;
        int_1 = 0;
        int_2 = 0;
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Get_User_Silk_Info", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            var sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                int_0 = sqlDataReader.GetInt32(0);
                int_1 = sqlDataReader.GetInt32(1);
                int_2 = sqlDataReader.GetInt32(2);
            }
            sqlDataReader.Close();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_User_Silk_Info", string_0, ex.ToString());
            return -100;
        }
    }

    public static bool smethod_23() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("USE [" + Class8.string_5 + "] select name from sys.objects where name = '_RefDropClassSel_COSEquip' and type='U'", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read()) {
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exists_RefDropClassSel_COSEquip", ex.ToString());
            return false;
        }
    }

    public static int smethod_24(int int_0, out string string_0) {
        string_0 = "";
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Get_RefObjCommon_ID_Info", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@CodeName", SqlDbType.VarChar, 129);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@ID"].Value = int_0;
            sqlCommand.Parameters["@CodeName"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_0 = (string)sqlCommand.Parameters["@CodeName"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_RefObjCommon_ID_Info", int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_25(string string_0, string string_1, string string_2, out string string_3) {
        string_3 = "";
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Center_System_Event_Char_Login", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@IP", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@PCInfo", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 129);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@IP"].Value = string_1;
            sqlCommand.Parameters["@PCInfo"].Value = string_2;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_3 = (string)sqlCommand.Parameters["@Info"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Center_System_Event_Char_Login", string_0, string_1, string_2, ex.ToString());
            return -100;
        }
    }



    public static int smethod_32(string string_0, string string_1, int int_0, string string_2, string string_3, int int_1, byte byte_0, short short_0, int int_2, int int_3, out int int_4, out string string_4) {
        string_4 = "";
        int_4 = 0;
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Center_System_Function_Send_Sell_Reward", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@RegTime", SqlDbType.Int);
            sqlCommand.Parameters.Add("@IP", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@PCInfo", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@SendType", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Config_SellRegisterRewardLevel", SqlDbType.TinyInt);
            sqlCommand.Parameters.Add("@Config_SellRegisterRewardRegionID", SqlDbType.SmallInt);
            sqlCommand.Parameters.Add("@Config_SellRegisterRewardTime", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Config_SellRegisterRewardSilk", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Return_RewardSilk", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 129);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@CharName"].Value = string_1;
            sqlCommand.Parameters["@RegTime"].Value = int_0;
            sqlCommand.Parameters["@IP"].Value = string_2;
            sqlCommand.Parameters["@PCInfo"].Value = string_3;
            sqlCommand.Parameters["@SendType"].Value = int_1;
            sqlCommand.Parameters["@Config_SellRegisterRewardLevel"].Value = byte_0;
            sqlCommand.Parameters["@Config_SellRegisterRewardRegionID"].Value = short_0;
            sqlCommand.Parameters["@Config_SellRegisterRewardTime"].Value = int_2;
            sqlCommand.Parameters["@Config_SellRegisterRewardSilk"].Value = int_3;
            sqlCommand.Parameters["@Return_RewardSilk"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int_4 = (int)sqlCommand.Parameters["@Return_RewardSilk"].Value;
            string_4 = (string)sqlCommand.Parameters["@Info"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Center_System_Function_Send_Sell_Reward", string_1, string_1, int_0.ToString(), string_2, string_3, int_1.ToString(), byte_0.ToString(), short_0.ToString(), int_2.ToString(), int_3.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_33() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _RefChatCommand WHERE Service = 1", sqlConnection).ExecuteReader();
            list_9.Clear();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                string @string = sqlDataReader.GetString(1);
                int int2 = sqlDataReader.GetInt32(2);
                string string2 = sqlDataReader.GetString(3);
                byte @byte = sqlDataReader.GetByte(4);
                string string3 = sqlDataReader.GetString(5);
                string string4 = sqlDataReader.GetString(6);
                string string5 = sqlDataReader.GetString(7);
                string string6 = sqlDataReader.GetString(8);
                string string7 = sqlDataReader.GetString(9);
                string string8 = sqlDataReader.GetString(10);
                string string9 = sqlDataReader.GetString(11);
                string string10 = sqlDataReader.GetString(12);
                var item = new Struct7(@int, @string, int2, string2, @byte, string3, string4, string5, string6, string7, string8, string9, string10);
                list_9.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_RefChatCommand", ex.ToString());
            return -100;
        }
    }

    public static int smethod_34() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _RefShopSilkReward WHERE Service = 1 ORDER BY Level", sqlConnection).ExecuteReader();
            list_8.Clear();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                byte @byte = sqlDataReader.GetByte(1);
                int int2 = sqlDataReader.GetInt32(2);
                int int3 = sqlDataReader.GetInt32(3);
                var item = default(Struct46);
                item.int_0 = @int;
                item.byte_0 = @byte;
                item.int_1 = int2;
                item.int_2 = int3;
                list_8.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_RefShopSilkReward", ex.ToString());
            return -100;
        }
    }

    public static int smethod_35() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _RefLevelMaxReward WHERE Service = 1", sqlConnection).ExecuteReader();
            list_7.Clear();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                int int2 = sqlDataReader.GetInt32(1);
                int int3 = sqlDataReader.GetInt32(2);
                var item = default(Struct45);
                item.int_0 = @int;
                item.int_1 = int2;
                item.int_2 = int3;
                list_7.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_RefLevelMaxReward", ex.ToString());
            return -100;
        }
    }

    public static int smethod_36() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _RefShopSilkRankingReward WHERE Service = 1", sqlConnection).ExecuteReader();
            list_6.Clear();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                int int2 = sqlDataReader.GetInt32(1);
                int int3 = sqlDataReader.GetInt32(2);
                var item = default(Struct44);
                item.int_0 = @int;
                item.int_1 = int2;
                item.int_2 = int3;
                list_6.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_RefShopSilkRankingReward", ex.ToString());
            return -100;
        }
    }
    public static int smethod_26(string string_0, string string_1, string string_2, int int_0, out string string_3)
    {
        string_3 = "";
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Center_System_Event_Char_Kill_Rare_Monster", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@IP", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@PCInfo", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@MonsterID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 129);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@IP"].Value = string_1;
            sqlCommand.Parameters["@PCInfo"].Value = string_2;
            sqlCommand.Parameters["@MonsterID"].Value = int_0;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_3 = (string)sqlCommand.Parameters["@Info"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Center_System_Event_Char_Kill_Rare_Monster", string_0, string_1, string_2, int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_27(string string_0, string string_1, string string_2, int int_0, byte byte_0, byte byte_1, out string string_3)
    {
        string_3 = "";
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Center_System_Event_Char_Alchemy_Success", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@IP", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@PCInfo", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@RefItemID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@ItemOpt", SqlDbType.TinyInt);
            sqlCommand.Parameters.Add("@ItemSlot", SqlDbType.TinyInt);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 129);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@IP"].Value = string_1;
            sqlCommand.Parameters["@PCInfo"].Value = string_2;
            sqlCommand.Parameters["@RefItemID"].Value = int_0;
            sqlCommand.Parameters["@ItemOpt"].Value = byte_0;
            sqlCommand.Parameters["@ItemSlot"].Value = byte_1;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_3 = (string)sqlCommand.Parameters["@Info"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Center_System_Event_Char_Alchemy_Success", string_0, string_1, string_2, int_0.ToString(), byte_0.ToString(), byte_1.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_28(string string_0, string string_1, string string_2, int int_0, out string string_3)
    {
        string_3 = "";
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Center_System_Event_Char_Tele", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@IP", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@PCInfo", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@TeleportID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 129);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@IP"].Value = string_1;
            sqlCommand.Parameters["@PCInfo"].Value = string_2;
            sqlCommand.Parameters["@TeleportID"].Value = int_0;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_3 = (string)sqlCommand.Parameters["@Info"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Center_System_Event_Char_Tele", string_0, string_1, string_2, int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_29(string string_0, string string_1, string string_2, int int_0, out string string_3)
    {
        string_3 = "";
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Center_System_Event_Char_UseItem_Cos_Transport", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@IP", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@PCInfo", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Slot", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 129);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@IP"].Value = string_1;
            sqlCommand.Parameters["@PCInfo"].Value = string_2;
            sqlCommand.Parameters["@Slot"].Value = int_0;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_3 = (string)sqlCommand.Parameters["@Info"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Center_System_Event_Char_UseItem_Cos_Transport", string_0, string_1, string_2, int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_30(string string_0, string string_1, string string_2, int int_0, out string string_3)
    {
        string_3 = "";
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Center_System_Event_Char_UseItem_Return", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@IP", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@PCInfo", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@RetType", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 129);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@IP"].Value = string_1;
            sqlCommand.Parameters["@PCInfo"].Value = string_2;
            sqlCommand.Parameters["@RetType"].Value = int_0;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_3 = (string)sqlCommand.Parameters["@Info"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Center_System_Event_Char_UseItem_Return", string_0, string_1, string_2, int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_31(string string_0, string string_1, string string_2, int int_0, int int_1, int int_2, out string string_3)
    {
        string_3 = "";
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Center_System_Event_Char_Buff_UseItem_Return", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@IP", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@PCInfo", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@ItemID1", SqlDbType.Int);
            sqlCommand.Parameters.Add("@ItemID2", SqlDbType.Int);
            sqlCommand.Parameters.Add("@RetType", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 129);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@IP"].Value = string_1;
            sqlCommand.Parameters["@PCInfo"].Value = string_2;
            sqlCommand.Parameters["@ItemID1"].Value = int_0;
            sqlCommand.Parameters["@ItemID2"].Value = int_1;
            sqlCommand.Parameters["@RetType"].Value = int_2;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_3 = (string)sqlCommand.Parameters["@Info"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Center_System_Event_Char_Buff_UseItem_Return", string_0, string_1, string_2, int_0.ToString(), int_1.ToString(), int_2.ToString(), ex.ToString());
            return -100;
        }
    }
    public static int smethod_37() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _RefMonsterKillReward WHERE Service = 1", sqlConnection).ExecuteReader();
            list_0.Clear();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                int int2 = sqlDataReader.GetInt32(1);
                string @string = sqlDataReader.GetString(2);
                string string2 = sqlDataReader.GetString(3);
                int int3 = sqlDataReader.GetInt32(4);
                var item = default(Struct39);
                item.int_0 = @int;
                item.int_1 = int2;
                item.string_0 = @string;
                item.string_1 = string2;
                item.int_2 = int3;
                list_0.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_RefMonsterKillReward", ex.ToString());
            return -100;
        }
    }

    public static int smethod_38() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _RefAlchemyReward WHERE Service = 1", sqlConnection).ExecuteReader();
            list_1.Clear();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                int int2 = sqlDataReader.GetInt32(1);
                string @string = sqlDataReader.GetString(2);
                string string2 = sqlDataReader.GetString(3);
                byte @byte = sqlDataReader.GetByte(4);
                int int3 = sqlDataReader.GetInt32(5);
                var item = default(Struct40);
                item.int_0 = @int;
                item.int_1 = int2;
                item.string_0 = @string;
                item.string_1 = string2;
                item.byte_0 = @byte;
                item.int_2 = int3;
                list_1.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_RefAlchemyReward", ex.ToString());
            return -100;
        }
    }

    public static int smethod_39() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _RefAlchemyLimit WHERE Service = 1", sqlConnection).ExecuteReader();
            list_4.Clear();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                int int2 = sqlDataReader.GetInt32(1);
                string @string = sqlDataReader.GetString(2);
                string string2 = sqlDataReader.GetString(3);
                byte @byte = sqlDataReader.GetByte(4);
                var item = default(Struct43);
                item.int_0 = @int;
                item.int_1 = int2;
                item.string_0 = @string;
                item.string_1 = string2;
                item.byte_0 = @byte;
                list_4.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_RefAlchemyLimit", ex.ToString());
            return -100;
        }
    }
    public static int smethod_57(string string_0, string string_1, string string_2, string string_3, string string_4)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Add_UserID", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@phone", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@regip", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@Password"].Value = string_1;
            sqlCommand.Parameters["@Email"].Value = string_2;
            sqlCommand.Parameters["@phone"].Value = string_3;
            sqlCommand.Parameters["@regip"].Value = string_4;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_UserID", string_0, string_1, string_2, string_3, string_4, ex.ToString());
            return -100;
        }
    }

    public static int smethod_58(string string_0, string string_1)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Exists_UserID_Password", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@Password"].Value = string_1;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Exists_UserID_Password", string_0, string_1, ex.ToString());
            return -100;
        }
    }

    public static int smethod_59(string string_0, string string_1)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Update_UserID_Password", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@Password"].Value = string_1;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Update_UserID_Password", string_0, string_1, ex.ToString());
            return -100;
        }
    }

    public static int smethod_60(string string_0, string string_1, ushort ushort_0, byte byte_0, string string_2, string string_3, string string_4, int int_0, int int_1, int int_2)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Update_CertificationConfig", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@MachineIP", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@ShardName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@ShardMax", SqlDbType.SmallInt);
            sqlCommand.Parameters.Add("@ContentID", SqlDbType.TinyInt);
            sqlCommand.Parameters.Add("@GlobalQuery", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@ShardQuery", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@ShardLogQuery", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@GatewayServerPort", SqlDbType.Int);
            sqlCommand.Parameters.Add("@DownloadServerPort", SqlDbType.Int);
            sqlCommand.Parameters.Add("@AgentServerPort", SqlDbType.Int);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@MachineIP"].Value = string_0;
            sqlCommand.Parameters["@ShardName"].Value = string_1;
            sqlCommand.Parameters["@ShardMax"].Value = ushort_0;
            sqlCommand.Parameters["@ContentID"].Value = byte_0;
            sqlCommand.Parameters["@GlobalQuery"].Value = string_2;
            sqlCommand.Parameters["@ShardQuery"].Value = string_3;
            sqlCommand.Parameters["@ShardLogQuery"].Value = string_4;
            sqlCommand.Parameters["@GatewayServerPort"].Value = int_0;
            sqlCommand.Parameters["@DownloadServerPort"].Value = int_1;
            sqlCommand.Parameters["@AgentServerPort"].Value = int_2;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Update_CertificationConfig", string_0, string_1, ushort_0.ToString(), byte_0.ToString(), string_2, string_3, string_4, int_0.ToString(), int_1.ToString(), int_2.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_61(string string_0, int int_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Reduce_Char_Silk", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@silk_own", SqlDbType.Int);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@silk_own"].Value = int_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Reduce_Char_Silk", string_0, int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_62(string string_0, byte byte_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_AddLogAlchemy", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Slot", SqlDbType.TinyInt);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@Slot"].Value = byte_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_Alchemy_Log", string_0, byte_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_63(string string_0, string string_1, byte byte_0, int int_0, int int_1)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_AddLogSendSilk", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Type", SqlDbType.TinyInt);
            sqlCommand.Parameters.Add("@silk_own", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Silk_Cur", SqlDbType.Int);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@CharName"].Value = string_1;
            sqlCommand.Parameters["@Type"].Value = byte_0;
            sqlCommand.Parameters["@silk_own"].Value = int_0;
            sqlCommand.Parameters["@Silk_Cur"].Value = int_1;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_Send_Silk_Log", string_0, string_1, byte_0.ToString(), int_0.ToString(), int_1.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_64(int int_0, string string_0, byte byte_0, int int_1, bool bool_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            int num = 0;
            if (bool_0)
            {
                num = 1;
            }
            sqlConnection.Open();
            int num2 = new SqlCommand("INSERT INTO [dbo].[_CharLevelMaxRanking] ([Time], [Rank], [CharName], [Level], [RewardSilk], [Status]) VALUES (getdate(), " + int_0 + ", '" + string_0 + "', " + byte_0 + ", " + int_1 + ", " + num + ");", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num2 == -1)
            {
                return -200;
            }
            return 1;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_CharLevelRanking", int_0.ToString(), string_0, byte_0.ToString(), int_1.ToString(), bool_0.ToString(), ex.ToString());
            return -100;
        }
    }
    public static int smethod_40() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _GameNotice ORDER BY ID", sqlConnection).ExecuteReader();
            list_2.Clear();
            while (sqlDataReader.Read()) {
                byte @byte = sqlDataReader.GetByte(0);
                int @int = sqlDataReader.GetInt32(1);
                string string_ = sqlDataReader.GetDateTime(2).ToString();
                string string_2 = sqlDataReader.GetDateTime(3).ToString();
                string @string = sqlDataReader.GetString(4);
                var item = default(Struct41);
                item.byte_0 = @byte;
                item.int_0 = @int;
                item.string_0 = string_;
                item.string_1 = string_2;
                item.string_2 = @string;
                list_2.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_GameNotice", ex.ToString());
            return -100;
        }
    }

    public static int smethod_41() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _GameMonster ORDER BY ID", sqlConnection).ExecuteReader();
            list_3.Clear();
            while (sqlDataReader.Read()) {
                byte @byte = sqlDataReader.GetByte(0);
                int @int = sqlDataReader.GetInt32(1);
                byte byte2 = sqlDataReader.GetByte(2);
                string @string = sqlDataReader.GetString(3);
                string string2 = sqlDataReader.GetString(4);
                var minValue = DateTime.MinValue;
                list_3.Add(new Struct42(@byte, @int, byte2, @string, minValue, string2));
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_Data_GameMonster", ex.ToString());
            return -100;
        }
    }

    public static int smethod_42() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _GameBlocked", sqlConnection).ExecuteReader();
            list_5.Clear();
            while (sqlDataReader.Read()) {
                byte @byte = sqlDataReader.GetByte(0);
                string string_ = sqlDataReader.GetDateTime(1).ToString();
                byte byte2 = sqlDataReader.GetByte(2);
                string @string = sqlDataReader.GetString(3);
                var item = default(Struct33);
                item.byte_0 = @byte;
                item.string_0 = string_;
                item.byte_1 = byte2;
                item.string_1 = @string;
                list_5.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_GameBlocked", ex.ToString());
            return -100;
        }
    }

    public static int smethod_43() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _GameBlockedChat", sqlConnection).ExecuteReader();
            list_12.Clear();
            while (sqlDataReader.Read()) {
                string string_ = sqlDataReader.GetDateTime(0).ToString();
                string @string = sqlDataReader.GetString(1);
                var item = default(Struct28);
                item.string_0 = string_;
                item.string_1 = @string;
                list_12.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_GameBlockedChat", ex.ToString());
            return -100;
        }
    }

    public static int smethod_44() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _GameMultiTrust", sqlConnection).ExecuteReader();
            list_10.Clear();
            while (sqlDataReader.Read()) {
                byte @byte = sqlDataReader.GetByte(0);
                string string_ = sqlDataReader.GetDateTime(1).ToString();
                byte byte2 = sqlDataReader.GetByte(2);
                string @string = sqlDataReader.GetString(3);
                var item = default(Struct34);
                item.byte_0 = @byte;
                item.string_0 = string_;
                item.byte_1 = byte2;
                item.string_1 = @string;
                list_10.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_GameMultiTrust", ex.ToString());
            return -100;
        }
    }

    public static int smethod_45() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _RefMoreReward", sqlConnection).ExecuteReader();
            list_11.Clear();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                int int2 = sqlDataReader.GetInt32(1);
                byte @byte = sqlDataReader.GetByte(2);
                string @string = sqlDataReader.GetString(3);
                string string2 = sqlDataReader.GetString(4);
                long int3 = sqlDataReader.GetInt64(5);
                byte byte2 = sqlDataReader.GetByte(6);
                var item = default(Struct30);
                item.int_0 = @int;
                item.int_1 = int2;
                item.byte_0 = @byte;
                item.string_0 = @string;
                item.string_1 = string2;
                item.long_0 = int3;
                item.byte_1 = byte2;
                list_11.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_MoreReward", ex.ToString());
            return -100;
        }
    }

    public static int smethod_46() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("select SK.ID,SK.Action_ReuseDelay,SK.Action_Overlap,SK.GroupID from _GameSkillUselimit as GSU inner join " + Class8.string_5 + ".dbo._RefSkill AS SK on GSU.Skill_Code COLLATE Chinese_PRC_CI_AS = SK.Basic_Code where GSU.Service = 1", sqlConnection).ExecuteReader();
            list_13.Clear();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                int int2 = sqlDataReader.GetInt32(1);
                int int3 = sqlDataReader.GetInt32(2);
                int int4 = sqlDataReader.GetInt32(3);
                var item = new Struct13(@int, int2, int3, int4);
                list_13.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Load_GameSkillUselimit", ex.ToString());
            return -100;
        }
    }

    public static bool smethod_47(string string_0, int int_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE top(1) _CharLevelMaxRanking SET Status = " + int_0 + " WHERE CharName = '" + string_0 + "';", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Update_CharLevelRanking_Status", string_0, int_0.ToString(), ex.ToString());
            return false;
        }
    }

    public static bool smethod_48(string string_0, int int_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE top(1) _CharShopSilkRanking SET Status = " + int_0 + " WHERE CharName = '" + string_0 + "';", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Update_CharShopSilkRanking_Status", string_0, int_0.ToString(), ex.ToString());
            return false;
        }
    }

    public static string smethod_49() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("_Get_SiegFortress_Guild_Info", sqlConnection) {
                CommandType = CommandType.StoredProcedure
            }.ExecuteReader();
            string text = "";
            while (sqlDataReader.Read()) {
                string @string = sqlDataReader.GetString(0);
                text = text + @string + Environment.NewLine;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return text;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_SiegFortress_Guild_Info", ex.ToString());
            return "";
        }
    }

    public static string smethod_50() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("_Get_SiegFortress_Guild_Char_Info", sqlConnection) {
                CommandType = CommandType.StoredProcedure
            }.ExecuteReader();
            string text = "";
            while (sqlDataReader.Read()) {
                string @string = sqlDataReader.GetString(0);
                byte @byte = sqlDataReader.GetByte(1);
                string text2 = sqlDataReader.GetDateTime(2).ToString();
                text = text + @string + "\t" + @byte + "\t" + text2 + Environment.NewLine;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return text;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_SiegFortress_Guild_Char_Info", ex.ToString());
            return "";
        }
    }

    public static string smethod_51(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT distinct CharName FROM _CharTeleWorldCode WHERE Time > '" + string_0 + "'", sqlConnection).ExecuteReader();
            string text = "";
            while (sqlDataReader.Read()) {
                string @string = sqlDataReader.GetString(0);
                text = text + @string + Environment.NewLine;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return text;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_SiegFortress_Char_World", string_0, ex.ToString());
            return "";
        }
    }

    public static int smethod_52(string string_0, string string_1) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Exists_SiegFortress_Char_World", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@StartTime", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@StartTime"].Value = string_1;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exists_SiegFortress_Char_World", string_0, string_1, ex.ToString());
            return -100;
        }
    }
    public static int smethod_75(string string_0, out string string_1)
    {
        string_1 = "";
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Get_Char_NickName", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@NickName", SqlDbType.VarChar, 17);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@NickName"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_1 = (string)sqlCommand.Parameters["@NickName"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Get_Char_NickName", string_0, ex.ToString());
            return -100;
        }
    }

    public static int smethod_76(string string_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Get_Char_Level", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int num = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            if (num > 0)
            {
                return num;
            }
            return -100;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Get_Char_CurLevel", string_0, ex.ToString());
            return -200;
        }
    }

    public static int smethod_77(string string_0, string string_1, string string_2, out string string_3, out string string_4)
    {
        string_3 = "";
        string_4 = "";
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Center_System_Event_Char_Data_Loading_End", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@IP", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@PCInfo", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@FunctionInfo", SqlDbType.VarChar, 2550);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 129);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@IP"].Value = string_1;
            sqlCommand.Parameters["@PCInfo"].Value = string_2;
            sqlCommand.Parameters["@FunctionInfo"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_3 = (string)sqlCommand.Parameters["@FunctionInfo"].Value;
            string_4 = (string)sqlCommand.Parameters["@Info"].Value;
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Center_System_Event_Char_Data_Loading_End", string_0, string_1, string_2, ex.ToString());
            return -200;
        }
    }

    public static int smethod_78(string string_0, int int_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT TOP 100 * FROM [dbo].[_CharTeamRegister] WHERE [CharName] = '" + string_0 + "' AND [SendState] = 0", sqlConnection).ExecuteReader();
            int num = 0;
            while (sqlDataReader.Read())
            {
                sqlDataReader.GetDateTime(0).ToString();
                sqlDataReader.GetString(1);
                int @int = sqlDataReader.GetInt32(2);
                sqlDataReader.GetByte(3);
                num += @int;
            }
            sqlDataReader.Close();
            if (num >= int_0 && new SqlCommand("UPDATE TOP(100) [dbo].[_CharTeamRegister] SET [SendState]=1 WHERE [CharName] = '" + string_0 + "' AND [SendState] = 0", sqlConnection).ExecuteNonQuery() <= 0)
            {
                sqlConnection.Close();
                return -200;
            }
            sqlConnection.Close();
            return num;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Get_CharTeamRegisterTime", string_0, int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_79(string string_0, int int_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT TOP 100 * FROM [dbo].[_CharSellRegister] WHERE [CharName] = '" + string_0 + "' AND [SendState] = 0", sqlConnection).ExecuteReader();
            int num = 0;
            while (sqlDataReader.Read())
            {
                sqlDataReader.GetDateTime(0).ToString();
                sqlDataReader.GetString(1);
                int @int = sqlDataReader.GetInt32(2);
                sqlDataReader.GetByte(3);
                num += @int;
            }
            sqlDataReader.Close();
            if (num >= int_0 && new SqlCommand("UPDATE TOP(100) [dbo].[_CharSellRegister] SET [SendState]=1 WHERE [CharName] = '" + string_0 + "' AND [SendState] = 0", sqlConnection).ExecuteNonQuery() <= 0)
            {
                sqlConnection.Close();
                return -200;
            }
            sqlConnection.Close();
            return num;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Get_CharSellRegisterTime", string_0, int_0.ToString(), ex.ToString());
            return -100;
        }
    }
    public static int smethod_53(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Add_SiegFortress_Char_WorldCodeName", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_SiegFortress_Char_WorldCodeName", string_0, ex.ToString());
            return -100;
        }
    }

    public static int smethod_54(string string_0, int int_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Update_Char_Silk", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@silk_own", SqlDbType.Int);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@silk_own"].Value = int_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Update_Char_Silk", string_0, int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_55(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Exists_UserID", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exists_UserID", string_0, ex.ToString());
            return -100;
        }
    }

    public static int smethod_56(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Exists_Email", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@Email"].Value = string_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exists_Email", string_0, ex.ToString());
            return -100;
        }
    }



    public static int smethod_65(string string_0, byte byte_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            if (!new SqlCommand("SELECT TOP 1 * FROM [dbo].[_CharShopSilkReward] WHERE [CharName] = '" + string_0 + "' AND [Level] = '" + byte_0 + "'", sqlConnection).ExecuteReader().Read()) {
                sqlConnection.Close();
                return -200;
            }
            sqlConnection.Close();
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exist_CharShopSilkReward", string_0, byte_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_66(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT TOP 1 Silk_own FROM [dbo].[_CharShopSilk] WHERE [CharName] = '" + string_0 + "'", sqlConnection).ExecuteReader();
            if (!sqlDataReader.Read()) {
                sqlConnection.Close();
                return -200;
            }
            int @int = sqlDataReader.GetInt32(0);
            sqlConnection.Close();
            return @int;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_CharShopSilk", string_0, ex.ToString());
            return -100;
        }
    }

    public static int smethod_67(string string_0, byte byte_0, int int_0, int int_1) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [dbo].[_CharShopSilkReward] ([CharName], [Level], [ShopSilk], [RewardSilk]) VALUES ('" + string_0 + "', " + byte_0 + ", " + int_0 + ", " + int_1 + ");", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_CharShopSilkReward", string_0, byte_0.ToString(), int_0.ToString(), int_1.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_68() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Get_CharLevelMaxRanking", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int num = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            if (num > 0) {
                return num;
            }
            return -100;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_CharLevelRanking", ex.ToString());
            return -200;
        }
    }

    public static int smethod_69(byte byte_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Get_Char_Count", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@MaxLevel", SqlDbType.TinyInt);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@MaxLevel"].Value = byte_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int num = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            if (num > 0) {
                return num;
            }
            return -100;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_Char_Count", byte_0.ToString(), ex.ToString());
            return -200;
        }
    }

    public static int smethod_70(int int_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Update_Database", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@Ver", SqlDbType.Int);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@Ver"].Value = int_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int num = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            if (num > 0) {
                return num;
            }
            return -100;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Update_Database", int_0.ToString(), ex.ToString());
            return -200;
        }
    }

    public static int smethod_71(string string_0, string string_1, string string_2) {
        try {
            string_2 = string_2.Replace(" ", ".");
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_AddCharChatLog", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Chat", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@CharName"].Value = string_1;
            sqlCommand.Parameters["@Chat"].Value = string_2;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_Char_Chat_Log", string_0, string_1, string_2, ex.ToString());
            return -100;
        }
    }

    public static int smethod_72(string string_0, byte byte_0, out int int_0) {
        int_0 = 0;
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Get_Char_Slot_Item_Info", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Slot", SqlDbType.TinyInt);
            sqlCommand.Parameters.Add("@RefItemID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@Slot"].Value = byte_0;
            sqlCommand.Parameters["@RefItemID"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int.TryParse(sqlCommand.Parameters["@RefItemID"].Value.ToString(), out int_0);
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_Char_Slot_Item_Info", string_0, byte_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_73(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Get_User_Silk", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@UserID"].Value = string_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_User_Silk", string_0, ex.ToString());
            return -100;
        }
    }

    public static int smethod_74() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Clear_User_Data", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Clear_User_Data", ex.ToString());
            return -100;
        }
    }



    public static int smethod_80(byte byte_0, string string_0, string string_1, string string_2) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [_GameNotice] ([Service], [DateStart], [DateEnd], [Notice]) VALUES ('" + byte_0 + "', '" + string_0 + "', '" + string_1 + "', '" + string_2 + "')", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_AutoNotice", byte_0.ToString(), string_0, string_1, string_2, ex.ToString());
            return -100;
        }
    }

    public static int smethod_81(byte byte_0, byte byte_1, string string_0, string string_1) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [_GameMonster] ([Service], [Spawn_Opt_Type],[Spawn_Time], [Spawn_Parameter]) VALUES ('" + byte_0 + "','" + byte_1 + "' ,'" + string_0 + "', '" + string_1 + "')", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_GameMonster", byte_0.ToString(), byte_1.ToString(), string_0, string_1, ex.ToString());
            return -100;
        }
    }

    public static int smethod_82(int int_0, byte byte_0, byte byte_1, string string_0, string string_1) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE [_GameMonster] SET [Service]='" + byte_0 + "',[Spawn_Opt_Type]=" + byte_1 + ", [Spawn_Time]='" + string_0 + "', [Spawn_Parameter]='" + string_1 + "' WHERE [ID]=" + int_0, sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Upd_GameMonster", int_0.ToString(), byte_0.ToString(), byte_1.ToString(), string_0, string_1, ex.ToString());
            return -100;
        }
    }

    public static int smethod_83(int int_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _GameMonster WHERE ID = '" + int_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Del_GameMonster", int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_84(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [dbo].[_GameBlockedChat] ([AddTime], [CharName]) VALUES (GETDATE(), '" + string_0 + "');", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_GameBlockedChat", string_0, ex.ToString());
            return -100;
        }
    }

    public static int smethod_85(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _GameBlockedChat WHERE CharName = '" + string_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Del_GameBlockedChat", string_0, ex.ToString());
            return -100;
        }
    }



    public static bool smethod_97() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _GameBlocked", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Cle_Blocked", ex.ToString());
            return false;
        }
    }

    public static int smethod_98(byte byte_0, string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _GameBlocked WHERE Info = '" + string_0 + "' and AddType = " + byte_0, sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 0) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Del_Blocked", byte_0.ToString(), string_0, ex.ToString());
            return -100;
        }
    }

    public static int smethod_99(byte byte_0, byte byte_1, string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [_GameMultiTrust] ([Service], [AddTime], [AddType], [Info]) VALUES ('" + byte_0 + "', GETDATE(), " + byte_1 + ", '" + string_0 + "')", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_MultiTrust", byte_0.ToString(), byte_1.ToString(), string_0, ex.ToString());
            return -100;
        }
    }

    public static int smethod_100(string string_0, byte byte_0, byte byte_1, string string_1) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE [_GameMultiTrust] SET [Service]='" + byte_1 + "', [AddTime]= GETDATE(), [Info]='" + string_1 + "' WHERE [Info]='" + string_0 + "' and AddType = " + byte_0, sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Upd_MultiTrust", string_0, byte_0.ToString(), byte_1.ToString(), string_1, ex.ToString());
            return -100;
        }
    }

    public static int smethod_101(byte byte_0, string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _GameMultiTrust WHERE Info = '" + string_0 + "' and AddType = " + byte_0, sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 0) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Del_MultiTrust", byte_0.ToString(), string_0, ex.ToString());
            return -100;
        }
    }

    public static bool smethod_102(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("select name from sys.objects where name = '" + string_0 + "' and type='U'", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read()) {
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exist_Tab", string_0, ex.ToString());
            return false;
        }
    }
    public static bool smethod_128(string string_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _RefShopSilkReward WHERE Level = '" + string_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num < 0)
            {
                return false;
            }
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Del_RefShopSilkReward", string_0, ex.ToString());
            return false;
        }
    }

    public static int smethod_129(string string_0, string string_1, string string_2, string string_3, out string string_4, out string string_5)
    {
        string_5 = "";
        string_4 = "";
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand(string_0, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@TargetCharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@CommandParam", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 2550);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_1;
            sqlCommand.Parameters["@TargetCharName"].Value = string_2;
            sqlCommand.Parameters["@CommandParam"].Value = string_3;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_4 = sqlCommand.Parameters["@Info"].Value.ToString();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Exe_StoredProcedure", string_0, string_1, string_2, string_3, ex.ToString());
            string_5 = ex.Message;
            return -100;
        }
    }

    public static int smethod_130(string string_0, string string_1, string string_2, out string string_3, out string string_4)
    {
        string_4 = "";
        string_3 = "";
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand(string_0, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@CommandParam", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 2550);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_1;
            sqlCommand.Parameters["@CommandParam"].Value = string_2;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_3 = sqlCommand.Parameters["@Info"].Value.ToString();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            string_4 = ex.Message;
            return -100;
        }
    }

    public static int smethod_131(string string_0, string string_1, out string string_2, out string string_3)
    {
        string_3 = "";
        string_2 = "";
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand(string_0, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Info", SqlDbType.VarChar, 2550);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_1;
            sqlCommand.Parameters["@Info"].Direction = ParameterDirection.Output;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            string_2 = sqlCommand.Parameters["@Info"].Value.ToString();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            string_3 = ex.Message;
            return -100;
        }
    }
    public static bool smethod_103(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("select name from sys.objects where name = '" + string_0 + "' and type='P'", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read()) {
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exist_Exe", string_0, ex.ToString());
            return false;
        }
    }

    public static bool smethod_104(int int_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT TOP 1 ID FROM [dbo].[_RefMonsterKillReward] WHERE ID = " + int_0, sqlConnection).ExecuteReader();
            if (sqlDataReader.HasRows) {
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exist_RefMonsterKillReward_ID", int_0.ToString(), ex.ToString());
            return false;
        }
    }

    public static bool smethod_105(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT TOP 1 Level FROM [dbo].[_RefShopSilkReward] WHERE Level = " + string_0, sqlConnection).ExecuteReader();
            if (sqlDataReader.HasRows) {
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exist_RefShopSilkReward_Level", string_0.ToString(), ex.ToString());
            return false;
        }
    }

    public static bool smethod_106(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT TOP 1 Rank FROM [dbo].[_RefShopSilkRankingReward] WHERE Rank = " + string_0, sqlConnection).ExecuteReader();
            if (sqlDataReader.HasRows) {
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exist_RefShopSilkRankingReward_Rank", string_0, ex.ToString());
            return false;
        }
    }

    public static bool smethod_107(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT TOP 1 Rank FROM [dbo].[_RefLevelMaxReward] WHERE Rank = " + string_0, sqlConnection).ExecuteReader();
            if (sqlDataReader.HasRows) {
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exist_RefLevelMaxReward_Rank", string_0, ex.ToString());
            return false;
        }
    }

    public static bool smethod_108(int int_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT TOP 1 ID FROM [dbo].[_RefAlchemyReward] WHERE ID = " + int_0, sqlConnection).ExecuteReader();
            if (sqlDataReader.HasRows) {
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exist_RefAlchemyReward_ID", int_0.ToString(), ex.ToString());
            return false;
        }
    }

    public static bool smethod_109(string string_0, string string_1) {
        try {
            var sqlConnection = new SqlConnection(string_0);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("select name from sys.databases where name = '" + string_1 + "'", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read()) {
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Exist_Dab", string_0, string_1, ex.ToString());
            return false;
        }
    }



    public static bool smethod_121(string string_0, string string_1, string string_2) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [dbo].[_RefLevelMaxReward] ([Service], [Rank], [RewardSilk]) VALUES ('" + string_0 + "', '" + string_1 + "', '" + string_2 + "');", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num < 0) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_RefLevelMaxReward", string_0, string_1, string_2, ex.ToString());
            return false;
        }
    }

    public static bool smethod_122(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _RefAlchemyReward WHERE CodeName128 = '" + string_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num < 0) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Del_RefAlchemyReward", string_0, ex.ToString());
            return false;
        }
    }

    public static bool smethod_123(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _RefMonsterKillReward WHERE CodeName = '" + string_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num < 0) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Del_RefMonsterKillReward", string_0, ex.ToString());
            return false;
        }
    }

    public static bool smethod_124(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _RefLevelMaxReward WHERE Rank = '" + string_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num < 0) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Del_RefLevelMaxReward", string_0, ex.ToString());
            return false;
        }
    }

    public static bool smethod_125(string string_0, string string_1, string string_2) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [dbo].[_RefShopSilkRankingReward] ([Service], [Rank], [RewardSilk]) VALUES ('" + string_0 + "', '" + string_1 + "', '" + string_2 + "');", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num < 0) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_RefShopSilkRankingReward", string_0, string_1, string_2, ex.ToString());
            return false;
        }
    }

    public static bool smethod_126(string string_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _RefShopSilkRankingReward WHERE Rank = '" + string_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num < 0) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Del_RefShopSilkRankingReward", string_0, ex.ToString());
            return false;
        }
    }

    public static bool smethod_127(string string_0, string string_1, string string_2, string string_3) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [dbo].[_RefShopSilkReward] ([Service], [Level], [ShopSilk], [RewardSilk]) VALUES ('" + string_0 + "', '" + string_1 + "', '" + string_2 + "', '" + string_3 + "');", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num < 0) {
                return false;
            }
            return true;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Add_RefShopSilkReward", string_0, string_1, string_2, string_3, ex.ToString());
            return false;
        }
    }



    public static int smethod_132(string string_0, string string_1, out string string_2) {
        string_2 = "";
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand(string_0, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_1;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            string_2 = ex.Message;
            return -100;
        }
    }

    public static int smethod_133() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Sys_Custom_Event", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Sys_Custom_Event", ex.ToString());
            return -100;
        }
    }
    public static bool smethod_110(string string_0)
    {
        var sqlConnection = ((!(string_0 == "")) ? new SqlConnection(string_0) : new SqlConnection(Class8.string_3));
        try
        {
            sqlConnection.Open();
            sqlConnection.Close();
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Test", string_0, ex.ToString());
            return false;
        }
    }

    public static bool smethod_111(string string_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            new SqlCommand(string_0, sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Run_Code", string_0, ex.ToString());
            return false;
        }
    }

    public static bool smethod_112(string string_0, string string_1)
    {
        try
        {
            var sqlConnection = new SqlConnection(string_0);
            sqlConnection.Open();
            new SqlCommand("CREATE DATABASE " + string_1, sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Create_Database", string_0, string_1, ex.ToString());
            return false;
        }
    }

    public static bool smethod_113(string string_0, out string string_1)
    {
        string_1 = "";
        try
        {
            var sqlConnection = new SqlConnection(string_0);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("select name from sys.databases where name != 'master' and name != 'model' and name != 'tempdb' and name != 'msdb'", sqlConnection).ExecuteReader();
            while (sqlDataReader.Read())
            {
                string @string = sqlDataReader.GetString(0);
                if (string_1 == "")
                {
                    string_1 = @string;
                }
                else
                {
                    string_1 = string_1 + "/" + @string;
                }
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Get_AllDatabase", string_0, string_1, ex.ToString());
            return false;
        }
    }

    public static bool smethod_114(string string_0, string string_1)
    {
        try
        {
            var sqlConnection = new SqlConnection(string_0);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("select name from sys.objects where name = '" + string_1 + "' and type='U'", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read())
            {
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return false;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Shard_Exist_Tab", string_0, string_1, ex.ToString());
            return false;
        }
    }

    public static bool smethod_115(string string_0, short short_0, ushort ushort_0, ushort ushort_1, ushort ushort_2)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE _CertificationConfig SET ShardName = '" + string_0 + "',ShardMax = " + short_0 + ",GatewayServerPort = " + ushort_0 + ",AgentServerPort = " + ushort_1 + ",DownloadServerPort = " + ushort_2, sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num < 0)
            {
                return false;
            }
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Set_CertificationConfig", string_0, short_0.ToString(), ushort_0.ToString(), ushort_1.ToString(), ushort_2.ToString(), ex.ToString());
            return false;
        }
    }

    public static bool smethod_116(out byte byte_0, out string string_0, out string string_1, out string string_2, out string string_3, out string string_4, out short short_0, out ushort ushort_0, out ushort ushort_1, out ushort ushort_2)
    {
        byte_0 = 0;
        string_0 = "";
        string_1 = "";
        string_2 = "";
        string_3 = "";
        string_4 = "";
        short_0 = 0;
        ushort_0 = 0;
        ushort_1 = 0;
        ushort_2 = 0;
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT TOP 1 * FROM [dbo].[_CertificationConfig]", sqlConnection).ExecuteReader();
            if (sqlDataReader.Read())
            {
                byte_0 = sqlDataReader.GetByte(0);
                string_0 = sqlDataReader.GetString(1);
                string_1 = sqlDataReader.GetString(2);
                string_2 = sqlDataReader.GetString(3);
                string_3 = sqlDataReader.GetString(4);
                string_4 = sqlDataReader.GetString(5);
                short_0 = sqlDataReader.GetInt16(6);
                ushort_0 = (ushort)sqlDataReader.GetInt32(7);
                ushort_1 = (ushort)sqlDataReader.GetInt32(8);
                ushort_2 = (ushort)sqlDataReader.GetInt32(9);
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }
            byte_0 = 0;
            string_0 = "";
            string_1 = "";
            string_2 = "";
            string_3 = "";
            string_4 = "";
            short_0 = 0;
            ushort_0 = 0;
            ushort_1 = 0;
            ushort_2 = 0;
            sqlDataReader.Close();
            sqlConnection.Close();
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Get_CertificationConfig", ex.ToString());
            byte_0 = 0;
            string_0 = "";
            string_1 = "";
            string_2 = "";
            string_3 = "";
            string_4 = "";
            short_0 = 0;
            ushort_0 = 0;
            ushort_1 = 0;
            ushort_2 = 0;
            return false;
        }
    }

    public static int smethod_117(string string_0, int int_0)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Add_CharShopSilk", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@CharName", SqlDbType.VarChar);
            sqlCommand.Parameters.Add("@Silk_own", SqlDbType.Int);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@CharName"].Value = string_0;
            sqlCommand.Parameters["@Silk_own"].Value = int_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_CharShopSilk", string_0, int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static bool smethod_118(string string_0, string string_1)
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("INSERT INTO [dbo].[_GameLoginFunction] ([AddTime], [CharName], [SqlCode], [ExecuteState]) VALUES (getdate(), '" + string_1 + "', 'EXEC " + string_0 + " ''" + string_1 + "''', 0);", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num < 0)
            {
                return false;
            }
            return true;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Add_GameLoginFunction", string_0, string_1, ex.ToString());
            return false;
        }
    }

    public static int smethod_119()
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Update_CharShopSilkRanking", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Update_CharShopSilkRanking", ex.ToString());
            return -100;
        }
    }

    public static int smethod_120()
    {
        try
        {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("DELETE FROM _CharShopSilkRanking", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num < 0)
            {
                return -200;
            }
            return 1;
        }
        catch (Exception ex)
        {
            Class7.smethod_0("SqlError.SQL_Delete_CharShopSilkRanking", ex.ToString());
            return -100;
        }
    }
    public static int smethod_134() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Sys_Custom_Event_Start", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Sys_Custom_Event_Start", ex.ToString());
            return -100;
        }
    }

    public static int smethod_135(int int_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlCommand = new SqlCommand("_Sys_Custom_Event_Initial", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@EventID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@return", SqlDbType.Int);
            sqlCommand.Parameters["@EventID"].Value = int_0;
            sqlCommand.Parameters["@return"].Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            sqlConnection.Close();
            return result;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Sys_Custom_Event_Initial", int_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static List<Struct50> smethod_136() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _RefAppFunctionSetting ORDER BY FunctionID", sqlConnection).ExecuteReader();
            var list = new List<Struct50>();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                int int2 = sqlDataReader.GetInt32(1);
                string @string = sqlDataReader.GetString(2);
                int int3 = sqlDataReader.GetInt32(3);
                string string2 = sqlDataReader.GetString(4);
                string string3 = sqlDataReader.GetString(5);
                string string4 = sqlDataReader.GetString(6);
                string string5 = sqlDataReader.GetString(7);
                var item = new Struct50(@int, int2, @string, int3, string2, string3, string4, string5);
                list.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return list;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_RefAppFunctionSetting", ex.ToString());
            return null;
        }
    }

    public static List<Struct7> smethod_137() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT * FROM _RefChatCommand", sqlConnection).ExecuteReader();
            var list = new List<Struct7>();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                string @string = sqlDataReader.GetString(1);
                int int2 = sqlDataReader.GetInt32(2);
                string string2 = sqlDataReader.GetString(3);
                byte @byte = sqlDataReader.GetByte(4);
                string string3 = sqlDataReader.GetString(5);
                string string4 = sqlDataReader.GetString(6);
                string string5 = sqlDataReader.GetString(7);
                string string6 = sqlDataReader.GetString(8);
                string string7 = sqlDataReader.GetString(9);
                string string8 = sqlDataReader.GetString(10);
                string string9 = sqlDataReader.GetString(11);
                string string10 = sqlDataReader.GetString(12);
                var item = new Struct7(@int, @string, int2, string2, @byte, string3, string4, string5, string6, string7, string8, string9, string10);
                list.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return list;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_RefChatCommand", ex.ToString());
            return null;
        }
    }

    public static List<Struct51> smethod_138() {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            var sqlDataReader = new SqlCommand("SELECT RCE.Service,RCE.EventID,RCE.EventName,RCES.StartTime,RCES.ActionType,RCES.RewardType,RCES.RewardID,RCES.EventNotice,RCES.EventState,RCES.Author,RCES.EventDesc FROM _RefCustomEvent AS RCE inner join _RefCustomEventSetting AS RCES ON RCE.EventID = RCES.EventID", sqlConnection).ExecuteReader();
            var list = new List<Struct51>();
            while (sqlDataReader.Read()) {
                int @int = sqlDataReader.GetInt32(0);
                int int2 = sqlDataReader.GetInt32(1);
                string @string = sqlDataReader.GetString(2);
                string string_ = sqlDataReader.GetDateTime(3).ToString();
                int int3 = sqlDataReader.GetInt32(4);
                int int4 = sqlDataReader.GetInt32(5);
                int int5 = sqlDataReader.GetInt32(6);
                string string2 = sqlDataReader.GetString(7);
                int int6 = sqlDataReader.GetInt32(8);
                string string3 = sqlDataReader.GetString(9);
                string string4 = sqlDataReader.GetString(10);
                var item = new Struct51(@int, int2, @string, string_, int3, int4, int5, string2, int6, string3, string4);
                list.Add(item);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return list;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Get_RefCustomEvent", ex.ToString());
            return null;
        }
    }

    public static int smethod_139(int int_0, byte byte_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE [_RefCustomEvent] SET [Service]='" + byte_0.ToString() + "' WHERE [EventID]='" + int_0 + "' UPDATE [_RefCustomEventStart] SET [Service]='" + byte_0.ToString() + "' WHERE [EventID]='" + int_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Upd_RefCustomEvent", int_0.ToString(), byte_0.ToString(), ex.ToString());
            return -100;
        }
    }

    public static int smethod_140(string string_0, byte byte_0) {
        try {
            var sqlConnection = new SqlConnection(Class8.string_3);
            sqlConnection.Open();
            int num = new SqlCommand("UPDATE [_RefChatCommand] SET [Service]='" + byte_0 + "' WHERE [ChatCommand]='" + string_0 + "'", sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
            if (num == -1) {
                return -200;
            }
            return 1;
        }
        catch (Exception ex) {
            Class7.smethod_0("SqlError.SQL_Upd_RefChatCommand", string_0, byte_0.ToString(), ex.ToString());
            return -100;
        }
    }
}
