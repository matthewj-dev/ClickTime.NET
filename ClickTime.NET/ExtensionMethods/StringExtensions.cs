using System.Text;

namespace ClickTime.NET.ExtensionMethods;

internal static class StringExtensions
{
    internal static byte[] Encode(this string value) => Encoding.UTF8.GetBytes(value);
    internal static string Base64Encode(this string value) => value.Encode().Base64Encode();
}