using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDotNet60v50.APIExamples
{
    public static class Djvu2PdfExample
    {

        /// <summary>
        /// Creates RecognizeImage API and processes sample image with cloud API
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public static void TryDjvu2PdfApi(string clientId, string clientSecret)
        {
            try
            {
                string djvuFileName = "samples/latin.djvu";

                DjVu2PDFApi djvu2PdfApi = new DjVu2PDFApi(clientId, clientSecret);

                Console.WriteLine($"The following action will reduce the number of API calls available to your " +
                    $"account in the current period.\n" +
                    $"Sending sample file ({djvuFileName}) to DjVu2PdfApi...");

                byte[] imageData = File.ReadAllBytes(djvuFileName);

                var settings = new OCRSettingsDjVu2PDF();

                var taskId = djvu2PdfApi.PostDjVu2PDF(new OCRDjVu2PDFBody(
                    image: imageData,
                    settings: settings));
                Console.WriteLine($"File successfully sent. Your credentials accepted. Your task ID is {taskId}");

                Console.WriteLine($"Requesting results for task {taskId} ...");
                var result = djvu2PdfApi.GetDjVu2PDF(taskId);
                byte[] resultFile = result.Results[0].Data;
                string extension = result.Results[0].Type switch
                {
                    "Pdf" => "pdf",
                    _ => "pdf"
                };

                Console.WriteLine($"Respose received with status {result.TaskStatus.Value} \n\n" +
                    $" Your results will be saved to results\\{result.Id}.{extension}:\n\n");
                Directory.CreateDirectory("results");
                File.WriteAllBytes($"results/{result.Id}.{extension}", resultFile);

                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }
        }
    }
}
