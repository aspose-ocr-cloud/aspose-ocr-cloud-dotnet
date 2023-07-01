# Aspose.OCR.Cloud.SDK.Api.DewarpImageApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelDewarpImage**](DewarpImageApi.md#canceldewarpimage) | **DELETE** /v5/DewarpImage | CancelDewarpImage |
| [**GetDewarpImage**](DewarpImageApi.md#getdewarpimage) | **GET** /v5/DewarpImage | GetDewarpImage |
| [**PostDewarpImage**](DewarpImageApi.md#postdewarpimage) | **POST** /v5/DewarpImage | PostDewarpImage |

<a name="canceldewarpimage"></a>
# **CancelDewarpImage**
> void CancelDewarpImage (string id)

CancelDewarpImage

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

<a name="getdewarpimage"></a>
# **GetDewarpImage**
> OCRResponse GetDewarpImage (string id)

GetDewarpImage

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

<a name="postdewarpimage"></a>
# **PostDewarpImage**
> string PostDewarpImage (OCRDewarpImageBody oCRDewarpImageBody)

PostDewarpImage

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRDewarpImageBody** | [**OCRDewarpImageBody**](OCRDewarpImageBody.md) |  |  |

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

