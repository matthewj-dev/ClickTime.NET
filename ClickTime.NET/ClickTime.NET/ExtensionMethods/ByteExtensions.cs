namespace ClickTime.NET.ExtensionMethods;

internal static class ByteExtensions
{
    internal static string Base64Encode(this byte[] bytes) => Convert.ToBase64String(bytes);
}