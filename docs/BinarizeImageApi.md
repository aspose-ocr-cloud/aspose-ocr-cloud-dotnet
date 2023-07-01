# Aspose.OCR.Cloud.SDK.Api.BinarizeImageApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelBinarizeImage**](BinarizeImageApi.md#cancelbinarizeimage) | **DELETE** /v5/BinarizeImage | CancelBinarizeImage |
| [**GetBinarizeImage**](BinarizeImageApi.md#getbinarizeimage) | **GET** /v5/BinarizeImage | GetBinarizeImage |
| [**PostBinarizeImage**](BinarizeImageApi.md#postbinarizeimage) | **POST** /v5/BinarizeImage | PostBinarizeImage |

<a name="cancelbinarizeimage"></a>
# **CancelBinarizeImage**
> void CancelBinarizeImage (string id)

CancelBinarizeImage

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

<a name="getbinarizeimage"></a>
# **GetBinarizeImage**
> OCRResponse GetBinarizeImage (string id)

GetBinarizeImage

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

<a name="postbinarizeimage"></a>
# **PostBinarizeImage**
> string PostBinarizeImage (OCRBinarizeImageBody oCRBinarizeImageBody)

PostBinarizeImage

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRBinarizeImageBody** | [**OCRBinarizeImageBody**](OCRBinarizeImageBody.md) |  |  |

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

