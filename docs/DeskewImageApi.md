# Aspose.OCR.Cloud.SDK.Api.DeskewImageApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelDeskewImage**](DeskewImageApi.md#canceldeskewimage) | **DELETE** /v5/DeskewImage | CancelDeskewImage |
| [**GetDeskewImage**](DeskewImageApi.md#getdeskewimage) | **GET** /v5/DeskewImage | GetDeskewImage |
| [**PostDeskewImage**](DeskewImageApi.md#postdeskewimage) | **POST** /v5/DeskewImage | PostDeskewImage |

<a name="canceldeskewimage"></a>
# **CancelDeskewImage**
> void CancelDeskewImage (string id)

CancelDeskewImage

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

<a name="getdeskewimage"></a>
# **GetDeskewImage**
> OCRResponse GetDeskewImage (string id)

GetDeskewImage

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

<a name="postdeskewimage"></a>
# **PostDeskewImage**
> string PostDeskewImage (OCRDeskewImageBody oCRDeskewImageBody)

PostDeskewImage

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRDeskewImageBody** | [**OCRDeskewImageBody**](OCRDeskewImageBody.md) |  |  |

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

