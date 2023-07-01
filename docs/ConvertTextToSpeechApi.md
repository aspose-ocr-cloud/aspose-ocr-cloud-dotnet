# Aspose.OCR.Cloud.SDK.Api.ConvertTextToSpeechApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelConvertTextToSpeech**](ConvertTextToSpeechApi.md#cancelconverttexttospeech) | **DELETE** /v5/ConvertTextToSpeech | CancelConvertTextToSpeech |
| [**GetConvertTextToSpeech**](ConvertTextToSpeechApi.md#getconverttexttospeech) | **GET** /v5/ConvertTextToSpeech | GetConvertTextToSpeech |
| [**PostConvertTextToSpeech**](ConvertTextToSpeechApi.md#postconverttexttospeech) | **POST** /v5/ConvertTextToSpeech | PostConvertTextToSpeech |

<a name="cancelconverttexttospeech"></a>
# **CancelConvertTextToSpeech**
> void CancelConvertTextToSpeech (string id)

CancelConvertTextToSpeech

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconverttexttospeech"></a>
# **GetConvertTextToSpeech**
> TTSResponse GetConvertTextToSpeech (string id)

GetConvertTextToSpeech

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
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postconverttexttospeech"></a>
# **PostConvertTextToSpeech**
> string PostConvertTextToSpeech (TTSBody tTSBody)

PostConvertTextToSpeech

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tTSBody** | [**TTSBody**](TTSBody.md) |  |  |

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

