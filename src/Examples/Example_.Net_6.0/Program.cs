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
            Console.WriteLine("This is Aspose OCR Cloud SDK for .Net Standard 2.0 v23.12.0 example usage project");

            string clientId = "YOUR_CLIENT_ID";
            string clientSecret = "YOUR_CLIENT_SECRET";
            RecognizeImageExample.Run(clientId, clientSecret);
            TextToSpeechExample.Run(clientId, clientSecret);
            BinarizeImageExample.Run(clientId, clientSecret);
            DewarpImageExample.Run(clientId, clientSecret);
            DeskewImageExample.Run(clientId, clientSecret);
            UpscaleImageExample.Run(clientId, clientSecret);
            IdentifyFontExample.Run(clientId, clientSecret);
            RecognizeLabelExample.Run(clientId, clientSecret);
            RecognizeAndParseInvoiceExample.Run(clientId, clientSecret);
            UtilitiesApiExample.Run(clientId, clientSecret);
            TextToSpeechTrialExample.Run();
            RecognizeImageTrialExample.Run();

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }

    }
}
