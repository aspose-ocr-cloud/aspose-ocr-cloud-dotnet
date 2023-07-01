using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System.Text;

namespace ExampleDotNet60v50.APIExamples
{
    public static class RecognizeLabelExample
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

                Console.WriteLine($"Sending sample file({imageFileName}) to RecognizeLabelApi...\n");

                RecognizeLabelApi apiInstance = new RecognizeLabelApi(clientId, clientSecret);
                var requestBody = new OCRRecognizeLabelBody(
                        image: File.ReadAllBytes(imageFileName),
                        settings: new OCRSettingsRecognizeLabel(resultType:ResultType.Text));
                string taskId = apiInstance.PostRecognizeLabel(requestBody);
                Console.WriteLine($"File successfully sent. Your credentials accepted. Your task ID is {taskId}");
                var response = apiInstance.GetRecognizeLabel(taskId);
                Console.WriteLine($"Respose received with status {response.TaskStatus.Value} \n\n" +
                    $" Your results:\n\n");
                response.Results.ForEach(res => Console.WriteLine(Encoding.UTF8.GetString(res.Data)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
