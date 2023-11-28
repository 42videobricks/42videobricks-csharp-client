# Api42Vb.Model.DataVideoUsage
Video Usage KPIs

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateKey** | **string** | Date of the kpis.  Format:  - day:YYYY-MM-DD (2023-10-16) - week: YYYY-Www (2023-W42) - month: YYYY-MM (2023-10) | [optional] 
**Interval** | **string** | Unit of the period (day|month|week) | [optional] 
**Transcoding** | **decimal** | total of transcoding second since the begining of the month | 
**Hosting** | **decimal** | total of hosting second since the begining of the month | 
**Delivery** | **decimal** | total of delivery (stream) second since the begining of the month | [optional] 
**Drm** | **decimal** | total of delivery (stream) second since the begining of the month | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

