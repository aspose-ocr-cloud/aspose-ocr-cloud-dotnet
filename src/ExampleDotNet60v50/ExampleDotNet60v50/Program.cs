using System;
using System.IO;
using System.Text;
using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using ExampleDotNet60v50.APIExamples;

namespace NET_SDK_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Aspose OCR Cloud SDK for .Net 6.0 v23.5.0 example usage project");

            string clientId = "YOUR_CLIENT_ID";
            string clientSecret = "YOUR_CLIENT_SECRET";
            RecognizeImageExample.TryRecognizeImageApi(clientId, clientSecret);
            TextToSpeechExample.TryTextToSpeechApi(clientId, clientSecret);
            DewarpImageExample.TryDewarpImageApi(clientId, clientSecret);
            Djvu2PdfExample.TryDjvu2PdfApi(clientId, clientSecret);
        }

    }
}
