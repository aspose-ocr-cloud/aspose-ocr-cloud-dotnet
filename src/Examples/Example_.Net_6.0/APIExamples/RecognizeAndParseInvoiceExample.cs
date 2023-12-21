using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System.Text;

namespace ExampleDotNet60v50.APIExamples
{
    public static class RecognizeAndParseInvoiceExample
    {

        /// <summary>
        /// Creates RecognizeAndParseInvoice API and processes image with cloud API
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public static void Run(string clientId, string clientSecret)
        {
            try
            {
                string imageFileName = "samples/invoice_english_01.jpg";

                Console.WriteLine($"Sending sample file({imageFileName}) to RecognizeAndParseInvoiceApi...\n");

                RecognizeAndParseInvoiceApi apiInstance = new RecognizeAndParseInvoiceApi(clientId, clientSecret);
                var requestBody = new OCRRecognizeAndParseInvoiceBody(
                        image: File.ReadAllBytes(imageFileName),
                        settings: new OCRSettingsRecognizeAndParseInvoice(resultType: ResultType.Text));
                string taskId = apiInstance.PostRecognizeAndParseInvoice(requestBody);
                Console.WriteLine($"File successfully sent. Your credentials accepted. Your task ID is {taskId}\nTaking a while before request result...");
                Thread.Sleep(10000);
                var response = apiInstance.GetRecognizeAndParseInvoice(taskId);
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
