using Aspose.OCR.Cloud.SDK.Api;
using Aspose.OCR.Cloud.SDK.Model;

namespace ExampleDotNet60v50.APIExamples
{
    public static class TextToSpeechTrialExample
    {

        /// <summary>
        /// Creates TextToSpeech API and processes text with cloud API
        /// </summary>
        public static void Run()
        {
            try
            {
                string sampleText = "This is the sample text";

                Console.WriteLine($"Sending sample text ({sampleText}) to ConvertTextToSpeechTrialApi...\n");

                ConvertTextToSpeechTrialApi apiInstance = new ConvertTextToSpeechTrialApi();

                var settings = new TTSBody(
                        text: sampleText,
                        settings: new TTSSettings(
                            language: LanguageTTS.English,
                            resultType: ResultTypeTTS.Wav));

                var taskId = apiInstance.PostConvertTextToSpeechTrial(settings);
                Console.WriteLine($"Text sample successfully sent. Your credentials accepted. Your task ID is {taskId}");

                Console.WriteLine($"Requesting results for task {taskId} ...");
                var result = apiInstance.GetConvertTextToSpeechTrial(taskId);

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

