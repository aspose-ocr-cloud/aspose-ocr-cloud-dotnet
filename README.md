<img src="docs/Resources/heading.png">

# Aspose.OCR Cloud 23.6.0

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

## What was changed in version 23.6.0

A summary of recent changes, enhancements and bug fixes in **Aspose.OCR Cloud SDK for .NET 23.6.0** release:

Key | Summary | Category
--- | ------- | --------
OCR-3454 | Extracting text from photographed signboards, price tags, plates, food labels, and similar images. | New feature
OCR-2893 | Detecting fonts and styles in scans or photographs. | New feature

REST API changes: https://releases.aspose.cloud/ocr/release-notes/2023/aspose-ocr-cloud-23-6-0-release-notes/

### Public API changes and backwards compatibility

This section lists all public API changes introduced in **Aspose.OCR Cloud SDK for .NET 23.6.0** that may affect the code of existing applications.

#### Added public APIs:

The following public APIs have been introduced in this release:

##### Label recognition

The following new classes have been added for extracting text from street photos, labels, and similar images:

Class | Description
----- | -----------
`RecognizeLabelApi` | Label recognition API.
`OCRSettingsRecognizeLabel` | Label recognition settings.
`OCRRecognizeLabelBody` | Label recognition request body.

[Learn more...](https://docs.aspose.cloud/ocr/recognize-label/)

##### Font identification

The following new classes have been added:

Class | Description
----- | -----------
`IdentifyFontApi` | Font identification API.
`OCRSettingsRecognizeFont` | Font identification settings.
`OCRRecognizeFontBody` | Font identification request body.

[Learn more...](https://docs.aspose.cloud/ocr/recognize-label/)

#### Updated public APIs:

_No changes_

#### Removed public APIs:

_No changes._

## Examples

The examples below illustrate the changes introduced in version 23.6.0:

### Recognize label from street photo

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
			RecognizeLabelApi recognizeLabelApi = new RecognizeLabelApi("<client id="">", "<client secret="">");
			/** Read photographed label to array of bytes */
			byte[] image = File.ReadAllBytes("source.png");
			/** Specify recognition settings */
			OCRSettingsRecognizeLabel recognitionSettings = new OCRSettingsRecognizeLabel {
				Language = Language.English,
				ResultType = ResultType.Text
			};
			/** Send photographed label for recognition */
			OCRRecognizeLabelBody source = new OCRRecognizeLabelBody(image, recognitionSettings);
			string taskID = recognizeLabelApi.PostRecognizeLabel(source);
			/** Fetch recognition result */
			OCRResponse result = recognizeLabelApi.GetRecognizeLabel(taskID);
			Console.WriteLine(Encoding.UTF8.GetString(result.Results[0].Data));
		}
	}
}
```

### Identify font in image

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
			IdentifyFontApi fontIdentificationApi = new IdentifyFontApi("<client id="">", "<client secret="">");
			/** Read the image to array of bytes */
			byte[] image = File.ReadAllBytes("source.png");
			/** Specify recognition settings */
			OCRSettingsRecognizeFont recognitionSettings = new OCRSettingsRecognizeFont {
				ResultType = ResultType.Text
			};
			/** Send image for font detection */
			OCRRecognizeFontBody source = new OCRRecognizeFontBody(image, recognitionSettings);
			string taskID = fontIdentificationApi.PostIdentifyFont(source);
			/** Fetch recognition result */
			OCRResponse result = fontIdentificationApi.GetIdentifyFont(taskID);
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
