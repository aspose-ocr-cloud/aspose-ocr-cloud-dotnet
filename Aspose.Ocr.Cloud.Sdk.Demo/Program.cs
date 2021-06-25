using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Aspose.Ocr.Cloud.Sdk.Model;
using Aspose.Ocr.Cloud.Sdk.Model.Requests;

namespace Aspose.Ocr.Cloud.Sdk.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration conf = new Configuration();
            conf.AppSid = "";
            conf.AppKey = "";

            if (string.IsNullOrEmpty(conf.AppSid) || string.IsNullOrEmpty(conf.AppKey))
                throw new Exception("Please, get and set your API keys. https://dashboard.aspose.cloud/#/");
            
            string text="";

            Console.WriteLine("Example #-1:\nSend your Receipt file for recognition as request content");
            text = RecognizeReceiptFromContent(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Example #-1:\nSend your Receipt file for recognition as request content");
            text = RecognizePdfFromContent(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Example #2:\nRecognize text on any image in the World Wide Web");
            text = RecognizeFromUrl(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Example #3:\nPut yor file in Aspose Storage and recognize it");
            text = RecognizeFromStorage(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Example #4.1:\nRecognize one of 21 supported languages");
            text = RecognizeFromStorageDeFr(conf);
            // You may also recognize it from Content or URL
            //text = RecognizeFromContentDeFr(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n" +
                              "Attention: UTF is not supported in windows console." +
                              "\n---------------------------------------------------\n");

            Console.WriteLine("Example #4.2:\nRecognize Arabic");
            text = RecognizeFromContentAr(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n" +
                              "Attention: UTF is not supported in windows console." +
                              "\n---------------------------------------------------\n");

            Console.WriteLine("Example #5:\nRecognize specific text regions (by coordinates) by URL");
            text = RecognizeRegionsFromUrl(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n" +
                              "Attention: UTF is not supported in windows console." +
                              "\n---------------------------------------------------\n");

            Console.WriteLine("Example #6:\nRecognize specific text regions (by coordinates) using local File Stream");
            text = RecognizeRegionsFromContent(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n" +
                              "Attention: UTF is not supported in windows console." +
                              "\n---------------------------------------------------\n");

            Console.WriteLine("Example #7:\nRecognize specific text regions (by coordinates) using Aspose Storage");
            text = RecognizeRegionsFromStorage(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n" +
                              "Attention: UTF is not supported in windows console." +
                              "\n---------------------------------------------------\n");

            Console.WriteLine("Example #8:\nSend your file for recognition as request content and Get PDF base64");
            text = RecognizeFromContentToPdf(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Example #9:\nSend your file for recognition as request content and Get PDF base64");
            text = RecognizeFromUrlToPdf(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Example #10:\nRecognize Table using local File System");
            text = RecognizeTableFromContent(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Example #11:\nRecognize Table using Aspose Storage");
            text = RecognizeTableFromStorage(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Example #12:\nRecognize Table using URL");
            text = RecognizeTableFromUrl(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.Write("Completed. Press any key..."); Console.ReadKey();
        }

        static string RecognizeFromUrl(Configuration conf)
        {
            string imgUri = @"https://upload.wikimedia.org/wikipedia/commons/2/2f/Book_of_Abraham_FirstPage.png";
            OcrApi api = new OcrApi(conf);
            var request = new PostOcrFromUrlOrContentRequest(null, imgUri, resultType:ResultType.Text);
            OCRResponse response = api.PostOcrFromUrlOrContent(request);

            return response.Text;
        }

        static string RecognizeFromContent(Configuration conf)
        {
            string name = "10.png"; 
            using (FileStream fs = File.OpenRead(name))
            {
                OcrApi api = new OcrApi(conf);
                var request = new PostOcrFromUrlOrContentRequest(fs, resultType: ResultType.Text, dsrMode:DsrMode.DsrAndFilter);
                OCRResponse response = api.PostOcrFromUrlOrContent(request);

                return response.Text;
            }
        }

        static string RecognizeFromStorage(Configuration conf)
        {
            string name = "10.png";

            OcrApi api = new OcrApi(conf);
            FileApi fileApi = new FileApi(conf /* or AppSid & AppKey*/);           

            fileApi.UploadFile(new UploadFileRequest(name, System.IO.File.OpenRead(name)));
            
            GetRecognizeDocumentRequest request = new GetRecognizeDocumentRequest(name);
            OCRResponse response = api.GetRecognizeDocument(request);

            return response.Text;
        }

        static string RecognizeFromContentDeFr(Configuration conf)
        {
            string name = "de_1.jpg";
            using (FileStream fs = File.OpenRead(name))
            {
                OcrApi api = new OcrApi(conf);
                var request = new PostOcrFromUrlOrContentRequest(fs, "", language:LanguageEnum.German);
                OCRResponse response = api.PostOcrFromUrlOrContent(request);

                return response.Text;
            }
        }
        
        static string RecognizeFromContentAr(Configuration conf)
        {
            string name = "ar2.png";
            using (FileStream fs = File.OpenRead(name))
            {
                OcrApi api = new OcrApi(conf);
                var request = new PostOcrFromUrlOrContentRequest(fs, "", language:LanguageEnum.Arabic);
                OCRResponse response = api.PostOcrFromUrlOrContent(request);

                return response.Text;
            }
        }

        static string RecognizeFromStorageDeFr(Configuration conf)
        {
            string name = "de_1.jpg";

            OcrApi api = new OcrApi(conf);
            FileApi fileApi = new FileApi(conf /* or AppSid & AppKey*/);           

            fileApi.UploadFile(new UploadFileRequest(name, System.IO.File.OpenRead(name)));
            
            GetRecognizeDocumentRequest request = new GetRecognizeDocumentRequest(name, language: LanguageEnum.German);
            OCRResponse response = api.GetRecognizeDocument(request);

            return response.Text;
        }

        static string RecognizeFromUrlDeFr(Configuration conf)
        {
            string url = "https://upload.wikimedia.org/wikipedia/commons/2/2f/Book_of_Abraham_FirstPage.png";
            
            OcrApi api = new OcrApi(conf);

            var request = new PostOcrFromUrlOrContentRequest(null, url, LanguageEnum.Spanish);
            OCRResponse response = api.PostOcrFromUrlOrContent(request);

            return response.Text;
        }

        static string RecognizeRegionsFromUrl(Configuration conf)
        {
            string urlToFile = @"https://upload.wikimedia.org/wikipedia/commons/2/2f/Book_of_Abraham_FirstPage.png";
            List<OCRRegion> mImageBook_of_Abraham_FirstPagePngRegions = new List<OCRRegion>()
            {
                new OCRRegion() {Order = 0, Rect = new OCRRect(209,28,283,39)},
                new OCRRegion() {Order = 1, Rect = new OCRRect(24,114,359,185)},
                new OCRRegion() {Order = 2, Rect = new OCRRect(21,201,356,451)},
                new OCRRegion() {Order = 3, Rect = new OCRRect(21,464,359,558)}
            };

            OcrApi api = new OcrApi(conf);
            OCRRegionsRequestData requestData = new OCRRegionsRequestData(){ Regions = mImageBook_of_Abraham_FirstPagePngRegions };
            OCRResponse response = api.OcrRegionsFromUrl(requestData, urlToFile);
            
            return response.Text;
        }

        static string RecognizeRegionsFromContent(Configuration conf)
        {
            List<OCRRegion> mImage5PngRegions = new List<OCRRegion>()
            {
                new OCRRegion() {Order = 0, Rect = new OCRRect(243,308,2095,964)},
                new OCRRegion() {Order = 1, Rect = new OCRRect(240,1045,2108,1826)},
                new OCRRegion() {Order = 2, Rect = new OCRRect(237,1916,2083,3180)}
            };

            string name = "5.png";
            using (FileStream fs = File.OpenRead(name))
            {
                OcrApi api = new OcrApi(conf);
                OCRRegionsRequestData requestData = new OCRRegionsRequestData()
                {
                    Language = LanguageEnum.English, 
                    Regions = mImage5PngRegions
                };
                OCRResponse response = api.OcrRegionsFromContent(requestData, fs);

                return response.Text;
            }
        }

        static string RecognizeRegionsFromStorage(Configuration conf)
        {
            List<OCRRegion> mImage5PngRegions = new List<OCRRegion>()
            {
                new OCRRegion() {Order = 0, Rect = new OCRRect(243,308,2095,964)},
                new OCRRegion() {Order = 1, Rect = new OCRRect(240,1045,2108,1826)},
                new OCRRegion() {Order = 2, Rect = new OCRRect(237,1916,2083,3180)}
            };

            string name = "5.png";
            using (FileStream fs = File.OpenRead(name))
            {
                OcrApi api = new OcrApi(conf);
                FileApi fileApi = new FileApi(conf /* or AppSid & AppKey*/);

                fileApi.UploadFile(new UploadFileRequest(name, System.IO.File.OpenRead(name)));

                OCRRegionsRequestDataStorage requestData = new OCRRegionsRequestDataStorage()
                {
                    Language = LanguageEnum.German,
                    Regions = mImage5PngRegions,
                    FileName = name
                };
                OCRResponse response = api.OcrRegionsFromContent(requestData, fs);

                return response.Text;
            }
        }

        static string RecognizeFromContentToPdf(Configuration conf)
        {
            string name = "10.png";
            using (FileStream fs = File.OpenRead(name))
            {
                OcrApi api = new OcrApi(conf);
                var request = new PostOcrFromUrlOrContentRequest(fs, resultType: ResultType.Pdf, dsrMode: DsrMode.DsrAndFilter);
                OCRResponse response = api.PostOcrFromUrlOrContent(request);

                return response.Pdf.Substring(0, 30) + " ..................";
            }
        }
        
        static string RecognizeFromUrlToPdf(Configuration conf)
        {
            string url = @"https://upload.wikimedia.org/wikipedia/commons/2/2f/Book_of_Abraham_FirstPage.png";
            OcrApi api = new OcrApi(conf);

            var request = new PostOcrFromUrlOrContentRequest(null, url, LanguageEnum.Spanish, ResultType.Pdf, DsrMode.NoDsrNoFilter);
            OCRResponse response = api.PostOcrFromUrlOrContent(request);

            return response.Text;
        }
        
        static string RecognizeReceiptFromContent(Configuration conf)
        {
            string name = "r11.jpg";
            using (FileStream fs = File.OpenRead(name))
            {
                OcrApi api = new OcrApi(conf);
                var request = new OCRReceiptRequestData(){ MakeSkewCorrect = false};
                OCRReceiptResponse response = api.OcrReceiptFromContent(request, fs);

                return response.Text;
            }
        }
        
        static string RecognizePdfFromContent(Configuration conf)
        {
            string name = "multi2.pdf"; 
            using (FileStream fs = File.OpenRead(name))
            {
                OcrApi api = new OcrApi(conf);
                var request = new OCRRequestData(){DsrMode = DsrMode.NoDsrNoFilter};
                OCRPDFResponse response = api.OcrPdfFromContent(request, fs);

                var all_text = response.ResultData.Aggregate(
                    "", (s, page) => 
                        s += page.OriginalText + "\n\n" + page.ImageOcrResults.Aggregate("", (s1, singleImageResult) => s1 += singleImageResult.ResultText +"\n\n") +"\n\n"); 
                
                return all_text;
            }
        }
        
        
        static string RecognizeTableFromContent(Configuration conf)
        {
            string name = "table.jpeg"; 
            using (FileStream fs = File.OpenRead(name))
            {
                OcrApi api = new OcrApi(conf);
                var request = new OCRTableRequestData() { MakeSkewCorrect = true};
                OCRTableResponse response = api.OcrTableFromContent(request, fs);

                //response.Excel, response.CSV
                return response.Text;
            }
        }

        static string RecognizeTableFromStorage(Configuration conf)
        {
            string name = "table.jpeg";
            using (FileStream fs = File.OpenRead(name))
            {
                OcrApi api = new OcrApi(conf);
                FileApi fileApi = new FileApi(conf /* or AppSid & AppKey*/);

                fileApi.UploadFile(new UploadFileRequest(name, System.IO.File.OpenRead(name)));

                OCRTableRequestDataStorage requestData = new OCRTableRequestDataStorage()
                {
                    FileName = name,
                    MakeSkewCorrect = true
                };
                OCRTableResponse response = api.OcrTableFromContent(requestData, fs);

                //response.Excel, response.CSV
                return response.Text;
            }
        }

        static string RecognizeTableFromUrl(Configuration conf)
        {
            string urlToFile = @"https://learnche.org/pid/_images/table-car-payments.png";

            OcrApi api = new OcrApi(conf);
            OCRTableRequestData requestData = new OCRTableRequestData() { MakeSkewCorrect = true };
            OCRTableResponse response = api.OcrTableFromUrl(requestData, urlToFile);

            return response.Text;
        }
    }
}
