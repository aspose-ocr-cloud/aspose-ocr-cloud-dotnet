# Aspose.OCR.Cloud.SDK.Api.RecognizeReceiptApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelRecognizeReceipt**](RecognizeReceiptApi.md#cancelrecognizereceipt) | **DELETE** /v5/RecognizeReceipt | CancelRecognizeReceipt |
| [**GetRecognizeReceipt**](RecognizeReceiptApi.md#getrecognizereceipt) | **GET** /v5/RecognizeReceipt | GetRecognizeReceipt |
| [**PostRecognizeReceipt**](RecognizeReceiptApi.md#postrecognizereceipt) | **POST** /v5/RecognizeReceipt | PostRecognizeReceipt |

<a name="cancelrecognizereceipt"></a>
# **CancelRecognizeReceipt**
> void CancelRecognizeReceipt (string id)

CancelRecognizeReceipt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class CancelRecognizeReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeReceiptApi(config);
            var id = "id_example";  // string | 

            try
            {
                // CancelRecognizeReceipt
                apiInstance.CancelRecognizeReceipt(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeReceiptApi.CancelRecognizeReceipt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelRecognizeReceiptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CancelRecognizeReceipt
    apiInstance.CancelRecognizeReceiptWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeReceiptApi.CancelRecognizeReceiptWithHttpInfo: " + e.Message);
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

<a name="getrecognizereceipt"></a>
# **GetRecognizeReceipt**
> OCRResponse GetRecognizeReceipt (string id)

GetRecognizeReceipt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class GetRecognizeReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeReceiptApi(config);
            var id = "id_example";  // string | Task id to select the result

            try
            {
                // GetRecognizeReceipt
                OCRResponse result = apiInstance.GetRecognizeReceipt(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeReceiptApi.GetRecognizeReceipt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecognizeReceiptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetRecognizeReceipt
    ApiResponse<OCRResponse> response = apiInstance.GetRecognizeReceiptWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeReceiptApi.GetRecognizeReceiptWithHttpInfo: " + e.Message);
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

<a name="postrecognizereceipt"></a>
# **PostRecognizeReceipt**
> string PostRecognizeReceipt (OCRRecognizeReceiptBody oCRRecognizeReceiptBody)

PostRecognizeReceipt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class PostRecognizeReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeReceiptApi(config);
            var oCRRecognizeReceiptBody = new OCRRecognizeReceiptBody(); // OCRRecognizeReceiptBody | 

            try
            {
                // PostRecognizeReceipt
                string result = apiInstance.PostRecognizeReceipt(oCRRecognizeReceiptBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeReceiptApi.PostRecognizeReceipt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostRecognizeReceiptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PostRecognizeReceipt
    ApiResponse<string> response = apiInstance.PostRecognizeReceiptWithHttpInfo(oCRRecognizeReceiptBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeReceiptApi.PostRecognizeReceiptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRRecognizeReceiptBody** | [**OCRRecognizeReceiptBody**](OCRRecognizeReceiptBody.md) |  |  |

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
| **401** | Unauthorized |  -  |
| **200** | Task unique ID |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

