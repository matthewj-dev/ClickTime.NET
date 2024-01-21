namespace ClickTime.NET.Models.Authorization;

public readonly record struct ApiToken(string Token);
public readonly record struct Basic(string Email, string Password);
