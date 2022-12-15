# Aspose.OCR.Cloud.SDK.Api.RecognizePdfApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelRecognizePdf**](RecognizePdfApi.md#cancelrecognizepdf) | **DELETE** /v5/RecognizePdf | CancelRecognizePdf |
| [**GetRecognizePdf**](RecognizePdfApi.md#getrecognizepdf) | **GET** /v5/RecognizePdf | GetRecognizePdf |
| [**PostRecognizePdf**](RecognizePdfApi.md#postrecognizepdf) | **POST** /v5/RecognizePdf | PostRecognizePdf |

<a name="cancelrecognizepdf"></a>
# **CancelRecognizePdf**
> void CancelRecognizePdf (string id)

CancelRecognizePdf

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class CancelRecognizePdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizePdfApi(config);
            var id = "id_example";  // string | 

            try
            {
                // CancelRecognizePdf
                apiInstance.CancelRecognizePdf(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizePdfApi.CancelRecognizePdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelRecognizePdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CancelRecognizePdf
    apiInstance.CancelRecognizePdfWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizePdfApi.CancelRecognizePdfWithHttpInfo: " + e.Message);
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

<a name="getrecognizepdf"></a>
# **GetRecognizePdf**
> OCRResponse GetRecognizePdf (string id)

GetRecognizePdf

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class GetRecognizePdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizePdfApi(config);
            var id = "id_example";  // string | Task id to select the result

            try
            {
                // GetRecognizePdf
                OCRResponse result = apiInstance.GetRecognizePdf(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizePdfApi.GetRecognizePdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecognizePdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetRecognizePdf
    ApiResponse<OCRResponse> response = apiInstance.GetRecognizePdfWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizePdfApi.GetRecognizePdfWithHttpInfo: " + e.Message);
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

<a name="postrecognizepdf"></a>
# **PostRecognizePdf**
> string PostRecognizePdf (OCRRecognizePdfBody oCRRecognizePdfBody)

PostRecognizePdf

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class PostRecognizePdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizePdfApi(config);
            var oCRRecognizePdfBody = new OCRRecognizePdfBody(); // OCRRecognizePdfBody | 

            try
            {
                // PostRecognizePdf
                string result = apiInstance.PostRecognizePdf(oCRRecognizePdfBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizePdfApi.PostRecognizePdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostRecognizePdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PostRecognizePdf
    ApiResponse<string> response = apiInstance.PostRecognizePdfWithHttpInfo(oCRRecognizePdfBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizePdfApi.PostRecognizePdfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRRecognizePdfBody** | [**OCRRecognizePdfBody**](OCRRecognizePdfBody.md) |  |  |

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

