# Aspose.OCR.Cloud.SDK.Api.RecognizeRegionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelRecognizeRegions**](RecognizeRegionsApi.md#cancelrecognizeregions) | **DELETE** /v5/RecognizeRegions | CancelRecognizeRegions |
| [**GetRecognizeRegions**](RecognizeRegionsApi.md#getrecognizeregions) | **GET** /v5/RecognizeRegions | GetRecognizeRegions |
| [**PostRecognizeRegions**](RecognizeRegionsApi.md#postrecognizeregions) | **POST** /v5/RecognizeRegions | PostRecognizeRegions |

<a name="cancelrecognizeregions"></a>
# **CancelRecognizeRegions**
> void CancelRecognizeRegions (string id)

CancelRecognizeRegions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class CancelRecognizeRegionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeRegionsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // CancelRecognizeRegions
                apiInstance.CancelRecognizeRegions(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeRegionsApi.CancelRecognizeRegions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelRecognizeRegionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CancelRecognizeRegions
    apiInstance.CancelRecognizeRegionsWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeRegionsApi.CancelRecognizeRegionsWithHttpInfo: " + e.Message);
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

<a name="getrecognizeregions"></a>
# **GetRecognizeRegions**
> OCRResponse GetRecognizeRegions (string id)

GetRecognizeRegions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class GetRecognizeRegionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeRegionsApi(config);
            var id = "id_example";  // string | Task id to select the result

            try
            {
                // GetRecognizeRegions
                OCRResponse result = apiInstance.GetRecognizeRegions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeRegionsApi.GetRecognizeRegions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecognizeRegionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetRecognizeRegions
    ApiResponse<OCRResponse> response = apiInstance.GetRecognizeRegionsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeRegionsApi.GetRecognizeRegionsWithHttpInfo: " + e.Message);
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

<a name="postrecognizeregions"></a>
# **PostRecognizeRegions**
> string PostRecognizeRegions (OCRRecognizeRegionsBody oCRRecognizeRegionsBody)

PostRecognizeRegions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class PostRecognizeRegionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeRegionsApi(config);
            var oCRRecognizeRegionsBody = new OCRRecognizeRegionsBody(); // OCRRecognizeRegionsBody | 

            try
            {
                // PostRecognizeRegions
                string result = apiInstance.PostRecognizeRegions(oCRRecognizeRegionsBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeRegionsApi.PostRecognizeRegions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostRecognizeRegionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PostRecognizeRegions
    ApiResponse<string> response = apiInstance.PostRecognizeRegionsWithHttpInfo(oCRRecognizeRegionsBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeRegionsApi.PostRecognizeRegionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRRecognizeRegionsBody** | [**OCRRecognizeRegionsBody**](OCRRecognizeRegionsBody.md) |  |  |

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

