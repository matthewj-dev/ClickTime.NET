using ClickTime.NET.Enums;
using ClickTime.NET.ExtensionMethods;
using ClickTime.NET.Models.Authorization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using static Microsoft.Kiota.Abstractions.Authentication.ApiKeyAuthenticationProvider.KeyLocation;

namespace ClickTime.NET.HelperMethods;

/// <summary>
/// Helper methods for creating ClickTimeClient objects. See table below for relevant environment variables.
/// 
///     <list type="table">
///         <listheader>
///             <term>Description</term>
///             <description>Environment Variable Key</description>
///             <default>Default if not present</default>
///         </listheader>
///         <item>
///             <term>Email</term>
///             <description>ClickTimeClient:Email</description>
///             <default></default>
///         </item>
///         <item>
///             <term>Password</term>
///             <description>ClickTimeClient:Password</description>
///             <default></default>
///         </item>
///         <item>
///             <term>API AuthToken</term>
///             <description>ClickTimeClient:AuthToken</description>
///             <default>Uses (Basic email:password[Base64])</default>
///         </item>
///         <item>
///             <term>AllowedHosts</term>
///             <description>ClickTimeClient:AllowedHosts</description>
///             <default>api.clicktime.com</default>
///         </item>
///     </list>
/// 
/// Create methods with specific parameters override these.
/// </summary>
public static class ClickTimeClientHelper
{
    private static string? Email => EnvironmentHelper.GetEnvironmentVariable(EnvironmentVariableEnums.Email);
    private static string? Password => EnvironmentHelper.GetEnvironmentVariable(EnvironmentVariableEnums.Password);
    private static string? AuthToken => EnvironmentHelper.GetEnvironmentVariable(EnvironmentVariableEnums.AuthToken);
    private static string[] AllowedHosts => EnvironmentHelper.GetEnvironmentVariable(EnvironmentVariableEnums.AllowedHosts)
                                                ?.Split(',') 
                                                ?? ["api.clicktime.com"];
    private static string AuthHeaderValue => $"{(AuthToken is not null ? "Token" : "Basic")} {AuthToken ?? $"{Email}:{Password}".Base64Encode()}";
    
    /// <summary>
    /// Creates a ClickTimeClient by directly passing in a request adapter.
    /// Useful for unit test mocking and fixing change in authentication scheme.
    /// </summary>
    /// <param name="requestAdapter">An object that implements IRequestAdapter</param>
    /// <returns>A new ClickTimeClient</returns>
    public static ClickTimeClient Create(IRequestAdapter requestAdapter) => new(requestAdapter);

    /// <summary>
    /// Creates a ClickTimeClient by directly passing in a IAuthenticationProvider.
    /// Uses HttpClientRequestAdapter by default.
    /// </summary>
    /// <param name="authenticationProvider">Custom authentication provider</param>
    /// <returns>A new ClickTimeClient</returns>
    public static ClickTimeClient Create(IAuthenticationProvider authenticationProvider)
    {
        HttpClientRequestAdapter adapter = new(authenticationProvider);
        
        return new(adapter);
    }
    
    /// <summary>
    /// Creates a new ClickTimeClient by using environment variables.
    /// </summary>
    /// <returns>A new ClickTimeClient</returns>
    public static ClickTimeClient Create()
    {
        ApiKeyAuthenticationProvider auth = new(
            AuthHeaderValue
            , "Authorization"
            , Header
            , AllowedHosts);
        
        return Create(auth);
    }
    
    /// <summary>
    /// Creates a new ClickTimeClient by using API Kky/token, along with an allowedHosts environment variable.
    /// </summary>
    /// <param name="token">An API Token from ClickTime</param>
    /// <returns>A new ClickTimeClient</returns>
    public static ClickTimeClient CreateWithToken(string token)
    {
        ApiKeyAuthenticationProvider auth = new(
            $"Token {token}"
            , "Authorization"
            , Header
            , AllowedHosts);
        
        return Create(auth);
    }
    
    /// <summary>
    /// Creates a new ClickTimeClient by using API Kky/token, along with an allowedHosts environment variable.
    /// </summary>
    /// <param name="token">An API Token from ClickTime</param>
    /// <returns>A new ClickTimeClient</returns>
    public static ClickTimeClient Create(ApiToken token)
    {
        ApiKeyAuthenticationProvider auth = new(
            $"Token {token.Token}"
            , "Authorization"
            , Header
            , AllowedHosts);

        return Create(auth);
    }
    
    /// <summary>
    /// Creates a new ClickTimeClient by using API Kky/token, and any number of allowedHosts.
    /// </summary>
    /// <example>ClickTimeClientHelper.Create(token: new("402880824ff933a4014ff9345d7c0002"), "api.clicktime.com")</example>
    /// <example>ClickTimeClientHelper.Create(token:: new("402880824ff933a4014ff9345d7c0002"), "api.clicktime.com", "developer.clicktime.com", ...)</example>
    /// <param name="token">An API Token from ClickTime</param>
    /// <param name="allowedHosts">Any number of host strings</param>
    /// <returns>A new ClickTimeClient</returns>
    public static ClickTimeClient Create(ApiToken token, params string[] allowedHosts)
    {
        ApiKeyAuthenticationProvider auth = new(
            $"Token {token.Token}"
            , "Authorization"
            , Header
            , allowedHosts);

        return Create(auth);
    }

    /// <summary>
    /// Creates a new ClickTimeClient by using email and password, along with an allowedHosts environment variable.
    /// </summary>
    /// <param name="email">Your ClickTime username</param>
    /// <param name="password">Your ClickTime password</param>
    /// <returns>A new ClickTimeClient</returns>
    public static ClickTimeClient CreateWithLogin(string email, string password)
    {
        ApiKeyAuthenticationProvider auth = new(
            $"Basic {$"{email}:{password}".Base64Encode()}"
            , "Authorization"
            , Header
            , AllowedHosts);

        return Create(auth);
    }
    
    /// <summary>
    /// Creates a new ClickTimeClient by using email and password, along with an allowedHosts environment variable.
    /// </summary>
    /// <param name="basic">Your ClickTime username and password</param>
    /// <returns>A new ClickTimeClient</returns>
    public static ClickTimeClient Create(Basic basic)
    {
        ApiKeyAuthenticationProvider auth = new(
            $"Basic {$"{basic.Email}:{basic.Password}".Base64Encode()}"
            , "Authorization"
            , Header
            , AllowedHosts);

        return Create(auth);
    }
    
    /// <summary>
    /// Creates a new ClickTimeClient by using email and password, and any number of allowedHosts.
    /// </summary>
    /// <example>ClickTimeClientHelper.Create(basic: new("example@gmail.com", "Password1!"), "api.clicktime.com")</example>
    /// <example>ClickTimeClientHelper.Create(basic:: new("example@gmail.com", "Password1!"), "api.clicktime.com", "developer.clicktime.com", ...)</example>
    /// <param name="basic">Your ClickTime username and password</param>
    /// <param name="allowedHosts">Any number of host strings</param>
    /// <returns>A new ClickTimeClient</returns>
    public static ClickTimeClient Create(Basic basic, params string[] allowedHosts)
    {
        ApiKeyAuthenticationProvider auth = new(
            $"Basic {$"{basic.Email}:{basic.Password}".Base64Encode()}"
            , "Authorization"
            , Header
            , allowedHosts);

        return Create(auth);
    }
}