# Aspose.OCR.Cloud.SDK.Api.RecognizeImageApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelRecognizeImage**](RecognizeImageApi.md#cancelrecognizeimage) | **DELETE** /v5/RecognizeImage | CancelRecognizeImage |
| [**GetRecognizeImage**](RecognizeImageApi.md#getrecognizeimage) | **GET** /v5/RecognizeImage | GetRecognizeImage |
| [**PostRecognizeImage**](RecognizeImageApi.md#postrecognizeimage) | **POST** /v5/RecognizeImage | PostRecognizeImage |

<a name="cancelrecognizeimage"></a>
# **CancelRecognizeImage**
> void CancelRecognizeImage (string id)

CancelRecognizeImage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class CancelRecognizeImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeImageApi(config);
            var id = "id_example";  // string | 

            try
            {
                // CancelRecognizeImage
                apiInstance.CancelRecognizeImage(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeImageApi.CancelRecognizeImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelRecognizeImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CancelRecognizeImage
    apiInstance.CancelRecognizeImageWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeImageApi.CancelRecognizeImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

<a name="getrecognizeimage"></a>
# **GetRecognizeImage**
> OCRResponse GetRecognizeImage (string id)

GetRecognizeImage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class GetRecognizeImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeImageApi(config);
            var id = "id_example";  // string | Task id to select the result

            try
            {
                // GetRecognizeImage
                OCRResponse result = apiInstance.GetRecognizeImage(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeImageApi.GetRecognizeImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecognizeImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetRecognizeImage
    ApiResponse<OCRResponse> response = apiInstance.GetRecognizeImageWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeImageApi.GetRecognizeImageWithHttpInfo: " + e.Message);
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

<a name="postrecognizeimage"></a>
# **PostRecognizeImage**
> string PostRecognizeImage (OCRRecognizeImageBody oCRRecognizeImageBody)

PostRecognizeImage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class PostRecognizeImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeImageApi(config);
            var oCRRecognizeImageBody = new OCRRecognizeImageBody(); // OCRRecognizeImageBody | 

            try
            {
                // PostRecognizeImage
                string result = apiInstance.PostRecognizeImage(oCRRecognizeImageBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeImageApi.PostRecognizeImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostRecognizeImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PostRecognizeImage
    ApiResponse<string> response = apiInstance.PostRecognizeImageWithHttpInfo(oCRRecognizeImageBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeImageApi.PostRecognizeImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRRecognizeImageBody** | [**OCRRecognizeImageBody**](OCRRecognizeImageBody.md) |  |  |

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
| **200** | Task unique ID |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

