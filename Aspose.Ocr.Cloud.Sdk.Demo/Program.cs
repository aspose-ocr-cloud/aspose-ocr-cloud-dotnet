using System;
using System.IO;
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
            
            string text="";
            Console.WriteLine("Send your file for recognition as request content");
            text = RecognizeFromContent(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Recognize text on any image in the World Wide Web");
            text = RecognizeFromUrl(conf);
            Console.WriteLine("-------------\n" + text + "\n-------------\n");

            Console.WriteLine("Put yor file in Aspose Storage and recognize it");
            text = RecognizeFromStorage(conf);
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
    }
}
