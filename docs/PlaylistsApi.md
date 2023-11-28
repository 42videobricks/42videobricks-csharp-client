# Api42Vb.Api.PlaylistsApi

All URIs are relative to *https://api-sbx.42videobricks.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPlaylist**](PlaylistsApi.md#addplaylist) | **POST** /playlists | Add a new playlist |
| [**DeletePlaylistById**](PlaylistsApi.md#deleteplaylistbyid) | **DELETE** /playlists/{playlistId} | Delete a playlist |
| [**GetPlaylistById**](PlaylistsApi.md#getplaylistbyid) | **GET** /playlists/{playlistId} | Retun a single playlist |
| [**GetPlaylists**](PlaylistsApi.md#getplaylists) | **GET** /playlists | List playlists |
| [**UpdatePlaylistById**](PlaylistsApi.md#updateplaylistbyid) | **PUT** /playlists/{playlistId} | Update an existing playlist |

<a id="addplaylist"></a>
# **AddPlaylist**
> Playlist AddPlaylist (PlaylistProperties playlistProperties)

Add a new playlist

Create a new playlist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class AddPlaylistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlaylistsApi(config);
            var playlistProperties = new PlaylistProperties(); // PlaylistProperties | 

            try
            {
                // Add a new playlist
                Playlist result = apiInstance.AddPlaylist(playlistProperties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaylistsApi.AddPlaylist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPlaylistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new playlist
    ApiResponse<Playlist> response = apiInstance.AddPlaylistWithHttpInfo(playlistProperties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlaylistsApi.AddPlaylistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **playlistProperties** | [**PlaylistProperties**](PlaylistProperties.md) |  |  |

### Return type

[**Playlist**](Playlist.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Playlist Created |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteplaylistbyid"></a>
# **DeletePlaylistById**
> void DeletePlaylistById (string playlistId)

Delete a playlist

Delete a playlist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class DeletePlaylistByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlaylistsApi(config);
            var playlistId = {{playlistId}};  // string | Id of the playlist

            try
            {
                // Delete a playlist
                apiInstance.DeletePlaylistById(playlistId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaylistsApi.DeletePlaylistById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePlaylistByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a playlist
    apiInstance.DeletePlaylistByIdWithHttpInfo(playlistId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlaylistsApi.DeletePlaylistByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **playlistId** | **string** | Id of the playlist |  |

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
| **204** | Playlist Deleted |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getplaylistbyid"></a>
# **GetPlaylistById**
> Playlist GetPlaylistById (string playlistId)

Retun a single playlist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetPlaylistByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlaylistsApi(config);
            var playlistId = {{playlistId}};  // string | Id of the playlist

            try
            {
                // Retun a single playlist
                Playlist result = apiInstance.GetPlaylistById(playlistId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaylistsApi.GetPlaylistById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlaylistByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retun a single playlist
    ApiResponse<Playlist> response = apiInstance.GetPlaylistByIdWithHttpInfo(playlistId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlaylistsApi.GetPlaylistByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **playlistId** | **string** | Id of the playlist |  |

### Return type

[**Playlist**](Playlist.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested playlist |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getplaylists"></a>
# **GetPlaylists**
> PlaylistList GetPlaylists (int? limit = null, int? offset = null, string? search = null, string? sort = null)

List playlists

Return the list of playlist.  Return an empty list it there is no playlist to return.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class GetPlaylistsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlaylistsApi(config);
            var limit = 56;  // int? | Number of elements to return (default=10) (optional) 
            var offset = 56;  // int? | offset for pagination (optional) 
            var search = {{search}};  // string? | Keywords search in all indexed fields (optional) 
            var sort = ctime:asc;  // string? | Sorting results (optional) 

            try
            {
                // List playlists
                PlaylistList result = apiInstance.GetPlaylists(limit, offset, search, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaylistsApi.GetPlaylists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlaylistsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List playlists
    ApiResponse<PlaylistList> response = apiInstance.GetPlaylistsWithHttpInfo(limit, offset, search, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlaylistsApi.GetPlaylistsWithHttpInfo: " + e.Message);
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

[**PlaylistList**](PlaylistList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of playlists |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateplaylistbyid"></a>
# **UpdatePlaylistById**
> Playlist UpdatePlaylistById (string playlistId, PlaylistProperties playlistProperties)

Update an existing playlist

Update a existing playlist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Api42Vb.Api;
using Api42Vb.Client;
using Api42Vb.Model;

namespace Example
{
    public class UpdatePlaylistByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sbx.42videobricks.com";
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new PlaylistsApi(config);
            var playlistId = {{playlistId}};  // string | Id of the playlist
            var playlistProperties = new PlaylistProperties(); // PlaylistProperties | 

            try
            {
                // Update an existing playlist
                Playlist result = apiInstance.UpdatePlaylistById(playlistId, playlistProperties);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlaylistsApi.UpdatePlaylistById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePlaylistByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing playlist
    ApiResponse<Playlist> response = apiInstance.UpdatePlaylistByIdWithHttpInfo(playlistId, playlistProperties);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlaylistsApi.UpdatePlaylistByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **playlistId** | **string** | Id of the playlist |  |
| **playlistProperties** | [**PlaylistProperties**](PlaylistProperties.md) |  |  |

### Return type

[**Playlist**](Playlist.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Playlist Updated |  -  |
| **400** | The request is invalid or incomplete |  -  |
| **404** | The specified resource was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

