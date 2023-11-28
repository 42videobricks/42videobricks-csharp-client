# Api42Vb.Api.DataApi

All URIs are relative to *https://api-sbx.42videobricks.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDataVideoUsage**](DataApi.md#getdatavideousage) | **GET** /data/videos/usage | List Video Usage KPIs |

<a id="getdatavideousage"></a>
# **GetDataVideoUsage**
> DataVideoUsageList GetDataVideoUsage (int? limit = null, int? offset = null, string? interval = null, string? startDate = null, string? endDate = null)

List Video Usage KPIs

Return the usage of the platform ressources.  By default, it returns monthly usage but unit (dayly|week|month) can be defined. For current period, usage is calculated until current time. Start and end dates can be also optionaly defined to filter results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetDataVideoUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DataApi(config);
            var limit = 56;  // int? | Number of elements to return (default=10) (optional) 
            var offset = 56;  // int? | offset for pagination (optional) 
            var interval = {{interval}};  // string? | Period unit (day|week|month) (optional) 
            var startDate = {{starDate}};  // string? | Start date for the period (optional) 
            var endDate = {{endDate}};  // string? | End date for the period (optional) 

            try
            {
                // List Video Usage KPIs
                DataVideoUsageList result = apiInstance.GetDataVideoUsage(limit, offset, interval, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataApi.GetDataVideoUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataVideoUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Video Usage KPIs
    ApiResponse<DataVideoUsageList> response = apiInstance.GetDataVideoUsageWithHttpInfo(limit, offset, interval, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataApi.GetDataVideoUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Number of elements to return (default&#x3D;10) | [optional]  |
| **offset** | **int?** | offset for pagination | [optional]  |
| **interval** | **string?** | Period unit (day|week|month) | [optional]  |
| **startDate** | **string?** | Start date for the period | [optional]  |
| **endDate** | **string?** | End date for the period | [optional]  |

### Return type

[**DataVideoUsageList**](DataVideoUsageList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of monthly usage KPIs |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

