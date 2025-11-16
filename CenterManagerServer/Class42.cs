using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

internal class Class42 : IComparer {
    private int int_0;

    private SortOrder sortOrder_0;

    private CaseInsensitiveComparer caseInsensitiveComparer_0;

    public Class42() {
        int_0 = 0;
        sortOrder_0 = SortOrder.None;
        caseInsensitiveComparer_0 = new CaseInsensitiveComparer();
    }

    public Class42(int int_1, SortOrder sortOrder_1) {
        int_0 = int_1;
        sortOrder_0 = sortOrder_1;
        caseInsensitiveComparer_0 = new CaseInsensitiveComparer();
    }
    public bool method_0(string string_0)
    {
        return Regex.Match(string_0, "^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$").Success;
    }

    private int method_5(int int_1, int int_2)
    {
        if (int_1 > int_2)
        {
            return 1;
        }
        if (int_1 < int_2)
        {
            return -1;
        }
        return 0;
    }

    private int method_6(string string_0, string string_1)
    {
        string[] array = string_0.Split('.');
        string[] array2 = string_1.Split('.');
        int num = 0;
        while (true)
        {
            if (num < 4)
            {
                if (Convert.ToInt32(array[num]) > Convert.ToInt32(array2[num]))
                {
                    break;
                }
                if (Convert.ToInt32(array[num]) >= Convert.ToInt32(array2[num]))
                {
                    num++;
                    continue;
                }
                return -1;
            }
            return 0;
        }
        return 1;
    }

    public void method_1(int int_1)
    {
        int_0 = int_1;
    }
    public int Compare(object x, object y) {
        var obj = (ListViewItem)x;
        var listViewItem = (ListViewItem)y;
        string text = obj.SubItems[int_0].Text;
        string text2 = listViewItem.SubItems[int_0].Text;
		int num = ((method_0(text) && method_0(text2)) ? method_6(text, text2) : ((!int.TryParse(text, out int result) || !int.TryParse(text2, out int result2)) ? caseInsensitiveComparer_0.Compare(text, text2) : method_5(result, result2)));
		if (sortOrder_0 == SortOrder.Ascending) {
            return num;
        }
        if (sortOrder_0 == SortOrder.Descending) {
            return -num;
        }
        return 0;
    }



    public int method_2() {
        return int_0;
    }

    public void method_3(SortOrder sortOrder_1) {
        sortOrder_0 = sortOrder_1;
    }

    public SortOrder method_4() {
        return sortOrder_0;
    }
}
