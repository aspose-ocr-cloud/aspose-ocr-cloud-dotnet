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
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Aspose.OCR.Cloud.SDK.Client;
using Aspose.OCR.Cloud.SDK.Client.Auth;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System.Text.RegularExpressions;
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


		public const string clientId = "Your client_id";
		public const string clientSecret = "Your client_secret";


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
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
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
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostDeskewImage(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            //Thread.Sleep(10000);
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
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostDewarpImage(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            //Thread.Sleep(10000);
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
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostUpscaleImage(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            //Thread.Sleep(10000);
            var response = apiInstance.GetUpscaleImage(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.png", response.Results[0].Data);
        }


        [Test]
        public void PublicConvertTextToSpeechTrialApiTest()
        {
            var apiInstance = new ConvertTextToSpeechTrialApi();

            var requestBody = new TTSBody(
                    text: "Text to speech test",
                    settings: new TTSSettings(
                    language: LanguageTTS.English,
                    resultType: ResultTypeTTS.Wav));
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostConvertTextToSpeechTrial(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            Thread.Sleep(3000);
            var response = apiInstance.GetConvertTextToSpeechTrial(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllBytes($"results/{taskId}.wav", response.Results[0].Data);
        }


        [Test]
        public void PublicDetectRegionsApiTest()
        {
            var apiInstance = new DetectRegionsApi(clientId, clientSecret);

            var requestBody = new OCRDetectRegionsBody(
                    image: File.ReadAllBytes("samples/greek.PNG"),
                    settings: new OCRSettingsDetectRegions(
                        makeSkewCorrect: false,
                        makeContrastCorrection: false,
                        dsrMode: DsrMode.Regions,
                        makeBinarization: false,
                        resultType: ResultType.Text));
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostDetectRegions(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            //Thread.Sleep(10000);
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
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostDjVu2PDF(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
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
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostRecognizeImage(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            Thread.Sleep(4000);
            var response = apiInstance.GetRecognizeImage(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllText($"results/{taskId}.txt", Encoding.UTF8.GetString(response.Results[0].Data));
        }

        
        [Test]
        public void PublicRecognizeImageTrialApiTest()
        {
            var apiInstance = new RecognizeImageTrialApi();

            var requestBody = new OCRRecognizeImageBody(
                    image: File.ReadAllBytes("samples/latin.png"),
                    settings: new OCRSettingsRecognizeImage(
                        language: Language.English,
                        makeBinarization: true,
                        makeSkewCorrect: true,
                        dsrMode: DsrMode.NoDsrNoFilter
                        ));
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostRecognizeImageTrial(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            var response = apiInstance.GetRecognizeImageTrial(taskId);
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
                        dsrMode: DsrMode.DsrPlusDetector,
                        makeBinarization: true,
                        makeSkewCorrect: false,
                        makeContrastCorrection:false));
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostRecognizePdf(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            //Thread.Sleep(10000);
            var response = apiInstance.GetRecognizePdf(taskId);
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
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostRecognizeReceipt(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            Thread.Sleep(40000);
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
                    image: File.ReadAllBytes("samples/greek.PNG"),
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
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostRecognizeRegions(requestBody);
            //Thread.Sleep(5000);
            var response = apiInstance.GetRecognizeRegions(taskId);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
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
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostRecognizeTable(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            //Thread.Sleep(5000);
            var response = apiInstance.GetRecognizeTable(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllText($"results/{taskId}.txt", Encoding.UTF8.GetString(response.Results[0].Data));
        }


        [Test]
        public void PublicRecognizeLabelApiTest()
        {
            var apiInstance = new RecognizeLabelApi(clientId, clientSecret);

            var requestBody = new OCRRecognizeLabelBody(
                    image: File.ReadAllBytes("samples/wild_screen_english_1.PNG"),
                    settings: new OCRSettingsRecognizeLabel(
                        language: Language.English,
                        resultType: ResultType.Text,
                        makeBinarization: false
                    ));
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostRecognizeLabel(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            var response = apiInstance.GetRecognizeLabel(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllText($"results/{taskId}.txt", Encoding.UTF8.GetString(response.Results[0].Data));
        }


        [Test]
        public void PublicIdentifyFontApiTest()
        {
            var apiInstance = new IdentifyFontApi(clientId, clientSecret);

            var requestBody = new OCRRecognizeFontBody(
                    image: File.ReadAllBytes("samples/font_courier.PNG"),
                    settings: new OCRSettingsRecognizeFont(
                        resultType: ResultType.Text,
                        makeBinarization: false
                    ));
            timer.Reset();
            timer.Start();
            string taskId = apiInstance.PostIdentifyFont(requestBody);
            Console.WriteLine($"Task ID: {taskId}\n Send in {timer.Elapsed} ");
            var response = apiInstance.GetIdentifyFont(taskId);
            Assert.IsNotNull(response);
            Assert.That(response.ResponseStatusCode == ResponseStatusCode.Ok);
            File.WriteAllText($"results/{taskId}.txt", Encoding.UTF8.GetString(response.Results[0].Data));
        }
    }
}















