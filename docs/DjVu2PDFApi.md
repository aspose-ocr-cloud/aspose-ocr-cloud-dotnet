# Aspose.OCR.Cloud.SDK.Api.DjVu2PDFApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelDjVu2PDF**](DjVu2PDFApi.md#canceldjvu2pdf) | **DELETE** /v5/DjVu2PDF | CancelDjVu2PDF |
| [**GetDjVu2PDF**](DjVu2PDFApi.md#getdjvu2pdf) | **GET** /v5/DjVu2PDF | GetDjVu2PDF |
| [**PostDjVu2PDF**](DjVu2PDFApi.md#postdjvu2pdf) | **POST** /v5/DjVu2PDF | PostDjVu2PDF |

<a name="canceldjvu2pdf"></a>
# **CancelDjVu2PDF**
> void CancelDjVu2PDF (string id)

CancelDjVu2PDF

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

<a name="getdjvu2pdf"></a>
# **GetDjVu2PDF**
> OCRResponse GetDjVu2PDF (string id)

GetDjVu2PDF

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

<a name="postdjvu2pdf"></a>
# **PostDjVu2PDF**
> string PostDjVu2PDF (OCRDjVu2PDFBody oCRDjVu2PDFBody)

PostDjVu2PDF

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRDjVu2PDFBody** | [**OCRDjVu2PDFBody**](OCRDjVu2PDFBody.md) |  |  |

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

