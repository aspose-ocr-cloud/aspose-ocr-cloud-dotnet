<img src="docs/Resources/heading.png">

# Aspose.OCR Cloud .NET SDK 24.8.0

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

## What was changed in version 24.8.0

A summary of recent changes, enhancements and bug fixes in **Aspose.OCR Cloud SDK for .NET 24.8.0** release:

Key | Summary | Category
--- | ------- | --------
OCR&#8209;3930 | Added support for 149 recognition languages. | Enhancement

REST API changes: https://releases.aspose.cloud/ocr/release-notes/2024/aspose-ocr-cloud-24-8-0-release-notes/

### Public API changes and backwards compatibility

This section lists all public API changes introduced in **Aspose.OCR Cloud SDK for .NET 24.8.0** that may affect the code of existing applications.

#### Added public APIs:

_No changes._

#### Updated public APIs:

The following public APIs have been updated in this release:

#### JSON result type

{{% alert color="info" %}}
**Compatibility: fully backward compatible.**
{{% /alert %}}

Aspose.OCR Cloud greatly expands the number of languages supported. We have added a total of 149 languages based on Latin, Cyrillic, Chinese and Indic scripts. By default, the text is considered to be in _English_.

Language | Value
-------- | --------
Afrikaans | `Language.Afrikaans`
Albanian | `Language.Albanian`
Arabic | `Language.Arabic`
Awadhi | `Language.Awadhi`
Azerbaijani | `Language.Azerbaijani`
Belorussian | `Language.Belorussian`
Bemba | `Language.Bemba`
Bengali | `Language.Bengali`
Betawi | `Language.Betawi`
Bhojpuri | `Language.Bhojpuri`
Bikol | `Language.Bikol`
Bosnian | `Language.Bosnian`
Bouyei | `Language.Bouyei`
Bulgarian | `Language.Bulgarian`
Cantonese | `Language.Cantonese`
Catalan | `Language.Catalan`
Cebuano | `Language.Cebuano`
Chattisgarhi | `Language.Chattisgarhi`
Chechen | `Language.Chechen`
Chichewa | `Language.Chichewa`
Chinese | `Language.Chinese`
Croatian | `Language.Croatian`
Czech | `Language.Czech`
Danish | `Language.Danish`
Dhundari | `Language.Dhundari`
Dimli | `Language.Dimli`
Dong | `Language.Dong`
Dutch | `Language.Dutch`
English | `Language.English`
_Handwritten English_ | `Language.HWT_ENG`
Estonian | `Language.Estonian`
Finnish | `Language.Finnish`
French | `Language.French`
Galician | `Language.Galician`
Gan | `Language.Gan`
Garhwali | `Language.Garhwali`
Georgian | `Language.Georgian`
German | `Language.German`
Gilaki | `Language.Gilaki`
Greek | `Language.Greek`
Gusii | `Language.Gusii`
Hakka | `Language.Hakka`
Haryanvi | `Language.Haryanvi`
Hausa | `Language.Hausa`
Hebrew | `Language.Hebrew`
Hiligaynon | `Language.Hiligaynon`
Hindi | `Language.Hindi`
Hmong | `Language.Hmong`
Hungarian | `Language.Hungarian`
Ilocano | `Language.Ilocano`
Indonesian | `Language.Indonesian`
Italian | `Language.Italian`
Japanese | `Language.Japanese`
Javanese | `Language.Javanese`
Kabardian | `Language.Kabardian`
Kanauji | `Language.Kanauji`
Kanuri | `Language.Kanuri`
Kapampangan | `Language.Kapampangan`
Kazah | `Language.Kazah`
Kiche | `Language.Kiche`
Kikongo | `Language.Kikongo`
Konkani | `Language.Konkani`
Korean | `Language.Korean`
Kumauni | `Language.Kumauni`
Kurdish | `Language.Kurdish`
Lamani | `Language.Lamani`
Latin | `Language.Latin`
Latvian | `Language.Latvian`
Lithuanian | `Language.Lithuanian`
Low German | `Language.Low_German`
Luguru | `Language.Luguru`
Luo | `Language.Luo`
Macedonian | `Language.Macedonian`
Magahi | `Language.Magahi`
Maithili | `Language.Maithili`
Makassar | `Language.Makassar`
Makua | `Language.Makua`
Malagasy | `Language.Malagasy`
Malay | `Language.Malay`
Malvi | `Language.Malvi`
Marathi | `Language.Marathi`
Marwari | `Language.Marwari`
Meru | `Language.Meru`
Mewari | `Language.Mewari`
Mewati | `Language.Mewati`
Min Bei | `Language.Min_Bei`
Min Dong | `Language.Min_Dong`
Min Nan | `Language.Min_Nan`
Minangkabau | `Language.Minangkabau`
Muong | `Language.Muong`
Musi | `Language.Musi`
Nandi | `Language.Nandi`
Ndebele | `Language.Ndebele`
Nepali | `Language.Nepali`
Netherlands | `Language.Netherlands`
Norwegian | `Language.Norwegian`
Occitan | `Language.Occitan`
Oromo | `Language.Oromo`
Palembang | `Language.Palembang`
Pangasinan | `Language.Pangasinan`
Persian | `Language.Persian`
Polish | `Language.Polish`
Portuguese | `Language.Portuguese`
Pu-Xian | `Language.Pu_Xian`
Quechua | `Language.Quechua`
Rajbanshi | `Language.Rajbanshi`
Romanian | `Language.Romanian`
Russian | `Language.Russian`
Rwanda | `Language.Rwanda`
Sasak | `Language.Sasak`
Serbian | `Language.Serbian`
Serbo-Croatian | `Language.Serbo_Croatian`
Serer-Sine | `Language.Serer_Sine`
Shona | `Language.Shona`
Slovak | `Language.Slovak`
Slovene | `Language.Slovene`
Somali | `Language.Somali`
Sotho (Northern) | `Language.Sotho_Northern`
Sotho (Southern) | `Language.Sotho_Southern`
Spanish | `Language.Spanish`
Sukuma | `Language.Sukuma`
Sundanese | `Language.Sundanese`
Swahili | `Language.Swahili`
Swati | `Language.Swati`
Swedish | `Language.Swedish`
Tagalog | `Language.Tagalog`
Thai | `Language.Thai`
Tibetan | `Language.Tibetan`
Tonga | `Language.Tonga`
Tsonga | `Language.Tsonga`
Tswana | `Language.Tswana`
Tumbuka | `Language.Tumbuka`
Turkish | `Language.Turkish`
Turkmen | `Language.Turkmen`
Ukrainan | `Language.Ukrainan`
Umbundu | `Language.Umbundu`
Urdu | `Language.Urdu`
Uzbek | `Language.Uzbek`
Vietnamese | `Language.Vietnamese`
Wagdi | `Language.Wagdi`
Waray-Waray | `Language.Waray_Waray`
Wolaytta | `Language.Wolaytta`
Wu | `Language.Wu`
Xhosa | `Language.Xhosa`
Xiang | `Language.Xiang`
Yao | `Language.Yao`
Yoruba | `Language.Yoruba`
Zhuang | `Language.Zhuang`
Zulu | `Language.Zulu`

#### Removed public APIs:

_No changes._

## Examples

The examples below illustrate the changes introduced in version 24.8.0:

### Recognize Turkish image

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
        Language = Language.Turkish,
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
