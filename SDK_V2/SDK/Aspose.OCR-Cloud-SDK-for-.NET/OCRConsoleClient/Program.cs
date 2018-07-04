using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Aspose.Storage.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Com.Aspose.Ocr.Api;
using Com.Aspose.Ocr.Model;
using System.Diagnostics;

namespace OCRConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo current = new DirectoryInfo(Directory.GetCurrentDirectory());
            JObject Config;

            while (null != current && current.GetFiles("test_config.json").Length == 0)
                current = current.Parent;
            if (null == current) return;

            Config = JObject.Parse(System.IO.File.ReadAllText(Path.Combine(current.FullName, "test_config.json")));
            string DataFolder = Path.Combine(current.FullName, "Data");

            string name = "Dr._Jekyll_and_Mr._Hyde_Text.jpg";
            string language = "english";

            string APIKEY = Config["api_key"].ToString();
            string APPSID = Config["api_sid"].ToString();

            string BASEPATH = Config["base_path"].ToString();

            OcrApi ocrApi = new OcrApi(APIKEY, APPSID, BASEPATH);
            IOcrV2Api ocrApiV2 = new OcrV2Api(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

            Console.WriteLine($"Uploading file {name} ...");
            Com.Aspose.Storage.Model.ResponseMessage putCreateResponse = storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Path.Combine(DataFolder, name)));
            Debug.Assert("OK" == putCreateResponse.Status);

            Console.WriteLine($"{Environment.NewLine}{new string('=', Console.WindowWidth - 1)}{Environment.NewLine}");

            Console.WriteLine($"Recognizing {name} with OCRV1...");
            OCRResponse ocrResponseV1 = ocrApi.OcrGetRecognizeDocument(name, language, null, null, null, null, false, false, null, null);
            Debug.Assert("OK" == putCreateResponse.Status);
            Console.WriteLine($"OCRV1 Text:{ocrResponseV1.Text}");

            Console.WriteLine($"{Environment.NewLine}{new string('=', Console.WindowWidth - 1)}{Environment.NewLine}");

            Console.WriteLine($"Recognizing {name} with OCRV2...");
            OCRResponse ocrResponseV2 = ocrApiV2.OcrV2GetRecognizeDocument(name, null, null);
            Debug.Assert("OK" == putCreateResponse.Status);
            Console.WriteLine($"OCRV2 Text:{ocrResponseV1.Text}");
            
            Console.WriteLine($"{Environment.NewLine}{new string('=', Console.WindowWidth - 1)}{Environment.NewLine}{Environment.NewLine}");
            Console.WriteLine($"Press Any Key");
            Console.ReadKey();
        }
    }
}
