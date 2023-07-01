# Aspose.OCR.Cloud.SDK.Api.RecognizePdfApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelRecognizePdf**](RecognizePdfApi.md#cancelrecognizepdf) | **DELETE** /v5/RecognizePdf | CancelRecognizePdf |
| [**GetRecognizePdf**](RecognizePdfApi.md#getrecognizepdf) | **GET** /v5/RecognizePdf | GetRecognizePdf |
| [**PostRecognizePdf**](RecognizePdfApi.md#postrecognizepdf) | **POST** /v5/RecognizePdf | PostRecognizePdf |

<a name="cancelrecognizepdf"></a>
# **CancelRecognizePdf**
> void CancelRecognizePdf (string id)

CancelRecognizePdf

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

<a name="getrecognizepdf"></a>
# **GetRecognizePdf**
> OCRResponse GetRecognizePdf (string id)

GetRecognizePdf

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

<a name="postrecognizepdf"></a>
# **PostRecognizePdf**
> string PostRecognizePdf (OCRRecognizePdfBody oCRRecognizePdfBody)

PostRecognizePdf

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRRecognizePdfBody** | [**OCRRecognizePdfBody**](OCRRecognizePdfBody.md) |  |  |

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
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

