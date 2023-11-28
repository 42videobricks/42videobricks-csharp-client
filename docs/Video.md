# Api42Vb.Model.Video
Video Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | title of the video | [optional] 
**Description** | **string** | description of the video | [optional] 
**VarPublic** | **bool** | Define if the video is public (it can be accessible by anybody with the video url). Default &#x3D; tue | [optional] 
**Tags** | **List&lt;string&gt;** | tags list linked to video | [optional] 
**Id** | **string** | id of the video (null when adding a new video) | 
**Status** | **string** | Status of the video : * &#39;REQUESTED&#39;: video as been submited, waiting for its creation * &#39;CREATED&#39;: video has been created and file can be uploaded          * &#39;TRANSCODING&#39;: video is unvailable because still in the creation  &amp; in encoding process * &#39;TRANSCODING_ERROR&#39;: video is unvailable because the encoding failed  * &#39;AVAILABLE&#39;: video is ready to be stream | [optional] 
**Duration** | **int** | video duration in second | [optional] 
**Ctime** | **int** | Creation date (timestamp) | [optional] 
**Mtime** | **int** | Modification date (timestamp) | [optional] 
**Assets** | [**VideoAssets**](VideoAssets.md) |  | [optional] 
**Metas** | **Dictionary&lt;string, Object&gt;** | metas data  free-form object: refere to the documentation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

