# Api42Vb.Model.Webhook
Webhook Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | Url of the application wich is receiving Notifications | 
**Token** | **string** | Optionnal Secret token to validate notifications. Sent with the request in the X-Vpass-Token HTTP header. | [optional] 
**EventType** | **List&lt;Webhook.EventTypeEnum&gt;** | List of event to be notified:   * VIDEO_STATUS: Get Video object status modification notifications   Status values: REQUESTED, CREATED, TRANSCODING, TRANSCODING_ERROR, AVAILABLE, DELETED   * VIDEO_TRANSCODING_PROGRESS: Get transcoding progression notifications | 
**Id** | **string** | id of the webhook | 
**Ctime** | **int** | Creation date (timestamp) | [optional] 
**Mtime** | **int** | Modification date (timestamp) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

