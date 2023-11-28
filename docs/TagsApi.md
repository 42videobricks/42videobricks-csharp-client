# Api42Vb.Api.TagsApi

All URIs are relative to *https://api-sbx.42videobricks.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTags**](TagsApi.md#gettags) | **GET** /tags | List Video Tags |

<a id="gettags"></a>
# **GetTags**
> TagList GetTags (int? limit = null, int? offset = null, string? partial = null)

List Video Tags

Return the list of tags created and set to videos

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TagsApi(config);
            var limit = 56;  // int? | Number of elements to return (default=10) (optional) 
            var offset = 56;  // int? | offset for pagination (optional) 
            var partial = {{partial}};  // string? | \\'partial\\' string to filter list (optional) 

            try
            {
                // List Video Tags
                TagList result = apiInstance.GetTags(limit, offset, partial);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.GetTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Video Tags
    ApiResponse<TagList> response = apiInstance.GetTagsWithHttpInfo(limit, offset, partial);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagsApi.GetTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Number of elements to return (default&#x3D;10) | [optional]  |
| **offset** | **int?** | offset for pagination | [optional]  |
| **partial** | **string?** | \\&#39;partial\\&#39; string to filter list | [optional]  |

### Return type

[**TagList**](TagList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of video tags |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

