using UserAuthTokenModel = ClickTime.NET.Models.ResponseBodyGet.UserAuthTokenModel;
using UserModel_Me = ClickTime.NET.Models.ResponseBodyGet.UserModel_Me;

namespace ClickTime.NET.Tests;

public class MeTests
{
    [Fact]
    public async void Get_Current_User()
    {
        var adapter = Substitute.For<IRequestAdapter>();
        var client = ClickTimeClientHelper.Create(adapter);

        var expectedMe = new UserModel_Me()
        {
            Data = new Models.Get.UserModel_Me(){ EmployeeNumber = "12345"}
        };

        adapter.SendAsync(Arg.Any<RequestInformation>()
                , Arg.Any<ParsableFactory<Models.ResponseBodyGet.UserModel_Me>>()
                , Arg.Any<Dictionary<string, ParsableFactory<IParsable>>>(),
                Arg.Any<CancellationToken>())
            .Returns(expectedMe);
        
        var me = await client.Me.GetAsync();

        
        Assert.NotNull(me);
        Assert.NotNull(me.Data);
        Assert.Equal(expectedMe.Data.EmployeeNumber, me.Data.EmployeeNumber);
    }
    
    [Fact]
    public async void Patch_Update_Current_User()
    {
        var adapter = Substitute.For<IRequestAdapter>();
        var client = ClickTimeClientHelper.Create(adapter);
        
        var expectedMe = new UserModel_Me()
        {
            Data = new Models.Get.UserModel_Me(){ Name = "Alice"}
        };

        var request = new Models.Patch.UserModel_Me
        {
            Name = expectedMe.Data.Name
        };

        adapter.SendAsync(Arg.Any<RequestInformation>()
                , Arg.Any<ParsableFactory<Models.ResponseBodyGet.UserModel_Me>>()
                , Arg.Any<Dictionary<string, ParsableFactory<IParsable>>>(),
                Arg.Any<CancellationToken>())
            .Returns(expectedMe);
        
        var me = await client.Me.PatchAsync(request);
        
        Assert.NotNull(me);
        Assert.NotNull(me.Data);
        Assert.Equal(expectedMe.Data.Name, me.Data.Name);
    }
    
    [Fact]
    public async void Reset_Auth_Token()
    {
        var adapter = Substitute.For<IRequestAdapter>();
        var client = ClickTimeClientHelper.Create(adapter);

        var expectedResponse = new UserAuthTokenModel()
        {
            Data = new Models.Get.UserAuthTokenModel() { Token = Guid.NewGuid().ToString() }
        };

        adapter.SendAsync(Arg.Any<RequestInformation>()
                , Arg.Any<ParsableFactory<UserAuthTokenModel>>()
                , Arg.Any<Dictionary<string, ParsableFactory<IParsable>>>(),
                Arg.Any<CancellationToken>())
            .Returns(expectedResponse);

        var userAuthTokenResetResponse = await client.Me.ResetAuthToken.PostAsync();
        
        Assert.NotNull(userAuthTokenResetResponse);
        Assert.NotNull(userAuthTokenResetResponse.Data);
        Assert.Equal(expectedResponse.Data.Token, userAuthTokenResetResponse.Data.Token);
    }
}