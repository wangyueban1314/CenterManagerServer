using System;
using System.Collections.Concurrent;

internal class Class45 {
    private ConcurrentDictionary<IntPtr, object> concurrentDictionary_0 = new ConcurrentDictionary<IntPtr, object>();
    public T method_1<T>(IntPtr intptr_0)
    {
        if (concurrentDictionary_0.TryGetValue(intptr_0, out var value))
        {
            return (T)value;
        }
        return default(T);
    }

    public bool method_2(IntPtr intptr_0, object object_0)
    {
        try
        {
            concurrentDictionary_0.AddOrUpdate(intptr_0, object_0, (IntPtr intptr_1, object object_1) => object_0);
            return true;
        }
        catch (OverflowException)
        {
            return false;
        }
        catch (ArgumentNullException)
        {
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public object method_0(IntPtr intptr_0) {
        if (concurrentDictionary_0.TryGetValue(intptr_0, out var value)) {
            return value;
        }
        return null;
    }



    public bool method_3(IntPtr intptr_0) {
		return concurrentDictionary_0.TryRemove(intptr_0, out object value);
	}
}
