# Api42Vb.Api.WebhooksApi

All URIs are relative to *https://api-sbx.42videobricks.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddWebhook**](WebhooksApi.md#addwebhook) | **POST** /webhooks | Add a new webhook |
| [**DeleteWebhookById**](WebhooksApi.md#deletewebhookbyid) | **DELETE** /webhooks/{webhookId} | Delete a webhook |
| [**GetWebhookById**](WebhooksApi.md#getwebhookbyid) | **GET** /webhooks/{webhookId} | Retun a single webhook |
| [**GetWebhooks**](WebhooksApi.md#getwebhooks) | **GET** /webhooks | List webhooks |
| [**UpdateWebhookById**](WebhooksApi.md#updatewebhookbyid) | **PUT** /webhooks/{webhookId} | Update an existing webhook |

<a id="addwebhook"></a>
# **AddWebhook**
> Webhook AddWebhook (WebhookProperties webhookProperties)

Add a new webhook

Create a new webhook to configure notification.  Only one hook per url

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class AddWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var webhookProperties = new WebhookProperties(); // WebhookProperties | 

            try
            {
                // Add a new webhook
                Webhook result = apiInstance.AddWebhook(webhookProperties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.AddWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new webhook
    ApiResponse<Webhook> response = apiInstance.AddWebhookWithHttpInfo(webhookProperties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.AddWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookProperties** | [**WebhookProperties**](WebhookProperties.md) |  |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Webhook Created |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletewebhookbyid"></a>
# **DeleteWebhookById**
> void DeleteWebhookById (string webhookId)

Delete a webhook

Delete a webhook.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class DeleteWebhookByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var webhookId = {{webhookId}};  // string | Id of the webhook

            try
            {
                // Delete a webhook
                apiInstance.DeleteWebhookById(webhookId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhookById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhookByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a webhook
    apiInstance.DeleteWebhookByIdWithHttpInfo(webhookId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.DeleteWebhookByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **string** | Id of the webhook |  |

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Webhook Deleted |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwebhookbyid"></a>
# **GetWebhookById**
> Webhook GetWebhookById (string webhookId)

Retun a single webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetWebhookByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var webhookId = {{webhookId}};  // string | Id of the webhook

            try
            {
                // Retun a single webhook
                Webhook result = apiInstance.GetWebhookById(webhookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhookById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhookByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retun a single webhook
    ApiResponse<Webhook> response = apiInstance.GetWebhookByIdWithHttpInfo(webhookId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.GetWebhookByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **string** | Id of the webhook |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested webhook |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwebhooks"></a>
# **GetWebhooks**
> WebhookList GetWebhooks (int? limit = null, int? offset = null)

List webhooks

Return the list of webhooks.  Return an empty list it there are no webhook to return.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var limit = 56;  // int? | Number of elements to return (default=10) (optional) 
            var offset = 56;  // int? | offset for pagination (optional) 

            try
            {
                // List webhooks
                WebhookList result = apiInstance.GetWebhooks(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List webhooks
    ApiResponse<WebhookList> response = apiInstance.GetWebhooksWithHttpInfo(limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.GetWebhooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Number of elements to return (default&#x3D;10) | [optional]  |
| **offset** | **int?** | offset for pagination | [optional]  |

### Return type

[**WebhookList**](WebhookList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of webhooks |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewebhookbyid"></a>
# **UpdateWebhookById**
> Webhook UpdateWebhookById (string webhookId, WebhookProperties webhookProperties)

Update an existing webhook

Update a existing webhooks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class UpdateWebhookByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var webhookId = {{webhookId}};  // string | Id of the webhook
            var webhookProperties = new WebhookProperties(); // WebhookProperties | 

            try
            {
                // Update an existing webhook
                Webhook result = apiInstance.UpdateWebhookById(webhookId, webhookProperties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.UpdateWebhookById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWebhookByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing webhook
    ApiResponse<Webhook> response = apiInstance.UpdateWebhookByIdWithHttpInfo(webhookId, webhookProperties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.UpdateWebhookByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **string** | Id of the webhook |  |
| **webhookProperties** | [**WebhookProperties**](WebhookProperties.md) |  |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhook Updated |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

