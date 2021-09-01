
<img src="Docs/Resources/heading.png">

# Aspose.OCR Cloud
[![License](https://img.shields.io/github/license/aspose-ocr-cloud/aspose-ocr-cloud-dotnet)](LICENSE)
[![Nuget](https://img.shields.io/nuget/v/Aspose.OCR-Cloud)](https://www.nuget.org/packages/Aspose.OCR-Cloud/)

[Aspose.OCR Cloud](https://products.aspose.cloud/ocr/) is a simple OCR API to add text recognition to your app with just a few lines of code.

In detail, it's a set of SDKs for optical character recognition and document scanning in Cloud. It supports reading and recognizing text from the most commonly used raster image formats and PDF files. Just pass a specific image to the Aspose.OCR Cloud API, and get a response with recognized text.

It is easy to get started with Aspose.OCR Cloud and there is nothing to install. Create a free account at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/applications) and get your application information, then you are ready to use [SDKs](#asposeocr-cloud-sdks).

## Try Online
[Image to Text](https://products.aspose.app/ocr/scan-image) | [Image to Searchable PDF](https://products.aspose.app/ocr/ocr-to-pdf) | [PDF OCR](https://products.aspose.app/ocr/pdf-ocr)| [Receipt Scanner](https://products.aspose.app/ocr/scan-receipt)
:---: | :---: | :---:| :---:
[![Scan Image](https://products.aspose.app/ocr/scan-image/img/ocr-recognize-48.png)](https://products.aspose.app/ocr/scan-image) | [![Image to Searchable PDF](https://products.aspose.app/ocr/scan-image/img/ocr-to-pdf-4-48.png)](https://products.aspose.app/ocr/ocr-to-pdf) | [![PDF OCR](https://products.aspose.app/ocr/scan-image/img/ocr-to-pdf-2-48.png)](https://products.aspose.app/ocr/pdf-ocr) | [![Receipt Scanner](https://products.aspose.app/ocr/scan-image/img/aspose-scan-receipt-48.png)](https://products.aspose.app/ocr/scan-receipt) 



## Release 21.09
Added new recognition languages: Bengali, Tibetan, Thai, Urdu, Turkish, Korean, Indonesian, Hebrew, Javanese, Greek, Japanese, Persian

## Features
- Automated skew correction
- Automated and manual document layout detection
- Recognize documents with complex layouts in fully automatic mode or with manual corrections.
- Extract and recognize text from images via OCR
- Supports multiple international languages
- High speed with no hardware resources
- Receipt recognition
- Table image recognition
- Supports PDF Recognition
- Text correction using spell checking algorithms
- Various output formats: Text, Searchable PDF, hOCR, Excel for tables.

## Recognize text of different languages
Aspose.OCR Cloud supports 38 languages including English, German, French, Italian, Spanish, Portuguese, Polish, Slovene, Slovak, Netherlands, Lithuanian, Latvian, Danish, Norwegian, Finnish, Serbian, Croatian, Czech, Swedish, Estonian, Romanian, Chinese, Arabic, Hindi, Russian, Ukrainian, Bengali, Tibetan, Thai, Urdu, Turkish, Korean, Indonesian, Hebrew, Javanese, Greek, Japanese, Persian and a lot of other works too.

## How to use the SDK?

Our API is completely independent of your operating system, database system, or development language. You can use any language and platform that supports HTTP to interact with our API. However, manually writing client code can be difficult, error-prone, and time-consuming. Therefore, we have provided and support [SDKs](#asposeocr-cloud-sdks) in several development languages to make it easier to integrate with us.

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

Create simple solution using Aspose.OCR Cloud .NET SDK following these steps:

#### 1. Get API Credentials

Make a free personal account on [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/) and navigate to [Applications](https://dashboard.aspose.cloud/applications) to get API Credentials - Client ID and Client Secret. These Credentials are used by all Aspose Cloud products. If you have any trouble, please check [step by step manual](https://docs.aspose.cloud/display/totalcloud/Create+New+App+and+Get+App+Key+and+SID).

#### 2. Run Demo
  * Checkout the SDK or install from [NuGet](https://www.nuget.org/packages/Aspose.OCR-Cloud/)
  * Open [.NET 2.0](/Aspose.Ocr.Cloud.Sdk.Demo) or [.NET Core](/Aspose.Ocr.Cloud.Sdk.Demo.Net.Core) demo project
  * Set Your Client ID & Client Secret
  * Run

<p align="center">
  <a title="Download ZIP" href="https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-dotnet/archive/master.zip">
     <img src="Docs/Resources/download.png" />
  </a>
</p>

_________________________

## Aspose.OCR Cloud SDKs

||||||
|--------------|----------|-------|---------|---------|
|[.NET & Core](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-dotnet)|[Java](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-java)|[Python](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-python)|[Node.js](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-nodejs)|[Android](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-android)

## Resources
      
- **Website:** [https://www.aspose.cloud](https://www.aspose.cloud)
- **Product Home:** [Aspose.OCR Cloud](https://products.aspose.cloud/ocr/family)
- **Documentation:** [Aspose.OCR Cloud Documentation](https://docs.aspose.cloud/display/ocrcloud/Home)
- **Forum:** [Aspose.OCR Cloud Forum](https://forum.aspose.cloud/c/ocr)
- **Blog:** [Aspose.OCR Cloud Blog](https://blog.aspose.cloud/category/ocr/)
- **Pricing:** [Aspose Cloud Pricing](https://purchase.aspose.cloud/pricing)
- **Free Online Demo** [Aspose.OCR Image to Text](https://products.aspose.app/ocr/scan-image)
