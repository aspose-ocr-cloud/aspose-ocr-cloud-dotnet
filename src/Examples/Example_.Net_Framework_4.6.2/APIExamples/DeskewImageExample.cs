﻿using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;

namespace ExampleDotNetStandard20v50.APIExamples
{
    public static class DeskewImageExample
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
                string imageFileName = "samples/skew_correction.png";

                Console.WriteLine($"Sending sample file({imageFileName}) to DeskewImageApi...\n");

                DeskewImageApi apiInstance = new DeskewImageApi(clientId, clientSecret);
                var requestBody = new OCRDeskewImageBody(
                        image: File.ReadAllBytes(imageFileName));
                string taskId = apiInstance.PostDeskewImage(requestBody);
                Console.WriteLine($"File successfully sent. Your credentials accepted. Your task ID is {taskId}");
                var response = apiInstance.GetDeskewImage(taskId);
                Console.WriteLine($"Respose received with status {response.TaskStatus.Value} \n\n" +
                    $" Your results will be saved to results\\{response.Id}.png:\n\n");
                File.WriteAllBytes($"results/{taskId}.png", response.Results[0].Data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
