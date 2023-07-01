# Aspose.OCR.Cloud.SDK.Api.RecognizeImageApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelRecognizeImage**](RecognizeImageApi.md#cancelrecognizeimage) | **DELETE** /v5/RecognizeImage | CancelRecognizeImage |
| [**GetRecognizeImage**](RecognizeImageApi.md#getrecognizeimage) | **GET** /v5/RecognizeImage | GetRecognizeImage |
| [**PostRecognizeImage**](RecognizeImageApi.md#postrecognizeimage) | **POST** /v5/RecognizeImage | PostRecognizeImage |

<a name="cancelrecognizeimage"></a>
# **CancelRecognizeImage**
> void CancelRecognizeImage (string id)

CancelRecognizeImage

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

<a name="getrecognizeimage"></a>
# **GetRecognizeImage**
> OCRResponse GetRecognizeImage (string id)

GetRecognizeImage

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

<a name="postrecognizeimage"></a>
# **PostRecognizeImage**
> string PostRecognizeImage (OCRRecognizeImageBody oCRRecognizeImageBody)

PostRecognizeImage

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRRecognizeImageBody** | [**OCRRecognizeImageBody**](OCRRecognizeImageBody.md) |  |  |

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

