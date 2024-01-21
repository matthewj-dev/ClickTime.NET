# ClickTime.NET
.NET wrapper for Web API @ https://developer.clicktime.com/docs/api/

## Why do this?

Because I wanted to experiment with creating some sort of SDK for some public API
using their openapi/swagger spec.

## What was done

Using Kiota (https://learn.microsoft.com/en-us/openapi/kiota/) to generate a CSharp
interface for the API. Then adding a light wrapper around that to make a few things 
nicer. As I use more endpoints I will try to add more unit tests.

## How to use

### Direct Access

I have left the generated code public, so you can directly call it like so:

#### Direct Access Example

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using static Microsoft.Kiota.Abstractions.Authentication.ApiKeyAuthenticationProvider;

var token = "402880824ff933a4014ff9345d7c0002";

ApiKeyAuthenticationProvider auth = new(
    $"Token {token}"
    , "Authorization"
    , KeyLocation.Header
    , "api.clicktime.com");

HttpClientRequestAdapter adapter = new(auth);

ClickTimeClient client = new(adapter);

try
{
    var me = await client.Me.GetAsync();

    Console.WriteLine(me.Data.Email);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
```

### Using Helper Methods

However, I have also added some wrapper methods in `ClickTimeClientHelper` under namespace `ClickTime.NET.HelperMethods`.

#### Helper Method Example

```csharp
var client = ClickTimeClientHelper.CreateWithToken("402880824ff933a4014ff9345d7c0002");

try
{
    var me = await client.Me.GetAsync();
    Console.WriteLine(me.Data.Email);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
```

#### Environment Variables

The wrapper methods can also use environment variables
when not provided engough information directly via method calling.

| Description   	 | Environment Variable Key     	 | Default if not present              	 | Example                                                                     	 |
|-----------------|--------------------------------|---------------------------------------|-------------------------------------------------------------------------------|
| Email         	 | ClickTimeClient:Email        	 | 	                                     | ClickTimeClient:Email=example@gmail.com                                     	 |
| Password      	 | ClickTimeClient:Password     	 | 	                                     | ClickTimeClient:Password=123Password!                                       	 |
| API AuthToken 	 | ClickTimeClient:AuthToken    	 | Uses (Basic email:password[Base64]) 	 | ClickTimeClient:AuthToken=1kj2k3j2923i1k2j3l1k2j31k2j3                      	 |
| AllowedHosts  	 | ClickTimeClient:AllowedHosts 	 | api.clicktime.com                   	 | ClickTimeClient:AllowedHosts=api.clicktime.com,google.com,otherHostName.com 	 |