using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using static Microsoft.Kiota.Abstractions.Authentication.ApiKeyAuthenticationProvider.KeyLocation;

namespace ClickTime.NET.Tests;

public class UnitTest1
{
    [Fact]
    public async void Test1()
    {
        var auth = new ApiKeyAuthenticationProvider(
            "Token "
            , "Authorization"
            , Header
            , "api.clicktime.com");

        var adapter = new HttpClientRequestAdapter(auth);
        
        var client = new ClickTimeClient(adapter);

        var me = await client.Me.GetAsync();
        
        Assert.NotNull(me);
    }
}