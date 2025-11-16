using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;

internal class Class51 {
    public static List<Struct56> smethod_0() {
        return (from ipaddress_0 in Dns.GetHostAddresses(Dns.GetHostName())
                where ipaddress_0.AddressFamily == AddressFamily.InterNetwork || ipaddress_0.AddressFamily == AddressFamily.InterNetworkV6
                select ipaddress_0).Select(delegate (IPAddress ipaddress_0) {
                    var result = default(Struct56);
                    result.enum10_0 = ((ipaddress_0.AddressFamily == AddressFamily.InterNetwork) ? Enum10.const_1 : Enum10.const_2);
                    result.string_0 = ipaddress_0.ToString();
                    return result;
                }).ToList();
    }

    public static IPAddress[] smethod_1() {
        return Dns.GetHostAddresses(Dns.GetHostName());
    }
}
