using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDotNet60v50.APIExamples
{
    public static class DewarpImageExample
    {

        /// <summary>
        /// Creates Dewarping API and processes image with cloud API
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public static void TryDewarpImageApi(string clientId, string clientSecret)
        {
            try
            {
                string imageFileName = "samples/dewarping.png";

                DewarpImageApi dewarpImageApi = new DewarpImageApi(clientId, clientSecret);

                Console.WriteLine($"The following action will reduce the number of API calls available to your " +
                    $"account in the current period.\n" +
                    $"Sending sample file ({imageFileName}) to DewarpImageApi...");


                byte[] imageData = File.ReadAllBytes(imageFileName);


                var taskId = dewarpImageApi.PostDewarpImage(new OCRDewarpImageBody(
                    image: imageData));

                Console.WriteLine($"File successfully sent. Your credentials accepted. Your task ID is {taskId}");

                Console.WriteLine($"Requesting results for task {taskId} ...");
                var result = dewarpImageApi.GetDewarpImage(taskId);
                byte[] imageFileData = result.Results[0].Data;
                string extension = result.Results[0].Type switch
                {
                    "ImagePNG" => "png",
                    _ => "png"
                };

                Console.WriteLine($"Respose received with status {result.TaskStatus.Value} \n\n" +
                        $" Your results will be saved to results\\{result.Id}.{extension}:\n\n");
                Directory.CreateDirectory("results");
                File.WriteAllBytes($"results/{result.Id}.{extension}", imageFileData);

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
