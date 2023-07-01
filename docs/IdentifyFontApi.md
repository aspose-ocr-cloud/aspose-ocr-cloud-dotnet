# Aspose.OCR.Cloud.SDK.Api.IdentifyFontApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelIdentifyFont**](IdentifyFontApi.md#cancelidentifyfont) | **DELETE** /v5/IdentifyFont | CancelIdentifyFont |
| [**GetIdentifyFont**](IdentifyFontApi.md#getidentifyfont) | **GET** /v5/IdentifyFont | GetIdentifyFont |
| [**PostIdentifyFont**](IdentifyFontApi.md#postidentifyfont) | **POST** /v5/IdentifyFont | PostIdentifyFont |

<a name="cancelidentifyfont"></a>
# **CancelIdentifyFont**
> void CancelIdentifyFont (string id)

CancelIdentifyFont

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

<a name="getidentifyfont"></a>
# **GetIdentifyFont**
> OCRResponse GetIdentifyFont (string id)

GetIdentifyFont

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**OCRResponse**](OCRResponse.md)

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

<a name="postidentifyfont"></a>
# **PostIdentifyFont**
> string PostIdentifyFont (OCRRecognizeFontBody oCRRecognizeFontBody)

PostIdentifyFont

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRRecognizeFontBody** | [**OCRRecognizeFontBody**](OCRRecognizeFontBody.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

