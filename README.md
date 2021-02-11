
![](https://img.shields.io/badge/api-v3.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/Aspose.ocr-Cloud) ![Nuget](https://img.shields.io/nuget/dt/Aspose.ocr-Cloud) [![GitHub license](https://img.shields.io/github/license/aspose-ocr-cloud/aspose-ocr-cloud-dotnet)](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-dotnet/blob/master/LICENSE) ![GitHub last commit](https://img.shields.io/github/last-commit/Aspose-ocr-Cloud/aspose-ocr-cloud-dotnet)

# .NET Cloud REST API for OCR
Aspose OCR Cloud Android SDK is a simple OCR technology, which you can use in your application to convert image to text.
[Aspose.OCR Cloud](https://products.aspose.cloud/ocr/cloud) is a simple SDK used to add text recognition to your app with merely a few lines of code.
In detail, it's a set of SDKs for optical character recognition and document scanning in our Cloud. It supports reading and recognizing text from most commonly used raster image formats. Just pass a specific image to the Aspose.OCR Cloud API, and it will return a response with recognized text.

It is easy to get started with Aspose.OCR Cloud, and there is nothing to install. Create an account at Aspose Cloud and get your application information, then you are ready to use [SDKs](#asposeocr-cloud-sdks)

## OCR Processing Features
- Recognize and extract text from images via OCR.
- Specify the area of the image from which you want to extract text.
- Perform OCR to recognize text from the whole or partial image.
- Fetch character and font information from raster images.
- Return the response in the JSON or XML format.
- Supports English text recognition.

## Save OCR As
TXT, PDF, HOCR

## Read OCR Formats
BMP, JPG, GIF, PNG, TIFF

## Release 20.03:
We are glad to introduce French and German languages support.

<a title="GOTO WEB DEMO" href="http://saltov-gpu-3.dynabic.com:8084/">
  <img src="Docs/Resources/demo_preview.png">
</a>

## Features:
- Automatic skew correction
- Automatic and manual document layout detection
- Advanced automated image pre-processing
- Extract and recognize text from images via OCR
- Supports multiple international languages
- High speed with no hardware resources

## How to use the SDK?

Our API is completely independent of your operating system, database system, or development language. You can use any language and platform that supports HTTP to interact with our API. However, manually writing client code can be difficult, error-prone, and time-consuming. Therefore, we have provided and support [SDKs](#asposeocr-cloud-sdks) in many development languages to make it easier to integrate with us.

## Example

```csharp
static string RecognizeFromUrl(Configuration conf)
{
    string imgUri = @"http://typecast.com/images/uploads/fluid-type-single-column.png";

    OcrApi api = new OcrApi(conf);
    var request = new PostOcrFromUrlOrContentRequest(null, imgUri);
    OCRResponse response = api.PostOcrFromUrlOrContent(request);

    return response.Text;
}

static string RecognizeFromContent(Configuration conf)
{
    string name = "10.png";
    using (FileStream fs = File.OpenRead(name))
    {
        OcrApi api = new OcrApi(conf);
        var request = new PostOcrFromUrlOrContentRequest(fs, language: LanguageGroup.German);
        OCRResponse response = api.PostOcrFromUrlOrContent(request);

        return response.Text;
    }
}
```
_________________________

## Quickstart

Make your solution using [SDK](#asposeocr-cloud-sdks), follow these steps:

#### 1. Get API keys if you haven't

Make a personal account on [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/) and click _Get Keys_. These keys are useful for all Aspose Cloud products. If you have any trouble, look at this [detailed manual](https://docs.aspose.cloud/total/create-new-app-and-get-app-key-and-sid/).

#### 2. Run Demo
  * Checkout the SDK
  * Open [.NET 2.0](/Aspose.Ocr.Cloud.Sdk.Demo) or [.NET Core](/Aspose.Ocr.Cloud.Sdk.Demo.Net.Core) demo project
  * Set Your AppSid & AppKey
  * Run

<p align="center">
  <a title="Download ZIP" href="https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-dotnet/archive/master.zip">
     <img src="Docs/Resources/download.png" />
  </a>
</p>

_________________________

## Aspose.OCR Cloud SDKs in Popular Languages

| .NET | Java | Python| Android |
|---|---|---|---|
| [GitHub](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-dotnet) |[GitHub](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-java) | [GitHub](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-python)|[GitHub](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-android)|[GitHub](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-nodejs)
| [NuGet](https://www.nuget.org/packages/Aspose.ocr-Cloud/)| [Maven](https://repository.aspose.cloud/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-ocr-cloud) | [PIP](https://pypi.org/project/aspose-ocr-cloud/) | [Maven](https://repository.aspose.cloud/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-ocr-cloud)) | [NPM](https://www.npmjs.com/package/@asposecloud/aspose-ocr-cloud)

[Product Page](https://products.aspose.cloud/ocr/net) | [Documentation](https://docs.aspose.cloud/display/ocrcloud/Home) | [API Reference](https://apireference.aspose.cloud/ocr/) | [Code Samples](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-dotnet) | [Blog](https://blog.aspose.cloud/category/ocr/) | [Free Support](https://forum.aspose.cloud/c/ocr) | [Free Trial](https://dashboard.aspose.cloud/#/apps)
