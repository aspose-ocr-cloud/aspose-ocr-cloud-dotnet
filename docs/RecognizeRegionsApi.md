# Aspose.OCR.Cloud.SDK.Api.RecognizeRegionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelRecognizeRegions**](RecognizeRegionsApi.md#cancelrecognizeregions) | **DELETE** /v5/RecognizeRegions | CancelRecognizeRegions |
| [**GetRecognizeRegions**](RecognizeRegionsApi.md#getrecognizeregions) | **GET** /v5/RecognizeRegions | GetRecognizeRegions |
| [**PostRecognizeRegions**](RecognizeRegionsApi.md#postrecognizeregions) | **POST** /v5/RecognizeRegions | PostRecognizeRegions |

<a name="cancelrecognizeregions"></a>
# **CancelRecognizeRegions**
> void CancelRecognizeRegions (string id)

CancelRecognizeRegions

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

<a name="getrecognizeregions"></a>
# **GetRecognizeRegions**
> OCRResponse GetRecognizeRegions (string id)

GetRecognizeRegions

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

<a name="postrecognizeregions"></a>
# **PostRecognizeRegions**
> string PostRecognizeRegions (OCRRecognizeRegionsBody oCRRecognizeRegionsBody)

PostRecognizeRegions

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRRecognizeRegionsBody** | [**OCRRecognizeRegionsBody**](OCRRecognizeRegionsBody.md) |  |  |

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

