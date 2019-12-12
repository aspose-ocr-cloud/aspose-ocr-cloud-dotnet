<img src="Docs/Resources/heading.png">

# Aspose.OCR for Cloud

[Aspose.OCR for Cloud](https://products.aspose.cloud/ocr/cloud) is a simple SDK used to add text recognition to your app with simply few line of code.

In details, it's a set of SDKs for optical character recognition and documents scanning in our cloud. It supports reading and recognizing text from most commonly used raster image formats. Just pass specific image to the Aspose.OCR for Cloud API and it will return response with recognized text.

It is easy to get started with Aspose.OCR for Cloud and there is nothing to install. Simply create an account at Aspose for Cloud and get your application information, then you are ready to use [SDKs](#sdk-packages)

<a title="GOTO WEB DEMO" href="http://saltov-gpu-3.dynabic.com:8082/">
  <img src="Docs/Resources/demo_preview.png">
</a>

## How to use the SDK?

Our API is completely independent of your operating system, database system or development language. You can use any language and platform that supports HTTP to interact with our API. However, manually writing client code can be difficult, error-prone and time-consuming. Therefore, we have provided and support API [SDKs](#sdk-packages) in many development languages in order to make it easier to integrate with us.

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
        var request = new PostOcrFromUrlOrContentRequest(fs);
        OCRResponse response = api.PostOcrFromUrlOrContent(request);

        return response.Text;
    }
}
```
_________________________

## Quickstart

Try out our [demo](http://saltov-gpu-3.dynabic.com:8082/) right now or make your own solution using [SDK](#sdk-packages), follow this steps:

#### 1. Get API keys if you haven't

Make a personal account on [Aspose for Cloud](https://dashboard.aspose.cloud/#/) and click _Get Keys_. This keys are usefull for all Aspose Cloud products. If you have any trouble, look at this [detailed manual](https://docs.aspose.cloud/display/totalcloud/Create+New+App+and+Get+App+Key+and+SID).

#### 2. Run Demo
  * Checkout the SDK
  * Open [.NET 2.0](/Aspose.Ocr.Cloud.Sdk.Demo) or [.NET Core](/Aspose.Ocr.Cloud.Sdk.Demo.Net.Core) demo project
  * Set Your AppSid & AppKey
  * Run

<p align="center">
  <a title="Download ZIP" href="https://github.com/asposecloud/Aspose.OCR-Cloud/archive/master.zip">
     <img src="Docs/Resources/download.png" />
  </a>
</p>

_________________________

## SDKs

||||||||||
|-------|----------|-------|-------|-------|---------|---------|----------|-------|
|[.NET](/SDK_V3/SDK/Aspose.OCR-Cloud-SDK-for-.NET)|Java|PHP|Ruby|Python|Node.js|Android|Objective-C|Perl|

## Resources

- **Website:** [https://www.aspose.cloud](https://www.aspose.cloud)
- **Product Home:** [Aspose.OCR Cloud](https://products.aspose.cloud/ocr/family)
- **Documentation:** [Aspose.OCR Cloud Documentation](https://docs.aspose.cloud/display/ocrcloud/Home)
- **Forum:** [Aspose.OCR Cloud Forum](https://forum.aspose.cloud/c/ocr)
- **Blog:** [Aspose.OCR Cloud Blog](https://blog.aspose.cloud/category/ocr/)
- **Pricing:** [Aspose Cloud Pricing](https://purchase.aspose.cloud/pricing).
