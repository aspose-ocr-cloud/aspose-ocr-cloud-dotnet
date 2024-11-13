<img src="docs/Resources/heading.png">

# Aspose.OCR Cloud .NET SDK 24.11.0

[![License](https://img.shields.io/github/license/aspose-ocr-cloud/aspose-ocr-cloud-dotnet)](LICENSE)
[![Nuget](https://img.shields.io/nuget/v/Aspose.OCR-Cloud)](https://www.nuget.org/packages/Aspose.OCR-Cloud/)

[Aspose.OCR Cloud](https://products.aspose.cloud/ocr/) is an optical character recognition as a service. With it, you can easily add OCR functionality to almost any device or platform, including netbooks, mini PCs, or even entry-level smartphones.

Our engine can read text from images, photos, screenshots and scanned PDFs in a wide variety of European, Cyrillic and Oriental fonts, returning results in the most popular document formats. Powerful built-in image processing filters based on neural networks automatically correct skewed and distorted images, automatically remove dirt, smudges, scratches, glare and other image defects that can affect recognition accuracy. To further improve the results, Aspose.OCR Cloud has a built-in spell checker that automatically replaces misspelled words and saves you the trouble of manually correcting the recognition results.

Even the complex recognition tasks can be done with a couple of API calls. To make interacting with Aspose.OCR Cloud services from .NET applications even easier, we provide the software development kit (SDK) for .NET. It handles all the routine operations such as establishing connections, sending API requests, and parsing responses, wrapping all these tasks into a few simple classes.

Aspose.OCR Cloud SDK for .NET is open source under the MIT license. You can freely use it for any projects, including commercial and proprietary applications, as well as modify any part of its code.

## Try Online
[Image to Text](https://products.aspose.app/ocr/scan-image) | [Image to Searchable PDF](https://products.aspose.app/ocr/ocr-to-pdf) | [PDF OCR](https://products.aspose.app/ocr/pdf-ocr)| [Receipt Scanner](https://products.aspose.app/ocr/scan-receipt)
:---: | :---: | :---:| :---:
[![Scan Image](https://products.aspose.app/ocr/scan-image/img/ocr-recognize-48.png)](https://products.aspose.app/ocr/scan-image) | [![Image to Searchable PDF](https://products.aspose.app/ocr/scan-image/img/ocr-to-pdf-4-48.png)](https://products.aspose.app/ocr/ocr-to-pdf) | [![PDF OCR](https://products.aspose.app/ocr/scan-image/img/ocr-to-pdf-2-48.png)](https://products.aspose.app/ocr/pdf-ocr) | [![Receipt Scanner](https://products.aspose.app/ocr/scan-image/img/aspose-scan-receipt-48.png)](https://products.aspose.app/ocr/scan-receipt) 

## Get started

Aspose.OCR Cloud is an on-demand service with a free tier. In order to use Aspose.OCR Cloud service, you must create an account at **Aspose Cloud API**:

1. Go to https://dashboard.aspose.cloud/
2. If you are already registered with Aspose, sign in with your user name and password.  
   Otherwise, click **Don’t have an account? Sign Up** link and create a new account.
3. [Check out more information](https://docs.aspose.cloud/ocr/subscription/) about available subscription plans and a free tier limits.

Aspose values your privacy and takes technical, security and organizational measures to protect your data from unauthorized use, accidental loss or disclosure. Read our [Privacy Policy](https://about.aspose.cloud/legal/privacy-policy) and [Terms of Service](https://about.aspose.cloud/legal/tos) for details.

### Authorization

Aspose.OCR Cloud follows industry standards and best practices to keep your data secure. All communication with OCR REST API is done using JWT authentication, which provides an open-standard, highly secure way to exchange information. Time-limited JWT tokens are generated using _Client ID_ and _Client Secret_ credentials that are specific for each application. To obtain the credentials:

1. Sign in to [Aspose Cloud API Dashboard](https://dashboard.aspose.cloud/).
2. Go to [**Applications**](https://dashboard.aspose.cloud/applications) page.
3. Click **Create New Application** button.
4. Give the application an easily recognizable name so it can be quickly found in a long list, and provide an optional detailed description.
5. Create the cloud storage by clicking the _plus_ icon and following the required steps. You can also reuse existing storage, if available.   
   Aspose.OCR Cloud uses its own internal storage, so you can provide the bare minimum storage options:

    - Type: **Internal storage**
    - Storage name: _Any name you like_
    - Storage mode: **Retain files for 24 hours**

6. Click **Save** button.
7. Click the newly created application and copy the values from **Client Id** and **Client Secret** fields.
8. Pass in the values from the **Client ID** and **Client Secret** fields when initializing the required OCR API.

### Running demo

1. Check out the SDK or install it from [NuGet](https://www.nuget.org/packages/Aspose.OCR-Cloud/).
2. Open [Examples](/src/Examples) demo solution.
3. Provide your **Client ID** and **Client Secret** (see _Authorization_ above).
4. Run the project.

<p align="center">
  <a title="Download ZIP" href="https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-dotnet/archive/master.zip">
     <img src="Docs/Resources/download.png" />
  </a>
</p>

## What was changed in version 24.11.0

A summary of recent changes, enhancements and bug fixes in **Aspose.OCR Cloud SDK for .NET 24.11.0** release:

Key | Summary | Category
--- | ------- | --------
OCR-3977 | Added recognition of the Uyghur language, including mixed Uyghur/English texts. | New feature
OCR-3978 | Added recognition of the Telugu language, including mixed Telugu/English texts. | New feature
OCR-3979 | Added recognition of the Kannada language, including mixed Kannada/English texts. | New feature
OCR-3980 | Added recognition of the Tamil language, including mixed Tamil/English texts. | New feature
OCR-3985 | Added recognition of the Devanagari-based scripts, including mixed Devanagari/English texts. | New feature
OCR-3986 | Added support for mixed Arabic/English texts. | Enhancement
OCR-3984 | Added support for mixed Japanese/English texts. | Enhancement
OCR-3983 | Added support for mixed Korean/English texts. | Enhancement
OCR-3982 | Added support for mixed Chinese/English texts. | Enhancement
OCR-3987 | Added support for mixed Persian/English texts. | Enhancement

REST API changes: https://releases.aspose.cloud/ocr/release-notes/2024/aspose-ocr-cloud-24-11-0-release-notes/

### Public API changes and backwards compatibility

This section lists all public API changes introduced in **Aspose.OCR Cloud SDK for .NET 24.11.0** that may affect the code of existing applications.

#### Added public APIs:

The following public APIs have been added in **Aspose.OCR Cloud SDK for .NET 24.11.0** release:

#### New recognition languages

The following recognition languages have been added:

Script     | REST API
---------- | --------
Uyghur     | `Language.Uyghur`
Telugu     | `Language.Telugu`
Kannada    | `Language.Kannada`
Tamil      | `Language.Tamil`
Devanagari-based languages | `Language.Devanagari`

{{% alert color="primary" %}}
All of the OCR languages mentioned above also support the recognition of mixed texts, including those with Latin characters.
{{% /alert %}}

#### Updated public APIs:

_No changes._

#### Removed public APIs:

_No changes._

## Changes to application logic

This section lists all improvements introduced in **Aspose.OCR Cloud SDK for .NET 24.11.0** that do not affect the public APIs and thus do not require changes to your application code.

### Mixed language support

Aspose.OCR Cloud now supports the recognition of texts which include both native and Latin characters for the following languages:

- Arabic (`Language.Arabic`)
- Chinese (`Language.Chinese`)
- Japanese (`Language.Japanese`)
- Korean (`Language.Korean`)
- Persian (`Language.Persian`)

## Examples

The examples below illustrate the changes introduced in version 24.11.0:

### Recognize Tamil language

```csharp
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System.Text;

namespace Example
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /** Authorize your requests to Aspose.OCR Cloud API */
      RecognizeImageApi recognizeImageApi = new RecognizeImageApi("<Client Id>", "<Client Secret>");
      /** Read source image to array of bytes */
      byte[] image = File.ReadAllBytes("source.png");
      /** Specify recognition language */
      OCRSettingsRecognizeImage recognitionSettings = new OCRSettingsRecognizeImage {
        Language = Language.Tamil,
        ResultType = ResultType.Text
      };
      /** Send image for recognition */
      OCRRecognizeImageBody source = new OCRRecognizeImageBody(image, recognitionSettings);
      string taskID = recognizeImageApi.PostRecognizeImage(source);
      /** Fetch recognition result */
      OCRResponse result = recognizeImageApi.GetRecognizeImage(taskID);
      Console.WriteLine(Encoding.UTF8.GetString(result.Results[0].Data));
    }
  }
}
```

## Other Aspose.OCR Cloud SDKs

- [Aspose.OCR Cloud for Java](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-java)  
  Call Aspose.OCR Cloud API from cross-platform Java apps.
- [Aspose.OCR Cloud for Python](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-python)  
  Natively integrate OCR features into Python applications.
- [Aspose.OCR Cloud for Node.js](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-nodejs)  
  Add OCR functionality to AWS Lambda, Azure Functions, services, and applications written in Node.js by querying our REST API.
- [Aspose.OCR Cloud for Android](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-android)  
  Turn a smartphone into a full featured OCR scanner. Aspose.OCR service runs in the cloud and supports even entry-level and legacy smartphones.

## Resources

Find more information on Aspose.OCR Cloud and get professional help:

- [Documentation](https://docs.aspose.cloud/ocr/)
- [GitHub repositories](https://github.com/aspose-ocr-cloud)
- [Free Support Forum](https://forum.aspose.cloud/c/ocr/12)
- [Paid Support Helpdesk](https://helpdesk.aspose.cloud/)
- [Blog](https://blog.aspose.cloud/category/ocr/)
- [Free OCR Apps](https://products.aspose.app/ocr/family/)
- [Aspose Cloud Pricing](https://purchase.aspose.cloud/pricing)
- [Terms of Service](https://about.aspose.cloud/legal/tos/)
