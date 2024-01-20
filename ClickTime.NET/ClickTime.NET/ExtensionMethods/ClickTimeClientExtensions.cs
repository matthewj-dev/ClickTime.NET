using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using static Microsoft.Kiota.Abstractions.Authentication.ApiKeyAuthenticationProvider.KeyLocation;

namespace ClickTime.NET.ExtensionMethods;

internal static class ClickTimeClientExtensions
{
    public static ClickTimeClient Create(string token, string allowedHost = "api.clicktime.com")
    {
        ApiKeyAuthenticationProvider auth = new(
            $"Token {token}"
            , "Authorization"
            , Header
            , allowedHost);

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