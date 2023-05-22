/*
 * Aspose OCR Cloud 5.0 API
 *
 * Aspose OCR Cloud 5.0 API
 *
 * The version of the OpenAPI document: 5.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;

using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System.Threading;
using System.Text;
using System.Diagnostics;

namespace Aspose.OCR.Cloud.SDK.Test.Api
{
    /// <summary>
    ///  Class for testing PublicApi
    /// </summary>

    [TestFixture]
    public class PublicApiTests
    {
        public readonly Stopwatch timer = new Stopwatch();
        public const string clientId = "YOUR_CLIENT_ID";
        public const string clientSecret = "YOUR_CLIENT_ID";

        [SetUp]
        public void Setup()
        {
            Directory.CreateDirectory("results");
        }


        [Test]
        public void PublicBinarizeImageApiTest()
        {
            timer.Start();
            var apiInstance = new BinarizeImageApi(clientId, clientSecret);
            Console.WriteLine($"Api created at {timer.Elapsed}");

            var requestBody = new OCRBinarizeImageBody(
                    image: File.ReadAllBytes("samples/binarization.jpeg"));
            Console.WriteLine($"Request body created at {timer.Elapsed}");
            string taskId = apiInstance.PostBinarizeImage(requestBody);
            Console.WriteLine($"Post performed at {timer.Elapsed}");
            var response = apiInstance.GetBinarizeImage(taskId);
            Console.WriteLine($"Get performed at {timer.Elapsed}");
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.png", response.Results[0].Data);
        }


        [Test]
        public void PublicDeskewImageApiTest()
        {
            var apiInstance = new DeskewImageApi(clientId, clientSecret);

            var requestBody = new OCRDeskewImageBody(
                    image: File.ReadAllBytes("samples/latin_skew.png"));
            string taskId = apiInstance.PostDeskewImage(requestBody);
            var response = apiInstance.GetDeskewImage(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.png", response.Results[0].Data);
        }


        [Test]
        public void PublicDewarpImageApiTest()
        {
            var apiInstance = new DewarpImageApi(clientId, clientSecret);

            var requestBody = new OCRDewarpImageBody(
                    image: File.ReadAllBytes("samples/dewarping.png"));
            string taskId = apiInstance.PostDewarpImage(requestBody);
            var response = apiInstance.GetDewarpImage(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.png", response.Results[0].Data);
        }


        [Test]
        public void PublicUpscaleImageApiTest()
        {
            var apiInstance = new UpscaleImageApi(clientId, clientSecret);

            var requestBody = new OCRUpscaleImageBody(
                    image: File.ReadAllBytes("samples/upsampling.png"));
            string taskId = apiInstance.PostUpscaleImage(requestBody);
            var response = apiInstance.GetUpscaleImage(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.png", response.Results[0].Data);
        }


        [Test]
        public void PublicImageProcessingApiTest()
        {
            var apiInstance = new ImageProcessingApi(clientId, clientSecret);

            string taskId = "";

            using (Stream stream = File.OpenRead("samples/binarization.jpeg"))
            {
                taskId = apiInstance.PostBinarizationFile(stream);
            }
            Thread.Sleep(10000);
            var responseBinarization = apiInstance.GetResultTask(taskId);
            Assert.IsNotNull(responseBinarization);
            Assert.That(responseBinarization.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.png", responseBinarization.Results[0].Data);

            using (Stream stream = File.OpenRead("samples/latin_skew.png"))
            {
                taskId = apiInstance.PostBinarizationFile(stream);
            }
            var responseSkewCorrection = apiInstance.GetResultTask(taskId);
            Assert.IsNotNull(responseSkewCorrection);
            Assert.That(responseSkewCorrection.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.png", responseSkewCorrection.Results[0].Data);

            using (Stream stream = File.OpenRead("samples/dewarping.png"))
            {
                taskId = apiInstance.PostBinarizationFile(stream);
            }
            var responseDewarping = apiInstance.GetResultTask(taskId);
            Assert.IsNotNull(responseDewarping);
            Assert.That(responseDewarping.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.png", responseDewarping.Results[0].Data);

            using (Stream stream = File.OpenRead("samples/upsampling.png"))
            {
                taskId = apiInstance.PostBinarizationFile(stream);
            }
            var responseUpsampling = apiInstance.GetResultTask(taskId);
            Assert.IsNotNull(responseUpsampling);
            Assert.That(responseUpsampling.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.png", responseUpsampling.Results[0].Data);
        }


        [Test]
        public void PublicTextToSpeechApiTest()
        {
            var apiInstance = new TextToSpeechApi(clientId, clientSecret);

            var requestBody = new TTSBodyDeprecated(
                    text: "Text to speech test",
                    language: LanguageTTS.English,
                    resultType: ResultTypeTTS.Wav);
            string taskId = apiInstance.PostTextToSpeech(requestBody);
            var response = apiInstance.GetTextToSpeechResult(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.wav", response.Results[0].Data);
        }

        [Test]
        public void PublicConvertTextToSpeechApiTest()
        {
            var apiInstance = new ConvertTextToSpeechApi(clientId, clientSecret);

            var requestBody = new TTSBody(
                    text: "Text to speech test",
                    settings: new TTSSettings(
                    language: LanguageTTS.English,
                    resultType: ResultTypeTTS.Wav));
            string taskId = apiInstance.PostConvertTextToSpeech(requestBody);
            var response = apiInstance.GetConvertTextToSpeech(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.wav", response.Results[0].Data);
        }


        [Test]
        public void PublicDetectRegionsApiTest()
        {
            var apiInstance = new DetectRegionsApi(clientId, clientSecret);

            var requestBody = new OCRDetectRegionsBody(
                    image: File.ReadAllBytes("samples/greek.png"),
                    settings: new OCRSettingsDetectRegions(
                        makeSkewCorrect: false,
                        makeContrastCorrection: false,
                        dsrMode: DsrMode.Regions,
                        makeBinarization: false,
                        resultType: ResultType.Text));
            string taskId = apiInstance.PostDetectRegions(requestBody);
            var response = apiInstance.GetDetectRegions(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllText($"results/{taskId}.txt", Encoding.UTF8.GetString(response.Results[0].Data));
        }


        [Test]
        public void PublicDjvu2PdfApiTest()
        {
            var apiInstance = new DjVu2PDFApi(clientId, clientSecret);

            var requestBody = new OCRDjVu2PDFBody(File.ReadAllBytes(
                    "samples/latin.djvu"),
                    new OCRSettingsDjVu2PDF()
                    {
                        Language = Language.English,
                        MakeContrastCorrection = false,
                        DsrMode = DsrMode.NoDsrNoFilter,
                        ResultType = ResultType.Pdf,
                    });
            string taskId = apiInstance.PostDjVu2PDF(requestBody);
            Console.WriteLine($"Task ID: {taskId}");
            var response = apiInstance.GetDjVu2PDF(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.pdf", response.Results[0].Data);
        }


        [Test]
        public void PublicRecognizeImageApiTest()
        {
            var apiInstance = new RecognizeImageApi(clientId, clientSecret);

            var requestBody = new OCRRecognizeImageBody(
                    image: File.ReadAllBytes("samples/latin.png"),
                    settings: new OCRSettingsRecognizeImage(
                        language: Language.English,
                        makeBinarization: true,
                        makeSkewCorrect: true,
                        dsrMode: DsrMode.NoDsrNoFilter
                        ));
            string taskId = apiInstance.PostRecognizeImage(requestBody);
            Console.WriteLine($"Task ID: {taskId}");
            var response = apiInstance.GetRecognizeImage(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllText($"results/{taskId}.txt", Encoding.UTF8.GetString(response.Results[0].Data));
        }


        [Test]
        public void PublicRecognizePdfApiTest()
        {
            var apiInstance = new RecognizePdfApi(clientId, clientSecret);

            var requestBody = new OCRRecognizePdfBody(
                    image: File.ReadAllBytes("samples/latin.pdf"),
                    settings: new OCRSettingsRecognizePdf(
                        Language.English,
                        dsrMode: DsrMode.NoDsrNoFilter,
                        makeBinarization: true));
            string taskId = apiInstance.PostRecognizePdf(requestBody);
            Console.WriteLine($"Task ID: {taskId}");
            var response = apiInstance.GetRecognizePdf(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllText($"results/{taskId}.txt", Encoding.UTF8.GetString(response.Results[0].Data));
        }


        [Test]
        public void PublicRecognizeReceiptApiTest()
        {
            var apiInstance = new RecognizeReceiptApi(clientId, clientSecret);

            var requestBody = new OCRRecognizeReceiptBody(
                image: File.ReadAllBytes("samples/receipt.PNG"),
                settings: new OCRSettingsRecognizeReceipt(
                    language: Language.English,
                    dsrMode: DsrMode.DsrNoFilter,
                    resultType: ResultType.Text
                ));
            string taskId = apiInstance.PostRecognizeReceipt(requestBody);
            Console.WriteLine($"Task ID: {taskId}");
            Thread.Sleep(15000);
            var response = apiInstance.GetRecognizeReceipt(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllText($"results/{taskId}.txt", Encoding.UTF8.GetString(response.Results[0].Data));
        }



        [Test]
        public void PublicRecognizeRegionsApiTest()
        {
            var apiInstance = new RecognizeRegionsApi(clientId, clientSecret);

            var requestBody = new OCRRecognizeRegionsBody(
                    image: File.ReadAllBytes("samples/greek.png"),
                    settings: new OCRSettingsRecognizeRegions(
                        language: Language.Greek,
                        makeSkewCorrect: false,
                        makeContrastCorrection: false,
                        makeBinarization: false,
                        dsrMode: DsrMode.Regions,
                        regions: new List<OCRRegion>
                        {
                            new OCRRegion(new OCRRect(117, 81, 611, 98)), // only 1 region
                        }));
            string taskId = apiInstance.PostRecognizeRegions(requestBody);
            var response = apiInstance.GetRecognizeRegions(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllText($"results/{taskId}.txt", Encoding.UTF8.GetString(response.Results[0].Data));
        }


        [Test]
        public void PublicRecognizeTableApiTest()
        {
            var apiInstance = new RecognizeTableApi(clientId, clientSecret);

            var requestBody = new OCRRecognizeTableBody(
                    image: File.ReadAllBytes("samples/table_latin.png"),
                    settings: new OCRSettingsRecognizeTable(
                        language: Language.English,
                        dsrMode: DsrMode.NoDsrNoFilter,
                        resultTypeTable: ResultTypeTable.Text,
                        makeBinarization: false
                    ));
            string taskId = apiInstance.PostRecognizeTable(requestBody);
            var response = apiInstance.GetRecognizeTable(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllText($"results/{taskId}.txt", Encoding.UTF8.GetString(response.Results[0].Data));
        }
    }
}
