using StrEnum;

namespace ClickTime.NET.Enums;

internal sealed class EnvironmentVariableEnums : StringEnum<EnvironmentVariableEnums>
{
    internal static readonly EnvironmentVariableEnums Email = Define("ClickTimeClient:Email");
    internal static readonly EnvironmentVariableEnums Password = Define("ClickTimeClient:Password");
    internal static readonly EnvironmentVariableEnums AuthToken = Define("ClickTimeClient:AuthToken");
    internal static readonly EnvironmentVariableEnums AllowedHosts = Define("ClickTimeClient:AllowedHosts");
}