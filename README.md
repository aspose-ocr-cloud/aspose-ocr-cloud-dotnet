<img src="docs/Resources/heading.png">

# Aspose.OCR Cloud .NET SDK 23.11.0

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

## What was changed in version 23.11.0

A summary of recent changes, enhancements and bug fixes in **Aspose.OCR Cloud SDK for .NET 23.11.0** release:

Key | Summary | Category
--- | ------- | --------
OCR&#8209;3560 | Added an API for extracting structured information from scanned invoices. | New feature
OCR&#8209;3722 | Added a free API for evaluating text-to-speech conversion that works without [authorization](/ocr/authorization/).<br />Some restrictions apply. See below for details. | New feature
OCR&#8209;3171 | Added an API for getting [task status](/ocr/recognition-workflow/#3-fetch-the-recognition-result) without downloading a full recognition result. | Enhancement

REST API changes: https://releases.aspose.cloud/ocr/release-notes/2023/aspose-ocr-cloud-23-11-0-release-notes/

### Public API changes and backwards compatibility

This section lists all public API changes introduced in **Aspose.OCR Cloud SDK for .NET 23.11.0** that may affect the code of existing applications.

#### Added public APIs:

The following public APIs have been introduced in this release:

##### Extracting structured information from invoice

The following new classes have been added for extracting structured information in JSON format from scanned or photographed invoices:

Class | Description
----- | -----------
`RecognizeAndParseInvoiceApi` | Invoice processing API.
`OCRSettingsRecognizeAndParseInvoice` | Invoice processing settings.
`OCRRecognizeAndParseInvoiceBody` | Invoice processing request body.

[Learn more...](https://docs.aspose.cloud/ocr/recognize-parse-invoice/)

##### Text-to-speech evaluation

The following new classes have been added:

Class | Description
----- | -----------
`ConvertTextToSpeechTrialApi` | Evaluation text-to-speech conversion API (without authorization).

The evaluation mode has some limitations:

- **10** requests per day from a single IP address.
- The text size must not exceed **500** characters, including spaces and punctuation.
- The phrase _"Please authenticate to the API to remove this message"_ is inserted at a random position within the generated audio.

[Learn more...](https://docs.aspose.cloud/ocr/text-to-speech/)

##### Quickly fetch processing status

The following new classes have been added:

Class | Description
----- | -----------
`UtilitiesApi` | Universal API for various management and monitoring purposes.

[Learn more...](https://docs.aspose.cloud/ocr/subscription/)

#### Updated public APIs:

_No changes_

#### Removed public APIs:

_No changes._

## Examples

The examples below illustrate the changes introduced in version 23.11.0:

### Extract structured data from the invoice

```csharp
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System.Text;

namespace ExampleDotNet60v50.APIExamples
{
	public static class RecognizeAndParseInvoiceExample
	{
    	public static void Run(string clientId, string clientSecret)
    	{
        	try
        	{
            	string imageFileName = "samples/invoice_english_01.jpg";

            	Console.WriteLine($"Sending sample invoice ({imageFileName}) for processing...\n");

            	RecognizeAndParseInvoiceApi apiInstance = new RecognizeAndParseInvoiceApi(clientId, clientSecret);
            	var requestBody = new OCRRecognizeAndParseInvoiceBody(
                    	image: File.ReadAllBytes(imageFileName),
                    	settings: new OCRSettingsRecognizeAndParseInvoice(resultType: ResultType.Text));
            	string taskId = apiInstance.PostRecognizeAndParseInvoice(requestBody);
            	Console.WriteLine($"File successfully sent. Your credentials accepted. Your task ID is {taskId}\nTaking a while before request result...");
            	Thread.Sleep(10000);
            	var response = apiInstance.GetRecognizeAndParseInvoice(taskId);
            	Console.WriteLine($"Respose received with status {response.TaskStatus.Value} \n\n" +
                	$" Your results:\n\n");
            	response.Results.ForEach(res => Console.WriteLine(Encoding.UTF8.GetString(res.Data)));
        	}
        	catch (Exception ex)
        	{
            	Console.WriteLine(ex.ToString());
        	}
    	}
	}
}
```

### Convert text to speech in free (evaluation) mode

```csharp
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;

namespace ExampleDotNet60v50.APIExamples
{
	public static class TextToSpeechTrialExample
	{
    	public static void TryConvertTextToSpeechTrialApi()
    	{
        	try
        	{
            	string sampleText = "This is the sample text";

            	ConvertTextToSpeechTrialApi apiInstance = new ConvertTextToSpeechTrialApi();

            	var settings = new TTSBody(
                    	text: sampleText,
                    	settings: new TTSSettings(
                        	language: LanguageTTS.English,
                        	resultType: ResultTypeTTS.Wav));

            	var taskId = apiInstance.PostConvertTextToSpeechTrial(settings);
            	Console.WriteLine($"Text sent for TTS. Your credentials accepted. Your task ID is {taskId}");

            	Console.WriteLine($"Requesting results for task {taskId} ...");
            	var result = apiInstance.GetConvertTextToSpeechTrial(taskId);

            	byte[] soundFile = result.Results[0].Data;
            	string extension = result.Results[0].Type switch
            	{
                	"WavFile" => "wav",
                	_ => "wav"
            	};

            	Console.WriteLine($"Respose received with status {result.TaskStatus.Value} \n\n" +
                	$" Your results will be saved to results\\{result.Id}.{extension}:\n\n");
            	Directory.CreateDirectory("results");
            	File.WriteAllBytes($"results/{result.Id}.{extension}", soundFile);

            	Console.WriteLine("\nPress any key to continue");
            	Console.ReadKey();
        	}
        	catch (Exception ex)
        	{
            	Console.WriteLine(ex.ToString());
            	Console.WriteLine("\nPress any key to continue");
            	Console.ReadKey();
        	}
    	}
	}
}
```

### Fetch the status of the request

```csharp
namespace ExampleDotNet60v50.APIExamples
{
	public static class UtilitiesApiExample
	{
    	public static void TryUtilitiesApi(string clientId, string clientSecret)
    	{
        	try
        	{
            	string taskId = "00000000-0000-0000-0000-000000000000";

            	UtilitiesApi utilitieseApi = new UtilitiesApi();

            	Console.WriteLine($"Requesting task status for task {taskId} ...");
            	var result = utilitieseApi.GetTaskStatus(taskId);
            	Console.WriteLine($"Respose received with status {result.TaskStatus.Value} \n\n ");

            	Console.WriteLine("\nPress any key to continue");
            	Console.ReadKey();
        	}
        	catch (Exception ex)
        	{
            	Console.WriteLine(ex.ToString());
            	Console.WriteLine("\nPress any key to continue");
            	Console.ReadKey();
        	}
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
