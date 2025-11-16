using System.Management;

internal class Class35 {
    private static string smethod_0() {
        new ManagementClass("Win32_NetworkAdapterConfiguration");
        var managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
        managementObject.Get();
        return managementObject.GetPropertyValue("VolumeSerialNumber").ToString();
    }

    private static string smethod_1() {
        string result = null;
        using (var managementObjectEnumerator = new ManagementClass("win32_Processor").GetInstances().GetEnumerator()) {
            if (managementObjectEnumerator.MoveNext()) {
                return ((ManagementObject)managementObjectEnumerator.Current).Properties["Processorid"].Value.ToString();
            }
            return result;
        }
    }

    public static string smethod_2() {
        try {
            return (smethod_3() + smethod_1() + smethod_0()).Substring(0, 30);
        }
        catch {
            return "210103863BFEBFBFF000306C38E883";
        }
    }

    private static string smethod_3() {
        var managementObjectSearcher = new ManagementObjectSearcher();
        managementObjectSearcher.Query = new SelectQuery("Win32_DiskDrive", "", new string[2] { "PNPDeviceID", "Signature" });
        var enumerator = managementObjectSearcher.Get().GetEnumerator();
        enumerator.MoveNext();
        return enumerator.Current.Properties["signature"].Value.ToString().Trim();
    }
}
