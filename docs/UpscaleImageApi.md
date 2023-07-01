# Aspose.OCR.Cloud.SDK.Api.UpscaleImageApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelUpscaleImage**](UpscaleImageApi.md#cancelupscaleimage) | **DELETE** /v5/UpscaleImage | CancelUpscaleImage |
| [**GetUpscaleImage**](UpscaleImageApi.md#getupscaleimage) | **GET** /v5/UpscaleImage | GetUpscaleImage |
| [**PostUpscaleImage**](UpscaleImageApi.md#postupscaleimage) | **POST** /v5/UpscaleImage | PostUpscaleImage |

<a name="cancelupscaleimage"></a>
# **CancelUpscaleImage**
> void CancelUpscaleImage (string id)

CancelUpscaleImage

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

<a name="getupscaleimage"></a>
# **GetUpscaleImage**
> OCRResponse GetUpscaleImage (string id)

GetUpscaleImage

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

<a name="postupscaleimage"></a>
# **PostUpscaleImage**
> string PostUpscaleImage (OCRUpscaleImageBody oCRUpscaleImageBody)

PostUpscaleImage

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRUpscaleImageBody** | [**OCRUpscaleImageBody**](OCRUpscaleImageBody.md) |  |  |

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

