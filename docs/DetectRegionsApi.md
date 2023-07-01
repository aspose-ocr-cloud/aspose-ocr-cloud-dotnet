# Aspose.OCR.Cloud.SDK.Api.DetectRegionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelDetectRegions**](DetectRegionsApi.md#canceldetectregions) | **DELETE** /v5/DetectRegions | CancelDetectRegions |
| [**GetDetectRegions**](DetectRegionsApi.md#getdetectregions) | **GET** /v5/DetectRegions | GetDetectRegions |
| [**PostDetectRegions**](DetectRegionsApi.md#postdetectregions) | **POST** /v5/DetectRegions | PostDetectRegions |

<a name="canceldetectregions"></a>
# **CancelDetectRegions**
> void CancelDetectRegions (string id)

CancelDetectRegions

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

<a name="getdetectregions"></a>
# **GetDetectRegions**
> OCRResponse GetDetectRegions (string id)

GetDetectRegions

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

<a name="postdetectregions"></a>
# **PostDetectRegions**
> string PostDetectRegions (OCRDetectRegionsBody oCRDetectRegionsBody)

PostDetectRegions

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRDetectRegionsBody** | [**OCRDetectRegionsBody**](OCRDetectRegionsBody.md) |  |  |

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

