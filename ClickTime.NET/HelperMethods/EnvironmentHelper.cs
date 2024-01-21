using ClickTime.NET.Enums;

namespace ClickTime.NET.HelperMethods;

internal static class EnvironmentHelper
{
    internal static string? GetEnvironmentVariable(EnvironmentVariableEnums envEnum) => Environment.GetEnvironmentVariable(envEnum.ToString());
}