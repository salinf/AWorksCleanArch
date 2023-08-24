using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDomain.ClassExtensions;

public static class StringUtility
{
    public static string EncodeBase64(this string value)
    {
        var valueBytes = Encoding.UTF8.GetBytes(value);
        return Convert.ToBase64String(valueBytes);
    }

    public static string DecodeBase64(this string value)
    {
        var valueBytes = Convert.FromBase64String(value);
        return Encoding.UTF8.GetString(valueBytes);
    }

    public static T DecodeBase64<T>(this string value)
    {
        var valueBytes = Convert.FromBase64String(value);
        return (T)Convert.ChangeType(valueBytes, typeof(T));
    }
    public static string EncodeBase64Url(this string value)
    {
        var valueBytes = Encoding.UTF8.GetBytes(value);
        return Convert.ToBase64String(valueBytes).Replace("-", "/").Replace("_", "+").Replace("=", "!");
    }
    public static string DecodeBase64Url(this string value)
    {
        var valueBytes = Convert.FromBase64String(value.Replace("/", "-").Replace("+", "_").Replace("!", "="));
        return Encoding.UTF8.GetString(valueBytes);
    }
}
