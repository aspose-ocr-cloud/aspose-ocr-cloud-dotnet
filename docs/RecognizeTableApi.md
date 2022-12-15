# Aspose.OCR.Cloud.SDK.Api.RecognizeTableApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelRecognizeTable**](RecognizeTableApi.md#cancelrecognizetable) | **DELETE** /v5/RecognizeTable | CancelRecognizeTable |
| [**GetRecognizeTable**](RecognizeTableApi.md#getrecognizetable) | **GET** /v5/RecognizeTable | GetRecognizeTable |
| [**PostRecognizeTable**](RecognizeTableApi.md#postrecognizetable) | **POST** /v5/RecognizeTable | PostRecognizeTable |

<a name="cancelrecognizetable"></a>
# **CancelRecognizeTable**
> void CancelRecognizeTable (string id)

CancelRecognizeTable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class CancelRecognizeTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeTableApi(config);
            var id = "id_example";  // string | 

            try
            {
                // CancelRecognizeTable
                apiInstance.CancelRecognizeTable(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeTableApi.CancelRecognizeTable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelRecognizeTableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CancelRecognizeTable
    apiInstance.CancelRecognizeTableWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeTableApi.CancelRecognizeTableWithHttpInfo: " + e.Message);
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

<a name="getrecognizetable"></a>
# **GetRecognizeTable**
> OCRResponse GetRecognizeTable (string id)

GetRecognizeTable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class GetRecognizeTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeTableApi(config);
            var id = "id_example";  // string | Task id to select the result

            try
            {
                // GetRecognizeTable
                OCRResponse result = apiInstance.GetRecognizeTable(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeTableApi.GetRecognizeTable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecognizeTableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetRecognizeTable
    ApiResponse<OCRResponse> response = apiInstance.GetRecognizeTableWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeTableApi.GetRecognizeTableWithHttpInfo: " + e.Message);
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

<a name="postrecognizetable"></a>
# **PostRecognizeTable**
> string PostRecognizeTable (OCRRecognizeTableBody oCRRecognizeTableBody)

PostRecognizeTable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Model;

namespace Example
{
    public class PostRecognizeTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecognizeTableApi(config);
            var oCRRecognizeTableBody = new OCRRecognizeTableBody(); // OCRRecognizeTableBody | 

            try
            {
                // PostRecognizeTable
                string result = apiInstance.PostRecognizeTable(oCRRecognizeTableBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecognizeTableApi.PostRecognizeTable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostRecognizeTableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PostRecognizeTable
    ApiResponse<string> response = apiInstance.PostRecognizeTableWithHttpInfo(oCRRecognizeTableBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecognizeTableApi.PostRecognizeTableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oCRRecognizeTableBody** | [**OCRRecognizeTableBody**](OCRRecognizeTableBody.md) |  |  |

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

