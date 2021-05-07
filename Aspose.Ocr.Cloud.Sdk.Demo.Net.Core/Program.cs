using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Ocr.Cloud.Sdk.Model;
using Aspose.Ocr.Cloud.Sdk.Model.Requests;

namespace Aspose.Ocr.Cloud.Sdk.Demo.Net.Core
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
            Console.WriteLine("Example #1:\nSend your file for recognition as request content");
            text = RecognizeFromContent(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Example #2:\nRecognize text on any image in the World Wide Web");
            text = RecognizeFromUrl(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Example #3:\nPut yor file in Aspose Storage and recognize it");
            text = RecognizeFromStorage(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Example #4:\nRecognize German or French");
            text = RecognizeFromStorageDeFr(conf);
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
            OCRRegionsRequestData requestData = new OCRRegionsRequestData() { Regions = mImageBook_of_Abraham_FirstPagePngRegions };
            OCRResponse response = api.OcrRegionsFromUrl(requestData, urlToFile);

            return response.Text;
        }

        static string RecognizeTableFromContent(Configuration conf)
        {
            string name = "table.png";
            using (FileStream fs = File.OpenRead(name))
            {
                OcrApi api = new OcrApi(conf);
                var request = new OCRTableRequestData() { MakeSkewCorrect = true };
                OCRTableResponse response = api.OcrTableFromContent(request, fs);

                //response.Excel, response.CSV
                return response.Text;
            }
        }

        static string RecognizeTableFromStorage(Configuration conf)
        {
            string name = "table.png";
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
