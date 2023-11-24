using ExampleDotNetStandard20v50.APIExamples;
using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is Aspose OCR Cloud SDK for .Net Standard 2.0 v23.11.0 example usage project");

        string clientId = "Your client_id";
        string clientSecret = "Your client_secret";
        RecognizeImageExample.TryRecognizeImageApi(clientId, clientSecret);
        TextToSpeechExample.TryTextToSpeechApi(clientId, clientSecret);
        BinarizeImageExample.Run(clientId, clientSecret);
        DewarpImageExample.Run(clientId, clientSecret);
        DeskewImageExample.Run(clientId, clientSecret);
        UpscaleImageExample.Run(clientId, clientSecret);
        IdentifyFontExample.Run(clientId, clientSecret);
        RecognizeLabelExample.Run(clientId, clientSecret);

        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();
    }
}