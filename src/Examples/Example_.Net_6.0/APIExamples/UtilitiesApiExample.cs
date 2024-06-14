using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;

namespace ExampleDotNet60v50.APIExamples
{
    public static class UtilitiesApiExample
    {

        /// <summary>
        /// Creates RecognizeImage API and processes sample image with cloud API
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public static void Run(string clientId, string clientSecret)
        {
            try
            {
                string taskId = "00000000-0000-0000-0000-000000000000";

                Console.WriteLine($"Requesting task status ({taskId}) via UtilitiesApi...\n");

                UtilitiesApi utilitieseApi = new UtilitiesApi(clientId, clientSecret);

                Console.WriteLine($"Requesting task status for task {taskId} ...");
                OCRResponse result = utilitieseApi.GetTaskStatus(taskId);
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


        /// <summary>
        /// Uses Utilities API to get task status until it become completed or failed
        /// </summary>
        /// <param name="waitTime"></param>
        public static void MonitorTaskStatus(string taskid, float waitTime = 0.0f, string client_id = "", string client_secret = "")
        {
            int getTaskStatusRetriesCount = 0;
            int getTaskStatusMaxRetries = 20;
            OCRResponse getTaskStatusResponse = new OCRResponse();
            UtilitiesApi api = new UtilitiesApi(client_id, client_secret);
            while (getTaskStatusRetriesCount <= getTaskStatusMaxRetries
                & getTaskStatusResponse.TaskStatus != OCRTaskStatus.Completed
                & getTaskStatusResponse.TaskStatus != OCRTaskStatus.Error)
            {
                getTaskStatusRetriesCount += 1;
                Thread.Sleep((int)(1000 + waitTime * 1000));
                getTaskStatusResponse = api.GetTaskStatus(taskid);
                switch (getTaskStatusResponse.TaskStatus)
                {
                    case OCRTaskStatus.Pending:
                        break;
                    case OCRTaskStatus.Error:
                        throw new Exception("Task failed");
                }
            };
        }
    }
}
