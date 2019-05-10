<img src="Docs/Resources/heading.png">

# Aspose.OCR for Cloud

[Aspose.OCR for Cloud](https://products.aspose.cloud/ocr/cloud) is a REST API for optical character recognition and documents scanning in the cloud. It supports reading and recognizing characters from most commonly used raster image formats. Just pass specific image name and its format to the Aspose.OCR for Cloud REST API and it will return response in JSON format including recognized text.

Aspose.OCR for Cloud helps quickly add OCR functionality to your application.

It is easy to get started with Aspose.OCR for Cloud and there is nothing to install. Simply create an account at Aspose for Cloud and get your application information, then you are ready to use owr [SDK](#sdk-packages) or [REST API](#rest) with any language - on any platform.

<a title="GOTO WEB DEMO" href="http://saltov-gpu-3.dynabic.com:8084/">
  <img src="Docs/Resources/demo_preview.png">
</a>

## How to use it in Your project

Aspose.OCR for Cloud is implemented as a [REST API](#rest).

Our API is completely independent of your operating system, database system or development language. You can use any language and platform that supports HTTP to interact with our API. However, manually writing client code can be difficult, error-prone and time-consuming. Therefore, we have provided and support API [SDKs](#sdk-packages) in many development languages in order to make it easier to integrate with us.
If you use [SDK](#sdk-packages), it hides the [REST API](#rest) calls and lets you use Aspose.OCR features in a native way for your preferred language.

## Examples

#### C#

```csharp
// Upload file using storage API
OcrApi ocrApi = new OcrApi(APIKEY, APPSID, BASEPATH);
IOcrV2Api ocrApiV2 = new OcrV2Api(APIKEY, APPSID, BASEPATH);
StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
ResponseMessage putCreateResponse = storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Path.Combine(DataFolder, name)));

// Recognize using OCR Cloud API
OCRResponse ocrResponseV2 = ocrApiV2.OcrV2GetRecognizeDocument(name, null, null);

Console.WriteLine(ocrResponseV2.Status)
Console.WriteLine(ocrResponseV2.Text)
```

#### REST

The fastest way to learn our REST API is to try a request builder on [API Reference page](https://apireference.aspose.cloud/ocr/).

REST Example:

```REST
/ocr/ocrv3/{name}/recognize_v3/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}
```

_________________________

## Versions and APIs

Currently we have two versions of Cloud OCR: **V2** and **V3**: The first is based on the classic OCR algorithms and allows to perform the entire OCR process; The second is based on neural networks, it has limited functionality, experimental algorithms, but is very promising, we will develop this version.

The APIs of these versions are the same, differ only in the server address, so you can use **V2** now and swith to **V3** in future.

### V2 - 17.10

This vesion uses our latest stable developments. It's produces a good result on almost all types of images for an acceptable execution time. It's based on classical OCR algorithms, not very fast and high-quality, but its advatage is that it can do document structure recognition - prosees document pages with images, tables and other content and automatically detect text regions to recognize.

[Try V2 vesion demostration here](http://saltov-gpu-3.dynabic.com:8083/)

### V3 - 18.09

This is the last version we just released, but not yet perfect. It's based on the cutting edge neural networks algorithms, distributed computing and scalable cloud architecture. The key features are: DSR, Skew correction and fast text recognition. It also provides the good results on only-text images, up to 97,7% [1 - ([Levenshtein](https://en.wikipedia.org/wiki/Levenshtein_distance) / Text_Length)]. 

We are very actively engaged in the development of this version, and suggest to look at our [roadmap :arrow_double_down:](#roadmap) and [release notes](#release-notes)

[Try V3 vesion demostration here](http://saltov-gpu-3.dynabic.com:8084/)

_________________________

## Quickstart

Try out our [demo](http://saltov-gpu-3.dynabic.com:8083/) right now or make your own solution using [SDK](#sdk-packages) or [REST](#rest), follow this steps:

#### 1. Get API keys if you haven't

Make a personal account on [Aspose for Cloud](https://dashboard.aspose.cloud/#/) and click _Get Keys_. This keys are usefull for all Aspose Cloud products. If you have any trouble, look at this [detailed manual](https://docs.aspose.cloud/display/totalcloud/Create+New+App+and+Get+App+Key+and+SID).

This step takes about 2 minutes and allows you to recognize 30mb of any image files.

#### 2. Upload image file on storage

On the same [page](https://dashboard.aspose.cloud/#/files) go to the _My Files_ tab and upload files you want to recognize.

#### 3. Check the API

Use [API Reference page](https://apireference.aspose.cloud/ocr/) to check your keys and API usage.

<p align="center">
  <a title="Download ZIP" href="https://github.com/asposecloud/Aspose.OCR-Cloud/archive/master.zip">
     <img src="Docs/Resources/download.png" />
  </a>
</p>

_________________________

## SDK packages

Currently only .NET SDK is available. Packages for other most used programming languages will be avialable soon. We are working on them right now.

||||||||||
|-------|----------|-------|-------|-------|---------|---------|----------|-------|
|[.NET](/SDK_V3/SDK/Aspose.OCR-Cloud-SDK-for-.NET)|Java|PHP|Ruby|Python|Node.js|Android|Objective-C|Perl|

## Release notes
**17.12** 

We provided our new version based on the most advanced algorithms on neural networks, distributed computing.

Advantages of this algorithm:
- It's faster than V2, mean page processing time is less than 3 seconds
- Excellent recognition results. Mean recognition quality is greater than 97% on text-only samples
- It is based on modern, perspective, scalable cloud architecture

**18.06**

- We've released our skew correction module that allows to recognize slightly rotated images
- We've improved text recognition module to fix a lot of issues in our [roadmap](#roadmap)
- We've integrated Tensorflow-Serving technology into our pipeline

**18.09**

We've included our current groundwork on DSR feature with the following classes: paragraph, table, image, formula, header, caption and list. Also we've prepared text lines recognition module that replaces words splitter and recognition modules. OCR Engine works slightly better and faster due to those improvements.

## Roadmap

In the upcoming releases, we are set to implement a number of new features and fix issues:

- [ ] Build SDK packages for Java, PHP, Ruby, Python, Node.js, Android, Objective-C, Perl
- [ ] Speed up single page recognition up to  less than 2 seconds
- [ ] Add a feature of batch files processing
- [ ] Add a feature to select custom regions of image to recognize
- [x] Add a feature of document structure processing to take a possibility of any document processing (with images, tables, etc. on page)
- [ ] Add more output formats: _hocr_ and _pdf_
- [x] Fix issue of collapsing words
- [x] Fix issue of duplicate letters
- [x] Fix issues with punctuation symbols
- [x] Learn to recognize characters: hyphen-minus (-), dash (–), grave accent (`), underscore (_), slashes (/)(\\)

## Resources

- **Website:** [https://www.aspose.cloud](https://www.aspose.cloud)
- **Product Home:** [Aspose.OCR Cloud](https://products.aspose.cloud/ocr/)
- **Documentation:** [Aspose.OCR Cloud Documentation](https://docs.aspose.cloud/display/ocrcloud/Home)
- **API Reference** [Aspose.OCR Cloud API Reference](https://apireference.aspose.cloud/diagram/)
- **Forum:** [Aspose.OCR Cloud Forum](https://forum.aspose.cloud/c/ocr)
- **Blog:** [Aspose.OCR Cloud Blog](https://blog.aspose.cloud/category/ocr/)
