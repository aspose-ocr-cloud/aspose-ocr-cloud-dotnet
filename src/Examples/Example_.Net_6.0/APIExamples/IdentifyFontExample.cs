using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System.Text;

namespace ExampleDotNet60v50.APIExamples
{
    public static class IdentifyFontExample
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
                string imageFileName = "samples/font_courier.png";

                Console.WriteLine($"Sending sample file({imageFileName}) to IdentifyFontApi...\n");

                IdentifyFontApi apiInstance = new IdentifyFontApi(clientId, clientSecret);
                var requestBody = new OCRRecognizeFontBody(
                        image: File.ReadAllBytes(imageFileName),
                        settings: new OCRSettingsRecognizeFont(resultType:ResultType.Text));
                string taskId = apiInstance.PostIdentifyFont(requestBody);
                Console.WriteLine($"File successfully sent. Your credentials accepted. Your task ID is {taskId}");
                var response = apiInstance.GetIdentifyFont(taskId);
                Console.WriteLine($"Respose received with status {response.TaskStatus.Value} \n\n" +
                    $" Your results:\n\n");
                response.Results.ForEach(res => Console.WriteLine(Encoding.UTF8.GetString(res.Data)));

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
