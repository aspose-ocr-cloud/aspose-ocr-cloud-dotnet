# Aspose.OCR.Cloud.SDK.Api.TextToSpeechApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTextToSpeechResult**](TextToSpeechApi.md#gettexttospeechresult) | **GET** /v5/TextToSpeech/GetTextToSpeechResult | GetTextToSpeechResult |
| [**GetTextToSpeechResultFile**](TextToSpeechApi.md#gettexttospeechresultfile) | **GET** /v5/TextToSpeech/GetTextToSpeechResultFile | GetTextToSpeechResultFile |
| [**PostTextToSpeech**](TextToSpeechApi.md#posttexttospeech) | **POST** /v5/TextToSpeech/PostTextToSpeech | PostTextToSpeech |

<a name="gettexttospeechresult"></a>
# **GetTextToSpeechResult**
> TTSResponse GetTextToSpeechResult (string id)

GetTextToSpeechResult

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**TTSResponse**](TTSResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettexttospeechresultfile"></a>
# **GetTextToSpeechResultFile**
> Object GetTextToSpeechResultFile (string id)

GetTextToSpeechResultFile

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**Object**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **204** | Results expired |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttexttospeech"></a>
# **PostTextToSpeech**
> string PostTextToSpeech (TTSBodyDeprecated tTSBodyDeprecated)

PostTextToSpeech

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tTSBodyDeprecated** | [**TTSBodyDeprecated**](TTSBodyDeprecated.md) |  |  |

### Return type

**string**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Task unique ID |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

