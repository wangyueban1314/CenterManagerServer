using System.IO;
using System.Text;

internal class Class21 : BinaryWriter {
    private MemoryStream memoryStream_0;

    public Class21() {
        try {
            memoryStream_0 = new MemoryStream();
            OutStream = memoryStream_0;
        }
        catch {
        }
    }



    public void method_1(string string_0) {
        try {
            byte[] bytes = Encoding.Default.GetBytes(string_0);
            Write((ushort)bytes.Length);
            Write(bytes);
        }
        catch {
        }
    }
    public byte[] method_0()
    {
        try
        {
            return memoryStream_0.ToArray();
        }
        catch
        {
            return null;
        }
    }
}
