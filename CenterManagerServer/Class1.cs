using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class Class1 {
    public delegate bool Delegate0(IntPtr intptr_0, int int_0);

    private static IntPtr intptr_0 = IntPtr.Zero;

    private static IntPtr intptr_1 = IntPtr.Zero;

    [DllImport("User32.dll")]
    public static extern IntPtr FindWindow(string string_0, string string_1);

    [DllImport("User32.dll")]
    public static extern int GetWindowThreadProcessId(IntPtr intptr_2, out int int_0);

    [DllImport("ntdll.dll")]
    public static extern int ZwSuspendProcess(IntPtr intptr_2);

    [DllImport("ntdll.dll")]
    public static extern int ZwResumeProcess(IntPtr intptr_2);

    [DllImport("kernel32.dll")]
    public static extern int OpenProcess(int int_0, bool bool_0, int int_1);

    [DllImport("kernel32")]
    public static extern bool CloseHandle(int int_0);

    [DllImport("kernel32.dll")]
    public static extern int WriteProcessMemory(int int_0, int int_1, byte[] byte_0, int int_2, int int_3);

    [DllImport("kernel32.dll ")]
    public static extern bool ReadProcessMemory(int int_0, int int_1, byte[] byte_0, int int_2, out int int_3);

    [DllImport("user32.dll")]
    public static extern int GetWindowTextW(IntPtr intptr_2, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

    [DllImport("user32.dll")]
    public static extern bool EnumWindows(Delegate0 delegate0_0, int int_0);

    [DllImport("User32.dll")]
    public static extern bool IsIconic(IntPtr intptr_2);

    [DllImport("User32.dll")]
    public static extern bool IsWindowVisible(IntPtr intptr_2);

    public static bool smethod_0(string string_0) {
        intptr_0 = IntPtr.Zero;
        intptr_1 = IntPtr.Zero;
        EnumWindows(delegate (IntPtr intptr_0, int int_0) {
            var stringBuilder = new StringBuilder(256);
            GetWindowTextW(intptr_0, stringBuilder, stringBuilder.Capacity);
            if (stringBuilder.ToString().IndexOf(string_0) > -1) {
                if (IsIconic(intptr_0)) {
                    if (intptr_1 == IntPtr.Zero) {
                        intptr_1 = intptr_0;
                    }
                }
                else if (IsWindowVisible(intptr_0)) {
                    if (intptr_1 == IntPtr.Zero) {
                        intptr_1 = intptr_0;
                    }
                }
                else if (Class1.intptr_0 == IntPtr.Zero) {
                    Class1.intptr_0 = intptr_0;
                    return true;
                }
            }
            return true;
        }, 0);
        return true;
    }

    public static string smethod_1(int int_0) {
        string string_0 = "";
        intptr_0 = IntPtr.Zero;
        intptr_1 = IntPtr.Zero;
        EnumWindows(delegate (IntPtr intptr_0, int int_1) {
            var stringBuilder = new StringBuilder(256);
            GetWindowTextW(intptr_0, stringBuilder, stringBuilder.Capacity);
            string text = stringBuilder.ToString();
            GetWindowThreadProcessId(intptr_0, out var int_2);
            if (text.IndexOf("Server") > -1 && int_2 == int_0) {
                string_0 = text;
            }
            return true;
        }, 0);
        return string_0;
    }

    public static string smethod_2(string string_0, bool bool_0 = false) {
        try {
			var zero = IntPtr.Zero;
			if (bool_0) {
                smethod_0(string_0);
                if (intptr_0 == IntPtr.Zero) {
                    intptr_0 = intptr_1;
                }
                zero = intptr_0;
            }
            else {
                string_0 += "r";
                zero = FindWindow(string_0, string_0);
            }
            GetWindowThreadProcessId(zero, out int int_);
            string moduleName = Process.GetProcessById(int_).MainModule.ModuleName;
            string fileName = Process.GetProcessById(int_).MainModule.FileName;
            return fileName.Substring(0, fileName.Length - moduleName.Length);
        }
        catch {
            return "";
        }
    }
    public static string smethod_9(string string_0, string string_1)
    {
        try
        {
            GetWindowThreadProcessId(FindWindow(string_0, string_1), out int int_);
            string moduleName = Process.GetProcessById(int_).MainModule.ModuleName;
            string fileName = Process.GetProcessById(int_).MainModule.FileName;
            return fileName.Substring(0, fileName.Length - moduleName.Length);
        }
        catch
        {
            return "";
        }
    }

    public static int smethod_10(byte[] byte_0, byte[] byte_1)
    {
        if (byte_0 == null)
        {
            return -1;
        }
        if (byte_1 == null)
        {
            return -1;
        }
        if (byte_0.Length == 0)
        {
            return -1;
        }
        if (byte_1.Length == 0)
        {
            return -1;
        }
        if (byte_0.Length < byte_1.Length)
        {
            return -1;
        }
        int num = 0;
        while (true)
        {
            if (num < byte_0.Length)
            {
                if (byte_0[num] == byte_1[0])
                {
                    if (byte_1.Length == 1)
                    {
                        return num;
                    }
                    bool flag = true;
                    for (int i = 1; i < byte_1.Length; i++)
                    {
                        if (byte_0[num + i] != byte_1[i])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        break;
                    }
                }
                num++;
                continue;
            }
            return -1;
        }
        return num;
    }

    public static byte[] smethod_11(byte[] byte_0, byte[] byte_1)
    {
        try
        {
            int num = smethod_10(byte_0, byte_1);
            int num2 = byte_1.Length + num;
            byte[] array = new byte[byte_0.Length - byte_1.Length];
            if (num > -1)
            {
                int num3 = 0;
                for (int i = 0; i < byte_0.Length; i++)
                {
                    if (i < num || i >= num2)
                    {
                        array[num3] = byte_0[i];
                        num3++;
                    }
                }
            }
            return array;
        }
        catch
        {
            return null;
        }
    }

    public static byte[] smethod_12(byte[] byte_0, byte[] byte_1)
    {
        try
        {
            if (byte_0.Length != 0 && byte_1.Length != 0)
            {
                byte[] array = new byte[byte_0.Length + byte_1.Length];
                Array.Copy(byte_0, array, byte_0.Length);
                Array.Copy(byte_1, 0, array, byte_0.Length, byte_1.Length);
                return array;
            }
            return null;
        }
        catch
        {
            return null;
        }
    }

    public static byte[] smethod_13(byte[] byte_0, int int_0)
    {
        try
        {
            if (byte_0.Length == 0)
            {
                return null;
            }
            int num = byte_0.Length - int_0;
            byte[] array = new byte[byte_0.Length - num];
            Array.Copy(byte_0, num, array, 0, array.Length);
            return array;
        }
        catch
        {
            return null;
        }
    }

    public static byte[] smethod_14(byte[] byte_0, int int_0)
    {
        try
        {
            if (byte_0.Length == 0)
            {
                return null;
            }
            byte[] array = new byte[int_0];
            Array.Copy(byte_0, 0, array, 0, array.Length);
            return array;
        }
        catch
        {
            return null;
        }
    }

    public static bool smethod_15(int int_0, int int_1, byte byte_0)
    {
        if (smethod_18(int_0, int_1, new byte[1] { byte_0 }))
        {
            return true;
        }
        return false;
    }

    public static byte smethod_16(int int_0, int int_1)
    {
        byte[] array = smethod_17(int_0, int_1, 1);
        if (array.Length != 1)
        {
            return 0;
        }
        return array[0];
    }

    public static byte[] smethod_17(int int_0, int int_1, int int_2)
    {
        try
        {
            int num = OpenProcess(2035711, bool_0: false, int_0);
            if (num < 1)
            {
                return new byte[0];
            }
            byte[] array = new byte[int_2];
            if (ReadProcessMemory(num, int_1, array, int_2, out int int_3))
            {
                CloseHandle(num);
                return array;
            }
            CloseHandle(num);
            return new byte[0];
        }
        catch
        {
            return new byte[0];
        }
    }

    public static bool smethod_18(int int_0, int int_1, byte[] byte_0)
    {
        try
        {
            int num = OpenProcess(2035711, bool_0: false, int_0);
            if (num < 1)
            {
                return false;
            }
            if (WriteProcessMemory(num, int_1, byte_0, byte_0.Length, 0) == 0)
            {
                CloseHandle(num);
                return false;
            }
            CloseHandle(num);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public static string smethod_3(int int_0) {
        try {
            string moduleName = Process.GetProcessById(int_0).MainModule.ModuleName;
            string fileName = Process.GetProcessById(int_0).MainModule.FileName;
            return fileName.Substring(0, fileName.Length - moduleName.Length);
        }
        catch {
            return "";
        }
    }

    public static int smethod_4(string string_0, bool bool_0 = false) {
        try {
			var zero = IntPtr.Zero;
			if (bool_0) {
                smethod_0(string_0);
                if (intptr_0 == IntPtr.Zero) {
                    intptr_0 = intptr_1;
                }
                zero = intptr_0;
            }
            else {
                string_0 += "r";
                zero = FindWindow(string_0, string_0);
            }
            GetWindowThreadProcessId(zero, out int int_);
            return int_;
        }
        catch {
            return 0;
        }
    }

    public static string smethod_5(string string_0, out int int_0, bool bool_0 = false) {
        try {
            int_0 = 0;
			var zero = IntPtr.Zero;
			if (bool_0) {
                smethod_0(string_0);
                if (intptr_0 == IntPtr.Zero) {
                    intptr_0 = intptr_1;
                }
                zero = intptr_0;
            }
            else {
                string_0 += "r";
                zero = FindWindow(string_0, string_0);
            }
            GetWindowThreadProcessId(zero, out int int_);
            _ = Process.GetProcessById(int_).MainModule.ModuleName;
            var fileStream = new FileStream(Process.GetProcessById(int_).MainModule.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] array = new MD5CryptoServiceProvider().ComputeHash(fileStream);
            fileStream.Close();
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < array.Length; i++) {
                stringBuilder.Append(array[i].ToString("x2"));
            }
            int_0 = int_;
            return stringBuilder.ToString();
        }
        catch {
            int_0 = 0;
            return "";
        }
    }

    public static string smethod_6(string string_0, string string_1, out int int_0) {
        try {
            int_0 = 0;
			GetWindowThreadProcessId(FindWindow(string_0, string_1), out int int_);
			_ = Process.GetProcessById(int_).MainModule.ModuleName;
            var fileStream = new FileStream(Process.GetProcessById(int_).MainModule.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] array = new MD5CryptoServiceProvider().ComputeHash(fileStream);
            fileStream.Close();
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < array.Length; i++) {
                stringBuilder.Append(array[i].ToString("x2"));
            }
            int_0 = int_;
            return stringBuilder.ToString();
        }
        catch {
            int_0 = 0;
            return "";
        }
    }

    public static string smethod_7(int int_0) {
        try {
            var fileStream = new FileStream(Process.GetProcessById(int_0).MainModule.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] array = new MD5CryptoServiceProvider().ComputeHash(fileStream);
            fileStream.Close();
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < array.Length; i++) {
                stringBuilder.Append(array[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
        catch {
            return "";
        }
    }

    public static int smethod_8(string string_0, string string_1) {
        try {
			GetWindowThreadProcessId(FindWindow(string_0, string_1), out int int_);
			return int_;
        }
        catch {
            return 0;
        }
    }


}
