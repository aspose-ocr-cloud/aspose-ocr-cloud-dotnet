using Aspose.OCR.Cloud.SDK.Api;

namespace ExampleDotNet60v50.APIExamples
{
    public static class UtilitiesApiExample
    {

        /// <summary>
        /// Creates RecognizeImage API and processes sample image with cloud API
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public static void TryUtilitiesApi(string clientId, string clientSecret)
        {
            try
            {
                string taskId = "00000000-0000-0000-0000-000000000000";

                UtilitiesApi utilitieseApi = new UtilitiesApi(clientId, clientSecret);

                Console.WriteLine($"Requesting task status for task {taskId} ...");
                var result = utilitieseApi.GetTaskStatus(taskId);
                Console.WriteLine($"Respose received with status {result.TaskStatus.Value} \n\n ");

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
