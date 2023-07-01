# Aspose.OCR.Cloud.SDK.Api.RecognizeLabelApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelRecognizeLabel**](RecognizeLabelApi.md#cancelrecognizelabel) | **DELETE** /v5/RecognizeLabel | CancelRecognizeLabel |
| [**GetRecognizeLabel**](RecognizeLabelApi.md#getrecognizelabel) | **GET** /v5/RecognizeLabel | GetRecognizeLabel |
| [**PostRecognizeLabel**](RecognizeLabelApi.md#postrecognizelabel) | **POST** /v5/RecognizeLabel | PostRecognizeLabel |

<a name="cancelrecognizelabel"></a>
# **CancelRecognizeLabel**
> void CancelRecognizeLabel (string id)

CancelRecognizeLabel

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

<a name="getrecognizelabel"></a>
# **GetRecognizeLabel**
> OCRResponse GetRecognizeLabel (string id)

GetRecognizeLabel

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

<a name="postrecognizelabel"></a>
# **PostRecognizeLabel**
> string PostRecognizeLabel (OCRRecognizeLabelBody oCRRecognizeLabelBody)

PostRecognizeLabel

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRRecognizeLabelBody** | [**OCRRecognizeLabelBody**](OCRRecognizeLabelBody.md) |  |  |

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

