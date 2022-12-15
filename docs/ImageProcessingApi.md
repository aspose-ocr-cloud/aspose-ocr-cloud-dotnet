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
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class GetResultFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImageProcessingApi(config);
            var id = "id_example";  // string | Task id to select the result

            try
            {
                // GetResultFile
                Object result = apiInstance.GetResultFile(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImageProcessingApi.GetResultFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResultFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetResultFile
    ApiResponse<Object> response = apiInstance.GetResultFileWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImageProcessingApi.GetResultFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Task id to select the result |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresulttask"></a>
# **GetResultTask**
> OCRResponse GetResultTask (string id)

GetResultTask

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class GetResultTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImageProcessingApi(config);
            var id = "id_example";  // string | Task id to select the result

            try
            {
                // GetResultTask
                OCRResponse result = apiInstance.GetResultTask(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImageProcessingApi.GetResultTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResultTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetResultTask
    ApiResponse<OCRResponse> response = apiInstance.GetResultTaskWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImageProcessingApi.GetResultTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Task id to select the result |  |

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
> string PostBinarizationFile (System.IO.Stream? file = null)

PostBinarizationFile

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class PostBinarizationFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImageProcessingApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 

            try
            {
                // PostBinarizationFile
                string result = apiInstance.PostBinarizationFile(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImageProcessingApi.PostBinarizationFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostBinarizationFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PostBinarizationFile
    ApiResponse<string> response = apiInstance.PostBinarizationFileWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImageProcessingApi.PostBinarizationFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |

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
> string PostDewarpingFile (System.IO.Stream? file = null)

PostDewarpingFile

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class PostDewarpingFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImageProcessingApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 

            try
            {
                // PostDewarpingFile
                string result = apiInstance.PostDewarpingFile(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImageProcessingApi.PostDewarpingFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostDewarpingFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PostDewarpingFile
    ApiResponse<string> response = apiInstance.PostDewarpingFileWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImageProcessingApi.PostDewarpingFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |

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
> string PostSkewCorrectionFile (System.IO.Stream? file = null)

PostSkewCorrectionFile

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class PostSkewCorrectionFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImageProcessingApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 

            try
            {
                // PostSkewCorrectionFile
                string result = apiInstance.PostSkewCorrectionFile(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImageProcessingApi.PostSkewCorrectionFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostSkewCorrectionFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PostSkewCorrectionFile
    ApiResponse<string> response = apiInstance.PostSkewCorrectionFileWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImageProcessingApi.PostSkewCorrectionFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |

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
> string PostUpsamplingFile (System.IO.Stream? file = null)

PostUpsamplingImageFile

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class PostUpsamplingFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImageProcessingApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 

            try
            {
                // PostUpsamplingImageFile
                string result = apiInstance.PostUpsamplingFile(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImageProcessingApi.PostUpsamplingFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostUpsamplingFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PostUpsamplingImageFile
    ApiResponse<string> response = apiInstance.PostUpsamplingFileWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImageProcessingApi.PostUpsamplingFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |

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

