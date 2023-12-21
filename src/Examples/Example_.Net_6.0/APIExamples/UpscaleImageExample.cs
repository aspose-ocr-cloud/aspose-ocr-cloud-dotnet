using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;

namespace ExampleDotNet60v50.APIExamples
{
    public static class UpscaleImageExample
    {

        /// <summary>
        /// Creates Binarization API and processes image with cloud API
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public static void Run(string clientId, string clientSecret)
        {
            try
            {
                string imageFileName = "samples/street_sign_01.jpg";

                Console.WriteLine($"Sending sample file({imageFileName}) to UpscaleImageApi...\n");

                UpscaleImageApi apiInstance = new UpscaleImageApi(clientId, clientSecret);
                var requestBody = new OCRUpscaleImageBody(
                        image: File.ReadAllBytes(imageFileName));
                string taskId = apiInstance.PostUpscaleImage(requestBody);
                Console.WriteLine($"File successfully sent. Your credentials accepted. Your task ID is {taskId}");
                var response = apiInstance.GetUpscaleImage(taskId);
                Console.WriteLine($"Respose received with status {response.TaskStatus.Value} \n\n" +
                    $" Your results will be saved to results\\{response.Id}.png:\n\n");
                File.WriteAllBytes($"results/{taskId}.png", response.Results[0].Data);

                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
