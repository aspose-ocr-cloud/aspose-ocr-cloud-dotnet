using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDotNet60v50.APIExamples
{
    public static class RecognizeImageExample
    {

        /// <summary>
        /// Creates RecognizeImage API and processes sample image with cloud API
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public static void TryRecognizeImageApi(string clientId, string clientSecret)
        {
            try
            {
                string imageFileName = "samples/lorem_ipsum.png";

                RecognizeImageApi recognizeImageApi = new RecognizeImageApi(clientId, clientSecret);

                byte[] imageData = File.ReadAllBytes(imageFileName);

                var settings = new OCRSettingsRecognizeImage(
                        language: Language.English,
                        resultType: ResultType.Text,
                        dsrMode: DsrMode.NoDsrNoFilter,
                        makeContrastCorrection: false);

                var taskId = recognizeImageApi.PostRecognizeImage(new OCRRecognizeImageBody(
                    image: imageData,
                    settings: settings));
                Console.WriteLine($"File successfully sent. Your credentials accepted. Your task ID is {taskId}");

                Console.WriteLine($"Requesting results for task {taskId} ...");
                var result = recognizeImageApi.GetRecognizeImage(taskId);
                Console.WriteLine($"Respose received with status {result.TaskStatus.Value} \n\n Your results:\n\n");

                result.Results.ForEach(res => Console.WriteLine(Encoding.UTF8.GetString(res.Data)));
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
