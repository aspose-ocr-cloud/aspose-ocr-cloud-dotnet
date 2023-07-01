using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDotNet60v50.APIExamples
{
    public static class TextToSpeechExample
    {

        /// <summary>
        /// Creates TextToSpeech API and processes text with cloud API
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public static void TryTextToSpeechApi(string clientId, string clientSecret)
        {
            try
            {
                string sampleText = "This is the sample text";

                ConvertTextToSpeechApi apiInstance = new ConvertTextToSpeechApi(clientId, clientSecret);

                var settings = new TTSBody(
                        text: sampleText,
                        settings: new TTSSettings(
                            language: LanguageTTS.English,
                            resultType: ResultTypeTTS.Wav));

                var taskId = apiInstance.PostConvertTextToSpeech(settings);
                Console.WriteLine($"File successfully sent. Your credentials accepted. Your task ID is {taskId}");

                Console.WriteLine($"Requesting results for task {taskId} ...");
                var result = apiInstance.GetConvertTextToSpeech(taskId);

                byte[] soundFile = result.Results[0].Data;
                string extension = result.Results[0].Type switch
                {
                    "WavFile" => "wav",
                    _ => "wav"
                };

                Console.WriteLine($"Respose received with status {result.TaskStatus.Value} \n\n" +
                    $" Your results will be saved to results\\{result.Id}.{extension}:\n\n");
                Directory.CreateDirectory("results");
                File.WriteAllBytes($"results/{result.Id}.{extension}", soundFile);

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
