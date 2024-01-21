using StrEnum;

namespace ClickTime.NET.Enums;

public class EnvironmentVariableEnums : StringEnum<EnvironmentVariableEnums>
{
    public static readonly EnvironmentVariableEnums Email = Define("ClickTimeClient:Email");
    public static readonly EnvironmentVariableEnums Password = Define("ClickTimeClient:Password");
    public static readonly EnvironmentVariableEnums AuthToken = Define("ClickTimeClient:AuthToken");
    public static readonly EnvironmentVariableEnums AllowedHosts = Define("ClickTimeClient:AllowedHosts");
}