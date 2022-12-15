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
            Console.WriteLine("This is Aspose OCR Cloud SDK for .Net 6.0 v22.12.0 example usage project");

            string clientId = "";
            string clientSecret = "";
            RecognizeImageExample.TryRecognizeImageApi(clientId, clientSecret);
            TextToSpeechExample.TryTextToSpeechApi(clientId, clientSecret);
            ImageProcessingExample.TryImageProcessingApi(clientId, clientSecret);
        }

    }
}
