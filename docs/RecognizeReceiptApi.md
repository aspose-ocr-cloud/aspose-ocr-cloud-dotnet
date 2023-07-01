# Aspose.OCR.Cloud.SDK.Api.RecognizeReceiptApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelRecognizeReceipt**](RecognizeReceiptApi.md#cancelrecognizereceipt) | **DELETE** /v5/RecognizeReceipt | CancelRecognizeReceipt |
| [**GetRecognizeReceipt**](RecognizeReceiptApi.md#getrecognizereceipt) | **GET** /v5/RecognizeReceipt | GetRecognizeReceipt |
| [**PostRecognizeReceipt**](RecognizeReceiptApi.md#postrecognizereceipt) | **POST** /v5/RecognizeReceipt | PostRecognizeReceipt |

<a name="cancelrecognizereceipt"></a>
# **CancelRecognizeReceipt**
> void CancelRecognizeReceipt (string id)

CancelRecognizeReceipt

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

<a name="getrecognizereceipt"></a>
# **GetRecognizeReceipt**
> OCRResponse GetRecognizeReceipt (string id)

GetRecognizeReceipt

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

<a name="postrecognizereceipt"></a>
# **PostRecognizeReceipt**
> string PostRecognizeReceipt (OCRRecognizeReceiptBody oCRRecognizeReceiptBody)

PostRecognizeReceipt

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRRecognizeReceiptBody** | [**OCRRecognizeReceiptBody**](OCRRecognizeReceiptBody.md) |  |  |

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
| **401** | Unauthorized |  -  |
| **200** | Task unique ID |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

