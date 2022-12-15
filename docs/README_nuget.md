.NET Cloud REST API for OCR
---------------------------

![Version 22.12.0](https://img.shields.io/badge/nuget-v22.12.0-blue) ![Nuget](https://img.shields.io/nuget/dt/Aspose.OCR-Cloud)![GitHub](https://img.shields.io/github/license/aspose-ocr-cloud/aspose-ocr-cloud-dotnet)

[![banner](https://raw.githubusercontent.com/asposecloud/asposecloud.github.io/master/img/banners/aspose_ocr-cloud-for-net-banner.png)](https://dashboard.aspose.cloud/#/apps)

[Product Page](https://products.aspose.cloud/ocr/net/) | [Docs](https://docs.aspose.cloud/ocr/) | [Demos](https://products.aspose.app/ocr/family) | [Swagger UI](https://apireference.aspose.cloud/ocr/) | [Examples](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-dotnet) | [Blog](https://blog.aspose.cloud/category/ocr/) | [Search](https://search.aspose.cloud/) | [Free Support](https://forum.aspose.cloud/c/ocr) | [Free Trial](https://purchase.aspose.cloud/trial)

This cloud SDK helps you [perform optical character recognition (OCR)](https://products.aspose.cloud/ocr/net/) on various image formats using C#, ASP.NET, or other .NET supported languages, in the cloud.

### OCR Processing Features

* Recognize and extract text from images via OCR.
* Specify the area of the image from which you want to extract text.
* Perform OCR to recognize text from the whole or partial image.
* Fetch character and font information from raster images.
* Return the response in the JSON or XML format.
* Supports English text recognition.

### Read OCR Formats

JPEG, PNG, GIF, BMP, TIFF

### Get Started

You do not need to install anything to get started with Aspose.OCR Cloud SDK for .NET. Just create an account at [Aspose for Cloud](https://dashboard.aspose.cloud/#/apps) and get your application information.

Simply execute `Install-Package Aspose.OCR-Cloud` from the Package Manager Console in Visual Studio to fetch & reference Aspose.OCR assembly in your project. If you already have Aspose.OCR Cloud SDK for .NET and want to upgrade it, please execute `Update-Package Aspose.OCR-Cloud` to get the latest version.

Please check the [GitHub Repository](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-dotnet) for common usage scenarios.

### Extract text from `PNG` using C# Code

    // For complete examples and data files, please go to https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-dotnet/
    
    string imageFileName = "samples/lorem_ipsum.png";
    string clientId = ""
    string clientSecret = ""

    RecognizeImageApi recognizeImageApi = new RecognizeImageApi(clientId, clientSecret);

    byte[] imageData = File.ReadAllBytes(imageFileName);

    var settings = new OCRSettingsRecognizeImage(
            language: Language.English,
            resultType: ResultType.Text,
            dsrMode: DsrMode.NoDsrNoFilter,
            makeContrastCorrection: false);

    var taskId = recognizeImageApi.PostRecognizeImage(new OCRRecognizeImageBody(
        image: imageData,
        settings: settings));

    var result = recognizeImageApi.GetRecognizeImage(taskId);

    result.Results.ForEach(res => Console.WriteLine(Encoding.UTF8.GetString(res.Data)));
    

[Product Page](https://products.aspose.cloud/ocr/net/) | [Docs](https://docs.aspose.cloud/ocr/) | [Demos](https://products.aspose.app/ocr/family) | [Swagger UI](https://apireference.aspose.cloud/ocr/) | [Examples](https://github.com/aspose-ocr-cloud/aspose-ocr-cloud-dotnet) | [Blog](https://blog.aspose.cloud/category/ocr/) | [Search](https://search.aspose.cloud/) | [Free Support](https://forum.aspose.cloud/c/ocr) | [Free Trial](https://purchase.aspose.cloud/trial)