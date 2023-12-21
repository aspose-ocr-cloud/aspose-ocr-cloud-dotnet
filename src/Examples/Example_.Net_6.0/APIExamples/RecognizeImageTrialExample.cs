using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System.Text;

namespace ExampleDotNet60v50.APIExamples
{
    public static class RecognizeImageTrialExample
    {

        /// <summary>
        /// Creates RecognizeImageTrial API and processes sample image with cloud API
        /// </summary>
        public static void Run()
        {
            try
            {
                string imageFileName = "samples/lorem_ipsum.png";
                Console.WriteLine($"Sending sample file({imageFileName}) to RecognizeImageTrialApi...\n");

                RecognizeImageTrialApi api = new RecognizeImageTrialApi();

                byte[] imageData = File.ReadAllBytes(imageFileName);

                var settings = new OCRSettingsRecognizeImage(
                        language: Language.English,
                        resultType: ResultType.Text,
                        dsrMode: DsrMode.NoDsrNoFilter,
                        makeContrastCorrection: false);

                var taskId = api.PostRecognizeImageTrial(new OCRRecognizeImageBody(
                    image: imageData,
                    settings: settings));
                Console.WriteLine($"File successfully sent. Your task ID is {taskId}");

                UtilitiesApiExample.MonitorTaskStatus(taskId);

                Console.WriteLine($"Requesting results for task {taskId} ...");
                OCRResponse result = api.GetRecognizeImageTrial(taskId);
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
