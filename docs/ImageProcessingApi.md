# Aspose.OCR.Cloud.SDK.Api.ImageProcessingApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetResultFile**](ImageProcessingApi.md#getresultfile) | **GET** /v5/ImageProcessing/GetResultFile | GetResultFile |
| [**GetResultTask**](ImageProcessingApi.md#getresulttask) | **GET** /v5/ImageProcessing/GetResultTask | GetResultTask |
| [**PostBinarizationFile**](ImageProcessingApi.md#postbinarizationfile) | **POST** /v5/ImageProcessing/PostBinarizationFile | PostBinarizationFile |
| [**PostDewarpingFile**](ImageProcessingApi.md#postdewarpingfile) | **POST** /v5/ImageProcessing/PostDewarpingFile | PostDewarpingFile |
| [**PostSkewCorrectionFile**](ImageProcessingApi.md#postskewcorrectionfile) | **POST** /v5/ImageProcessing/PostSkewCorrectionFile | PostSkewCorrectionFile |
| [**PostUpsamplingFile**](ImageProcessingApi.md#postupsamplingfile) | **POST** /v5/ImageProcessing/PostUpsamplingImageFile | PostUpsamplingImageFile |

<a name="getresultfile"></a>
# **GetResultFile**
> Object GetResultFile (string id)

GetResultFile

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**Object**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **204** | Rsults expired |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresulttask"></a>
# **GetResultTask**
> OCRResponse GetResultTask (string id)

GetResultTask

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

<a name="postbinarizationfile"></a>
# **PostBinarizationFile**
> string PostBinarizationFile (System.IO.Stream file = null)

PostBinarizationFile

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

**string**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdewarpingfile"></a>
# **PostDewarpingFile**
> string PostDewarpingFile (System.IO.Stream file = null)

PostDewarpingFile

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

**string**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postskewcorrectionfile"></a>
# **PostSkewCorrectionFile**
> string PostSkewCorrectionFile (System.IO.Stream file = null)

PostSkewCorrectionFile

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

**string**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postupsamplingfile"></a>
# **PostUpsamplingFile**
> string PostUpsamplingFile (System.IO.Stream file = null)

PostUpsamplingImageFile

### Example
Please refer example project

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

**string**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

