# ApsNET.Api.AuthenticateApi

All URIs are relative to *https://developer.api.autodesk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthenticationV1AuthenticatePost**](AuthenticateApi.md#authenticationv1authenticatepost) | **POST** /authentication/v1/authenticate | Get a two-legged access token by providing your app’s client ID and secret.



## AuthenticationV1AuthenticatePost

> Bearer AuthenticationV1AuthenticatePost (string clientId, string clientSecret, string grantType, string scopes = null)

Get a two-legged access token by providing your app’s client ID and secret.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ApsNET.Api;
using ApsNET.Client;
using ApsNET.Model;

namespace Example
{
    public class AuthenticationV1AuthenticatePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://developer.api.autodesk.com";
            var apiInstance = new AuthenticateApi(Configuration.Default);
            var clientId = clientId_example;  // string | Client ID of the app
            var clientSecret = clientSecret_example;  // string | Client secret of the app
            var grantType = grantType_example;  // string | Must be client_credentials (default to "client_credentials")
            var scopes = scopes_example;  // string | Space-separated list of required scopes Note: A URL-encoded space is %20. * See the [Scopes](https://aps.autodesk.com/en/docs/oauth/v1/overview/scopes) page for more information on when scopes are required.  (optional) 

            try
            {
                // Get a two-legged access token by providing your app’s client ID and secret.
                Bearer result = apiInstance.AuthenticationV1AuthenticatePost(clientId, clientSecret, grantType, scopes);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticateApi.AuthenticationV1AuthenticatePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Client ID of the app | 
 **clientSecret** | **string**| Client secret of the app | 
 **grantType** | **string**| Must be client_credentials | [default to &quot;client_credentials&quot;]
 **scopes** | **string**| Space-separated list of required scopes Note: A URL-encoded space is %20. * See the [Scopes](https://aps.autodesk.com/en/docs/oauth/v1/overview/scopes) page for more information on when scopes are required.  | [optional] 

### Return type

[**Bearer**](Bearer.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/x-www-form-urlencoded
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful request; access token returned. |  -  |
| **400** | One or more parameters are invalid. Examine the response payload body for details. |  -  |
| **401** | The client_id and client_secret combination is not valid. |  -  |
| **403** | The client_id is not authorized to access this endpoint. |  -  |
| **405** | The Content-Type header is missing or specifies a value other than application/x-www-form-urlencoded. |  -  |
| **409** | Rate limit exceeded; wait some time before retrying. |  -  |
| **500** | Generic internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

