# Api42Vb.Api.VideosApi

All URIs are relative to *https://api-sbx.42videobricks.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAttachmentByVideoId**](VideosApi.md#addattachmentbyvideoid) | **POST** /videos/{videoId}/attachments/{attachmentType}/{locale} | Upload an attachement |
| [**AddThumbnailByVideoId**](VideosApi.md#addthumbnailbyvideoid) | **POST** /videos/{videoId}/thumbnail | Upload a thumbnail |
| [**AddVideo**](VideosApi.md#addvideo) | **POST** /videos | Add a new video |
| [**DeleteAttachmentByVideoId**](VideosApi.md#deleteattachmentbyvideoid) | **DELETE** /videos/{videoId}/attachments/{attachmentType}/{locale} | Delete an attachment |
| [**DeleteThumbnailByVideoId**](VideosApi.md#deletethumbnailbyvideoid) | **DELETE** /videos/{videoId}/thumbnail | Delete a thumbnail |
| [**DeleteVideoById**](VideosApi.md#deletevideobyid) | **DELETE** /videos/{videoId} | Delete a video |
| [**FinalizeMultipartUploadVideoById**](VideosApi.md#finalizemultipartuploadvideobyid) | **POST** /videos/{videoId}/multipart-upload/finalize | Multipart upload finalization |
| [**FinalizeUploadVideoById**](VideosApi.md#finalizeuploadvideobyid) | **PUT** /videos/{videoId}/upload/finalize | Single file upload finalization |
| [**GetAttachmentByVideoId**](VideosApi.md#getattachmentbyvideoid) | **GET** /videos/{videoId}/attachments/{attachmentType}/{locale} | Get the attachment |
| [**GetAttachmentFileByVideoId**](VideosApi.md#getattachmentfilebyvideoid) | **GET** /videos/{videoId}/attachments/{attachmentType}/{locale}/file | Get attachement file |
| [**GetAttachmentsByVideoId**](VideosApi.md#getattachmentsbyvideoid) | **GET** /videos/{videoId}/attachments | List of attachments |
| [**GetVideoById**](VideosApi.md#getvideobyid) | **GET** /videos/{videoId} | Retun a single video |
| [**GetVideoStatusById**](VideosApi.md#getvideostatusbyid) | **GET** /videos/{videoId}/status | Retun the detailed status of the video |
| [**GetVideos**](VideosApi.md#getvideos) | **GET** /videos | List videos |
| [**InitMultipartUploadVideoById**](VideosApi.md#initmultipartuploadvideobyid) | **POST** /videos/{videoId}/multipart-upload/init | Multipart upload intialization |
| [**InitUploadVideoById**](VideosApi.md#inituploadvideobyid) | **GET** /videos/{videoId}/upload/init | Single file upload intialization |
| [**UpdateVideoById**](VideosApi.md#updatevideobyid) | **PUT** /videos/{videoId} | Update an existing video |

<a id="addattachmentbyvideoid"></a>
# **AddAttachmentByVideoId**
> void AddAttachmentByVideoId (string videoId, string attachmentType, string locale, System.IO.Stream? file = null)

Upload an attachement

Upload an attachement file and attached it to a video Currently: - attachement file type is limited to \"subtitle\" and \"caption\" (close caption) - supported file types: SRT (text/plain), VTT (text/vtt)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class AddAttachmentByVideoIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video
            var attachmentType = {{attachmentType}};  // string | Type of attachment
            var locale = {{locale}};  // string | Le locale value of the attachment
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? | The file to upload (optional) 

            try
            {
                // Upload an attachement
                apiInstance.AddAttachmentByVideoId(videoId, attachmentType, locale, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.AddAttachmentByVideoId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAttachmentByVideoIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload an attachement
    apiInstance.AddAttachmentByVideoIdWithHttpInfo(videoId, attachmentType, locale, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.AddAttachmentByVideoIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |
| **attachmentType** | **string** | Type of attachment |  |
| **locale** | **string** | Le locale value of the attachment |  |
| **file** | **System.IO.Stream?****System.IO.Stream?** | The file to upload | [optional]  |

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | File Accepted |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addthumbnailbyvideoid"></a>
# **AddThumbnailByVideoId**
> void AddThumbnailByVideoId (string videoId, System.IO.Stream? file = null)

Upload a thumbnail

Upload an image file and set it as Thumbnail to the video

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class AddThumbnailByVideoIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? | The file to upload (optional) 

            try
            {
                // Upload a thumbnail
                apiInstance.AddThumbnailByVideoId(videoId, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.AddThumbnailByVideoId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddThumbnailByVideoIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a thumbnail
    apiInstance.AddThumbnailByVideoIdWithHttpInfo(videoId, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.AddThumbnailByVideoIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |
| **file** | **System.IO.Stream?****System.IO.Stream?** | The file to upload | [optional]  |

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image file accepted |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addvideo"></a>
# **AddVideo**
> Video AddVideo (VideoProperties videoProperties)

Add a new video

You can create a video object by using this endpoint.  Once the video is created you can then upload the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class AddVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoProperties = new VideoProperties(); // VideoProperties | 

            try
            {
                // Add a new video
                Video result = apiInstance.AddVideo(videoProperties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.AddVideo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddVideoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new video
    ApiResponse<Video> response = apiInstance.AddVideoWithHttpInfo(videoProperties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.AddVideoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoProperties** | [**VideoProperties**](VideoProperties.md) |  |  |

### Return type

[**Video**](Video.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Video Created |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteattachmentbyvideoid"></a>
# **DeleteAttachmentByVideoId**
> void DeleteAttachmentByVideoId (string videoId, string attachmentType, string locale)

Delete an attachment

Delete an attachment (and the attached file)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class DeleteAttachmentByVideoIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video
            var attachmentType = {{attachmentType}};  // string | Type of attachment
            var locale = {{locale}};  // string | Le locale value of the attachment

            try
            {
                // Delete an attachment
                apiInstance.DeleteAttachmentByVideoId(videoId, attachmentType, locale);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.DeleteAttachmentByVideoId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAttachmentByVideoIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an attachment
    apiInstance.DeleteAttachmentByVideoIdWithHttpInfo(videoId, attachmentType, locale);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.DeleteAttachmentByVideoIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |
| **attachmentType** | **string** | Type of attachment |  |
| **locale** | **string** | Le locale value of the attachment |  |

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
| **204** | empty content |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletethumbnailbyvideoid"></a>
# **DeleteThumbnailByVideoId**
> void DeleteThumbnailByVideoId (string videoId)

Delete a thumbnail

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class DeleteThumbnailByVideoIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video

            try
            {
                // Delete a thumbnail
                apiInstance.DeleteThumbnailByVideoId(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.DeleteThumbnailByVideoId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteThumbnailByVideoIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a thumbnail
    apiInstance.DeleteThumbnailByVideoIdWithHttpInfo(videoId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.DeleteThumbnailByVideoIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |

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
| **204** | Thumbnail deleted |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletevideobyid"></a>
# **DeleteVideoById**
> void DeleteVideoById (string videoId)

Delete a video

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class DeleteVideoByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video

            try
            {
                // Delete a video
                apiInstance.DeleteVideoById(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.DeleteVideoById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteVideoByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a video
    apiInstance.DeleteVideoByIdWithHttpInfo(videoId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.DeleteVideoByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |

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
| **204** | Video Deleted |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="finalizemultipartuploadvideobyid"></a>
# **FinalizeMultipartUploadVideoById**
> void FinalizeMultipartUploadVideoById (string videoId, VideoMultipartUploadFinalize? videoMultipartUploadFinalize = null)

Multipart upload finalization

Once video parts are uploaded, finalize the upload by requesting to transcode the file.  New video file is replacing previous video file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class FinalizeMultipartUploadVideoByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video
            var videoMultipartUploadFinalize = new VideoMultipartUploadFinalize?(); // VideoMultipartUploadFinalize? |  (optional) 

            try
            {
                // Multipart upload finalization
                apiInstance.FinalizeMultipartUploadVideoById(videoId, videoMultipartUploadFinalize);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.FinalizeMultipartUploadVideoById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinalizeMultipartUploadVideoByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Multipart upload finalization
    apiInstance.FinalizeMultipartUploadVideoByIdWithHttpInfo(videoId, videoMultipartUploadFinalize);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.FinalizeMultipartUploadVideoByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |
| **videoMultipartUploadFinalize** | [**VideoMultipartUploadFinalize?**](VideoMultipartUploadFinalize?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Upload Accepted |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="finalizeuploadvideobyid"></a>
# **FinalizeUploadVideoById**
> void FinalizeUploadVideoById (string videoId)

Single file upload finalization

Once video file is uploaded, finalize the upload by requesting to transcode the file. Finalize apply to the last signedurl provided by the upload initialization.  New video file is replacing previous video file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class FinalizeUploadVideoByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video

            try
            {
                // Single file upload finalization
                apiInstance.FinalizeUploadVideoById(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.FinalizeUploadVideoById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinalizeUploadVideoByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Single file upload finalization
    apiInstance.FinalizeUploadVideoByIdWithHttpInfo(videoId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.FinalizeUploadVideoByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |

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
| **202** | Upload Accepted |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getattachmentbyvideoid"></a>
# **GetAttachmentByVideoId**
> void GetAttachmentByVideoId (string videoId, string attachmentType, string locale)

Get the attachment

Get a video attachement object

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetAttachmentByVideoIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video
            var attachmentType = {{attachmentType}};  // string | Type of attachment
            var locale = {{locale}};  // string | Le locale value of the attachment

            try
            {
                // Get the attachment
                apiInstance.GetAttachmentByVideoId(videoId, attachmentType, locale);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.GetAttachmentByVideoId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttachmentByVideoIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the attachment
    apiInstance.GetAttachmentByVideoIdWithHttpInfo(videoId, attachmentType, locale);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.GetAttachmentByVideoIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |
| **attachmentType** | **string** | Type of attachment |  |
| **locale** | **string** | Le locale value of the attachment |  |

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
| **200** | video attachement object |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getattachmentfilebyvideoid"></a>
# **GetAttachmentFileByVideoId**
> void GetAttachmentFileByVideoId (string videoId, string attachmentType, string locale)

Get attachement file

Get the attachement file Currently only text/plain files are handled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetAttachmentFileByVideoIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video
            var attachmentType = {{attachmentType}};  // string | Type of attachment
            var locale = {{locale}};  // string | Le locale value of the attachment

            try
            {
                // Get attachement file
                apiInstance.GetAttachmentFileByVideoId(videoId, attachmentType, locale);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.GetAttachmentFileByVideoId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttachmentFileByVideoIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get attachement file
    apiInstance.GetAttachmentFileByVideoIdWithHttpInfo(videoId, attachmentType, locale);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.GetAttachmentFileByVideoIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |
| **attachmentType** | **string** | Type of attachment |  |
| **locale** | **string** | Le locale value of the attachment |  |

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
| **200** | Attachement file |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getattachmentsbyvideoid"></a>
# **GetAttachmentsByVideoId**
> VideoAttachmentList GetAttachmentsByVideoId (string videoId, string? attachmentType = null, string? locale = null, int? limit = null, int? offset = null)

List of attachments

Return a list of attachments to a videos

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetAttachmentsByVideoIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video
            var attachmentType = "caption";  // string? | The type of attachments (optional) 
            var locale = "locale_example";  // string? | The locale (optional) 
            var limit = 56;  // int? | Number of elements to return (default=10) (optional) 
            var offset = 56;  // int? | offset for pagination (optional) 

            try
            {
                // List of attachments
                VideoAttachmentList result = apiInstance.GetAttachmentsByVideoId(videoId, attachmentType, locale, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.GetAttachmentsByVideoId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttachmentsByVideoIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of attachments
    ApiResponse<VideoAttachmentList> response = apiInstance.GetAttachmentsByVideoIdWithHttpInfo(videoId, attachmentType, locale, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.GetAttachmentsByVideoIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |
| **attachmentType** | **string?** | The type of attachments | [optional]  |
| **locale** | **string?** | The locale | [optional]  |
| **limit** | **int?** | Number of elements to return (default&#x3D;10) | [optional]  |
| **offset** | **int?** | offset for pagination | [optional]  |

### Return type

[**VideoAttachmentList**](VideoAttachmentList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of attachments |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getvideobyid"></a>
# **GetVideoById**
> Video GetVideoById (string videoId, bool? token = null)

Retun a single video

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetVideoByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video
            var token = true;  // bool? | add a token to assets to alloaw access to private video (optional) 

            try
            {
                // Retun a single video
                Video result = apiInstance.GetVideoById(videoId, token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.GetVideoById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVideoByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retun a single video
    ApiResponse<Video> response = apiInstance.GetVideoByIdWithHttpInfo(videoId, token);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.GetVideoByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |
| **token** | **bool?** | add a token to assets to alloaw access to private video | [optional]  |

### Return type

[**Video**](Video.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested Video |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getvideostatusbyid"></a>
# **GetVideoStatusById**
> VideoStatus GetVideoStatusById (string videoId)

Retun the detailed status of the video

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetVideoStatusByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video

            try
            {
                // Retun the detailed status of the video
                VideoStatus result = apiInstance.GetVideoStatusById(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.GetVideoStatusById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVideoStatusByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retun the detailed status of the video
    ApiResponse<VideoStatus> response = apiInstance.GetVideoStatusByIdWithHttpInfo(videoId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.GetVideoStatusByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |

### Return type

[**VideoStatus**](VideoStatus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested Video |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getvideos"></a>
# **GetVideos**
> VideoList GetVideos (int? limit = null, int? offset = null, string? search = null, string? sort = null)

List videos

Return the list of videos.  Return an empty list it there is no video to return.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var limit = 56;  // int? | Number of elements to return (default=10) (optional) 
            var offset = 56;  // int? | offset for pagination (optional) 
            var search = {{search}};  // string? | Keywords search in all indexed fields (optional) 
            var sort = ctime:asc;  // string? | Sorting results (optional) 

            try
            {
                // List videos
                VideoList result = apiInstance.GetVideos(limit, offset, search, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.GetVideos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVideosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List videos
    ApiResponse<VideoList> response = apiInstance.GetVideosWithHttpInfo(limit, offset, search, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.GetVideosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Number of elements to return (default&#x3D;10) | [optional]  |
| **offset** | **int?** | offset for pagination | [optional]  |
| **search** | **string?** | Keywords search in all indexed fields | [optional]  |
| **sort** | **string?** | Sorting results | [optional]  |

### Return type

[**VideoList**](VideoList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Videos |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="initmultipartuploadvideobyid"></a>
# **InitMultipartUploadVideoById**
> VideoMultipartUploadInitResponse InitMultipartUploadVideoById (string videoId, VideoMultipartUploadInit? videoMultipartUploadInit = null)

Multipart upload intialization

Get signed urls to upload a big file split in multiparts Once the video is uploaded, do not forget to call the multipart upload finalize  New video file is replacing previous video file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class InitMultipartUploadVideoByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video
            var videoMultipartUploadInit = new VideoMultipartUploadInit?(); // VideoMultipartUploadInit? |  (optional) 

            try
            {
                // Multipart upload intialization
                VideoMultipartUploadInitResponse result = apiInstance.InitMultipartUploadVideoById(videoId, videoMultipartUploadInit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.InitMultipartUploadVideoById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InitMultipartUploadVideoByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Multipart upload intialization
    ApiResponse<VideoMultipartUploadInitResponse> response = apiInstance.InitMultipartUploadVideoByIdWithHttpInfo(videoId, videoMultipartUploadInit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.InitMultipartUploadVideoByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |
| **videoMultipartUploadInit** | [**VideoMultipartUploadInit?**](VideoMultipartUploadInit?.md) |  | [optional]  |

### Return type

[**VideoMultipartUploadInitResponse**](VideoMultipartUploadInitResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of signed urls to post parts of the video to upload |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inituploadvideobyid"></a>
# **InitUploadVideoById**
> VideoUploadInitResponse InitUploadVideoById (string videoId)

Single file upload intialization

Get a single signed url to upload a file Once the video is uploaded, do not forget to call the single upload finalize  File formats currently supported: avi, mov, mp4, mpeg, mpg, mxf, ts. New video file is replacing previous video file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class InitUploadVideoByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video

            try
            {
                // Single file upload intialization
                VideoUploadInitResponse result = apiInstance.InitUploadVideoById(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.InitUploadVideoById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InitUploadVideoByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Single file upload intialization
    ApiResponse<VideoUploadInitResponse> response = apiInstance.InitUploadVideoByIdWithHttpInfo(videoId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.InitUploadVideoByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |

### Return type

[**VideoUploadInitResponse**](VideoUploadInitResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Signed url to post the video file to upload |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatevideobyid"></a>
# **UpdateVideoById**
> void UpdateVideoById (string videoId, VideoProperties videoProperties)

Update an existing video

Update video properties  Only properties provided are updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class UpdateVideoByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new VideosApi(config);
            var videoId = {{videoId}};  // string | Id of the video
            var videoProperties = new VideoProperties(); // VideoProperties | 

            try
            {
                // Update an existing video
                apiInstance.UpdateVideoById(videoId, videoProperties);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosApi.UpdateVideoById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateVideoByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing video
    apiInstance.UpdateVideoByIdWithHttpInfo(videoId, videoProperties);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VideosApi.UpdateVideoByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **videoId** | **string** | Id of the video |  |
| **videoProperties** | [**VideoProperties**](VideoProperties.md) |  |  |

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Video update accepted |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

