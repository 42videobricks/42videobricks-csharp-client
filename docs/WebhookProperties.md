# Api42Vb.Model.WebhookProperties
Webhook properties object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | Url of the application wich is receiving Notifications | 
**Token** | **string** | Optionnal Secret token to validate notifications. Sent with the request in the X-Vpass-Token HTTP header. | [optional] 
**EventType** | **List&lt;WebhookProperties.EventTypeEnum&gt;** | List of event to be notified:   * VIDEO_STATUS: Get Video object status modification notifications   Status values: REQUESTED, CREATED, TRANSCODING, TRANSCODING_ERROR, AVAILABLE, DELETED   * VIDEO_TRANSCODING_PROGRESS: Get transcoding progression notifications | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

