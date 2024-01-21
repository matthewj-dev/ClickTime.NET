using ClickTime.NET.Enums;
using ClickTime.NET.ExtensionMethods;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using static Microsoft.Kiota.Abstractions.Authentication.ApiKeyAuthenticationProvider.KeyLocation;

namespace ClickTime.NET.HelperMethods;

public static class ClickTimeClientHelper
{
    private static string? Email => Environment.GetEnvironmentVariable(EnvironmentVariableEnums.Email.ToString());
    private static string? Password => Environment.GetEnvironmentVariable(EnvironmentVariableEnums.Password.ToString());
    private static string? AuthToken => Environment.GetEnvironmentVariable(EnvironmentVariableEnums.AuthToken.ToString());
    private static string[] AllowedHosts => Environment.GetEnvironmentVariable(EnvironmentVariableEnums.AllowedHosts.ToString())
                                                ?.Split(',') 
                                                ?? Array.Empty<string>();
    private static string ApiKey => $"{(AuthToken is not null ? "Token" : "Basic")} {AuthToken ?? $"{Email}:{Password}".Base64Encode()}";
    
    public static ClickTimeClient Create(IRequestAdapter requestAdapter) => new ClickTimeClient(requestAdapter);
    
    public static ClickTimeClient Create()
    {
        ApiKeyAuthenticationProvider auth = new(
            ApiKey
            , "Authorization"
            , Header
            , AllowedHosts);

        HttpClientRequestAdapter adapter = new(auth);
        
        return new ClickTimeClient(adapter);
    }
    
    public static ClickTimeClient Create(string email, string password)
    {
        ApiKeyAuthenticationProvider auth = new(
            $"Basic {$"{email}:{password}".Base64Encode()}"
            , "Authorization"
            , Header
            , AllowedHosts);

        HttpClientRequestAdapter adapter = new(auth);
        
        return new ClickTimeClient(adapter);
    }
    
    public static ClickTimeClient Create(string token)
    {
        ApiKeyAuthenticationProvider auth = new(
            $"Token {token}"
            , "Authorization"
            , Header
            , AllowedHosts);

        HttpClientRequestAdapter adapter = new(auth);
        
        return new ClickTimeClient(adapter);
    }
    
    public static ClickTimeClient Create(string email, string password, params string[] allowedHosts)
    {
        ApiKeyAuthenticationProvider auth = new(
            $"Basic {$"{email}:{password}".Base64Encode()}"
            , "Authorization"
            , Header
            , allowedHosts);

        HttpClientRequestAdapter adapter = new(auth);
        
        return new ClickTimeClient(adapter);
    }
    
    public static ClickTimeClient Create(string token, params string[] allowedHosts)
    {
        ApiKeyAuthenticationProvider auth = new(
            $"Token {token}"
            , "Authorization"
            , Header
            , allowedHosts);

        HttpClientRequestAdapter adapter = new(auth);
        
        return new ClickTimeClient(adapter);
    }
}